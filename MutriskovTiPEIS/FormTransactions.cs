﻿using System;
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
    public partial class FormTransactions : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private string sPath = Path.Combine(Application.StartupPath, "mydb.db");
        private string ConnectionString;

        public FormTransactions()
        {
            InitializeComponent();
        }

        private void FormTransactions_Load(object sender, EventArgs e)
        {
            ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            string selectCommand = "Select * from Transactions";
            SelectTable(ConnectionString, selectCommand);
        }

        private void SelectTable(string conString, string selectCmd)
        {
            SQLiteConnection connect = new SQLiteConnection(conString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            DataSet ds = new DataSet();
           
            for (int i = 0; i < Convert.ToInt32(selectValue(conString, "select count(*) from Transactions")); i++)
            {
                if(selectValue(conString, "select [Счет кредит] from Transactions where id=" + (i + 1)).ToString() == "60.1")
                {
                    dataAdapter = new SQLiteDataAdapter("select id, Дата, [id операции реализации], [Счет дебет], (select Наименование from Materials as M where M.Id = T.'Субконто дебет1') as [Субконто дебет1], (select Наименование from Storages as S where S.Id = T.'Субконто дебет2') as [Субконто дебет2], (select ФИО from MOL where MOL.Id = T.'Субконто дебет3') as [Субконто дебет3], [Счет кредит], [Субконто кредит1], [Субконто кредит2], [Субконто кредит3], Количество, Сумма from Transactions as T where id = " + (i + 1), ConnectionString);
                    dataAdapter.Fill(ds, "Transactions");
                }
                if(selectValue(conString, "select [Счет кредит] from Transactions where id=" + (i + 1)).ToString() == "91")
                {
                    dataAdapter = new SQLiteDataAdapter("select id, Дата, [id операции реализации], [Счет дебет], (select ФИО from Buyer as B where B.Id = T.'Субконто дебет1') as [Субконто дебет1], [Субконто дебет2], [Субконто дебет3], [Счет кредит], [Субконто кредит1], [Субконто кредит2], [Субконто кредит3], Количество, Сумма from Transactions as T where id =" + (i + 1), ConnectionString);
                    dataAdapter.Fill(ds, "Transactions");
                }
                if (selectValue(conString, "select [Счет кредит] from Transactions where id=" + (i + 1)).ToString() == "10")
                {
                    dataAdapter = new SQLiteDataAdapter("select id, Дата, [id операции реализации], [Счет дебет], [Субконто дебет1], [Субконто дебет2], [Субконто дебет3], [Счет кредит], (select Наименование from Materials as M where M.id = T.'Субконто кредит1') as [Субконто кредит1], (select Наименование from Storages as S where S.id = T.'Субконто кредит2') as [Субконто кредит2], (select ФИО from MOL where MOL.id = T.'Субконто кредит3') as [Субконто кредит3], Количество, Сумма from Transactions as T where id =" + (i + 1), ConnectionString);
                    dataAdapter.Fill(ds, "Transactions");
                }
                if (selectValue(conString, "select [Счет кредит] from Transactions where id=" + (i + 1)).ToString() == "68")
                {
                    dataAdapter = new SQLiteDataAdapter("select * from Transactions where id =" + (i + 1), ConnectionString);
                    dataAdapter.Fill(ds, "Transactions");
                }
            }
            dataGridView.DataSource = ds.Tables["Transactions"];
            dataAdapter = new SQLiteDataAdapter("select * from Materials", connect);
            dataAdapter.Fill(ds, "Materials");
            comboBoxMaterial.DataSource = ds.Tables["Materials"];
            comboBoxMaterial.DisplayMember = "Наименование";
            comboBoxMaterial.ValueMember = "Id";
            comboBoxMaterial.SelectedItem = null;
            dataAdapter = new SQLiteDataAdapter("select * from MOL", connect);
            dataAdapter.Fill(ds, "MOL");
            comboBoxMOL.DataSource = ds.Tables["MOL"];
            comboBoxMOL.DisplayMember = "ФИО";
            comboBoxMOL.ValueMember = "Id";
            comboBoxMOL.SelectedItem = null;
            connect.Close();
        }

        private void SelectTableDate(string conString, string selectCmd)
        {
            SQLiteConnection connect = new SQLiteConnection(conString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            DataSet ds = new DataSet();

            for (int i = 0; i < Convert.ToInt32(selectValue(conString, "select count(*) from Transactions")); i++)
            {
                if (selectValue(conString, "select [Счет кредит] from Transactions where id=" + (i + 1)).ToString() == "60.1")
                {
                    dataAdapter = new SQLiteDataAdapter("select id, Дата, [id операции реализации], [Счет дебет], (select Наименование from Materials as M where M.Id = T.'Субконто дебет1') as [Субконто дебет1], (select Наименование from Storages as S where S.Id = T.'Субконто дебет2') as [Субконто дебет2], (select ФИО from MOL where MOL.Id = T.'Субконто дебет3') as [Субконто дебет3], [Счет кредит], [Субконто кредит1], [Субконто кредит2], [Субконто кредит3], Количество, Сумма from Transactions as T where id = " + (i + 1) + " and Дата between '" + dateTimePickerFrom.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'", ConnectionString);
                    dataAdapter.Fill(ds, "Transactions");
                }
                if (selectValue(conString, "select [Счет кредит] from Transactions where id=" + (i + 1)).ToString() == "91")
                {
                    dataAdapter = new SQLiteDataAdapter("select id, Дата, [id операции реализации], [Счет дебет], (select ФИО from Buyer as B where B.Id = T.'Субконто дебет1') as [Субконто дебет1], [Субконто дебет2], [Субконто дебет3], [Счет кредит], [Субконто кредит1], [Субконто кредит2], [Субконто кредит3], Количество, Сумма from Transactions as T where id =" + (i + 1) + " and Дата between '" + dateTimePickerFrom.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'", ConnectionString);
                    dataAdapter.Fill(ds, "Transactions");
                }
                if (selectValue(conString, "select [Счет кредит] from Transactions where id=" + (i + 1)).ToString() == "10")
                {
                    dataAdapter = new SQLiteDataAdapter("select id, Дата, [id операции реализации], [Счет дебет], [Субконто дебет1], [Субконто дебет2], [Субконто дебет3], [Счет кредит], (select Наименование from Materials as M where M.id = T.'Субконто кредит1') as [Субконто кредит1], (select Наименование from Storages as S where S.id = T.'Субконто кредит2') as [Субконто кредит2], (select ФИО from MOL where MOL.id = T.'Субконто кредит3') as [Субконто кредит3], Количество, Сумма from Transactions as T where id =" + (i + 1) + " and Дата between '" + dateTimePickerFrom.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'", ConnectionString);
                    dataAdapter.Fill(ds, "Transactions");
                }
                if (selectValue(conString, "select [Счет кредит] from Transactions where id=" + (i + 1)).ToString() == "68")
                {
                    dataAdapter = new SQLiteDataAdapter("select * from Transactions where id =" + (i + 1) + " and Дата between '" + dateTimePickerFrom.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'", ConnectionString);
                    dataAdapter.Fill(ds, "Transactions");
                }
            }
            dataGridView.DataSource = ds.Tables["Transactions"];
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if(dateTimePickerFrom.Value <= dateTimePickerTo.Value)
            {
                string selectCmd = "Select * from Transactions where Дата between '" + dateTimePickerFrom.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                SelectTableDate(ConnectionString, selectCmd);
            }
            else
            {
                MessageBox.Show("Неверный выбор дат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string selectCommand = "select MAX(Id) from Transactions";
            var maxValue = selectValue(ConnectionString, selectCommand);
            if (Convert.ToString(maxValue) == "")
                maxValue = 0;
            if (comboBoxMaterial.SelectedItem == null || String.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int count;
            if (!Int32.TryParse(textBoxCount.Text, out count))
            {
                MessageBox.Show("Неверный формат строки 'Количество'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (count < 0)
            {
                MessageBox.Show("Количество не должно быть меньше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sum = (Convert.ToDecimal(selectValue(ConnectionString, "select Цена from Materials where id=" + Convert.ToInt32(comboBoxMaterial.SelectedValue))) * Convert.ToInt32(textBoxCount.Text)).ToString();
            string txtSQLQuery = "insert into Transactions (id, Дата, [Счет дебет], [Субконто дебет1], [Субконто дебет2], [Субконто дебет3], [Счет кредит], Количество, Сумма) values (" + (Convert.ToInt32(maxValue) + 1) + ", @date, (select [Номер счета] from ChartOfAccounts where [Номер счета]=10), " + Convert.ToInt32(comboBoxMaterial.SelectedValue) + ", (select [Id склада] from Materials where id=" + Convert.ToInt32(comboBoxMaterial.SelectedValue) + "), " + Convert.ToInt32(comboBoxMOL.SelectedValue) + ", (select [Номер счета] from ChartOfAccounts where [Номер счета]=60.1), " + textBoxCount.Text + ", '" + sum + "')";

            ExecuteQuery(txtSQLQuery);

            selectCommand = "select * from Transactions";
            refreshForm(ConnectionString, selectCommand);
            textBoxCount.Clear();
            comboBoxMaterial.SelectedItem = null;
            comboBoxMOL.SelectedItem = null;
        }

        private void refreshForm(string conString, string selectCmd)
        {
            SelectTable(conString, selectCmd);
            dataGridView.Update();
            dataGridView.Refresh();
            textBoxCount.Text = "";
            comboBoxMaterial.SelectedItem = null;
            comboBoxMOL.SelectedItem = null;
        }

        private void ExecuteQuery(string Query)
        {
            sql_con = new SQLiteConnection(ConnectionString + ";Compress=True;");
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = Query;
            sql_cmd.Parameters.Add("@date", DbType.DateTime).Value = dateTimePicker1.Value;
            sql_con.Open();
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
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

        private void buttonResetFilter_Click(object sender, EventArgs e)
        {
            SelectTable(ConnectionString, "");
        }
    }
}
