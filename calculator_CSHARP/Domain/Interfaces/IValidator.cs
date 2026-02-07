namespace calculator_CSHARP.Domain.Interfaces
{
  // Define los métodos de validación necesarios para operaciones matemáticas seguras.
  // Representa las reglas de negocio del dominio.
  public interface IValidator<T>
  {
    // Valida que la lista tenga suficientes elementos para realizar una operación.
    // Se lanza cuando la cantidad es menor que el mínimo requerido
    void ValidateSufficientList(int count);

    // Valida que el divisor no sea cero antes de realizar una división.
    // Se lanza una excepción cuando el divisor es cero o muy cercano a cero
    void ValidateDivisionByZero(T divisor);
  }
}
