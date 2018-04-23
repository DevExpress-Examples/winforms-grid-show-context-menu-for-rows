using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RowsPopupMenu
{
    public partial class FormGridMenu : Form
    {
        public FormGridMenu()
        {
            InitializeComponent();
            InitializeMenuItems();
        }

        DXMenuItem[] menuItems;
        void InitializeMenuItems()
        {
            DXMenuItem itemEdit = new DXMenuItem("Edit", ItemEdit_Click);
            DXMenuItem itemDelete = new DXMenuItem("Delete", ItemDelete_Click);
            menuItems = new DXMenuItem[] { itemEdit, itemDelete };
        }

        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                GridView view = sender as GridView;
                view.FocusedRowHandle = e.HitInfo.RowHandle;

                if (radioGroup1.EditValue.ToString() == "Standard Menu")
                    ContextMenu1.Show(view.GridControl, e.Point);

                if (radioGroup1.EditValue.ToString() == "DevExpress Menu") {
                    foreach (DXMenuItem item in menuItems)
                        e.Menu.Items.Add(item);
                }
            }
        }
        

        private void Form1_Load(object sender, System.EventArgs e)
        {
            new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1);
        }
        private void ItemEdit_Click(object sender, System.EventArgs e)
        {
            gridView1.ShowEditor();
        }
        private void ItemDelete_Click(object sender, System.EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }
    }
}
