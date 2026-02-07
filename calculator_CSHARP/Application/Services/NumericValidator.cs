using calculator_CSHARP.Domain.Exceptions;
using calculator_CSHARP.Domain.Interfaces;

namespace calculator_CSHARP.Application.Services
{
  // Servicio de aplicación que implementa las validaciones de negocio.
  // Encapsula las reglas de validación del dominio.
  public class NumericValidator<T> : IValidator<T> where T : struct, IComparable, IConvertible
  {
    private const int MinimumNumberItems = 2;

    // Valida que la lista contenga al menos 2 elementos.
    // Se lanza un InsufficientListException cuando la cantidad es menor a 2
    public void ValidateSufficientList(int cantidad)
    {
        if (cantidad < MinimumNumberItems)
        {
          throw new InsufficientListException(
            $"La lista debe contener al menos {MinimumNumberItems} números para realizar una operación.");
        }
    }

    // Valida que el divisor no sea cero o muy cercano a cero.
    // Se lanza una excepción cuando el divisor es cero o cercano a cero
    public void ValidateDivisionByZero(T divisor)
    {
      double value = Convert.ToDouble(divisor);
      if (Math.Abs(value) < double.Epsilon)
      {
        throw new DivideByZeroException("No se puede dividir entre cero.");
      }
    }
  }
}