namespace AppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double preco_gasolina = Convert.ToDouble(gasolina.Text);
            double preco_etanol = Convert.ToDouble(etanol.Text);
            string msg = "";

            if(preco_etanol > (preco_gasolina * 0.70)){
                msg = "Compensa a gasolina";
            }
            else
            {
                msg = "Compensa o etanol";
            }
            DisplayAlertAsync("Resultado:", msg, "OK");
        }
    }
}
