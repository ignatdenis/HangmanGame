namespace Hangman_Ignat_Denis
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
            pictureBoxImagine = new PictureBox();
            labelWord = new Label();
            label1 = new Label();
            buttonExit = new Button();
            labelGreseli = new Label();
            buttonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagine).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImagine
            // 
            pictureBoxImagine.Location = new Point(599, 144);
            pictureBoxImagine.Name = "pictureBoxImagine";
            pictureBoxImagine.Size = new Size(405, 406);
            pictureBoxImagine.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxImagine.TabIndex = 1;
            pictureBoxImagine.TabStop = false;
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWord.Location = new Point(37, 114);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(0, 65);
            labelWord.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(331, 86);
            label1.TabIndex = 5;
            label1.Text = "Hangman";
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(844, 556);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(160, 64);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Iesire";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelGreseli
            // 
            labelGreseli.AutoSize = true;
            labelGreseli.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGreseli.Location = new Point(420, 187);
            labelGreseli.Name = "labelGreseli";
            labelGreseli.Size = new Size(0, 40);
            labelGreseli.TabIndex = 7;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(37, 556);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(160, 64);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Joc Nou";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 632);
            Controls.Add(buttonReset);
            Controls.Add(labelGreseli);
            Controls.Add(buttonExit);
            Controls.Add(label1);
            Controls.Add(labelWord);
            Controls.Add(pictureBoxImagine);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxImagine;
        private Label labelWord;
        private Label label1;
        private Button buttonExit;
        private Label labelGreseli;
        private Button buttonReset;
    }
}
