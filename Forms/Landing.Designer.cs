namespace Metadata_Manager.Forms
{
   partial class Landing
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
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemOpenPdf = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.ReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openPdfFile = new System.Windows.Forms.OpenFileDialog();
			this.dataGridMain = new System.Windows.Forms.DataGridView();
			this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
			this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Published = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RecordSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
			this.SuspendLayout();
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.ReportMenuItem});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(1055, 24);
			this.menuMain.TabIndex = 0;
			this.menuMain.Text = "Main Menu";
			// 
			// menuItemFile
			// 
			this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpenPdf,
            this.menuItemExit});
			this.menuItemFile.Name = "menuItemFile";
			this.menuItemFile.Size = new System.Drawing.Size(37, 20);
			this.menuItemFile.Text = "File";
			// 
			// menuItemOpenPdf
			// 
			this.menuItemOpenPdf.Name = "menuItemOpenPdf";
			this.menuItemOpenPdf.Size = new System.Drawing.Size(180, 22);
			this.menuItemOpenPdf.Text = "Open pdf(s)";
			this.menuItemOpenPdf.Click += new System.EventHandler(this.openPdfsToolStripMenuItem_Click);
			// 
			// menuItemExit
			// 
			this.menuItemExit.Name = "menuItemExit";
			this.menuItemExit.Size = new System.Drawing.Size(180, 22);
			this.menuItemExit.Text = "Exit";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// ReportMenuItem
			// 
			this.ReportMenuItem.Enabled = false;
			this.ReportMenuItem.Name = "ReportMenuItem";
			this.ReportMenuItem.Size = new System.Drawing.Size(80, 20);
			this.ReportMenuItem.Text = "Export Data";
			this.ReportMenuItem.Click += new System.EventHandler(this.ExportData);
			// 
			// openPdfFile
			// 
			this.openPdfFile.DefaultExt = "pdf";
			this.openPdfFile.Filter = "Pdf files | *.pdf";
			this.openPdfFile.Multiselect = true;
			this.openPdfFile.Title = "Open Files";
			// 
			// dataGridMain
			// 
			this.dataGridMain.AllowUserToAddRows = false;
			this.dataGridMain.AllowUserToDeleteRows = false;
			this.dataGridMain.AllowUserToResizeRows = false;
			this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.Details,
            this.FileName,
            this.Title,
            this.Author,
            this.Published,
            this.RecordSeries,
            this.FilePath});
			this.dataGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridMain.Location = new System.Drawing.Point(0, 24);
			this.dataGridMain.Name = "dataGridMain";
			this.dataGridMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.dataGridMain.RowTemplate.Height = 25;
			this.dataGridMain.Size = new System.Drawing.Size(1055, 421);
			this.dataGridMain.TabIndex = 5;
			this.dataGridMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMain_CellClick);
			this.dataGridMain.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMain_CellValueChanged);
			this.dataGridMain.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridMain_RowValidating);
			// 
			// Selected
			// 
			this.Selected.DataPropertyName = "Selected";
			this.Selected.Frozen = true;
			this.Selected.HeaderText = "";
			this.Selected.Name = "Selected";
			this.Selected.Width = 25;
			// 
			// Details
			// 
			this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.Details.DataPropertyName = "Details";
			this.Details.Frozen = true;
			this.Details.HeaderText = "...";
			this.Details.Name = "Details";
			this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Details.Width = 22;
			// 
			// FileName
			// 
			this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.FileName.DataPropertyName = "FileName";
			this.FileName.Frozen = true;
			this.FileName.HeaderText = "File Name";
			this.FileName.Name = "FileName";
			this.FileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.FileName.Width = 85;
			// 
			// Title
			// 
			this.Title.DataPropertyName = "Title";
			this.Title.HeaderText = "Title";
			this.Title.Name = "Title";
			// 
			// Author
			// 
			this.Author.DataPropertyName = "Author";
			this.Author.HeaderText = "Author(s)";
			this.Author.Name = "Author";
			// 
			// Published
			// 
			this.Published.DataPropertyName = "Published";
			this.Published.HeaderText = "Published";
			this.Published.Name = "Published";
			// 
			// RecordSeries
			// 
			this.RecordSeries.DataPropertyName = "RecordSeries";
			this.RecordSeries.HeaderText = "Record Series";
			this.RecordSeries.Name = "RecordSeries";
			// 
			// FilePath
			// 
			this.FilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FilePath.DataPropertyName = "FilePath";
			this.FilePath.HeaderText = "Path";
			this.FilePath.Name = "FilePath";
			this.FilePath.ReadOnly = true;
			// 
			// Landing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1055, 445);
			this.Controls.Add(this.dataGridMain);
			this.Controls.Add(this.menuMain);
			this.MainMenuStrip = this.menuMain;
			this.Name = "Landing";
			this.Text = "Landing";
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion

      private MenuStrip menuMain;
      private ToolStripMenuItem menuItemFile;
      private ToolStripMenuItem menuItemOpenPdf;
      private ToolStripMenuItem menuItemExit;
      private OpenFileDialog openPdfFile;
      private DataGridView dataGridMain;
		private DataGridViewCheckBoxColumn Selected;
		private DataGridViewButtonColumn Details;
		private DataGridViewTextBoxColumn FileName;
		private DataGridViewTextBoxColumn Title;
		private DataGridViewTextBoxColumn Author;
		private DataGridViewTextBoxColumn Published;
		private DataGridViewTextBoxColumn RecordSeries;
		private DataGridViewTextBoxColumn FilePath;
		private ToolStripMenuItem ReportMenuItem;
	}
}