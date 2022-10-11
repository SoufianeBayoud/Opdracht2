namespace Oefening33
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_usd = new System.Windows.Forms.TextBox();
            this.txt_euro = new System.Windows.Forms.TextBox();
            this.txt_pounds = new System.Windows.Forms.TextBox();
            this.txt_frank = new System.Windows.Forms.TextBox();
            this.txt_yen = new System.Windows.Forms.TextBox();
            this.txt_rupees = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "EUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pounds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Frank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rupees";
            // 
            // txt_usd
            // 
            this.txt_usd.Location = new System.Drawing.Point(164, 90);
            this.txt_usd.Name = "txt_usd";
            this.txt_usd.Size = new System.Drawing.Size(100, 23);
            this.txt_usd.TabIndex = 7;
            // 
            // txt_euro
            // 
            this.txt_euro.Location = new System.Drawing.Point(164, 124);
            this.txt_euro.Name = "txt_euro";
            this.txt_euro.Size = new System.Drawing.Size(100, 23);
            this.txt_euro.TabIndex = 8;
            // 
            // txt_pounds
            // 
            this.txt_pounds.Location = new System.Drawing.Point(164, 158);
            this.txt_pounds.Name = "txt_pounds";
            this.txt_pounds.Size = new System.Drawing.Size(100, 23);
            this.txt_pounds.TabIndex = 9;
            // 
            // txt_frank
            // 
            this.txt_frank.Location = new System.Drawing.Point(164, 188);
            this.txt_frank.Name = "txt_frank";
            this.txt_frank.Size = new System.Drawing.Size(100, 23);
            this.txt_frank.TabIndex = 10;
            // 
            // txt_yen
            // 
            this.txt_yen.Location = new System.Drawing.Point(164, 219);
            this.txt_yen.Name = "txt_yen";
            this.txt_yen.Size = new System.Drawing.Size(100, 23);
            this.txt_yen.TabIndex = 11;
            // 
            // txt_rupees
            // 
            this.txt_rupees.Location = new System.Drawing.Point(164, 248);
            this.txt_rupees.Name = "txt_rupees";
            this.txt_rupees.Size = new System.Drawing.Size(100, 23);
            this.txt_rupees.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_rupees);
            this.Controls.Add(this.txt_yen);
            this.Controls.Add(this.txt_frank);
            this.Controls.Add(this.txt_pounds);
            this.Controls.Add(this.txt_euro);
            this.Controls.Add(this.txt_usd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_usd;
        private TextBox txt_euro;
        private TextBox txt_pounds;
        private TextBox txt_frank;
        private TextBox txt_yen;
        private TextBox txt_rupees;
    }
}