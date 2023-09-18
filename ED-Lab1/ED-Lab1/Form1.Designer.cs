namespace ED_Lab1
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
            label1 = new Label();
            txtStudentNo = new TextBox();
            label2 = new Label();
            cbProg = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtLast = new TextBox();
            txtFirst = new TextBox();
            txtMiddle = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtAge = new TextBox();
            txtContact = new TextBox();
            label8 = new Label();
            txtAddress = new TextBox();
            btnNext = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudentNo.Location = new Point(14, 45);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(231, 25);
            txtStudentNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(276, 21);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 2;
            label2.Text = "Program:";
            // 
            // cbProg
            // 
            cbProg.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbProg.FormattingEnabled = true;
            cbProg.Items.AddRange(new object[] { "BSIT", "BSCS", "BSAIS", "BSHM", "BSED" });
            cbProg.Location = new Point(276, 45);
            cbProg.Name = "cbProg";
            cbProg.Size = new Size(263, 25);
            cbProg.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 89);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(157, 89);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 5;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(402, 89);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 6;
            label5.Text = "Middle Name";
            // 
            // txtLast
            // 
            txtLast.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtLast.Location = new Point(12, 113);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(129, 25);
            txtLast.TabIndex = 7;
            // 
            // txtFirst
            // 
            txtFirst.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirst.Location = new Point(158, 113);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(227, 25);
            txtFirst.TabIndex = 8;
            // 
            // txtMiddle
            // 
            txtMiddle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtMiddle.Location = new Point(404, 113);
            txtMiddle.Name = "txtMiddle";
            txtMiddle.Size = new Size(161, 25);
            txtMiddle.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 160);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 10;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(187, 160);
            label7.Name = "label7";
            label7.Size = new Size(101, 21);
            label7.TabIndex = 11;
            label7.Text = "Contact No.:";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAge.Location = new Point(13, 185);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(129, 25);
            txtAge.TabIndex = 12;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtContact.Location = new Point(187, 185);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(189, 25);
            txtContact.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(13, 233);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 14;
            label8.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddress.Location = new Point(14, 257);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(582, 127);
            txtAddress.TabIndex = 15;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.ActiveCaption;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(262, 397);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(82, 37);
            btnNext.TabIndex = 16;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 450);
            Controls.Add(btnNext);
            Controls.Add(txtAddress);
            Controls.Add(label8);
            Controls.Add(txtContact);
            Controls.Add(txtAge);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtMiddle);
            Controls.Add(txtFirst);
            Controls.Add(txtLast);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbProg);
            Controls.Add(label2);
            Controls.Add(txtStudentNo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentNo;
        private Label label2;
        private ComboBox cbProg;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtLast;
        private TextBox txtFirst;
        private TextBox txtMiddle;
        private Label label6;
        private Label label7;
        private TextBox txtAge;
        private TextBox txtContact;
        private Label label8;
        private TextBox txtAddress;
        private Button btnNext;
    }
}