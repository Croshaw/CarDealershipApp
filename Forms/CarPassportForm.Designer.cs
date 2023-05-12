namespace CarDealershipApp.Forms
{
    partial class CarPassportForm
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
            CarsPassportsDGV = new DataGridView();
            CarsCB = new ComboBox();
            label4 = new Label();
            NumberTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            OwnersCB = new ComboBox();
            EditCB = new CheckBox();
            SaveBTN = new Button();
            DeleteBTN = new Button();
            AddBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)CarsPassportsDGV).BeginInit();
            SuspendLayout();
            // 
            // CarsPassportsDGV
            // 
            CarsPassportsDGV.AllowUserToAddRows = false;
            CarsPassportsDGV.AllowUserToDeleteRows = false;
            CarsPassportsDGV.AllowUserToResizeColumns = false;
            CarsPassportsDGV.AllowUserToResizeRows = false;
            CarsPassportsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CarsPassportsDGV.BackgroundColor = Color.White;
            CarsPassportsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarsPassportsDGV.Location = new Point(14, 12);
            CarsPassportsDGV.Name = "CarsPassportsDGV";
            CarsPassportsDGV.ReadOnly = true;
            CarsPassportsDGV.RowHeadersVisible = false;
            CarsPassportsDGV.RowTemplate.Height = 25;
            CarsPassportsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarsPassportsDGV.Size = new Size(610, 315);
            CarsPassportsDGV.TabIndex = 42;
            CarsPassportsDGV.CellMouseClick += CarsPassportsDGV_CellMouseClick;
            // 
            // CarsCB
            // 
            CarsCB.FormattingEnabled = true;
            CarsCB.Location = new Point(12, 358);
            CarsCB.Name = "CarsCB";
            CarsCB.Size = new Size(207, 23);
            CarsCB.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(465, 340);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 61;
            label4.Text = "Номер машины:";
            // 
            // NumberTB
            // 
            NumberTB.Location = new Point(465, 358);
            NumberTB.Name = "NumberTB";
            NumberTB.Size = new Size(159, 23);
            NumberTB.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 340);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 62;
            label1.Text = "Машина:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 340);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 64;
            label2.Text = "Владелец:";
            // 
            // OwnersCB
            // 
            OwnersCB.FormattingEnabled = true;
            OwnersCB.Location = new Point(238, 358);
            OwnersCB.Name = "OwnersCB";
            OwnersCB.Size = new Size(207, 23);
            OwnersCB.TabIndex = 63;
            // 
            // EditCB
            // 
            EditCB.AutoSize = true;
            EditCB.Location = new Point(297, 405);
            EditCB.Name = "EditCB";
            EditCB.Size = new Size(115, 19);
            EditCB.TabIndex = 66;
            EditCB.Text = "Редактирование";
            EditCB.UseVisualStyleBackColor = true;
            EditCB.CheckedChanged += EditCB_CheckedChanged;
            // 
            // SaveBTN
            // 
            SaveBTN.Location = new Point(179, 400);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new Size(96, 26);
            SaveBTN.TabIndex = 65;
            SaveBTN.Text = "Сохранить";
            SaveBTN.UseVisualStyleBackColor = true;
            SaveBTN.Click += SaveBTN_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(424, 400);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(96, 26);
            DeleteBTN.TabIndex = 67;
            DeleteBTN.Text = "Удалить";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(528, 400);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(96, 26);
            AddBTN.TabIndex = 68;
            AddBTN.Text = "Добавить";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // CarPassportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 444);
            Controls.Add(EditCB);
            Controls.Add(SaveBTN);
            Controls.Add(DeleteBTN);
            Controls.Add(AddBTN);
            Controls.Add(label2);
            Controls.Add(OwnersCB);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(NumberTB);
            Controls.Add(CarsCB);
            Controls.Add(CarsPassportsDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarPassportForm";
            Text = "CarPassportForm";
            FormClosing += CarPassportForm_FormClosing;
            Load += CarPassportForm_Load;
            ((System.ComponentModel.ISupportInitialize)CarsPassportsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CarsPassportsDGV;
        private ComboBox CarsCB;
        private Label label4;
        private TextBox NumberTB;
        private Label label1;
        private Label label2;
        private ComboBox OwnersCB;
        private CheckBox EditCB;
        private Button SaveBTN;
        private Button DeleteBTN;
        private Button AddBTN;
    }
}