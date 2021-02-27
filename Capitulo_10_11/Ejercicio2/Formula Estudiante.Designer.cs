
namespace Capitulo_10_11.Ejercicio2
{
    partial class Formula_Estudiante
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
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.EdadtextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.PromediotextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad de estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion Estudiante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Promedio Estudinate";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(153, 34);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(108, 23);
            this.NombretextBox.TabIndex = 4;
            // 
            // EdadtextBox
            // 
            this.EdadtextBox.Location = new System.Drawing.Point(153, 63);
            this.EdadtextBox.Name = "EdadtextBox";
            this.EdadtextBox.Size = new System.Drawing.Size(108, 23);
            this.EdadtextBox.TabIndex = 5;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(153, 92);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(108, 23);
            this.DirecciontextBox.TabIndex = 6;
            // 
            // PromediotextBox
            // 
            this.PromediotextBox.Location = new System.Drawing.Point(153, 121);
            this.PromediotextBox.Name = "PromediotextBox";
            this.PromediotextBox.Size = new System.Drawing.Size(108, 23);
            this.PromediotextBox.TabIndex = 7;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(348, 44);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(84, 37);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(348, 87);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(84, 37);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Formula_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 186);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.PromediotextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.EdadtextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formula_Estudiante";
            this.Text = "Formula_Estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox EdadtextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.TextBox PromediotextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
    }
}