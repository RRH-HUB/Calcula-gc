namespace Calculadora_de_grasa
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
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.buttonCalcula = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.radioButtonHombre = new System.Windows.Forms.RadioButton();
            this.radioButtonMujer = new System.Windows.Forms.RadioButton();
            this.groupBoxMetodos = new System.Windows.Forms.GroupBox();
            this.radioButtonDeurenberg = new System.Windows.Forms.RadioButton();
            this.groupBoxSexo.SuspendLayout();
            this.groupBoxMetodos.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(32, 73);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(100, 20);
            this.textBoxPeso.TabIndex = 0;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(144, 80);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(32, 98);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltura.TabIndex = 2;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(141, 105);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // buttonCalcula
            // 
            this.buttonCalcula.Location = new System.Drawing.Point(129, 203);
            this.buttonCalcula.Name = "buttonCalcula";
            this.buttonCalcula.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcula.TabIndex = 4;
            this.buttonCalcula.Text = "Calcula";
            this.buttonCalcula.UseVisualStyleBackColor = true;
            this.buttonCalcula.Click += new System.EventHandler(this.buttonCalcula_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(244, 230);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 13);
            this.labelResultado.TabIndex = 5;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(141, 131);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(32, 13);
            this.labelEdad.TabIndex = 6;
            this.labelEdad.Text = "Edad";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(32, 124);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdad.TabIndex = 7;
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.radioButtonMujer);
            this.groupBoxSexo.Controls.Add(this.radioButtonHombre);
            this.groupBoxSexo.Location = new System.Drawing.Point(32, 150);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(100, 76);
            this.groupBoxSexo.TabIndex = 8;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // radioButtonHombre
            // 
            this.radioButtonHombre.AutoSize = true;
            this.radioButtonHombre.Checked = true;
            this.radioButtonHombre.Location = new System.Drawing.Point(6, 42);
            this.radioButtonHombre.Name = "radioButtonHombre";
            this.radioButtonHombre.Size = new System.Drawing.Size(62, 17);
            this.radioButtonHombre.TabIndex = 0;
            this.radioButtonHombre.TabStop = true;
            this.radioButtonHombre.Text = "Hombre";
            this.radioButtonHombre.UseVisualStyleBackColor = true;
            // 
            // radioButtonMujer
            // 
            this.radioButtonMujer.AutoSize = true;
            this.radioButtonMujer.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMujer.Name = "radioButtonMujer";
            this.radioButtonMujer.Size = new System.Drawing.Size(51, 17);
            this.radioButtonMujer.TabIndex = 1;
            this.radioButtonMujer.Text = "Mujer";
            this.radioButtonMujer.UseVisualStyleBackColor = true;
            // 
            // groupBoxMetodos
            // 
            this.groupBoxMetodos.Controls.Add(this.radioButtonDeurenberg);
            this.groupBoxMetodos.Location = new System.Drawing.Point(12, 13);
            this.groupBoxMetodos.Name = "groupBoxMetodos";
            this.groupBoxMetodos.Size = new System.Drawing.Size(302, 54);
            this.groupBoxMetodos.TabIndex = 9;
            this.groupBoxMetodos.TabStop = false;
            this.groupBoxMetodos.Text = "Metodos";
            // 
            // radioButtonDeurenberg
            // 
            this.radioButtonDeurenberg.AutoSize = true;
            this.radioButtonDeurenberg.Checked = true;
            this.radioButtonDeurenberg.Location = new System.Drawing.Point(7, 20);
            this.radioButtonDeurenberg.Name = "radioButtonDeurenberg";
            this.radioButtonDeurenberg.Size = new System.Drawing.Size(81, 17);
            this.radioButtonDeurenberg.TabIndex = 0;
            this.radioButtonDeurenberg.TabStop = true;
            this.radioButtonDeurenberg.Text = "Deurenberg";
            this.radioButtonDeurenberg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 268);
            this.Controls.Add(this.groupBoxMetodos);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonCalcula);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.textBoxPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.groupBoxMetodos.ResumeLayout(false);
            this.groupBoxMetodos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button buttonCalcula;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton radioButtonMujer;
        private System.Windows.Forms.RadioButton radioButtonHombre;
        private System.Windows.Forms.GroupBox groupBoxMetodos;
        private System.Windows.Forms.RadioButton radioButtonDeurenberg;
    }
}

