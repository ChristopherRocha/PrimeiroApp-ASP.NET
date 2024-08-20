
using ProjetoGerenciarTarefas.Validators;
using System.ComponentModel.DataAnnotations;

namespace ProjetoGerenciarTarefas.Models
{
    public class ParaFazer
    {
        public  int Id { get; set; }
        [Required(ErrorMessage ="Este campo é obrigatório")]
        [StringLength(100,MinimumLength =3, ErrorMessage="O campo Título deve ter entre 3 e 100 Caracteres")]
        public string Title { get; set; } = string.Empty;

        public DateTime DataCriacao { get; set; }

        [Display(Name = "Data de Entrega")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [FutureOrPresent]
        public  DateOnly DataLimite { get; set; }

        public DateOnly? DataFinalicao { get; set; }


        public void Finish()
        {
            DataFinalicao = DateOnly.FromDateTime(DateTime.Now);
        }

        public DateTime GetDate()
        {
            return DataCriacao;
        }
    }
}
