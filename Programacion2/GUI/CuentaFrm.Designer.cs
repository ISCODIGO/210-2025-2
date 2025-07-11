namespace GUI
{
    partial class CuentaFrm
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ClienteLabel = new System.Windows.Forms.Label();
            SaldoLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            MontoTexto = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            ClienteEditable = new System.Windows.Forms.TextBox();
            BtnEditarCliente = new System.Windows.Forms.Button();
            BtnGuardarCliente = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(59, 58);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(59, 106);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Saldo:";
            // 
            // ClienteLabel
            // 
            ClienteLabel.AutoSize = true;
            ClienteLabel.Location = new System.Drawing.Point(158, 58);
            ClienteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ClienteLabel.Name = "ClienteLabel";
            ClienteLabel.Size = new System.Drawing.Size(50, 20);
            ClienteLabel.TabIndex = 2;
            ClienteLabel.Text = "label3";
            // 
            // SaldoLabel
            // 
            SaldoLabel.AutoSize = true;
            SaldoLabel.Location = new System.Drawing.Point(158, 106);
            SaldoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            SaldoLabel.Name = "SaldoLabel";
            SaldoLabel.Size = new System.Drawing.Size(17, 20);
            SaldoLabel.TabIndex = 3;
            SaldoLabel.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(59, 155);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "Monto:";
            // 
            // MontoTexto
            // 
            MontoTexto.Location = new System.Drawing.Point(158, 148);
            MontoTexto.Margin = new System.Windows.Forms.Padding(2);
            MontoTexto.Name = "MontoTexto";
            MontoTexto.Size = new System.Drawing.Size(224, 27);
            MontoTexto.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.LightGreen;
            button1.Location = new System.Drawing.Point(59, 215);
            button1.Margin = new System.Windows.Forms.Padding(2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(90, 47);
            button1.TabIndex = 6;
            button1.Text = "Deposito";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.IndianRed;
            button2.Location = new System.Drawing.Point(210, 215);
            button2.Margin = new System.Windows.Forms.Padding(2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(90, 47);
            button2.TabIndex = 7;
            button2.Text = "Retiro";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ClienteEditable
            // 
            ClienteEditable.Location = new System.Drawing.Point(158, 55);
            ClienteEditable.Name = "ClienteEditable";
            ClienteEditable.Size = new System.Drawing.Size(224, 27);
            ClienteEditable.TabIndex = 8;
            ClienteEditable.Visible = false;
            // 
            // button3
            // 
            BtnEditarCliente.Location = new System.Drawing.Point(420, 52);
            BtnEditarCliente.Name = "BtnEditarCliente";
            BtnEditarCliente.Size = new System.Drawing.Size(139, 29);
            BtnEditarCliente.TabIndex = 9;
            BtnEditarCliente.Text = "Editar Cliente";
            BtnEditarCliente.UseVisualStyleBackColor = true;
            BtnEditarCliente.Click += BtnEditarClienteClick;
            // 
            // button4
            // 
            BtnGuardarCliente.Location = new System.Drawing.Point(565, 52);
            BtnGuardarCliente.Name = "BtnGuardarCliente";
            BtnGuardarCliente.Size = new System.Drawing.Size(133, 29);
            BtnGuardarCliente.TabIndex = 10;
            BtnGuardarCliente.Text = "Guardar Cliente";
            BtnGuardarCliente.UseVisualStyleBackColor = true;
            BtnGuardarCliente.Click += BtnGuardarClienteClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(BtnGuardarCliente);
            Controls.Add(BtnEditarCliente);
            Controls.Add(ClienteEditable);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(MontoTexto);
            Controls.Add(label5);
            Controls.Add(SaldoLabel);
            Controls.Add(ClienteLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ClienteLabel;
        private System.Windows.Forms.Label SaldoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MontoTexto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ClienteEditable;
        private System.Windows.Forms.Button BtnEditarCliente;
        private System.Windows.Forms.Button BtnGuardarCliente;
    }
}
