using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixUpGuy
{
    class zlecenia
    {
        private int id;
        private string data_dodania;
        private string termin_wykonania;
        private string opis;
        private int kwota;
        private string link;

        public int Id { get; set; }
        public string Data_dodania { get; set; }
        public string Termin_wykonania { get; set; }
        public string Opis { get; set; }
        public int Kwota { get; set; }
        public string Link { get; set; }

        public zlecenia(int id, string z_data_dodania, string z_termin_wykonania, string opis, int kwota, string link)
        {
            this.Id = id;
            this.Data_dodania = z_data_dodania;
            this.Termin_wykonania = z_termin_wykonania;
            this.Opis = opis;
            this.Kwota = kwota;
            this.Link = link;
        }
    }
}
