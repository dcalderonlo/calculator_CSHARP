using calculator_CSHARP.Domain.Delegates;

namespace calculator_CSHARP.Domain.Interfaces
{
  // Define las operaciones básicas que se pueden realizar sobre una lista genérica de números.
  // Representa el contrato del dominio para gestión de colecciones numéricas.
  public interface IListOperations<T>
  {
    // Agrega un número a la lista.
    void AddNumber(T number);

    // Realiza una operación matemática sobre todos los elementos de la lista.
    T PerformOperation(OperationMath<T> operation);

    // Obtiene la cantidad de elementos en la lista.
    int GetElementCount();

    // Elimina todos los elementos de la lista.
    void ClearList();
  }
}