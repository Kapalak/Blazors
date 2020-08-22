using BlazorMobile.Common;
using BlazorMobile.Components;
using kapalak.Helpers;
using BlazorMobile.Services;

namespace kapalak
{
	public partial class App : BlazorApplication
    {
        public App()
        {
            InitializeComponent();

            ServiceRegistrationHelper.RegisterServices();

            WebApplicationFactory.SetHttpPort(8888);

            MainPage = new MainPage();
        }
    }
}
