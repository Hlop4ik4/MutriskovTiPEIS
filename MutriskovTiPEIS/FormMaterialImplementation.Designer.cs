namespace MutriskovTiPEIS
{
    partial class FormMaterialImplementation
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelSum = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMOL = new System.Windows.Forms.Label();
            this.comboBoxMOL = new System.Windows.Forms.ComboBox();
            this.labelBuyer = new System.Windows.Forms.Label();
            this.comboBoxBuyer = new System.Windows.Forms.ComboBox();
            this.labelStorage = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.buttonTransactions = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRemains = new System.Windows.Forms.Label();
            this.textBoxStorage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(850, 71);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(2, 59);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(842, 389);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(452, 9);
            this.labelCount.MinimumSize = new System.Drawing.Size(66, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(69, 13);
            this.labelCount.TabIndex = 2;
            this.labelCount.Text = "Количество:";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(527, 6);
            this.textBoxCount.MaxLength = 100;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount.TabIndex = 3;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(691, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2022, 11, 27, 0, 49, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(477, 35);
            this.labelSum.MinimumSize = new System.Drawing.Size(40, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(44, 13);
            this.labelSum.TabIndex = 2;
            this.labelSum.Text = "Сумма:";
            this.labelSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(527, 32);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSum.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(850, 111);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(850, 154);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 0;
            this.buttonChange.Text = "Обновить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(649, 35);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Дата:";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMOL
            // 
            this.labelMOL.AutoSize = true;
            this.labelMOL.Location = new System.Drawing.Point(262, 35);
            this.labelMOL.MinimumSize = new System.Drawing.Size(30, 0);
            this.labelMOL.Name = "labelMOL";
            this.labelMOL.Size = new System.Drawing.Size(35, 13);
            this.labelMOL.TabIndex = 2;
            this.labelMOL.Text = "МОЛ:";
            this.labelMOL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMOL
            // 
            this.comboBoxMOL.FormattingEnabled = true;
            this.comboBoxMOL.Location = new System.Drawing.Point(303, 32);
            this.comboBoxMOL.Name = "comboBoxMOL";
            this.comboBoxMOL.Size = new System.Drawing.Size(143, 21);
            this.comboBoxMOL.TabIndex = 5;
            this.comboBoxMOL.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMOL_SelectionChangeCommitted);
            // 
            // labelBuyer
            // 
            this.labelBuyer.AutoSize = true;
            this.labelBuyer.Location = new System.Drawing.Point(227, 9);
            this.labelBuyer.MinimumSize = new System.Drawing.Size(67, 0);
            this.labelBuyer.Name = "labelBuyer";
            this.labelBuyer.Size = new System.Drawing.Size(70, 13);
            this.labelBuyer.TabIndex = 2;
            this.labelBuyer.Text = "Покупатель:";
            this.labelBuyer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxBuyer
            // 
            this.comboBoxBuyer.FormattingEnabled = true;
            this.comboBoxBuyer.Location = new System.Drawing.Point(303, 6);
            this.comboBoxBuyer.Name = "comboBoxBuyer";
            this.comboBoxBuyer.Size = new System.Drawing.Size(143, 21);
            this.comboBoxBuyer.TabIndex = 5;
            // 
            // labelStorage
            // 
            this.labelStorage.AutoSize = true;
            this.labelStorage.Location = new System.Drawing.Point(31, 35);
            this.labelStorage.MinimumSize = new System.Drawing.Size(38, 0);
            this.labelStorage.Name = "labelStorage";
            this.labelStorage.Size = new System.Drawing.Size(41, 13);
            this.labelStorage.TabIndex = 2;
            this.labelStorage.Text = "Склад:";
            this.labelStorage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(12, 9);
            this.labelMaterial.MinimumSize = new System.Drawing.Size(57, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(60, 13);
            this.labelMaterial.TabIndex = 2;
            this.labelMaterial.Text = "Материал:";
            this.labelMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(78, 6);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(143, 21);
            this.comboBoxMaterial.TabIndex = 5;
            this.comboBoxMaterial.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMaterial_SelectionChangeCommitted);
            // 
            // buttonTransactions
            // 
            this.buttonTransactions.Location = new System.Drawing.Point(861, 193);
            this.buttonTransactions.Name = "buttonTransactions";
            this.buttonTransactions.Size = new System.Drawing.Size(86, 43);
            this.buttonTransactions.TabIndex = 0;
            this.buttonTransactions.Text = "Посмотреть проводки";
            this.buttonTransactions.UseVisualStyleBackColor = true;
            this.buttonTransactions.Click += new System.EventHandler(this.buttonTransactions_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Остатки:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRemains
            // 
            this.labelRemains.AutoSize = true;
            this.labelRemains.Location = new System.Drawing.Point(688, 9);
            this.labelRemains.Name = "labelRemains";
            this.labelRemains.Size = new System.Drawing.Size(0, 13);
            this.labelRemains.TabIndex = 2;
            // 
            // textBoxStorage
            // 
            this.textBoxStorage.Location = new System.Drawing.Point(78, 32);
            this.textBoxStorage.Name = "textBoxStorage";
            this.textBoxStorage.ReadOnly = true;
            this.textBoxStorage.Size = new System.Drawing.Size(143, 20);
            this.textBoxStorage.TabIndex = 6;
            // 
            // FormMaterialImplementation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.textBoxStorage);
            this.Controls.Add(this.comboBoxBuyer);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.comboBoxMOL);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelMOL);
            this.Controls.Add(this.labelStorage);
            this.Controls.Add(this.labelBuyer);
            this.Controls.Add(this.labelRemains);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonTransactions);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormMaterialImplementation";
            this.Text = "Реализация материалов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMaterialImplementation_FormClosed);
            this.Load += new System.EventHandler(this.FormMaterialImplementation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMOL;
        private System.Windows.Forms.ComboBox comboBoxMOL;
        private System.Windows.Forms.Label labelBuyer;
        private System.Windows.Forms.ComboBox comboBoxBuyer;
        private System.Windows.Forms.Label labelStorage;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Button buttonTransactions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRemains;
        private System.Windows.Forms.TextBox textBoxStorage;
    }
}