namespace calculator_CSHARP.Domain.Delegates
{
  // Delegado para operaciones matemáticas binarias.
  // Representa una función que toma dos valores del mismo tipo y devuelve un resultado del mismo tipo.
  public delegate T OperationMath<T>(T a, T b);
}
