using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public abstract class MasterWindow : IMasterWindow
    {
        private bool _Setwindowopen = true;
        public bool Setwindowopen
        {
            get => _Setwindowopen;
            set => _Setwindowopen = value;
        }

        private bool _Setwindowfrosted = false;
        public bool Setwindowfrosted
        {
            set
            {
                _Setwindowfrosted = value;
            }

            get => _Setwindowfrosted;
        }


        private EWindowMaterial _Setwindowmaterial = EWindowMaterial.WoodOak;
        public EWindowMaterial Setwindowmaterial
        {
            get => _Setwindowmaterial;
            set => _Setwindowmaterial = value;
        }

        private EColor _Setcolor = EColor.ColorWhite;
        public EColor Setcolor
        {
            get => _Setcolor;
            set => _Setcolor = value;
        }

        public EWindowCasement Setwindowcasement { get; set; }
        public abstract EWindowType GetWindowType();
        
    }
}