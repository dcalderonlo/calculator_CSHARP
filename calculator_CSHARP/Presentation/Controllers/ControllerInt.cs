using calculator_CSHARP.Domain.Interfaces;
using calculator_CSHARP.Infrastructure.Input;
using calculator_CSHARP.Presentation.UI;

namespace calculator_CSHARP.Presentation.Controllers
{
  // Implementa los hook methods del Template Method con comportamiento específico para int.
  // Constructor que inyecta todas las dependencias necesarias.
  public class ControllerInt(
    IListOperations<int> list,
    IMathOperations<int> operations,
    InputManager inputManager,
    InterfaceUser ui) : ControllerBase<int>(list, operations, inputManager, ui)
  {
    protected override string GetInputMessage()
    {
      return "Ingrese un número entero: ";
    }

    // Los enteros se muestran sin decimales.
    protected override string FormatNumber(int numero)
    {
      return numero.ToString();
    }
  }
}