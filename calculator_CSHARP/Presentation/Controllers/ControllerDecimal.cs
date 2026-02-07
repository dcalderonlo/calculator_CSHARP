using OperationMath.Domain.Interfaces;
using OperationMath.Infrastructure.Input;
using OperationMath.Presentation.UI;

namespace OperationMath.Presentation.Controllers
{
  // Controlador especializado para operaciones con números de alta precisión.
  // Implementa los hook methods del Template Method con comportamiento específico para decimal.
  public class ControllerDecimal(
    IListOperations<decimal> list,
    IMathOperations<decimal> operations,
    InputManager inputManager,
    InterfaceUser ui) : ControllerBase<decimal>(list, operations, inputManager, ui), ControllerBase<decimal>
  {
    protected override string GetInputMessage()
    {
      return "Ingrese un número decimal de alta precisión: ";
    }

    protected override string FormatNumber(decimal number)
    {
      return number.ToString();
    }
  }
}
