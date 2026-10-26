# Reto de Estructuras de Control Iterativo en C#

**Actividad:** 220501097-04-AA1 – EV05 – Aplicación de la sintaxis básica de C#  
**Lenguaje:** C#  
**Entorno de desarrollo:** Visual Studio Code  
**Tipo de actividad:** Ejercicio práctico individual

## Descripción

Este proyecto desarrolla el reto de estructuras de control iterativo en C#, aplicando bucles y sentencias de control de flujo para resolver problemas relacionados con las calificaciones de un grupo de estudiantes.

El proyecto está organizado en tres ejercicios independientes, cada uno dentro de su propia carpeta y con su respectivo proyecto de consola.

## Objetivo

Aplicar las estructuras de control iterativo `for`, `foreach`, `while` y `do-while`, junto con las sentencias `break` y `continue`, mediante ejercicios prácticos de programación.

## Estructura del proyecto

```text
RetoEstructurasIterativas/
├── Ejercicio1_ForForeach/
│   ├── Ejercicio1_ForForeach.csproj
│   └── Program.cs
├── Ejercicio2_WhileDoWhile/
│   ├── Ejercicio2_WhileDoWhile.csproj
│   └── Program.cs
├── Ejercicio3_BreakContinue/
│   ├── Ejercicio3_BreakContinue.csproj
│   └── Program.cs
├── RetoEstructurasIterativas.sln
└── README.md
```

## Ejercicios desarrollados

### Ejercicio 1: For y Foreach

**Carpeta:** `Ejercicio1_ForForeach`

Se realizan las siguientes operaciones:

- Recorrido de las calificaciones en orden normal.
- Recorrido de las calificaciones en orden descendente.
- Cálculo de la suma total y el promedio del grupo.
- Recorrido de los índices del array con incremento de dos.

### Ejercicio 2: While y Do-While

**Carpeta:** `Ejercicio2_WhileDoWhile`

Se implementan las siguientes funcionalidades:

- Sistema de control de acceso mediante una clave.
- Validación de la clave con un máximo de tres intentos.
- Menú interactivo que permite consultar el promedio del grupo.
- Consulta de la calificación más alta.
- Validación de opciones y salida del menú.

### Ejercicio 3: Break y Continue

**Carpeta:** `Ejercicio3_BreakContinue`

Se desarrollan las siguientes operaciones:

- Búsqueda de la primera calificación reprobatoria.
- Filtrado de calificaciones aprobatorias.
- Conteo de estudiantes aprobados.
- Uso combinado de `break` y `continue` para controlar el recorrido del array.

## Tecnologías utilizadas

- C#
- .NET SDK
- Visual Studio Code
- Git
- GitHub

## Requisitos previos

Para ejecutar el proyecto se necesita:

- Tener instalado el SDK de .NET.
- Tener una terminal de comandos disponible.
- Descargar o clonar el repositorio en el equipo.

## Cómo ejecutar los ejercicios

Abre una terminal en la carpeta principal del proyecto y ejecuta el comando correspondiente a cada ejercicio.

**Ejercicio 1:**

```bash
dotnet run --project Ejercicio1_ForForeach
```

**Ejercicio 2:**

```bash
dotnet run --project Ejercicio2_WhileDoWhile
```

**Ejercicio 3:**

```bash
dotnet run --project Ejercicio3_BreakContinue
```

## Verificación de compilación

Para compilar los tres proyectos desde la carpeta principal, ejecuta:

```bash
dotnet build RetoEstructurasIterativas.sln
```

Si la compilación finaliza correctamente, los proyectos estarán listos para ejecutarse.

## Autor

**Aprendiz:** Samuel Vanegas Quintero

## Conclusión

El desarrollo de este reto permite practicar las estructuras de control iterativo en C#, fortalecer la lógica de programación y comprender cómo recorrer colecciones, validar datos y controlar la ejecución de los bucles mediante condiciones.
