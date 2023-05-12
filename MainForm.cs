using CarDealershipApp.DataBaseApi;
using CarDealershipApp.Forms;

namespace CarDealershipApp
{
    public partial class MainForm : Form
    {
        Form curForm;

        void ActiveForm(Form form)
        {
            if (curForm != null)
            {
                curForm.Close();
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i] == curForm)
                        return;
                }
                MainPanel.Controls.Remove(curForm);
            }
            form.TopLevel = false;
            form.AutoScroll = true;
            MainPanel.Controls.Add(form);
            this.Width = form.Width + 20;
            this.Height = form.Height + menuStrip1.Height + 32;
            form.Show();
            this.CenterToScreen();
            curForm = form;
        }

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            IniFile iniFile = new IniFile("Settings.ini");
            DataBaseApi.DataBase.ConnectionString = iniFile.Read("ConnectionString","DataBase");
        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm(new CarForm());
        }

        private void людиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm(new PeopleForm());
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm(new EmployeeForm());
        }

        private void пТСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm(new CarPassportForm());
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm(new SaleForm());
        }

        private void фильтрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm(new FilterSaleForm());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.CloseConnection();
        }
    }
}
