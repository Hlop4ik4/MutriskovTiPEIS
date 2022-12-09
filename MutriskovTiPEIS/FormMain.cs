using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutriskovTiPEIS
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void chartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormChartOfAccounts(comboBox1.SelectedIndex);
            form.ShowDialog();
        }

        private void MOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMOLs(comboBox1.SelectedIndex);
            form.ShowDialog();
        }

        private void MaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMaterial(comboBox1.SelectedIndex);
            form.ShowDialog();
        }

        private void StoragesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormStorage(comboBox1.SelectedIndex);
            form.ShowDialog();
        }

        private void BuyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormBuyer(comboBox1.SelectedIndex);
            form.ShowDialog();
        }

        private void materialImplementationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMaterialImplementation(comboBox1.SelectedIndex);
            form.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormTransactions(comboBox1.SelectedIndex);
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            List<string> language = new List<string>();
            language.Add("Русский");
            language.Add("English");
            comboBox1.DataSource = language;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 1)
            {
                this.Text = "Main";
                this.chartOfAccountsToolStripMenuItem.Text = "Chart of Accounts";
                this.справочникиToolStripMenuItem.Text = "Directories";
                this.MOLToolStripMenuItem.Text = "Materially responsible persons";
                this.MaterialToolStripMenuItem.Text = "Materials";
                this.StoragesToolStripMenuItem.Text = "Storages";
                this.BuyerToolStripMenuItem.Text = "Buyers";
                this.materialImplementationToolStripMenuItem.Text = "Material implementation";
                this.transactionsToolStripMenuItem.Text = "Transactions";
                this.ReportToolStripMenuItem.Text = "Reports";
                this.ReportMaterialSaleToolStripMenuItem.Text = "Sales report";
                this.ReportRemainsToolStripMenuItem.Text = "Remains report";
                this.label1.Text = "Language select";
            }
            else
            {
                this.Text = "Главная";
                this.chartOfAccountsToolStripMenuItem.Text = "План счетов";
                this.справочникиToolStripMenuItem.Text = "Справочники";
                this.MOLToolStripMenuItem.Text = "МОЛ";
                this.MaterialToolStripMenuItem.Text = "Материалы";
                this.StoragesToolStripMenuItem.Text = "Склады";
                this.BuyerToolStripMenuItem.Text = "Покупатели";
                this.materialImplementationToolStripMenuItem.Text = "Реализация материалов";
                this.transactionsToolStripMenuItem.Text = "Проводки";
                this.ReportToolStripMenuItem.Text = "Отчеты";
                this.ReportMaterialSaleToolStripMenuItem.Text = "Отчет по продажам";
                this.ReportRemainsToolStripMenuItem.Text = "Отчет по остаткам";
                this.label1.Text = "Выбор языка";
            }
        }

        private void ReportMaterialSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormReportMaterialSale(comboBox1.SelectedIndex);
            form.ShowDialog();
        }

        private void ReportRemainsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
