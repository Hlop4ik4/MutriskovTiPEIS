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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMOL = new System.Windows.Forms.Label();
            this.comboBoxMOL = new System.Windows.Forms.ComboBox();
            this.labelBuyer = new System.Windows.Forms.Label();
            this.comboBoxBuyer = new System.Windows.Forms.ComboBox();
            this.labelStorage = new System.Windows.Forms.Label();
            this.comboBoxStorage = new System.Windows.Forms.ComboBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.buttonTransactions = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRemains = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1133, 87);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
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
            this.dataGridView.Location = new System.Drawing.Point(3, 73);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1123, 479);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(703, 7);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCount.MaxLength = 100;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(132, 22);
            this.textBoxCount.TabIndex = 3;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(921, 39);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2022, 11, 24, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сумма:";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(703, 39);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(132, 22);
            this.textBoxSum.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1133, 137);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(1133, 190);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(100, 28);
            this.buttonChange.TabIndex = 0;
            this.buttonChange.Text = "Обновить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(865, 43);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 16);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Дата:";
            // 
            // labelMOL
            // 
            this.labelMOL.AutoSize = true;
            this.labelMOL.Location = new System.Drawing.Point(349, 43);
            this.labelMOL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMOL.Name = "labelMOL";
            this.labelMOL.Size = new System.Drawing.Size(40, 16);
            this.labelMOL.TabIndex = 2;
            this.labelMOL.Text = "МОЛ:";
            // 
            // comboBoxMOL
            // 
            this.comboBoxMOL.FormattingEnabled = true;
            this.comboBoxMOL.Location = new System.Drawing.Point(404, 39);
            this.comboBoxMOL.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMOL.Name = "comboBoxMOL";
            this.comboBoxMOL.Size = new System.Drawing.Size(189, 24);
            this.comboBoxMOL.TabIndex = 5;
            // 
            // labelBuyer
            // 
            this.labelBuyer.AutoSize = true;
            this.labelBuyer.Location = new System.Drawing.Point(303, 11);
            this.labelBuyer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuyer.Name = "labelBuyer";
            this.labelBuyer.Size = new System.Drawing.Size(89, 16);
            this.labelBuyer.TabIndex = 2;
            this.labelBuyer.Text = "Покупатель:";
            // 
            // comboBoxBuyer
            // 
            this.comboBoxBuyer.FormattingEnabled = true;
            this.comboBoxBuyer.Location = new System.Drawing.Point(404, 7);
            this.comboBoxBuyer.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBuyer.Name = "comboBoxBuyer";
            this.comboBoxBuyer.Size = new System.Drawing.Size(189, 24);
            this.comboBoxBuyer.TabIndex = 5;
            // 
            // labelStorage
            // 
            this.labelStorage.AutoSize = true;
            this.labelStorage.Location = new System.Drawing.Point(41, 43);
            this.labelStorage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStorage.Name = "labelStorage";
            this.labelStorage.Size = new System.Drawing.Size(50, 16);
            this.labelStorage.TabIndex = 2;
            this.labelStorage.Text = "Склад:";
            // 
            // comboBoxStorage
            // 
            this.comboBoxStorage.FormattingEnabled = true;
            this.comboBoxStorage.Location = new System.Drawing.Point(104, 39);
            this.comboBoxStorage.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStorage.Name = "comboBoxStorage";
            this.comboBoxStorage.Size = new System.Drawing.Size(189, 24);
            this.comboBoxStorage.TabIndex = 5;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(16, 11);
            this.labelMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(76, 16);
            this.labelMaterial.TabIndex = 2;
            this.labelMaterial.Text = "Материал:";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(104, 7);
            this.comboBoxMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(189, 24);
            this.comboBoxMaterial.TabIndex = 5;
            this.comboBoxMaterial.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMaterial_SelectionChangeCommitted);
            // 
            // buttonTransactions
            // 
            this.buttonTransactions.Location = new System.Drawing.Point(1148, 238);
            this.buttonTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTransactions.Name = "buttonTransactions";
            this.buttonTransactions.Size = new System.Drawing.Size(115, 53);
            this.buttonTransactions.TabIndex = 0;
            this.buttonTransactions.Text = "Посмотреть проводки";
            this.buttonTransactions.UseVisualStyleBackColor = true;
            this.buttonTransactions.Click += new System.EventHandler(this.buttonTransactions_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(843, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Остатки:";
            // 
            // labelRemains
            // 
            this.labelRemains.AutoSize = true;
            this.labelRemains.Location = new System.Drawing.Point(918, 11);
            this.labelRemains.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRemains.Name = "labelRemains";
            this.labelRemains.Size = new System.Drawing.Size(0, 16);
            this.labelRemains.TabIndex = 2;
            // 
            // FormMaterialImplementation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 554);
            this.Controls.Add(this.comboBoxStorage);
            this.Controls.Add(this.comboBoxBuyer);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.comboBoxMOL);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMOL);
            this.Controls.Add(this.labelStorage);
            this.Controls.Add(this.labelBuyer);
            this.Controls.Add(this.labelRemains);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonTransactions);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMaterialImplementation";
            this.Text = "Реализация материалов";
            this.Load += new System.EventHandler(this.FormMaterialImplementation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMOL;
        private System.Windows.Forms.ComboBox comboBoxMOL;
        private System.Windows.Forms.Label labelBuyer;
        private System.Windows.Forms.ComboBox comboBoxBuyer;
        private System.Windows.Forms.Label labelStorage;
        private System.Windows.Forms.ComboBox comboBoxStorage;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Button buttonTransactions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRemains;
    }
}