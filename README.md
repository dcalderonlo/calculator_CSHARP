# 📘 Bienvenido a GenericCalculator_CSharp

¡Bienvenido! Este proyecto es una aplicación en **C#** diseñada para realizar operaciones matemáticas (suma, resta, multiplicación y división) sobre listas genéricas de números. 

El objetivo principal es demostrar el uso de **genéricos**, **delegados** y **control de excepciones** en un entorno práctico y sencillo.

## ✨ Funcionalidades

La aplicación permite:
- Trabajar con diferentes tipos de datos numéricos (`int`, `double`, `decimal`).
- Definir operaciones matemáticas mediante **delegados**.
- Manejar errores comunes como entradas inválidas, listas vacías o división por cero.
- Interactuar con el usuario a través de una interfaz de consola clara y amigable.

Este repositorio servirá como base para explorar conceptos fundamentales de programación en C#, aplicados a un caso real de manipulación de listas y operaciones matemáticas.

---

## 🚀 Características Principales

- **Arquitectura Genérica**: Capacidad de procesar listas de tipos `int`, `double`, `float` y `decimal` utilizando una única lógica de negocio, evitando la duplicación de código.

- **Operaciones Flexibles**: Implementación de aritmética básica (Suma, Resta, Multiplicación y División) desacoplada mediante el uso de **Delegados**, lo que permite extender las funcionalidades fácilmente.

- **Robustez**: Sistema integral de control de excepciones que garantiza la estabilidad ante:
    * Entradas de formato incorrecto (`FormatException`).
    * Operaciones matemáticas ilegales (`DivideByZeroException`).
    * Estados inválidos de la lista (`InvalidOperationException`).

---

## 🛠️ Tecnologías Utilizadas

- **Lenguaje**: C# (.NET Core / .NET 10+)  
- **Paradigma**: Programación Orientada a Objetos y Programación Funcional (Delegados)  
- **Conceptos Clave**: `Generics`, `Delegates`, `Exception Handling`


# 🧮 Calculator C# - Sistema de Operaciones Matemáticas

## 📋 Propósito del Proyecto

Este proyecto es una **aplicación de consola en C#** que implementa un sistema calculadora avanzado utilizando **Clean Architecture** y los principios **SOLID**. El sistema permite realizar operaciones matemáticas (suma, resta, multiplicación y división) sobre listas de números de diferentes tipos (enteros, decimales de punto flotante y decimales de alta precisión).

### **Objetivos Principales:**

1. ✅ **Demostrar Clean Architecture** en un proyecto real de C#
2. ✅ **Aplicar principios SOLID** en todos los niveles del código
3. ✅ **Implementar genéricos** para reutilización de código type-safe
4. ✅ **Utilizar delegados** para operaciones matemáticas dinámicas
5. ✅ **Gestionar excepciones** de manera robusta y profesional
6. ✅ **Seguir convenciones de C#** con nombres en inglés

---

## 🏗️ Arquitectura del Proyecto

El proyecto sigue **Clean Architecture** de Robert C. Martin ("Uncle Bob"), organizado en **4 capas concéntricas**:

```
┌──────────────────────────────────────────┐
│     PRESENTATION LAYER                    │  ← Capa 4: Interfaz de Usuario
│  (Controllers, UI, Program.cs)           │
│                                          │
│  ┌────────────────────────────────────┐ │
│  │   INFRASTRUCTURE LAYER             │ │  ← Capa 3: Detalles Técnicos
│  │   (InputManager)                   │ │
│  │                                    │ │
│  │  ┌──────────────────────────────┐ │ │
│  │  │  APPLICATION LAYER           │ │ │  ← Capa 2: Lógica de Aplicación
│  │  │  (Services, Validators)      │ │ │
│  │  │                              │ │ │
│  │  │  ┌────────────────────────┐ │ │ │
│  │  │  │   DOMAIN LAYER         │ │ │ │  ← Capa 1: Núcleo del Negocio
│  │  │  │   (Entities,           │ │ │ │
│  │  │  │    Interfaces,         │ │ │ │
│  │  │  │    Exceptions)         │ │ │ │
│  │  │  └────────────────────────┘ │ │ │
│  │  └──────────────────────────────┘ │ │
│  └────────────────────────────────────┘ │
└──────────────────────────────────────────┘

Las dependencias SIEMPRE apuntan hacia el centro ➜
```

