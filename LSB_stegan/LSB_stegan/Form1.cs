using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LSB_stegan
{
    public partial class Form1 : Form
    {
        public string imagepath, filepath, tekst;
        public int whichBit;
        Bitmap input, output;
        public Form1()
        {
            InitializeComponent();
            encript.CheckState = CheckState.Checked;
            decript.CheckState = CheckState.Unchecked;
            imagePath.ReadOnly = true;
            whichBit = trackBar.Value;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void decript_CheckedChanged(object sender, EventArgs e)
        {
            switch(decript.CheckState)
            {
                case CheckState.Checked: {
                        label1.Text = "Deszyfrować na którym bicie?";
                        encript.CheckState = CheckState.Unchecked;
                        message.Text = "";
                        messageLabel.Text = "Pozyskana wiadomość:";
                        message.ReadOnly = true;
                    };break;
                case CheckState.Unchecked: {
                        label1.Text = "Szyfrować na którym bicie?";
                        encript.CheckState = CheckState.Checked;
                        messageLabel.Text = "Podaj wiadomość:";
                        message.ReadOnly = false;
                    };break;
            }
        }
        private void encript_CheckedChanged(object sender, EventArgs e)
        {
            switch (encript.CheckState)
            {
                case CheckState.Checked: {
                        label1.Text = "Szyfrować na którym bicie?";
                        decript.CheckState = CheckState.Unchecked;
                        messageLabel.Text = "Podaj wiadomość:";
                        message.ReadOnly = false;
                    }; break;
                case CheckState.Unchecked: {
                        label1.Text = "Deszyfrować na którym bicie?";
                        decript.CheckState = CheckState.Checked;
                        message.Text = "";
                        messageLabel.Text = "Pozyskana wiadomość:";
                        message.ReadOnly = true;
                    }; break;
            }
        }
        private void ReadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagepath = openFileDialog1.FileName;
                imagePath.Text = imagepath;
                input = new Bitmap(imagepath);
                pictureLabel.Text = "Wczytany obraz:";
                picture.Image = input;
                message.ReadOnly = false;
            }
        }

        private void imagePath_TextChanged(object sender, EventArgs e)
        {

        }
        private void messageLabel_Click(object sender, EventArgs e)
        {

        }

        private void message_TextChanged(object sender, EventArgs e)
        {
            if(imagePath.Text == "")
            {
                message.ReadOnly = true;
                message.Text = "";
                MessageBox.Show("Nie wybrano obrazu!");
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            LSB_STG stg = new LSB_STG();
            if (imagePath.Text != "")
            {
                if (encript.CheckState == CheckState.Checked)
                {
                    if (message.Text != "")
                    {
                        input = new Bitmap(imagepath);
                        tekst = message.Text;
                        pictureLabel.Text = "Przetwarzanie";
                        output = stg.embedText(tekst, input, whichBit);
                        pictureLabel.Text = "Obraz z zaszyfrowanym tekstem";
                        picture.Image = output;
                    }
                    else
                        MessageBox.Show("Nie wprowadzono wiadomości do zaszyfrowania!\nWprowadź tekst po czym naciśnij START.");
                }
                else
                {
                    tekst = stg.extractText(input, whichBit);
                    message.Text = tekst;
                    message.ReadOnly = true;
                }
            }
            else
                MessageBox.Show("Nie wybrano pliku graficznego!\nWybierz plik graficzny (najlepiej formatu PNG lub BMP) po czym wciśnij START");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            whichBit = trackBar.Value;
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void pictureLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            output = (Bitmap)picture.Image;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                output.Save(saveFileDialog1.FileName);
            }
        }
    }
}
