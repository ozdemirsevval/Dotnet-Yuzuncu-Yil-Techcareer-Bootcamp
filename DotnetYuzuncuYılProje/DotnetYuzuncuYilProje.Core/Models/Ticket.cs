using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProje.Core
{
    public class Ticket : BaseEntity
    {
        public int Price { get; set; }
        public int AudienceId { get; set; }//foreign key

        //ticket - audience arasındaki 1-1 ilişkiyi tanımlar.
        public Audience Audience { get; set; }


    }
}
