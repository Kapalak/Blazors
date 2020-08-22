using BlazorMobile.Common;
using kapalak.Common.Interfaces;
using kapalak.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace kapalak.Services
{
    public class XamarinBridge : IXamarinBridge
    {
        public async Task<List<string>> DisplayAlert(string title, string msg, string cancel)
        {
            await App.Current.MainPage.DisplayAlert(title, msg, cancel);

            List<string> result = new List<string>()
            {
                "Lorem",
                "Ipsum",
                "Dolorem",
            };

            return result;
        }
    }
}
