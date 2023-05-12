using CarDealershipApp.DataBaseApi.Tables;

namespace CarDealershipApp.Forms
{
    public partial class PeopleForm : Form
    {
        PeoplesTable Table;
        List<int> hideIds;
        bool isSave=true;

        public PeopleForm()
        {
            InitializeComponent();
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            Table = new PeoplesTable();
            if (Table.PeoplesList == null)
                return;
            hideIds = new List<int>();
            PeoplesDGV.DataSource = Table.DataTable;
            PeoplesDGV.Columns[0].Visible = false;
            foreach (DataGridViewColumn column in PeoplesDGV.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PeoplesDGV.Columns[PeoplesDGV.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                int id = PeoplesDGV.CurrentRow.Index;
                Table.PeoplesList[id].Surname = SurnameTB.Text;
                Table.PeoplesList[id].Name = NameTB.Text;
                Table.PeoplesList[id].Patronymic = PatronymicTB.Text;
                Table.PeoplesList[id].Phone = PhoneTB.Text;
                Table.PeoplesList[id].BirthDate = BirthDateDTP.Value;
                Table.PeoplesList[id].Address = AddressTB.Text;
                var i = Table.DataTable.Rows[id].ItemArray[0];
                Table.DataTable.Rows[id].ItemArray = new object[] { i, SurnameTB.Text, NameTB.Text, PatronymicTB.Text, PhoneTB.Text, BirthDateDTP.Value.ToShortDateString(), AddressTB.Text };
            }
            else
            {
                Table.DataTable.Rows.Add(-1, SurnameTB.Text, NameTB.Text, PatronymicTB.Text, PhoneTB.Text, BirthDateDTP.Value.ToShortDateString(), AddressTB.Text);
                Table.PeoplesList.Add(new Entity.People(-1, SurnameTB.Text, NameTB.Text, PatronymicTB.Text, PhoneTB.Text, BirthDateDTP.Value, AddressTB.Text));
                ExtraTools.HideRows(PeoplesDGV, hideIds);
            }
            ExtraTools.ClearTB(SurnameTB, NameTB, PatronymicTB, AddressTB, PhoneTB);
            if (isSave)
                isSave = false;
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (PeoplesDGV.SelectedRows.Count < 1) return;
            var rows = PeoplesDGV.SelectedRows;
            PeoplesDGV.CurrentCell = null;
            foreach (DataGridViewRow item in rows)
            {
                item.Visible = false;
                hideIds.Add(item.Index);
                Table.PeoplesList[item.Index].IsDelete = true;
            }
            if (isSave)
                isSave = false;
        }

        private void EditCB_CheckedChanged(object sender, EventArgs e)
        {
            if (EditCB.CheckState == CheckState.Checked)
            {
                AddBTN.Text = "Изменить";
                if (ExtraTools.LoadData(PeoplesDGV.CurrentRow, 1, SurnameTB, NameTB, PatronymicTB, PhoneTB, BirthDateDTP, AddressTB))
                    BirthDateDTP.Value = Convert.ToDateTime(PeoplesDGV.Rows[PeoplesDGV.CurrentRow.Index].Cells[5].Value);
            }
            else
            {
                AddBTN.Text = "Добавить";
                ExtraTools.ClearTB(SurnameTB, NameTB, PatronymicTB, AddressTB, PhoneTB);
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

        private void PeoplesDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (EditCB.CheckState == CheckState.Unchecked) return;
            if (ExtraTools.LoadData(PeoplesDGV.CurrentRow, 1, SurnameTB, NameTB, PatronymicTB, PhoneTB, BirthDateDTP, AddressTB))
                BirthDateDTP.Value = Convert.ToDateTime(PeoplesDGV.Rows[PeoplesDGV.CurrentRow.Index].Cells[5].Value);
        }

        private void PeopleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!isSave)
            {
                switch(MessageBox.Show("Вы не сохранили данные, сохранить?", "Внимание", MessageBoxButtons.YesNoCancel))
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
