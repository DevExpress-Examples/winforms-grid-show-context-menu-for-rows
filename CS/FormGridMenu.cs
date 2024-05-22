using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace RowsPopupMenu {
    public partial class FormGridMenu : DevExpress.XtraEditors.XtraForm {
        public FormGridMenu() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e) {
            new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1);
        }

        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if (e.MenuType == GridMenuType.Row) {
                popupMenu_Row.Tag = e.HitInfo;
                e.ShowCustomMenu(popupMenu_Row);
            }
        }
        GridHitInfo GetHitInfo(BarItemLink link) {
            PopupMenu menu = link.LinkedObject as PopupMenu;
            return menu.Tag as GridHitInfo;
        }

        private void barButtonItem_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GridHitInfo info = GetHitInfo(e.Link);
            info?.View.ShowEditor();
        }

        private void barButtonItem_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GridHitInfo info = GetHitInfo(e.Link);
            info.View.DeleteRow(info.View.FocusedRowHandle);
        }
    }
}
