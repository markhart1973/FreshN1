using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshN1.Models;

namespace FreshN1.Services
{
    public class DataService :
        IDataService
    {
        public async Task<List<Contact>> GetContacts()
        {
            await Task.Delay(3000);
            return new List<Contact>
            {
                new Contact {Name="Peter", Number="01772409099" },
                new Contact {Name="james", Number="01772789069" }
            };
        }
    }
}
