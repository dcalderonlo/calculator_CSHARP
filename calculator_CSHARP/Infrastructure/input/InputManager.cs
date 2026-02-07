namespace calculator_CSHARP.Infrastructure.Input
{
  // Servicio responsable de gestionar la entrada de datos del usuario.
  // Abstrae los detalles de implementación de la entrada (consola, archivo, API, etc).
  public class InputManager
  {
    // Lee un número del usuario con validación automática y manejo de errores.
    // Continúa solicitando entrada hasta recibir un valor válido.
    public T ReadNumber<T>(string message) where T : struct, IComparable, IConvertible
    {
      while (true)
      {
        try
        {
          Console.Write(message);
          string input = Console.ReadLine() ?? throw new InvalidOperationException("Input cannot be null");
          return (T)Convert.ChangeType(input, typeof(T));
        }
        catch (FormatException)
        {
          Console.WriteLine($"Error: Debe ingresar un valor numérico válido de tipo {typeof(T).Name}.");
        }
        catch (OverflowException)
        {
          Console.WriteLine($"Error: El valor es demasiado grande o pequeño para el tipo {typeof(T).Name}.");
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error inesperado: {ex.Message}");
        }
      }
    }

    // Lee una opción numérica del menú con validación de rango.
    public int ReadOption(string message, int min, int max)
    {
      while (true)
      {
        try
        {
          // Console.Write(message);
          // string input = Console.ReadLine() ?? throw new InvalidOperationException("Input cannot be null");
          string input = Console.ReadLine() ?? string.Empty;
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Error: No se permiten entradas vacías.");
                        continue;
                    }
          
          int option = int.Parse(input);
          
          if (option >= min && option <= max)
            return option;
          
          Console.WriteLine($"Por favor, ingrese un número entre {min} y {max}.");
        }
        catch (FormatException)
        {
          Console.WriteLine("Error: Debe ingresar un número entero.");
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error inesperado: {ex.Message}");
        }
      }
    }
  }
}
