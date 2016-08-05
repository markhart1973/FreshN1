using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace FreshN1.Models
{
    [ImplementPropertyChanged]
    public class Quote
    {
        public string CustomerName { get; set; }
        public int QuoteAmount { get; set; }
    }
}
