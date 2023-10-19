using LogisticaRastreamento.ViewModels;

namespace LogisticaRastreamento
{
    public partial class MainPage : ContentPage
    {
        public PacoteViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new PacoteViewModel();
            BindingContext = ViewModel;
        }

        private async void OnRastrearClicked(object sender, EventArgs e)
        {
            string codigoRastreamento = CodigoRastreamentoEntry.Text;
            await ViewModel.BuscarInformacoesPacoteAsync(codigoRastreamento);
            await Navigation.PushAsync(new ResultadosPage { BindingContext = ViewModel });
        }

    }
}
