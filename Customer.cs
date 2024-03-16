using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tobeto_video_odev5
{
    public class Customer
    {
        public Customer()
        {
            Console.WriteLine("Müşteri nesnesi başlatıldı.");
        }
        public int Id { get; set; }
        public string City { get; set; }    
    
    }
}
