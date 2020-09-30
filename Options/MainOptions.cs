using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyReaction_NoBinding
{
    public class MainOptions :  PChange, IOptionsBase
    {
        internal Action<bool> OnVisUpdate;

        private bool _visible;
        public bool IsVisible { get => _visible; set { _visible = value; OnPropertyChanged(); OnVisUpdate?.Invoke(_visible); } }
    }
}
