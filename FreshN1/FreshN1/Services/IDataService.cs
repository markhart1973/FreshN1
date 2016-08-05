using System.Collections.Generic;
using System.Threading.Tasks;
using FreshN1.Models;

namespace FreshN1.Services
{
    public interface IDataService
    {
        Task<List<Contact>> GetContacts();
    }
}