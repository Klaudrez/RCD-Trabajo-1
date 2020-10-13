namespace Cliente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonRut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextoRut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ApText = new System.Windows.Forms.TextBox();
            this.Amtext = new System.Windows.Forms.TextBox();
            this.NmsText = new System.Windows.Forms.TextBox();
            this.MensajeText = new System.Windows.Forms.Button();
            this.BotonF = new System.Windows.Forms.RadioButton();
            this.BotonM = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BotonRut
            // 
            this.BotonRut.Location = new System.Drawing.Point(271, 59);
            this.BotonRut.Name = "BotonRut";
            this.BotonRut.Size = new System.Drawing.Size(75, 23);
            this.BotonRut.TabIndex = 0;
            this.BotonRut.Text = "Ingresar";
            this.BotonRut.UseVisualStyleBackColor = true;
            this.BotonRut.Click += new System.EventHandler(this.BotonRut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rut";
            // 
            // TextoRut
            // 
            this.TextoRut.Location = new System.Drawing.Point(43, 28);
            this.TextoRut.Name = "TextoRut";
            this.TextoRut.Size = new System.Drawing.Size(100, 20);
            this.TextoRut.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Formato: 12345678-9";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellido Materno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombres";
            // 
            // ApText
            // 
            this.ApText.Location = new System.Drawing.Point(110, 101);
            this.ApText.Name = "ApText";
            this.ApText.Size = new System.Drawing.Size(100, 20);
            this.ApText.TabIndex = 7;
            // 
            // Amtext
            // 
            this.Amtext.Location = new System.Drawing.Point(110, 137);
            this.Amtext.Name = "Amtext";
            this.Amtext.Size = new System.Drawing.Size(100, 20);
            this.Amtext.TabIndex = 8;
            // 
            // NmsText
            // 
            this.NmsText.Location = new System.Drawing.Point(110, 168);
            this.NmsText.Name = "NmsText";
            this.NmsText.Size = new System.Drawing.Size(100, 20);
            this.NmsText.TabIndex = 9;
            // 
            // MensajeText
            // 
            this.MensajeText.Location = new System.Drawing.Point(271, 205);
            this.MensajeText.Name = "MensajeText";
            this.MensajeText.Size = new System.Drawing.Size(75, 23);
            this.MensajeText.TabIndex = 10;
            this.MensajeText.Text = "Ingresar";
            this.MensajeText.UseVisualStyleBackColor = true;
            this.MensajeText.Click += new System.EventHandler(this.MensajeText_Click);
            // 
            // BotonF
            // 
            this.BotonF.AutoSize = true;
            this.BotonF.Location = new System.Drawing.Point(16, 214);
            this.BotonF.Name = "BotonF";
            this.BotonF.Size = new System.Drawing.Size(71, 17);
            this.BotonF.TabIndex = 11;
            this.BotonF.TabStop = true;
            this.BotonF.Text = "Femenino";
            this.BotonF.UseVisualStyleBackColor = true;
            // 
            // BotonM
            // 
            this.BotonM.AutoSize = true;
            this.BotonM.Location = new System.Drawing.Point(107, 214);
            this.BotonM.Name = "BotonM";
            this.BotonM.Size = new System.Drawing.Size(73, 17);
            this.BotonM.TabIndex = 12;
            this.BotonM.TabStop = true;
            this.BotonM.Text = "Masculino";
            this.BotonM.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 243);
            this.Controls.Add(this.BotonM);
            this.Controls.Add(this.BotonF);
            this.Controls.Add(this.MensajeText);
            this.Controls.Add(this.NmsText);
            this.Controls.Add(this.Amtext);
            this.Controls.Add(this.ApText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextoRut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonRut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonRut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextoRut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ApText;
        private System.Windows.Forms.TextBox Amtext;
        private System.Windows.Forms.TextBox NmsText;
        private System.Windows.Forms.Button MensajeText;
        private System.Windows.Forms.RadioButton BotonF;
        private System.Windows.Forms.RadioButton BotonM;
    }
}

