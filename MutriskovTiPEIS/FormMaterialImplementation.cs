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

namespace MutriskovTiPEIS
{
    public partial class FormMaterialImplementation : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private string sPath = Path.Combine(Application.StartupPath, "mydb.db");
        private string ConnectionString;
        public FormMaterialImplementation()
        {
            InitializeComponent();
        }

        private void FormMaterialImplementation_Load(object sender, EventArgs e)
        {
            ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            string selectCommand = "Select * from MaterialImplementation";
            SelectTable(ConnectionString, selectCommand);
        }

        private void SelectTable(string conString, string selectCmd)
        {
            SQLiteConnection connect = new SQLiteConnection(conString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "MI");
            dataGridView.DataSource = ds.Tables["MI"];
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            selectCmd = "Select * from Materials";
            dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            dataAdapter.Fill(ds, "Materials");
            if(ds.Tables.Count != 0)
            {
                comboBoxMaterial.DataSource = ds.Tables["Materials"];
                comboBoxMaterial.DisplayMember = ds.Tables["Materials"].Columns["Наименование"].ColumnName;
                comboBoxMaterial.ValueMember = ds.Tables["Materials"].Columns["Id"].ColumnName;
                comboBoxMaterial.SelectedItem = null;
            }
            selectCmd = "Select * from Buyer";
            dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            dataAdapter.Fill(ds, "Buyer");
            if (ds.Tables.Count != 0)
            {
                comboBoxBuyer.DataSource = ds.Tables["Buyer"];
                comboBoxBuyer.DisplayMember = "ФИО";
                comboBoxBuyer.ValueMember = "id";
                comboBoxBuyer.SelectedItem = null;
            }
            selectCmd = "Select * from MOL";
            dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            dataAdapter.Fill(ds, "MOL");
            if (ds.Tables.Count != 0)
            {
                comboBoxMOL.DataSource = ds.Tables["MOL"];
                comboBoxMOL.DisplayMember = "ФИО";
                comboBoxMOL.ValueMember = "id";
                comboBoxMOL.SelectedItem = null;
            }
            selectCmd = "Select * from Storages";
            dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            dataAdapter.Fill(ds, "Storages");
            if (ds.Tables.Count != 0)
            {
                comboBoxStorage.DataSource = ds.Tables["Storages"];
                comboBoxStorage.DisplayMember = "Наименование";
                comboBoxStorage.ValueMember = "id";
                comboBoxStorage.SelectedItem = null;
            }
            connect.Close();
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
            cmd.Parameters.Add("@date", DbType.Date).Value = dateTimePicker1.Value.Date;
            cmd.ExecuteNonQuery();
            trans.Commit();
            connect.Close();
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

        private void ExecuteQuery(string Query)
        {
            sql_con = new SQLiteConnection(ConnectionString + ";Compress=True;");
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = Query;
            sql_cmd.Parameters.Add("@date", DbType.Date).Value = dateTimePicker1.Value.Date;
            sql_con.Open();
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void refreshForm(string conString, string selectCmd)
        {
            SelectTable(conString, selectCmd);
            dataGridView.Update();
            dataGridView.Refresh();
            textBoxCount.Text = "";
            textBoxSum.Text = "";
            comboBoxStorage.SelectedItem = null;
            comboBoxBuyer.SelectedItem = null;
            comboBoxMaterial.SelectedItem = null;
            comboBoxMOL.SelectedItem = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string selectCommand = "select MAX(Id) from MaterialImplementation";
            var maxValue = selectValue(ConnectionString, selectCommand);
            if (Convert.ToString(maxValue) == "")
                maxValue = 0;
            if(comboBoxBuyer.SelectedItem == null || comboBoxMaterial.SelectedItem == null || comboBoxMOL.SelectedItem == null || comboBoxStorage.SelectedItem == null || String.IsNullOrEmpty(textBoxCount.Text)) 
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string txtSQLQuery = "insert into MaterialImplementation (Id, [Id МОЛа], [Id материала], [Id склада], [Id покупателя], Количество, Сумма, [Дата операции]) values (" + (Convert.ToInt32(maxValue) + 1) + ", " + Convert.ToInt32(comboBoxMOL.SelectedValue) + ", " + Convert.ToInt32(comboBoxMaterial.SelectedValue) + ", " + Convert.ToInt32(comboBoxStorage.SelectedValue) + ", " + Convert.ToInt32(comboBoxBuyer.SelectedValue) + ", " + Convert.ToInt32(textBoxCount.Text) + ", '" + Convert.ToDecimal(textBoxSum.Text) + "', @date)";

            ExecuteQuery(txtSQLQuery);

            selectCommand = "select MAX(id) from Transactions";
            var maxValT = selectValue(ConnectionString, selectCommand);
            if (Convert.ToString(maxValT) == "")
                maxValT = 0;

            txtSQLQuery = "insert into Transactions(id, [id операции реализации], [Счет дебет], [Субконто дебет1], [Субконто дебет2], [Субконто дебет3], [Счет кредит], [Субконто кредит1], [Субконто кредит2], [Субконто кредит3], Количество, Сумма, Дата) values (" + (Convert.ToInt32(maxValT) + 1) + ", " + (Convert.ToInt32(maxValue) + 1) + ", " + Convert.ToInt32(selectValue(ConnectionString, "Select [Номер счета] from ChartOfAccounts where [Номер счета] = '10'")) + ", '', '', '', " + Convert.ToInt32(selectValue(ConnectionString, "Select [Номер счета] from ChartOfAccounts where [Номер счета] = '10'")) + ", '', '', '', " + Convert.ToInt32(textBoxCount.Text) + ", '" + Convert.ToDecimal(textBoxSum.Text) + "', @date)";

            ExecuteQuery(txtSQLQuery);

            selectCommand = "select * from MaterialImplementation";
            refreshForm(ConnectionString, selectCommand);
            textBoxCount.Text = "";
            textBoxSum.Text = "";
            comboBoxStorage.SelectedItem = null;
            comboBoxBuyer.SelectedItem = null;
            comboBoxMaterial.SelectedItem = null;
            comboBoxMOL.SelectedItem = null;
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void CalcSum()
        {
            if(comboBoxMaterial.SelectedValue != null && !(String.IsNullOrEmpty(textBoxCount.Text)))
            {
                try
                {
                    int count = Convert.ToInt32(textBoxCount.Text);
                    string selectCmd = "select Цена from Materials where Id=" + Convert.ToInt32(comboBoxMaterial.SelectedValue);
                    var price = selectValue(ConnectionString, selectCmd);
                    textBoxSum.Text = Math.Round((count * Convert.ToDecimal(price)), 2, MidpointRounding.AwayFromZero).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Для удаления выберите элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string valueId = dataGridView[0, CurrentRow].Value.ToString();
            string selectCommand = "delete from MaterialImplementation where Id=" + valueId;
            changeValue(ConnectionString, selectCommand);
            selectCommand = "select * from MaterialImplementation";
            refreshForm(ConnectionString, selectCommand);
            textBoxCount.Text = "";
            textBoxSum.Text = "";
            comboBoxStorage.SelectedItem = null;
            comboBoxBuyer.SelectedItem = null;
            comboBoxMaterial.SelectedItem = null;
            comboBoxMOL.SelectedItem = null;
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
                if (comboBoxBuyer.SelectedItem == null || comboBoxMaterial.SelectedItem == null || comboBoxMOL.SelectedItem == null || comboBoxStorage.SelectedItem == null || String.IsNullOrEmpty(textBoxCount.Text))
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
                string valueId = dataGridView[0, CurrentRow].Value.ToString();

                string changeCount = textBoxCount.Text;
                string changeSum = textBoxSum.Text;
                string changeMOLId = (comboBoxMOL.SelectedValue).ToString();
                string changeStorageId = (comboBoxStorage.SelectedValue).ToString();
                string changeBuyerId = (comboBoxBuyer.SelectedValue).ToString();
                string changeMaterialId = (comboBoxMaterial.SelectedValue).ToString();
                string changeDate = (dateTimePicker1.Value).ToString();

                string selectCommand = "update MaterialImplementation set [Id МОЛа]=" + changeMOLId + ", [Id материала]=" + changeMaterialId + ", [Id склада]=" + changeStorageId +", [Id покупателя]=" + changeBuyerId + ", Количество=" + changeCount + ", Сумма='" + changeSum + "', [Дата операции]=@date where Id=" + valueId;
                changeValue(ConnectionString, selectCommand);
                selectCommand = "select * from MaterialImplementation";
                refreshForm(ConnectionString, selectCommand);
                textBoxCount.Text = "";
                textBoxSum.Text = "";
                comboBoxStorage.SelectedItem = null;
                comboBoxBuyer.SelectedItem = null;
                comboBoxMaterial.SelectedItem = null;
                comboBoxMOL.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            int MOLId = Convert.ToInt32(dataGridView[1, CurrentRow].Value);
            int materialId = Convert.ToInt32(dataGridView[2, CurrentRow].Value);
            int storageId = Convert.ToInt32(dataGridView[3, CurrentRow].Value);
            int buyerId = Convert.ToInt32(dataGridView[4, CurrentRow].Value);
            string count = dataGridView[5, CurrentRow].Value.ToString();
            string sum = dataGridView[6, CurrentRow].Value.ToString();
            var date = Convert.ToDateTime(dataGridView[7, CurrentRow].Value);
            textBoxCount.Text = count;
            textBoxSum.Text = sum;
            comboBoxBuyer.SelectedValue = buyerId;
            comboBoxMaterial.SelectedValue = materialId;
            comboBoxMOL.SelectedValue = MOLId;
            comboBoxStorage.SelectedValue = storageId;
            dateTimePicker1.Value = date;
        }
    }
}
