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
                num_one_label.Text = "Diva! Az els� sz�m �res";
                num_two_label.Text = "Diva! A m�sodik sz�m �res";
            }
            else if (string.IsNullOrEmpty(text1.Text) && !string.IsNullOrEmpty(text2.Text))
            {
                num_two_label.Text = "M�sodik sz�m";
                num_one_label.Text = "Diva! Az els� sz�m �res";
            }
            else if (string.IsNullOrEmpty(text2.Text) && !string.IsNullOrEmpty(text1.Text))
            {
                num_one_label.Text = "Els� Sz�m";
                num_two_label.Text = "Diva! A m�sodik sz�m �res";
            }
            else
            {
                num_one_label.Text = "Els� Sz�m";
                num_two_label.Text = "M�sodik Sz�m";
                label5.Text = $"A k�t sz�m szorozva: {Math.Round((double.Parse(text1.Text) * double.Parse(text2.Text)), 2)}";

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
                num_one_label.Text = "Diva! Az els� sz�m �res";
                num_two_label.Text = "Diva! A m�sodik sz�m �res";
            }
            else if (string.IsNullOrEmpty(text1.Text) && !string.IsNullOrEmpty(text2.Text))
            {
                num_two_label.Text = "M�sodik sz�m";
                num_one_label.Text = "Diva! Az els� sz�m �res";
            }
            else if (string.IsNullOrEmpty(text2.Text) && !string.IsNullOrEmpty(text1.Text))
            {
                num_one_label.Text = "Els� Sz�m";
                num_two_label.Text = "Diva! A m�sodik sz�m �res";
            }
            else
            {
                num_one_label.Text = "Els� Sz�m";
                num_two_label.Text = "M�sodik Sz�m";
                label5.Text = $"A k�t sz�m �sszeadva: {Math.Round((double.Parse(text1.Text) + double.Parse(text2.Text)), 2)}";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text1.Text) && string.IsNullOrEmpty(text2.Text))
            {
                num_one_label.Text = "Diva! Az els� sz�m �res";
                num_two_label.Text = "Diva! A m�sodik sz�m �res";
            }
            else if (string.IsNullOrEmpty(text1.Text) && !string.IsNullOrEmpty(text2.Text))
            {
                num_two_label.Text = "M�sodik sz�m";
                num_one_label.Text = "Diva! Az els� sz�m �res";
            }
            else if (string.IsNullOrEmpty(text2.Text) && !string.IsNullOrEmpty(text1.Text))
            {
                num_one_label.Text = "Els� Sz�m";
                num_two_label.Text = "Diva! A m�sodik sz�m �res";
            }
            else
            {
                num_one_label.Text = "Els� Sz�m";
                num_two_label.Text = "M�sodik Sz�m";
                label5.Text = $"A k�t sz�m elosztva: {Math.Round((double.Parse(text1.Text) / double.Parse(text2.Text)), 2)}";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text1.Text) && string.IsNullOrEmpty(text2.Text))
            {
                num_one_label.Text = "Diva! Az els� sz�m �res";
                num_two_label.Text = "Diva! A m�sodik sz�m �res";
            }
            else if (string.IsNullOrEmpty(text1.Text) && !string.IsNullOrEmpty(text2.Text))
            {
                num_two_label.Text = "M�sodik sz�m";
                num_one_label.Text = "Diva! Az els� sz�m �res";
            }
            else if (string.IsNullOrEmpty(text2.Text) && !string.IsNullOrEmpty(text1.Text))
            {
                num_one_label.Text = "Els� Sz�m";
                num_two_label.Text = "Diva! A m�sodik sz�m �res";
            }
            else
            {
                num_one_label.Text = "Els� Sz�m";
                num_two_label.Text = "M�sodik Sz�m";
                label5.Text = $"A k�t sz�m kivonva: {Math.Round((double.Parse(text1.Text) - double.Parse(text2.Text)),2)}";

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
                num_one_label.Text = "Diva! Az els� sz�m �res";
                num_two_label.Text = "Diva! A m�sodik sz�m �res";
            }
            else if (string.IsNullOrEmpty(text2.Text) && !string.IsNullOrEmpty(text1.Text))
            {
                num_two_label.Text = "M�sodik sz�m";
                num_one_label.Text = "Diva! Az els� sz�m �res";
            }
            else if (string.IsNullOrEmpty(text1.Text) && !string.IsNullOrEmpty(text2.Text))
            {
                num_one_label.Text = "Els� sz�m";
                num_two_label.Text = "Diva! A m�sodik sz�m �res";
            }
            else
            {
                num_one_label.Text = "Els� Sz�m";
                num_two_label.Text = "M�sodik Sz�m";
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
                        label5.Text = $"A k�t sz�m kivonva: {num}";
                        break;
                    case 1:
                        label5.Text = $"A k�t sz�m elosztva: {num}";
                        break;
                    case 2:
                        label5.Text = $"A k�t sz�m �sszeadva: {num}";
                        break;
                    case 3:
                        label5.Text = $"A k�t sz�m szorozva: {num}";
                        break;
                    default:
                        MessageBox.Show("Valami hiba t�rt�nt");
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
