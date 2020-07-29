using CEC.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GetEncodes.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _GetBytes;

        public string GetBytes
        {
            get { return _GetBytes; }
            set
            {
                _GetBytes = value;
                Notify("GetBytes");
            }
        }
        private string _ResultBytes;

        public string ResultBytes
        {
            get { return _ResultBytes; }
            set
            {
                _ResultBytes = value;
                Notify("ResultBytes");
            }
        }
        private string _GetID;

        public string GetID
        {
            get { return _GetID; }
            set
            {
                _GetID = value;
                Notify("GetID");
            }
        }
        private string _GetSHA;

        public string GetSHA
        {
            get { return _GetSHA; }
            set
            {
                _GetSHA = value;
                Notify("GetSHA");
            }
        }

        public ICommand GetIDCommand => new Command<string>(async (strParam) => GetIDAsync(strParam));

        private void GetIDAsync(string strParam)
        {
            GetID = Guid.NewGuid().ToString();
        }


    }
}
