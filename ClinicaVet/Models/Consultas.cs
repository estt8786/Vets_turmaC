using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVet.Models
{
    /// <summary>
    /// Classe representa a tabela das "Consulta" na base de dados
    /// </summary>
    public class Consultas
    {
        /// <summary>
        /// PK da tabela
        /// </summary>
        public int ID { set; get; }

        public DateTime Date { get; set; }

        public string Observacoes { get; set; }


    }
}
