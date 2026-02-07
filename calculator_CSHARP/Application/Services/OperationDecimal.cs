using calculator_CSHARP.Domain.Interfaces;

namespace calculator_CSHARP.Application.Services
{
  // Servicio de aplicación que implementa las operaciones matemáticas para decimal.
  // Proporciona alta precisión (128 bits) ideal para cálculos financieros.
  // Constructor con inyección de dependencias (DIP).
  public class OperationDecimal(IValidator<decimal> validator) : IMathOperations<decimal>
  {
    private readonly IValidator<decimal> _validator = validator ?? throw new ArgumentNullException(nameof(validator));

    // Suma dos números decimales con alta precisión.
    public decimal Add(decimal a, decimal b) => a + b;

    // Resta dos números decimales con alta precisión.
    public decimal Subtract(decimal a, decimal b) => a - b;

    // Multiplica dos números decimales con alta precisión.
    public decimal Multiply(decimal a, decimal b) => a * b;

    // Divide dos números decimales con alta precisión y validación.
    // Se lanza una excepción cuando el divisor es cero o muy cercano a cero
    public decimal Divide(decimal a, decimal b)
    {
      _validator.ValidateDivisionByZero(b);
      return a / b;
    }
  }
}
