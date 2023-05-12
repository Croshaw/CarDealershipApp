using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipApp
{
    internal class ExtraTools
    {
        public static void ClearTB(params TextBox[] controls)
        {
            foreach (var control in controls)
            {
                control.Clear();
            }
        }

        public static bool IsTextBoxesEmpty(params TextBox[] controls)
        {
            foreach (var control in controls)
            {
                if (string.IsNullOrEmpty(control.Text))
                    return true;
            }
            return false;
        }

        public static void HideRows(DataGridView DGV, List<int> hideIds)
        {
            DGV.CurrentCell = null;
            foreach (var id in hideIds)
                DGV.Rows[id].Visible = false;
        }
        public static bool LoadData(DataGridViewRow row, int startId, params Control[] controls)
        {
            if(row == null) return false;
            if (row.Index < 0) return false;
            foreach (var control in controls)
            {
                if (control is System.Windows.Forms.TextBox)
                    control.Text = row.Cells[startId++].Value.ToString();
                else startId++;
            }
            return true;
        }
    }
}
