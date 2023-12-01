namespace U4_Practica_2
{
    public partial class Form1 : Form
    {
        int CantidadHamburguesas;
        int CantidadHotdog;
        int CantidadSandwich;
        int CantidadTe;
        int CantidadRefresco;
        int CantidadPapas;

        double TotalVenta;
        double CostoHamburguesa;
        double CostoHotdog;
        double CostoSandwich;
        double CostoTe;
        double CostoRefresco;
        double CostoPapas;

        double Hamburguesa = 20.5;
        double Hotdog = 19.25;
        double Sandwich = 17.5;
        double Papas = 4.5;
        double Refresco = 4;
        double Te = 5;


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Clear();
            if (radioButton1.Checked == true)
            {
                CantidadHamburguesas = 1;
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotdog = 0;
                CantidadSandwich = 0;
                CantidadTe = 0;

                txtHamburguesa.Text = CantidadHamburguesas.ToString();
                txtRefresco.Text = CantidadRefresco.ToString();
                txtPapas.Text = CantidadPapas.ToString();

                txtHamburguesa.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;

                txtHotdog.Enabled = false;
                txtSandwich.Enabled = false;
                txtTe.Enabled = false;

                txtHotdog.Clear();
                txtSandwich.Clear();
                txtTe.Clear();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Clear();
            if (radioButton2.Checked == true)
            {
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotdog = 1;
                CantidadSandwich = 0;
                CantidadHamburguesas = 0;
                CantidadTe = 0;

                txtHotdog.Text = CantidadHotdog.ToString();
                txtRefresco.Text = CantidadRefresco.ToString();
                txtPapas.Text = CantidadPapas.ToString();

                txtHotdog.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;

                txtHamburguesa.Enabled = false;
                txtSandwich.Enabled = false;
                txtTe.Enabled = false;

                txtHamburguesa.Clear();
                txtSandwich.Clear();
                txtTe.Clear();
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Clear();
            if (radioButton3.Checked == true)
            {
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadSandwich = 1;
                CantidadHamburguesas = 0;
                CantidadHotdog = 0;
                CantidadTe = 0;

                txtSandwich.Text = CantidadSandwich.ToString();
                txtRefresco.Text = CantidadRefresco.ToString();
                txtPapas.Text = CantidadPapas.ToString();

                txtSandwich.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;

                txtHamburguesa.Enabled = false;
                txtHotdog.Enabled = false;
                txtTe.Enabled = false;

                txtHamburguesa.Clear();
                txtHotdog.Clear();
                txtTe.Clear();
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Clear();

            if (radioButton4.Checked == true)
            {
                txtHamburguesa.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;
                txtHotdog.Enabled = true;
                txtSandwich.Enabled = true;
                txtTe.Enabled = true;

                txtHamburguesa.Text = " ";
                txtHotdog.Text = " ";
                txtPapas.Text = "";
                txtHotdog.Text = "";
                txtSandwich.Text = "";
                txtTe.Text = "";

                double CantidadHamburguesas = double.Parse(txtHamburguesa.Text);
                double CantidadRefresco = double.Parse(txtHotdog.Text);
                double CantidadPapas = double.Parse(txtPapas.Text);
                double CantidadHotdog = double.Parse(txtHotdog.Text);
                double CantidadSandwich = double.Parse(txtSandwich.Text);
                double CantidadTe = double.Parse(txtTe.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CostoHamburguesa = CantidadHamburguesas * Hamburguesa;
            CostoHotdog = CantidadHotdog * Hotdog;
            CostoSandwich = CantidadSandwich * Sandwich;
            CostoTe = CantidadTe * Te;
            CostoRefresco = CantidadRefresco * Refresco;
            CostoPapas = CantidadPapas * Papas;
            TotalVenta = CostoHamburguesa + CostoHotdog + CostoSandwich + CostoTe + CostoRefresco + CostoPapas;
            txtTotal.Text = TotalVenta.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}