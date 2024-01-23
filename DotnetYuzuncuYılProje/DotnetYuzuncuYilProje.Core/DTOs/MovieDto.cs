using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProje.Core.DTOs
{
    public class MovieDto : BaseDto
    {
        public string MovieTitle { get; set; }
        public string MovieType { get; set; }
        public DateTime MovieReleasedDate { get; set; }
    }
}
