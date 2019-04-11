using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace AsnycTesting
{
    public class AsyncTest
    {
        private bool isConnected = true;
        public void Connect(IPAddress addr)
        {
            if(addr == null)
            {
                throw new ArgumentNullException("address");
            }
            if(this.isConnected)
            {
                throw new InvalidOperationException("Already Connected.");
            }
            Thread.Sleep(3000);
            this.isConnected = true;
        }


    }
}

/*
            (this.DataContext as MainWindowViewModel).ShowMessageBox += delegate (object sender, EventArgs args)
            {
                MessageBox.Show(((MessageEventArgs)args).Message);
            };
 */

namespace League
{
    public class LeagueAPI
    {
    }

    public class Person : NotificationClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CityOfResidence { get; set; }
        public Profession Profession { get; set; }
    }
    public enum Profession
    {
        Default = -1,
        Doctor,
        SoftwareEngineer,
        Student,
        SportsPerson,
        Other
    }
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; set; }
    }

    public class PersonDB 
    {
    }
    public class Business : NotificationClass
    {
        PersonDB _dbContext = null;
        public Business()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            _dbContext = new PersonDB();
        }


    }
    public class NotificationClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public void OnProprtyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}