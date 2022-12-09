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
        int language = 0;

        public FormTransactionsOfMI(int id, int language)
        {
            InitializeComponent();
            this.id = id;
            this.language = language;
        }

        private void FormTransactions_Load(object sender, EventArgs e)
        {
            ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            string selectCommand = "Select * from Transactions where [id операции реализации]=" + id;
            SelectTable(ConnectionString, selectCommand);
            this.Text = "Журнал проводок операции " + id;
            if(language == 1)
            {
                this.Text = "Transaction log of operation " + id;
            }
        }

        private void SelectTable(string conString, string selectCmd)
        {
            SQLiteConnection connect = new SQLiteConnection(conString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            DataSet ds = new DataSet();
            for (int i = 0; i < Convert.ToInt32(selectValue(conString, "select count(*) from Transactions")); i++)
            {
                if (selectValue(conString, "select [Счет кредит] from Transactions where id=" + (i + 1)).ToString() == "60.1")
                {
                    dataAdapter = new SQLiteDataAdapter("select id, Дата, [id операции реализации], [Счет дебет], (select Наименование from Materials as M where M.Id = T.'Субконто дебет1') as [Субконто дебет1], (select Наименование from Storages as S where S.Id = T.'Субконто дебет2') as [Субконто дебет2], (select ФИО from MOL where MOL.Id = T.'Субконто дебет3') as [Субконто дебет3], [Счет кредит], [Субконто кредит1], [Субконто кредит2], [Субконто кредит3], Количество, Сумма from Transactions as T where id = " + (i + 1) + " and [id операции реализации]= " + id, ConnectionString);
                    dataAdapter.Fill(ds, "Transactions");
                    //ds.Tables["Transactions"].Rows.Add(selectValue(conString, "select id, Дата, [id операции реализации], [Счет дебет], (select Наименование from Materials as M where M.Id = T.'Субконто дебет1') as [Субконто дебет1], (select Наименование from Storages as S where S.Id = T.'Субконто дебет2') as [Субконто дебет2], (select ФИО from MOL where MOL.Id = T.'Субконто дебет3') as [Субконто дебет3], [Счет кредит], [Субконто кредит1], [Субконто кредит2], [Субконто кредит3], Количество, Сумма from Transactions as T where id = " + (i + 1)));
                }
                if (selectValue(conString, "select [Счет кредит] from Transactions where id=" + (i + 1)).ToString() == "91")
                {
                    dataAdapter = new SQLiteDataAdapter("select id, Дата, [id операции реализации], [Счет дебет], (select ФИО from Buyer as B where B.Id = T.'Субконто дебет1') as [Субконто дебет1], [Субконто дебет2], [Субконто дебет3], [Счет кредит], [Субконто кредит1], [Субконто кредит2], [Субконто кредит3], Количество, Сумма from Transactions as T where id =" + (i + 1) + " and [id операции реализации]= " + id, ConnectionString);
                    dataAdapter.Fill(ds, "Transactions");
                    //ds.Tables["Transactions"].Rows.Add(selectValue(conString, "select id, Дата, [id операции реализации], [Счет дебет], (select ФИО from Buyer as B where B.Id = T.'Субконто дебет1') as [Субконто дебет1], [Субконто дебет2], [Субконто дебет3], [Счет кредит], [Субконто кредит1], [Субконто кредит2], [Субконто кредит3], Количество, Сумма from Transactions as T where id =" + (i + 1)));
                }
                if (selectValue(conString, "select [Счет кредит] from Transactions where id=" + (i + 1)).ToString() == "10")
                {
                    dataAdapter = new SQLiteDataAdapter("select id, Дата, [id операции реализации], [Счет дебет], [Субконто дебет1], [Субконто дебет2], [Субконто дебет3], [Счет кредит], (select Наименование from Materials as M where M.id = T.'Субконто кредит1') as [Субконто кредит1], (select Наименование from Storages as S where S.id = T.'Субконто кредит2') as [Субконто кредит2], (select ФИО from MOL where MOL.id = T.'Субконто кредит3') as [Субконто кредит3], Количество, Сумма from Transactions as T where id =" + (i + 1) + " and [id операции реализации]= " + id, ConnectionString);
                    dataAdapter.Fill(ds, "Transactions");
                    //ds.Tables["Transactions"].Rows.Add(selectValue(conString, "select id, Дата, [id операции реализации], [Счет дебет], [Субконто дебет1], [Субконто дебет2], [Субконто дебет3], [Счет кредит], (select Наименование from Materials as M where M.id = T.'Субконто кредит1') as [Субконто кредит1], (select Наименование from Storages as S where S.id = T.'Субконто кредит2') as [Субконто кредит2], (select ФИО from MOL where MOL.id = T.'Субконто кредит3') as [Субконто кредит3], Количество, Сумма from Transactions as T where id =" + (i + 1)));
                }
                if (selectValue(conString, "select [Счет кредит] from Transactions where id=" + (i + 1)).ToString() == "68")
                {
                    dataAdapter = new SQLiteDataAdapter("select * from Transactions where id =" + (i + 1) + " and [id операции реализации]= " + id, ConnectionString);
                    dataAdapter.Fill(ds, "Transactions");
                    //ds.Tables["Transactions"].Rows.Add(selectValue(conString, "select * from Transactions where id =" + (i + 1)));
                }
            }
            dataGridView.DataSource = ds.Tables["Transactions"];
            string[] columns = new string[dataGridView.Columns.Count];
            for(int i = 0; i < columns.Length; i++)
            {
                columns[i] = dataGridView.Columns[i].HeaderText;
            }
            if(language == 1)
            {
                dataGridView.Columns[1].HeaderText = "Date";
                dataGridView.Columns[2].HeaderText = "Operation id";
                dataGridView.Columns[3].HeaderText = "Debit account";
                dataGridView.Columns[4].HeaderText = "Debit sub-konto1";
                dataGridView.Columns[5].HeaderText = "Debit sub-konto2";
                dataGridView.Columns[6].HeaderText = "Debit sub-konto3";
                dataGridView.Columns[7].HeaderText = "Credit account";
                dataGridView.Columns[8].HeaderText = "Credit sub-konto1";
                dataGridView.Columns[9].HeaderText = "Credit sub-konto2";
                dataGridView.Columns[10].HeaderText = "Credit sub-konto3";
                dataGridView.Columns[11].HeaderText = "Count";
                dataGridView.Columns[12].HeaderText = "Sum";
            }
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
    }
}
