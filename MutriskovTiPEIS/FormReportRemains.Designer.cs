namespace MutriskovTiPEIS
{
    partial class FormReportRemains
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
            this.buttonReport = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCountRemains = new System.Windows.Forms.Label();
            this.labelSumRemains = new System.Windows.Forms.Label();
            this.buttonDoc = new System.Windows.Forms.Button();
            this.buttonXls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(398, 17);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(105, 19);
            this.buttonReport.TabIndex = 0;
            this.buttonReport.Text = "Сформировать";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(9, 61);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(511, 258);
            this.dataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "В период с";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerTo);
            this.groupBox1.Controls.Add(this.dateTimePickerFrom);
            this.groupBox1.Controls.Add(this.buttonReport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(511, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать отчет";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(243, 18);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerTo.TabIndex = 4;
            this.dateTimePickerTo.Value = new System.DateTime(2022, 12, 10, 1, 54, 9, 0);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(67, 18);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFrom.TabIndex = 4;
            this.dateTimePickerFrom.Value = new System.DateTime(2022, 12, 10, 1, 54, 9, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "по";
            // 
            // labelCountRemains
            // 
            this.labelCountRemains.AutoSize = true;
            this.labelCountRemains.Location = new System.Drawing.Point(9, 324);
            this.labelCountRemains.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountRemains.MinimumSize = new System.Drawing.Size(164, 0);
            this.labelCountRemains.Name = "labelCountRemains";
            this.labelCountRemains.Size = new System.Drawing.Size(164, 13);
            this.labelCountRemains.TabIndex = 4;
            this.labelCountRemains.Text = "Итого по количеству остатков:";
            // 
            // labelSumRemains
            // 
            this.labelSumRemains.AutoSize = true;
            this.labelSumRemains.Location = new System.Drawing.Point(9, 345);
            this.labelSumRemains.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSumRemains.MinimumSize = new System.Drawing.Size(140, 0);
            this.labelSumRemains.Name = "labelSumRemains";
            this.labelSumRemains.Size = new System.Drawing.Size(140, 13);
            this.labelSumRemains.TabIndex = 4;
            this.labelSumRemains.Text = "Итого по сумме остатков:";
            // 
            // buttonDoc
            // 
            this.buttonDoc.Location = new System.Drawing.Point(445, 324);
            this.buttonDoc.Name = "buttonDoc";
            this.buttonDoc.Size = new System.Drawing.Size(75, 23);
            this.buttonDoc.TabIndex = 5;
            this.buttonDoc.Text = "DOC";
            this.buttonDoc.UseVisualStyleBackColor = true;
            this.buttonDoc.Click += new System.EventHandler(this.buttonDoc_Click);
            // 
            // buttonXls
            // 
            this.buttonXls.Location = new System.Drawing.Point(445, 353);
            this.buttonXls.Name = "buttonXls";
            this.buttonXls.Size = new System.Drawing.Size(75, 23);
            this.buttonXls.TabIndex = 5;
            this.buttonXls.Text = "XLS";
            this.buttonXls.UseVisualStyleBackColor = true;
            this.buttonXls.Click += new System.EventHandler(this.buttonXls_Click);
            // 
            // FormReportRemains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 383);
            this.Controls.Add(this.buttonXls);
            this.Controls.Add(this.buttonDoc);
            this.Controls.Add(this.labelSumRemains);
            this.Controls.Add(this.labelCountRemains);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormReportRemains";
            this.Text = "Отчет по остаткам";
            this.Load += new System.EventHandler(this.FormReportRemains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCountRemains;
        private System.Windows.Forms.Label labelSumRemains;
        private System.Windows.Forms.Button buttonDoc;
        private System.Windows.Forms.Button buttonXls;
    }
}