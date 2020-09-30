using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PropertyReaction_NoBinding
{
    public interface IOptionsBase
    {
        bool IsVisible { get; set; }
    }

    public class BaseOptions : PChange
    {
        public Brush Foreground { get => _color; set { _color = value; OnPropertyChanged(); } }
        private Brush _color = Brushes.Blue;

        private Color _myColor = Colors.Blue;

        public Color MyColor
        {
            get { return _myColor; }
            set { _myColor = value; OnPropertyChanged(); }
        }

    }

    public class PChange:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }

}