### **Estructura de Carpetas:**

```
calculator_CSHARP/
│
├── Domain/                             ← CAPA 1: Dominio (núcleo independiente)
│   ├── Entities/
│   │   └── NumberedList.cs            (Lista genérica de números)
│   ├── Interfaces/
│   │   ├── IListOperations.cs         (Operaciones de lista)
│   │   ├── IValidator.cs              (Validaciones)
│   │   └── IMathOperations.cs         (Operaciones matemáticas)
│   ├── Exceptions/
│   │   └── InsufficientListException.cs  (Excepción de negocio)
│   └── Delegates/
│       └── OperationMath.cs           (Delegado para operaciones)
│
├── Application/                        ← CAPA 2: Aplicación
│   └── Services/
│       ├── NumericValidator.cs        (Validador genérico)
│       ├── OperationInt.cs            (Operaciones para int)
│       ├── OperationDouble.cs         (Operaciones para double)
│       └── OperationDecimal.cs        (Operaciones para decimal)
│
├── Infrastructure/                     ← CAPA 3: Infraestructura
│   └── input/
│       └── InputManager.cs            (Gestor de entrada del usuario)
│
├── Presentation/                       ← CAPA 4: Presentación
│   ├── Controllers/
│   │   ├── ControllerBase.cs          (Template Method)
│   │   ├── ControllerInt.cs           (Para int)
│   │   ├── ControllerDouble.cs        (Para double)
│   │   └── ControllerDecimal.cs       (Para decimal)
│   └── UI/
│       └── InterfaceUser.cs           (Interfaz visual)
│
├── Program.cs                          ← Composition Root
└── calculator_CSHARP.csproj           ← Configuración del proyecto
```

---

## ⚙️ Tecnologías Utilizadas

- **Lenguaje:** C# 13
- **Framework:** .NET 10.0
- **Paradigma:** Programación Orientada a Objetos (POO)
- **Arquitectura:** Clean Architecture
- **Principios:** SOLID
- **Características de C# utilizadas:**
  - Genéricos (`<T>`)
  - Delegados
  - Excepciones personalizadas
  - Inyección de dependencias manual
  - Pattern Matching
  - Nullable reference types

---

## 🚀 Instrucciones para Ejecutar el Programa

### **Requisitos Previos:**

