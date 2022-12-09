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
    public partial class FormReportMaterialSale : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private string sPath = Path.Combine(Application.StartupPath, "mydb.db");
        private string ConnectionString;
        int language = 0;
        public FormReportMaterialSale(int language)
        {
            InitializeComponent();
            this.language = language;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value <= dateTimePickerTo.Value)
            {
                string selectCmd = "select [Субконто дебет1] as [id покупателя], (select ФИО from Buyer as B where B.id=T.'Субконто дебет1') as ФИО, (select Сумма from Transactions where id=T.id) as [Сумма выручки], (select Сумма from Transactions where id=T.id + 1) as [Сумма себестоимости] from Transactions as T where [Счет дебет]=62 and Дата between '" + dateTimePickerFrom.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                SelectTable(ConnectionString, selectCmd);
            }
            else
            {
                if(language == 0)
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
            dataGridView.Columns.Clear();
            dataGridView.DataSource = ds;
            dataGridView.DataMember = ds.Tables[0].ToString();
            dataGridView.Columns.Add("сум", "Сумма прибыли/убыли");
            decimal sumOfGain = 0;
            decimal sumOfCost = 0;
            decimal sumOfDiff = 0;
            for(int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Cells[dataGridView.Rows[i].Cells.Count - 1].Value = Convert.ToDecimal(dataGridView.Rows[i].Cells[dataGridView.Rows[i].Cells.Count - 3].Value) - Convert.ToDecimal(dataGridView.Rows[i].Cells[dataGridView.Rows[i].Cells.Count - 2].Value);
                sumOfGain += Convert.ToDecimal(dataGridView.Rows[i].Cells[2].Value);
                sumOfCost += Convert.ToDecimal(dataGridView.Rows[i].Cells[3].Value);
                sumOfDiff += Convert.ToDecimal(dataGridView.Rows[i].Cells[4].Value);
            }
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            if(language == 1)
            {
                dataGridView.Columns[0].HeaderText = "Buyer id";
                dataGridView.Columns[1].HeaderText = "Name";
                dataGridView.Columns[2].HeaderText = "Gain";
                dataGridView.Columns[3].HeaderText = "Purchase price";
                dataGridView.Columns[4].HeaderText = "Profit/loss";
            }
            labelCost.Text = sumOfCost.ToString();
            labelDiff.Text = sumOfDiff.ToString();
            labelGain.Text = sumOfGain.ToString();
            connect.Close();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            if(language == 1)
            {
                this.Text = "Report material sale";
                groupBox1.Text = "Create report";
                label1.Text = "In date from";
                label2.Text = "to";
                label3.Text = "Total gain:";
                label4.Text = "Total purchase price:";
                label5.Text = "Total profit";
                buttonReport.Text = "Sales report";
            }
        }
    }
}
