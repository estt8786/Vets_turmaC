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
            //
            ListaDeAnimais = new HashSet<Animais>();
        }
            /// <summary>
        /// PK da tabela
        /// </summary>
        /// 
        [Key]
        public int ID { set; get; }
        public string Nome { get; set; }
        public string NIF { get; set; }

        /// <summary>
        /// lista dos animais que o dono tem
        //
        /// </summary>
        public ICollection<Animais> ListaDeAnimais { get; set; }


    }
}
