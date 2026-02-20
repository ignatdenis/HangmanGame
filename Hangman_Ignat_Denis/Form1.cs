using System.Windows.Forms;

namespace Hangman_Ignat_Denis
{
    public partial class Form1 : Form
    {
        private string cuvantCurent;
        private List<char> LitereGhicite = new List<char>();
        private int greseli = 0;
        private List<string> cuvinte = new List<string>
            {
              "CALCULATOR", "TELEFON", "MASA", "SCAUN", "PANTOF",
              "AVION", "LAMPA", "FLOARE", "COPAC", "CARTE",
              "PIX", "TREN", "FRIGIDER", "TELEVIZOR", "PLAPUMA",
              "SOARE", "LUNA", "STEA", "MUNTE", "MARE",
              "PESTE", "CAINE", "PISICA", "CAIET", "GHIOZDAN",
              "GEAM", "USA", "OGLINDA", "PERETE", "PAT",
              "CASTI", "TABLA", "BIROU", "FRUCT", "LAPTE",
              "CEAS", "CHEIE", "FARFURIE", "LINGURA", "FURCULITA"
            };
        private int scor;
        public Form1()
        {
            InitializeComponent();
            scor = cuvinte.Count;
            cuvantCurent = AlegeCuvantRandom();
            UpdateGreseli();
            CreareButoane();
            UpdateCuvantAfisat();
        }

        private void CreareButoane()
        {
            int x = 10, y = 250;
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Button b = new Button();
                b.Font = new Font("Arial", 16, FontStyle.Bold);
                b.Text = c.ToString();
                b.Width = 60;
                b.Height = 60;
                b.Left = x;
                b.Top = y;
                b.Click += ButonClick;
                this.Controls.Add(b);

                x += 65;
                if ((c - 'A' + 1) % 18 == 0)
                {
                    x = 45;
                    y += 70;
                }
                else if((c - 'A' + 1) % 9 == 0)
                {
                    x = 10;
                    y += 70;
                }
            }
        }

        private void ButonClick(object sender, EventArgs e)
        {
            Button butonApasat = sender as Button;
            butonApasat.Enabled = false;
            char literaGhicita = butonApasat.Text[0];

            if (cuvantCurent.Contains(literaGhicita.ToString()))
            {
                LitereGhicite.Add(literaGhicita);
                UpdateCuvantAfisat();
                VerifCastig();
            }
            else
            {
                greseli++;
                UpdateGreseli();
                VerifPierdere();
            }
        }

        private void UpdateCuvantAfisat()
        {
            string cuv = "";
            foreach (char c in cuvantCurent)
            {
                if (LitereGhicite.Contains(c))
                    cuv += c + " ";
                else
                    cuv += "_ ";
            }
            labelWord.Text = cuv;
        }

        private void UpdateGreseli()
        {
            labelGreseli.Text = $"Greseli: {greseli}/6";
            switch (greseli)
            {
                case 0:
                    pictureBoxImagine.Image = Image.FromFile("Image/hangman0.png");
                    break;
                case 1:
                    pictureBoxImagine.Image = Image.FromFile("Image/hangman1.png");
                    break;
                case 2:
                    pictureBoxImagine.Image = Image.FromFile("Image/hangman2.png");
                    break;
                case 3:
                    pictureBoxImagine.Image = Image.FromFile("Image/hangman3.png");
                    break;
                case 4:
                    pictureBoxImagine.Image = Image.FromFile("Image/hangman4.png");
                    break;
                case 5:
                    pictureBoxImagine.Image = Image.FromFile("Image/hangman5.png");
                    break;
                case 6:
                    pictureBoxImagine.Image = Image.FromFile("Image/hangman6.png");
                    break;
            }
        }

        private void VerifCastig()
        {
            bool castig = true;
            foreach (char c in cuvantCurent)
            {
                if (!LitereGhicite.Contains(c))
                {
                    castig = false;
                    break;
                }
            }

            if (castig)
            {
                scor--;
                MessageBox.Show("Felicitari! Ai castigat!");
                StopJoc();
            }
        }

        private void StopJoc()
        {
            foreach (Control ctrl in this.Controls)
                if (ctrl is Button b && b.Text.Length == 1)
                    ctrl.Enabled = false;
        }

        private void StopJocTot()
        {
            foreach (Control ctrl in this.Controls)
                if (ctrl is Button b && b.Text.Length == 1)
                    ctrl.Enabled = false;
            buttonReset.Enabled = false;
        }

        private void VerifPierdere()
        {
            if (greseli >= 6)
            {
                MessageBox.Show($"Ai pierdut! Cuvantul era: {cuvantCurent}");
                StopJoc();
            }
        }


        private string AlegeCuvantRandom()
        {
            Random r = new Random();
            int index = r.Next(0, cuvinte.Count);
            string temp = cuvinte[index];
            cuvinte.RemoveAt(index);
            return temp;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (cuvinte.Count == 0)
            {
                if(scor == 0)
                MessageBox.Show("Nu mai sunt cuvinte disponibile, felicitari le-ai ghicit pe toate!");
                else MessageBox.Show("Nu mai sunt cuvinte disponibile, mai citeste odata dictionarul");
                StopJocTot();
                return;
            }
            cuvantCurent = AlegeCuvantRandom();
            LitereGhicite.Clear();
            greseli = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button && ctrl.Text.Length == 1)
                    ctrl.Enabled = true;
            }
            UpdateCuvantAfisat();
            UpdateGreseli();
        }
    }
}
