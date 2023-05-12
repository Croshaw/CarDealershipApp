namespace CarDealershipApp.Forms
{
    partial class SaleForm
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
            EditCB = new CheckBox();
            SaveBTN = new Button();
            DeleteBTN = new Button();
            AddBTN = new Button();
            label1 = new Label();
            label4 = new Label();
            CostTB = new TextBox();
            CarsCB = new ComboBox();
            DGV = new DataGridView();
            label3 = new Label();
            EmployeesCB = new ComboBox();
            label6 = new Label();
            TradeDateDTP = new DateTimePicker();
            BuyersCB = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // EditCB
            // 
            EditCB.AutoSize = true;
            EditCB.Location = new Point(689, 404);
            EditCB.Name = "EditCB";
            EditCB.Size = new Size(115, 19);
            EditCB.TabIndex = 77;
            EditCB.Text = "Редактирование";
            EditCB.UseVisualStyleBackColor = true;
            EditCB.CheckedChanged += EditCB_CheckedChanged;
            // 
            // SaveBTN
            // 
            SaveBTN.Location = new Point(560, 399);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new Size(96, 26);
            SaveBTN.TabIndex = 76;
            SaveBTN.Text = "Сохранить";
            SaveBTN.UseVisualStyleBackColor = true;
            SaveBTN.Click += SaveBTN_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(816, 399);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(96, 26);
            DeleteBTN.TabIndex = 78;
            DeleteBTN.Text = "Удалить";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(922, 399);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(96, 26);
            AddBTN.TabIndex = 79;
            AddBTN.Text = "Добавить";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 340);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 73;
            label1.Text = "Машина:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(699, 340);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 72;
            label4.Text = "Цена:";
            // 
            // CostTB
            // 
            CostTB.Location = new Point(699, 358);
            CostTB.Name = "CostTB";
            CostTB.Size = new Size(159, 23);
            CostTB.TabIndex = 71;
            // 
            // CarsCB
            // 
            CarsCB.FormattingEnabled = true;
            CarsCB.Location = new Point(12, 358);
            CarsCB.Name = "CarsCB";
            CarsCB.Size = new Size(207, 23);
            CarsCB.TabIndex = 70;
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AllowUserToResizeColumns = false;
            DGV.AllowUserToResizeRows = false;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.BackgroundColor = Color.White;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(12, 12);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowHeadersVisible = false;
            DGV.RowTemplate.Height = 25;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new Size(1006, 315);
            DGV.TabIndex = 69;
            DGV.CellMouseClick += DGV_CellMouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 340);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 81;
            label3.Text = "Продавец:";
            // 
            // EmployeesCB
            // 
            EmployeesCB.FormattingEnabled = true;
            EmployeesCB.Location = new Point(232, 358);
            EmployeesCB.Name = "EmployeesCB";
            EmployeesCB.Size = new Size(216, 23);
            EmployeesCB.TabIndex = 80;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(875, 340);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 83;
            label6.Text = "Дата сделки:";
            // 
            // TradeDateDTP
            // 
            TradeDateDTP.Location = new Point(875, 358);
            TradeDateDTP.Name = "TradeDateDTP";
            TradeDateDTP.Size = new Size(143, 23);
            TradeDateDTP.TabIndex = 82;
            // 
            // BuyersCB
            // 
            BuyersCB.FormattingEnabled = true;
            BuyersCB.Location = new Point(471, 358);
            BuyersCB.Name = "BuyersCB";
            BuyersCB.Size = new Size(207, 23);
            BuyersCB.TabIndex = 84;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 340);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 85;
            label2.Text = "Покупатель:";
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 436);
            Controls.Add(label2);
            Controls.Add(BuyersCB);
            Controls.Add(label6);
            Controls.Add(TradeDateDTP);
            Controls.Add(label3);
            Controls.Add(EmployeesCB);
            Controls.Add(EditCB);
            Controls.Add(SaveBTN);
            Controls.Add(DeleteBTN);
            Controls.Add(AddBTN);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(CostTB);
            Controls.Add(CarsCB);
            Controls.Add(DGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SaleForm";
            Text = "SaleForm";
            FormClosing += SaleForm_FormClosing;
            Load += SaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox EditCB;
        private Button SaveBTN;
        private Button DeleteBTN;
        private Button AddBTN;
        private Label label1;
        private Label label4;
        private TextBox CostTB;
        private ComboBox CarsCB;
        private DataGridView DGV;
        private Label label3;
        private ComboBox EmployeesCB;
        private Label label6;
        private DateTimePicker TradeDateDTP;
        private ComboBox BuyersCB;
        private Label label2;
    }
}