- **.NET 10 SDK** instalado ([Descargar aquí](https://dotnet.microsoft.com/download/dotnet/10.0))
- **Terminal/Consola** (CMD, PowerShell, Bash, Zsh, etc.)
- (Opcional) **Visual Studio 2022+** o **Visual Studio Code** con extensión de C#

### **Verificar Instalación de .NET:**

```bash
dotnet --version
# Debe mostrar: 10.0.x
```

### **Opción 1: Ejecutar desde la carpeta del proyecto (RECOMENDADA)**

```bash
# 1. Navegar a la carpeta del proyecto
cd "Tarea práctica 2 - Unidad 2 /calculator_CSHARP"

# 2. Compilar el proyecto
dotnet build

# 3. Ejecutar el proyecto
dotnet run
```

### **Opción 2: Ejecutar desde la carpeta raíz**

```bash
# 1. Navegar a la carpeta raíz
cd "Tarea práctica 2 - Unidad 2 "

# 2. Compilar especificando el proyecto
dotnet build calculator_CSHARP/calculator_CSHARP.csproj

# 3. Ejecutar especificando el proyecto
dotnet run --project calculator_CSHARP
```

### **Opción 3: Ejecutar el binario compilado directamente**

```bash
cd "Tarea práctica 2 - Unidad 2 /calculator_CSHARP"
dotnet build
./bin/Debug/net10.0/calculator_CSHARP
```

### **Compilación para Producción (Release):**

```bash
cd calculator_CSHARP
dotnet build --configuration Release
dotnet run --configuration Release
```

---

## 🎮 Uso del Programa

### **Flujo de Uso:**

1. **Inicio:** El programa muestra el menú principal
2. **Seleccionar tipo de dato:** Enteros (int), Decimales (double), o Alta precisión (decimal)
3. **Menú de operaciones:**
   - Agregar números a la lista
   - Realizar operaciones (suma, resta, multiplicación, división)
   - Ver lista actual
   - Limpiar lista
   - Volver al menú principal

### **Ejemplo de Sesión:**

```
╔════════════════════════════════════════════════════════════╗
║          SISTEMA DE OPERACIONES MATEMÁTICAS               ║
║           Clean Architecture + SOLID + .NET 10            ║
╚════════════════════════════════════════════════════════════╝

╔══════════════════════════════════════════╗
║  SISTEMA DE OPERACIONES MATEMÁTICAS     ║
║        Clean Architecture + SOLID        ║
╚══════════════════════════════════════════╝
1. Trabajar con números enteros (int)
2. Trabajar con números decimales (double)
3. Trabajar con números precisos (decimal)
4. Salir

Seleccione el tipo de dato: 1

═══ Trabajando con números enteros (int) ═══

╔═══════════ MENÚ DE OPERACIONES ══════════╗
║ 1. Agregar número                        ║
║ 2. Sumar todos los números               ║
║ 3. Restar todos los números              ║
║ 4. Multiplicar todos los números         ║
║ 5. Dividir todos los números             ║
║ 6. Ver lista actual                      ║
║ 7. Limpiar lista                         ║
║ 8. Volver al menú principal              ║
╚══════════════════════════════════════════╝

Seleccione una opción: 1
Ingrese un número entero: 10
✓ Número 10 agregado correctamente.

Seleccione una opción: 1
Ingrese un número entero: 5
✓ Número 5 agregado correctamente.

Seleccione una opción: 2
✓ Resultado de la Suma: 15

Seleccione una opción: 5
✓ Resultado de la División: 2
```

---

## 🛡️ Manejo de Excepciones

El programa implementa un **sistema robusto de manejo de excepciones** en múltiples niveles:

### **1. Excepciones Personalizadas del Dominio**

#### **`InsufficientListException`**
- **Tipo:** Excepción de dominio personalizada
- **Hereda de:** `InvalidOperationException`
- **Ubicación:** `Domain/Exceptions/InsufficientListException.cs`
- **Cuándo se lanza:** Cuando se intenta realizar una operación con menos de 2 números
- **Ejemplo:**
  ```C#
  if (count < MinimumElementCount)
  {
      throw new InsufficientListException(
          $"La lista debe contener al menos {MinimumElementCount} números...");
  }
  ```

### **2. Validaciones en la Capa de Dominio**

#### **`NumericValidator<T>`**
- **Ubicación:** `Application/Services/NumericValidator.cs`
- **Validaciones implementadas:**
  
  **a) Validación de lista suficiente:**
  ```C#
  public void ValidateSufficientList(int count)
  {
      if (count < 2)
      {
          throw new InsufficientListException(
              "La lista debe contener al menos 2 números...");
      }
  }
  ```
  
  **b) Validación de división por cero:**
  ```C#
  public void ValidateDivisionByZero(T divisor)
  {
      double value = Convert.ToDouble(divisor);
      if (Math.Abs(value) < double.Epsilon)
      {
          throw new DivideByZeroException(
              "No se puede dividir entre cero.");
      }
  }
  ```

### **3. Manejo de Excepciones en Controladores**

#### **`ControllerBase<T>.Execute()`**
- **Ubicación:** `Presentation/Controllers/ControllerBase.cs`
- **Estrategia:** Try-Catch con captura específica
- **Implementación:**
  ```C#
  try
  {
      continueLoop = ProcessOption(option);
  }
  catch (InsufficientListException ex)
  {
      _ui.ShowError(ex.Message);  // Error de negocio
  }
  catch (DivideByZeroException ex)
  {
      _ui.ShowError(ex.Message);  // Error matemático
  }
  catch (Exception ex)
  {
      _ui.ShowError($"Error inesperado: {ex.Message}");  // Cualquier otro error
  }
  ```

