using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVet.Models
{
    /// <summary>
    /// Classe representa a tabela dos "Donos" na base de dados
    /// </summary>
    public class Donos
    {
        /// <summary>
        /// PK da tabela
        /// </summary>
        public int ID { set; get; }
        public string Nome { get; set; }
        public string NIF { get; set; }


    }
}
