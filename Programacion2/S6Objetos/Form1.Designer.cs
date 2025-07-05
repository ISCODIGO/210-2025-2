namespace S6Objetos
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCrear = new Button();
            lstAlumnos = new ListBox();
            txtNombre = new TextBox();
            txtCuenta = new TextBox();
            txtCarrera = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(18, 241);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(153, 23);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear alumno";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // lstAlumnos
            // 
            lstAlumnos.FormattingEnabled = true;
            lstAlumnos.ItemHeight = 15;
            lstAlumnos.Location = new Point(339, 28);
            lstAlumnos.Name = "lstAlumnos";
            lstAlumnos.Size = new Size(400, 304);
            lstAlumnos.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(79, 145);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(238, 23);
            txtCuenta.TabIndex = 7;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(79, 188);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(238, 23);
            txtCarrera.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 106);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 153);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 10;
            label2.Text = "Cuenta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 196);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 11;
            label3.Text = "Carrera:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCarrera);
            Controls.Add(txtCuenta);
            Controls.Add(txtNombre);
            Controls.Add(lstAlumnos);
            Controls.Add(btnCrear);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCrear;
        private ListBox lstAlumnos;
        private TextBox txtNombre;
        private TextBox txtCuenta;
        private TextBox txtCarrera;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
