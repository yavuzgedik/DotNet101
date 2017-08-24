using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26DialogResult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();
        Random rnd = new Random();
        List<string> takimlar = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            TakimOlustur();

            foreach (var item in takimlar)
            {
                listTakimlar.Items.Add(item);
            }
        }

        int count = 0;
        int tickCount = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            tickCount++;
            int indexGrup = rnd.Next(1, 5);

            switch (indexGrup)
            {
                case 1:
                    if (listAgrubu.Items.Count < 4)
                    {
                        listAgrubu.Items.Add(takimlar[count]);
                    }
                    else
                    {
                        count--;
                        break;
                    }
                    break;
                case 2:
                    if (listBgrubu.Items.Count < 4)
                    {
                        listBgrubu.Items.Add(takimlar[count]);
                    }
                    else
                    {
                        count--;
                        break;
                    }
                    break;
                case 3:
                    if (listCgrubu.Items.Count < 4)
                    {
                        listCgrubu.Items.Add(takimlar[count]);
                    }
                    else
                    {
                        count--;
                        break;
                    }
                    break;
                case 4:
                    if (listDgrubu.Items.Count < 4)
                    {
                        listDgrubu.Items.Add(takimlar[count]);
                    }
                    else
                    {
                        count--;
                        break;
                    }
                    break;
                default:
                    break;
            }

            count++;

            if (count > 15)
            {
                timer.Stop();
                sw.Stop();
                Text = tickCount.ToString();
                Text = sw.ElapsedMilliseconds.ToString();
            }
        }

        Stopwatch sw = new Stopwatch();
        private void btnKura_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show
                (
                    "Emin Misin?",
                    "Onay Ekranı",
                    MessageBoxButtons.OKCancel
                );

            if (result == DialogResult.OK)
            {
                Temizle();
                timer.Start();
                sw.Restart();
            }
            else
            {
                MessageBox.Show("Onay Verilmedi");
            }
        }

        private void btnKura2_Click(object sender, EventArgs e)
        {
            sw.Restart();
            Temizle();

            List<string> geciciList = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int index = rnd.Next(0, takimlar.Count);
                    geciciList.Add(takimlar[index]);
                    takimlar.RemoveAt(index);
                }

                string takim = geciciList[rnd.Next(0, geciciList.Count)];
                listAgrubu.Items.Add(takim);
                geciciList.Remove(takim);

                takim = geciciList[rnd.Next(0, geciciList.Count)];
                listBgrubu.Items.Add(takim);
                geciciList.Remove(takim);

                takim = geciciList[rnd.Next(0, geciciList.Count)];
                listCgrubu.Items.Add(takim);
                geciciList.Remove(takim);

                takim = geciciList[rnd.Next(0, geciciList.Count)];
                listDgrubu.Items.Add(takim);
                geciciList.Remove(takim);
            }
            sw.Stop();
            Text = sw.ElapsedMilliseconds.ToString();
            TakimOlustur();
        }

        void Temizle()
        {
            listAgrubu.Items.Clear();
            listBgrubu.Items.Clear();
            listCgrubu.Items.Clear();
            listDgrubu.Items.Clear();
            count = 0;
            tickCount = 0;
        }

        void TakimOlustur()
        {
            takimlar.Add("Barcelona");
            takimlar.Add("Real Madrid");
            takimlar.Add("PSG");
            takimlar.Add("Monaco");
            takimlar.Add("Lyon");
            takimlar.Add("Bayern Munih");
            takimlar.Add("Liverpool");
            takimlar.Add("Galatasaray");
            takimlar.Add("Juventus");
            takimlar.Add("Milan");
            takimlar.Add("Inter");
            takimlar.Add("Porto");
            takimlar.Add("Beşiktaş");
            takimlar.Add("Chelsea");
            takimlar.Add("B. Dortmund");
            takimlar.Add("Napoli");
        }

        private void btnKura3_Click(object sender, EventArgs e)
        {
            Temizle();

            sw.Restart();
            for (int i = 0; i < 16; i++)
            {
                int indexGrup = rnd.Next(1, 5);

                switch (indexGrup)
                {
                    case 1:
                        if (listAgrubu.Items.Count < 4)
                        {
                            listAgrubu.Items.Add(takimlar[i]);
                        }
                        else
                        {
                            i--;
                            break;
                        }
                        break;
                    case 2:
                        if (listBgrubu.Items.Count < 4)
                        {
                            listBgrubu.Items.Add(takimlar[i]);
                        }
                        else
                        {
                            i--;
                            break;
                        }
                        break;
                    case 3:
                        if (listCgrubu.Items.Count < 4)
                        {
                            listCgrubu.Items.Add(takimlar[i]);
                        }
                        else
                        {
                            i--;
                            break;
                        }
                        break;
                    case 4:
                        if (listDgrubu.Items.Count < 4)
                        {
                            listDgrubu.Items.Add(takimlar[i]);
                        }
                        else
                        {
                            i--;
                            break;
                        }
                        break;
                    default:
                        break;
                }
            }

            sw.Stop();
            Text = sw.ElapsedMilliseconds.ToString();
        }
    }
}
