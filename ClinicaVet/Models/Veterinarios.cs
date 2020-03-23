using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVet.Models
{
    /// <summary>
    /// Classe representa a tabela dos "Veterinarios" na base de dados
    /// </summary>
    public class Veterinarios
    {
        /// <summary>
        /// PK da tabela
        /// </summary>
        public int ID { set; get; }

        public string Nome { get; set; }
        public string NumCedulaProf { get; set; }

        public string Foto { get; set; }
    }
}
