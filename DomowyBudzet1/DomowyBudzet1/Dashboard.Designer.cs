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
            IncLbl = new Label();
            panel4 = new Panel();
            label17 = new Label();
            pictureBox10 = new PictureBox();
            SummaryLbl = new Label();
            panel5 = new Panel();
            label14 = new Label();
            ExpLbl = new Label();
            pictureBox1 = new PictureBox();
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
            panel2.BackColor = Color.White;
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
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(16, 9);
            label7.Name = "label7";
            label7.Size = new Size(200, 40);
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
            panel1.BackColor = Color.White;
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
            ExpenseBtn.Cursor = Cursors.Hand;
            ExpenseBtn.Image = (Image)resources.GetObject("ExpenseBtn.Image");
            ExpenseBtn.Location = new Point(12, 320);
            ExpenseBtn.Name = "ExpenseBtn";
            ExpenseBtn.Size = new Size(59, 55);
            ExpenseBtn.TabIndex = 10;
            ExpenseBtn.TabStop = false;
            ExpenseBtn.Click += ExpenseBtn_Click_1;
            // 
            // DashboardBtn
            // 
            DashboardBtn.Cursor = Cursors.Hand;
            DashboardBtn.Image = (Image)resources.GetObject("DashboardBtn.Image");
            DashboardBtn.Location = new Point(12, 200);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(59, 55);
            DashboardBtn.TabIndex = 11;
            DashboardBtn.TabStop = false;
            DashboardBtn.Click += DashboardBtn_Click_1;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Firebrick;
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.Image = (Image)resources.GetObject("LogoutBtn.Image");
            LogoutBtn.Location = new Point(12, 744);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(59, 55);
            LogoutBtn.TabIndex = 1;
            LogoutBtn.TabStop = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // IncomeBtn
            // 
            IncomeBtn.Cursor = Cursors.Hand;
            IncomeBtn.Image = (Image)resources.GetObject("IncomeBtn.Image");
            IncomeBtn.Location = new Point(12, 440);
            IncomeBtn.Name = "IncomeBtn";
            IncomeBtn.Size = new Size(59, 55);
            IncomeBtn.TabIndex = 12;
            IncomeBtn.TabStop = false;
            IncomeBtn.Click += IncomeBtn_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(IncLbl);
            panel3.Location = new Point(129, 320);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 263);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 6;
            label1.Text = "Przychody";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(14, 57);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(59, 55);
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // IncLbl
            // 
            IncLbl.AutoSize = true;
            IncLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IncLbl.ForeColor = Color.LimeGreen;
            IncLbl.Location = new Point(95, 57);
            IncLbl.Name = "IncLbl";
            IncLbl.Size = new Size(131, 21);
            IncLbl.TabIndex = 7;
            IncLbl.Text = "Przychody w PLN";
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(label17);
            panel4.Controls.Add(pictureBox10);
            panel4.Controls.Add(SummaryLbl);
            panel4.Location = new Point(510, 320);
            panel4.Name = "panel4";
            panel4.Size = new Size(313, 263);
            panel4.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(16, 13);
            label17.Name = "label17";
            label17.Size = new Size(116, 21);
            label17.TabIndex = 6;
            label17.Text = "Podsumowanie";
            label17.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(16, 57);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(59, 55);
            pictureBox10.TabIndex = 1;
            pictureBox10.TabStop = false;
            // 
            // SummaryLbl
            // 
            SummaryLbl.AutoSize = true;
            SummaryLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SummaryLbl.ForeColor = Color.LimeGreen;
            SummaryLbl.Location = new Point(99, 57);
            SummaryLbl.Name = "SummaryLbl";
            SummaryLbl.Size = new Size(131, 21);
            SummaryLbl.TabIndex = 7;
            SummaryLbl.Text = "Przychody w PLN";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Beige;
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(ExpLbl);
            panel5.Location = new Point(926, 320);
            panel5.Name = "panel5";
            panel5.Size = new Size(313, 263);
            panel5.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Maroon;
            label14.Location = new Point(25, 13);
            label14.Name = "label14";
            label14.Size = new Size(67, 21);
            label14.TabIndex = 7;
            label14.Text = "Wydatki";
            // 
            // ExpLbl
            // 
            ExpLbl.AutoSize = true;
            ExpLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpLbl.ForeColor = Color.LimeGreen;
            ExpLbl.Location = new Point(110, 57);
            ExpLbl.Name = "ExpLbl";
            ExpLbl.Size = new Size(116, 21);
            ExpLbl.TabIndex = 7;
            ExpLbl.Text = "Wydatki w PLN";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 55);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ExpenseBtn_Click_1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1296, 811);
            Controls.Add(panel5);
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
        private Label IncLbl;
        private Label label17;
        private Label SummaryLbl;
        private Label ExpLbl;
        private PictureBox pictureBox1;
    }
}