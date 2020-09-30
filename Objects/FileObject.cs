using PropertyReaction_NoBinding.Options;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PropertyReaction_NoBinding.Objects
{
    public class FileObject : PChange
    {
        private MainViewModel vm;

        private bool _isVisible;

        public bool IsVisible
        {
            get { return _isVisible || vm.Options.IsVisible; }
            set { _isVisible = value; OnPropertyChanged(); }
        }

        public ObservableCollection<IndividualObject> Objects { get; set; } = new ObservableCollection<IndividualObject>();

        public FileOptions Options { get; private set; }


        public TypeObject TypeObject { get; private set; }

        public FileObject(MainOptions options)
        {
        }

        public FileObject(MainViewModel mainViewModel)
        {
            this.vm = mainViewModel;
            Options = new FileOptions(vm);

            for (int i = 0; i < 4; i++)
            {
                Objects.Add(new IndividualObject());
            }
          
        }
    }
}
