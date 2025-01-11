namespace DomowyBudzet1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel2 = new Panel();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            panel1 = new Panel();
            ExpenseBtn = new PictureBox();
            DashboardBtn = new PictureBox();
            LogoutBtn = new PictureBox();
            IncomeBtn = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox6 = new PictureBox();
            label3 = new Label();
            IncSum = new Label();
            panel4 = new Panel();
            AmountTotal = new Label();
            pictureBox10 = new PictureBox();
            ExpCount = new Label();
            IncCount = new Label();
            label17 = new Label();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            label14 = new Label();
            label2 = new Label();
            ExpSum = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExpenseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DashboardBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IncomeBtn).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(84, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1212, 69);
            panel2.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(16, 9);
            label7.Name = "label7";
            label7.Size = new Size(190, 40);
            label7.TabIndex = 4;
            label7.Text = "SmartBudget";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(59, 66);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(ExpenseBtn);
            panel1.Controls.Add(DashboardBtn);
            panel1.Controls.Add(LogoutBtn);
            panel1.Controls.Add(IncomeBtn);
            panel1.Controls.Add(pictureBox7);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 811);
            panel1.TabIndex = 3;
            // 
            // ExpenseBtn
            // 
            ExpenseBtn.BackColor = Color.FromArgb(255, 41, 41);
            ExpenseBtn.Cursor = Cursors.Hand;
            ExpenseBtn.Image = (Image)resources.GetObject("ExpenseBtn.Image");
            ExpenseBtn.Location = new Point(12, 440);
            ExpenseBtn.Name = "ExpenseBtn";
            ExpenseBtn.Size = new Size(59, 55);
            ExpenseBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            ExpenseBtn.TabIndex = 10;
            ExpenseBtn.TabStop = false;
            ExpenseBtn.Click += ExpenseBtn_Click_1;
            // 
            // DashboardBtn
            // 
            DashboardBtn.BackColor = Color.FromArgb(203, 163, 92);
            DashboardBtn.Cursor = Cursors.Hand;
            DashboardBtn.Image = (Image)resources.GetObject("DashboardBtn.Image");
            DashboardBtn.Location = new Point(12, 200);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(59, 55);
            DashboardBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            DashboardBtn.TabIndex = 11;
            DashboardBtn.TabStop = false;
            DashboardBtn.Click += DashboardBtn_Click_1;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Firebrick;
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.Image = (Image)resources.GetObject("LogoutBtn.Image");
            LogoutBtn.Location = new Point(0, 744);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(84, 67);
            LogoutBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            LogoutBtn.TabIndex = 1;
            LogoutBtn.TabStop = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // IncomeBtn
            // 
            IncomeBtn.BackColor = Color.FromArgb(92, 179, 56);
            IncomeBtn.Cursor = Cursors.Hand;
            IncomeBtn.Image = (Image)resources.GetObject("IncomeBtn.Image");
            IncomeBtn.Location = new Point(12, 320);
            IncomeBtn.Name = "IncomeBtn";
            IncomeBtn.Size = new Size(59, 55);
            IncomeBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            IncomeBtn.TabIndex = 12;
            IncomeBtn.TabStop = false;
            IncomeBtn.Click += IncomeBtn_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(IncSum);
            panel3.Location = new Point(129, 320);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 263);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(76, 175, 80);
            label1.Location = new Point(101, 13);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 6;
            label1.Text = "Przychody";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(59, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(62, 123, 39);
            label3.Location = new Point(59, 102);
            label3.Name = "label3";
            label3.Size = new Size(182, 25);
            label3.TabIndex = 7;
            label3.Text = "Suma przychodów:";
            // 
            // IncSum
            // 
            IncSum.AutoSize = true;
            IncSum.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            IncSum.ForeColor = Color.FromArgb(62, 123, 39);
            IncSum.Location = new Point(59, 138);
            IncSum.Name = "IncSum";
            IncSum.Size = new Size(27, 25);
            IncSum.TabIndex = 7;
            IncSum.Text = "zł";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(AmountTotal);
            panel4.Controls.Add(pictureBox10);
            panel4.Controls.Add(ExpCount);
            panel4.Controls.Add(IncCount);
            panel4.Location = new Point(532, 200);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 263);
            panel4.TabIndex = 5;
            // 
            // AmountTotal
            // 
            AmountTotal.AutoSize = true;
            AmountTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AmountTotal.Location = new Point(16, 212);
            AmountTotal.Name = "AmountTotal";
            AmountTotal.Size = new Size(27, 25);
            AmountTotal.TabIndex = 8;
            AmountTotal.Text = "zł";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(128, 16);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(59, 55);
            pictureBox10.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox10.TabIndex = 1;
            pictureBox10.TabStop = false;
            // 
            // ExpCount
            // 
            ExpCount.AutoSize = true;
            ExpCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExpCount.ForeColor = Color.Red;
            ExpCount.Location = new Point(16, 120);
            ExpCount.Name = "ExpCount";
            ExpCount.Size = new Size(218, 25);
            ExpCount.TabIndex = 7;
            ExpCount.Text = "Łączna ilość wydatków:";
            // 
            // IncCount
            // 
            IncCount.AutoSize = true;
            IncCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            IncCount.ForeColor = Color.FromArgb(62, 123, 39);
            IncCount.Location = new Point(16, 84);
            IncCount.Name = "IncCount";
            IncCount.Size = new Size(236, 25);
            IncCount.TabIndex = 7;
            IncCount.Text = "Łączna ilość przychodów:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(548, 104);
            label17.Name = "label17";
            label17.Size = new Size(297, 45);
            label17.TabIndex = 6;
            label17.Text = "Przegląd finansów";
            label17.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonFace;
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(ExpSum);
            panel5.Location = new Point(936, 320);
            panel5.Name = "panel5";
            panel5.Size = new Size(313, 263);
            panel5.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ExpenseBtn_Click_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Maroon;
            label14.Location = new Point(110, 13);
            label14.Name = "label14";
            label14.Size = new Size(104, 32);
            label14.TabIndex = 7;
            label14.Text = "Wydatki";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(64, 102);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 7;
            label2.Text = "Suma wydatków:";
            // 
            // ExpSum
            // 
            ExpSum.AutoSize = true;
            ExpSum.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExpSum.ForeColor = Color.Maroon;
            ExpSum.Location = new Point(64, 138);
            ExpSum.Name = "ExpSum";
            ExpSum.Size = new Size(27, 25);
            ExpSum.TabIndex = 7;
            ExpSum.Text = "zł";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 178);
            label4.Name = "label4";
            label4.Size = new Size(224, 25);
            label4.TabIndex = 8;
            label4.Text = "Aktualna ilość środków:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1296, 811);
            Controls.Add(panel5);
            Controls.Add(label17);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ExpenseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)DashboardBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)IncomeBtn).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label7;
        private PictureBox pictureBox7;
        private Panel panel1;
        private PictureBox LogoutBtn;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox10;
        private Label label14;
        private PictureBox ExpenseBtn;
        private PictureBox DashboardBtn;
        private PictureBox IncomeBtn;
        private Label IncSum;
        private Label label17;
        private Label IncCount;
        private Label ExpSum;
        private PictureBox pictureBox1;
        private Label ExpCount;
        private Label AmountTotal;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}