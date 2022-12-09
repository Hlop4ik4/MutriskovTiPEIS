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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelGain = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelDiff = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "В период с";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(89, 25);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonReport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerTo);
            this.groupBox1.Controls.Add(this.dateTimePickerFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать отчет";
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(530, 25);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(144, 23);
            this.buttonReport.TabIndex = 2;
            this.buttonReport.Text = "Сформировать";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "по";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(324, 25);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
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
            this.dataGridView.Location = new System.Drawing.Point(12, 81);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(685, 265);
            this.dataGridView.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Итого по выручке:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Итого по себестоимости:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Итого по прибыли/убыли:";
            // 
            // labelGain
            // 
            this.labelGain.AutoSize = true;
            this.labelGain.Location = new System.Drawing.Point(145, 353);
            this.labelGain.Name = "labelGain";
            this.labelGain.Size = new System.Drawing.Size(7, 16);
            this.labelGain.TabIndex = 4;
            this.labelGain.Text = "\r\n";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(189, 379);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(7, 16);
            this.labelCost.TabIndex = 4;
            this.labelCost.Text = "\r\n";
            // 
            // labelDiff
            // 
            this.labelDiff.AutoSize = true;
            this.labelDiff.Location = new System.Drawing.Point(191, 405);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(7, 16);
            this.labelDiff.TabIndex = 4;
            this.labelDiff.Text = "\r\n";
            // 
            // FormReportMaterialSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDiff);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelGain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelGain;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelDiff;
    }
}