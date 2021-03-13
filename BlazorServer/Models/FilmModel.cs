using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Models
{
    public class FilmModel
    {
        public int film_Id { get; set; }
        public string film_Titel { get; set; }
        public DateTime film_Datum { get; set; }
        public int prod_Id { get; set; }
        public string prod_Bezeichnung { get; set; }
        public int schau_Id { get; set; }
        public string schau_Vname { get; set; }
        public string schau_Nname { get; set; }

        public string Schauspieler{ get; set; }

    }
}
