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
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;

namespace MutriskovTiPEIS
{
    public partial class FormReportMaterialSale : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private string sPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "mydb.db");
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
                labelPurchase.Text = "Total purchase price: " + sumOfCost.ToString();
                labelProfitOrLoss.Text = "Total profit: " + sumOfDiff.ToString();
                labelProfit.Text = "Total gain: " + sumOfGain.ToString();
            }
            else
            {
                labelProfit.Text = "Итого по выручке: " + sumOfGain.ToString();
                labelPurchase.Text = "Итого по себестоимости: " + sumOfCost.ToString();
                labelProfitOrLoss.Text = "Итого по прибыли/убыли: " + sumOfDiff.ToString();
            }
            
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
                labelProfit.Text = "Total gain:";
                labelPurchase.Text = "Total purchase price:";
                labelProfitOrLoss.Text = "Total profit:";
                buttonReport.Text = "Sales report";
                dateTimePickerFrom.CustomFormat = "MM-dd-yyyy HH:mm:ss";
                dateTimePickerTo.CustomFormat = "MM-dd-yyyy HH:mm:ss";
            }
        }

        private void buttonDoc_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date >= dateTimePickerTo.Value.Date)
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
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "docx|*.docx"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (language == 0)
                    {
                        saveDoc(sfd.FileName);
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        saveDoc(sfd.FileName);
                        MessageBox.Show("Done", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    if (language == 0)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void saveDoc(string FileName)
        {
            var winword = new Microsoft.Office.Interop.Word.Application();
            try
            {
                object missing = System.Reflection.Missing.Value;
                //создаем документ
                Microsoft.Office.Interop.Word.Document document =
                winword.Documents.Add(ref missing, ref missing, ref missing, ref
               missing);
                //получаем ссылку на параграф
                var paragraph = document.Paragraphs.Add(missing);
                var range = paragraph.Range;
                string title = "";
                if (language == 0)
                {
                    title = "Продажи материалов с " + Convert.ToString(dateTimePickerFrom.Text) + " по " + Convert.ToString(dateTimePickerTo.Text) + "";
                }
                else
                {
                    title = "Material sales from " + Convert.ToString(dateTimePickerFrom.Text) + " to " + Convert.ToString(dateTimePickerTo.Text) + "";

                }
                //задаем текст
                range.Text = title;
                //задаем настройки шрифта
                var font = range.Font;
                font.Size = 16;
                font.Name = "Times New Roman";
                font.Bold = 1;
                //задаем настройки абзаца
                var paragraphFormat = range.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 0;
                //добавляем абзац в документ
                range.InsertParagraphAfter();
                //создаем таблицу
                var paragraphTable = document.Paragraphs.Add(Type.Missing);
                var rangeTable = paragraphTable.Range;
                var table = document.Tables.Add(rangeTable, dataGridView.Rows.Count + 1, dataGridView.Columns.Count, ref
               missing, ref missing);
                font = table.Range.Font;
                font.Size = 14;
                font.Name = "Times New Roman";
                var paragraphTableFormat = table.Range.ParagraphFormat;
                paragraphTableFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphTableFormat.SpaceAfter = 0;
                paragraphTableFormat.SpaceBefore = 0;
                for (int i = 0; i < dataGridView.Columns.Count; ++i)
                {
                    table.Cell(1, i + 1).Range.Text = dataGridView.Columns[i].HeaderCell.Value.ToString();
                }
                for (int i = 0; i < dataGridView.Rows.Count; ++i)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; ++j)
                    {
                        table.Cell(i + 2, j + 1).Range.Text = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                //задаем границы таблицы
                table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleInset;
                table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                paragraph = document.Paragraphs.Add(missing);
                range = paragraph.Range;
                range.Text = labelProfit.Text.ToString() + Environment.NewLine + labelPurchase.Text.ToString() + Environment.NewLine + labelProfitOrLoss.Text + Environment.NewLine;
                font = range.Font;
                font.Size = 12;
                font.Name = "Times New Roman";
                paragraphFormat = range.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 10;
                range.InsertParagraphAfter();
                //сохраняем
                object fileFormat = WdSaveFormat.wdFormatXMLDocument;
                document.SaveAs(FileName, ref fileFormat, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing);
                document.Close(ref missing, ref missing, ref missing);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                winword.Quit();
            }
        }

        private void buttonXLS_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date >= dateTimePickerTo.Value.Date)
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
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "xls|*.xls|xlsx|*.xlsx"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (language == 0)
                    {
                        saveXls(sfd.FileName);
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        saveXls(sfd.FileName);
                        MessageBox.Show("Done", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    if (language == 0)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void saveXls(string FileName)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                if (File.Exists(FileName))
                {
                    excel.Workbooks.Open(FileName, Type.Missing, Type.Missing,
                   Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                   Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                   Type.Missing,
                    Type.Missing);
                }
                else
                {
                    excel.SheetsInNewWorkbook = 1;
                    excel.Workbooks.Add(Type.Missing);
                    excel.Workbooks[1].SaveAs(FileName, XlFileFormat.xlExcel8,
                    Type.Missing,
                     Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange,
                    Type.Missing,
                     Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                Sheets excelsheets = excel.Workbooks[1].Worksheets;

                var excelworksheet = (Worksheet)excelsheets.get_Item(1);
                excelworksheet.Cells.Clear();
                Microsoft.Office.Interop.Excel.Range excelcells = excelworksheet.get_Range("A1", "H1");
                excelcells.Merge(Type.Missing);
                excelcells.Font.Bold = true;
                string title = "";
                if (language == 0)
                {
                    title = "Продажи материалов с " + Convert.ToString(dateTimePickerFrom.Text) + " по " + Convert.ToString(dateTimePickerTo.Text) + "";
                }
                else
                {
                    title = "Material sales from " + Convert.ToString(dateTimePickerFrom.Text) + " to " + Convert.ToString(dateTimePickerTo.Text) + "";

                }
                excelcells.Value2 = title;
                excelcells.RowHeight = 40;
                excelcells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                excelcells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                excelcells.Font.Name = "Times New Roman";
                excelcells.Font.Size = 14;

                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    excelcells = excelworksheet.get_Range("B3", "B3");
                    excelcells = excelcells.get_Offset(0, j);
                    excelcells.ColumnWidth = 15;
                    excelcells.Value2 = dataGridView.Columns[j].HeaderCell.Value.ToString();
                    excelcells.Font.Bold = true;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        excelcells = excelworksheet.get_Range("B4", "B4");
                        excelcells = excelcells.get_Offset(i, j);
                        excelcells.ColumnWidth = 15;
                        excelcells.Value2 = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excelcells = excelcells.get_Offset(1, 0);
                excelcells.Value2 = labelProfit.Text.ToString();
                excelcells.Font.Bold = true;
                excelcells = excelcells.get_Offset(1, 0);
                excelcells.Value2 = labelPurchase.Text;
                excelcells.Font.Bold = true;
                excelcells = excelcells.get_Offset(1, 0);
                excelcells.Value2 = labelProfitOrLoss.Text;
                excelcells.Font.Bold = true;
                excel.Workbooks[1].Save();
            }
            catch (Exception)
            {
            }
            finally
            {
                excel.Quit();
            }
        }
    }
}
