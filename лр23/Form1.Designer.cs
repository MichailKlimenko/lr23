
namespace лр23
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BikeRentalDBDataSet = new лр23.BikeRentalDBDataSet();
            this.RentalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RentalsTableAdapter = new лр23.BikeRentalDBDataSetTableAdapters.RentalsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.прокатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.велосипедToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.BikeRentalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.RentalsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "лр23.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 27);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(746, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // BikeRentalDBDataSet
            // 
            this.BikeRentalDBDataSet.DataSetName = "BikeRentalDBDataSet";
            this.BikeRentalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RentalsBindingSource
            // 
            this.RentalsBindingSource.DataMember = "Rentals";
            this.RentalsBindingSource.DataSource = this.BikeRentalDBDataSet;
            // 
            // RentalsTableAdapter
            // 
            this.RentalsTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прокатToolStripMenuItem,
            this.велосипедToolStripMenuItem,
            this.клиентToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // прокатToolStripMenuItem
            // 
            this.прокатToolStripMenuItem.Name = "прокатToolStripMenuItem";
            this.прокатToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.прокатToolStripMenuItem.Text = "Прокат";
            this.прокатToolStripMenuItem.Click += new System.EventHandler(this.прокатToolStripMenuItem_Click);
            // 
            // велосипедToolStripMenuItem
            // 
            this.велосипедToolStripMenuItem.Name = "велосипедToolStripMenuItem";
            this.велосипедToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.велосипедToolStripMenuItem.Text = "Велосипед";
            this.велосипедToolStripMenuItem.Click += new System.EventHandler(this.велосипедToolStripMenuItem_Click);
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.клиентToolStripMenuItem.Text = "Клиент";
            this.клиентToolStripMenuItem.Click += new System.EventHandler(this.клиентToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BikeRentalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RentalsBindingSource;
        private BikeRentalDBDataSet BikeRentalDBDataSet;
        private BikeRentalDBDataSetTableAdapters.RentalsTableAdapter RentalsTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem прокатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem велосипедToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
    }
}

