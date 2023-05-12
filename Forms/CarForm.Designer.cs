namespace CarDealershipApp.Forms
{
    partial class CarForm
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
            CarsDGV = new DataGridView();
            AddBTN = new Button();
            TradeMarkTB = new TextBox();
            ModelTB = new TextBox();
            SeriesTB = new TextBox();
            DeleteBTN = new Button();
            SaveBTN = new Button();
            EditCB = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)CarsDGV).BeginInit();
            SuspendLayout();
            // 
            // CarsDGV
            // 
            CarsDGV.AllowUserToAddRows = false;
            CarsDGV.AllowUserToDeleteRows = false;
            CarsDGV.AllowUserToResizeColumns = false;
            CarsDGV.AllowUserToResizeRows = false;
            CarsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CarsDGV.BackgroundColor = Color.White;
            CarsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarsDGV.Location = new Point(22, 21);
            CarsDGV.Name = "CarsDGV";
            CarsDGV.ReadOnly = true;
            CarsDGV.RowHeadersVisible = false;
            CarsDGV.RowTemplate.Height = 25;
            CarsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarsDGV.Size = new Size(447, 315);
            CarsDGV.TabIndex = 0;
            CarsDGV.CellMouseClick += CarsDGV_CellMouseClick;
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(373, 403);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(96, 26);
            AddBTN.TabIndex = 1;
            AddBTN.Text = "Добавить";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // TradeMarkTB
            // 
            TradeMarkTB.Location = new Point(22, 363);
            TradeMarkTB.Name = "TradeMarkTB";
            TradeMarkTB.Size = new Size(145, 23);
            TradeMarkTB.TabIndex = 2;
            // 
            // ModelTB
            // 
            ModelTB.Location = new Point(173, 363);
            ModelTB.Name = "ModelTB";
            ModelTB.Size = new Size(145, 23);
            ModelTB.TabIndex = 3;
            // 
            // SeriesTB
            // 
            SeriesTB.Location = new Point(324, 363);
            SeriesTB.Name = "SeriesTB";
            SeriesTB.Size = new Size(145, 23);
            SeriesTB.TabIndex = 4;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(271, 403);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(96, 26);
            DeleteBTN.TabIndex = 5;
            DeleteBTN.Text = "Удалить";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // SaveBTN
            // 
            SaveBTN.Location = new Point(22, 403);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new Size(96, 26);
            SaveBTN.TabIndex = 6;
            SaveBTN.Text = "Сохранить";
            SaveBTN.UseVisualStyleBackColor = true;
            SaveBTN.Click += SaveBTN_Click;
            // 
            // EditCB
            // 
            EditCB.AutoSize = true;
            EditCB.Location = new Point(140, 408);
            EditCB.Name = "EditCB";
            EditCB.Size = new Size(115, 19);
            EditCB.TabIndex = 7;
            EditCB.Text = "Редактирование";
            EditCB.UseVisualStyleBackColor = true;
            EditCB.CheckedChanged += EditCB_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 345);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 8;
            label1.Text = "Марка машины:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 345);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 9;
            label2.Text = "Модель машины:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 345);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "Серия:";
            // 
            // CarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(493, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EditCB);
            Controls.Add(SaveBTN);
            Controls.Add(DeleteBTN);
            Controls.Add(SeriesTB);
            Controls.Add(ModelTB);
            Controls.Add(TradeMarkTB);
            Controls.Add(AddBTN);
            Controls.Add(CarsDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarForm";
            Text = "CarForm";
            FormClosing += CarForm_FormClosing;
            Load += CarForm_Load;
            ((System.ComponentModel.ISupportInitialize)CarsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CarsDGV;
        private Button AddBTN;
        private TextBox TradeMarkTB;
        private TextBox ModelTB;
        private TextBox SeriesTB;
        private Button DeleteBTN;
        private Button SaveBTN;
        private CheckBox EditCB;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}