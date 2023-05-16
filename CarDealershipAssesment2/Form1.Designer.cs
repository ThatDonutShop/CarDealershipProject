namespace CarDealershipAssesment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CarList = new ListBox();
            Make = new TextBox();
            Model = new TextBox();
            Year = new TextBox();
            Price = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            AddToList = new Button();
            btnClearList = new Button();
            label10 = new Label();
            AverageCarSalesIncludingGst = new Label();
            SuspendLayout();
            // 
            // CarList
            // 
            CarList.Cursor = Cursors.UpArrow;
            CarList.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CarList.FormattingEnabled = true;
            CarList.ItemHeight = 29;
            CarList.Location = new Point(327, 76);
            CarList.MultiColumn = true;
            CarList.Name = "CarList";
            CarList.Size = new Size(461, 207);
            CarList.TabIndex = 0;
            // 
            // Make
            // 
            Make.BackColor = Color.Silver;
            Make.Location = new Point(107, 76);
            Make.Name = "Make";
            Make.Size = new Size(185, 23);
            Make.TabIndex = 1;
            // 
            // Model
            // 
            Model.BackColor = Color.Silver;
            Model.Location = new Point(107, 126);
            Model.Name = "Model";
            Model.Size = new Size(185, 23);
            Model.TabIndex = 2;
            // 
            // Year
            // 
            Year.BackColor = Color.Silver;
            Year.Location = new Point(107, 175);
            Year.Name = "Year";
            Year.Size = new Size(185, 23);
            Year.TabIndex = 3;
            // 
            // Price
            // 
            Price.BackColor = Color.Silver;
            Price.Location = new Point(107, 221);
            Price.Name = "Price";
            Price.Size = new Size(185, 23);
            Price.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 79);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Make:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 129);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 6;
            label2.Text = "Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 178);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 7;
            label3.Text = "Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 224);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 49);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Make";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(424, 49);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 10;
            label6.Text = "Model";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(516, 49);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 11;
            label7.Text = "Year";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(597, 49);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 12;
            label8.Text = "Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(673, 49);
            label9.Name = "label9";
            label9.Size = new Size(117, 15);
            label9.TabIndex = 13;
            label9.Text = "Price (Including GST)";
            // 
            // AddToList
            // 
            AddToList.Location = new Point(107, 259);
            AddToList.Name = "AddToList";
            AddToList.Size = new Size(75, 31);
            AddToList.TabIndex = 14;
            AddToList.Text = "Add To List";
            AddToList.UseVisualStyleBackColor = true;
            AddToList.Click += AddToList_Click;
            // 
            // btnClearList
            // 
            btnClearList.Location = new Point(217, 259);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new Size(75, 31);
            btnClearList.TabIndex = 15;
            btnClearList.Text = "Clear List";
            btnClearList.UseVisualStyleBackColor = true;
            btnClearList.Click += ClearCarList_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(362, 302);
            label10.Name = "label10";
            label10.Size = new Size(171, 15);
            label10.TabIndex = 16;
            label10.Text = "Average car sale price (inc GST)";
            // 
            // AverageCarSalesIncludingGst
            // 
            AverageCarSalesIncludingGst.AutoSize = true;
            AverageCarSalesIncludingGst.Location = new Point(539, 302);
            AverageCarSalesIncludingGst.Name = "AverageCarSalesIncludingGst";
            AverageCarSalesIncludingGst.Size = new Size(0, 15);
            AverageCarSalesIncludingGst.TabIndex = 17;
            // 
            // Form1
            // 
            AcceptButton = AddToList;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 450);
            Controls.Add(AverageCarSalesIncludingGst);
            Controls.Add(label10);
            Controls.Add(btnClearList);
            Controls.Add(AddToList);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Price);
            Controls.Add(Year);
            Controls.Add(Model);
            Controls.Add(Make);
            Controls.Add(CarList);
            Name = "Form1";
            Text = "CarListForm";
            Load += LoadForm;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox CarList;
        private TextBox Make;
        private TextBox Model;
        private TextBox Year;
        private TextBox Price;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button AddToList;
        private Button btnClearList;
        private Label label10;
        private Label AverageCarSalesIncludingGst;
    }
}