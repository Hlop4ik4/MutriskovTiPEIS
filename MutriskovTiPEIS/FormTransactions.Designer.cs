namespace MutriskovTiPEIS
{
    partial class FormTransactions
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelFiltFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelFiltTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.comboBoxMOL = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelMOL = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.buttonResetFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 118);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(706, 381);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(540, 4);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 1;
            this.buttonFilter.Text = "Фильтр";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // labelFiltFrom
            // 
            this.labelFiltFrom.AutoSize = true;
            this.labelFiltFrom.Location = new System.Drawing.Point(12, 9);
            this.labelFiltFrom.Name = "labelFiltFrom";
            this.labelFiltFrom.Size = new System.Drawing.Size(85, 13);
            this.labelFiltFrom.TabIndex = 2;
            this.labelFiltFrom.Text = "Фильтровать с";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(103, 3);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // labelFiltTo
            // 
            this.labelFiltTo.AutoSize = true;
            this.labelFiltTo.Location = new System.Drawing.Point(309, 9);
            this.labelFiltTo.Name = "labelFiltTo";
            this.labelFiltTo.Size = new System.Drawing.Size(19, 13);
            this.labelFiltTo.TabIndex = 2;
            this.labelFiltTo.Text = "по";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(334, 3);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxCount);
            this.groupBox1.Controls.Add(this.comboBoxMOL);
            this.groupBox1.Controls.Add(this.comboBoxMaterial);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.labelDate);
            this.groupBox1.Controls.Add(this.labelCount);
            this.groupBox1.Controls.Add(this.labelMOL);
            this.groupBox1.Controls.Add(this.labelMaterial);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод новой записи";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(447, 39);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(81, 46);
            this.textBoxCount.MaxLength = 100;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(121, 20);
            this.textBoxCount.TabIndex = 3;
            // 
            // comboBoxMOL
            // 
            this.comboBoxMOL.FormattingEnabled = true;
            this.comboBoxMOL.Location = new System.Drawing.Point(250, 19);
            this.comboBoxMOL.Name = "comboBoxMOL";
            this.comboBoxMOL.Size = new System.Drawing.Size(167, 21);
            this.comboBoxMOL.TabIndex = 2;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(81, 19);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterial.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(250, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(208, 49);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Дата:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(6, 49);
            this.labelCount.MinimumSize = new System.Drawing.Size(69, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(69, 13);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "Количетсво:";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMOL
            // 
            this.labelMOL.AutoSize = true;
            this.labelMOL.Location = new System.Drawing.Point(209, 22);
            this.labelMOL.Name = "labelMOL";
            this.labelMOL.Size = new System.Drawing.Size(35, 13);
            this.labelMOL.TabIndex = 0;
            this.labelMOL.Text = "МОЛ:";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(15, 22);
            this.labelMaterial.MinimumSize = new System.Drawing.Size(60, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(60, 13);
            this.labelMaterial.TabIndex = 0;
            this.labelMaterial.Text = "Материал:";
            this.labelMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonResetFilter
            // 
            this.buttonResetFilter.Location = new System.Drawing.Point(621, 4);
            this.buttonResetFilter.Name = "buttonResetFilter";
            this.buttonResetFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonResetFilter.TabIndex = 1;
            this.buttonResetFilter.Text = "Сбросить фильтр";
            this.buttonResetFilter.UseVisualStyleBackColor = true;
            this.buttonResetFilter.Click += new System.EventHandler(this.buttonResetFilter_Click);
            // 
            // FormTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.labelFiltTo);
            this.Controls.Add(this.labelFiltFrom);
            this.Controls.Add(this.buttonResetFilter);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormTransactions";
            this.Text = "Журнал проводок";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTransactions_FormClosed);
            this.Load += new System.EventHandler(this.FormTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label labelFiltFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelFiltTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox comboBoxMOL;
        private System.Windows.Forms.Label labelMOL;
        private System.Windows.Forms.Button buttonResetFilter;
    }
}