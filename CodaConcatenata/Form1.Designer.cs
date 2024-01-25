namespace CodaConcatenata
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
            textBoxValore = new TextBox();
            buttonPush = new Button();
            buttonPop = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxValore
            // 
            textBoxValore.Location = new Point(21, 38);
            textBoxValore.Name = "textBoxValore";
            textBoxValore.Size = new Size(158, 23);
            textBoxValore.TabIndex = 0;
            // 
            // buttonPush
            // 
            buttonPush.Location = new Point(185, 38);
            buttonPush.Name = "buttonPush";
            buttonPush.Size = new Size(117, 23);
            buttonPush.TabIndex = 1;
            buttonPush.Text = "Push";
            buttonPush.UseVisualStyleBackColor = true;
            buttonPush.Click += buttonPush_Click;
            // 
            // buttonPop
            // 
            buttonPop.Location = new Point(308, 38);
            buttonPop.Name = "buttonPop";
            buttonPop.Size = new Size(117, 23);
            buttonPop.TabIndex = 2;
            buttonPop.Text = "Pop";
            buttonPop.UseVisualStyleBackColor = true;
            buttonPop.Click += buttonPop_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(21, 67);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(404, 229);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 4;
            label1.Text = "Valore del nuovo nodo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 324);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(buttonPop);
            Controls.Add(buttonPush);
            Controls.Add(textBoxValore);
            Name = "Form1";
            Text = "Coda Concatenata";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxValore;
        private Button buttonPush;
        private Button buttonPop;
        private ListBox listBox1;
        private Label label1;
    }
}
