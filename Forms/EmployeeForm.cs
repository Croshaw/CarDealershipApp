using CarDealershipApp.DataBaseApi.Tables;

namespace CarDealershipApp.Forms
{
    public partial class EmployeeForm : Form
    {
        EmployeesTable Table;
        List<int> hideIds;
        bool isSave = true;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            Table = new EmployeesTable();
            if (Table.EmployeesList == null)
                return;
            hideIds = new List<int>();
            EmployeesDGV.DataSource = Table.DataTable;
            EmployeesDGV.Columns[0].Visible = false;
            PositionsCB.DataSource = Table.PositionsList.Select(x => x.Name).ToList();
            foreach (DataGridViewColumn column in EmployeesDGV.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeesDGV.Columns[EmployeesDGV.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            isSave = true;
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            if (ExtraTools.IsTextBoxesEmpty(SurnameTB, NameTB, PatronymicTB, AddressTB, PhoneTB))
            {
                MessageBox.Show("Заполните поля!", "Внимание");
                return;
            }
            if (EditCB.CheckState == CheckState.Checked)
            {
                int id = EmployeesDGV.CurrentRow.Index;
                Table.EmployeesList[id].Surname = SurnameTB.Text;
                Table.EmployeesList[id].Name = NameTB.Text;
                Table.EmployeesList[id].Patronymic = PatronymicTB.Text;
                Table.EmployeesList[id].Phone = PhoneTB.Text;
                Table.EmployeesList[id].BirthDate = BirthDateDTP.Value;
                Table.EmployeesList[id].Address = AddressTB.Text;
                Table.EmployeesList[id].Position = Table.PositionsList.FirstOrDefault(x => x.Name.Equals(PositionsCB.SelectedItem.ToString()));
                var i = Table.DataTable.Rows[id].ItemArray[0];
                Table.DataTable.Rows[id].ItemArray = new object[] { i, SurnameTB.Text, NameTB.Text, PatronymicTB.Text, PhoneTB.Text, BirthDateDTP.Value.ToShortDateString(), Table.EmployeesList[id].Position.Name, AddressTB.Text };
            }
            else
            {
                Table.DataTable.Rows.Add(-1, SurnameTB.Text, NameTB.Text, PatronymicTB.Text, PhoneTB.Text, BirthDateDTP.Value.ToShortDateString(), AddressTB.Text);
                Table.EmployeesList.Add(new Entity.Employee(-1, SurnameTB.Text, NameTB.Text, PatronymicTB.Text, PhoneTB.Text, BirthDateDTP.Value, Table.PositionsList.FirstOrDefault(x => x.Name.Equals(PositionsCB.SelectedItem.ToString())), AddressTB.Text));
                ExtraTools.HideRows(EmployeesDGV, hideIds);
            }
            ExtraTools.ClearTB(SurnameTB, NameTB, PatronymicTB, AddressTB, PhoneTB);
            PositionsCB.SelectedIndex = -1;
            if (isSave)
                isSave = false;
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (EmployeesDGV.SelectedRows.Count < 1) return;
            var rows = EmployeesDGV.SelectedRows;
            EmployeesDGV.CurrentCell = null;
            foreach (DataGridViewRow item in rows)
            {
                item.Visible = false;
                hideIds.Add(item.Index);
                Table.EmployeesList[item.Index].IsDelete = true;
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
                if (ExtraTools.LoadData(EmployeesDGV.CurrentRow, 1, SurnameTB, NameTB, PatronymicTB, PhoneTB, BirthDateDTP, PositionsCB, AddressTB))
                {
                    BirthDateDTP.Value = Convert.ToDateTime(EmployeesDGV.Rows[EmployeesDGV.CurrentRow.Index].Cells[5].Value);
                    PositionsCB.SelectedItem = Table.PositionsList.FirstOrDefault(x => x.Name.Equals(EmployeesDGV.Rows[EmployeesDGV.CurrentRow.Index].Cells[6].Value.ToString())).Name;
                }
            }
            else
            {
                AddBTN.Text = "Добавить";
                ExtraTools.ClearTB(SurnameTB, NameTB, PatronymicTB, AddressTB, PhoneTB);
                PositionsCB.SelectedIndex = -1;
            }
        }

        private void PeoplesDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (EditCB.CheckState == CheckState.Unchecked) return;
            if (ExtraTools.LoadData(EmployeesDGV.CurrentRow, 1, SurnameTB, NameTB, PatronymicTB, PhoneTB, BirthDateDTP, PositionsCB, AddressTB))
            {
                BirthDateDTP.Value = Convert.ToDateTime(EmployeesDGV.Rows[EmployeesDGV.CurrentRow.Index].Cells[5].Value);
                PositionsCB.SelectedItem = Table.PositionsList.FirstOrDefault(x => x.Name.Equals(EmployeesDGV.Rows[EmployeesDGV.CurrentRow.Index].Cells[6].Value.ToString())).Name;
            }
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
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
