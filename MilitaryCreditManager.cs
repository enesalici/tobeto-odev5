using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tobeto_video_odev5
{
    public class MilitaryCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Asker kredisi hesaplandı.");
        }

        //public void Save()  Save operasyonunu BaseCreditManager'dan çekeceği için gerek kalmayacak 
        //{
        //    throw new NotImplementedException();
        //}
    }
}
