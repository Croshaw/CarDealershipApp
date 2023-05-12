namespace CarDealershipApp
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            таблицыToolStripMenuItem = new ToolStripMenuItem();
            автомобилиToolStripMenuItem = new ToolStripMenuItem();
            людиToolStripMenuItem = new ToolStripMenuItem();
            сотрудникиToolStripMenuItem = new ToolStripMenuItem();
            пТСToolStripMenuItem = new ToolStripMenuItem();
            продажиToolStripMenuItem = new ToolStripMenuItem();
            фильтрацияToolStripMenuItem = new ToolStripMenuItem();
            MainPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { таблицыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            таблицыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { автомобилиToolStripMenuItem, людиToolStripMenuItem, сотрудникиToolStripMenuItem, пТСToolStripMenuItem, продажиToolStripMenuItem, фильтрацияToolStripMenuItem });
            таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            таблицыToolStripMenuItem.Size = new Size(68, 20);
            таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // автомобилиToolStripMenuItem
            // 
            автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            автомобилиToolStripMenuItem.Size = new Size(144, 22);
            автомобилиToolStripMenuItem.Text = "Автомобили";
            автомобилиToolStripMenuItem.Click += автомобилиToolStripMenuItem_Click;
            // 
            // людиToolStripMenuItem
            // 
            людиToolStripMenuItem.Name = "людиToolStripMenuItem";
            людиToolStripMenuItem.Size = new Size(144, 22);
            людиToolStripMenuItem.Text = "Люди";
            людиToolStripMenuItem.Click += людиToolStripMenuItem_Click;
            // 
            // сотрудникиToolStripMenuItem
            // 
            сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            сотрудникиToolStripMenuItem.Size = new Size(144, 22);
            сотрудникиToolStripMenuItem.Text = "Сотрудники";
            сотрудникиToolStripMenuItem.Click += сотрудникиToolStripMenuItem_Click;
            // 
            // пТСToolStripMenuItem
            // 
            пТСToolStripMenuItem.Name = "пТСToolStripMenuItem";
            пТСToolStripMenuItem.Size = new Size(144, 22);
            пТСToolStripMenuItem.Text = "ПТС";
            пТСToolStripMenuItem.Click += пТСToolStripMenuItem_Click;
            // 
            // продажиToolStripMenuItem
            // 
            продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            продажиToolStripMenuItem.Size = new Size(144, 22);
            продажиToolStripMenuItem.Text = "Продажи";
            продажиToolStripMenuItem.Click += продажиToolStripMenuItem_Click;
            // 
            // фильтрацияToolStripMenuItem
            // 
            фильтрацияToolStripMenuItem.Name = "фильтрацияToolStripMenuItem";
            фильтрацияToolStripMenuItem.Size = new Size(144, 22);
            фильтрацияToolStripMenuItem.Text = "Фильтрация";
            фильтрацияToolStripMenuItem.Click += фильтрацияToolStripMenuItem_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 24);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(800, 2);
            MainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 26);
            Controls.Add(MainPanel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Автосалон";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem таблицыToolStripMenuItem;
        private ToolStripMenuItem автомобилиToolStripMenuItem;
        private Panel MainPanel;
        private ToolStripMenuItem людиToolStripMenuItem;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem пТСToolStripMenuItem;
        private ToolStripMenuItem продажиToolStripMenuItem;
        private ToolStripMenuItem фильтрацияToolStripMenuItem;
    }
}