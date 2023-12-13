using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maill.UsersClasses
{
    public class StringPair
    {
        public StringPair(string emailAdress, string name)
        {
            EmailAdress = emailAdress ?? throw new ArgumentNullException(nameof(emailAdress));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string EmailAdress { get; set; }
       public string Name { get; set; }
    
       
    }
    
}
