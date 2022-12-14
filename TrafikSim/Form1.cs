namespace TrafikSim 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat = 2455;
        int c = 0;
        int krmz = 0;
        int sari = 0;
        int ysl = 0;
        int kysl = 0;
        int ykrmz = 0;
        int kkrmz = 0;
        int yayayysl = 0;
        int yayakrmz = 0;
        int krmz2 = 0;
        int siyah = 1;
        int c1 = 0;
        int krmz1 = 0;
        int sari1 = 0;
        int ysl1 = 0;
        int kysl1 = 0;
        int ykrmz1 = 0;
        int kkrmz1 = 0;
        int yayayysl1 = 0;
        int yayakrmz1 = 0;
        int dur = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;

        }

        private void FullRed()
        {
            l1.BackColor = Color.Red;
            l2.BackColor = Color.Red;
            l3.BackColor = Color.Red;
            l4.BackColor = Color.Red;
            k1.BackColor = Color.Red;
            k2.BackColor = Color.Red;
            k3.BackColor = Color.Red;
            k4.BackColor = Color.Red;
            y1.BackColor = Color.Red;
            y2.BackColor = Color.Red;
            y3.BackColor = Color.Red;
            y4.BackColor = Color.Red;
        }

        private void FullBlack()
        {
            l1.BackColor = Color.Black;
            l2.BackColor = Color.Black;
            l3.BackColor = Color.Black;
            l4.BackColor = Color.Black;
            k1.BackColor = Color.Black;
            k2.BackColor = Color.Black;
            k3.BackColor = Color.Black;
            k4.BackColor = Color.Black;
            y1.BackColor = Color.Black;
            y2.BackColor = Color.Black;
            y3.BackColor = Color.Black;
            y4.BackColor = Color.Black;
        }
        private void YayaGreen()
        {
            y1.BackColor = Color.Green;
            y2.BackColor = Color.Green;
            y3.BackColor = Color.Green;
            y4.BackColor = Color.Green;
        }

        private  void YayaRed()
        {
            y1.BackColor = Color.Red;
            y2.BackColor = Color.Red;
            y3.BackColor = Color.Red;
            y4.BackColor = Color.Red;
        }
        private void Yol1veYol3Yellow()
        {
            l1.BackColor = Color.Yellow;
            l3.BackColor = Color.Yellow;
            k1.BackColor = Color.Yellow;
            k3.BackColor = Color.Yellow;
        }

        private void L1VeL3Green()
        {
            l1.BackColor = Color.Green;
            l3.BackColor = Color.Green;
        }

        private void L1veL3Red()
        {
            k1.BackColor = Color.Red;
            k3.BackColor = Color.Red;
        }

        private void K1VeK3Green()
        {
            k1.BackColor = Color.Green;
            k3.BackColor = Color.Green;
        }

        private void K1VeK3Red()
        {
            k1.BackColor = Color.Red;
            k3.BackColor = Color.Red;
        }
        private void Yol2veYol4Yellow()
        {
            l2.BackColor = Color.Yellow;
            l4.BackColor = Color.Yellow;
            k2.BackColor = Color.Yellow;
            k4.BackColor = Color.Yellow;
        }

        private void L2VeL4Green()
        {
            l2.BackColor = Color.Green;
            l4.BackColor = Color.Green;
        }

        private void L2veL4Red()
        {
            k2.BackColor = Color.Red;
            k4.BackColor = Color.Red;
        }

        private void K2VeK4Green()
        {
            k2.BackColor = Color.Green;
            k4.BackColor = Color.Green;
        }

        private void K2VeK4Red()
        {
            k2.BackColor = Color.Red;
            k4.BackColor = Color.Red;
        }
        private void Reset()
        {
            krmz = 0;
            sari = 0;
            ysl = 0;
            kysl = 0;
            ykrmz = 0;
            kkrmz = 0;
            yayayysl = 0;
            yayakrmz = 0;
            krmz1 = 0;
            sari1 = 0;
            ysl1 = 0;
            kysl1 = 0;
            ykrmz1 = 0;
            kkrmz1 = 0;
            yayayysl1 = 0;
            yayakrmz1 = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            saat++;
            label2.Text = saat.ToString();


            if (saat == 9600)
            {
                timer1.Stop();
            }
            if (c1 < 100)
            {
                if (402 < saat & saat < 2400)// Gece Trafik ýþýklarý
                {
                    if (siyah < 2)
                    {
                        // Tüm ýþýklar söndü
                        FullBlack();
                        siyah++;


                    }
                    if (siyah > 1 & krmz2 < 2)
                    {
                        FullRed();
                        krmz2++;

                    }
                    c1++;
                    siyah = 1;
                    krmz2 = 0;

                    if (saat == 2400)
                    {
                        c1 = 2000;
                    }


                }






            }
            if (c < 10000

                )
            {
                if (saat == 2400)
                {
                    if (dur < 2) // Saat Tam 6 ise tüm ýþýklar 2sn kýrmýzý yanar
                    {
                        FullRed();
                        dur++;

                    }

                }

                if (0 < saat & saat < 400 || 2400 < saat & saat < 9600)// Gündüz Trafik ýþýklarý
                {
                    //YOL 1 VE YOL3 IÞIKLARI
                    if (krmz < 2)
                    {
                        FullRed();
                        krmz++;

                    }
                    if (krmz > 1 & sari < 2)
                    {
                        Yol1veYol3Yellow();
                        sari = sari + 1;
                    }

                    if (sari > 1 & ysl < 5)
                    {
                        L1VeL3Green();
                        ysl = ysl + 1;
                    }
                    if (sari > 1 & kysl < 7)
                    {
                        K1VeK3Green();
                        kysl = kysl + 1;
                    }
                    if (ysl > 4 & ykrmz < 2)
                    {
                        L1veL3Red();
                        ykrmz = ykrmz + 1;

                    }
                    if (kysl > 6 & kkrmz < 2)
                    {
                        K1VeK3Red();
                        kkrmz = kkrmz + 1;

                    }
                    if (kkrmz > 1 & yayayysl < 2)
                    {
                        //YAYA IÞIKLARI
                        YayaGreen();
                        yayayysl++;
                    }
                    if (yayayysl > 1 & yayakrmz < 2)
                    {
                        YayaRed();
                        yayakrmz++;
                    }

                    //YOL2 VE YOL-4

                    if (yayakrmz > 1 & krmz1 < 2)
                    {
                        FullRed();
                        krmz1++;

                    }
                    if (krmz1 > 1 & sari1 < 2)
                    {
                        Yol2veYol4Yellow();
                        sari1++;
                    }

                    if (sari1 > 1 & ysl1 < 5)
                    {
                        L2VeL4Green();
                        ysl1++;
                    }
                    if (sari1 > 1 & kysl1 < 7)
                    {
                        K2VeK4Green();
                        kysl1++;
                    }
                    if (ysl1 > 4 & ykrmz1 < 2)
                    {
                        L2veL4Red();
                        ykrmz1++;

                    }
                    if (kysl1 > 6 & kkrmz1 < 2)
                    {
                        K2VeK4Red();
                        kkrmz1++;

                    }
                    if (kkrmz1 > 1 & yayayysl1 < 2)
                    {
                        //YAYA IÞIKLARI
                        YayaGreen();
                        yayayysl1++;
                    }
                    if (yayayysl1 > 1 & yayakrmz1 < 2)
                    {
                        YayaRed();
                        yayakrmz1++;
                        c++;
                        Reset();
                    }
                    if (saat == 9600)
                    {
                        c = 10000;
                    }



                }







            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}