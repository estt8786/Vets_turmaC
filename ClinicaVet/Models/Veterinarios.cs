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

        // System.ComponentModel.DataAnnotations Namespace
        // https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=netcore-3.1

        /// <summary>
        /// PK da tabela
        /// </summary>
        /// 
        [Key]
        public int ID { set; get; }

        [Required(ErrorMessage ="O Nome é de preenchimento obrigatório")]
        [StringLength(40,ErrorMessage ="O {0} só pode ter, no máximo, {1} carateres.")]
        [RegularExpression("[A-ZÁÉÍÓÚÂ][a-záéíóúàèìòùâêîôûçñ]+[A-Z][a-z]+(( | e |-|'|d'| de | d[ao](s)? )[A-Z][a-z]+) {1,3}[A-ZÁÉÍÓÚÂ][a-záéíóúàèìòùâêîôûçñ]",
            ErrorMessage ="Só são aceites letras. Cada palavra deve começar por uma Maiúscula, separadas por espaço em branco")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        //Será um texto com traço e 6 numeros => vet-XXXXXX -----> a palavra vet, um hifem, seguido de 6 digitos
        [RegularExpression("vet-[0-9]{6}", ErrorMessage ="Deve introduzir a palavra 'vet-' (em minusculas) seguida de 6 algarismos")]
        [StringLength(10, ErrorMessage = "O {0} só pode ter, no máximo, {1} carateres.")]
        [Display(Name ="Nº Cédula Profissional")]
        public string NumCedulaProf { get; set; }

        [Required]
        public string Foto { get; set; }
        /// <summary>
        /// Lista de "Consultas" a que o Veterinário está associado
        /// </summary>
        /// 
       
        public virtual ICollection<Consultas> Consultas { get; set; }
    }
}
