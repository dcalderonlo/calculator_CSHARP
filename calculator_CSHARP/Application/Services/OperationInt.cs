using calculator_CSHARP.Domain.Interfaces;

namespace calculator_CSHARP.Application.Services
{
  // Servicio de aplicación que implementa las operaciones matemáticas para enteros.
  // Implementa la lógica de negocio específica para el tipo int.
  // Constructor con inyección de dependencias (DIP).
  public class OperacionesInt(IValidator<int> validator) : IMathOperations<int>
  {
    private readonly IValidator<int> _validator = validator ?? throw new ArgumentNullException(nameof(validator));

    // Suma dos números enteros.
    public static int Add(int a, int b) => a + b;

    // Resta dos números enteros.
    public static int Subtract(int a, int b) => a - b;

    /// Multiplica dos números enteros.
    public static int Multiply(int a, int b) => a * b;

    // Divide dos números enteros con validación de división por cero.
    // Se lanza cuando el divisor es cero
    public int Divide(int a, int b)
    {
      _validator.ValidateDivisionByZero(b);
      return a / b;
    }
  }
}