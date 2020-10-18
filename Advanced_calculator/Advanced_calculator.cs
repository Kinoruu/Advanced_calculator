using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float a = 0;
        float b = 0;
        float wynik = 0;
        float ans = 0;

        int silnia(int a)
        {
            if (a < 2) return 1;
            return a * silnia(a - 1);
        }

        int potęga(int a, int b)
        {
            if (b == 0) return 1;
            return a * potęga(a, --b);
        }

        private void suma_Click(object sender, EventArgs e)
        {
            try
            {
                a = (float)Convert.ToDouble(textBox_a.Text);
                b = (float)Convert.ToDouble(textBox_b.Text);
                wynik = a + b;
                textBox_wynik.Text = wynik.ToString();
                ans = wynik;
            }
            catch (Exception) { }
        }

        private void różnica_Click(object sender, EventArgs e)
        {
            try
            {
                a = (float)Convert.ToDouble(textBox_a.Text);
                b = (float)Convert.ToDouble(textBox_b.Text);
                wynik = a - b;
                textBox_wynik.Text = wynik.ToString();
                ans = wynik;
            }
            catch (Exception) { }
        }

        private void iloczyn_Click(object sender, EventArgs e)
        {
            try
            {
                a = (float)Convert.ToDouble(textBox_a.Text);
                b = (float)Convert.ToDouble(textBox_b.Text);
                wynik = a * b;
                textBox_wynik.Text = wynik.ToString();
                ans = wynik;
            }
            catch (Exception) { }
        }

        private void iloraz_Click(object sender, EventArgs e)
        {
            try
            {
                a = (float)Convert.ToDouble(textBox_a.Text);
                b = (float)Convert.ToDouble(textBox_b.Text);
                if (b == 0)
                {
                    MessageBox.Show("Nie można dzielić przez 0!");
                }
                else
                {
                    wynik = a / b;
                    textBox_wynik.Text = wynik.ToString();
                    ans = wynik;
                }
            }
            catch (Exception) { }
        }

        private void suma_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("suma = a + b", button_suma);
        }

        private void różnica_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("różnica = a - b", button_różnica);
        }

        private void iloczyn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("iloczyn = a x b", button_iloczyn);
        }

        private void iloraz_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("iloraz = a / b", button_iloraz);
        }

        private void button_ans_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("użyj wyniku jako a", button_ans);
        }

        private void button_ans_Click(object sender, EventArgs e)
        {
            //a = (float)Convert.ToDouble(ans);
            //b = (float)Convert.ToDouble("");
        }

        private void procent_Click(object sender, EventArgs e)
        {
            try
            {
                a = (float)Convert.ToDouble(textBox_a.Text);
                b = (float)Convert.ToDouble(textBox_b.Text);
                wynik = a * b / 100;
                textBox_wynik.Text = wynik.ToString() + "%";
                ans = wynik;   
            }
            catch (Exception) { }
        }

        private void procent_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("oblicza a procent z liczby b", button_procent);
        }

        private void silnia_Click(object sender, EventArgs e)
        {
            try
            {
                a = (float)Convert.ToDouble(textBox_a.Text);
                int x = Convert.ToInt32(textBox_a.Text);
                if((a % 1 == 0) && (a >= 0))
                {
                    wynik = Convert.ToSingle(silnia(x));
                    textBox_wynik.Text = wynik.ToString();
                    ans = wynik;
                }
                else
                {
                    MessageBox.Show("Silnię można obliczyć tylko z liczby naturalnej i 0");
                }
            }
            catch (Exception) { }
        }

        private void silnia_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("silnia z liczby a", button_procent);
        }

        private void button_potęga_Click(object sender, EventArgs e)
        {
            try
            {
                b = (float)Convert.ToDouble(textBox_a.Text);
                int x = Convert.ToInt32(textBox_a.Text);
                int y = Convert.ToInt32(textBox_b.Text);
                if (b % 1 == 0)
                {
                    wynik = Convert.ToSingle(potęga(x, y));
                    textBox_wynik.Text = wynik.ToString();
                    ans = wynik;
                }
                else
                {
                    MessageBox.Show("Liczbę można podnieeść do liczby cakowitej ");
                }
            }
            catch (Exception) { }
        }
    }
}
