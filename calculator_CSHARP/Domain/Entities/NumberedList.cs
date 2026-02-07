using System.Collections.Generic;
using calculator_CSHARP.Domain.Delegates;
using calculator_CSHARP.Domain.Interfaces;

namespace calculator_CSHARP.Domain.Entities
{
  // Entidad de dominio que representa una lista de números con operaciones matemáticas.
  // Implementa el patrón Aggregate Root en DDD.
  // Constructor que inicializa la entidad con sus dependencias.
  // Inyección de dependencias a nivel de dominio (DIP).
  public class NumberedList<T>(IValidator<T> validator) : IListOperations<T> where T : struct, IComparable, IConvertible
  {
    private readonly List<T> _numbers = [];
    private readonly IValidator<T> _validator = validator ?? throw new ArgumentNullException(nameof(validator));

  /// Agrega un número a la colección interna.
  public void AddNumber(T number)
    {
      _numbers.Add(number);
    }

    // Realiza una operación matemática sobre todos los elementos de forma secuencial.
    // Implementa el patrón Strategy mediante delegados.
    // Se lanza cuando la lista tiene menos de 2 elementos, ya que no se pueden realizar operaciones binarias.
    public T PerformOperation(OperationMath<T> operation)
    {
      _validator.ValidateSufficientList(_numbers.Count);

      T result = _numbers[0];
      for (int i = 1; i < _numbers.Count; i++)
      {
        result = operation(result, _numbers[i]);
      }

      return result;
    }

    // Obtiene la cantidad de elementos en la colección.
    public int GetElementCount()
    {
      return _numbers.Count;
    }

    // Elimina todos los elementos de la colección.
    public void ClearList()
    {
      _numbers.Clear();
    }

    // Obtiene una copia defensiva de la colección para lectura.
    // Protege la invariante del dominio.
    public List<T> GetNumbers()
    {
      return [.. _numbers];
    }
  }
}
