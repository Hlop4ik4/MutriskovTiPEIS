namespace MutriskovTiPEIS
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartOfAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StoragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuyerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialImplementationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportMaterialSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportRemainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.materialImplementationToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.ReportToolStripMenuItem,
            this.LogsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartOfAccountsToolStripMenuItem,
            this.MOLToolStripMenuItem,
            this.MaterialToolStripMenuItem,
            this.StoragesToolStripMenuItem,
            this.BuyerToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // chartOfAccountsToolStripMenuItem
            // 
            this.chartOfAccountsToolStripMenuItem.Name = "chartOfAccountsToolStripMenuItem";
            this.chartOfAccountsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.chartOfAccountsToolStripMenuItem.Text = "План счетов";
            this.chartOfAccountsToolStripMenuItem.Click += new System.EventHandler(this.chartOfAccountsToolStripMenuItem_Click);
            // 
            // MOLToolStripMenuItem
            // 
            this.MOLToolStripMenuItem.Name = "MOLToolStripMenuItem";
            this.MOLToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.MOLToolStripMenuItem.Text = "МОЛ";
            this.MOLToolStripMenuItem.Click += new System.EventHandler(this.MOLToolStripMenuItem_Click);
            // 
            // MaterialToolStripMenuItem
            // 
            this.MaterialToolStripMenuItem.Name = "MaterialToolStripMenuItem";
            this.MaterialToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.MaterialToolStripMenuItem.Text = "Материал";
            this.MaterialToolStripMenuItem.Click += new System.EventHandler(this.MaterialToolStripMenuItem_Click);
            // 
            // StoragesToolStripMenuItem
            // 
            this.StoragesToolStripMenuItem.Name = "StoragesToolStripMenuItem";
            this.StoragesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.StoragesToolStripMenuItem.Text = "Склад";
            this.StoragesToolStripMenuItem.Click += new System.EventHandler(this.StoragesToolStripMenuItem_Click);
            // 
            // BuyerToolStripMenuItem
            // 
            this.BuyerToolStripMenuItem.Name = "BuyerToolStripMenuItem";
            this.BuyerToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.BuyerToolStripMenuItem.Text = "Покупатель";
            this.BuyerToolStripMenuItem.Click += new System.EventHandler(this.BuyerToolStripMenuItem_Click);
            // 
            // materialImplementationToolStripMenuItem
            // 
            this.materialImplementationToolStripMenuItem.Name = "materialImplementationToolStripMenuItem";
            this.materialImplementationToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.materialImplementationToolStripMenuItem.Text = "Реализация материалов";
            this.materialImplementationToolStripMenuItem.Click += new System.EventHandler(this.materialImplementationToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.transactionsToolStripMenuItem.Text = "Проводки";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // ReportToolStripMenuItem
            // 
            this.ReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportMaterialSaleToolStripMenuItem,
            this.ReportRemainsToolStripMenuItem});
            this.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem";
            this.ReportToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ReportToolStripMenuItem.Text = "Отчеты";
            // 
            // ReportMaterialSaleToolStripMenuItem
            // 
            this.ReportMaterialSaleToolStripMenuItem.Name = "ReportMaterialSaleToolStripMenuItem";
            this.ReportMaterialSaleToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.ReportMaterialSaleToolStripMenuItem.Text = "Отчет по продажам материалов";
            this.ReportMaterialSaleToolStripMenuItem.Click += new System.EventHandler(this.ReportMaterialSaleToolStripMenuItem_Click);
            // 
            // ReportRemainsToolStripMenuItem
            // 
            this.ReportRemainsToolStripMenuItem.Name = "ReportRemainsToolStripMenuItem";
            this.ReportRemainsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.ReportRemainsToolStripMenuItem.Text = "Отчет по остаткам";
            this.ReportRemainsToolStripMenuItem.Click += new System.EventHandler(this.ReportRemainsToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(679, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбора языка";
            // 
            // LogsToolStripMenuItem
            // 
            this.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem";
            this.LogsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.LogsToolStripMenuItem.Text = "Логи";
            this.LogsToolStripMenuItem.Click += new System.EventHandler(this.LogsToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartOfAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MOLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StoragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuyerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialImplementationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ReportMaterialSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportRemainsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogsToolStripMenuItem;
    }
}

