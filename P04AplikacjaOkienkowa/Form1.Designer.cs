
namespace P04AplikacjaOkienkowa
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
            this.dgvDane = new System.Windows.Forms.DataGridView();
            this.txtPolecenieSQL = new System.Windows.Forms.TextBox();
            this.btnWyslij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDane
            // 
            this.dgvDane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDane.Location = new System.Drawing.Point(12, 42);
            this.dgvDane.Name = "dgvDane";
            this.dgvDane.Size = new System.Drawing.Size(776, 396);
            this.dgvDane.TabIndex = 0;
            // 
            // txtPolecenieSQL
            // 
            this.txtPolecenieSQL.Location = new System.Drawing.Point(12, 13);
            this.txtPolecenieSQL.Name = "txtPolecenieSQL";
            this.txtPolecenieSQL.Size = new System.Drawing.Size(695, 20);
            this.txtPolecenieSQL.TabIndex = 1;
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(713, 10);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(75, 23);
            this.btnWyslij.TabIndex = 2;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.txtPolecenieSQL);
            this.Controls.Add(this.dgvDane);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDane;
        private System.Windows.Forms.TextBox txtPolecenieSQL;
        private System.Windows.Forms.Button btnWyslij;
    }
}

