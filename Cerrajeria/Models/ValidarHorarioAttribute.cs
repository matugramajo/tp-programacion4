using System.ComponentModel.DataAnnotations;

namespace Cerrajeria.Models
{
    public class ValidarHorarioAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is DateTime fecha)
            {
                int hora = fecha.Hour;
                int minuto = fecha.Minute;
                DayOfWeek dia = fecha.DayOfWeek;

                if (dia == DayOfWeek.Sunday)
                    return false;

                if (dia == DayOfWeek.Saturday)
                    return hora >= 9 && (hora < 12 || (hora == 12 && minuto == 0));

                return hora >= 8 && (hora < 16 || (hora == 16 && minuto == 0));
            }
            return false;
        }
    }
}