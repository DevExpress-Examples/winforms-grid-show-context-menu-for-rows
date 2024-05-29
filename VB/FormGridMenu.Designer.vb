Namespace RowsPopupMenu

    Partial Class FormGridMenu

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
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
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(448, 317)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            AddHandler Me.gridView1.PopupMenuShowing, New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(AddressOf Me.gridView1_PopupMenuShowing)
            ' 
            ' ContextMenu1
            ' 
            Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
            ' 
            ' MenuItem1
            ' 
            Me.MenuItem1.Index = 0
            Me.MenuItem1.Text = "Edit"
            AddHandler Me.MenuItem1.Click, New System.EventHandler(AddressOf Me.ItemEdit_Click)
            ' 
            ' MenuItem2
            ' 
            Me.MenuItem2.Index = 1
            Me.MenuItem2.Text = "Delete"
            AddHandler Me.MenuItem2.Click, New System.EventHandler(AddressOf Me.ItemDelete_Click)
            ' 
            ' radioGroup1
            ' 
            Me.radioGroup1.EditValue = "DevExpress Menu"
            Me.radioGroup1.Location = New System.Drawing.Point(454, 12)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Standard Menu", "Standard Menu"), New DevExpress.XtraEditors.Controls.RadioGroupItem("DevExpress Menu", "DevExpress Menu")})
            Me.radioGroup1.Size = New System.Drawing.Size(116, 80)
            Me.radioGroup1.TabIndex = 1
            ' 
            ' FormGridMenu
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(575, 317)
            Me.Controls.Add(Me.radioGroup1)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "FormGridMenu"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Friend ContextMenu1 As System.Windows.Forms.ContextMenu

        Friend MenuItem1 As System.Windows.Forms.MenuItem

        Friend MenuItem2 As System.Windows.Forms.MenuItem

        Private radioGroup1 As DevExpress.XtraEditors.RadioGroup
    End Class
End Namespace
