namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Koe koe = new Koe(215, "koe");
            if (checkKoe.Checked)
            {
                MessageBox.Show(koe.Zegt() + "" + koe.Weegt() + "kg" + koe.Geluid());
            }
            Slang slang = new Slang(18, "slang");
            if (checkKoe.Checked)
            {
                MessageBox.Show(slang.Zegt() + "" + slang.Weegt() + "kg" + slang.Geluid());
            }
            Varken varken = new Varken(168, "Varken");
            if (checkVarken.Checked)
            {
                MessageBox.Show(varken.Zegt() + "" + varken.Weegt() + "kg" + varken.Geluid());
            }
        }
    }
}