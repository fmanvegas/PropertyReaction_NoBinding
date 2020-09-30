using PropertyReaction_NoBinding.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyReaction_NoBinding
{
    public class MainViewModel : PChange
    {
        private MainOptions mainOptions=new MainOptions();

        public MainOptions Options
        {
            get { return mainOptions; }
            set { mainOptions = value; OnPropertyChanged(); }
        }

        public FileObject FileObject { get => _file; set { _file = value; OnPropertyChanged(); } }
        private FileObject _file;

        public ObservableCollection<FileObject> Files { get; set; } = new ObservableCollection<FileObject>();

        public MainViewModel()
        {
            FileObject = new FileObject(this);

            for (int i = 0; i < 2; i++)
            {
                Files.Add(new FileObject(this));
            }
        }
    }
}
