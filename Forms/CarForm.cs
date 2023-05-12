using CarDealershipApp.DataBaseApi.Tables;

namespace CarDealershipApp.Forms
{
    public partial class CarForm : Form
    {
        CarsTable Table;
        List<int> hideIds;
        bool isSave=true;

        public CarForm()
        {
            InitializeComponent();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            Table = new CarsTable();
            if (Table.CarsList == null)
                return;
            hideIds = new List<int>();
            CarsDGV.DataSource = Table.DataTable;
            CarsDGV.Columns[0].Visible = false;
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            if (ExtraTools.IsTextBoxesEmpty(TradeMarkTB, ModelTB))
            {
                MessageBox.Show("Заполните поля!", "Внимание");
                return;
            }
            if (EditCB.CheckState == CheckState.Checked)
            {
                int id = CarsDGV.CurrentRow.Index;
                Table.CarsList[id].Trademark = TradeMarkTB.Text;
                Table.CarsList[id].Model = ModelTB.Text;
                Table.CarsList[id].Series = SeriesTB.Text;
                var i = Table.DataTable.Rows[id].ItemArray[0];
                Table.DataTable.Rows[id].ItemArray = new object[] { i, TradeMarkTB.Text, ModelTB.Text, SeriesTB.Text };
            }
            else
            {
                Table.DataTable.Rows.Add(-1, TradeMarkTB.Text, ModelTB.Text, SeriesTB.Text);
                Table.CarsList.Add(new Entity.Car(-1, TradeMarkTB.Text, ModelTB.Text, SeriesTB.Text));
                ExtraTools.HideRows(CarsDGV, hideIds);
            }
            ExtraTools.ClearTB(TradeMarkTB, ModelTB, SeriesTB);
            if (isSave)
                isSave = false;
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (CarsDGV.SelectedRows.Count < 1) return;
            var rows = CarsDGV.SelectedRows;
            CarsDGV.CurrentCell = null;
            foreach (DataGridViewRow item in rows)
            {
                item.Visible = false;
                hideIds.Add(item.Index);
                Table.CarsList[item.Index].IsDelete = true;
            }
            if (isSave)
                isSave = false;
        }

        private void EditCB_CheckedChanged(object sender, EventArgs e)
        {
            if (EditCB.CheckState == CheckState.Checked)
            {
                AddBTN.Text = "Изменить";
                ExtraTools.LoadData(CarsDGV.CurrentRow, 1,TradeMarkTB, ModelTB, SeriesTB);
            }
            else
            {
                AddBTN.Text = "Добавить";
                ExtraTools.ClearTB(TradeMarkTB, ModelTB, SeriesTB);
            }
        }

        private void CarsDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (EditCB.CheckState == CheckState.Unchecked) return;
            ExtraTools.LoadData(CarsDGV.CurrentRow, 1, TradeMarkTB, ModelTB, SeriesTB);
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

        private void CarForm_FormClosing(object sender, FormClosingEventArgs e)
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
