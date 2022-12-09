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
    public partial class FormChartOfAccounts : Form
    {
        private SQLiteConnection sqlConn;
        private SQLiteCommand sqlCmd;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private string sPath = Path.Combine(Application.StartupPath, "mydb.db");
        int language = 0;

        public FormChartOfAccounts(int language)
        {
            InitializeComponent();
            this.language = language;
        }

        private void FormChartOfAccounts_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            string selectCommand = "Select * from ChartOfAccounts";
            SelectTable(ConnectionString, selectCommand);
            if(language == 0)
            {
                this.Text = "План счетов";
            }
            else
            {
                this.Text = "Chart of accounts";
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
            string[] columns = new string[dataGridView.Columns.Count];
            for(int i = 0; i < dataGridView.Columns.Count; i++)
            {
                columns[i] = dataGridView.Columns[i].HeaderText;
            }
            if(language == 1)
            {
                dataGridView.Columns[1].HeaderText = "Account";
                dataGridView.Columns[2].HeaderText = "Name";
                dataGridView.Columns[3].HeaderText = "Type";
                dataGridView.Columns[4].HeaderText = "Sub-konto1";
                dataGridView.Columns[5].HeaderText = "Sub-konto2";
                dataGridView.Columns[6].HeaderText = "Sub-konto3";
                dataGridView.Columns[7].HeaderText = "Comment";
            }
            else
            {
                for(int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    dataGridView.Columns[i].HeaderText = columns[i];
                }
            }
            connect.Close();
        }
    }
}
