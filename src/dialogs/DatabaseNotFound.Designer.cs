using System.Windows.Forms;
using static Oire.Notika.Helpers.Tr;

namespace Oire.Notika.Dialogs {
	partial class DatabaseNotFound {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Form controls

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.mainPanel = new TableLayoutPanel();
			this.databaseNotFoundLabel = new Label();
			this.fileNameLabel = new Label();
			this.fileName = new TextBox();
			this.browse = new Button();
			this.ok = new Button();
			this.cancel = new Button();

			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			//
			// mainPanel
			//
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Location = new System.Drawing.Point(1, 1);
			this.mainPanel.Dock = DockStyle.Fill;
			this.mainPanel.RowCount = 3;
			this.mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30f));
			this.mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 35f));
			this.mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 35f));
			this.mainPanel.ColumnCount = 3;
			this.mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
			this.mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70f));
			this.mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
			this.mainPanel.Controls.Add(this.databaseNotFoundLabel, 0, 0);
			this.mainPanel.SetColumnSpan(this.databaseNotFoundLabel, 3);
			this.mainPanel.Controls.Add(this.fileNameLabel, 0, 1);
			this.mainPanel.Controls.Add(this.fileName, 1, 1);
			this.mainPanel.Controls.Add(this.browse, 2, 1);
			this.mainPanel.Controls.Add(this.ok, 0, 2);
			this.mainPanel.Controls.Add(this.cancel, 2, 2);
			//
			// databaseNotFoundLabel
			//
			this.databaseNotFoundLabel.Name = "databaseNotFoundLabel";
			this.databaseNotFoundLabel.Dock = DockStyle.Fill;
			this.databaseNotFoundLabel.TabStop = false;
			this.databaseNotFoundLabel.AccessibleRole = AccessibleRole.StaticText;
			this.databaseNotFoundLabel.Text = _("The notes database could not be found. Please select database location.\nIf you run Notika for the first time, you may leave the path field blank. If you do so, the database will be created in the default location.");
			//
			// fileNameLabel
			//
			this.fileNameLabel.Name = "fileNameLabel";
			this.fileNameLabel.Dock = DockStyle.Fill;
			this.fileNameLabel.TabStop = false;
			this.fileNameLabel.Text = _("&File Name:");
			// 
			// fileName
			// 
			this.fileName.Name = "fileName";
			this.fileName.Dock = DockStyle.Fill;
			this.fileName.TabStop = true;
			this.fileName.Text = Config.database.location;
			// 
			// browse
			// 
			this.browse.Name = "browse";
			this.browse.Dock = DockStyle.Fill;
			this.browse.TabStop = true;
			this.browse.Text = _("&Browse...");
			this.browse.Click += new System.EventHandler(this.browse_Click);
			//
			// ok
			//
			this.ok.Name = "ok";
			this.ok.Dock = DockStyle.Fill;
			this.ok.TabStop = true;
			this.ok.Text = _("&OK");
			this.ok.Click += new System.EventHandler(this.ok_Click);
			//
			// Cancel
			//
			this.cancel.Name = "cancel";
			this.cancel.Dock = DockStyle.Fill;
			this.cancel.TabStop = true;
			this.cancel.Text = _("&Cancel");
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// DatabaseNotFound
			//
			this.Size = new System.Drawing.Size(800, 120);
			this.Controls.Add(this.mainPanel);
			this.AccessibleRole = AccessibleRole.Dialog;
			this.AcceptButton = this.ok;
			this.CancelButton = this.cancel;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.ControlBox = false;
			this.Name = "DatabaseNotFound";
			this.Text = _("Notes Database Not Found");

			this.mainPanel.ResumeLayout(true);
			this.ResumeLayout(true);
		}

		#endregion

		private TableLayoutPanel mainPanel;
		private Label databaseNotFoundLabel;
		private Label fileNameLabel;
		private TextBox fileName;
		private Button browse;
		private Button ok;
		private Button cancel;
	}
}