
namespace Rca.Pool.Thermodynamics_TestBench
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
            this.txt_Temperature = new System.Windows.Forms.TextBox();
            this.txt_HumidityRel = new System.Windows.Forms.TextBox();
            this.txt_DrewPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.txt_HumidityAbs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_HumidityAbs = new System.Windows.Forms.RadioButton();
            this.rb_HumidityRel = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Temperature
            // 
            this.txt_Temperature.Location = new System.Drawing.Point(169, 25);
            this.txt_Temperature.Name = "txt_Temperature";
            this.txt_Temperature.Size = new System.Drawing.Size(100, 20);
            this.txt_Temperature.TabIndex = 0;
            this.txt_Temperature.Text = "25";
            // 
            // txt_HumidityRel
            // 
            this.txt_HumidityRel.Location = new System.Drawing.Point(169, 94);
            this.txt_HumidityRel.Name = "txt_HumidityRel";
            this.txt_HumidityRel.Size = new System.Drawing.Size(100, 20);
            this.txt_HumidityRel.TabIndex = 1;
            // 
            // txt_DrewPoint
            // 
            this.txt_DrewPoint.Location = new System.Drawing.Point(169, 192);
            this.txt_DrewPoint.Name = "txt_DrewPoint";
            this.txt_DrewPoint.Size = new System.Drawing.Size(100, 20);
            this.txt_DrewPoint.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperatur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Relative Luftfeuchtigkeit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Taupunkt";
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(169, 134);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(100, 23);
            this.btn_Calc.TabIndex = 6;
            this.btn_Calc.Text = "Berechnen";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // txt_HumidityAbs
            // 
            this.txt_HumidityAbs.Location = new System.Drawing.Point(169, 218);
            this.txt_HumidityAbs.Name = "txt_HumidityAbs";
            this.txt_HumidityAbs.Size = new System.Drawing.Size(100, 20);
            this.txt_HumidityAbs.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Abs. Luftfeuchte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_HumidityRel);
            this.groupBox1.Controls.Add(this.rb_HumidityAbs);
            this.groupBox1.Controls.Add(this.txt_HumidityAbs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Temperature);
            this.groupBox1.Controls.Add(this.txt_HumidityRel);
            this.groupBox1.Controls.Add(this.btn_Calc);
            this.groupBox1.Controls.Add(this.txt_DrewPoint);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 264);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rb_HumidityAbs
            // 
            this.rb_HumidityAbs.AutoSize = true;
            this.rb_HumidityAbs.Checked = true;
            this.rb_HumidityAbs.Location = new System.Drawing.Point(285, 219);
            this.rb_HumidityAbs.Name = "rb_HumidityAbs";
            this.rb_HumidityAbs.Size = new System.Drawing.Size(85, 17);
            this.rb_HumidityAbs.TabIndex = 9;
            this.rb_HumidityAbs.TabStop = true;
            this.rb_HumidityAbs.Text = "radioButton1";
            this.rb_HumidityAbs.UseVisualStyleBackColor = true;
            // 
            // rb_HumidityRel
            // 
            this.rb_HumidityRel.AutoSize = true;
            this.rb_HumidityRel.Location = new System.Drawing.Point(285, 95);
            this.rb_HumidityRel.Name = "rb_HumidityRel";
            this.rb_HumidityRel.Size = new System.Drawing.Size(85, 17);
            this.rb_HumidityRel.TabIndex = 10;
            this.rb_HumidityRel.Text = "radioButton2";
            this.rb_HumidityRel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 288);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Temperature;
        private System.Windows.Forms.TextBox txt_HumidityRel;
        private System.Windows.Forms.TextBox txt_DrewPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.TextBox txt_HumidityAbs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_HumidityRel;
        private System.Windows.Forms.RadioButton rb_HumidityAbs;
    }
}

