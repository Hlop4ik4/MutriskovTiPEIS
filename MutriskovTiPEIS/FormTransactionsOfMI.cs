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
    public partial class FormTransactionsOfMI : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private string sPath = Path.Combine(Application.StartupPath, "mydb.db");
        private string ConnectionString;
        private int id;

        public FormTransactionsOfMI(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormTransactions_Load(object sender, EventArgs e)
        {
            ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            string selectCommand = "Select * from Transactions where [id операции реализации]=" + id;
            SelectTable(ConnectionString, selectCommand);
            this.Text = "Журнал проводок операции " + id;
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

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if(dateTimePickerFrom.Value <= dateTimePickerTo.Value)
            {
                string selectCmd = "Select * from Transactions where Дата between '" + dateTimePickerFrom.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dateTimePickerTo.Value.Date.ToString("yyyy-MM-dd") + "' and [id операции реализации] = " + id;
                SelectTable(ConnectionString, selectCmd);
            }
            else
            {
                MessageBox.Show("Неверный выбор дат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
