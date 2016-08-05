using Acr.UserDialogs;
using FreshMvvm;
using FreshN1.PageModels;
using FreshN1.Services;
using Xamarin.Forms;

namespace FreshN1
{
    public class App : Application
    {
        public App()
        {
            this.SetupIoc();

            var contactList = FreshPageModelResolver.ResolvePageModel<ContactListPageModel>();
            var navContainer = new FreshNavigationContainer(contactList);

            this.MainPage = navContainer;
        }

        private void SetupIoc()
        {
            FreshIOC.Container.Register<IDataService, DataService>();
            FreshIOC.Container.Register<IUserDialogs>(UserDialogs.Instance);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}