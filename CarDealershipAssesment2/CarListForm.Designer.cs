namespace CarDealership.WinForms
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
            label12 = new Label();
            TaxPayment = new Label();
            SaveFile = new Button();
            LoadFile = new Button();
            Search = new Button();
            SearchBy = new ComboBox();
            SearchByMake = new TextBox();
            SearchByPriceFrom = new NumericUpDown();
            SearchByPriceTo = new NumericUpDown();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            MakeAndPriceRangePanel = new Panel();
            label17 = new Label();
            SearchByYearPanel = new Panel();
            SearchByYear = new DateTimePicker();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)carErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchByPriceFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchByPriceTo).BeginInit();
            MakeAndPriceRangePanel.SuspendLayout();
            SearchByYearPanel.SuspendLayout();
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
            label6.Location = new Point(441, 49);
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
            label10.Location = new Point(385, 304);
            label10.Name = "label10";
            label10.Size = new Size(171, 15);
            label10.TabIndex = 16;
            label10.Text = "Average car sale price (inc GST)";
            // 
            // AverageCarSalesIncludingGst
            // 
            AverageCarSalesIncludingGst.AutoSize = true;
            AverageCarSalesIncludingGst.BackColor = SystemColors.Control;
            AverageCarSalesIncludingGst.Location = new Point(567, 304);
            AverageCarSalesIncludingGst.Name = "AverageCarSalesIncludingGst";
            AverageCarSalesIncludingGst.Size = new Size(34, 15);
            AverageCarSalesIncludingGst.TabIndex = 17;
            AverageCarSalesIncludingGst.Text = "$0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(380, 327);
            label11.Name = "label11";
            label11.Size = new Size(176, 15);
            label11.TabIndex = 18;
            label11.Text = "Average car sale price (excl GST)";
            // 
            // AverageCarSalesExcludingGst
            // 
            AverageCarSalesExcludingGst.AutoSize = true;
            AverageCarSalesExcludingGst.BackColor = SystemColors.Control;
            AverageCarSalesExcludingGst.Location = new Point(567, 327);
            AverageCarSalesExcludingGst.Name = "AverageCarSalesExcludingGst";
            AverageCarSalesExcludingGst.Size = new Size(34, 15);
            AverageCarSalesExcludingGst.TabIndex = 19;
            AverageCarSalesExcludingGst.Text = "$0.00";
            // 
            // carErrorProvider
            // 
            carErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            carErrorProvider.ContainerControl = this;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(482, 351);
            label12.Name = "label12";
            label12.Size = new Size(74, 15);
            label12.TabIndex = 20;
            label12.Text = "Tax payment";
            // 
            // TaxPayment
            // 
            TaxPayment.AutoSize = true;
            TaxPayment.BackColor = SystemColors.Control;
            TaxPayment.Location = new Point(568, 351);
            TaxPayment.Name = "TaxPayment";
            TaxPayment.Size = new Size(34, 15);
            TaxPayment.TabIndex = 21;
            TaxPayment.Text = "$0.00";
            // 
            // SaveFile
            // 
            SaveFile.Location = new Point(686, 328);
            SaveFile.Name = "SaveFile";
            SaveFile.Size = new Size(75, 23);
            SaveFile.TabIndex = 22;
            SaveFile.Text = "Save file";
            SaveFile.UseVisualStyleBackColor = true;
            SaveFile.Click += SaveFile_Click;
            // 
            // LoadFile
            // 
            LoadFile.Location = new Point(686, 357);
            LoadFile.Name = "LoadFile";
            LoadFile.Size = new Size(75, 23);
            LoadFile.TabIndex = 23;
            LoadFile.Text = "Load file";
            LoadFile.UseVisualStyleBackColor = true;
            LoadFile.Click += LoadFile_Click;
            // 
            // Search
            // 
            Search.Location = new Point(234, 304);
            Search.Name = "Search";
            Search.Size = new Size(75, 23);
            Search.TabIndex = 24;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // SearchBy
            // 
            SearchBy.FormattingEnabled = true;
            SearchBy.Location = new Point(107, 304);
            SearchBy.Name = "SearchBy";
            SearchBy.Size = new Size(121, 23);
            SearchBy.TabIndex = 25;
            SearchBy.SelectedIndexChanged += SearchBy_SelectedIndexChanged;
            // 
            // SearchByMake
            // 
            SearchByMake.Location = new Point(76, 13);
            SearchByMake.Name = "SearchByMake";
            SearchByMake.Size = new Size(121, 23);
            SearchByMake.TabIndex = 26;
            // 
            // SearchByPriceFrom
            // 
            SearchByPriceFrom.Location = new Point(76, 42);
            SearchByPriceFrom.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            SearchByPriceFrom.Name = "SearchByPriceFrom";
            SearchByPriceFrom.Size = new Size(88, 23);
            SearchByPriceFrom.TabIndex = 27;
            SearchByPriceFrom.Validating += ValidatePriceFromSearch;
            // 
            // SearchByPriceTo
            // 
            SearchByPriceTo.Location = new Point(76, 71);
            SearchByPriceTo.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            SearchByPriceTo.Name = "SearchByPriceTo";
            SearchByPriceTo.Size = new Size(88, 23);
            SearchByPriceTo.TabIndex = 28;
            SearchByPriceTo.Validating += ValidatePriceTo;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(28, 16);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 29;
            label13.Text = "Make: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 73);
            label14.Name = "label14";
            label14.Size = new Size(50, 15);
            label14.TabIndex = 30;
            label14.Text = "Price to:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 44);
            label15.Name = "label15";
            label15.Size = new Size(65, 15);
            label15.TabIndex = 31;
            label15.Text = "Price from:";
            // 
            // MakeAndPriceRangePanel
            // 
            MakeAndPriceRangePanel.Controls.Add(label17);
            MakeAndPriceRangePanel.Controls.Add(SearchByMake);
            MakeAndPriceRangePanel.Controls.Add(label15);
            MakeAndPriceRangePanel.Controls.Add(SearchByPriceFrom);
            MakeAndPriceRangePanel.Controls.Add(label14);
            MakeAndPriceRangePanel.Controls.Add(SearchByPriceTo);
            MakeAndPriceRangePanel.Controls.Add(label13);
            MakeAndPriceRangePanel.Location = new Point(107, 338);
            MakeAndPriceRangePanel.Name = "MakeAndPriceRangePanel";
            MakeAndPriceRangePanel.Size = new Size(218, 179);
            MakeAndPriceRangePanel.TabIndex = 32;
            // 
            // label17
            // 
            label17.Location = new Point(7, 97);
            label17.Name = "label17";
            label17.Size = new Size(157, 76);
            label17.TabIndex = 32;
            label17.Text = "If you leave Price from and Price to at zero only make will be searched for. Vice versa";
            // 
            // SearchByYearPanel
            // 
            SearchByYearPanel.Controls.Add(SearchByYear);
            SearchByYearPanel.Controls.Add(label16);
            SearchByYearPanel.Location = new Point(344, 338);
            SearchByYearPanel.Name = "SearchByYearPanel";
            SearchByYearPanel.Size = new Size(218, 100);
            SearchByYearPanel.TabIndex = 33;
            SearchByYearPanel.Visible = false;
            // 
            // SearchByYear
            // 
            SearchByYear.CustomFormat = "yyyy";
            SearchByYear.Format = DateTimePickerFormat.Custom;
            SearchByYear.Location = new Point(55, 10);
            SearchByYear.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            SearchByYear.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            SearchByYear.Name = "SearchByYear";
            SearchByYear.ShowUpDown = true;
            SearchByYear.Size = new Size(86, 23);
            SearchByYear.TabIndex = 2;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 13);
            label16.Name = "label16";
            label16.Size = new Size(32, 15);
            label16.TabIndex = 0;
            label16.Text = "Year:";
            // 
            // CarListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 509);
            Controls.Add(SearchByYearPanel);
            Controls.Add(MakeAndPriceRangePanel);
            Controls.Add(SearchBy);
            Controls.Add(Search);
            Controls.Add(LoadFile);
            Controls.Add(SaveFile);
            Controls.Add(TaxPayment);
            Controls.Add(label12);
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
            Load += CarListForm_Load;
            ((System.ComponentModel.ISupportInitialize)carErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchByPriceFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchByPriceTo).EndInit();
            MakeAndPriceRangePanel.ResumeLayout(false);
            MakeAndPriceRangePanel.PerformLayout();
            SearchByYearPanel.ResumeLayout(false);
            SearchByYearPanel.PerformLayout();
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
        private ErrorProvider carErrorProvider;
        private Label label12;
        private Label TaxPayment;
        private Button SaveFile;
        private Button LoadFile;
        private Button Search;
        private ComboBox SearchBy;
        private Label label15;
        private Label label14;
        private Label label13;
        private NumericUpDown SearchByPriceTo;
        private NumericUpDown SearchByPriceFrom;
        private TextBox SearchByMake;
        private Panel MakeAndPriceRangePanel;
        private Panel SearchByYearPanel;
        private Label label16;
        private DateTimePicker SearchByYear;
        private Label label17;
    }
}