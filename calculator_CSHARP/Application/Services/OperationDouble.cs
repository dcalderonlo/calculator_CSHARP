using calculator_CSHARP.Domain.Interfaces;

namespace calculator_CSHARP.Application.Services
{
  // Servicio de aplicación que implementa las operaciones matemáticas para double.
  // Proporciona precisión de punto flotante de 64 bits.
  // Constructor con inyección de dependencias (DIP).
  public class OperationDouble(IValidator<double> validator) : IMathOperations<double>
  {
    private readonly IValidator<double> _validator = validator ?? throw new ArgumentNullException(nameof(validator));

    /// Suma dos números de punto flotante.
    public double Add(double a, double b) => a + b;

    /// Resta dos números de punto flotante.
    public double Subtract(double a, double b) => a - b;

    /// Multiplica dos números de punto flotante.
    public double Multiply(double a, double b) => a * b;

    /// Divide dos números de punto flotante con validación.
    /// Se lanza una excepción cuando el divisor es cero o muy cercano a cero
    public double Divide(double a, double b)
    {
      _validator.ValidateDivisionByZero(b);
      return a / b;
    }
  }
}