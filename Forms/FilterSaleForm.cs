using CarDealershipApp.DataBaseApi.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarDealershipApp.Forms
{
    public partial class FilterSaleForm : Form
    {
        SalesTable Table;
        public FilterSaleForm()
        {
            InitializeComponent();
        }

        private void FilterSaleForm_Load(object sender, EventArgs e)
        {
            Table = new SalesTable();
            if (Table.SalesList == null)
                return;
            DGV.DataSource = Table.DataTable;
            for (int i = 0; i < 4; i++)
                DGV.Columns[i].Visible = false;
        }

        private void ApplyBTN_Click(object sender, EventArgs e)
        {
            if (isSurname.CheckState == CheckState.Checked && !string.IsNullOrEmpty(SurnameOwnerTB.Text))
                Table.FilterBySurnameOwner(SurnameOwnerTB.Text);
            if (isNumberCar.CheckState==CheckState.Checked && !string.IsNullOrEmpty(NumberCarTB.Text))
                Table.FilterByNumberCar(NumberCarTB.Text);
            if (isTrademarkCar.CheckState == CheckState.Checked && !string.IsNullOrEmpty(TrademarkCarTB.Text))
                Table.FilterByTrademarkCar(TrademarkCarTB.Text);
            if (isStatus.CheckState == CheckState.Checked && StatusCB.SelectedIndex != -1)
                Table.FilterByStatus(StatusCB.SelectedItem.ToString());
            if (isSoloDate.CheckState == CheckState.Checked)
                Table.FilterByDate(SoloDTP.Value.ToShortDateString());
            if (isDates.CheckState == CheckState.Checked)
                Table.FilterByDates(FirstDTP.Value.ToShortDateString(), SecDTP.Value.ToShortDateString());
            if (isCost.CheckState == CheckState.Checked)
            {
                long fcost, scost;
                if(long.TryParse(FirstCostTB.Text, out fcost) && long.TryParse(SecCostTB.Text, out scost))
                    Table.FilterByCost(fcost, scost);
            }

            Table.ApplyFilter();
            DGV.DataSource = Table.DataTable;
        }

        private void isSoloDate_CheckedChanged(object sender, EventArgs e)
        {
            if (isSoloDate.CheckState == CheckState.Checked)
                isDates.CheckState = CheckState.Unchecked;
        }

        private void isDates_CheckedChanged(object sender, EventArgs e)
        {
            if (isDates.CheckState == CheckState.Checked)
                isSoloDate.CheckState = CheckState.Unchecked;
        }

        private void FirstCostTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void SecCostTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
