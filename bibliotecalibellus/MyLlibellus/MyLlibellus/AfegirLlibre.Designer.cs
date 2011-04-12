namespace MyLlibellus
{
    partial class AfegirLlibre
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gboxNovaLlib = new System.Windows.Forms.GroupBox();
            this.txtBoxResum = new System.Windows.Forms.TextBox();
            this.txtBoxPremis = new System.Windows.Forms.TextBox();
            this.txtBoxPVP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxAutor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTitolLlarg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTitolCurt = new System.Windows.Forms.TextBox();
            this.txtBoxISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxNovaLlib.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(186, 177);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 29);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(280, 177);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancel·lar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gboxNovaLlib
            // 
            this.gboxNovaLlib.Controls.Add(this.txtBoxResum);
            this.gboxNovaLlib.Controls.Add(this.txtBoxPremis);
            this.gboxNovaLlib.Controls.Add(this.txtBoxPVP);
            this.gboxNovaLlib.Controls.Add(this.label7);
            this.gboxNovaLlib.Controls.Add(this.label6);
            this.gboxNovaLlib.Controls.Add(this.label5);
            this.gboxNovaLlib.Controls.Add(this.cmbBoxAutor);
            this.gboxNovaLlib.Controls.Add(this.label4);
            this.gboxNovaLlib.Controls.Add(this.txtBoxTitolLlarg);
            this.gboxNovaLlib.Controls.Add(this.label3);
            this.gboxNovaLlib.Controls.Add(this.txtBoxTitolCurt);
            this.gboxNovaLlib.Controls.Add(this.txtBoxISBN);
            this.gboxNovaLlib.Controls.Add(this.label2);
            this.gboxNovaLlib.Controls.Add(this.label1);
            this.gboxNovaLlib.Location = new System.Drawing.Point(15, 9);
            this.gboxNovaLlib.Name = "gboxNovaLlib";
            this.gboxNovaLlib.Size = new System.Drawing.Size(541, 163);
            this.gboxNovaLlib.TabIndex = 4;
            this.gboxNovaLlib.TabStop = false;
            this.gboxNovaLlib.Text = "Nou Llibre";
            // 
            // txtBoxResum
            // 
            this.txtBoxResum.Location = new System.Drawing.Point(357, 29);
            this.txtBoxResum.Multiline = true;
            this.txtBoxResum.Name = "txtBoxResum";
            this.txtBoxResum.Size = new System.Drawing.Size(178, 43);
            this.txtBoxResum.TabIndex = 13;
            // 
            // txtBoxPremis
            // 
            this.txtBoxPremis.Location = new System.Drawing.Point(357, 85);
            this.txtBoxPremis.Name = "txtBoxPremis";
            this.txtBoxPremis.Size = new System.Drawing.Size(178, 20);
            this.txtBoxPremis.TabIndex = 12;
            // 
            // txtBoxPVP
            // 
            this.txtBoxPVP.Location = new System.Drawing.Point(357, 115);
            this.txtBoxPVP.Name = "txtBoxPVP";
            this.txtBoxPVP.Size = new System.Drawing.Size(178, 20);
            this.txtBoxPVP.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "PVP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Premis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resum:";
            // 
            // cmbBoxAutor
            // 
            this.cmbBoxAutor.DisplayMember = "nom";
            this.cmbBoxAutor.FormattingEnabled = true;
            this.cmbBoxAutor.Location = new System.Drawing.Point(103, 115);
            this.cmbBoxAutor.Name = "cmbBoxAutor";
            this.cmbBoxAutor.Size = new System.Drawing.Size(156, 21);
            this.cmbBoxAutor.TabIndex = 7;
            this.cmbBoxAutor.ValueMember = "id_autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Publicador:";
            // 
            // txtBoxTitolLlarg
            // 
            this.txtBoxTitolLlarg.Location = new System.Drawing.Point(103, 85);
            this.txtBoxTitolLlarg.Name = "txtBoxTitolLlarg";
            this.txtBoxTitolLlarg.Size = new System.Drawing.Size(156, 20);
            this.txtBoxTitolLlarg.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Títol llarg:";
            // 
            // txtBoxTitolCurt
            // 
            this.txtBoxTitolCurt.Location = new System.Drawing.Point(103, 56);
            this.txtBoxTitolCurt.Name = "txtBoxTitolCurt";
            this.txtBoxTitolCurt.Size = new System.Drawing.Size(156, 20);
            this.txtBoxTitolCurt.TabIndex = 3;
            // 
            // txtBoxISBN
            // 
            this.txtBoxISBN.Location = new System.Drawing.Point(103, 30);
            this.txtBoxISBN.Name = "txtBoxISBN";
            this.txtBoxISBN.Size = new System.Drawing.Size(156, 20);
            this.txtBoxISBN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Títol curt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN:";
            // 
            // AfegirLlibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 213);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gboxNovaLlib);
            this.Name = "AfegirLlibre";
            this.Text = "AfegirLlibre";
            this.gboxNovaLlib.ResumeLayout(false);
            this.gboxNovaLlib.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gboxNovaLlib;
        private System.Windows.Forms.TextBox txtBoxResum;
        private System.Windows.Forms.TextBox txtBoxPremis;
        private System.Windows.Forms.TextBox txtBoxPVP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTitolLlarg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTitolCurt;
        private System.Windows.Forms.TextBox txtBoxISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}