# Laboratorio - Temas Variados en C# y SQL

Ejercicios desarrollados para practicar seguridad en bases de datos (inyección SQL y consultas parametrizadas) y conceptos de programación en C#: métodos sobrecargados, recursividad y conteo de frecuencias.

**Universidad Tecnológica de Panamá - Facultad de Ingeniería en Sistemas**

**Materia:** Herramientas de la programación Aplicada III (.NET) 

**Programado por:** Kevin Esquivel

**Fecha de entrega:** 12 de octubre de 2026

---

## 📋 Descripción

Este repositorio reúne cinco problemas del laboratorio. Cada uno está en su propia carpeta y cuenta con la evidencia de su ejecución.

| # | Problema | Carpeta |
|---|----------|---------|
| 1 | Consultas SQL (inyección SQL) | `Problema1_SQL` |
| 2 | Cadenas: armando INSERT / UPDATE con consultas parametrizadas | `Diccionario` |
| 3 | Métodos sobrecargados | `SobreCargaMetodos` |
| 4 | Recursividad (factorial) | `Factorial` |
| 5 | Frecuencia | `Dados` |

---

## 🛠️ Tecnologías utilizadas

* Lenguaje: C#
* Framework: .NET 10.0 (SDK 10.0)
* IDE: Visual Studio
* Tipo de aplicación: Consola
* Base de datos: MySQL (Problema #1)

---


## 🗄️ Problema #1: Consultas SQL (inyección SQL)

Demostración de tres consultas manipuladas que aprovechan una concatenación insegura de cadenas. Se ejecutan en MySQL sobre la base `problema1_productos`.

Archivos en `Problema1_SQL`:

* El script de creación de la base de datos y la tabla `productos`.
* `consultas_inyeccion.sql`: las tres consultas de la demostración.

| Consulta | Técnica |
|----------|---------|
| `WHERE nombre = '' OR '1'='1'` | Condición siempre verdadera: devuelve todos los registros |
| `WHERE id = 1 AND SLEEP(15)` | Inyección basada en tiempo: la consulta se demora 15 segundos |
| `WHERE nombre = 'Producto' OR 1=1; -- productos` | Uso de comentario para anular el resto de la consulta |

**Consulta 1:**

<img width="513" height="181" alt="image" src="https://github.com/user-attachments/assets/94712ee3-5ef1-499a-987a-5a71a11ea0a6" />


**Consulta 2:**

<img width="443" height="103" alt="image" src="https://github.com/user-attachments/assets/b1d6025a-f8e1-4fcf-99e4-0eabac42c4ea" />


**Consulta 3:**

<img width="559" height="152" alt="image" src="https://github.com/user-attachments/assets/3eedb60a-cad1-4c2c-bf8f-7d154b038067" />


---

## 🔐 Problema #2: Cadenas (armando INSERT / UPDATE) con consultas parametrizadas

A partir de un `Dictionary<string, object>` se arman dinámicamente las sentencias `INSERT` y `UPDATE`. Los valores nunca se concatenan en la cadena SQL: se usan marcadores (`@Nombre`, `@Precio`, `@Id`...) y los valores se envían aparte como parámetros. Esta es la mitigación contra la inyección SQL del Problema #1.

<img width="616" height="189" alt="image" src="https://github.com/user-attachments/assets/e5474e95-2b6a-48a2-ad03-940a5aa25c02" />


---

## 🔁 Problema #3: Métodos sobrecargados

La clase `SobreCarga` define dos métodos `Cuadrado` con el mismo nombre y distinta firma: uno recibe un `int` y otro un `double`. C# elige cuál ejecutar según el tipo del argumento.

<img width="406" height="133" alt="image" src="https://github.com/user-attachments/assets/743aae35-09f4-4dd8-ab21-09774507124e" />


---

## ♾️ Problema #4: Recursividad (factorial)

El método `Factorial` se llama a sí mismo hasta llegar al caso base (`numero <= 1`), lo que evita el desbordamiento de pila. Se calcula el factorial de 0 a 10.

<img width="115" height="206" alt="image" src="https://github.com/user-attachments/assets/7915ce2d-99f0-429a-bae3-8627ddde7e98" />


---

## 🎲 Problema #5: Frecuencia

Se simulan 6000 tiros de un dado y se cuenta cuántas veces sale cada cara (del 1 al 6), mostrando la frecuencia de cada una.

<img width="188" height="138" alt="image" src="https://github.com/user-attachments/assets/6680c540-9859-4cdb-aa9c-013d1fad1f10" />


---

*Universidad Tecnológica de Panamá - Herramientas de la programación Aplicada III (.NET) - 12 de octubre de 2026*
