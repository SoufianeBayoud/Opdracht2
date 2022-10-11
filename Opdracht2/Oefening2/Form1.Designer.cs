namespace Oefening2
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
            this.checkKoe = new System.Windows.Forms.CheckBox();
            this.checkSlang = new System.Windows.Forms.CheckBox();
            this.checkVarken = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkKoe
            // 
            this.checkKoe.AutoSize = true;
            this.checkKoe.Location = new System.Drawing.Point(55, 58);
            this.checkKoe.Name = "checkKoe";
            this.checkKoe.Size = new System.Drawing.Size(46, 19);
            this.checkKoe.TabIndex = 0;
            this.checkKoe.Text = "Koe";
            this.checkKoe.UseVisualStyleBackColor = true;
            // 
            // checkSlang
            // 
            this.checkSlang.AutoSize = true;
            this.checkSlang.Location = new System.Drawing.Point(151, 58);
            this.checkSlang.Name = "checkSlang";
            this.checkSlang.Size = new System.Drawing.Size(55, 19);
            this.checkSlang.TabIndex = 1;
            this.checkSlang.Text = "Slang";
            this.checkSlang.UseVisualStyleBackColor = true;
            // 
            // checkVarken
            // 
            this.checkVarken.AutoSize = true;
            this.checkVarken.Location = new System.Drawing.Point(266, 58);
            this.checkVarken.Name = "checkVarken";
            this.checkVarken.Size = new System.Drawing.Size(61, 19);
            this.checkVarken.TabIndex = 2;
            this.checkVarken.Text = "Varken";
            this.checkVarken.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Laat horen !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 246);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkVarken);
            this.Controls.Add(this.checkSlang);
            this.Controls.Add(this.checkKoe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkKoe;
        private CheckBox checkSlang;
        private CheckBox checkVarken;
        private Button button1;
    }
}