### **4. Validación de Entrada del Usuario**

#### **`InputManager`**
- **Ubicación:** `Infrastructure/input/InputManager.cs`
- **Validaciones:**
  
  **a) Validación de tipo de dato:**
  ```C#
  public T ReadNumber<T>(string message) where T : struct, IComparable, IConvertible
  {
      while (true)
      {
          try
          {
              Console.Write(message);
              string input = Console.ReadLine();
              return (T)Convert.ChangeType(input, typeof(T));
          }
          catch (FormatException)
          {
              Console.WriteLine("Error: Debe ingresar un valor numérico válido...");
          }
          catch (OverflowException)
          {
              Console.WriteLine("Error: El valor es demasiado grande o pequeño...");
          }
      }
  }
  ```
  
  **b) Validación de opciones de menú:**
  ```C#
  public int ReadOption(string message, int min, int max)
  {
      while (true)
      {
          try
          {
              int option = int.Parse(Console.ReadLine());
              if (option >= min && option <= max)
                  return option;
              
              Console.WriteLine($"Por favor, ingrese un número entre {min} y {max}.");
          }
          catch (FormatException)
          {
              Console.WriteLine("Error: Debe ingresar un número entero.");
          }
      }
  }
  ```

### **5. Jerarquía de Excepciones**

```
Exception (Base de .NET)
│
├── SystemException
│   │
│   ├── InvalidOperationException
│   │   └── InsufficientListException ← Excepción personalizada
│   │
│   ├── DivideByZeroException ← Usada para división por cero
│   │
│   ├── FormatException ← Capturada en InputManager
│   │
│   └── OverflowException ← Capturada en InputManager
│
└── ArgumentNullException ← Validación de dependencias en constructores
```

### **6. Estrategia de Manejo por Capa**

| Capa | Estrategia | Ejemplo |
|------|-----------|---------|
| **Domain** | Lanza excepciones de negocio | `throw new InsufficientListException(...)` |
| **Application** | Valida y lanza excepciones | `ValidateDivisionByZero()` |
| **Infrastructure** | Captura errores de entrada y reintenta | `try-catch` con bucle while |
| **Presentation** | Captura todas las excepciones y muestra al usuario | `catch` específicos + genérico |

### **7. Mensajes de Error Amigables**

El programa convierte excepciones técnicas en mensajes comprensibles:

| Excepción | Mensaje al Usuario |
|-----------|-------------------|
| `InsufficientListException` | ✗ La lista debe contener al menos 2 números para realizar una operación. |
| `DivideByZeroException` | ✗ No se puede dividir entre cero. |
| `FormatException` | ✗ Error: Debe ingresar un valor numérico válido de tipo int. |
| `OverflowException` | ✗ Error: El valor es demasiado grande o pequeño para el tipo int. |
| `Exception` (genérica) | ✗ Error inesperado: [detalle técnico] |

### **8. Ventajas del Manejo de Excepciones Implementado**

✅ **Específico:** Captura excepciones específicas antes que la genérica  
✅ **Informativo:** Mensajes claros y útiles para el usuario  
✅ **Robusto:** El programa nunca se cae, siempre permite recuperación  
✅ **Limpio:** Separación clara entre validación, ejecución y presentación  
✅ **Profesional:** Sigue best practices de C# y .NET  

---

## 🎯 Principios SOLID Implementados

### **S - Single Responsibility Principle (SRP)**
Cada clase tiene una única razón para cambiar:

| Clase | Responsabilidad Única |
|-------|---------------------|
| `NumberedList<T>` | Gestionar colección de números |
| `NumericValidator<T>` | Validar reglas de negocio |
| `OperationInt` | Operaciones matemáticas para enteros |
| `InputManager` | Leer entrada del usuario |
| `InterfaceUser` | Mostrar información visual |
| `ControllerBase<T>` | Coordinar flujo de presentación |

