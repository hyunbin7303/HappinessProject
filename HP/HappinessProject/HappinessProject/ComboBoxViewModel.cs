using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappinessProject
{
    public class ComboBoxViewModel
    {
        public List<string> NameCollection { get; set; }
        public List<Brush> BrushCollection { get; set; }
        public ComboBoxViewModel()
        {
            NameCollection = new List<string>()
            {
                "Kevin",
                "Park",
                "NAME",
                "CHECKING",

            };
            BrushCollection = new List<Brush>()
            {
                Brushes.Red,
                Brushes.Orange,
                Brushes.Green
            };
        }
    }
}
