using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PropertyReaction_NoBinding.Options
{
    public class FileOptions : BaseOptions
    {
        private MainOptions options;

        private bool isVisible;
        private MainViewModel vm;

        public bool IsVisible
        {
            get { return isVisible || options.IsVisible; }
            set { isVisible = value; OnPropertyChanged(); }
        }

        public FileOptions(MainOptions options)
        {
            this.options = options;
        }

        public FileOptions(MainViewModel vm)
        {
            options = vm.Options;
            options.OnVisUpdate += (a) => {
                OnPropertyChanged("IsVisible");
            };
            Foreground = Brushes.Red;
        }
    }
}
