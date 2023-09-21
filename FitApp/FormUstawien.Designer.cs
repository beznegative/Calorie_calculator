namespace FitApp
{
    partial class FormUstawien
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
            this.rbtnKobieta = new System.Windows.Forms.RadioButton();
            this.rbtnMezczyzna = new System.Windows.Forms.RadioButton();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWzrost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnSchudnie = new System.Windows.Forms.RadioButton();
            this.rbtnUtrzymanie = new System.Windows.Forms.RadioButton();
            this.rbtnPrzytyj = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTempo = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(112, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пол:";
            // 
            // rbtnKobieta
            // 
            this.rbtnKobieta.AutoSize = true;
            this.rbtnKobieta.Checked = true;
            this.rbtnKobieta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnKobieta.Location = new System.Drawing.Point(118, 38);
            this.rbtnKobieta.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnKobieta.Name = "rbtnKobieta";
            this.rbtnKobieta.Size = new System.Drawing.Size(90, 21);
            this.rbtnKobieta.TabIndex = 6;
            this.rbtnKobieta.TabStop = true;
            this.rbtnKobieta.Text = "Женщина";
            this.rbtnKobieta.UseVisualStyleBackColor = true;
            // 
            // rbtnMezczyzna
            // 
            this.rbtnMezczyzna.AutoSize = true;
            this.rbtnMezczyzna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnMezczyzna.Location = new System.Drawing.Point(118, 63);
            this.rbtnMezczyzna.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMezczyzna.Name = "rbtnMezczyzna";
            this.rbtnMezczyzna.Size = new System.Drawing.Size(85, 21);
            this.rbtnMezczyzna.TabIndex = 5;
            this.rbtnMezczyzna.Text = "Мужчина";
            this.rbtnMezczyzna.UseVisualStyleBackColor = true;
            // 
            // txtWaga
            // 
            this.txtWaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWaga.Location = new System.Drawing.Point(116, 164);
            this.txtWaga.Margin = new System.Windows.Forms.Padding(2);
            this.txtWaga.MaxLength = 5;
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(128, 23);
            this.txtWaga.TabIndex = 8;
            this.txtWaga.TextChanged += new System.EventHandler(this.TxtWaga_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(114, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вес:";
            // 
            // txtWzrost
            // 
            this.txtWzrost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWzrost.Location = new System.Drawing.Point(116, 215);
            this.txtWzrost.Margin = new System.Windows.Forms.Padding(2);
            this.txtWzrost.MaxLength = 3;
            this.txtWzrost.Name = "txtWzrost";
            this.txtWzrost.Size = new System.Drawing.Size(129, 23);
            this.txtWzrost.TabIndex = 10;
            this.txtWzrost.TextChanged += new System.EventHandler(this.TxtWzrost_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(113, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Рост:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(246, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "кг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(245, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "см";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(118, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Сохранить настройки";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = " dd.MM.yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 115);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 23);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(113, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Дата рождения:";
            // 
            // rbtnSchudnie
            // 
            this.rbtnSchudnie.AutoSize = true;
            this.rbtnSchudnie.Checked = true;
            this.rbtnSchudnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnSchudnie.Location = new System.Drawing.Point(3, 5);
            this.rbtnSchudnie.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnSchudnie.Name = "rbtnSchudnie";
            this.rbtnSchudnie.Size = new System.Drawing.Size(132, 21);
            this.rbtnSchudnie.TabIndex = 17;
            this.rbtnSchudnie.TabStop = true;
            this.rbtnSchudnie.Text = "Я хочу похудеть";
            this.rbtnSchudnie.UseVisualStyleBackColor = true;
            // 
            // rbtnUtrzymanie
            // 
            this.rbtnUtrzymanie.AutoSize = true;
            this.rbtnUtrzymanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnUtrzymanie.Location = new System.Drawing.Point(3, 30);
            this.rbtnUtrzymanie.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnUtrzymanie.Name = "rbtnUtrzymanie";
            this.rbtnUtrzymanie.Size = new System.Drawing.Size(200, 21);
            this.rbtnUtrzymanie.TabIndex = 18;
            this.rbtnUtrzymanie.Text = "Я хочу сохранить свой вес";
            this.rbtnUtrzymanie.UseVisualStyleBackColor = true;
            this.rbtnUtrzymanie.CheckedChanged += new System.EventHandler(this.RbtnUtrzymanie_CheckedChanged);
            // 
            // rbtnPrzytyj
            // 
            this.rbtnPrzytyj.AutoSize = true;
            this.rbtnPrzytyj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnPrzytyj.Location = new System.Drawing.Point(3, 54);
            this.rbtnPrzytyj.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnPrzytyj.Name = "rbtnPrzytyj";
            this.rbtnPrzytyj.Size = new System.Drawing.Size(153, 21);
            this.rbtnPrzytyj.TabIndex = 19;
            this.rbtnPrzytyj.Text = "Я хочу набрать вес";
            this.rbtnPrzytyj.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnUtrzymanie);
            this.panel1.Controls.Add(this.rbtnPrzytyj);
            this.panel1.Controls.Add(this.rbtnSchudnie);
            this.panel1.Location = new System.Drawing.Point(88, 265);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 81);
            this.panel1.TabIndex = 20;
            // 
            // txtTempo
            // 
            this.txtTempo.DecimalPlaces = 1;
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTempo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtTempo.Location = new System.Drawing.Point(118, 386);
            this.txtTempo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempo.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(125, 23);
            this.txtTempo.TabIndex = 21;
            this.txtTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTempo.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(71, 367);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Скорость изменения веса в неделю:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(245, 388);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "кг";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(110, 246);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Цель изменения веса:";
            // 
            // FormUstawien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(371, 492);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWzrost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWaga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnKobieta);
            this.Controls.Add(this.rbtnMezczyzna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUstawien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormUstawien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnKobieta;
        private System.Windows.Forms.RadioButton rbtnMezczyzna;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWzrost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnSchudnie;
        private System.Windows.Forms.RadioButton rbtnUtrzymanie;
        private System.Windows.Forms.RadioButton rbtnPrzytyj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txtTempo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}