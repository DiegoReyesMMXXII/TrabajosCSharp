using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Dominio
{
    public class TorneoEquipo
    {
        public int TorneoId { get; set; }
        public int EquipoId { get; set; }
        public Torneo Torneo {get; set;}
        public Equipo Equipo {get;set;}

        
    }
}