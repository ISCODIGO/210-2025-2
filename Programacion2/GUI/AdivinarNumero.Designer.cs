namespace GUI
{
    partial class AdivinarNumero
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
            label1 = new Label();
            TxtNumero = new TextBox();
            BtnAdivina = new Button();
            statusStrip1 = new StatusStrip();
            LblIntentos = new ToolStripStatusLabel();
            LblConsejo = new ToolStripStatusLabel();
            LstCandidatosFallidos = new ListBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero:";
            // 
            // textBox1
            // 
            TxtNumero.Location = new Point(84, 49);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(69, 27);
            TxtNumero.TabIndex = 1;
            // 
            // button1
            // 
            BtnAdivina.Location = new Point(159, 48);
            BtnAdivina.Name = "BtnAdivina";
            BtnAdivina.Size = new Size(94, 29);
            BtnAdivina.TabIndex = 3;
            BtnAdivina.Text = "Adivinar";
            BtnAdivina.UseVisualStyleBackColor = true;
            BtnAdivina.Click += BtnAdivinaClick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblIntentos, LblConsejo });
            statusStrip1.Location = new Point(0, 221);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(540, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // intentosLabel
            // 
            LblIntentos.Name = "LblIntentos";
            LblIntentos.Size = new Size(98, 20);
            LblIntentos.Text = "intentosLabel";
            // 
            // consejoLabel
            // 
            LblConsejo.Name = "LblConsejo";
            LblConsejo.Size = new Size(96, 20);
            LblConsejo.Text = "consejoLabel";
            // 
            // listBox1
            // 
            LstCandidatosFallidos.FormattingEnabled = true;
            LstCandidatosFallidos.Location = new Point(293, 12);
            LstCandidatosFallidos.Name = "LstCandidatosFallidos";
            LstCandidatosFallidos.Size = new Size(150, 184);
            LstCandidatosFallidos.TabIndex = 5;
            // 
            // AdivinarNumero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 247);
            Controls.Add(LstCandidatosFallidos);
            Controls.Add(statusStrip1);
            Controls.Add(BtnAdivina);
            Controls.Add(TxtNumero);
            Controls.Add(label1);
            Name = "AdivinarNumero";
            Text = "AdivinarNumero";
            Load += AdivinarNumero_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtNumero;
        private Button BtnAdivina;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LblIntentos;
        private ToolStripStatusLabel LblConsejo;
        private ListBox LstCandidatosFallidos;
    }
}