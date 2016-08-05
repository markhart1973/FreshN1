using System;
using System.Collections.Generic;
using FreshMvvm;
using FreshN1.Infrastructure.Constants;
using PropertyChanged;

namespace FreshN1.PageModels
{
    [ImplementPropertyChanged]
    public class MenuPageModel :
        FreshBasePageModel
    {
        public List<string> MenuItems { get; set; }

        public string SelectedMenuItem
        {
            get { return null; }
            set
            {
                switch (value)
                {
                    case PageNames.Contacts:
                        this.CoreMethods.PushPageModel<ContactListPageModel>();
                        break;
                    case PageNames.Quotes:
                        this.CoreMethods.PushPageModel<QuoteListPageModel>();
                        break;
                }
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            this.MenuItems = new List<string>
            {
                PageNames.Quotes,
                PageNames.Contacts
            };
        }
    }
}