using calculator_CSHARP.Domain.Entities;
using calculator_CSHARP.Application.Services;
using calculator_CSHARP.Infrastructure.Input;
using calculator_CSHARP.Presentation.Controllers;
using calculator_CSHARP.Presentation.UI;

namespace calculator_CSHARP
{
  // Implementa el patrón Composition Root para la inyección de dependencias manual.
  class Program
  {
    static void Main(string[] args)
    {
      // Inicialización de componentes compartidos de infraestructura y presentación
      var ui = new InterfaceUser();
      var inputManager = new InputManager();

      ui.ShowMainHeader();

      // Bucle principal de la aplicación
      bool exit = false;
      while (!exit)
      {
        ui.ShowMainMenu();
        int option = inputManager.ReadOption("\nSeleccione el tipo de dato: ", 1, 4);

        switch (option)
        {
          case 1:
            ExecuteWithInt(ui, inputManager);
            break;
          case 2:
            ExecuteWithDouble(ui, inputManager);
            break;
          case 3:
            ExecuteWithDecimal(ui, inputManager);
            break;
          case 4:
            exit = true;
            ui.ShowGoodbye();
            break;
        }
      }
    }

    // Composition Root para trabajar con números enteros.
    // Configura e inyecta todas las dependencias necesarias.
    // Implementa el principio de Inversión de Dependencias (DIP).
    static void ExecuteWithInt(InterfaceUser ui, InputManager inputManager)
    {
        // Capa de Aplicación: Crear validador
      var validator = new NumericValidator<int>();
      
      // Capa de Dominio: Crear entidad con sus dependencias
      var list = new NumberedList<int>(validator);
      
      // Capa de Aplicación: Crear servicio de operaciones
      var operations = new OperationInt(validator);
      
      // Capa de Presentación: Crear controlador con todas las dependencias
      var controller = new ControllerInt(list, operations, inputManager, ui);
      
      ui.ShowSuccess("\n═══ Trabajando con números enteros (int) ═══");
      controller.Execute();
    }

    // Composition Root para trabajar con números decimales (double).
    // Configura e inyecta todas las dependencias necesarias.
    static void ExecuteWithDouble(InterfaceUser ui, InputManager inputManager)
    {
      // Inyección de dependencias manual
      var validator = new NumericValidator<double>();
      var list = new NumberedList<double>(validator);
      var operations = new OperationDouble(validator);
      var controller = new ControllerDouble(list, operations, inputManager, ui);
      
      ui.ShowSuccess("\n═══ Trabajando con números decimales (double) ═══");
      controller.Execute();
    }

    // Composition Root para trabajar con números de alta precisión (decimal).
    // Configura e inyecta todas las dependencias necesarias.
    static void ExecuteWithDecimal(InterfaceUser ui, InputManager inputManager)
    {
      // Inyección de dependencias manual
      var validator = new NumericValidator<decimal>();
      var list = new NumberedList<decimal>(validator);
      var operations = new OperationDecimal(validator);
      var controller = new ControllerDecimal(list, operations, inputManager, ui);
      
      ui.ShowSuccess("\n═══ Trabajando con números precisos (decimal) ═══");
      controller.Execute();
    }
  }
}
