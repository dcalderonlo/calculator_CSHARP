using OperacionesMatematicas.Domain.Interfaces;
using OperacionesMatematicas.Infrastructure.Input;
using OperacionesMatematicas.Presentation.UI;

namespace OperacionesMatematicas.Presentation.Controllers
{
  // Implementa los hook methods del Template Method con comportamiento específico para int.
  // Constructor que inyecta todas las dependencias necesarias.
  public class ControllerInt(
    IListOperations<int> list,
    IMathOperations<int> operations,
    InputManager inputManager,
    InterfaceUser ui) : ControllerBase<int>(list, operations, inputManager, ui), ControllerBase<int>
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