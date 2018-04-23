using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace RowsPopupMenu
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		internal System.Windows.Forms.ContextMenu ContextMenu1;
		internal System.Windows.Forms.MenuItem MenuItem1;
		internal System.Windows.Forms.MenuItem MenuItem2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ContextMenu1 = new System.Windows.Forms.ContextMenu();
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuItem2 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(520, 317);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridView1_ShowGridMenu);
            // 
            // ContextMenu1
            // 
            this.ContextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem1,
            this.MenuItem2});
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 0;
            this.MenuItem1.Text = "Edit";
            this.MenuItem1.Click += new System.EventHandler(this.MenuItem1_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.Index = 1;
            this.MenuItem2.Text = "Delete";
            this.MenuItem2.Click += new System.EventHandler(this.MenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(520, 317);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e) {
			new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1);
		}
		private void gridView1_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e) {
			GridView view = (GridView)sender;
			GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
			if(hitInfo.InRow) {
				view.FocusedRowHandle = hitInfo.RowHandle;
				ContextMenu1.Show(view.GridControl, e.Point);
			}
		}
		private void MenuItem1_Click(object sender, System.EventArgs e) {
			gridView1.ShowEditor();
		}
		private void MenuItem2_Click(object sender, System.EventArgs e) {
			gridView1.DeleteRow(gridView1.FocusedRowHandle);
		}
	}
}
