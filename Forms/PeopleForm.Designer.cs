namespace CarDealershipApp.Forms
{
    partial class PeopleForm
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
            PeoplesDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PeoplesDGV).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 383);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 40;
            label6.Text = "Дата рождения:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(610, 339);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 39;
            label5.Text = "Адрес:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 339);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 38;
            label4.Text = "Номер телефона:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 339);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 37;
            label3.Text = "Отчество:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 339);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 36;
            label2.Text = "Имя:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 339);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 35;
            label1.Text = "Фамилия:";
            // 
            // BirthDateDTP
            // 
            BirthDateDTP.Location = new Point(6, 403);
            BirthDateDTP.Name = "BirthDateDTP";
            BirthDateDTP.Size = new Size(143, 23);
            BirthDateDTP.TabIndex = 31;
            // 
            // AddressTB
            // 
            AddressTB.Location = new Point(610, 357);
            AddressTB.Name = "AddressTB";
            AddressTB.Size = new Size(292, 23);
            AddressTB.TabIndex = 30;
            // 
            // PhoneTB
            // 
            PhoneTB.Location = new Point(459, 357);
            PhoneTB.Name = "PhoneTB";
            PhoneTB.Size = new Size(145, 23);
            PhoneTB.TabIndex = 29;
            // 
            // EditCB
            // 
            EditCB.AutoSize = true;
            EditCB.Location = new Point(577, 408);
            EditCB.Name = "EditCB";
            EditCB.Size = new Size(115, 19);
            EditCB.TabIndex = 33;
            EditCB.Text = "Редактирование";
            EditCB.UseVisualStyleBackColor = true;
            EditCB.CheckedChanged += EditCB_CheckedChanged;
            // 
            // SaveBTN
            // 
            SaveBTN.Location = new Point(459, 403);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new Size(96, 26);
            SaveBTN.TabIndex = 32;
            SaveBTN.Text = "Сохранить";
            SaveBTN.UseVisualStyleBackColor = true;
            SaveBTN.Click += SaveBTN_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(704, 403);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(96, 26);
            DeleteBTN.TabIndex = 34;
            DeleteBTN.Text = "Удалить";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // PatronymicTB
            // 
            PatronymicTB.Location = new Point(308, 357);
            PatronymicTB.Name = "PatronymicTB";
            PatronymicTB.Size = new Size(145, 23);
            PatronymicTB.TabIndex = 28;
            // 
            // NameTB
            // 
            NameTB.Location = new Point(157, 357);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(145, 23);
            NameTB.TabIndex = 27;
            // 
            // SurnameTB
            // 
            SurnameTB.Location = new Point(6, 357);
            SurnameTB.Name = "SurnameTB";
            SurnameTB.Size = new Size(145, 23);
            SurnameTB.TabIndex = 26;
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(806, 403);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(96, 26);
            AddBTN.TabIndex = 35;
            AddBTN.Text = "Добавить";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // PeoplesDGV
            // 
            PeoplesDGV.AllowUserToAddRows = false;
            PeoplesDGV.AllowUserToDeleteRows = false;
            PeoplesDGV.AllowUserToResizeColumns = false;
            PeoplesDGV.AllowUserToResizeRows = false;
            PeoplesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PeoplesDGV.BackgroundColor = Color.White;
            PeoplesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PeoplesDGV.Location = new Point(6, 11);
            PeoplesDGV.Name = "PeoplesDGV";
            PeoplesDGV.ReadOnly = true;
            PeoplesDGV.RowHeadersVisible = false;
            PeoplesDGV.RowTemplate.Height = 25;
            PeoplesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PeoplesDGV.Size = new Size(896, 315);
            PeoplesDGV.TabIndex = 24;
            PeoplesDGV.CellMouseClick += PeoplesDGV_CellMouseClick;
            // 
            // PeopleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 441);
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
            Controls.Add(PeoplesDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PeopleForm";
            Text = "PeopleForm";
            FormClosing += PeopleForm_FormClosing;
            Load += PeopleForm_Load;
            ((System.ComponentModel.ISupportInitialize)PeoplesDGV).EndInit();
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
        private DataGridView PeoplesDGV;
    }
}