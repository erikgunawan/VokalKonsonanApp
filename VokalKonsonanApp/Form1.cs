using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VokalKonsonanApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setLabel("");
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            setLabel("");

            String statement = txtStatement.Text;
            
            lblVokal.Text = printVC(statement,'v');
            lblKonsonan.Text = printVC(statement,'c');
            lblJumlahVokal.Text = Convert.ToString(countVC(statement, 'v'));
            lblJumlahKonsonan.Text = Convert.ToString(countVC(statement, 'c'));

            int jumlahTotal = countVC(statement, 'v') + countVC(statement, 'c');
            lblJumlahTotal.Text = Convert.ToString(jumlahTotal);
        }

        private Boolean checkVC(char huruf)
        {
            if ((huruf >= 65 && huruf <= 90) || (huruf >= 97 && huruf <= 122))
                return true;
            else 
                return false;
        }

        private int getVC(char huruf)
        {
            int vc;
            if (huruf == 'A' || huruf == 'E' || huruf == 'I' || huruf == 'O' || huruf == 'U'
                    || huruf == 'a' || huruf == 'e' || huruf == 'i' || huruf == 'o' || huruf == 'u')
                vc = 1;
            else
                vc = 0;

            return vc;
        }
        
        private int countVC(String text, char type)
        {
            int v = 0; 
            int c = 0;
            for (int i = 0; i < text.Count(); i++)
            {
                if (checkVC(text.ElementAt(i)) == true)
                {
                    if (getVC(text.ElementAt(i)) == 1)
                        v++;
                    else
                        c++;
                }
            }

            if (type == 'v')
                return v;
            else if (type == 'c')
                return c;

            return 0;
        }

        private String printVC(String text, char type)
        {
            String vokal = "";
            String konsonan = "";
            for (int i = 0; i < text.Count(); i++)
            {
                if (checkVC(text.ElementAt(i)) == true)
                {
                    if (getVC(text.ElementAt(i)) == 1)
                        vokal += text.ElementAt(i) + ", ";
                    else
                        konsonan += text.ElementAt(i) + ", ";
                }
            }

            if (vokal.Count() >= 3)
                vokal = vokal.Substring(0, vokal.Count() - 2);
            else
                vokal = "Tidak ada huruf vokal";


            if (konsonan.Count() >= 3)
                konsonan = konsonan.Substring(0, konsonan.Count() - 2);
            else
                konsonan = "Tidak ada huruf konsonan";

            if (type == 'v')
                return vokal;
            else if (type == 'c')
                return konsonan;
            
            return "";
        }

        private void setLabel(String s)
        {
            lblVokal.Text = s;
            lblKonsonan.Text = s;
            lblJumlahVokal.Text = s;
            lblJumlahKonsonan.Text = s;
            lblJumlahTotal.Text = s;
        }
    }
}
