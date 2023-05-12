using CarDealershipApp.DataBaseApi.Tables;
using System.Data;

namespace CarDealershipApp.Forms
{
    public partial class SaleForm : Form
    {
        SalesTable Table;
        List<int> hideIds;
        bool isSave=true;

        void LocalLoadData()
        {
            if (DGV.CurrentRow.Index < 0) return;
            CarsCB.SelectedItem = DGV.CurrentRow.Cells[4].Value.ToString();
            EmployeesCB.SelectedItem = DGV.CurrentRow.Cells[6].Value.ToString();
            BuyersCB.SelectedItem = DGV.CurrentRow.Cells[8].Value.ToString();
            CostTB.Text = DGV.CurrentRow.Cells[7].Value.ToString();
            if(DGV.CurrentRow.Cells[9].Value != DBNull.Value)
                TradeDateDTP.Value = Convert.ToDateTime(DGV.CurrentRow.Cells[9].Value);
        }

        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            Table = new SalesTable();
            if (Table.SalesList == null)
                return;
            hideIds = new List<int>();
            DGV.DataSource = Table.DataTable;
            for (int i = 0; i < 4; i++)
                DGV.Columns[i].Visible = false;
            CarsCB.DataSource = Table.CarsPassportsTable.CarPassportList.Select(x => x.Car.GetFullName()).ToList();
            BuyersCB.Items.Add("");
            BuyersCB.Items.AddRange(Table.CarsPassportsTable.OwnerTable.PeoplesList.Select(x => x.GetFullName()).ToArray());
            EmployeesCB.DataSource = Table.EmployeesTable.EmployeesList.Select(x => x.GetFullName()).ToList();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            if (ExtraTools.IsTextBoxesEmpty(CostTB) || CarsCB.SelectedIndex == -1 || EmployeesCB.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните поле!", "Внимание");
                return;
            }
            long cost;
            if (!long.TryParse(CostTB.Text, out cost))
            {
                MessageBox.Show("Введите корректную цену!", "Внимание");
                return;
            }
            if (EditCB.CheckState == CheckState.Checked)
            {
                int id = DGV.CurrentRow.Index;
                Table.SalesList[id].Cost = cost;
                Table.SalesList[id].Employee = Table.EmployeesTable.EmployeesList[EmployeesCB.SelectedIndex];
                Table.SalesList[id].CarBuyer = BuyersCB.SelectedIndex < 1 ? null : Table.CarsPassportsTable.OwnerTable.PeoplesList[BuyersCB.SelectedIndex-1];
                Table.SalesList[id].PassportCar = Table.CarsPassportsTable.CarPassportList[CarsCB.SelectedIndex];
                object date;
                if (BuyersCB.SelectedIndex < 1)
                {
                    Table.SalesList[id].Status = "Продаётся";
                    Table.SalesList[id].Date = null;
                    date = DBNull.Value;
                }
                else
                {
                    Table.SalesList[id].Status = "Продано";
                    Table.SalesList[id].Date = TradeDateDTP.Value;
                    date = Table.SalesList[id].Date;
                }

                var i = Table.DataTable.Rows[id].ItemArray[0];
                Table.DataTable.Rows[id].ItemArray = new object[] { i, Table.SalesList[id].PassportCar.Id, Table.SalesList[id].Employee.Id, Table.SalesList[id].CarBuyer?.Id, Table.SalesList[id].PassportCar.Car.GetFullName(), Table.SalesList[id].PassportCar.Owner.GetFullName(), Table.SalesList[id].Employee.GetFullName(), Table.SalesList[id].Cost, Table.SalesList[id].CarBuyer?.GetFullName()?? "", date, Table.SalesList[id].Status };
            }
            else
            {
                object date;
                if (BuyersCB.SelectedIndex < 1)
                {
                    date = DBNull.Value;
                }
                else
                {
                    date = TradeDateDTP.Value;
                }
                Table.SalesList.Add(new Entity.Sale(-1, Table.CarsPassportsTable.CarPassportList[CarsCB.SelectedIndex], Table.EmployeesTable.EmployeesList[EmployeesCB.SelectedIndex], cost, BuyersCB.SelectedIndex < 1 ? null : Table.CarsPassportsTable.OwnerTable.PeoplesList[BuyersCB.SelectedIndex-1], TradeDateDTP.Value));
                int id = Table.SalesList.Count - 1;
                Table.DataTable.Rows.Add(-1, Table.SalesList[id].PassportCar.Id, Table.SalesList[id].Employee.Id, Table.SalesList[id].CarBuyer?.Id, Table.SalesList[id].PassportCar.Car.GetFullName(), Table.SalesList[id].PassportCar.Owner.GetFullName(), Table.SalesList[id].Employee.GetFullName(), Table.SalesList[id].Cost, Table.SalesList[id].CarBuyer?.GetFullName()??"", date, Table.SalesList[id].Status);
                ExtraTools.HideRows(DGV, hideIds);
            }
            ExtraTools.ClearTB(CostTB);
            CarsCB.SelectedIndex = EmployeesCB.SelectedIndex = BuyersCB.SelectedIndex = -1;
            if (isSave)
                isSave = false;
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count < 1) return;
            var rows = DGV.SelectedRows;
            DGV.CurrentCell = null;
            foreach (DataGridViewRow item in rows)
            {
                item.Visible = false;
                hideIds.Add(item.Index);
                Table.SalesList[item.Index].IsDelete = true;
            }
            if (isSave)
                isSave = false;
        }

        private void EditCB_CheckedChanged(object sender, EventArgs e)
        {
            if (EditCB.CheckState == CheckState.Checked)
            {
                AddBTN.Text = "Изменить";
                LocalLoadData();
            }
            else
            {
                AddBTN.Text = "Добавить";
                ExtraTools.ClearTB(CostTB);
                CarsCB.SelectedIndex = EmployeesCB.SelectedIndex = BuyersCB.SelectedIndex = -1;
            }
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (Table.SaveTable())
            {
                MessageBox.Show("Всё сохранено", "Успех");
                if (!isSave)
                    isSave = true;
            }
            else
                MessageBox.Show("Что-то пошло не так!", "Ошибка");
        }

        private void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (EditCB.CheckState == CheckState.Unchecked) return;
            LocalLoadData();
        }

        private void SaleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSave)
            {
                switch (MessageBox.Show("Вы не сохранили данные, сохранить?", "Внимание", MessageBoxButtons.YesNoCancel))
                {
                    case (DialogResult.Yes):
                        Table.SaveTable();
                        break;
                    case (DialogResult.Cancel):
                        e.Cancel = true;
                        break;
                    case (DialogResult.No): break;
                }
            }
        }
    }
}
