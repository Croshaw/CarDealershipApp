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

namespace CarDealershipApp.Forms
{
    public partial class CarPassportForm : Form
    {
        CarsPassportsTable Table;
        List<int> hideIds;
        bool isSave = true;

        public CarPassportForm()
        {
            InitializeComponent();
        }

        private void CarPassportForm_Load(object sender, EventArgs e)
        {
            Table = new CarsPassportsTable();
            if (Table.CarPassportList == null)
                return;
            hideIds = new List<int>();
            CarsPassportsDGV.DataSource = Table.DataTable;
            CarsPassportsDGV.Columns[0].Visible = CarsPassportsDGV.Columns[1].Visible = CarsPassportsDGV.Columns[3].Visible = false;
            CarsCB.DataSource = Table.CarsTable.CarsList.Select(x=>x.GetFullName()).ToList();
            OwnersCB.DataSource = Table.OwnerTable.PeoplesList.Select(x => x.GetFullName()).ToList();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            if (ExtraTools.IsTextBoxesEmpty(NumberTB) || CarsCB.SelectedIndex==-1 || OwnersCB.SelectedIndex==-1)
            {
                MessageBox.Show("Заполните поле!", "Внимание");
                return;
            }
            if (EditCB.CheckState == CheckState.Checked)
            {
                int id = CarsPassportsDGV.CurrentRow.Index;
                Table.CarPassportList[id].Car = Table.CarsTable.CarsList[CarsCB.SelectedIndex];
                Table.CarPassportList[id].Owner = Table.OwnerTable.PeoplesList[OwnersCB.SelectedIndex];
                Table.CarPassportList[id].Number = NumberTB.Text;

                var i = Table.DataTable.Rows[id].ItemArray[0];
                Table.DataTable.Rows[id].ItemArray = new object[] { i, Table.CarPassportList[id].Car.Id, Table.CarPassportList[id].Car.GetFullName(), Table.CarPassportList[id].Owner.Id, Table.CarPassportList[id].Owner.GetFullName(), Table.CarPassportList[id].Number };
            }
            else
            {
                Table.DataTable.Rows.Add(-1, Table.CarsTable.CarsList[CarsCB.SelectedIndex].Id, Table.CarsTable.CarsList[CarsCB.SelectedIndex].GetFullName(), Table.OwnerTable.PeoplesList[OwnersCB.SelectedIndex].Id, Table.OwnerTable.PeoplesList[OwnersCB.SelectedIndex].GetFullName(), NumberTB.Text);
                Table.CarPassportList.Add(new Entity.CarPassport(-1, Table.CarsTable.CarsList[CarsCB.SelectedIndex], Table.OwnerTable.PeoplesList[OwnersCB.SelectedIndex], NumberTB.Text));
                ExtraTools.HideRows(CarsPassportsDGV, hideIds);
            }
            ExtraTools.ClearTB(NumberTB);
            CarsCB.SelectedIndex = OwnersCB.SelectedIndex = -1;
            if (isSave)
                isSave = false;
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (CarsPassportsDGV.SelectedRows.Count < 1) return;
            var rows = CarsPassportsDGV.SelectedRows;
            CarsPassportsDGV.CurrentCell = null;
            foreach (DataGridViewRow item in rows)
            {
                item.Visible = false;
                hideIds.Add(item.Index);
                Table.CarPassportList[item.Index].IsDelete = true;
            }
            if (isSave)
                isSave = false;
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

        private void EditCB_CheckedChanged(object sender, EventArgs e)
        {
            if (EditCB.CheckState == CheckState.Checked)
            {
                AddBTN.Text = "Изменить";
                if (ExtraTools.LoadData(CarsPassportsDGV.CurrentRow, 5, NumberTB))
                {
                    CarsCB.SelectedItem = CarsPassportsDGV.CurrentRow.Cells[2].Value.ToString();
                    OwnersCB.SelectedItem = CarsPassportsDGV.CurrentRow.Cells[4].Value.ToString();
                }
            }
            else
            {
                AddBTN.Text = "Добавить";
                ExtraTools.ClearTB(NumberTB);
                CarsCB.SelectedIndex = OwnersCB.SelectedIndex = -1;
            }
        }

        private void CarPassportForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void CarsPassportsDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (EditCB.CheckState == CheckState.Unchecked) return;
            if (ExtraTools.LoadData(CarsPassportsDGV.CurrentRow, 5, NumberTB))
            {
                CarsCB.SelectedItem = CarsPassportsDGV.CurrentRow.Cells[2].Value.ToString();
                OwnersCB.SelectedItem = CarsPassportsDGV.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
}
