using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public abstract class MasterWindow : IMasterWindow
    {
        private bool _Setwindowopen;
        public bool Setwindowopen
        {
            get => _Setwindowopen;
            set => _Setwindowopen = value;
        }

        private bool _Setwindowfrosted;
        public bool Setwindowfrosted
        {
            set
            {
                _Setwindowfrosted = value;
            }

            get => _Setwindowfrosted;
        }
        public EWindowMaterial Setwindowmaterial
        {
            get => Setwindowmaterial;
            set => Setwindowmaterial = value;
        }
        public EColor Setcolor
        {
            get => Setcolor;
            set => Setcolor = value;
        }

        public EWindowCasement Setwindowcasement { get; set; }
        public abstract EWindowType GetWindowType();
        
    }
}