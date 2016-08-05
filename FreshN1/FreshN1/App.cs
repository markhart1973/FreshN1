using Acr.UserDialogs;
using FreshMvvm;
using FreshN1.Infrastructure.Constants;
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

            this.SetupTabbedNav();
        }

        private void SetupIoc()
        {
            FreshIOC.Container.Register<IDataService, DataService>();
            FreshIOC.Container.Register<IUserDialogs>(UserDialogs.Instance);
        }

        private void SetupTabbedNav()
        {
            var tabbedNav = new FreshTabbedNavigationContainer();
            tabbedNav.AddTab<ContactListPageModel>(PageNames.Contacts, null);
            tabbedNav.AddTab<QuoteListPageModel>(PageNames.Quotes, null);
            this.MainPage = tabbedNav;
        }

        private void SetupMasterDetail()
        {
            var masterDetail = new FreshMasterDetailNavigationContainer();
            masterDetail.AddPage<ContactListPageModel>(PageNames.Contacts, null);
            masterDetail.AddPage<QuoteListPageModel>(PageNames.Quotes, null);
            masterDetail.Init(PageNames.Menu);
            this.MainPage = masterDetail;
        }

        private void SetupSingleNav()
        {
            var page = FreshPageModelResolver.ResolvePageModel<MenuPageModel>(null);
            var singleNav = new FreshNavigationContainer(page);
            this.MainPage = singleNav;
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