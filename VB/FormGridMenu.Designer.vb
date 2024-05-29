Imports System

Namespace RowsPopupMenu
    Partial Class FormGridMenu
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormGridMenu))
            gridControl1 = New DevExpress.XtraGrid.GridControl()
            gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            popupMenu_Row = New DevExpress.XtraBars.PopupMenu(components)
            barButtonItem_Edit = New DevExpress.XtraBars.BarButtonItem()
            barButtonItem_Delete = New DevExpress.XtraBars.BarButtonItem()
            barManager1 = New DevExpress.XtraBars.BarManager(components)
            barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            CType(gridControl1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gridView1, ComponentModel.ISupportInitialize).BeginInit()
            CType(popupMenu_Row, ComponentModel.ISupportInitialize).BeginInit()
            CType(barManager1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' gridControl1
            ' 
            gridControl1.Dock = Windows.Forms.DockStyle.Fill
            gridControl1.Location = New Drawing.Point(0, 0)
            gridControl1.MainView = gridView1
            gridControl1.Name = "gridControl1"
            gridControl1.Size = New Drawing.Size(1015, 542)
            gridControl1.TabIndex = 0
            gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {gridView1})
            ' 
            ' gridView1
            ' 
            gridView1.GridControl = gridControl1
            gridView1.Name = "gridView1"
            AddHandler gridView1.PopupMenuShowing, New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(AddressOf gridView1_PopupMenuShowing)
            ' 
            ' popupMenu_Row
            ' 
            popupMenu_Row.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(barButtonItem_Edit), New DevExpress.XtraBars.LinkPersistInfo(barButtonItem_Delete)})
            popupMenu_Row.Manager = barManager1
            popupMenu_Row.Name = "popupMenu_Row"
            ' 
            ' barButtonItem_Edit
            ' 
            barButtonItem_Edit.Caption = "Edit"
            barButtonItem_Edit.Id = 0
            barButtonItem_Edit.ImageOptions.SvgImage = CType(resources.GetObject("barButtonItem_Edit.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            barButtonItem_Edit.Name = "barButtonItem_Edit"
            AddHandler barButtonItem_Edit.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf barButtonItem_Edit_ItemClick)
            ' 
            ' barButtonItem_Delete
            ' 
            barButtonItem_Delete.Caption = "Delete"
            barButtonItem_Delete.Id = 1
            barButtonItem_Delete.ImageOptions.SvgImage = CType(resources.GetObject("barButtonItem_Delete.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            barButtonItem_Delete.Name = "barButtonItem_Delete"
            AddHandler barButtonItem_Delete.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf barButtonItem_Delete_ItemClick)
            ' 
            ' barManager1
            ' 
            barManager1.DockControls.Add(barDockControlTop)
            barManager1.DockControls.Add(barDockControlBottom)
            barManager1.DockControls.Add(barDockControlLeft)
            barManager1.DockControls.Add(barDockControlRight)
            barManager1.Form = Me
            barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {barButtonItem_Edit, barButtonItem_Delete})
            barManager1.MaxItemId = 2
            ' 
            ' barDockControlTop
            ' 
            barDockControlTop.CausesValidation = False
            barDockControlTop.Dock = Windows.Forms.DockStyle.Top
            barDockControlTop.Location = New Drawing.Point(0, 0)
            barDockControlTop.Manager = barManager1
            barDockControlTop.Size = New Drawing.Size(1015, 0)
            ' 
            ' barDockControlBottom
            ' 
            barDockControlBottom.CausesValidation = False
            barDockControlBottom.Dock = Windows.Forms.DockStyle.Bottom
            barDockControlBottom.Location = New Drawing.Point(0, 542)
            barDockControlBottom.Manager = barManager1
            barDockControlBottom.Size = New Drawing.Size(1015, 0)
            ' 
            ' barDockControlLeft
            ' 
            barDockControlLeft.CausesValidation = False
            barDockControlLeft.Dock = Windows.Forms.DockStyle.Left
            barDockControlLeft.Location = New Drawing.Point(0, 0)
            barDockControlLeft.Manager = barManager1
            barDockControlLeft.Size = New Drawing.Size(0, 542)
            ' 
            ' barDockControlRight
            ' 
            barDockControlRight.CausesValidation = False
            barDockControlRight.Dock = Windows.Forms.DockStyle.Right
            barDockControlRight.Location = New Drawing.Point(1015, 0)
            barDockControlRight.Manager = barManager1
            barDockControlRight.Size = New Drawing.Size(0, 542)
            ' 
            ' FormGridMenu
            ' 
            AutoScaleBaseSize = New Drawing.Size(10, 26)
            ClientSize = New Drawing.Size(1015, 542)
            Controls.Add(gridControl1)
            Controls.Add(barDockControlLeft)
            Controls.Add(barDockControlRight)
            Controls.Add(barDockControlBottom)
            Controls.Add(barDockControlTop)
            Name = "FormGridMenu"
            Text = "Form1"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            CType(gridControl1, ComponentModel.ISupportInitialize).EndInit()
            CType(gridView1, ComponentModel.ISupportInitialize).EndInit()
            CType(popupMenu_Row, ComponentModel.ISupportInitialize).EndInit()
            CType(barManager1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private popupMenu_Row As DevExpress.XtraBars.PopupMenu
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private barButtonItem_Edit As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem_Delete As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace
