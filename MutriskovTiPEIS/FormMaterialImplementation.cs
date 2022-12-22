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
        private int StorageId;
        int language = 0;

        public FormMaterialImplementation(int language)
        {
            InitializeComponent();
            this.language = language;
        }

        private void FormMaterialImplementation_Load(object sender, EventArgs e)
        {
            ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            string selectCommand = "select * from MaterialsImplementationView";
            SelectTable(ConnectionString, selectCommand);
            if(language == 1) 
            {
                this.Text = "Material implementation";
                labelMaterial.Text = "Material:";
                labelBuyer.Text = "Buyer:";
                labelDate.Text = "Date:";
                labelMOL.Text = "MRP:";
                label3.Text = "Remains:";
                labelSum.Text = "Sum:";
                labelCount.Text = "Count:";
                labelStorage.Text = "Storage:";
                buttonAdd.Text = "Add";
                buttonChange.Text = "Change";
                buttonDelete.Text = "Delete";
                buttonTransactions.Text = "Check transactions";
                dateTimePicker1.CustomFormat = "MM-dd-yyyy HH:mm:ss";
            }
        }

        private void SelectTable(string conString, string selectCmd)
        {
            SQLiteConnection connect = new SQLiteConnection(conString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "MI");
            dataGridView.DataSource = ds.Tables["MI"];
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            string[] columns = new string[dataGridView.Columns.Count];
            for (int i = 0; i < columns.Length; i++)
            {
                columns[i] = dataGridView.Columns[i].HeaderText;
            }
            if (language == 1)
            {
                dataGridView.Columns[1].HeaderText = "MRP";
                dataGridView.Columns[2].HeaderText = "Material";
                dataGridView.Columns[3].HeaderText = "Storage";
                dataGridView.Columns[4].HeaderText = "Buyer";
                dataGridView.Columns[5].HeaderText = "Count";
                dataGridView.Columns[6].HeaderText = "Sum";
                dataGridView.Columns[7].HeaderText = "Date";
            }
            else
            {
                for(int i = 0; i < columns.Length; i++)
                {
                    dataGridView.Columns[i].HeaderText = columns[i];
                }
            }
            selectCmd = "Select * from Materials";
            dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            dataAdapter.Fill(ds, "Materials");
            if (ds.Tables.Count != 0)
            {
                comboBoxMaterial.DataSource = ds.Tables["Materials"];
                comboBoxMaterial.DisplayMember = "Наименование";
                comboBoxMaterial.ValueMember = "Id";
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
            cmd.Parameters.Add("@date", DbType.DateTime).Value = dateTimePicker1.Value;
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
            sql_cmd.Parameters.Add("@date", DbType.DateTime2).Value = dateTimePicker1.Value;
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
            textBoxStorage.Text = "";
            comboBoxBuyer.SelectedItem = null;
            comboBoxMaterial.SelectedItem = null;
            comboBoxMOL.SelectedItem = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string selectCommand = "select MAX(Id) from MaterialImplementation";
                var maxValue = selectValue(ConnectionString, selectCommand);
                if (Convert.ToString(maxValue) == "")
                    maxValue = 0;
                if (comboBoxBuyer.SelectedItem == null || comboBoxMaterial.SelectedItem == null || comboBoxMOL.SelectedItem == null ||  String.IsNullOrEmpty(textBoxCount.Text))
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
                if (Convert.ToInt32(textBoxCount.Text) > Convert.ToInt32(labelRemains.Text)) 
                {
                    if(language == 0)
                    {
                        MessageBox.Show("Количество не может быть больше остатков", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("The quantity cannot be more than the remainder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string txtSQLQuery = "insert into MaterialImplementation (Id, [Id МОЛа], [Id материала], [Id склада], [Id покупателя], Количество, Сумма, [Дата операции]) values (" + (Convert.ToInt32(maxValue) + 1) + ", " + Convert.ToInt32(comboBoxMOL.SelectedValue) + ", " + Convert.ToInt32(comboBoxMaterial.SelectedValue) + ", " + StorageId + ", " + Convert.ToInt32(comboBoxBuyer.SelectedValue) + ", " + Convert.ToInt32(textBoxCount.Text) + ", '" + Convert.ToDecimal(textBoxSum.Text) + "', @date)";

                ExecuteQuery(txtSQLQuery);

                selectCommand = "select MAX(id) from Transactions";
                var maxValT = selectValue(ConnectionString, selectCommand);
                if (Convert.ToString(maxValT) == "")
                    maxValT = 0;

                decimal taxes = Convert.ToDecimal(selectValue(ConnectionString, "select [Цена продажная] from Materials where id = " + comboBoxMaterial.SelectedValue.ToString())) * Convert.ToInt32(textBoxCount.Text) * 0.15m;

                txtSQLQuery = "insert into Transactions(id, [id операции реализации], [Счет дебет], [Субконто дебет1], [Субконто дебет2], [Субконто дебет3], [Счет кредит], [Субконто кредит1], [Субконто кредит2], [Субконто кредит3], Количество, Сумма, Дата)" +
                    " values" +
                    " (" + (Convert.ToInt32(maxValT) + 1) + ", " + (Convert.ToInt32(maxValue) + 1) + ", (Select [Номер счета] from ChartOfAccounts where [Номер счета] = '62'), " + Convert.ToInt32(comboBoxBuyer.SelectedValue) + ", (Select Субконто2 from ChartOfAccounts where [Номер счета] = '62'), (Select Субконто3 from ChartOfAccounts where [Номер счета] = '62'), (Select [Номер счета] from ChartOfAccounts where [Номер счета] = '91'), (Select Субконто1 from ChartOfAccounts where [Номер счета] = '91'), (Select Субконто2 from ChartOfAccounts where [Номер счета] = '91'), (Select Субконто3 from ChartOfAccounts where [Номер счета] = '91'), 1, '" + Math.Round((Convert.ToDecimal(selectValue(ConnectionString, "select [Цена продажная] from Materials where id = " + comboBoxMaterial.SelectedValue.ToString())) * Convert.ToInt32(textBoxCount.Text)), 2, MidpointRounding.AwayFromZero) + "', @date)," +
                    " (" + (Convert.ToInt32(maxValT) + 2) + ", " + (Convert.ToInt32(maxValue) + 1) + ", (Select [Номер счета] from ChartOfAccounts where [Номер счета] = '91'), (Select Субконто1 from ChartOfAccounts where [Номер счета] = '91'), (Select Субконто2 from ChartOfAccounts where [Номер счета] = '91'), (Select Субконто3 from ChartOfAccounts where [Номер счета] = '91'), (Select [Номер счета] from ChartOfAccounts where [Номер счета] = '10'), " + Convert.ToInt32(comboBoxMaterial.SelectedValue) + ", " + StorageId + ", " + Convert.ToInt32(comboBoxMOL.SelectedValue) + ", " + Convert.ToInt32(textBoxCount.Text) + ", '" + Math.Round((Convert.ToDecimal(selectValue(ConnectionString, "select Цена from Materials where id = " + comboBoxMaterial.SelectedValue.ToString())) * Convert.ToInt32(textBoxCount.Text)), 2, MidpointRounding.AwayFromZero) + "', @date)," +
                    " (" + (Convert.ToInt32(maxValT) + 3) + ", " + (Convert.ToInt32(maxValue) + 1) + ", (Select [Номер счета] from ChartOfAccounts where [Номер счета] = '91'), (Select Субконто1 from ChartOfAccounts where [Номер счета] = '91'), (Select Субконто2 from ChartOfAccounts where [Номер счета] = '91'), (Select Субконто3 from ChartOfAccounts where [Номер счета] = '91'), (Select [Номер счета] from ChartOfAccounts where [Номер счета] = '68'), (Select Субконто1 from ChartOfAccounts where [Номер счета] = '68'), (Select Субконто2 from ChartOfAccounts where [Номер счета] = '68'), (Select Субконто3 from ChartOfAccounts where [Номер счета] = '68'), 1, '" + Math.Round(taxes, 2, MidpointRounding.AwayFromZero) + "', @date)";


                ExecuteQuery(txtSQLQuery);

                selectCommand = "select * from MaterialsImplementationView";
                refreshForm(ConnectionString, selectCommand);
                textBoxCount.Clear();
                textBoxSum.Text = "";
                textBoxStorage.Text = "";
                comboBoxBuyer.SelectedItem = null;
                comboBoxMaterial.SelectedItem = null;
                comboBoxMOL.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            int count;
            Int32.TryParse(textBoxCount.Text, out count);
            if (count < 0)
            {
                if (language == 0)
                {
                    MessageBox.Show("Количество не может быть меньше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("The quantity cannot be less than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            CalcSum();
        }

        private void CalcSum()
        {
            if (comboBoxMaterial.SelectedValue != null && !(String.IsNullOrEmpty(textBoxCount.Text)))
            {
                try
                {
                    int count = Convert.ToInt32(textBoxCount.Text);
                    string selectCmd = "select [Цена продажная] from Materials where Id=" + Convert.ToInt32(comboBoxMaterial.SelectedValue);
                    var price = selectValue(ConnectionString, selectCmd);
                    textBoxSum.Text = Math.Round((count * Convert.ToDecimal(price)), 2, MidpointRounding.AwayFromZero).ToString();
                }
                catch (Exception ex)
                {
                    if(language == 0)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
            string selectCommand = "delete from MaterialImplementation where Id=" + valueId;
            changeValue(ConnectionString, selectCommand);
            selectCommand = "delete from Transactions where [id операции реализации]=" + valueId;
            changeValue(ConnectionString, selectCommand);
            selectCommand = "select * from MaterialsImplementationView";
            refreshForm(ConnectionString, selectCommand);
            textBoxCount.Text = "";
            textBoxSum.Text = "";
            textBoxStorage.Text = "";
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
                if (comboBoxBuyer.SelectedItem == null || comboBoxMaterial.SelectedItem == null || comboBoxMOL.SelectedItem == null ||  String.IsNullOrEmpty(textBoxCount.Text))
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
                int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
                string valueId = dataGridView[0, CurrentRow].Value.ToString();

                string changeCount = textBoxCount.Text;
                string changeSum = textBoxSum.Text;
                string changeMOLId = (comboBoxMOL.SelectedValue).ToString();
                string changeStorageId = StorageId.ToString();
                string changeBuyerId = (comboBoxBuyer.SelectedValue).ToString();
                string changeMaterialId = (comboBoxMaterial.SelectedValue).ToString();
                string changeDate = (dateTimePicker1.Value).ToString();

                string selectCommand = "update MaterialImplementation set [Id МОЛа]=" + changeMOLId + ", [Id материала]=" + changeMaterialId + ", [Id склада]=" + changeStorageId + ", [Id покупателя]=" + changeBuyerId + ", Количество=" + changeCount + ", Сумма='" + changeSum + "', [Дата операции]=@date where Id=" + valueId;
                changeValue(ConnectionString, selectCommand);
                selectCommand = "update Transactions set Количество=" + changeCount + ", Сумма='" + changeSum + "', Дата= @date where [id операции реализации]=" + valueId;
                changeValue(ConnectionString, selectCommand);
                selectCommand = "select * from MaterialsImplementationView";
                refreshForm(ConnectionString, selectCommand);
                textBoxCount.Text = "";
                textBoxSum.Text = "";
                textBoxStorage.Text = "";
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
            int id = Convert.ToInt32(dataGridView[0, CurrentRow].Value);
            string selectCmd = "select [Id МОЛа] from MaterialImplementation where id=" + id;
            int MOLId = Convert.ToInt32(selectValue(ConnectionString, selectCmd));
            selectCmd = "select [Id материала] from MaterialImplementation where id=" + id;
            int materialId = Convert.ToInt32(selectValue(ConnectionString, selectCmd));
            selectCmd = "select [Id склада] from MaterialImplementation where id=" + id;
            int storageId = Convert.ToInt32(selectValue(ConnectionString, selectCmd));
            selectCmd = "select [Id покупателя] from MaterialImplementation where id=" + id;
            int buyerId = Convert.ToInt32(selectValue(ConnectionString, selectCmd));
            string count = dataGridView[5, CurrentRow].Value.ToString();
            string sum = dataGridView[6, CurrentRow].Value.ToString();
            var date = Convert.ToDateTime(dataGridView[7, CurrentRow].Value);
            textBoxCount.Text = count;
            textBoxSum.Text = sum;
            comboBoxBuyer.SelectedValue = buyerId;
            comboBoxMaterial.SelectedValue = materialId;
            comboBoxMOL.SelectedValue = MOLId;
            textBoxStorage.Text = selectValue(ConnectionString, "select Наименование from Storages where Id=" + storageId).ToString();
            dateTimePicker1.Value = date;
        }

        private void buttonTransactions_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count == 0)
            {
                if(language == 0)
                {
                    MessageBox.Show("Для просмотра выберите элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("To view, select the item", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridView[0, CurrentRow].Value);
            var form = new FormTransactionsOfMI(id, language);
            form.Show();
        }

        private void comboBoxMaterial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(comboBoxMOL.SelectedValue != null)
            {
                int kt = 0;
                int dt = 0;
                Int32.TryParse(selectValue(ConnectionString, "select sum(Количество) from Transactions where [Счет дебет]=10 and [Субконто дебет1]='" + comboBoxMaterial.SelectedValue + "' and Дата < '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and [Субконто дебет3]=" + comboBoxMOL.SelectedValue).ToString(), out dt);
                Int32.TryParse(selectValue(ConnectionString, "select sum(Количество) from Transactions where [Счет кредит]=10 and [Субконто кредит1]='" + comboBoxMaterial.SelectedValue + "' and Дата < '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and [Субконто кредит3]=" + comboBoxMOL.SelectedValue).ToString(), out kt);
                labelRemains.Text = (dt - kt).ToString();
            }
            StorageId = Convert.ToInt32(selectValue(ConnectionString, "select [Id склада] from Materials where id=" + comboBoxMaterial.SelectedValue));
            textBoxStorage.Text = selectValue(ConnectionString, "select Наименование from Storages where id=" + StorageId).ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(comboBoxMaterial.SelectedItem != null && comboBoxMOL.SelectedItem != null)
            {
                int kt = 0;
                int dt = 0;
                Int32.TryParse(selectValue(ConnectionString, "select sum(Количество) from Transactions where [Счет дебет]=10 and [Субконто дебет1]='" + comboBoxMaterial.SelectedValue + "' and Дата < '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and [Субконто дебет3]=" + comboBoxMOL.SelectedValue).ToString(), out dt);
                Int32.TryParse(selectValue(ConnectionString, "select sum(Количество) from Transactions where [Счет кредит]=10 and [Субконто кредит1]='" + comboBoxMaterial.SelectedValue + "' and Дата < '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and [Субконто кредит3]=" + comboBoxMOL.SelectedValue).ToString(), out kt);
                labelRemains.Text = (dt - kt).ToString();
            }
        }

        private void comboBoxMOL_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxMaterial.SelectedItem != null)
            {
                int kt = 0;
                int dt = 0;
                Int32.TryParse(selectValue(ConnectionString, "select sum(Количество) from Transactions where [Счет дебет]=10 and [Субконто дебет1]='" + comboBoxMaterial.SelectedValue + "' and Дата < '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and [Субконто дебет3]=" + comboBoxMOL.SelectedValue).ToString(), out dt);
                Int32.TryParse(selectValue(ConnectionString, "select sum(Количество) from Transactions where [Счет кредит]=10 and [Субконто кредит1]='" + comboBoxMaterial.SelectedValue + "' and Дата < '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and [Субконто кредит3]=" + comboBoxMOL.SelectedValue).ToString(), out kt);
                labelRemains.Text = (dt - kt).ToString();
            }
        }
    }
}
