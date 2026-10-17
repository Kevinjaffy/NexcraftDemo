using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Input;

namespace NexcraftDemo
{
    public class CotizacionViewModel : INotifyPropertyChanged
    {
        
        private const decimal PrecioPorGramo = 2.50m;

        private string _gramos = "";
        private Color _acento = Colors.Orange;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Gramos
        {
            get => _gramos;
            set
            {
                _gramos = value;
                OnPropertyChanged(nameof(Gramos));
                OnPropertyChanged(nameof(Total));
            }
        }

        public string Total
        {
            get
            {
                if (decimal.TryParse(_gramos, NumberStyles.Number,
                                     CultureInfo.InvariantCulture, out var g))
                    return $"L {g * PrecioPorGramo:N2}";
                return "L 0.00";
            }
        }

        public Color Acento
        {
            get => _acento;
            set { _acento = value; OnPropertyChanged(nameof(Acento)); }
        }

        public ICommand CambiarAcentoCommand => new Command(() =>
            Acento = Acento == Colors.Orange ? Colors.Teal : Colors.Orange);

        private void OnPropertyChanged(string nombre) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
    }
}
