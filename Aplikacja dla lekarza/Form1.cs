using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_dla_lekarza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Kolejka
        {
            int sizeArr;
            int lastEl;
            int firstEl;
            string[] imie, badanie, data;
            int whichEl = 0;

            public Kolejka(int rozmiar)
            {
                sizeArr = rozmiar;
                firstEl = lastEl = 0;
                imie = new string[rozmiar];
                badanie = new string[rozmiar];
                data = new string[rozmiar];
            }

            public void WhichElPlus()
            {
                whichEl++;
            }
            public void WhichElMinus()
            {
                whichEl--;
            }
            public int GetWhichEl()
            {
                return whichEl;
            }

            public bool IfEmpty()
            {
                if (lastEl == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void ToFile()
            {
                TextWriter sw = new StreamWriter("kolejka.txt");
                for(int i=0; i < sizeArr; i++)
                {
                    sw.Write(imie[i]);
                    sw.WriteLine("");
                    sw.Write(badanie[i]);
                    sw.WriteLine("");
                    sw.Write(data[i]);
                    sw.WriteLine("");
                }
                sw.Close();
            }
            public void SaveToQ(string a, string b, string c)
            {
                imie[lastEl] = a;
                badanie[lastEl] = b;
                data[lastEl] = c;
                lastEl++;
            }
            public void InsertToQ(string a, string b, string c)
            {
                imie[firstEl + whichEl] = a;
                badanie[firstEl + whichEl] = b;
                data[firstEl + whichEl] = c;
            }
            public void RemoveFromQ()
            {
                if (firstEl + 1 <= sizeArr)
                {
                    imie[firstEl] = "";
                    badanie[firstEl] = "";
                    data[firstEl] = "";
                    firstEl++;
                    lastEl--;
                }
                else
                {
                    imie[firstEl] = "";
                    badanie[firstEl] = "";
                    data[firstEl] = "";
                    firstEl = whichEl = lastEl = 0;
                }
                
            }
            public string GetImie(int a)
            {
                if (whichEl - 1 >= 0)
                {
                    if (a == 0)
                    {
                        return imie[firstEl + whichEl - 1];
                    }
                    else if (a == 1)
                    {
                        return imie[firstEl + whichEl];
                    }
                    else if (a == 2)
                    {
                        return imie[firstEl + whichEl + 1];
                    }
                    else
                    {
                        return "brak wartosci funkcji";
                    }
                }
                else
                {
                    if (a == 0)
                    {
                        return "Brak danych";
                    }
                    else if (a == 1)
                    {
                        return imie[firstEl + whichEl];
                    }
                    else if (a == 2)
                    {
                        return imie[firstEl + whichEl + 1];
                    }
                    else
                    {
                        return "brak wartosci funkcji";
                    }
                }
            }
            public string GetBadanie(int a)
            {
                if (whichEl - 1 >= 0)
                {
                    if (a == 0)
                    {
                        return badanie[firstEl + whichEl - 1];
                    }
                    else if (a == 1)
                    {
                        return badanie[firstEl + whichEl];
                    }
                    else if (a == 2)
                    {
                        return badanie[firstEl + whichEl + 1];
                    }
                    else
                    {
                        return "brak wartosci funkcji";
                    }
                }
                else
                {
                    if (a == 0)
                    {
                        return "Brak danych";
                    }
                    else if (a == 1)
                    {
                        return badanie[firstEl + whichEl];
                    }
                    else if (a == 2)
                    {
                        return badanie[firstEl + whichEl + 1];
                    }
                    else
                    {
                        return "brak wartosci funkcji";
                    }
                }
            }
            public string GetData(int a)
            {
                if (whichEl - 1 >= 0)
                {
                    if (a == 0)
                    {
                        return data[firstEl + whichEl - 1];
                    }
                    else if (a == 1)
                    {
                        return data[firstEl + whichEl];
                    }
                    else if (a == 2)
                    {
                        return data[firstEl + whichEl + 1];
                    }
                    else
                    {
                        return "brak wartosci funkcji";
                    }
                }
                else
                {
                    if (a == 0)
                    {
                        return "Brak danych";
                    }
                    else if (a == 1)
                    {
                        return data[firstEl + whichEl];
                    }
                    else if (a == 2)
                    {
                        return data[firstEl + whichEl + 1];
                    }
                    else
                    {
                        return "brak wartosci funkcji";
                    }
                }
            }
            public int GetLastEl()
            {
                return lastEl;
            }

        }
        Kolejka kolejka = new Kolejka(100);
        private void dataTimer_Tick(object sender, EventArgs e)
        { 
            dataLabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void godzinaTimer_Tick(object sender, EventArgs e)
        {
            godzinaLabel.Text = DateTime.Now.ToString("HH:mm");
        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            kolejka.RemoveFromQ();
            Czytanie();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            kolejka.SaveToQ(imieTextBox.Text,badanieTextBox.Text,dataBadaniaDateTime.Value.ToString("dd.MM.yyyy"));
            Czytanie();
            kolejka.ToFile();

        }

        void Czytanie()
        {
            string x = kolejka.GetImie(1);
            string y = kolejka.GetBadanie(1);
            string z = kolejka.GetData(1);
            currimieLabel.Text = x;
            currbadanieLabel.Text = y;
            currdataLabel.Text = z;
            string a = kolejka.GetImie(0);
            string b = kolejka.GetBadanie(0);
            string c = kolejka.GetData(0);
            previmieLabel.Text = a;
            prevbadanieLabel.Text = b;
            prevdataLabel.Text = c;
            string h = kolejka.GetImie(2);
            string hh = kolejka.GetBadanie(2);
            string hhh = kolejka.GetData(2);
            nextimieLabel.Text = h;
            nextbadanieLabel.Text = hh;
            nextdataLabel.Text = hhh;
            string dzisiejszaData = DateTime.Now.ToString("dd.MM.yyyy");
            var days = (Convert.ToDateTime(z) - Convert.ToDateTime(dzisiejszaData)).TotalDays;
            if (days==0)
            {
                badaniezaLabel.Text = "Badanie dziś";
                badaniezaLabel.ForeColor = Color.Red;
            }else if (days >= 1){
                if(days == 1)
                {
                    badaniezaLabel.Text = "Badanie za " + days + " dzień";
                    badaniezaLabel.ForeColor = Color.Black;
                }
                else
                {
                    badaniezaLabel.Text = "Badanie za " + days + " dni";
                    badaniezaLabel.ForeColor = Color.Black;
                }
            }
            else if (days <= 1){
                if (days == -1)
                {
                    badaniezaLabel.Text = "Badanie było " + days*-1 + " dzień temu";
                    badaniezaLabel.ForeColor = Color.Black;
                }
                else
                {
                    badaniezaLabel.Text = "Badanie było " + days*-1 + " dni temu";
                    badaniezaLabel.ForeColor = Color.Black;
                }
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (kolejka.GetWhichEl() - 1 >= 0)
            {
                kolejka.WhichElMinus();
                Czytanie();
            }

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (kolejka.GetWhichEl() + 1 < kolejka.GetLastEl())
            {
                kolejka.WhichElPlus();
                Czytanie();
            }
        }

        private void wstawButton_Click(object sender, EventArgs e)
        {
            kolejka.InsertToQ(imieTextBox.Text, badanieTextBox.Text, dataBadaniaDateTime.Value.ToString("dd.MM.yyyy"));
            Czytanie();
            kolejka.ToFile();
        }
    }
}
