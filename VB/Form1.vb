Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace RowsPopupMenu
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Friend ContextMenu1 As System.Windows.Forms.ContextMenu
		Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
		Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
			Me.MenuItem1 = New System.Windows.Forms.MenuItem()
			Me.MenuItem2 = New System.Windows.Forms.MenuItem()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(520, 317)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.ShowGridMenu += New DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(Me.gridView1_ShowGridMenu);
			' 
			' ContextMenu1
			' 
			Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.MenuItem1, Me.MenuItem2})
			' 
			' MenuItem1
			' 
			Me.MenuItem1.Index = 0
			Me.MenuItem1.Text = "Edit"
'			Me.MenuItem1.Click += New System.EventHandler(Me.MenuItem1_Click);
			' 
			' MenuItem2
			' 
			Me.MenuItem2.Index = 1
			Me.MenuItem2.Text = "Delete"
'			Me.MenuItem2.Click += New System.EventHandler(Me.MenuItem2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(520, 317)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim TempXViewsPrinting As DevExpress.XtraGrid.Design.XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
		End Sub
		Private Sub gridView1_ShowGridMenu(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs) Handles gridView1.ShowGridMenu
			Dim view As GridView = CType(sender, GridView)
			Dim hitInfo As GridHitInfo = view.CalcHitInfo(e.Point)
			If hitInfo.InRow Then
				view.FocusedRowHandle = hitInfo.RowHandle
				ContextMenu1.Show(view.GridControl, e.Point)
			End If
		End Sub
		Private Sub MenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
			gridView1.ShowEditor()
		End Sub
		Private Sub MenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
			gridView1.DeleteRow(gridView1.FocusedRowHandle)
		End Sub
	End Class
End Namespace
