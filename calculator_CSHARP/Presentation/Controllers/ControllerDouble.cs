using OperationMath.Domain.Interfaces;
using OperationMath.Infrastructure.Input;
using OperationMath.Presentation.UI;

namespace OperationMath.Presentation.Controllers
{
  // Controlador especializado para operaciones con números de punto flotante.
  // Implementa los hook methods del Template Method con comportamiento específico para double.
  public class ControllerDouble(
    IListOperations<double> list,
    IMathOperations<double> operations,
    InputManager inputManager,
    InterfaceUser ui) : ControllerBase<double>(list, operations, inputManager, ui), ControllerBase<double>
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
