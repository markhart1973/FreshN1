using System.Collections.Generic;
using Acr.UserDialogs;
using FreshMvvm;
using FreshN1.Models;
using FreshN1.Services;

namespace FreshN1.PageModels
{
    public class ContactListPageModel :
        FreshBasePageModel
    {
        private readonly IDataService _dataService;
        private readonly IUserDialogs _userDialogs;

        public List<Contact> ContactList { get; set; }

        public Contact SelectedContact
        {
            get { return null; }
            set
            {
                this.CoreMethods.PushPageModel<ContactPageModel>(value);
                RaisePropertyChanged();
            }
        }

        public ContactListPageModel(IDataService dataService,
            IUserDialogs userDialogs)
        {
            _dataService = dataService;
            _userDialogs = userDialogs;
        }

        public override async void Init(object initData)
        {
            base.Init(initData);
            _userDialogs.ShowLoading();
            this.ContactList = await _dataService.GetContacts();
            _userDialogs.HideLoading();
        }
    }
}