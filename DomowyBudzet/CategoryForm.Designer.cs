﻿namespace DomowyBudzet
{
    partial class CategoryForm
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Category_ClrBtn = new Button();
            Category_DelBtn = new Button();
            Category_EdtBtn = new Button();
            Category_AddBtn = new Button();
            Category_CmbBox = new ComboBox();
            Category_TxtBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            Category_GridView = new DataGridView();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Category_GridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Category_ClrBtn);
            panel1.Controls.Add(Category_DelBtn);
            panel1.Controls.Add(Category_EdtBtn);
            panel1.Controls.Add(Category_AddBtn);
            panel1.Controls.Add(Category_CmbBox);
            panel1.Controls.Add(Category_TxtBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 520);
            panel1.TabIndex = 0;
            // 
            // Category_ClrBtn
            // 
            Category_ClrBtn.BackColor = Color.MediumSeaGreen;
            Category_ClrBtn.FlatAppearance.BorderSize = 0;
            Category_ClrBtn.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Category_ClrBtn.FlatStyle = FlatStyle.Flat;
            Category_ClrBtn.Font = new Font("Segoe UI", 11.25F);
            Category_ClrBtn.Location = new Point(16, 291);
            Category_ClrBtn.Name = "Category_ClrBtn";
            Category_ClrBtn.Size = new Size(75, 40);
            Category_ClrBtn.TabIndex = 0;
            Category_ClrBtn.Text = "Wyczyść";
            Category_ClrBtn.UseVisualStyleBackColor = false;
            // 
            // Category_DelBtn
            // 
            Category_DelBtn.BackColor = Color.MediumSeaGreen;
            Category_DelBtn.FlatAppearance.BorderSize = 0;
            Category_DelBtn.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Category_DelBtn.FlatStyle = FlatStyle.Flat;
            Category_DelBtn.Font = new Font("Segoe UI", 11.25F);
            Category_DelBtn.Location = new Point(160, 291);
            Category_DelBtn.Name = "Category_DelBtn";
            Category_DelBtn.Size = new Size(75, 40);
            Category_DelBtn.TabIndex = 0;
            Category_DelBtn.Text = "Usuń";
            Category_DelBtn.UseVisualStyleBackColor = false;
            // 
            // Category_EdtBtn
            // 
            Category_EdtBtn.BackColor = Color.MediumSeaGreen;
            Category_EdtBtn.FlatAppearance.BorderSize = 0;
            Category_EdtBtn.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Category_EdtBtn.FlatStyle = FlatStyle.Flat;
            Category_EdtBtn.Font = new Font("Segoe UI", 11.25F);
            Category_EdtBtn.Location = new Point(160, 220);
            Category_EdtBtn.Name = "Category_EdtBtn";
            Category_EdtBtn.Size = new Size(75, 40);
            Category_EdtBtn.TabIndex = 0;
            Category_EdtBtn.Text = "Edytuj";
            Category_EdtBtn.UseVisualStyleBackColor = false;
            Category_EdtBtn.Click += Category_EdtBtn_Click;
            // 
            // Category_AddBtn
            // 
            Category_AddBtn.BackColor = Color.MediumSeaGreen;
            Category_AddBtn.FlatAppearance.BorderSize = 0;
            Category_AddBtn.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Category_AddBtn.FlatStyle = FlatStyle.Flat;
            Category_AddBtn.Font = new Font("Segoe UI", 11.25F);
            Category_AddBtn.Location = new Point(16, 220);
            Category_AddBtn.Name = "Category_AddBtn";
            Category_AddBtn.Size = new Size(75, 40);
            Category_AddBtn.TabIndex = 0;
            Category_AddBtn.Text = "Dodaj";
            Category_AddBtn.UseVisualStyleBackColor = false;
            Category_AddBtn.Click += Category_AddBtn_Click;
            // 
            // Category_CmbBox
            // 
            Category_CmbBox.FormattingEnabled = true;
            Category_CmbBox.Items.AddRange(new object[] { "Przychody", "Wydatki" });
            Category_CmbBox.Location = new Point(16, 116);
            Category_CmbBox.Name = "Category_CmbBox";
            Category_CmbBox.Size = new Size(219, 23);
            Category_CmbBox.TabIndex = 0;
            // 
            // Category_TxtBox
            // 
            Category_TxtBox.Location = new Point(16, 53);
            Category_TxtBox.Name = "Category_TxtBox";
            Category_TxtBox.Size = new Size(219, 23);
            Category_TxtBox.TabIndex = 0;
            Category_TxtBox.TextChanged += Category_TxtBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(16, 88);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 0;
            label2.Text = "Typ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Kategoria";
            // 
            // panel2
            // 
            panel2.Controls.Add(Category_GridView);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(290, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(720, 520);
            panel2.TabIndex = 0;
            // 
            // Category_GridView
            // 
            Category_GridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Category_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Category_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Category_GridView.EnableHeadersVisualStyles = false;
            Category_GridView.Location = new Point(3, 53);
            Category_GridView.Name = "Category_GridView";
            Category_GridView.RowHeadersVisible = false;
            Category_GridView.Size = new Size(714, 464);
            Category_GridView.TabIndex = 0;
            Category_GridView.CellClick += Category_GridView_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(3, 25);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 0;
            label3.Text = "Lista kategorii";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CategoryForm";
            Size = new Size(1029, 558);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Category_GridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox Category_CmbBox;
        private TextBox Category_TxtBox;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button Category_ClrBtn;
        private Button Category_DelBtn;
        private Button Category_EdtBtn;
        private Button Category_AddBtn;
        private DataGridView Category_GridView;
        private Label label3;
    }
}
