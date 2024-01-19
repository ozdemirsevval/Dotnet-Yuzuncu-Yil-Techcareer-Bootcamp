using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotnetYuzuncuYilProje.Core
{
    public class Movie : BaseEntity
    {
        public string MovieTitle { get; set; }
        public string MovieType { get; set; }
        public DateTime MovieReleasedDate { get; set; }

        //Bire çok ilişki
        public ICollection<Audience>Audience { get; set; }
    }
}
