namespace OperationMath.Domain.Interfaces
{
  // Define las operaciones matemáticas básicas que se pueden realizar entre dos números.
  // Representa el comportamiento matemático del dominio.
  public interface IMathOperations<T>
  {
    // Suma dos números.
    T Add(T a, T b);

    // Resta dos números.
    T Subtract(T a, T b);

    // Multiplica dos números.
    T Multiply(T a, T b);

    // Divide dos números.
    // Se lanza cuando el divisor es cero
    T Divide(T a, T b);
  }
}