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