using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MutriskovTiPEIS
{
    public partial class FormLogs : Form
    {
        int language = 0;
        public FormLogs(int language)
        {
            this.language = language;
            InitializeComponent();
        }

        private void FormLogs_Load(object sender, EventArgs e)
        {
            if (language == 1)
            {
                this.Text = "Logs";
            }
            string line;
            StreamReader sr = new StreamReader("D://Logs//LogBase.txt");
            line = sr.ReadLine();
            while(line != null)
            {
                textBox1.Text += line + Environment.NewLine;
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
