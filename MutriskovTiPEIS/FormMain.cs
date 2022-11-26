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
            var form = new FormChartOfAccounts();
            form.ShowDialog();
        }

        private void MOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMOLs();
            form.ShowDialog();
        }

        private void MaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMaterial();
            form.ShowDialog();
        }

        private void StoragesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormStorage();
            form.ShowDialog();
        }

        private void BuyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormBuyer();
            form.ShowDialog();
        }

        private void materialImplementationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMaterialImplementation();
            form.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormTransactions();
            form.ShowDialog();
        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormReport();
            form.ShowDialog();
        }
    }
}
