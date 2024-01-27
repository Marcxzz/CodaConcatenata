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
            listBoxCoda = new ListBox();
            SuspendLayout();
            // 
            // textBoxValore
            // 
            textBoxValore.Location = new Point(19, 23);
            textBoxValore.Name = "textBoxValore";
            textBoxValore.PlaceholderText = "Valore del nuovo nodo";
            textBoxValore.Size = new Size(158, 23);
            textBoxValore.TabIndex = 0;
            // 
            // buttonPush
            // 
            buttonPush.Location = new Point(183, 23);
            buttonPush.Name = "buttonPush";
            buttonPush.Size = new Size(117, 23);
            buttonPush.TabIndex = 1;
            buttonPush.Text = "Push";
            buttonPush.UseVisualStyleBackColor = true;
            buttonPush.Click += buttonPush_Click;
            // 
            // buttonPop
            // 
            buttonPop.Location = new Point(306, 23);
            buttonPop.Name = "buttonPop";
            buttonPop.Size = new Size(117, 23);
            buttonPop.TabIndex = 2;
            buttonPop.Text = "Pop";
            buttonPop.UseVisualStyleBackColor = true;
            buttonPop.Click += buttonPop_Click;
            // 
            // listBoxCoda
            // 
            listBoxCoda.FormattingEnabled = true;
            listBoxCoda.ItemHeight = 15;
            listBoxCoda.Location = new Point(19, 52);
            listBoxCoda.Name = "listBoxCoda";
            listBoxCoda.Size = new Size(404, 229);
            listBoxCoda.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 304);
            Controls.Add(listBoxCoda);
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
        private ListBox listBoxCoda;
    }
}
