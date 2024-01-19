using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProje.Core
{
    public class Audience : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public int MovieId { get; set; } //foreign key

        //movie-audience arasındaki 1-N ilişkiyi tanımlar.
        public Movie Movie { get; set; } 
    }
}
