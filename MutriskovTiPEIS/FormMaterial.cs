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
        int language = 0;
        public FormMaterial(int language)
        {
            InitializeComponent();
            this.language = language;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string selectCommand = "select MAX(Id) from Materials";
                var maxValue = selectValue(ConnectionString, selectCommand);
                if (Convert.ToString(maxValue) == "")
                    maxValue = 0;
                if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxPrice.Text) || String.IsNullOrEmpty(textBoxPrice1.Text) || comboBoxStorage.SelectedItem == null)
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
                if (Convert.ToDecimal(textBoxPrice.Text) < 0 || Convert.ToDecimal(textBoxPrice1.Text) < 0)
                {
                    if(language == 0)
                    {
                        MessageBox.Show("Цена не должна быть меньше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPrice.Text = "";
                        return;
                    }
                    else
                    {
                        MessageBox.Show("The price should not be less than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPrice.Text = "";
                        return;
                    }
                }
                string txtSQLQuery = "insert into Materials (id, Наименование, Цена, [Цена продажная], [Id склада]) values (" + (Convert.ToInt32(maxValue) + 1) + ", '" + textBoxName.Text + "'" + ", '" + Math.Round(Convert.ToDecimal(textBoxPrice.Text), 2, MidpointRounding.AwayFromZero) + "', '" + Math.Round(Convert.ToDecimal(textBoxPrice1.Text), 2, MidpointRounding.AwayFromZero) +"', " + comboBoxStorage.SelectedValue + ")";

                ExecuteQuery(txtSQLQuery);
                selectCommand = "select * from Materials";
                refreshForm(ConnectionString, selectCommand);
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxPrice1.Text = "";
                comboBoxStorage.SelectedItem = null;
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
            textBoxPrice1.Text = "";
            comboBoxStorage.SelectedItem = null;
        }

        private void FormMaterial_Load(object sender, EventArgs e)
        {
            ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            string selectCommand = "Select * from Materials";
            SelectTable(ConnectionString, selectCommand);
            if(language == 0)
            {
                this.Text = "Материалы";
                labelName.Text = "Наименование:";
                labelPrice.Text = "Цена:";
                labelSalePrice.Text = "Цена продажная:";
                labelStorage.Text = "Склад:";
                buttonAdd.Text = "Добавить";
                buttonChange.Text = "Обновить";
                buttonDelete.Text = "Удалить";
            }
            else
            {
                this.Text = "Materials";
                labelName.Text = "Name:";
                labelPrice.Text = "Price:";
                labelSalePrice.Text = "Sale price:";
                labelStorage.Text = "Storage:";
                buttonAdd.Text = "Add";
                buttonChange.Text = "Change";
                buttonDelete.Text = "Delete";
            }
        }

        private void SelectTable(string conString, string selectCmd)
        {
            SQLiteConnection connect = new SQLiteConnection(conString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Materials");
            dataGridView.DataSource = ds.Tables["Materials"];
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            string[] columns = new string[dataGridView.Columns.Count];
            for(int i = 0; i < columns.Length; i++)
            {
                columns[i] = dataGridView.Columns[i].HeaderText;
            }
            if(language == 1)
            {
                dataGridView.Columns[1].HeaderText = "Name";
                dataGridView.Columns[2].HeaderText = "Price";
                dataGridView.Columns[3].HeaderText = "Sale price";
                dataGridView.Columns[4].HeaderText = "Storage";
            }
            else
            {
                for(int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    dataGridView.Columns[i].HeaderText = columns[i];
                }
            }

            dataAdapter = new SQLiteDataAdapter("select * from Storages", connect);
            dataAdapter.Fill(ds, "Storages");
            comboBoxStorage.DataSource = ds.Tables["Storages"];
            comboBoxStorage.DisplayMember = "Наименование";
            comboBoxStorage.ValueMember = "id";
            comboBoxStorage.SelectedItem = null;
            connect.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedCells.Count == 0)
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
            string selectCommand = "delete from Materials where Id=" + valueId;
            changeValue(ConnectionString, selectCommand);
            selectCommand = "select * from Materials";
            refreshForm(ConnectionString, selectCommand);
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxPrice1.Text = "";
            comboBoxStorage.SelectedItem = null;
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
                if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxPrice.Text) || String.IsNullOrEmpty(textBoxPrice1.Text) || comboBoxStorage.SelectedItem == null)
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
                if (Convert.ToDecimal(textBoxPrice.Text) < 0 || Convert.ToDecimal(textBoxPrice1.Text) < 0)
                {
                    if (language == 0)
                    {
                        MessageBox.Show("Цена не должна быть меньше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPrice.Text = "";
                        return;
                    }
                    else
                    {
                        MessageBox.Show("The price should not be less than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPrice.Text = "";
                        return;
                    }
                }
                int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
                string valueId = dataGridView[0, CurrentRow].Value.ToString();
                string ChangeName = textBoxName.Text;
                string ChangePrice = textBoxPrice.Text;
                string ChangePrice1 = textBoxPrice1.Text;
                string ChangeStorageId = comboBoxStorage.SelectedValue.ToString();
                string selectCommand = "update Materials set Наименование='" + ChangeName + "', Цена='" + Math.Round(Convert.ToDecimal(ChangePrice), 2, MidpointRounding.AwayFromZero) + "', [Цена продажная]='" + Math.Round(Convert.ToDecimal(ChangePrice1), 2, MidpointRounding.AwayFromZero) + "', [Id склада]=" + ChangeStorageId + " where Id=" + valueId;
                changeValue(ConnectionString, selectCommand);
                selectCommand = "select * from Materials";
                refreshForm(ConnectionString, selectCommand);
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxPrice1.Text = "";
                comboBoxStorage.SelectedItem = null;
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
            var price1Id = dataGridView[3, CurrentRow].Value.ToString();
            var storageId = dataGridView[4, CurrentRow].Value.ToString();
            textBoxName.Text = nameId;
            textBoxPrice.Text = priceId;
            textBoxPrice1.Text = price1Id;
            comboBoxStorage.SelectedValue = storageId;
        }
    }
}
