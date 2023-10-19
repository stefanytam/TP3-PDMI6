using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticaRastreamento.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LogisticaRastreamento.ViewModels
{
    public class PacoteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private PacoteModel _pacote;
        public PacoteModel Pacote
        {
            get { return _pacote; }
            set
            {
                _pacote = value;
                OnPropertyChanged();
            }
        }

        public async Task BuscarInformacoesPacoteAsync(string codigoRastreamento)
        {

        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
