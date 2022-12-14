using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using NLog;

namespace MutriskovTiPEIS
{
    public partial class FormBuyer : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private string sPath = Path.Combine(Application.StartupPath, "mydb.db");
        private string ConnectionString;
        int language = 0;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public FormBuyer(int language)
        {
            InitializeComponent();
            this.language = language;
        }

        private void FormBuyer_Load(object sender, EventArgs e)
        {
            ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            string selectCommand = "Select * from Buyer";
            SelectTable(ConnectionString, selectCommand);
            if (language == 0)
            {
                buttonAdd.Text = "Добавить";
                buttonChange.Text = "Изменить";
                buttonDelete.Text = "Удалить";
                labelName.Text = "ФИО:";
                this.Text = "Покупатели";
            }
            else
            {
                buttonAdd.Text = "Add";
                buttonChange.Text = "Change";
                buttonDelete.Text = "Delete";
                labelName.Text = "Name:";
                this.Text = "Buyers";
            }
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
            if (language == 1)
            {
                dataGridView.Columns[1].HeaderText = "Name";
            }
            else
            {
                dataGridView.Columns[1].HeaderText = "ФИО";
            }
            connect.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string selectCommand = "select MAX(Id) from Buyer";
            var maxValue = selectValue(ConnectionString, selectCommand);
            if (Convert.ToString(maxValue) == "")
                maxValue = 0;
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                if (language == 0)
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string txtSQLQuery = "insert into Buyer (id, ФИО) values (" + (Convert.ToInt32(maxValue) + 1) + ", '" + textBoxName.Text + "')";

            ExecuteQuery(txtSQLQuery);
            selectCommand = "select * from Buyer";
            logger.Info("Добавлен новый покупатель, id: " + (Convert.ToInt32(maxValue) + 1));
            refreshForm(ConnectionString, selectCommand);
            
            textBoxName.Text = "";
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
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count == 0)
            {
                if (language == 0)
                {
                    MessageBox.Show("Для удаления выберите элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("To delete, select the item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string valueId = dataGridView[0, CurrentRow].Value.ToString();
            string selectCommand = "delete from Buyer where Id=" + valueId;
            changeValue(ConnectionString, selectCommand);
            selectCommand = "select * from Buyer";
            logger.Info("Удален покупатель, id: " + valueId);
            refreshForm(ConnectionString, selectCommand);
            
            textBoxName.Text = "";
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
            if (dataGridView.SelectedCells.Count == 0)
            {
                if (language == 0)
                {
                    MessageBox.Show("Для обновления выберите элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("To update, select the item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string valueId = dataGridView[0, CurrentRow].Value.ToString();
            string ChangeName = textBoxName.Text;
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                if (language == 0)
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string selectCommand = "update Buyer set ФИО='" + ChangeName + "' where Id=" + valueId;
            changeValue(ConnectionString, selectCommand);
            selectCommand = "select * from Buyer";
            logger.Info("Обновлен покупатель покупатель, id: " + valueId + ", изменено ФИО на " + ChangeName);
            refreshForm(ConnectionString, selectCommand);
            
            textBoxName.Text = "";
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
            textBoxName.Text = nameId;
        }

        private void FormBuyer_FormClosed(object sender, FormClosedEventArgs e)
        {
            NLog.LogManager.Shutdown();
        }
    }
}
