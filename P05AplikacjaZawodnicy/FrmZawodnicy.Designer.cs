
namespace P05AplikacjaZawodnicy
{
    partial class FrmZawodnicy
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWzrost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataUr = new System.Windows.Forms.DateTimePicker();
            this.btnTrener = new System.Windows.Forms.Button();
            this.btnTrenerzy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 12);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(318, 251);
            this.lbDane.TabIndex = 0;
            this.lbDane.SelectedIndexChanged += new System.EventHandler(this.lbDane_SelectedIndexChanged);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(337, 12);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(68, 58);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(337, 76);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(68, 58);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(336, 140);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(68, 58);
            this.btnEdytuj.TabIndex = 3;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(337, 204);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(68, 58);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Imie";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(481, 97);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(140, 20);
            this.txtImie.TabIndex = 6;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(481, 123);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(140, 20);
            this.txtNazwisko.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwisko";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(481, 149);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(140, 20);
            this.txtKraj.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kraj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "DaraUr";
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(481, 201);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(140, 20);
            this.txtWaga.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Waga";
            // 
            // txtWzrost
            // 
            this.txtWzrost.Location = new System.Drawing.Point(481, 233);
            this.txtWzrost.Name = "txtWzrost";
            this.txtWzrost.Size = new System.Drawing.Size(140, 20);
            this.txtWzrost.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Wzrost";
            // 
            // dtpDataUr
            // 
            this.dtpDataUr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataUr.Location = new System.Drawing.Point(481, 174);
            this.dtpDataUr.Name = "dtpDataUr";
            this.dtpDataUr.Size = new System.Drawing.Size(140, 20);
            this.dtpDataUr.TabIndex = 17;
            // 
            // btnTrener
            // 
            this.btnTrener.Location = new System.Drawing.Point(411, 12);
            this.btnTrener.Name = "btnTrener";
            this.btnTrener.Size = new System.Drawing.Size(68, 58);
            this.btnTrener.TabIndex = 18;
            this.btnTrener.Text = "Trener";
            this.btnTrener.UseVisualStyleBackColor = true;
            this.btnTrener.Click += new System.EventHandler(this.btnTrener_Click);
            // 
            // btnTrenerzy
            // 
            this.btnTrenerzy.Location = new System.Drawing.Point(485, 12);
            this.btnTrenerzy.Name = "btnTrenerzy";
            this.btnTrenerzy.Size = new System.Drawing.Size(68, 58);
            this.btnTrenerzy.TabIndex = 19;
            this.btnTrenerzy.Text = "Formularz trenerzy";
            this.btnTrenerzy.UseVisualStyleBackColor = true;
            this.btnTrenerzy.Click += new System.EventHandler(this.btnTrenerzy_Click);
            // 
            // FrmZawodnicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 282);
            this.Controls.Add(this.btnTrenerzy);
            this.Controls.Add(this.btnTrener);
            this.Controls.Add(this.dtpDataUr);
            this.Controls.Add(this.txtWzrost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWaga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmZawodnicy";
            this.Text = "Zawodnicy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWzrost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataUr;
        private System.Windows.Forms.Button btnTrener;
        private System.Windows.Forms.Button btnTrenerzy;
    }
}

