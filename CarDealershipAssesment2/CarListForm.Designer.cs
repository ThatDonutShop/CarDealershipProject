namespace CarDealershipAssesment2
{
    partial class CarListForm
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
            components = new System.ComponentModel.Container();
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
            ClearList = new Button();
            label10 = new Label();
            AverageCarSalesIncludingGst = new Label();
            label11 = new Label();
            AverageCarSalesExcludingGst = new Label();
            carErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)carErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // CarList
            // 
            CarList.Cursor = Cursors.UpArrow;
            CarList.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CarList.FormattingEnabled = true;
            CarList.ItemHeight = 15;
            CarList.Location = new Point(327, 76);
            CarList.MultiColumn = true;
            CarList.Name = "CarList";
            CarList.Size = new Size(460, 199);
            CarList.TabIndex = 0;
            // 
            // Make
            // 
            Make.BackColor = Color.Silver;
            Make.Location = new Point(107, 76);
            Make.Name = "Make";
            Make.Size = new Size(185, 23);
            Make.TabIndex = 1;
            Make.Validating += ValidateNotEmpty;
            // 
            // Model
            // 
            Model.BackColor = Color.Silver;
            Model.Location = new Point(107, 126);
            Model.Name = "Model";
            Model.Size = new Size(185, 23);
            Model.TabIndex = 2;
            Model.Validating += ValidateNotEmpty;
            // 
            // Year
            // 
            Year.BackColor = Color.Silver;
            Year.Location = new Point(107, 175);
            Year.Name = "Year";
            Year.Size = new Size(185, 23);
            Year.TabIndex = 3;
            Year.Validating += ValidateYear;
            // 
            // Price
            // 
            Price.BackColor = Color.Silver;
            Price.Location = new Point(107, 221);
            Price.Name = "Price";
            Price.Size = new Size(185, 23);
            Price.TabIndex = 4;
            Price.Validating += ValidatePrice;
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
            label9.Location = new Point(670, 49);
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
            AddToList.Click += AddToList_OnClick;
            // 
            // ClearList
            // 
            ClearList.Location = new Point(217, 259);
            ClearList.Name = "ClearList";
            ClearList.Size = new Size(75, 31);
            ClearList.TabIndex = 15;
            ClearList.Text = "Clear List";
            ClearList.UseVisualStyleBackColor = true;
            ClearList.Click += ClearList_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Location = new Point(362, 304);
            label10.Name = "label10";
            label10.Size = new Size(171, 15);
            label10.TabIndex = 16;
            label10.Text = "Average car sale price (inc GST)";
            // 
            // AverageCarSalesIncludingGst
            // 
            AverageCarSalesIncludingGst.AutoSize = true;
            AverageCarSalesIncludingGst.BackColor = SystemColors.Control;
            AverageCarSalesIncludingGst.Location = new Point(551, 304);
            AverageCarSalesIncludingGst.Name = "AverageCarSalesIncludingGst";
            AverageCarSalesIncludingGst.Size = new Size(0, 15);
            AverageCarSalesIncludingGst.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(362, 327);
            label11.Name = "label11";
            label11.Size = new Size(176, 15);
            label11.TabIndex = 18;
            label11.Text = "Average car sale price (excl GST)";
            // 
            // AverageCarSalesExcludingGst
            // 
            AverageCarSalesExcludingGst.AutoSize = true;
            AverageCarSalesExcludingGst.BackColor = SystemColors.Control;
            AverageCarSalesExcludingGst.Location = new Point(551, 327);
            AverageCarSalesExcludingGst.Name = "AverageCarSalesExcludingGst";
            AverageCarSalesExcludingGst.Size = new Size(0, 15);
            AverageCarSalesExcludingGst.TabIndex = 19;
            // 
            // carErrorProvider
            // 
            carErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            carErrorProvider.ContainerControl = this;
            // 
            // CarListForm
            // 
            AcceptButton = AddToList;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 450);
            Controls.Add(AverageCarSalesExcludingGst);
            Controls.Add(label11);
            Controls.Add(AverageCarSalesIncludingGst);
            Controls.Add(label10);
            Controls.Add(ClearList);
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
            Name = "CarListForm";
            Text = "CarListForm";
            ((System.ComponentModel.ISupportInitialize)carErrorProvider).EndInit();
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
        private Button ClearList;
        private Label label10;
        private Label AverageCarSalesIncludingGst;
        private Label label11;
        private Label AverageCarSalesExcludingGst;
        private ErrorProvider errorProvider1;
        private ErrorProvider carErrorProvider;
    }
}