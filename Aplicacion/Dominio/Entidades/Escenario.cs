using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Dominio
{
    public class Escenario
    {        


        /**
        *! Propiedad Navigacional
        */
        public List<Campo> Campos {get; set;}
    }
}