namespace DomowyBudzet1
{
    partial class Incomes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incomes));
            label6 = new Label();
            IncomeList = new DataGridView();
            pictureBox6 = new PictureBox();
            DeleteBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            label5 = new Label();
            DescTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            CatTb = new TextBox();
            label2 = new Label();
            AmtTb = new TextBox();
            label8 = new Label();
            label1 = new Label();
            NameTb = new TextBox();
            panel2 = new Panel();
            label7 = new Label();
            panel1 = new Panel();
            ExpenseBtn = new PictureBox();
            LogoutBtn = new PictureBox();
            pictureBox7 = new PictureBox();
            DashboardBtn = new PictureBox();
            IncomeBtn = new PictureBox();
            DateTb = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)IncomeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExpenseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DashboardBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IncomeBtn).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(249, 112);
            label6.Name = "label6";
            label6.Size = new Size(161, 40);
            label6.TabIndex = 21;
            label6.Text = "Przychody";
            // 
            // IncomeList
            // 
            IncomeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            IncomeList.ColumnHeadersHeight = 30;
            IncomeList.Location = new Point(489, 190);
            IncomeList.Name = "IncomeList";
            IncomeList.RowTemplate.Height = 25;
            IncomeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            IncomeList.Size = new Size(795, 583);
            IncomeList.TabIndex = 33;
            IncomeList.CellContentClick += IncomeList_CellContentClick_1;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(156, 99);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(75, 78);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.White;
            DeleteBtn.FlatAppearance.BorderColor = Color.SeaGreen;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatAppearance.MouseOverBackColor = Color.Red;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.Location = new Point(156, 725);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(253, 48);
            DeleteBtn.TabIndex = 24;
            DeleteBtn.Text = "Usuń";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.White;
            EditBtn.FlatAppearance.BorderColor = Color.SeaGreen;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.Location = new Point(322, 650);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(87, 48);
            EditBtn.TabIndex = 23;
            EditBtn.Text = "Edytuj";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.White;
            AddBtn.FlatAppearance.BorderColor = Color.SeaGreen;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.Location = new Point(156, 650);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(87, 48);
            AddBtn.TabIndex = 22;
            AddBtn.Text = "Dodaj";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(162, 549);
            label5.Name = "label5";
            label5.Size = new Size(43, 21);
            label5.TabIndex = 20;
            label5.Text = "Opis";
            // 
            // DescTb
            // 
            DescTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescTb.Location = new Point(162, 573);
            DescTb.Name = "DescTb";
            DescTb.Size = new Size(247, 29);
            DescTb.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(162, 467);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 15;
            label4.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(162, 384);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 16;
            label3.Text = "Kategoria";
            // 
            // CatTb
            // 
            CatTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CatTb.Location = new Point(162, 408);
            CatTb.Name = "CatTb";
            CatTb.Size = new Size(247, 29);
            CatTb.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(162, 299);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 17;
            label2.Text = "Wartość";
            // 
            // AmtTb
            // 
            AmtTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmtTb.Location = new Point(162, 323);
            AmtTb.Name = "AmtTb";
            AmtTb.Size = new Size(247, 29);
            AmtTb.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(489, 156);
            label8.Name = "label8";
            label8.Size = new Size(137, 21);
            label8.TabIndex = 18;
            label8.Text = "Lista przychodów";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(162, 224);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 19;
            label1.Text = "Tytuł";
            // 
            // NameTb
            // 
            NameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameTb.Location = new Point(162, 248);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(247, 29);
            NameTb.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(84, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1212, 69);
            panel2.TabIndex = 9;
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ExpenseBtn);
            panel1.Controls.Add(LogoutBtn);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(DashboardBtn);
            panel1.Controls.Add(IncomeBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 811);
            panel1.TabIndex = 7;
            // 
            // ExpenseBtn
            // 
            ExpenseBtn.Cursor = Cursors.Hand;
            ExpenseBtn.Image = (Image)resources.GetObject("ExpenseBtn.Image");
            ExpenseBtn.Location = new Point(12, 320);
            ExpenseBtn.Name = "ExpenseBtn";
            ExpenseBtn.Size = new Size(59, 55);
            ExpenseBtn.TabIndex = 1;
            ExpenseBtn.TabStop = false;
            ExpenseBtn.Click += ExpenseBtn_Click;
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
            // DashboardBtn
            // 
            DashboardBtn.Cursor = Cursors.Hand;
            DashboardBtn.Image = (Image)resources.GetObject("DashboardBtn.Image");
            DashboardBtn.Location = new Point(12, 200);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(59, 55);
            DashboardBtn.TabIndex = 1;
            DashboardBtn.TabStop = false;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // IncomeBtn
            // 
            IncomeBtn.Cursor = Cursors.Hand;
            IncomeBtn.Image = (Image)resources.GetObject("IncomeBtn.Image");
            IncomeBtn.Location = new Point(12, 440);
            IncomeBtn.Name = "IncomeBtn";
            IncomeBtn.Size = new Size(59, 55);
            IncomeBtn.TabIndex = 1;
            IncomeBtn.TabStop = false;
            IncomeBtn.Click += IncomeBtn_Click;
            // 
            // DateTb
            // 
            DateTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DateTb.Format = DateTimePickerFormat.Short;
            DateTb.Location = new Point(162, 491);
            DateTb.Name = "DateTb";
            DateTb.Size = new Size(247, 29);
            DateTb.TabIndex = 26;
            // 
            // Incomes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1296, 811);
            Controls.Add(DateTb);
            Controls.Add(label6);
            Controls.Add(IncomeList);
            Controls.Add(pictureBox6);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(label5);
            Controls.Add(DescTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CatTb);
            Controls.Add(label2);
            Controls.Add(AmtTb);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(NameTb);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Incomes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Incomes";
            ((System.ComponentModel.ISupportInitialize)IncomeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ExpenseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)DashboardBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)IncomeBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DataGridView IncomeList;
        private PictureBox pictureBox6;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private Label label5;
        private TextBox DescTb;
        private Label label4;
        private Label label3;
        private TextBox CatTb;
        private Label label2;
        private TextBox AmtTb;
        private Label label8;
        private Label label1;
        private TextBox NameTb;
        private Panel panel2;
        private Label label7;
        private Panel panel1;
        private PictureBox ExpenseBtn;
        private PictureBox LogoutBtn;
        private PictureBox pictureBox7;
        private PictureBox DashboardBtn;
        private PictureBox IncomeBtn;
        private DateTimePicker DateTb;
    }
}