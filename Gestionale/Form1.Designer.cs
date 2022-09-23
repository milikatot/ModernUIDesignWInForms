namespace Gestionale
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
            this.pjTextBox1 = new Gestionale.Controls.PJTextBox();
            this.pjTextBox2 = new Gestionale.Controls.PJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pjButton1 = new Gestionale.Controls.PJButton();
            this.SuspendLayout();
            // 
            // pjTextBox1
            // 
            this.pjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.pjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.pjTextBox1.BorderSize = 2;
            this.pjTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pjTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.pjTextBox1.Location = new System.Drawing.Point(66, 74);
            this.pjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pjTextBox1.Multiline = false;
            this.pjTextBox1.Name = "pjTextBox1";
            this.pjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.pjTextBox1.PasswordChar = false;
            this.pjTextBox1.Size = new System.Drawing.Size(250, 32);
            this.pjTextBox1.TabIndex = 0;
            this.pjTextBox1.Texts = "";
            this.pjTextBox1.UnderLinedStyle = true;
            // 
            // pjTextBox2
            // 
            this.pjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pjTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.pjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.pjTextBox2.BorderSize = 2;
            this.pjTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pjTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.pjTextBox2.Location = new System.Drawing.Point(436, 74);
            this.pjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pjTextBox2.Multiline = false;
            this.pjTextBox2.Name = "pjTextBox2";
            this.pjTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.pjTextBox2.PasswordChar = true;
            this.pjTextBox2.Size = new System.Drawing.Size(250, 32);
            this.pjTextBox2.TabIndex = 1;
            this.pjTextBox2.Texts = "";
            this.pjTextBox2.UnderLinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // pjButton1
            // 
            this.pjButton1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pjButton1.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.pjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pjButton1.BorderRadius = 40;
            this.pjButton1.BorderSize = 0;
            this.pjButton1.FlatAppearance.BorderSize = 0;
            this.pjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pjButton1.ForeColor = System.Drawing.Color.White;
            this.pjButton1.Location = new System.Drawing.Point(290, 140);
            this.pjButton1.Name = "pjButton1";
            this.pjButton1.Size = new System.Drawing.Size(150, 40);
            this.pjButton1.TabIndex = 5;
            this.pjButton1.Text = "pjButton1";
            this.pjButton1.TextColor = System.Drawing.Color.White;
            this.pjButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pjButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pjTextBox2);
            this.Controls.Add(this.pjTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PJTextBox pjTextBox1;
        private Controls.PJTextBox pjTextBox2;
        private Label label1;
        private Label label2;
        private Controls.PJButton pjButton1;
    }
}