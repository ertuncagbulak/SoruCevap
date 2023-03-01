using System.Data.SqlClient;

namespace SoruCevap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-I2H6A9U\\SQLEXPRESS;Initial Catalog=yarisma;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Soru()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from sorucevap order by newid() ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            for (int soruid = 0; soruid <= 5; soruid++)
            {
                while (oku.Read())
                {
                    textBox1.Text = oku["soruid"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["a"].ToString();
                    button2.Text = oku["b"].ToString();
                    button3.Text = oku["c"].ToString();
                    button4.Text = oku["d"].ToString();
                    label4.Text = oku["dogrucevap"].ToString();

                }
                break;
            }
            baglanti.Close();
        }

        private void Soru1()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from sorucevap2 order by newid() ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            for (int soruid = 0; soruid <= 5; soruid++)
            {
                while (oku.Read())
                {
                    textBox1.Text = oku["soruid"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["a"].ToString();
                    button2.Text = oku["b"].ToString();
                    button3.Text = oku["c"].ToString();
                    button4.Text = oku["d"].ToString();
                    label4.Text = oku["dogrucevap"].ToString();

                }
                break;
            }
            baglanti.Close();

        }

        private void Soru2()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from sorucevap3 order by newid() ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            for (int soruid = 0; soruid <= 5; soruid++)
            {
                while (oku.Read())
                {
                    textBox1.Text = oku["soruid"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["a"].ToString();
                    button2.Text = oku["b"].ToString();
                    button3.Text = oku["c"].ToString();
                    button4.Text = oku["d"].ToString();
                    label4.Text = oku["dogrucevap"].ToString();

                }
                break;
            }
            baglanti.Close();

        }

        private void Soru3()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from sorucevap4 order by newid() ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            for (int soruid = 0; soruid <= 5; soruid++)
            {
                while (oku.Read())
                {
                    textBox1.Text = oku["soruid"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["a"].ToString();
                    button2.Text = oku["b"].ToString();
                    button3.Text = oku["c"].ToString();
                    button4.Text = oku["d"].ToString();
                    label4.Text = oku["dogrucevap"].ToString();

                }
                break;
            }
            baglanti.Close();

        }
        private void Soru4()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from sorucevap5 order by newid() ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            for (int soruid = 0; soruid <= 5; soruid++)
            {
                while (oku.Read())
                {
                    textBox1.Text = oku["soruid"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["a"].ToString();
                    button2.Text = oku["b"].ToString();
                    button3.Text = oku["c"].ToString();
                    button4.Text = oku["d"].ToString();
                    label4.Text = oku["dogrucevap"].ToString();

                }
                break;
            }
            baglanti.Close();

        }

        int soruid = 0;
        int puan = 0;
        int ss = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == label4.Text)
            {

                puan = puan + 10;
                label3.Text = puan.ToString();

                button1.BackColor = Color.Green;


            }
            else
            {
                puan = puan + 0;
                button1.BackColor = Color.Red;

            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == label4.Text)
            {

                puan = puan + 10;
                label3.Text = puan.ToString();
                button2.BackColor = Color.Green;


            }
            else
            {
                puan = puan + 0;
                button2.BackColor = Color.Red;


            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == label4.Text)
            {

                puan = puan + 10;
                label3.Text = puan.ToString();

                button3.BackColor = Color.Green;
            }
            else
            {
                puan = puan + 0;
                button3.BackColor = Color.Red;
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == label4.Text)
            {

                puan = puan + 10;
                label3.Text = puan.ToString();
                button4.BackColor = Color.Green;
            }
            else
            {
                puan = puan + 0;
                button4.BackColor = Color.Red;
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Sýradaki";
            ss++;
            label1.Text = ss.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;

            if (ss == 1)
            {
                Soru();
            }
            else if (ss == 2)
            {
                Soru1();
            }
            else if (ss == 3)
            {
                Soru2();
            }
            else if (ss == 4)
            {
                Soru3();
            }
            else if (ss == 5)
            {
                Soru4();
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Puanýnýz: " + puan);
            }
            button1.BackColor = DefaultBackColor;
            button2.BackColor = DefaultBackColor;
            button3.BackColor = DefaultBackColor;
            button4.BackColor = DefaultBackColor;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}