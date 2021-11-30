using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook.Navigation
{
    class SystemNavigation
    {
        public static void NavigateDoubleClick(string NodeText, DevExpress.XtraEditors.XtraForm form)
        {
            string ChildNode = NodeText;

            //Approval Entries
            MenuItems.DashboardClick(ChildNode);
            MenuItems.ApprovalEntriesClick(ChildNode);
            MenuItems.ReportsClick(ChildNode, form);
            MenuItems.MembersClick(ChildNode);
            MenuItems.SavingsClick(ChildNode);
            MenuItems.LoansClick(ChildNode);
        }

        public static void Navigate(DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e, DevExpress.XtraTreeList.TreeList Tree, DevExpress.XtraEditors.XtraForm form)
        {
            string ChildNode = e.Node.GetValue(Tree.Columns[0]).ToString();

            //Approval Entries
            MenuItems.DashboardClick(ChildNode);
            MenuItems.ApprovalEntriesClick(ChildNode);
            MenuItems.ReportsClick(ChildNode, form);
            MenuItems.MembersClick(ChildNode);
            MenuItems.SavingsClick(ChildNode);
            MenuItems.LoansClick(ChildNode);
        }
    }
}
