using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace MutriskovTiPEIS
{
    public partial class FormMaterial : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private string sPath = Path.Combine(Application.StartupPath, "mydb.db");
        private string ConnectionString;
        public FormMaterial()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string selectCommand = "select MAX(Id) from Materials";
                var maxValue = selectValue(ConnectionString, selectCommand);
                if (Convert.ToString(maxValue) == "")
                    maxValue = 0;
                if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxPrice.Text))
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToDecimal(textBoxPrice.Text) < 0)
                {
                    MessageBox.Show("Цена не должна быть меньше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPrice.Text = "";
                    return;
                }
                string txtSQLQuery = "insert into Materials (id, Наименование, Цена) values (" + (Convert.ToInt32(maxValue) + 1) + ", '" + textBoxName.Text + "'" + ", '" + Math.Round(Convert.ToDecimal(textBoxPrice.Text), 2, MidpointRounding.AwayFromZero) + "')";

                ExecuteQuery(txtSQLQuery);
                selectCommand = "select * from Materials";
                refreshForm(ConnectionString, selectCommand);
                textBoxName.Text = "";
                textBoxPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExecuteQuery(string Query)
        {
            sql_con = new SQLiteConnection(ConnectionString + ";Compress=True;");
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = Query;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void refreshForm(string conString, string selectCmd)
        {
            SelectTable(conString, selectCmd);
            dataGridView.Update();
            dataGridView.Refresh();
            textBoxName.Text = "";
            textBoxPrice.Text = "";
        }

        private void FormMaterial_Load(object sender, EventArgs e)
        {
            ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            string selectCommand = "Select * from Materials";
            SelectTable(ConnectionString, selectCommand);
        }

        private void SelectTable(string conString, string selectCmd)
        {
            SQLiteConnection connect = new SQLiteConnection(conString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView.DataSource = ds;
            dataGridView.DataMember = ds.Tables[0].ToString();
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            connect.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Для удаления выберите элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string valueId = dataGridView[0, CurrentRow].Value.ToString();
            string selectCommand = "delete from Materials where Id=" + valueId;
            changeValue(ConnectionString, selectCommand);
            selectCommand = "select * from Materials";
            refreshForm(ConnectionString, selectCommand);
            textBoxName.Text = "";
            textBoxPrice.Text = "";
        }

        private void changeValue(string conString, string selectCmd)
        {
            var connect = new SQLiteConnection(conString);
            connect.Open();
            SQLiteTransaction trans;
            SQLiteCommand cmd = new SQLiteCommand();
            trans = connect.BeginTransaction();
            cmd.Connection = connect;
            cmd.CommandText = selectCmd;
            cmd.ExecuteNonQuery();
            trans.Commit();
            connect.Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Для обновления выберите элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
                string valueId = dataGridView[0, CurrentRow].Value.ToString();
                string ChangeName = textBoxName.Text;
                string ChangePrice = textBoxPrice.Text;
                if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxPrice.Text))
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToDecimal(textBoxPrice.Text) < 0)
                {
                    MessageBox.Show("Цена не должна быть меньше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPrice.Text = "";
                    return;
                }
                string selectCommand = "update Materials set Наименование='" + ChangeName + "', Цена='" + Math.Round(Convert.ToDecimal(ChangePrice), 2, MidpointRounding.AwayFromZero) + "' where Id=" + valueId;
                changeValue(ConnectionString, selectCommand);
                selectCommand = "select * from Materials";
                refreshForm(ConnectionString, selectCommand);
                textBoxName.Text = "";
                textBoxPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private object selectValue(string conString, string selectCmd)
        {
            var con = new SQLiteConnection(conString);
            con.Open();
            var command = new SQLiteCommand(selectCmd, con);
            var reader = command.ExecuteReader();
            object value = "";
            while (reader.Read())
            {
                value = reader[0];
            }
            con.Close();
            return value;
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string nameId = dataGridView[1, CurrentRow].Value.ToString();
            var priceId = dataGridView[2, CurrentRow].Value.ToString();
            textBoxName.Text = nameId;
            textBoxPrice.Text = priceId;
        }
    }
}
