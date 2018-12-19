namespace LSB_stegan
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadImage = new System.Windows.Forms.Button();
            this.imagePath = new System.Windows.Forms.TextBox();
            this.encript = new System.Windows.Forms.CheckBox();
            this.decript = new System.Windows.Forms.CheckBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.RichTextBox();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadImage
            // 
            this.ReadImage.Location = new System.Drawing.Point(13, 13);
            this.ReadImage.Name = "ReadImage";
            this.ReadImage.Size = new System.Drawing.Size(84, 23);
            this.ReadImage.TabIndex = 0;
            this.ReadImage.Text = "Wczytaj obraz";
            this.ReadImage.UseVisualStyleBackColor = true;
            this.ReadImage.Click += new System.EventHandler(this.ReadImage_Click);
            // 
            // imagePath
            // 
            this.imagePath.Location = new System.Drawing.Point(104, 15);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(459, 20);
            this.imagePath.TabIndex = 1;
            this.imagePath.TextChanged += new System.EventHandler(this.imagePath_TextChanged);
            // 
            // encript
            // 
            this.encript.AutoSize = true;
            this.encript.Location = new System.Drawing.Point(15, 54);
            this.encript.Name = "encript";
            this.encript.Size = new System.Drawing.Size(70, 17);
            this.encript.TabIndex = 2;
            this.encript.Text = "Enkryptuj";
            this.encript.UseVisualStyleBackColor = true;
            this.encript.CheckedChanged += new System.EventHandler(this.encript_CheckedChanged);
            // 
            // decript
            // 
            this.decript.AutoSize = true;
            this.decript.Location = new System.Drawing.Point(15, 77);
            this.decript.Name = "decript";
            this.decript.Size = new System.Drawing.Size(71, 17);
            this.decript.TabIndex = 3;
            this.decript.Text = "Dekryptuj";
            this.decript.UseVisualStyleBackColor = true;
            this.decript.CheckedChanged += new System.EventHandler(this.decript_CheckedChanged);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(12, 110);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(63, 13);
            this.messageLabel.TabIndex = 5;
            this.messageLabel.Text = "Wiadomość";
            this.messageLabel.Click += new System.EventHandler(this.messageLabel_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(15, 127);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(548, 96);
            this.message.TabIndex = 6;
            this.message.Text = "";
            this.message.TextChanged += new System.EventHandler(this.message_TextChanged);
            // 
            // pictureLabel
            // 
            this.pictureLabel.AutoSize = true;
            this.pictureLabel.Location = new System.Drawing.Point(9, 282);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(35, 13);
            this.pictureLabel.TabIndex = 7;
            this.pictureLabel.Text = "Obraz";
            this.pictureLabel.Click += new System.EventHandler(this.pictureLabel_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 298);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(548, 267);
            this.picture.TabIndex = 8;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(15, 230);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(545, 36);
            this.start.TabIndex = 9;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // saveImage
            // 
            this.saveImage.Location = new System.Drawing.Point(485, 574);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(75, 23);
            this.saveImage.TabIndex = 10;
            this.saveImage.Text = "Zapisz obraz";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // trackBar
            // 
            this.trackBar.LargeChange = 2;
            this.trackBar.Location = new System.Drawing.Point(104, 64);
            this.trackBar.Maximum = 8;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(456, 45);
            this.trackBar.TabIndex = 8;
            this.trackBar.Value = 8;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Szyfrować na którym bicie?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "MSB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "LSB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 609);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.start);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.pictureLabel);
            this.Controls.Add(this.message);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.decript);
            this.Controls.Add(this.encript);
            this.Controls.Add(this.imagePath);
            this.Controls.Add(this.ReadImage);
            this.Name = "Form1";
            this.Text = "LSB Steganography";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadImage;
        private System.Windows.Forms.TextBox imagePath;
        private System.Windows.Forms.CheckBox encript;
        private System.Windows.Forms.CheckBox decript;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

