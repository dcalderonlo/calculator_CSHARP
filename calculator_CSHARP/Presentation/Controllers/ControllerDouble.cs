using calculator_CSHARP.Domain.Interfaces;
using calculator_CSHARP.Infrastructure.Input;
using calculator_CSHARP.Presentation.UI;

namespace calculator_CSHARP.Presentation.Controllers
{
  // Controlador especializado para operaciones con números de punto flotante.
  // Implementa los hook methods del Template Method con comportamiento específico para double.
  public class ControllerDouble(
    IListOperations<double> list,
    IMathOperations<double> operations,
    InputManager inputManager,
    InterfaceUser ui) : ControllerBase<double>(list, operations, inputManager, ui)
  {
    protected override string GetInputMessage()
    {
      return "Ingrese un número decimal: ";
    }

    // Los números se muestran con 2 decimales de precisión.
    protected override string FormatNumber(double number)
    {
      return number.ToString("F2");
    }
  }
}
