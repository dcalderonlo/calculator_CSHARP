namespace OperacionesMatematicas.Presentation.UI
{
  // Componente de presentación responsable de toda la interfaz visual.
  // Abstrae los detalles de visualización de la lógica de aplicación.
  public class InterfaceUser
  {
    // Muestra el menú principal del sistema.
    public static void ShowMainMenu()
    {
      Console.WriteLine("\n╔══════════════════════════════════════════╗");
      Console.WriteLine("║   SISTEMA DE OPERACIONES MATEMÁTICAS     ║");
      Console.WriteLine("╚══════════════════════════════════════════╝");
      Console.WriteLine("1. Trabajar con números enteros (int)");
      Console.WriteLine("2. Trabajar con números decimales (double)");
      Console.WriteLine("3. Trabajar con números precisos (decimal)");
      Console.WriteLine("4. Salir");
    }

    // Muestra el menú de operaciones.
    public static void ShowOperationsMenu()
    {
      Console.WriteLine("\n╔═══════════ MENÚ DE OPERACIONES ══════════╗");
      Console.WriteLine("║ 1. Agregar número                        ║");
      Console.WriteLine("║ 2. Sumar todos los números               ║");
      Console.WriteLine("║ 3. Restar todos los números              ║");
      Console.WriteLine("║ 4. Multiplicar todos los números         ║");
      Console.WriteLine("║ 5. Dividir todos los números             ║");
      Console.WriteLine("║ 6. Ver lista actual                      ║");
      Console.WriteLine("║ 7. Limpiar lista                         ║");
      Console.WriteLine("║ 8. Volver al menú principal              ║");
      Console.WriteLine("╚══════════════════════════════════════════╝");
    }

    // Muestra los mensajes informativos.
    public static void ShowMessage(string message)
    {
      Console.WriteLine(message);
    }

    // Muestra los mensajes de error en color rojo.
    public static void ShowError(string message)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"✗ {message}");
      Console.ResetColor();
    }

    // Muestra los mensajes de éxito en color verde.
    public static void ShowSuccess(string message)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"✓ {message}");
      Console.ResetColor();
    }

    // Muestra el encabezado principal de la aplicación.
    public static void ShowMainHeader()
    {
      Console.Clear();
      Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
      Console.WriteLine("║           SISTEMA DE OPERACIONES MATEMÁTICAS               ║");
      Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
    }

    // Muestra el mensaje de despedida al usuario.
    public static void ShowGoodbye()
    {
      Console.WriteLine("\n╔════════════════════════════════════════════════════════════╗");
      Console.WriteLine("║             ¡Gracias por usar el sistema!                   ║");
      Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
    }
  }
}