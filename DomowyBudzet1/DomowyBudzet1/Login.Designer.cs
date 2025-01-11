namespace DomowyBudzet1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label7 = new Label();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            CloseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(19, 16, 16);
            label7.Location = new Point(229, 259);
            label7.Name = "label7";
            label7.Size = new Size(190, 40);
            label7.TabIndex = 5;
            label7.Text = "SmartBudget";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(255, 125);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(133, 131);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(24, 28, 20);
            label1.Location = new Point(190, 45);
            label1.Name = "label1";
            label1.Size = new Size(261, 37);
            label1.TabIndex = 1;
            label1.Text = "Witamy w aplikacji";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 167, 69);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(192, 359);
            button1.Name = "button1";
            button1.Size = new Size(259, 48);
            button1.TabIndex = 2;
            button1.Text = "Przejdź do aplikacji";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.FromArgb(220, 53, 69);
            CloseBtn.FlatAppearance.BorderColor = Color.Black;
            CloseBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51);
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseBtn.ForeColor = Color.White;
            CloseBtn.Location = new Point(222, 441);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(199, 45);
            CloseBtn.TabIndex = 3;
            CloseBtn.Text = "Wyjdź";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(674, 531);
            Controls.Add(label7);
            Controls.Add(CloseBtn);
            Controls.Add(pictureBox7);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox7;
        private Label label7;
        private Label label1;
        private Button button1;
        private Button CloseBtn;
    }
}