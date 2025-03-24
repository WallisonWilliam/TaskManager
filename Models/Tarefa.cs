using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        [Display(Name = "Data de Entrega")]
        [DataType(DataType.Date)]
        public DateTime DataEntrega { get; set; }

        public string Prioridade { get; set; } 

        public string Status { get; set; } 
    }
}
