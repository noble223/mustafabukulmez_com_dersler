﻿namespace mustafabukulmez_com_dersler._034_Exceptions
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
            this.btn_ArgumentException = new System.Windows.Forms.Button();
            this.btn_ArgumentNullException = new System.Windows.Forms.Button();
            this.txt_cikti = new System.Windows.Forms.TextBox();
            this.btn_ArguOutOfRangeExce = new System.Windows.Forms.Button();
            this.btn_IndexOutOfRangeException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ArgumentException
            // 
            this.btn_ArgumentException.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ArgumentException.Location = new System.Drawing.Point(12, 12);
            this.btn_ArgumentException.Name = "btn_ArgumentException";
            this.btn_ArgumentException.Size = new System.Drawing.Size(225, 41);
            this.btn_ArgumentException.TabIndex = 0;
            this.btn_ArgumentException.Text = "ArgumentException";
            this.btn_ArgumentException.UseVisualStyleBackColor = true;
            this.btn_ArgumentException.Click += new System.EventHandler(this.btn_ArgumentException_Click);
            // 
            // btn_ArgumentNullException
            // 
            this.btn_ArgumentNullException.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ArgumentNullException.Location = new System.Drawing.Point(12, 59);
            this.btn_ArgumentNullException.Name = "btn_ArgumentNullException";
            this.btn_ArgumentNullException.Size = new System.Drawing.Size(225, 41);
            this.btn_ArgumentNullException.TabIndex = 1;
            this.btn_ArgumentNullException.Text = "ArgumentNullException";
            this.btn_ArgumentNullException.UseVisualStyleBackColor = true;
            this.btn_ArgumentNullException.Click += new System.EventHandler(this.btn_ArgumentNullException_Click);
            // 
            // txt_cikti
            // 
            this.txt_cikti.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_cikti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_cikti.Location = new System.Drawing.Point(427, 0);
            this.txt_cikti.Multiline = true;
            this.txt_cikti.Name = "txt_cikti";
            this.txt_cikti.Size = new System.Drawing.Size(718, 450);
            this.txt_cikti.TabIndex = 2;
            // 
            // btn_ArguOutOfRangeExce
            // 
            this.btn_ArguOutOfRangeExce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ArguOutOfRangeExce.Location = new System.Drawing.Point(12, 105);
            this.btn_ArguOutOfRangeExce.Name = "btn_ArguOutOfRangeExce";
            this.btn_ArguOutOfRangeExce.Size = new System.Drawing.Size(225, 41);
            this.btn_ArguOutOfRangeExce.TabIndex = 3;
            this.btn_ArguOutOfRangeExce.Text = "ArgumentOutOfRangeException ";
            this.btn_ArguOutOfRangeExce.UseVisualStyleBackColor = true;
            this.btn_ArguOutOfRangeExce.Click += new System.EventHandler(this.btn_ArguOutOfRangeExce_Click);
            // 
            // btn_IndexOutOfRangeException
            // 
            this.btn_IndexOutOfRangeException.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_IndexOutOfRangeException.Location = new System.Drawing.Point(12, 314);
            this.btn_IndexOutOfRangeException.Name = "btn_IndexOutOfRangeException";
            this.btn_IndexOutOfRangeException.Size = new System.Drawing.Size(225, 41);
            this.btn_IndexOutOfRangeException.TabIndex = 4;
            this.btn_IndexOutOfRangeException.Text = "IndexOutOfRangeException";
            this.btn_IndexOutOfRangeException.UseVisualStyleBackColor = true;
            this.btn_IndexOutOfRangeException.Visible = false;
            this.btn_IndexOutOfRangeException.Click += new System.EventHandler(this.btn_IndexOutOfRangeException_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 450);
            this.Controls.Add(this.btn_IndexOutOfRangeException);
            this.Controls.Add(this.btn_ArguOutOfRangeExce);
            this.Controls.Add(this.txt_cikti);
            this.Controls.Add(this.btn_ArgumentNullException);
            this.Controls.Add(this.btn_ArgumentException);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ArgumentException;
        private System.Windows.Forms.Button btn_ArgumentNullException;
        private System.Windows.Forms.TextBox txt_cikti;
        private System.Windows.Forms.Button btn_ArguOutOfRangeExce;
        private System.Windows.Forms.Button btn_IndexOutOfRangeException;
    }
}