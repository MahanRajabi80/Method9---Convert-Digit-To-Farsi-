namespace Example_10_9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputDigit = new System.Windows.Forms.TextBox();
            this.btnConvertFarsi = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Digit (Maxlength=12):";
            // 
            // txtInputDigit
            // 
            this.txtInputDigit.Location = new System.Drawing.Point(154, 37);
            this.txtInputDigit.MaxLength = 12;
            this.txtInputDigit.Name = "txtInputDigit";
            this.txtInputDigit.Size = new System.Drawing.Size(301, 20);
            this.txtInputDigit.TabIndex = 0;
            // 
            // btnConvertFarsi
            // 
            this.btnConvertFarsi.Location = new System.Drawing.Point(237, 80);
            this.btnConvertFarsi.Name = "btnConvertFarsi";
            this.btnConvertFarsi.Size = new System.Drawing.Size(75, 39);
            this.btnConvertFarsi.TabIndex = 1;
            this.btnConvertFarsi.Text = "Show Farsi";
            this.btnConvertFarsi.UseVisualStyleBackColor = true;
            this.btnConvertFarsi.Click += new System.EventHandler(this.btnConvertFarsi_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(12, 136);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult.Size = new System.Drawing.Size(459, 27);
            this.lblResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 172);
            this.Controls.Add(this.btnConvertFarsi);
            this.Controls.Add(this.txtInputDigit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Example 10-9 (Method9 - Convert Digit To Farsi)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputDigit;
        private System.Windows.Forms.Button btnConvertFarsi;
        private System.Windows.Forms.Label lblResult;
    }
}

