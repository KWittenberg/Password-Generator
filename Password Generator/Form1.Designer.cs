namespace Password_Generator
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
            this.checkBox1Lower = new System.Windows.Forms.CheckBox();
            this.checkBox2Upper = new System.Windows.Forms.CheckBox();
            this.checkBox3Numeric = new System.Windows.Forms.CheckBox();
            this.checkBox4Special = new System.Windows.Forms.CheckBox();
            this.button1Generate = new System.Windows.Forms.Button();
            this.txtPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button1Copy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1Lower
            // 
            this.checkBox1Lower.AutoSize = true;
            this.checkBox1Lower.Checked = true;
            this.checkBox1Lower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1Lower.Location = new System.Drawing.Point(89, 68);
            this.checkBox1Lower.Name = "checkBox1Lower";
            this.checkBox1Lower.Size = new System.Drawing.Size(58, 19);
            this.checkBox1Lower.TabIndex = 0;
            this.checkBox1Lower.Text = "Lower";
            this.checkBox1Lower.UseVisualStyleBackColor = true;
            // 
            // checkBox2Upper
            // 
            this.checkBox2Upper.AutoSize = true;
            this.checkBox2Upper.Checked = true;
            this.checkBox2Upper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2Upper.Location = new System.Drawing.Point(89, 106);
            this.checkBox2Upper.Name = "checkBox2Upper";
            this.checkBox2Upper.Size = new System.Drawing.Size(58, 19);
            this.checkBox2Upper.TabIndex = 0;
            this.checkBox2Upper.Text = "Upper";
            this.checkBox2Upper.UseVisualStyleBackColor = true;
            // 
            // checkBox3Numeric
            // 
            this.checkBox3Numeric.AutoSize = true;
            this.checkBox3Numeric.Checked = true;
            this.checkBox3Numeric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3Numeric.Location = new System.Drawing.Point(89, 142);
            this.checkBox3Numeric.Name = "checkBox3Numeric";
            this.checkBox3Numeric.Size = new System.Drawing.Size(72, 19);
            this.checkBox3Numeric.TabIndex = 0;
            this.checkBox3Numeric.Text = "Numeric";
            this.checkBox3Numeric.UseVisualStyleBackColor = true;
            // 
            // checkBox4Special
            // 
            this.checkBox4Special.AutoSize = true;
            this.checkBox4Special.Checked = true;
            this.checkBox4Special.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4Special.Location = new System.Drawing.Point(89, 179);
            this.checkBox4Special.Name = "checkBox4Special";
            this.checkBox4Special.Size = new System.Drawing.Size(63, 19);
            this.checkBox4Special.TabIndex = 0;
            this.checkBox4Special.Text = "Special";
            this.checkBox4Special.UseVisualStyleBackColor = true;
            // 
            // button1Generate
            // 
            this.button1Generate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1Generate.Location = new System.Drawing.Point(280, 159);
            this.button1Generate.Name = "button1Generate";
            this.button1Generate.Size = new System.Drawing.Size(277, 39);
            this.button1Generate.TabIndex = 1;
            this.button1Generate.Text = "GENERATE";
            this.button1Generate.UseVisualStyleBackColor = true;
            this.button1Generate.Click += new System.EventHandler(this.button1Generate_Click);
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.Location = new System.Drawing.Point(89, 232);
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.Size = new System.Drawing.Size(41, 23);
            this.txtPasswordLength.TabIndex = 2;
            this.txtPasswordLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(280, 226);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(205, 29);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = " hit Generate";
            // 
            // button1Copy
            // 
            this.button1Copy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1Copy.Location = new System.Drawing.Point(491, 216);
            this.button1Copy.Name = "button1Copy";
            this.button1Copy.Size = new System.Drawing.Size(66, 39);
            this.button1Copy.TabIndex = 1;
            this.button1Copy.Text = "COPY";
            this.button1Copy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPasswordLength);
            this.Controls.Add(this.button1Copy);
            this.Controls.Add(this.button1Generate);
            this.Controls.Add(this.checkBox4Special);
            this.Controls.Add(this.checkBox3Numeric);
            this.Controls.Add(this.checkBox2Upper);
            this.Controls.Add(this.checkBox1Lower);
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBox1Lower;
        private CheckBox checkBox2Upper;
        private CheckBox checkBox3Numeric;
        private CheckBox checkBox4Special;
        private Button button1Generate;
        private NumericUpDown txtPasswordLength;
        private TextBox txtPassword;
        private Button button1Copy;
    }
}