using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterdea
{
    class Holds
    {       
      List<Hold> list;

        public Holds()
        {
                this.list = new List<Hold>();
        }

            public void Add(Hold hold)
            {
                list.Add(hold);
            }

            public Hold GetLast()
            {
                return list[list.Count - 1];
            }

        

    }
}
