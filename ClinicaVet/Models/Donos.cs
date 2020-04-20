using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVet.Models
{
    /// <summary>
    /// Classe representa a tabela dos "Donos" na base de dados
    /// </summary>
    public class Donos
    {

        public Donos()
        {
            //Inicializar a lista de animais associados a um "Dono"
            ListaDeAnimais = new HashSet<Animais>();
        }
        /// <summary>
        /// PK da tabela
        /// </summary>
        /// 
        [Key]
        public int ID { set; get; }
        [Display(Name = "Nome do Dono do Animal")]
        [Required(ErrorMessage = "Introduza um nome válido.")]
        [StringLength(75, ErrorMessage = "O {0} poderá ter no máximo {1} caracteres.")]
        [RegularExpression("[A-ZÁÉÍÓÚÂ][a-záéíóúàèìòùäëïöüãõâêîôûçñ]+(( | e | de | d[ao](s)? |-|'| d')[A-ZÁÉÍÓÚÂ][a-záéíóúàèìòùäëïöüãõâêîôûçñ]+){1,3}",
                 ErrorMessage = "Só são aceites nomes, começados por letra Maiúscula, separados entre si por um espaço em branco.")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="O NIF é de preeenchimento obrigatório")]
        [StringLength(9,ErrorMessage = "O {0} poderá ter no máximo {1} caracteres.")]
        [RegularExpression("[1-9][0-9]{8}",ErrorMessage ="Só aceita NIF válidos, com 9 digitos e introduzidos corretamente")]
        [Display(Name = "Nº Identificação Fiscal")]
        public string NIF { get; set; }

        public String Sexo { set; get; }



        /// <summary>
        /// lista dos animais que o Dono tem
        /// </summary>
        public ICollection<Animais> ListaDeAnimais { get; set; } // Dono -----> Animais

    }
}
