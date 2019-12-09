using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public abstract class MasterWindow : IMasterWindow
    {
        private bool _windowOpen = true;
        public bool windowOpen
        {
            get => _windowOpen;
            set => _windowOpen = value;
        }

        private bool _windowFrosted = false;
        public bool windowFrosted
        {
            get => _windowFrosted;
            set => _windowFrosted = value;

        }


        private EWindowMaterial _windowMaterial = EWindowMaterial.WoodOak;
        public EWindowMaterial windowMaterial
        {
            get => _windowMaterial;
            set => _windowMaterial = value;
        }

        private EColor _color = EColor.ColorWhite;
        public EColor color
        {
            get => _color;
            set => _color = value;
        }

        public EWindowCasement windowCasement
        {
            get;
            set;
        }
        public abstract EWindowType GetWindowType();
        
    }
}