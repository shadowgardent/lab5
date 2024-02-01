namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSTUDENT = new System.Windows.Forms.TextBox();
            this.textBoxGPA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.TextBox();
            this.hightscore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lowscore = new System.Windows.Forms.TextBox();
            this.boxname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxgpa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAME";
            // 
            // textBoxSTUDENT
            // 
            this.textBoxSTUDENT.Location = new System.Drawing.Point(79, 39);
            this.textBoxSTUDENT.Name = "textBoxSTUDENT";
            this.textBoxSTUDENT.Size = new System.Drawing.Size(100, 20);
            this.textBoxSTUDENT.TabIndex = 2;
            // 
            // textBoxGPA
            // 
            this.textBoxGPA.Location = new System.Drawing.Point(79, 65);
            this.textBoxGPA.Name = "textBoxGPA";
            this.textBoxGPA.Size = new System.Drawing.Size(100, 20);
            this.textBoxGPA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "เกรด";
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(567, 113);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(100, 20);
            this.Average.TabIndex = 5;
            this.Average.TextChanged += new System.EventHandler(this.Average_TextChanged);
            // 
            // hightscore
            // 
            this.hightscore.Location = new System.Drawing.Point(567, 40);
            this.hightscore.Name = "hightscore";
            this.hightscore.Size = new System.Drawing.Size(100, 20);
            this.hightscore.TabIndex = 6;
            this.hightscore.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "hight score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Average";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "low score";
            // 
            // lowscore
            // 
            this.lowscore.Location = new System.Drawing.Point(565, 72);
            this.lowscore.Name = "lowscore";
            this.lowscore.Size = new System.Drawing.Size(100, 20);
            this.lowscore.TabIndex = 10;
            this.lowscore.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // boxname
            // 
            this.boxname.Location = new System.Drawing.Point(384, 40);
            this.boxname.Name = "boxname";
            this.boxname.Size = new System.Drawing.Size(100, 20);
            this.boxname.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "NAME";
            // 
            // boxgpa
            // 
            this.boxgpa.Location = new System.Drawing.Point(384, 76);
            this.boxgpa.Name = "boxgpa";
            this.boxgpa.Size = new System.Drawing.Size(100, 20);
            this.boxgpa.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "คะแนน";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boxgpa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxname);
            this.Controls.Add(this.lowscore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hightscore);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGPA);
            this.Controls.Add(this.textBoxSTUDENT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSTUDENT;
        private System.Windows.Forms.TextBox textBoxGPA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Average;
        private System.Windows.Forms.TextBox hightscore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lowscore;
        private System.Windows.Forms.TextBox boxname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxgpa;
        private System.Windows.Forms.Label label7;
    }
}

