namespace S6GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            btnCrear = new System.Windows.Forms.Button();
            LstAlumnos = new System.Windows.Forms.ListBox();
            TxtNombre = new System.Windows.Forms.TextBox();
            TxtCuenta = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            CmbCarrera = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new System.Drawing.Point(18, 241);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(153, 31);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear alumno";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // LstAlumnos
            // 
            LstAlumnos.FormattingEnabled = true;
            LstAlumnos.Location = new System.Drawing.Point(339, 28);
            LstAlumnos.Name = "LstAlumnos";
            LstAlumnos.Size = new System.Drawing.Size(400, 304);
            LstAlumnos.TabIndex = 5;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new System.Drawing.Point(91, 101);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new System.Drawing.Size(226, 27);
            TxtNombre.TabIndex = 6;
            // 
            // TxtCuenta
            // 
            TxtCuenta.Location = new System.Drawing.Point(91, 145);
            TxtCuenta.Name = "TxtCuenta";
            TxtCuenta.Size = new System.Drawing.Size(226, 27);
            TxtCuenta.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 106);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 20);
            label1.TabIndex = 9;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 153);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 20);
            label2.TabIndex = 10;
            label2.Text = "Cuenta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 196);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 20);
            label3.TabIndex = 11;
            label3.Text = "Carrera:";
            // 
            // CmbCarrera
            // 
            CmbCarrera.FormattingEnabled = true;
            CmbCarrera.Items.AddRange(new object[] { "Arquitectura", "Matemáticas", "Ing. en Sistemas", "Ing. Civil", "Ing. Elétrica" });
            CmbCarrera.Location = new System.Drawing.Point(91, 188);
            CmbCarrera.Name = "CmbCarrera";
            CmbCarrera.Size = new System.Drawing.Size(226, 28);
            CmbCarrera.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(CmbCarrera);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtCuenta);
            Controls.Add(TxtNombre);
            Controls.Add(LstAlumnos);
            Controls.Add(btnCrear);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox CmbCarrera;

        #endregion
        private System.Windows.Forms.Button btnCrear;
        private ListBox LstAlumnos;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCuenta;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
