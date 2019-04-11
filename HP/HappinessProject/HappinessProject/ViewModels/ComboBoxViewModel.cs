using HappinessProject.Models;
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
        public List<User> userCollection { get; set; }
        DAL dal = new DAL();
        public ComboBoxViewModel()
        {
            NameCollection = new List<string>()
            {
                "asdf",
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
            Call_AllUserInfo();
        }

        public void Call_AllUserInfo()
        {
            //userCollection.Add()
            userCollection = dal.userDisplay().ToList();

        }
    }
}
