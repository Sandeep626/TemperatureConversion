﻿
namespace TemperatureConversion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fahrenheit = new System.Windows.Forms.TextBox();
            this.txt_celsius = new System.Windows.Forms.TextBox();
            this.txt_kelvin = new System.Windows.Forms.TextBox();
            this.btn_fahrenheit = new System.Windows.Forms.Button();
            this.btn_celsius = new System.Windows.Forms.Button();
            this.btn_kevin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(43, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(53, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // txt_fahrenheit
            // 
            this.txt_fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fahrenheit.Location = new System.Drawing.Point(180, 72);
            this.txt_fahrenheit.Name = "txt_fahrenheit";
            this.txt_fahrenheit.Size = new System.Drawing.Size(156, 29);
            this.txt_fahrenheit.TabIndex = 3;
            // 
            // txt_celsius
            // 
            this.txt_celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celsius.Location = new System.Drawing.Point(180, 153);
            this.txt_celsius.Name = "txt_celsius";
            this.txt_celsius.Size = new System.Drawing.Size(156, 29);
            this.txt_celsius.TabIndex = 4;
            // 
            // txt_kelvin
            // 
            this.txt_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kelvin.Location = new System.Drawing.Point(180, 234);
            this.txt_kelvin.Name = "txt_kelvin";
            this.txt_kelvin.Size = new System.Drawing.Size(156, 29);
            this.txt_kelvin.TabIndex = 5;
            // 
            // btn_fahrenheit
            // 
            this.btn_fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fahrenheit.Location = new System.Drawing.Point(416, 72);
            this.btn_fahrenheit.Name = "btn_fahrenheit";
            this.btn_fahrenheit.Size = new System.Drawing.Size(94, 28);
            this.btn_fahrenheit.TabIndex = 6;
            this.btn_fahrenheit.Text = "Convert";
            this.btn_fahrenheit.UseVisualStyleBackColor = true;
            this.btn_fahrenheit.Click += new System.EventHandler(this.btn_fahrenheit_Click);
            // 
            // btn_celsius
            // 
            this.btn_celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_celsius.Location = new System.Drawing.Point(416, 153);
            this.btn_celsius.Name = "btn_celsius";
            this.btn_celsius.Size = new System.Drawing.Size(94, 28);
            this.btn_celsius.TabIndex = 7;
            this.btn_celsius.Text = "Convert";
            this.btn_celsius.UseVisualStyleBackColor = true;
            this.btn_celsius.Click += new System.EventHandler(this.btn_celsius_Click);
            // 
            // btn_kevin
            // 
            this.btn_kevin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kevin.Location = new System.Drawing.Point(416, 234);
            this.btn_kevin.Name = "btn_kevin";
            this.btn_kevin.Size = new System.Drawing.Size(94, 28);
            this.btn_kevin.TabIndex = 8;
            this.btn_kevin.Text = "Convert";
            this.btn_kevin.UseVisualStyleBackColor = true;
            this.btn_kevin.Click += new System.EventHandler(this.btn_kevin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kevin);
            this.Controls.Add(this.btn_celsius);
            this.Controls.Add(this.btn_fahrenheit);
            this.Controls.Add(this.txt_kelvin);
            this.Controls.Add(this.txt_celsius);
            this.Controls.Add(this.txt_fahrenheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fahrenheit;
        private System.Windows.Forms.TextBox txt_celsius;
        private System.Windows.Forms.TextBox txt_kelvin;
        private System.Windows.Forms.Button btn_fahrenheit;
        private System.Windows.Forms.Button btn_celsius;
        private System.Windows.Forms.Button btn_kevin;
    }
}

