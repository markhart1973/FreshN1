using System.Collections.Generic;
using FreshMvvm;
using FreshN1.Models;

namespace FreshN1.PageModels
{
    public class ContactListPageModel : FreshBasePageModel
    {
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

        public override void Init(object initData)
        {
            base.Init(initData);

            this.ContactList = new List<Contact>
            {
                new Contact {Name="Peter", Number="01772409099" },
                new Contact {Name="james", Number="01772789069" }
            };
        }
    }
}