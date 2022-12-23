namespace MutriskovTiPEIS
{
    partial class FormReportMaterialSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelProfit = new System.Windows.Forms.Label();
            this.labelPurchase = new System.Windows.Forms.Label();
            this.labelProfitOrLoss = new System.Windows.Forms.Label();
            this.buttonDoc = new System.Windows.Forms.Button();
            this.buttonXLS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "В период с";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(67, 20);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonReport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerTo);
            this.groupBox1.Controls.Add(this.dateTimePickerFrom);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(514, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать отчет";
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(398, 20);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(108, 19);
            this.buttonReport.TabIndex = 2;
            this.buttonReport.Text = "Сформировать";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "по";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(243, 20);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(9, 66);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(514, 215);
            this.dataGridView.TabIndex = 3;
            // 
            // labelProfit
            // 
            this.labelProfit.AutoSize = true;
            this.labelProfit.Location = new System.Drawing.Point(9, 287);
            this.labelProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfit.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(100, 13);
            this.labelProfit.TabIndex = 4;
            this.labelProfit.Text = "Итого по выручке:";
            // 
            // labelPurchase
            // 
            this.labelPurchase.AutoSize = true;
            this.labelPurchase.Location = new System.Drawing.Point(9, 308);
            this.labelPurchase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPurchase.MinimumSize = new System.Drawing.Size(136, 0);
            this.labelPurchase.Name = "labelPurchase";
            this.labelPurchase.Size = new System.Drawing.Size(136, 13);
            this.labelPurchase.TabIndex = 4;
            this.labelPurchase.Text = "Итого по себестоимости:";
            // 
            // labelProfitOrLoss
            // 
            this.labelProfitOrLoss.AutoSize = true;
            this.labelProfitOrLoss.Location = new System.Drawing.Point(9, 329);
            this.labelProfitOrLoss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfitOrLoss.MinimumSize = new System.Drawing.Size(138, 0);
            this.labelProfitOrLoss.Name = "labelProfitOrLoss";
            this.labelProfitOrLoss.Size = new System.Drawing.Size(138, 13);
            this.labelProfitOrLoss.TabIndex = 4;
            this.labelProfitOrLoss.Text = "Итого по прибыли/убыли:";
            // 
            // buttonDoc
            // 
            this.buttonDoc.Location = new System.Drawing.Point(448, 298);
            this.buttonDoc.Name = "buttonDoc";
            this.buttonDoc.Size = new System.Drawing.Size(75, 23);
            this.buttonDoc.TabIndex = 5;
            this.buttonDoc.Text = "DOC";
            this.buttonDoc.UseVisualStyleBackColor = true;
            this.buttonDoc.Click += new System.EventHandler(this.buttonDoc_Click);
            // 
            // buttonXLS
            // 
            this.buttonXLS.Location = new System.Drawing.Point(448, 324);
            this.buttonXLS.Name = "buttonXLS";
            this.buttonXLS.Size = new System.Drawing.Size(75, 23);
            this.buttonXLS.TabIndex = 5;
            this.buttonXLS.Text = "XLS";
            this.buttonXLS.UseVisualStyleBackColor = true;
            this.buttonXLS.Click += new System.EventHandler(this.buttonXLS_Click);
            // 
            // FormReportMaterialSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 375);
            this.Controls.Add(this.buttonXLS);
            this.Controls.Add(this.buttonDoc);
            this.Controls.Add(this.labelProfitOrLoss);
            this.Controls.Add(this.labelPurchase);
            this.Controls.Add(this.labelProfit);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormReportMaterialSale";
            this.Text = "Отчет по продажам";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelProfit;
        private System.Windows.Forms.Label labelPurchase;
        private System.Windows.Forms.Label labelProfitOrLoss;
        private System.Windows.Forms.Button buttonDoc;
        private System.Windows.Forms.Button buttonXLS;
    }
}