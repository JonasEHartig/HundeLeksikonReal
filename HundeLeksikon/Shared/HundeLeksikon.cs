using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeLeksikon.Shared
{
    public class HundeData
    {

        [Key] public int HundeId { get; set; }
        public required string HundeNavn { get; set; } 
        public required int FCIGrupper { get; set; }
        public int  HundeStørrelse { get; set; }
        public int HundeTemperament { get; set; }
        public int HundePelspleje { get; set; }
        public int HundeEnergi { get; set; }
        public required string HundeBeskrivelsen { get; set; }

    }
}
