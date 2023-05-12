namespace CarDealershipApp.Forms
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BirthDateDTP = new DateTimePicker();
            AddressTB = new TextBox();
            PhoneTB = new TextBox();
            EditCB = new CheckBox();
            SaveBTN = new Button();
            DeleteBTN = new Button();
            PatronymicTB = new TextBox();
            NameTB = new TextBox();
            SurnameTB = new TextBox();
            AddBTN = new Button();
            EmployeesDGV = new DataGridView();
            PositionsCB = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)EmployeesDGV).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 384);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 57;
            label6.Text = "Дата рождения:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(616, 340);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 56;
            label5.Text = "Адрес:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(465, 340);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 55;
            label4.Text = "Номер телефона:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 340);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 54;
            label3.Text = "Отчество:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 340);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 53;
            label2.Text = "Имя:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 340);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 51;
            label1.Text = "Фамилия:";
            // 
            // BirthDateDTP
            // 
            BirthDateDTP.Location = new Point(12, 404);
            BirthDateDTP.Name = "BirthDateDTP";
            BirthDateDTP.Size = new Size(143, 23);
            BirthDateDTP.TabIndex = 47;
            // 
            // AddressTB
            // 
            AddressTB.Location = new Point(616, 358);
            AddressTB.Name = "AddressTB";
            AddressTB.Size = new Size(292, 23);
            AddressTB.TabIndex = 46;
            // 
            // PhoneTB
            // 
            PhoneTB.Location = new Point(465, 358);
            PhoneTB.Name = "PhoneTB";
            PhoneTB.Size = new Size(145, 23);
            PhoneTB.TabIndex = 45;
            // 
            // EditCB
            // 
            EditCB.AutoSize = true;
            EditCB.Location = new Point(583, 409);
            EditCB.Name = "EditCB";
            EditCB.Size = new Size(115, 19);
            EditCB.TabIndex = 49;
            EditCB.Text = "Редактирование";
            EditCB.UseVisualStyleBackColor = true;
            EditCB.CheckedChanged += EditCB_CheckedChanged;
            // 
            // SaveBTN
            // 
            SaveBTN.Location = new Point(465, 404);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new Size(96, 26);
            SaveBTN.TabIndex = 48;
            SaveBTN.Text = "Сохранить";
            SaveBTN.UseVisualStyleBackColor = true;
            SaveBTN.Click += SaveBTN_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(710, 404);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(96, 26);
            DeleteBTN.TabIndex = 50;
            DeleteBTN.Text = "Удалить";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // PatronymicTB
            // 
            PatronymicTB.Location = new Point(314, 358);
            PatronymicTB.Name = "PatronymicTB";
            PatronymicTB.Size = new Size(145, 23);
            PatronymicTB.TabIndex = 44;
            // 
            // NameTB
            // 
            NameTB.Location = new Point(163, 358);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(145, 23);
            NameTB.TabIndex = 43;
            // 
            // SurnameTB
            // 
            SurnameTB.Location = new Point(12, 358);
            SurnameTB.Name = "SurnameTB";
            SurnameTB.Size = new Size(145, 23);
            SurnameTB.TabIndex = 42;
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(812, 404);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(96, 26);
            AddBTN.TabIndex = 52;
            AddBTN.Text = "Добавить";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // EmployeesDGV
            // 
            EmployeesDGV.AllowUserToAddRows = false;
            EmployeesDGV.AllowUserToDeleteRows = false;
            EmployeesDGV.AllowUserToResizeColumns = false;
            EmployeesDGV.AllowUserToResizeRows = false;
            EmployeesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeesDGV.BackgroundColor = Color.White;
            EmployeesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeesDGV.Location = new Point(12, 12);
            EmployeesDGV.Name = "EmployeesDGV";
            EmployeesDGV.ReadOnly = true;
            EmployeesDGV.RowHeadersVisible = false;
            EmployeesDGV.RowTemplate.Height = 25;
            EmployeesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeesDGV.Size = new Size(896, 315);
            EmployeesDGV.TabIndex = 41;
            EmployeesDGV.CellMouseClick += PeoplesDGV_CellMouseClick;
            // 
            // PositionsCB
            // 
            PositionsCB.FormattingEnabled = true;
            PositionsCB.Location = new Point(163, 404);
            PositionsCB.Name = "PositionsCB";
            PositionsCB.Size = new Size(136, 23);
            PositionsCB.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 386);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 59;
            label7.Text = "Должность:";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 445);
            Controls.Add(label7);
            Controls.Add(PositionsCB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BirthDateDTP);
            Controls.Add(AddressTB);
            Controls.Add(PhoneTB);
            Controls.Add(EditCB);
            Controls.Add(SaveBTN);
            Controls.Add(DeleteBTN);
            Controls.Add(PatronymicTB);
            Controls.Add(NameTB);
            Controls.Add(SurnameTB);
            Controls.Add(AddBTN);
            Controls.Add(EmployeesDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            FormClosing += EmployeeForm_FormClosing;
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker BirthDateDTP;
        private TextBox AddressTB;
        private TextBox PhoneTB;
        private CheckBox EditCB;
        private Button SaveBTN;
        private Button DeleteBTN;
        private TextBox PatronymicTB;
        private TextBox NameTB;
        private TextBox SurnameTB;
        private Button AddBTN;
        private DataGridView EmployeesDGV;
        private ComboBox PositionsCB;
        private Label label7;
    }
}