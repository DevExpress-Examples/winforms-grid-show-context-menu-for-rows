Imports System
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace RowsPopupMenu
    Public Partial Class FormGridMenu
        Inherits DevExpress.XtraEditors.XtraForm
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(sender As Object, e As EventArgs)
            Dim tmp_XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
        End Sub

        Private Sub gridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs)
            If e.MenuType = GridMenuType.Row Then
                popupMenu_Row.Tag = e.HitInfo
                e.ShowCustomMenu(popupMenu_Row)
            End If
        End Sub
        Private Function GetHitInfo(link As BarItemLink) As GridHitInfo
            Dim menu As PopupMenu = TryCast(link.LinkedObject, PopupMenu)
            Return TryCast(menu.Tag, GridHitInfo)
        End Function

        Private Sub barButtonItem_Edit_ItemClick(sender As Object, e As ItemClickEventArgs)
            Dim info = GetHitInfo(e.Link)
            info?.View.ShowEditor()
        End Sub

        Private Sub barButtonItem_Delete_ItemClick(sender As Object, e As ItemClickEventArgs)
            Dim info = GetHitInfo(e.Link)
            info.View.DeleteRow(info.View.FocusedRowHandle)
        End Sub
    End Class
End Namespace
