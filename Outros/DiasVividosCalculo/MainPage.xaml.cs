namespace DiasVividosCalculo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcularDiasOnClicked(object sender, EventArgs e)
        {
            int diasvividos = 0;

            diasvividos = int.Parse(etrIdade.Text) * 365;

            etrDiasVividos.Text = diasvividos.ToString();

            DisplayAlert("APP DIAS VIVIDOS",
                $"Você já viveu {diasvividos} dias!",
                "Ok");
        }
        private void btnLimparOnClicked(object sender, EventArgs e)
        {
            etrIdade.Text = "";
            etrDiasVividos.Text = "";
        }

    }

}
