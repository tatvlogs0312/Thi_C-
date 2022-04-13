using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimThe
{
    class SimThe
    {
        private string id;
        private string soSim;
        private string idMang;
        private DateTime nKH;
        private DateTime nHH;

        public string Id { get => id; set => id = value; }
        public string SoSim { get => soSim; set => soSim = value; }
        public string IdMang { get => idMang; set => idMang = value; }
        public DateTime NKH { get => nKH; set => nKH = value; }
        public DateTime NHH { get => nHH; set => nHH = value; }
    }
}
