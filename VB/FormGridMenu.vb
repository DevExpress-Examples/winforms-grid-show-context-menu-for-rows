Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Windows.Forms

Namespace RowsPopupMenu

    Public Partial Class FormGridMenu
        Inherits Form

        Public Sub New()
            InitializeComponent()
            InitializeMenuItems()
        End Sub

        Private menuItems As DXMenuItem()

        Private Sub InitializeMenuItems()
            Dim itemEdit As DXMenuItem = New DXMenuItem("Edit", AddressOf ItemEdit_Click)
            Dim itemDelete As DXMenuItem = New DXMenuItem("Delete", AddressOf ItemDelete_Click)
            menuItems = New DXMenuItem() {itemEdit, itemDelete}
        End Sub

        Private Sub gridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.HitInfo.InRow Then
                Dim view As GridView = TryCast(sender, GridView)
                view.FocusedRowHandle = e.HitInfo.RowHandle
                If Equals(radioGroup1.EditValue.ToString(), "Standard Menu") Then ContextMenu1.Show(view.GridControl, e.Point)
                If Equals(radioGroup1.EditValue.ToString(), "DevExpress Menu") Then
                    For Each item As DXMenuItem In menuItems
                        e.Menu.Items.Add(item)
                    Next
                End If
            End If
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim tmp_XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
        End Sub

        Private Sub ItemEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.ShowEditor()
        End Sub

        Private Sub ItemDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.DeleteRow(gridView1.FocusedRowHandle)
        End Sub
    End Class
End Namespace
