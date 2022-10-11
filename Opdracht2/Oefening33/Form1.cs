using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Drawing;

namespace Oefening33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (txt_euro.Text != "")
            {
                double EuroToUSD = double.Parse(txt_euro.Text) * 0.98;
                txt_usd.Text = EuroToUSD.ToString();

            }

            else if (txt_frank.Text != "")
            {
                double FrankToUSD = double.Parse(txt_frank.Text) * 1.01;
                txt_usd.Text = FrankToUSD.ToString();


            }

            else if (txt_pounds.Text != "")
            {
                double PoundToUSD = double.Parse(txt_pounds.Text) * 1.11;
                txt_usd.Text = PoundToUSD.ToString();

            }


            else if (txt_rupees.Text != "")
            {
                double RupeesToUSD = double.Parse(txt_rupees.Text) * 0.01;
                txt_usd.Text = RupeesToUSD.ToString();

            }


            else if (txt_yen.Text != "")
            {
                double YenToUSD = double.Parse(txt_yen.Text) * 0.007;
                txt_usd.Text = YenToUSD.ToString();

            }

            if (txt_usd.Text != "")
            {

                USD dollar = new USD(double.Parse(txt_usd.Text));
                USD euro = new Euro(double.Parse(txt_usd.Text));
                USD franken = new Franken(double.Parse(txt_usd.Text));
                USD pounds = new Pounds(double.Parse(txt_usd.Text));
                USD yen = new Yen(double.Parse(txt_usd.Text));
                USD rupees = new Rupees(double.Parse(txt_usd.Text));

                txt_usd.Text = dollar.ToString();
                txt_euro.Text = euro.ToString();
                txt_frank.Text = franken.ToString();
                txt_pounds.Text = pounds.ToString();
                txt_yen.Text = yen.ToString();
                txt_rupees.Text = rupees.ToString();

            }
        }
    }
    }
