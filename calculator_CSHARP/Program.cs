using OperationMath.Domain.Entities;
using OperationMath.Application.Services;
using OperationMath.Infrastructure.Input;
using OperationMath.Presentation.Controllers;
using OperationMath.Presentation.UI;

namespace OperationMath
{
  // Implementa el patrón Composition Root para la inyección de dependencias manual.
  class Program
  {
    static void Main(string[] args)
    {
      // Inicialización de componentes compartidos de infraestructura y presentación
      var ui = new InterfazUsuario();
      var inputManager = new GestorEntrada();

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
    static void ExecuteWithInt(InterfazUsuario ui, GestorEntrada inputManager)
    {
        // Capa de Aplicación: Crear validador
      var validator = new ValidadorNumerico<int>();
      
      // Capa de Dominio: Crear entidad con sus dependencias
      var list = new ListaNumerica<int>(validator);
      
      // Capa de Aplicación: Crear servicio de operaciones
      var operations = new OperacionesInt(validator);
      
      // Capa de Presentación: Crear controlador con todas las dependencias
      var controller = new ControladorInt(list, operations, inputManager, ui);
      
      ui.ShowSuccess("\n═══ Trabajando con números enteros (int) ═══");
      controller.Execute();
    }

    // Composition Root para trabajar con números decimales (double).
    // Configura e inyecta todas las dependencias necesarias.
    static void ExecuteWithDouble(InterfazUsuario ui, GestorEntrada inputManager)
    {
      // Inyección de dependencias manual
      var validator = new ValidadorNumerico<double>();
      var list = new ListaNumerica<double>(validator);
      var operations = new OperacionesDouble(validator);
      var controller = new ControladorDouble(list, operations, inputManager, ui);
      
      ui.ShowSuccess("\n═══ Trabajando con números decimales (double) ═══");
      controller.Execute();
    }

    // Composition Root para trabajar con números de alta precisión (decimal).
    // Configura e inyecta todas las dependencias necesarias.
    static void ExecuteWithDecimal(InterfazUsuario ui, GestorEntrada inputManager)
    {
      // Inyección de dependencias manual
      var validator = new ValidadorNumerico<decimal>();
      var list = new ListaNumerica<decimal>(validator);
      var operations = new OperacionesDecimal(validator);
      var controller = new ControladorDecimal(list, operations, inputManager, ui);
      
      ui.ShowSuccess("\n═══ Trabajando con números precisos (decimal) ═══");
      controller.Execute();
    }
  }
}
