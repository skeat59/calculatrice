﻿namespace calculatrice
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button_mod = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_egal = new System.Windows.Forms.Button();
            this.button_pow = new System.Windows.Forms.Button();
            this.button_fact = new System.Windows.Forms.Button();
            this.button_fibo = new System.Windows.Forms.Button();
            this.button_sqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 13);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(330, 20);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Click += new System.EventHandler(this.operand_updated);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Click += new System.EventHandler(this.operand_updated);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.Click += new System.EventHandler(this.operand_updated);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.Click += new System.EventHandler(this.operand_updated);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(69, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.Click += new System.EventHandler(this.operand_updated);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(125, 116);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 4;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.Click += new System.EventHandler(this.operand_updated);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 60);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.Click += new System.EventHandler(this.operand_updated);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(68, 60);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.Click += new System.EventHandler(this.operand_updated);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(125, 60);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            this.button9.Click += new System.EventHandler(this.operand_updated);
            // 
            // button_mod
            // 
            this.button_mod.Location = new System.Drawing.Point(181, 60);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(50, 50);
            this.button_mod.TabIndex = 10;
            this.button_mod.Text = "mod";
            this.button_mod.UseVisualStyleBackColor = true;
            this.button_mod.Click += new System.EventHandler(this.button_mod_Click);
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(181, 116);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(50, 50);
            this.button_div.TabIndex = 11;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_mul
            // 
            this.button_mul.Location = new System.Drawing.Point(181, 172);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(50, 50);
            this.button_mul.TabIndex = 12;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = true;
            this.button_mul.Click += new System.EventHandler(this.button_mul_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(181, 228);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(50, 50);
            this.button_minus.TabIndex = 13;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_moins_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(13, 228);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(49, 50);
            this.button0.TabIndex = 14;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            this.button0.Click += new System.EventHandler(this.operand_updated);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(125, 228);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(50, 50);
            this.button_plus.TabIndex = 15;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_egal
            // 
            this.button_egal.Location = new System.Drawing.Point(70, 228);
            this.button_egal.Name = "button_egal";
            this.button_egal.Size = new System.Drawing.Size(49, 50);
            this.button_egal.TabIndex = 16;
            this.button_egal.Text = "=";
            this.button_egal.UseVisualStyleBackColor = true;
            this.button_egal.Click += new System.EventHandler(this.button_egal_Click);
            // 
            // button_pow
            // 
            this.button_pow.Location = new System.Drawing.Point(237, 60);
            this.button_pow.Name = "button_pow";
            this.button_pow.Size = new System.Drawing.Size(50, 50);
            this.button_pow.TabIndex = 17;
            this.button_pow.Text = "x^y";
            this.button_pow.UseVisualStyleBackColor = true;
            this.button_pow.Click += new System.EventHandler(this.button_pow_Click);
            // 
            // button_fact
            // 
            this.button_fact.Location = new System.Drawing.Point(237, 228);
            this.button_fact.Name = "button_fact";
            this.button_fact.Size = new System.Drawing.Size(50, 50);
            this.button_fact.TabIndex = 18;
            this.button_fact.Text = "!";
            this.button_fact.UseVisualStyleBackColor = true;
            this.button_fact.Click += new System.EventHandler(this.button_fact_Click);
            // 
            // button_fibo
            // 
            this.button_fibo.Location = new System.Drawing.Point(237, 172);
            this.button_fibo.Name = "button_fibo";
            this.button_fibo.Size = new System.Drawing.Size(50, 50);
            this.button_fibo.TabIndex = 19;
            this.button_fibo.Text = "fibo";
            this.button_fibo.UseVisualStyleBackColor = true;
            this.button_fibo.Click += new System.EventHandler(this.button_fibo_Click);
            // 
            // button_sqrt
            // 
            this.button_sqrt.Location = new System.Drawing.Point(237, 116);
            this.button_sqrt.Name = "button_sqrt";
            this.button_sqrt.Size = new System.Drawing.Size(50, 50);
            this.button_sqrt.TabIndex = 20;
            this.button_sqrt.Text = "sqrt";
            this.button_sqrt.UseVisualStyleBackColor = true;
            this.button_sqrt.Click += new System.EventHandler(this.button_sqrt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 324);
            this.Controls.Add(this.button_sqrt);
            this.Controls.Add(this.button_fibo);
            this.Controls.Add(this.button_fact);
            this.Controls.Add(this.button_pow);
            this.Controls.Add(this.button_egal);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_mod);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button_mod;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_egal;
        private System.Windows.Forms.Button button_pow;
        private System.Windows.Forms.Button button_fact;
        private System.Windows.Forms.Button button_fibo;
        private System.Windows.Forms.Button button_sqrt;
    }
}

