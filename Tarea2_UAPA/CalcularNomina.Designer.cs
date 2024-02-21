namespace Tarea2_UAPA
{
    partial class CalcularNomina
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
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.labelSFS = new System.Windows.Forms.Label();
            this.labelAFP = new System.Windows.Forms.Label();
            this.labelISR = new System.Windows.Forms.Label();
            this.labelTotalDeducciones = new System.Windows.Forms.Label();
            this.labelSueldoNeto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular deducciones de nomina:";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(156, 132);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(176, 32);
            this.textBoxSalary.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salario:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCalcular.Location = new System.Drawing.Point(372, 132);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 32);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // labelSFS
            // 
            this.labelSFS.AutoSize = true;
            this.labelSFS.Location = new System.Drawing.Point(55, 210);
            this.labelSFS.Name = "labelSFS";
            this.labelSFS.Size = new System.Drawing.Size(55, 24);
            this.labelSFS.TabIndex = 4;
            this.labelSFS.Text = "SFS: ";
            // 
            // labelAFP
            // 
            this.labelAFP.AutoSize = true;
            this.labelAFP.Location = new System.Drawing.Point(55, 260);
            this.labelAFP.Name = "labelAFP";
            this.labelAFP.Size = new System.Drawing.Size(56, 24);
            this.labelAFP.TabIndex = 5;
            this.labelAFP.Text = "AFP: ";
            // 
            // labelISR
            // 
            this.labelISR.AutoSize = true;
            this.labelISR.Location = new System.Drawing.Point(55, 313);
            this.labelISR.Name = "labelISR";
            this.labelISR.Size = new System.Drawing.Size(53, 24);
            this.labelISR.TabIndex = 6;
            this.labelISR.Text = "ISR: ";
            // 
            // labelTotalDeducciones
            // 
            this.labelTotalDeducciones.AutoSize = true;
            this.labelTotalDeducciones.Location = new System.Drawing.Point(55, 369);
            this.labelTotalDeducciones.Name = "labelTotalDeducciones";
            this.labelTotalDeducciones.Size = new System.Drawing.Size(184, 24);
            this.labelTotalDeducciones.TabIndex = 7;
            this.labelTotalDeducciones.Text = "Total deducciones: ";
            // 
            // labelSueldoNeto
            // 
            this.labelSueldoNeto.AutoSize = true;
            this.labelSueldoNeto.Location = new System.Drawing.Point(55, 424);
            this.labelSueldoNeto.Name = "labelSueldoNeto";
            this.labelSueldoNeto.Size = new System.Drawing.Size(129, 24);
            this.labelSueldoNeto.TabIndex = 8;
            this.labelSueldoNeto.Text = "Sueldo neto: ";
            // 
            // CalcularNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 509);
            this.Controls.Add(this.labelSueldoNeto);
            this.Controls.Add(this.labelTotalDeducciones);
            this.Controls.Add(this.labelISR);
            this.Controls.Add(this.labelAFP);
            this.Controls.Add(this.labelSFS);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalcularNomina";
            this.Text = "CalcularNomina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxSalary;
        private Label label2;
        private Button btnCalcular;
        private Label labelSFS;
        private Label labelAFP;
        private Label labelISR;
        private Label labelTotalDeducciones;
        private Label labelSueldoNeto;
    }
}