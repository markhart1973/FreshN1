using PropertyChanged;

namespace FreshN1.Models
{
    [ImplementPropertyChanged]
    public class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }
}