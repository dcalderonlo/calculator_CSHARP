using OperationMath.Domain.Delegates;
using OperationMath.Domain.Exceptions;
using OperationMath.Domain.Interfaces;
using OperationMath.Domain.Entities;
using OperationMath.Infrastructure.Input;
using OperationMath.Presentation.UI;

namespace OperationMath.Presentation.Controllers
{
  // Controlador base que implementa el patrón Template Method.
  // Coordina la interacción entre las capas de dominio, aplicación y presentación.
  // Implementa el principio de Inversión de Dependencias (DIP).
  public abstract class ControllerBase<T>(
    IListOperations<T> list,
    IMathOperations<T> operations,
    InputManager inputManager,
    InterfaceUser ui) where T : struct, IComparable, IConvertible
  {
    protected readonly IListOperations<T> _list = list ?? throw new ArgumentNullException(nameof(list));
    protected readonly IMathOperations<T> _operations = operations ?? throw new ArgumentNullException(nameof(operations));
    protected readonly InputManager _inputManager = inputManager ?? throw new ArgumentNullException(nameof(inputManager));
    protected readonly InterfaceUser _ui = ui ?? throw new ArgumentNullException(nameof(ui));

    // Template Method que define el flujo principal de ejecución.
    public void Execute()
    {
      bool continueLoop = true;
      while (continueLoop)
      {
        _ui.ShowOperationsMenu();
        int option = _inputManager.ReadOption("Seleccione una opción: ", 1, 8);

        try
        {
          continueLoop = ProcessOption(option);
        }
        catch (InsufficientListException ex)
        {
          _ui.ShowError(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
          _ui.ShowError(ex.Message);
        }
        catch (Exception ex)
        {
          _ui.ShowError($"Error inesperado: {ex.Message}");
        }
      }
    }

    // Procesa la opción seleccionada por el usuario.
    // Método privado que implementa la lógica del menú.
    private bool ProcessOption(int option)
    {
      switch (option)
      {
        case 1:
          AddNumber();
          return true;
        case 2:
          PerformOperation(_operations.Add, "Suma");
          return true;
        case 3:
          PerformOperation(_operations.Subtract, "Resta");
          return true;
        case 4:
          PerformOperation(_operations.Multiply, "Multiplicación");
          return true;
        case 5:
          PerformOperation(_operations.Divide, "División");
          return true;
        case 6:
          ShowList();
          return true;
        case 7:
          ClearList();
          return true;
        case 8:
          return false;
        default:
          _ui.ShowError("Opción no válida.");
          return true;
      }
    }

    // Hook method para agregar un número.
    // Puede ser sobrescrito por clases derivadas si necesitan comportamiento específico.
    protected virtual void AddNumber()
    {
      T number = _inputManager.ReadNumber<T>(GetInputMessage());
      _list.AddNumber(number);
      _ui.ShowSuccess($"Número {FormatNumber(number)} agregado correctamente.");
    }

    // Realiza la operación matemática utilizando el patrón Strategy (delegado).
    protected virtual void PerformOperation(OperationMath<T> operation, string operationName)
    {
      T result = _list.PerformOperation(operation);
      _ui.ShowSuccess($"Resultado de la {operationName}: {FormatNumber(result)}");
    }

    // Muestra todos los números de la lista actual.
    protected virtual void ShowList()
    {
      var numbers = ((numberedList<T>)_list).GetNumbers();
      if (numbers.Count == 0)
      {
        _ui.ShowMessage("La lista está vacía.");
      }
      else
      {
        var formattedNumbers = numbers.Select(n => FormatNumber(n));
        _ui.ShowMessage($"Lista actual ({numbers.Count} elementos): [{string.Join(", ", formattedNumbers)}]");
      }
    }

    // Limpia todos los elementos de la lista.
    protected virtual void ClearList()
    {
      _list.ClearList();
      _ui.ShowSuccess("Lista limpiada correctamente.");
    }

    // Define el mensaje específico para solicitar entrada de cada tipo.
    protected abstract string GetInputMessage();

    /// Define el formato de presentación de cada tipo numérico.
    protected abstract string FormatNumber(T number);
  }
}