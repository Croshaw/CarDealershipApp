namespace CarDealershipApp.Forms
{
    partial class FilterSaleForm
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
            ApplyBTN = new Button();
            label1 = new Label();
            label4 = new Label();
            SurnameOwnerTB = new TextBox();
            StatusCB = new ComboBox();
            DGV = new DataGridView();
            label2 = new Label();
            NumberCarTB = new TextBox();
            label3 = new Label();
            TrademarkCarTB = new TextBox();
            groupBox1 = new GroupBox();
            SecCostTB = new TextBox();
            FirstCostTB = new TextBox();
            isCost = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            isDates = new CheckBox();
            SecDTP = new DateTimePicker();
            FirstDTP = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            SoloDTP = new DateTimePicker();
            label9 = new Label();
            isSurname = new CheckBox();
            isTrademarkCar = new CheckBox();
            isNumberCar = new CheckBox();
            isStatus = new CheckBox();
            isSoloDate = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ApplyBTN
            // 
            ApplyBTN.Location = new Point(831, 490);
            ApplyBTN.Name = "ApplyBTN";
            ApplyBTN.Size = new Size(187, 26);
            ApplyBTN.TabIndex = 94;
            ApplyBTN.Text = "Применить";
            ApplyBTN.UseVisualStyleBackColor = true;
            ApplyBTN.Click += ApplyBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 398);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 90;
            label1.Text = "Статус:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 343);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 89;
            label4.Text = "Фамилия владельца:";
            // 
            // SurnameOwnerTB
            // 
            SurnameOwnerTB.Location = new Point(12, 361);
            SurnameOwnerTB.Name = "SurnameOwnerTB";
            SurnameOwnerTB.Size = new Size(159, 23);
            SurnameOwnerTB.TabIndex = 88;
            // 
            // StatusCB
            // 
            StatusCB.FormattingEnabled = true;
            StatusCB.Items.AddRange(new object[] { "Продано", "Продаётся" });
            StatusCB.Location = new Point(12, 415);
            StatusCB.Name = "StatusCB";
            StatusCB.Size = new Size(121, 23);
            StatusCB.TabIndex = 87;
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
            DGV.TabIndex = 86;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 343);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 96;
            label2.Text = "Номер автомобиля:";
            // 
            // NumberCarTB
            // 
            NumberCarTB.Location = new Point(191, 361);
            NumberCarTB.Name = "NumberCarTB";
            NumberCarTB.Size = new Size(159, 23);
            NumberCarTB.TabIndex = 95;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 343);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 98;
            label3.Text = "Марка машины:";
            // 
            // TrademarkCarTB
            // 
            TrademarkCarTB.Location = new Point(365, 361);
            TrademarkCarTB.Name = "TrademarkCarTB";
            TrademarkCarTB.Size = new Size(159, 23);
            TrademarkCarTB.TabIndex = 97;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SecCostTB);
            groupBox1.Controls.Add(FirstCostTB);
            groupBox1.Controls.Add(isCost);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(590, 343);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 132);
            groupBox1.TabIndex = 99;
            groupBox1.TabStop = false;
            groupBox1.Text = "Цена";
            // 
            // SecCostTB
            // 
            SecCostTB.Location = new Point(20, 97);
            SecCostTB.Name = "SecCostTB";
            SecCostTB.Size = new Size(159, 23);
            SecCostTB.TabIndex = 112;
            SecCostTB.KeyPress += SecCostTB_KeyPress;
            // 
            // FirstCostTB
            // 
            FirstCostTB.Location = new Point(20, 46);
            FirstCostTB.Name = "FirstCostTB";
            FirstCostTB.Size = new Size(159, 23);
            FirstCostTB.TabIndex = 111;
            FirstCostTB.KeyPress += FirstCostTB_KeyPress;
            // 
            // isCost
            // 
            isCost.AutoSize = true;
            isCost.Location = new Point(41, 1);
            isCost.Name = "isCost";
            isCost.Size = new Size(15, 14);
            isCost.TabIndex = 111;
            isCost.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 76);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 102;
            label6.Text = "До:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 28);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 100;
            label5.Text = "От:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(isDates);
            groupBox2.Controls.Add(SecDTP);
            groupBox2.Controls.Add(FirstDTP);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(818, 343);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 132);
            groupBox2.TabIndex = 100;
            groupBox2.TabStop = false;
            groupBox2.Text = "Диапазон дат";
            // 
            // isDates
            // 
            isDates.AutoSize = true;
            isDates.Location = new Point(86, 1);
            isDates.Name = "isDates";
            isDates.Size = new Size(15, 14);
            isDates.TabIndex = 111;
            isDates.UseVisualStyleBackColor = true;
            isDates.CheckedChanged += isDates_CheckedChanged;
            // 
            // SecDTP
            // 
            SecDTP.Location = new Point(20, 94);
            SecDTP.Name = "SecDTP";
            SecDTP.Size = new Size(151, 23);
            SecDTP.TabIndex = 104;
            // 
            // FirstDTP
            // 
            FirstDTP.Location = new Point(20, 46);
            FirstDTP.Name = "FirstDTP";
            FirstDTP.Size = new Size(151, 23);
            FirstDTP.TabIndex = 103;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 76);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 102;
            label7.Text = "До:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 28);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 100;
            label8.Text = "От:";
            // 
            // SoloDTP
            // 
            SoloDTP.Location = new Point(158, 415);
            SoloDTP.Name = "SoloDTP";
            SoloDTP.Size = new Size(151, 23);
            SoloDTP.TabIndex = 105;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(179, 397);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 104;
            label9.Text = "Дата:";
            // 
            // isSurname
            // 
            isSurname.AutoSize = true;
            isSurname.Location = new Point(12, 344);
            isSurname.Name = "isSurname";
            isSurname.Size = new Size(15, 14);
            isSurname.TabIndex = 106;
            isSurname.UseVisualStyleBackColor = true;
            // 
            // isTrademarkCar
            // 
            isTrademarkCar.AutoSize = true;
            isTrademarkCar.Location = new Point(365, 344);
            isTrademarkCar.Name = "isTrademarkCar";
            isTrademarkCar.Size = new Size(15, 14);
            isTrademarkCar.TabIndex = 107;
            isTrademarkCar.UseVisualStyleBackColor = true;
            // 
            // isNumberCar
            // 
            isNumberCar.AutoSize = true;
            isNumberCar.Location = new Point(191, 344);
            isNumberCar.Name = "isNumberCar";
            isNumberCar.Size = new Size(15, 14);
            isNumberCar.TabIndex = 108;
            isNumberCar.UseVisualStyleBackColor = true;
            // 
            // isStatus
            // 
            isStatus.AutoSize = true;
            isStatus.Location = new Point(12, 399);
            isStatus.Name = "isStatus";
            isStatus.Size = new Size(15, 14);
            isStatus.TabIndex = 109;
            isStatus.UseVisualStyleBackColor = true;
            // 
            // isSoloDate
            // 
            isSoloDate.AutoSize = true;
            isSoloDate.Location = new Point(158, 399);
            isSoloDate.Name = "isSoloDate";
            isSoloDate.Size = new Size(15, 14);
            isSoloDate.TabIndex = 110;
            isSoloDate.UseVisualStyleBackColor = true;
            isSoloDate.CheckedChanged += isSoloDate_CheckedChanged;
            // 
            // FilterSaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 551);
            Controls.Add(isSoloDate);
            Controls.Add(isStatus);
            Controls.Add(isNumberCar);
            Controls.Add(isTrademarkCar);
            Controls.Add(isSurname);
            Controls.Add(SoloDTP);
            Controls.Add(label9);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(TrademarkCarTB);
            Controls.Add(label2);
            Controls.Add(NumberCarTB);
            Controls.Add(ApplyBTN);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(SurnameOwnerTB);
            Controls.Add(StatusCB);
            Controls.Add(DGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FilterSaleForm";
            Text = "FilterSaleForm";
            Load += FilterSaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ApplyBTN;
        private Label label1;
        private Label label4;
        private TextBox SurnameOwnerTB;
        private ComboBox StatusCB;
        private DataGridView DGV;
        private Label label2;
        private TextBox NumberCarTB;
        private Label label3;
        private TextBox TrademarkCarTB;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private DateTimePicker SecDTP;
        private DateTimePicker FirstDTP;
        private Label label7;
        private Label label8;
        private DateTimePicker SoloDTP;
        private Label label9;
        private CheckBox isCost;
        private CheckBox isDates;
        private CheckBox isSurname;
        private CheckBox isTrademarkCar;
        private CheckBox isNumberCar;
        private CheckBox isStatus;
        private CheckBox isSoloDate;
        private TextBox SecCostTB;
        private TextBox FirstCostTB;
    }
}