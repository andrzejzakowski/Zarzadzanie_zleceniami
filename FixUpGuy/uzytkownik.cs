using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixUpGuy
{
    class uzytkownik
    {
        private int id_uz;
        private string login;
        private string haslo;
        private string typ_konta;

        public int Id_uz { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string Typ_konta { get; set; }

        public uzytkownik(int id, string login, string haslo, string typ_konta)
        {
            this.Id_uz = id;
            this.Login = login;
            this.Haslo = haslo;
            this.Typ_konta = typ_konta;
        }
    }
}
