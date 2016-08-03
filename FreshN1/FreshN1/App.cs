using FreshMvvm;
using FreshN1.PageModels;
using Xamarin.Forms;

namespace FreshN1
{
    public class App : Application
    {
        public App()
        {
            var contactList = FreshPageModelResolver.ResolvePageModel<ContactListPageModel>();
            var navContainer = new FreshNavigationContainer(contactList);
            MainPage = navContainer;
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