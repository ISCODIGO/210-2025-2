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
            textBox1 = new TextBox();
            button1 = new Button();
            statusStrip1 = new StatusStrip();
            intentosLabel = new ToolStripStatusLabel();
            consejoLabel = new ToolStripStatusLabel();
            listBox1 = new ListBox();
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
            textBox1.Location = new Point(84, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(69, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(159, 48);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Adivinar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { intentosLabel, consejoLabel });
            statusStrip1.Location = new Point(0, 221);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(540, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // intentosLabel
            // 
            intentosLabel.Name = "intentosLabel";
            intentosLabel.Size = new Size(98, 20);
            intentosLabel.Text = "intentosLabel";
            // 
            // consejoLabel
            // 
            consejoLabel.Name = "consejoLabel";
            consejoLabel.Size = new Size(96, 20);
            consejoLabel.Text = "consejoLabel";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(293, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 184);
            listBox1.TabIndex = 5;
            // 
            // AdivinarNumero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 247);
            Controls.Add(listBox1);
            Controls.Add(statusStrip1);
            Controls.Add(button1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button button1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel intentosLabel;
        private ToolStripStatusLabel consejoLabel;
        private ListBox listBox1;
    }
}