namespace Mitarbeiter_Bearbeiten
{
    partial class Form2
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.Label();
            this.txtvn = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbm = new System.Windows.Forms.RadioButton();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(70, 39);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(65, 17);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Vorname";
            this.lb1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtvn
            // 
            this.txtvn.Location = new System.Drawing.Point(152, 39);
            this.txtvn.Name = "txtvn";
            this.txtvn.Size = new System.Drawing.Size(110, 22);
            this.txtvn.TabIndex = 1;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(70, 71);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(76, 17);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Nachname";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(152, 71);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(110, 22);
            this.txt2.TabIndex = 3;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(44, 114);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(102, 17);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "Geburtsdatum:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 5;
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Location = new System.Drawing.Point(152, 158);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(40, 21);
            this.rbm.TabIndex = 6;
            this.rbm.TabStop = true;
            this.rbm.Text = "M";
            this.rbm.UseVisualStyleBackColor = true;
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Location = new System.Drawing.Point(224, 158);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(37, 21);
            this.rbf.TabIndex = 7;
            this.rbf.TabStop = true;
            this.rbf.Text = "F";
            this.rbf.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Geschlecht:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(63, 202);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(77, 17);
            this.lb4.TabIndex = 9;
            this.lb4.Text = "Eingestellt:";
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(146, 202);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(115, 22);
            this.tb4.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Änderung speichern";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbf);
            this.Controls.Add(this.rbm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txtvn);
            this.Controls.Add(this.lb1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtvn;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbm;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Button button1;
    }
}

