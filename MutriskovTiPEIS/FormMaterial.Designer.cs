namespace MutriskovTiPEIS
{
    partial class FormMaterial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelSalePrice = new System.Windows.Forms.Label();
            this.textBoxPrice1 = new System.Windows.Forms.TextBox();
            this.labelStorage = new System.Windows.Forms.Label();
            this.comboBoxStorage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(1, 58);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(416, 366);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Наименование:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(71, 35);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Цена:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(113, 6);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(113, 32);
            this.textBoxPrice.MaxLength = 100;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(427, 57);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(427, 105);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChange.Location = new System.Drawing.Point(427, 155);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Обновить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelSalePrice
            // 
            this.labelSalePrice.AutoSize = true;
            this.labelSalePrice.Location = new System.Drawing.Point(218, 9);
            this.labelSalePrice.Name = "labelSalePrice";
            this.labelSalePrice.Size = new System.Drawing.Size(95, 13);
            this.labelSalePrice.TabIndex = 1;
            this.labelSalePrice.Text = "Цена продажная:";
            // 
            // textBoxPrice1
            // 
            this.textBoxPrice1.Location = new System.Drawing.Point(320, 6);
            this.textBoxPrice1.MaxLength = 100;
            this.textBoxPrice1.Name = "textBoxPrice1";
            this.textBoxPrice1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice1.TabIndex = 2;
            // 
            // labelStorage
            // 
            this.labelStorage.AutoSize = true;
            this.labelStorage.Location = new System.Drawing.Point(267, 34);
            this.labelStorage.Name = "labelStorage";
            this.labelStorage.Size = new System.Drawing.Size(44, 13);
            this.labelStorage.TabIndex = 1;
            this.labelStorage.Text = "Склад: ";
            // 
            // comboBoxStorage
            // 
            this.comboBoxStorage.FormattingEnabled = true;
            this.comboBoxStorage.Location = new System.Drawing.Point(320, 32);
            this.comboBoxStorage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxStorage.Name = "comboBoxStorage";
            this.comboBoxStorage.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStorage.TabIndex = 4;
            // 
            // FormMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 424);
            this.Controls.Add(this.comboBoxStorage);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPrice1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelStorage);
            this.Controls.Add(this.labelSalePrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormMaterial";
            this.Text = "Материалы";
            this.Load += new System.EventHandler(this.FormMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelSalePrice;
        private System.Windows.Forms.TextBox textBoxPrice1;
        private System.Windows.Forms.Label labelStorage;
        private System.Windows.Forms.ComboBox comboBoxStorage;
    }
}