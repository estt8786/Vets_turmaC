using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVet.Models
{
    /// <summary>
    /// Classe representa a tabela dos "Veterinarios" na base de dados
    /// </summary>
    public class Veterinarios
    {
        public Veterinarios()
        {
            // Inicializar a lista de consultas efetuadas por um veterinário
            Consultas = new HashSet<Consultas>();
        }
        /// <summary>
        /// PK da tabela
        /// </summary>
        /// 
        [Key]
        public int ID { set; get; }

        [Required(ErrorMessage ="O Nome é de preenchimento obrigatório")]
        [StringLength(40,ErrorMessage ="O {0} só pode ter, no máximo, {1} carateres.")]
        public string Nome { get; set; }

        [Required]
        public string NumCedulaProf { get; set; }

        [Required]
        public string Foto { get; set; }
        /// <summary>
        /// Lista de "Consultas" a que o Veterinário está associado
        /// </summary>
        public ICollection<Consultas> Consultas { get; set; }
    }
}
