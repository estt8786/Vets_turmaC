using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        /// 
        [Key] // anotação que força este atributo a ser PK. Mas, não seria necessário, pq o atributo chama-se "ID"
        public int ID { set; get; }

        public DateTime Data { get; set; }
        public string Observacoes { get; set; }

        //criar as chaves forasteiras FK -> estas 3 linhas abaixo fazem a FK
        [ForeignKey("Veterinario")]
        public int VeterinarioFK { get; set; }
        public Veterinarios Veterinario { get; set; } //rtelacionamento a custo deste atributo

        [ForeignKey(nameof(Animal))]
        public int AnimalFK { get; set; }
        public virtual Animais Animal { get; set; }
        

    }
}
