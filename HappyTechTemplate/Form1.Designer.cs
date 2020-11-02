namespace HappyTechTemplate
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
            this.tmpl_slct_txt = new System.Windows.Forms.TextBox();
            this.btnCV = new System.Windows.Forms.Button();
            this.btnInterview = new System.Windows.Forms.Button();
            this.btnTechInterview = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmpl_slct_txt
            // 
            this.tmpl_slct_txt.Location = new System.Drawing.Point(327, 55);
            this.tmpl_slct_txt.Margin = new System.Windows.Forms.Padding(4);
            this.tmpl_slct_txt.Name = "tmpl_slct_txt";
            this.tmpl_slct_txt.Size = new System.Drawing.Size(399, 22);
            this.tmpl_slct_txt.TabIndex = 3;
            this.tmpl_slct_txt.Text = "Template Select";
            this.tmpl_slct_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tmpl_slct_txt.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnCV
            // 
            this.btnCV.Location = new System.Drawing.Point(78, 130);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(98, 38);
            this.btnCV.TabIndex = 7;
            this.btnCV.Text = "CV";
            this.btnCV.UseVisualStyleBackColor = true;
            this.btnCV.Click += new System.EventHandler(this.btnCV_Click);
            // 
            // btnInterview
            // 
            this.btnInterview.Location = new System.Drawing.Point(78, 186);
            this.btnInterview.Name = "btnInterview";
            this.btnInterview.Size = new System.Drawing.Size(98, 43);
            this.btnInterview.TabIndex = 8;
            this.btnInterview.Text = "Interview";
            this.btnInterview.UseVisualStyleBackColor = true;
            // 
            // btnTechInterview
            // 
            this.btnTechInterview.Location = new System.Drawing.Point(78, 246);
            this.btnTechInterview.Name = "btnTechInterview";
            this.btnTechInterview.Size = new System.Drawing.Size(98, 54);
            this.btnTechInterview.TabIndex = 9;
            this.btnTechInterview.Text = "Technical Interview";
            this.btnTechInterview.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(388, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 229);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(108, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTechInterview);
            this.Controls.Add(this.btnInterview);
            this.Controls.Add(this.btnCV);
            this.Controls.Add(this.tmpl_slct_txt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tmpl_slct_txt;        
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btnInterview;
        private System.Windows.Forms.Button btnTechInterview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
    }
}

