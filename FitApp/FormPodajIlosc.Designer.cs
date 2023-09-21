namespace FitApp
{
    partial class FormPodajIlosc
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.lblKcal = new System.Windows.Forms.Label();
            this.lblMakro = new System.Windows.Forms.Label();
            this.panelParametrow = new System.Windows.Forms.Panel();
            this.panelParametrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodaj.Location = new System.Drawing.Point(84, 121);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(104, 28);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Добавить";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите количество:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(35, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TxtBoxPodajIlosc_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PodajLiczbeTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(116, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "g";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwa.Location = new System.Drawing.Point(80, 30);
            this.lblNazwa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(130, 20);
            this.lblNazwa.TabIndex = 4;
            this.lblNazwa.Text = "Название еды";
            // 
            // lblKcal
            // 
            this.lblKcal.AutoSize = true;
            this.lblKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKcal.Location = new System.Drawing.Point(2, 3);
            this.lblKcal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKcal.Name = "lblKcal";
            this.lblKcal.Size = new System.Drawing.Size(70, 15);
            this.lblKcal.TabIndex = 5;
            this.lblKcal.Text = "Ккал: 0kcal";
            this.lblKcal.Click += new System.EventHandler(this.lblKcal_Click);
            // 
            // lblMakro
            // 
            this.lblMakro.AutoSize = true;
            this.lblMakro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMakro.Location = new System.Drawing.Point(2, 18);
            this.lblMakro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMakro.Name = "lblMakro";
            this.lblMakro.Size = new System.Drawing.Size(106, 15);
            this.lblMakro.TabIndex = 6;
            this.lblMakro.Text = "Б: 0g, У: 0g, Ж: 0g";
            // 
            // panelParametrow
            // 
            this.panelParametrow.Controls.Add(this.lblMakro);
            this.panelParametrow.Controls.Add(this.lblKcal);
            this.panelParametrow.Location = new System.Drawing.Point(177, 64);
            this.panelParametrow.Margin = new System.Windows.Forms.Padding(2);
            this.panelParametrow.Name = "panelParametrow";
            this.panelParametrow.Size = new System.Drawing.Size(154, 55);
            this.panelParametrow.TabIndex = 7;
            // 
            // FormPodajIlosc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(331, 191);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.panelParametrow);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPodajIlosc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введение количества еды";
            this.Load += new System.EventHandler(this.FormPodajIlosc_Load);
            this.panelParametrow.ResumeLayout(false);
            this.panelParametrow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Label lblKcal;
        private System.Windows.Forms.Label lblMakro;
        private System.Windows.Forms.Panel panelParametrow;
    }
}