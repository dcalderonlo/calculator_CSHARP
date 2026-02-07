namespace calculator_CSHARP.Domain.Exceptions
{
  // Excepción de dominio que se lanza cuando la lista no contiene suficientes elementos
  /// para realizar una operación matemática.
  public class InsufficientListException : InvalidOperationException
  {
    // Constructor que acepta un mensaje de error personalizado.
    public InsufficientListException(string message) : base(message) 
    { 
    }

    // Constructor por defecto con mensaje estándar.
    public InsufficientListException() 
      : base("La lista no contiene suficientes elementos para realizar la operación.")
    {
    }
  }
}
