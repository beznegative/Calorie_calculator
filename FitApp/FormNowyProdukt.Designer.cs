﻿namespace FitApp
{
    partial class FormNowyProdukt
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
            this.lblNazwa = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.txtKcal = new System.Windows.Forms.TextBox();
            this.lblKcal = new System.Windows.Forms.Label();
            this.txtBialko = new System.Windows.Forms.TextBox();
            this.lblBialko = new System.Windows.Forms.Label();
            this.lblWegle = new System.Windows.Forms.Label();
            this.txtWegl = new System.Windows.Forms.TextBox();
            this.lblTluszcze = new System.Windows.Forms.Label();
            this.txtTluszcz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwa.Location = new System.Drawing.Point(89, 28);
            this.lblNazwa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(141, 17);
            this.lblNazwa.TabIndex = 0;
            this.lblNazwa.Text = "Название продукта:";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwa.Location = new System.Drawing.Point(93, 50);
            this.txtNazwa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazwa.MaxLength = 15;
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(212, 23);
            this.txtNazwa.TabIndex = 1;
            // 
            // txtKcal
            // 
            this.txtKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKcal.Location = new System.Drawing.Point(92, 110);
            this.txtKcal.Margin = new System.Windows.Forms.Padding(2);
            this.txtKcal.MaxLength = 5;
            this.txtKcal.Name = "txtKcal";
            this.txtKcal.Size = new System.Drawing.Size(80, 23);
            this.txtKcal.TabIndex = 2;
            this.txtKcal.TextChanged += new System.EventHandler(this.TextBoxKcal_TextChanged);
            // 
            // lblKcal
            // 
            this.lblKcal.AutoSize = true;
            this.lblKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKcal.Location = new System.Drawing.Point(87, 89);
            this.lblKcal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKcal.Name = "lblKcal";
            this.lblKcal.Size = new System.Drawing.Size(88, 17);
            this.lblKcal.TabIndex = 3;
            this.lblKcal.Text = "Ккал / 100g:";
            // 
            // txtBialko
            // 
            this.txtBialko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBialko.Location = new System.Drawing.Point(212, 110);
            this.txtBialko.Margin = new System.Windows.Forms.Padding(2);
            this.txtBialko.MaxLength = 5;
            this.txtBialko.Name = "txtBialko";
            this.txtBialko.Size = new System.Drawing.Size(80, 23);
            this.txtBialko.TabIndex = 4;
            this.txtBialko.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblBialko
            // 
            this.lblBialko.AutoSize = true;
            this.lblBialko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBialko.Location = new System.Drawing.Point(208, 89);
            this.lblBialko.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBialko.Name = "lblBialko";
            this.lblBialko.Size = new System.Drawing.Size(96, 17);
            this.lblBialko.TabIndex = 5;
            this.lblBialko.Text = "Белки / 100g:";
            // 
            // lblWegle
            // 
            this.lblWegle.AutoSize = true;
            this.lblWegle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWegle.Location = new System.Drawing.Point(88, 150);
            this.lblWegle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWegle.Name = "lblWegle";
            this.lblWegle.Size = new System.Drawing.Size(119, 17);
            this.lblWegle.TabIndex = 7;
            this.lblWegle.Text = "Углеводы / 100g:";
            // 
            // txtWegl
            // 
            this.txtWegl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWegl.Location = new System.Drawing.Point(92, 171);
            this.txtWegl.Margin = new System.Windows.Forms.Padding(2);
            this.txtWegl.MaxLength = 5;
            this.txtWegl.Name = "txtWegl";
            this.txtWegl.Size = new System.Drawing.Size(80, 23);
            this.txtWegl.TabIndex = 6;
            this.txtWegl.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblTluszcze
            // 
            this.lblTluszcze.AutoSize = true;
            this.lblTluszcze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTluszcze.Location = new System.Drawing.Point(207, 150);
            this.lblTluszcze.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTluszcze.Name = "lblTluszcze";
            this.lblTluszcze.Size = new System.Drawing.Size(95, 17);
            this.lblTluszcze.TabIndex = 9;
            this.lblTluszcze.Text = "Жиры / 100g:";
            // 
            // txtTluszcz
            // 
            this.txtTluszcz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTluszcz.Location = new System.Drawing.Point(212, 171);
            this.txtTluszcz.Margin = new System.Windows.Forms.Padding(2);
            this.txtTluszcz.MaxLength = 5;
            this.txtTluszcz.Name = "txtTluszcz";
            this.txtTluszcz.Size = new System.Drawing.Size(80, 23);
            this.txtTluszcz.TabIndex = 8;
            this.txtTluszcz.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(92, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить новый продукт";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(173, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "kcal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(173, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(293, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "g";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(293, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "g";
            // 
            // FormNowyProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 297);
            this.Controls.Add(this.txtWegl);
            this.Controls.Add(this.txtKcal);
            this.Controls.Add(this.txtBialko);
            this.Controls.Add(this.txtTluszcz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTluszcze);
            this.Controls.Add(this.lblWegle);
            this.Controls.Add(this.lblBialko);
            this.Controls.Add(this.lblKcal);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNowyProdukt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление новой еды";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtKcal;
        private System.Windows.Forms.Label lblKcal;
        private System.Windows.Forms.TextBox txtBialko;
        private System.Windows.Forms.Label lblBialko;
        private System.Windows.Forms.Label lblWegle;
        private System.Windows.Forms.TextBox txtWegl;
        private System.Windows.Forms.Label lblTluszcze;
        private System.Windows.Forms.TextBox txtTluszcz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}