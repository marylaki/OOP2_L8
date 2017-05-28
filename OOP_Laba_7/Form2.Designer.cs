namespace OOP_Laba_7
{
    partial class Form2
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
            this.result = new System.Windows.Forms.DataGridView();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AllowUserToDeleteRows = false;
            this.result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fio,
            this.genger,
            this.bdate,
            this.cours,
            this.sec,
            this.grupp,
            this.note,
            this.number,
            this.adress});
            this.result.Location = new System.Drawing.Point(0, 52);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(702, 209);
            this.result.TabIndex = 36;
            // 
            // fio
            // 
            this.fio.HeaderText = "ФИО";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            this.fio.Width = 59;
            // 
            // genger
            // 
            this.genger.HeaderText = "Пол";
            this.genger.Name = "genger";
            this.genger.ReadOnly = true;
            this.genger.Width = 52;
            // 
            // bdate
            // 
            this.bdate.HeaderText = "Дата рождения";
            this.bdate.Name = "bdate";
            this.bdate.ReadOnly = true;
            this.bdate.Width = 102;
            // 
            // cours
            // 
            this.cours.HeaderText = "Курс";
            this.cours.Name = "cours";
            this.cours.ReadOnly = true;
            this.cours.Width = 56;
            // 
            // sec
            // 
            this.sec.HeaderText = "Специальность";
            this.sec.Name = "sec";
            this.sec.ReadOnly = true;
            this.sec.Width = 110;
            // 
            // grupp
            // 
            this.grupp.HeaderText = "Группа";
            this.grupp.Name = "grupp";
            this.grupp.ReadOnly = true;
            this.grupp.Width = 67;
            // 
            // note
            // 
            this.note.HeaderText = "ср. балл";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Width = 69;
            // 
            // number
            // 
            this.number.HeaderText = "Телефон";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 77;
            // 
            // adress
            // 
            this.adress.HeaderText = "Адресс";
            this.adress.Name = "adress";
            this.adress.ReadOnly = true;
            this.adress.Width = 69;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 20);
            this.button1.TabIndex = 38;
            this.button1.Text = "найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 34);
            this.button2.TabIndex = 40;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 259);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.result);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView result;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn genger;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cours;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}