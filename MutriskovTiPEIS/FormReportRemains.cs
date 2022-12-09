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
    public partial class FormReportRemains : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private string sPath = Path.Combine(Application.StartupPath, "mydb.db");
        private string ConnectionString;
        int language = 0;
        public FormReportRemains(int language)
        {
            InitializeComponent();
            this.language = language;
        }

        private void FormReportRemains_Load(object sender, EventArgs e)
        {
            ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            if (language == 1)
            {
                this.Text = "Remains report";
                groupBox1.Text = "Create report";
                label1.Text = "In date from";
                label2.Text = "to";
                label3.Text = "Total count of remains:";
                label4.Text = "Total sum of remains:";
                buttonReport.Text = "Remains report";
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value <= dateTimePickerTo.Value)
            {
                string selectCmd = "select Id as [id материала], Наименование, ((select sum(Количество) from Transactions as T where T.'Счет дебет'=10 and T.'Субконто дебет1'=M.Id and Дата between '" + dateTimePickerFrom.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "') - (select sum(Количество) from Transactions as T where T.'Счет кредит'=10 and T.'Субконто кредит1'=M.Id and Дата between '" + dateTimePickerFrom.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "')) as Остатки, ((select sum(Сумма) from Transactions as T where T.'Счет дебет'=10 and T.'Субконто дебет1'=M.Id and Дата between '" + dateTimePickerFrom.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "') - (select sum(Сумма) from Transactions as T where T.'Счет кредит'=10 and T.'Субконто кредит1'=M.Id and Дата between '" + dateTimePickerFrom.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "')) as [Сумма остатка] from Materials as M where ((select sum(Сумма) from Transactions as T where T.'Счет дебет'=10 and T.'Субконто дебет1'=M.Id and Дата between '" + dateTimePickerFrom.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "') - (select sum(Сумма) from Transactions as T where T.'Счет кредит'=10 and T.'Субконто кредит1'=M.Id and Дата between '" + dateTimePickerFrom.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "')) is not null";
                SelectTable(ConnectionString, selectCmd);
            }
            else
            {
                if (language == 0)
                {
                    MessageBox.Show("Неверный выбор дат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Incorrect date selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            int sumCount = 0;
            decimal sumSum = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                sumCount += Convert.ToInt32(dataGridView.Rows[i].Cells[2].Value);
                sumSum += Convert.ToDecimal(dataGridView.Rows[i].Cells[3].Value);
            }
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            if (language == 1)
            {
                dataGridView.Columns[0].HeaderText = "Material id";
                dataGridView.Columns[1].HeaderText = "Name";
                dataGridView.Columns[2].HeaderText = "Count of remains";
                dataGridView.Columns[3].HeaderText = "Sum of remains";
            }
            labelCount.Text = sumCount.ToString();
            labelSum.Text = sumSum.ToString();
            connect.Close();
        }
    }
}
