using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace WebClassLibrary
{
   public class MySession
    {
        public string Property1 { get; set; }
        public DateTime MyDate { get; set; }
        public int LoginId { get; set; }

        private MySession()
        {
            Property1 = "default value";
        }

        



    }
}