### **O - Open/Closed Principle (OCP)**
Abierto para extensión, cerrado para modificación:

```C#
// Para agregar un nuevo tipo (float), NO modificas código existente:

// 1. Crear nuevo servicio
public class OperationFloat : IMathOperations<float> { }

// 2. Crear nuevo controlador
public class ControllerFloat : ControllerBase<float> { }

// 3. Agregar en Program.cs
static void ExecuteWithFloat(...) { }
```

### **L - Liskov Substitution Principle (LSP)**
Las implementaciones son intercambiables:

```C#
// Puedes usar cualquier implementación de IListOperations<T>
IListOperations<int> list = new NumberedList<int>(validator);
// O cualquier otra implementación futura sin romper el código

// Lo mismo con operaciones
IMathOperations<int> ops = new OperationInt(validator);
```

### **I - Interface Segregation Principle (ISP)**
Interfaces específicas y cohesivas:

- `IListOperations<T>` → Solo 4 métodos de lista
- `IValidator<T>` → Solo 2 métodos de validación
- `IMathOperations<T>` → Solo 4 operaciones matemáticas

**Ninguna clase implementa métodos que no necesita.**

### **D - Dependency Inversion Principle (DIP)**
Las dependencias apuntan hacia abstracciones:

```C#
// Alto nivel (ControllerBase) depende de abstracciones
public abstract class ControllerBase<T>
{
    protected readonly IListOperations<T> _list;           // ← Interface
    protected readonly IMathOperations<T> _operations;     // ← Interface
    // NO depende de NumberedList o OperationInt (concretas)
}

// Las implementaciones concretas se inyectan en el Composition Root
var list = new NumberedList<int>(validator);  // ← Composición
var controller = new ControllerInt(list, ...); // ← Inyección
```

---

## 🔧 Características Técnicas Avanzadas

### **1. Genéricos Type-Safe**
```C#
public class NumberedList<T> : IListOperations<T> 
    where T : struct, IComparable, IConvertible
{
    // Funciona con int, double, decimal, float, etc.
}
```

### **2. Delegados para Estrategias**
```C#
public delegate T OperationMath<T>(T a, T b);

// Uso:
T result = _list.PerformOperation(_operations.Add);
```

### **3. Template Method Pattern**
```C#
// ControllerBase define el algoritmo
public void Execute() { ... }

// Subclases implementan pasos específicos
protected abstract string GetInputMessage();
protected abstract string FormatNumber(T number);
```

### **4. Dependency Injection Manual**
```C#
// Program.cs actúa como Composition Root
var validator = new NumericValidator<int>();
var list = new NumberedList<int>(validator);
var operations = new OperationInt(validator);
var controller = new ControllerInt(list, operations, inputManager, ui);
```

### **5. Null Safety**
```C#
public ControllerBase(
    IListOperations<T> list,
    IMathOperations<T> operations,
    InputManager inputManager,
    InterfaceUser ui)
{
    _list = list ?? throw new ArgumentNullException(nameof(list));
    _operations = operations ?? throw new ArgumentNullException(nameof(operations));
    // ...
}
```

---

## 📚 Recursos y Referencias

- **Clean Architecture** - Robert C. Martin
- **SOLID Principles** - Robert C. Martin
- **C# Programming Guide** - Microsoft Docs
- **.NET 10 Documentation** - Microsoft

---

## ✅ Estado del Proyecto

- [x] Clean Architecture implementada
- [x] Principios SOLID aplicados
- [x] Manejo robusto de excepciones
- [x] Validaciones completas
- [x] Código documentado
- [x] Genéricos type-safe
- [x] Delegados para operaciones
- [x] Separación de responsabilidades
- [x] Inyección de dependencias
- [x] Compilación exitosa sin errores

---

## 👤 Autor

**Proyecto Académico** - Tarea Práctica 2 - Unidad 2

---

## 📄 Licencia

Este proyecto es de uso educativo.

---

**Versión:** 1.0.0  
**Framework:** .NET 10.0  
**Fecha:** 2026