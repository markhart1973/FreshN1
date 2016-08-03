using System;
using FreshMvvm;
using FreshN1.Models;

namespace FreshN1.PageModels
{
    public class ContactPageModel : FreshBasePageModel
    {
        public Contact Contact { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);

            this.Contact = initData as Contact;
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            this.CoreMethods.DisplayAlert("Wired", "Done", "OK");
        }
    }
}