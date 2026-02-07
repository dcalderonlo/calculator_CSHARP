namespace calculator_CSHARP.Presentation.UI
{
  // Componente de presentación responsable de toda la interfaz visual.
  // Abstrae los detalles de visualización de la lógica de aplicación.
  public class InterfaceUser
  {
    // Muestra el menú principal del sistema.
    public void ShowMainMenu()
    {
      Console.WriteLine("\n╔══════════════════════════════════════════╗");
      Console.WriteLine("║   SISTEMA DE OPERACIONES MATEMÁTICAS     ║");
      Console.WriteLine("╚══════════════════════════════════════════╝");
      Console.WriteLine("1. Trabajar con números enteros (int)");
      Console.WriteLine("2. Trabajar con números decimales (double)");
      Console.WriteLine("3. Trabajar con números precisos (decimal)");
      Console.WriteLine("4. Salir");
      Console.Write("\nSeleccione una opción (1-4): ");
    }

    // Muestra el menú de operaciones.
    public void ShowOperationsMenu()
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
      Console.Write("\nSeleccione una opción (1-8): ");
    }

    // Muestra los mensajes informativos.
    public void ShowMessage(string message)
    {
      Console.WriteLine(message);
    }

    // Muestra los mensajes de error en color rojo.
    public void ShowError(string message)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"✗ {message}");
      Console.ResetColor();
    }

    // Muestra los mensajes de éxito en color verde.
    public void ShowSuccess(string message)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"✓ {message}");
      Console.ResetColor();
    }

    // Muestra el encabezado principal de la aplicación.
    public void ShowMainHeader()
    {
      Console.Clear();
      Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
      Console.WriteLine("║             SISTEMA DE OPERACIONES MATEMÁTICAS             ║");
      Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
    }

    // Muestra el mensaje de despedida al usuario.
    public void ShowGoodbye()
    {
      Console.WriteLine("\n╔════════════════════════════════════════════════════════════╗");
      Console.WriteLine("║               ¡Gracias por usar el sistema!                ║");
      Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
    }
  }
}