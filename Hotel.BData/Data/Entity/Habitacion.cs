using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BData.Data.Entity
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int NumeroHabi { get; set; }
        public string? Huesped { get; set; }
        public int Cantidad { get; set; }
    }
}
