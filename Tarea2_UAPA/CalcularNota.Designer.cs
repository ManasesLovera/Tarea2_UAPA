namespace Tarea2_UAPA
{
    partial class CalcularNota
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxExamen = new System.Windows.Forms.TextBox();
            this.textBoxPlataforma = new System.Windows.Forms.TextBox();
            this.textBoxActitudesYValores = new System.Windows.Forms.TextBox();
            this.textBoxTrabajoFinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.labelNota = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelLiteral = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(187, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Examen: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plataforma: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Actitudes y valores: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trabajo final: ";
            // 
            // textBoxExamen
            // 
            this.textBoxExamen.Location = new System.Drawing.Point(337, 119);
            this.textBoxExamen.Name = "textBoxExamen";
            this.textBoxExamen.Size = new System.Drawing.Size(145, 34);
            this.textBoxExamen.TabIndex = 5;
            // 
            // textBoxPlataforma
            // 
            this.textBoxPlataforma.Location = new System.Drawing.Point(337, 179);
            this.textBoxPlataforma.Name = "textBoxPlataforma";
            this.textBoxPlataforma.Size = new System.Drawing.Size(145, 34);
            this.textBoxPlataforma.TabIndex = 6;
            // 
            // textBoxActitudesYValores
            // 
            this.textBoxActitudesYValores.Location = new System.Drawing.Point(337, 230);
            this.textBoxActitudesYValores.Name = "textBoxActitudesYValores";
            this.textBoxActitudesYValores.Size = new System.Drawing.Size(145, 34);
            this.textBoxActitudesYValores.TabIndex = 7;
            // 
            // textBoxTrabajoFinal
            // 
            this.textBoxTrabajoFinal.Location = new System.Drawing.Point(337, 281);
            this.textBoxTrabajoFinal.Name = "textBoxTrabajoFinal";
            this.textBoxTrabajoFinal.Size = new System.Drawing.Size(145, 34);
            this.textBoxTrabajoFinal.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCalcular.Location = new System.Drawing.Point(187, 362);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(177, 42);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(92, 455);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(68, 28);
            this.labelNota.TabIndex = 10;
            this.labelNota.Text = "Nota:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(92, 505);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(127, 28);
            this.labelResultado.TabIndex = 11;
            this.labelResultado.Text = "Resultado: ";
            // 
            // labelLiteral
            // 
            this.labelLiteral.AutoSize = true;
            this.labelLiteral.Location = new System.Drawing.Point(92, 554);
            this.labelLiteral.Name = "labelLiteral";
            this.labelLiteral.Size = new System.Drawing.Size(96, 28);
            this.labelLiteral.TabIndex = 12;
            this.labelLiteral.Text = "Literal: ";
            // 
            // CalcularNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 667);
            this.Controls.Add(this.labelLiteral);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelNota);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBoxTrabajoFinal);
            this.Controls.Add(this.textBoxActitudesYValores);
            this.Controls.Add(this.textBoxPlataforma);
            this.Controls.Add(this.textBoxExamen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CalcularNota";
            this.Text = "Calcular Nota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxExamen;
        private TextBox textBoxPlataforma;
        private TextBox textBoxActitudesYValores;
        private TextBox textBoxTrabajoFinal;
        private Button btnCalcular;
        private Label labelNota;
        private Label labelResultado;
        private Label labelLiteral;
    }
}