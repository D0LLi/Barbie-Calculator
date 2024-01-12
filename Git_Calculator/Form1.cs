namespace Git_Calculator
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            player.SoundLocation = "barbie.wav";
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text1.Text) && string.IsNullOrEmpty(text2.Text))
            {
                num_one_label.Text = "Diva! Az elsõ szám üres";
                num_two_label.Text = "Diva! A második szám üres";
            }
            else if (string.IsNullOrEmpty(text1.Text) && !string.IsNullOrEmpty(text2.Text))
            {
                num_two_label.Text = "Második szám";
                num_one_label.Text = "Diva! Az elsõ szám üres";
            }
            else if (string.IsNullOrEmpty(text2.Text) && !string.IsNullOrEmpty(text1.Text))
            {
                num_one_label.Text = "Elsõ Szám";
                num_two_label.Text = "Diva! A második szám üres";
            }
            else
            {
                num_one_label.Text = "Elsõ Szám";
                num_two_label.Text = "Második Szám";
                label5.Text = $"A két szám szorozva: {Math.Round((double.Parse(text1.Text) * double.Parse(text2.Text)), 2)}";

            }
        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text1.Text) && string.IsNullOrEmpty(text2.Text))
            {
                num_one_label.Text = "Diva! Az elsõ szám üres";
                num_two_label.Text = "Diva! A második szám üres";
            }
            else if (string.IsNullOrEmpty(text1.Text) && !string.IsNullOrEmpty(text2.Text))
            {
                num_two_label.Text = "Második szám";
                num_one_label.Text = "Diva! Az elsõ szám üres";
            }
            else if (string.IsNullOrEmpty(text2.Text) && !string.IsNullOrEmpty(text1.Text))
            {
                num_one_label.Text = "Elsõ Szám";
                num_two_label.Text = "Diva! A második szám üres";
            }
            else
            {
                num_one_label.Text = "Elsõ Szám";
                num_two_label.Text = "Második Szám";
                label5.Text = $"A két szám összeadva: {Math.Round((double.Parse(text1.Text) + double.Parse(text2.Text)), 2)}";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text1.Text) && string.IsNullOrEmpty(text2.Text))
            {
                num_one_label.Text = "Diva! Az elsõ szám üres";
                num_two_label.Text = "Diva! A második szám üres";
            }
            else if (string.IsNullOrEmpty(text1.Text) && !string.IsNullOrEmpty(text2.Text))
            {
                num_two_label.Text = "Második szám";
                num_one_label.Text = "Diva! Az elsõ szám üres";
            }
            else if (string.IsNullOrEmpty(text2.Text) && !string.IsNullOrEmpty(text1.Text))
            {
                num_one_label.Text = "Elsõ Szám";
                num_two_label.Text = "Diva! A második szám üres";
            }
            else
            {
                num_one_label.Text = "Elsõ Szám";
                num_two_label.Text = "Második Szám";
                label5.Text = $"A két szám elosztva: {Math.Round((double.Parse(text1.Text) / double.Parse(text2.Text)), 2)}";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text1.Text) && string.IsNullOrEmpty(text2.Text))
            {
                num_one_label.Text = "Diva! Az elsõ szám üres";
                num_two_label.Text = "Diva! A második szám üres";
            }
            else if (string.IsNullOrEmpty(text1.Text) && !string.IsNullOrEmpty(text2.Text))
            {
                num_two_label.Text = "Második szám";
                num_one_label.Text = "Diva! Az elsõ szám üres";
            }
            else if (string.IsNullOrEmpty(text2.Text) && !string.IsNullOrEmpty(text1.Text))
            {
                num_one_label.Text = "Elsõ Szám";
                num_two_label.Text = "Diva! A második szám üres";
            }
            else
            {
                num_one_label.Text = "Elsõ Szám";
                num_two_label.Text = "Második Szám";
                label5.Text = $"A két szám kivonva: {Math.Round((double.Parse(text1.Text) - double.Parse(text2.Text)),2)}";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text1.Text = Convert.ToString(new Random().Next(-1000, 23300));
            text2.Text = Convert.ToString(new Random().Next(-1000, 23300));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(text1.Text) && string.IsNullOrEmpty(text2.Text))
            {
                num_one_label.Text = "Diva! Az elsõ szám üres";
                num_two_label.Text = "Diva! A második szám üres";
            }
            else if (string.IsNullOrEmpty(text2.Text) && !string.IsNullOrEmpty(text1.Text))
            {
                num_two_label.Text = "Második szám";
                num_one_label.Text = "Diva! Az elsõ szám üres";
            }
            else if (string.IsNullOrEmpty(text1.Text) && !string.IsNullOrEmpty(text2.Text))
            {
                num_one_label.Text = "Elsõ szám";
                num_two_label.Text = "Diva! A második szám üres";
            }
            else
            {
                num_one_label.Text = "Elsõ Szám";
                num_two_label.Text = "Második Szám";
                double kiv = Math.Round((double.Parse(text1.Text) - double.Parse(text2.Text)), 2);
                double osz = Math.Round((double.Parse(text1.Text) + double.Parse(text2.Text)), 2);
                double szor = Math.Round((double.Parse(text1.Text) * double.Parse(text2.Text)), 2);
                double oszt = Math.Round((double.Parse(text1.Text) / double.Parse(text2.Text)), 2);
                double[] random_num = { kiv, oszt, osz, szor };
                int randomize = new Random().Next(0, 4);
                double num = random_num[randomize];
                switch (randomize)
                {
                    case 0:
                        label5.Text = $"A két szám kivonva: {num}";
                        break;
                    case 1:
                        label5.Text = $"A két szám elosztva: {num}";
                        break;
                    case 2:
                        label5.Text = $"A két szám összeadva: {num}";
                        break;
                    case 3:
                        label5.Text = $"A két szám szorozva: {num}";
                        break;
                    default:
                        MessageBox.Show("Valami hiba történt");
                        label5.Text = "hIbAAA:((((((";
                        break;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       

        private void num_one_label_Click(object sender, EventArgs e)
        {

        }
    }
}
