using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqExample
{
   public class BandController
    {
        IRepository repository;

        public BandController(IRepository repository)
        {
            this.repository = repository;
        }

        public void MethodToTest()
        {
            var bands = this.repository.GetBands();
            foreach(var band in bands)
            {
                if(band.Name=="Bayside")
                {
                    Console.WriteLine("I love this band");
                }
            }
        }
    }
}
