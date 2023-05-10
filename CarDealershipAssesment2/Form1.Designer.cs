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
            this.CarList = new System.Windows.Forms.ListBox();
            this.tbxMake = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarList
            // 
            this.CarList.FormattingEnabled = true;
            this.CarList.ItemHeight = 15;
            this.CarList.Location = new System.Drawing.Point(327, 76);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(461, 214);
            this.CarList.TabIndex = 0;
            // 
            // tbxMake
            // 
            this.tbxMake.BackColor = System.Drawing.Color.Silver;
            this.tbxMake.Location = new System.Drawing.Point(107, 76);
            this.tbxMake.Name = "tbxMake";
            this.tbxMake.Size = new System.Drawing.Size(185, 23);
            this.tbxMake.TabIndex = 1;
            // 
            // tbxModel
            // 
            this.tbxModel.BackColor = System.Drawing.Color.Silver;
            this.tbxModel.Location = new System.Drawing.Point(107, 126);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(185, 23);
            this.tbxModel.TabIndex = 2;
            // 
            // tbxYear
            // 
            this.tbxYear.BackColor = System.Drawing.Color.Silver;
            this.tbxYear.Location = new System.Drawing.Point(107, 175);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(185, 23);
            this.tbxYear.TabIndex = 3;
            // 
            // tbxPrice
            // 
            this.tbxPrice.BackColor = System.Drawing.Color.Silver;
            this.tbxPrice.Location = new System.Drawing.Point(107, 221);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(185, 23);
            this.tbxPrice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Make:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Make";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(597, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(673, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Price (Including GST)";
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(107, 259);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(75, 31);
            this.btnAddToList.TabIndex = 14;
            this.btnAddToList.Text = "Add To List";
            this.btnAddToList.UseVisualStyleBackColor = true;
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(217, 259);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 31);
            this.btnClearList.TabIndex = 15;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.tbxMake);
            this.Controls.Add(this.CarList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox CarList;
        private TextBox tbxMake;
        private TextBox tbxModel;
        private TextBox tbxYear;
        private TextBox tbxPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnAddToList;
        private Button btnClearList;
    }
}