using System.ComponentModel.DataAnnotations;

namespace ProjetoGerenciarTarefas.Validators
{
    public class FutureOrPresentAttribute:ValidationAttribute
    {
        public FutureOrPresentAttribute()
        {
            ErrorMessage = "O campo {0} deve ser uma data válida";
        }
        public override bool IsValid(object? value)
        {
            if ((value is null))
            {
                return true;
            }
            var data = (DateOnly)value;
            return data >= DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
