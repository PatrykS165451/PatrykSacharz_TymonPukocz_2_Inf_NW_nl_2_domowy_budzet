namespace DomowyBudzet
{
    partial class IncomeForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Income_GridView = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            Income_ClearBtn = new Button();
            Income_DeleteBtn = new Button();
            Income_EditBtn = new Button();
            Income_AddBtn = new Button();
            Income_Date = new DateTimePicker();
            Income_Desc = new TextBox();
            Income_Income = new TextBox();
            Income_Item = new TextBox();
            Income_Category = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Income_GridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Income_GridView);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 261);
            panel1.TabIndex = 0;
            // 
            // Income_GridView
            // 
            Income_GridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Income_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Income_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Income_GridView.EnableHeadersVisualStyles = false;
            Income_GridView.Location = new Point(16, 33);
            Income_GridView.Name = "Income_GridView";
            Income_GridView.RowHeadersVisible = false;
            Income_GridView.Size = new Size(1070, 216);
            Income_GridView.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 2;
            label1.Text = "Income List";
            // 
            // panel2
            // 
            panel2.Controls.Add(Income_ClearBtn);
            panel2.Controls.Add(Income_DeleteBtn);
            panel2.Controls.Add(Income_EditBtn);
            panel2.Controls.Add(Income_AddBtn);
            panel2.Controls.Add(Income_Date);
            panel2.Controls.Add(Income_Desc);
            panel2.Controls.Add(Income_Income);
            panel2.Controls.Add(Income_Item);
            panel2.Controls.Add(Income_Category);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(27, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 337);
            panel2.TabIndex = 0;
            // 
            // Income_ClearBtn
            // 
            Income_ClearBtn.BackColor = Color.MediumSeaGreen;
            Income_ClearBtn.FlatAppearance.BorderSize = 0;
            Income_ClearBtn.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Income_ClearBtn.FlatStyle = FlatStyle.Flat;
            Income_ClearBtn.Font = new Font("Segoe UI", 11.25F);
            Income_ClearBtn.Location = new Point(640, 218);
            Income_ClearBtn.Name = "Income_ClearBtn";
            Income_ClearBtn.Size = new Size(75, 40);
            Income_ClearBtn.TabIndex = 6;
            Income_ClearBtn.Text = "Wyczyść";
            Income_ClearBtn.UseVisualStyleBackColor = false;
            // 
            // Income_DeleteBtn
            // 
            Income_DeleteBtn.BackColor = Color.MediumSeaGreen;
            Income_DeleteBtn.FlatAppearance.BorderSize = 0;
            Income_DeleteBtn.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Income_DeleteBtn.FlatStyle = FlatStyle.Flat;
            Income_DeleteBtn.Font = new Font("Segoe UI", 11.25F);
            Income_DeleteBtn.Location = new Point(522, 218);
            Income_DeleteBtn.Name = "Income_DeleteBtn";
            Income_DeleteBtn.Size = new Size(75, 40);
            Income_DeleteBtn.TabIndex = 6;
            Income_DeleteBtn.Text = "Usuń";
            Income_DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // Income_EditBtn
            // 
            Income_EditBtn.BackColor = Color.MediumSeaGreen;
            Income_EditBtn.FlatAppearance.BorderSize = 0;
            Income_EditBtn.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Income_EditBtn.FlatStyle = FlatStyle.Flat;
            Income_EditBtn.Font = new Font("Segoe UI", 11.25F);
            Income_EditBtn.Location = new Point(314, 218);
            Income_EditBtn.Name = "Income_EditBtn";
            Income_EditBtn.Size = new Size(75, 40);
            Income_EditBtn.TabIndex = 6;
            Income_EditBtn.Text = "Edytuj";
            Income_EditBtn.UseVisualStyleBackColor = false;
            // 
            // Income_AddBtn
            // 
            Income_AddBtn.BackColor = Color.MediumSeaGreen;
            Income_AddBtn.FlatAppearance.BorderSize = 0;
            Income_AddBtn.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Income_AddBtn.FlatStyle = FlatStyle.Flat;
            Income_AddBtn.Font = new Font("Segoe UI", 11.25F);
            Income_AddBtn.Location = new Point(196, 218);
            Income_AddBtn.Name = "Income_AddBtn";
            Income_AddBtn.Size = new Size(75, 40);
            Income_AddBtn.TabIndex = 6;
            Income_AddBtn.Text = "Dodaj";
            Income_AddBtn.UseVisualStyleBackColor = false;
            Income_AddBtn.Click += Income_AddBtn_Click;
            // 
            // Income_Date
            // 
            Income_Date.Location = new Point(515, 134);
            Income_Date.Name = "Income_Date";
            Income_Date.Size = new Size(200, 23);
            Income_Date.TabIndex = 5;
            // 
            // Income_Desc
            // 
            Income_Desc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Income_Desc.Location = new Point(515, 19);
            Income_Desc.Multiline = true;
            Income_Desc.Name = "Income_Desc";
            Income_Desc.Size = new Size(432, 77);
            Income_Desc.TabIndex = 4;
            // 
            // Income_Income
            // 
            Income_Income.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Income_Income.Location = new Point(128, 131);
            Income_Income.Name = "Income_Income";
            Income_Income.Size = new Size(157, 29);
            Income_Income.TabIndex = 4;
            // 
            // Income_Item
            // 
            Income_Item.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Income_Item.Location = new Point(128, 75);
            Income_Item.Name = "Income_Item";
            Income_Item.Size = new Size(157, 29);
            Income_Item.TabIndex = 4;
            // 
            // Income_Category
            // 
            Income_Category.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Income_Category.FormattingEnabled = true;
            Income_Category.Location = new Point(128, 16);
            Income_Category.Name = "Income_Category";
            Income_Category.Size = new Size(157, 29);
            Income_Category.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(464, 19);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 2;
            label5.Text = "Opis:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(464, 134);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 2;
            label6.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(48, 131);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 2;
            label4.Text = "Przychód:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(78, 75);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 2;
            label3.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(46, 19);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Kategoria:";
            // 
            // IncomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IncomeForm";
            Size = new Size(1145, 748);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Income_GridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox Income_Income;
        private TextBox Income_Item;
        private ComboBox Income_Category;
        private Label label4;
        private Label label3;
        private DateTimePicker Income_Date;
        private TextBox Income_Desc;
        private Label label5;
        private Label label6;
        private Button Income_ClearBtn;
        private Button Income_DeleteBtn;
        private Button Income_EditBtn;
        private Button Income_AddBtn;
        private DataGridView Income_GridView;
    }
}
