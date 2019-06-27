using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterdea
{
    class Hold
    {        
       List<Compartment> list;
        string title;
        public Hold(List<Compartment> list, string title)
      {
          this.list = list;
          this.title = title;
      }

       public override string ToString()
       {
                string result = title + "\n";

                foreach (var subitem in list)
                    result += subitem.ToString() + " ";

                return (result + "\n");
       }



        
    }
}
