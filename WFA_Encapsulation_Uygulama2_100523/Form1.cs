namespace WFA_Encapsulation_Uygulama2_100523
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Bilgiler bilgiler = new Bilgiler();

                bilgiler.Ýsim = txtIsim.Text;
                bilgiler.Soyisim = txtSoyisim.Text;
                bilgiler.TC = txtTC.Text;
                bilgiler.Email = txtEmail.Text;
                string cinsiyet = rbKadin.Checked ? "Kadýn" : "Erkek";

                bilgiler.Cinsiyet = cinsiyet;

                MessageBox.Show("Bilgiler kaydedildi.");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}