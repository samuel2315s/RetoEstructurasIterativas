# Reto de Estructuras de Control Iterativo en C#

**Actividad:** 220501097-04-AA1 – EV05 – Aplicación de la sintaxis básica de C#  
**Lenguaje:** C#  
**Entorno de desarrollo:** Visual Studio Code  
**Tipo de actividad:** Ejercicio práctico individual  
**Aprendiz:** Samuel Vanegas Quintero

## Descripción

Este proyecto desarrolla el reto de estructuras de control iterativo en C#, aplicando bucles y sentencias de control de flujo para resolver problemas relacionados con las calificaciones de un grupo de estudiantes.

Los tres ejercicios se encuentran implementados dentro de un mismo proyecto de consola, utilizando un único archivo `Program.cs`.

## Objetivo

Aplicar las estructuras de control iterativo `for`, `foreach`, `while` y `do-while`, junto con las sentencias `break` y `continue`, mediante ejercicios prácticos de programación.

## Estructura del proyecto

```text
RetoEstructurasIterativas/
├── Program.cs
├── RetoEstructurasIterativas.csproj
├── RetoEstructurasIterativas.sln
└── README.md
```

## Ejercicios desarrollados

### Ejercicio 1: For y Foreach

Se realizan las siguientes operaciones:

- Recorrido de las calificaciones en orden normal.
- Recorrido de las calificaciones en orden descendente.
- Cálculo de la suma total y el promedio del grupo.
- Recorrido de las posiciones del array con incremento de dos.

### Ejercicio 2: While y Do-While

Se implementan las siguientes funcionalidades:

- Sistema de control de acceso mediante una clave.
- Validación de la clave con un máximo de tres intentos.
- Menú interactivo para consultar el promedio del grupo.
- Consulta de la calificación más alta.
- Validación de opciones y salida del menú.

### Ejercicio 3: Break y Continue

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

Para ejecutar el proyecto, se necesita:

- Tener instalado el SDK de .NET.
- Disponer de Visual Studio Code o una terminal de comandos.
- Tener Git instalado si se desea gestionar el control de versiones.

Para comprobar la instalación de .NET, ejecuta:

```bash
dotnet --version
```

## Cómo ejecutar el proyecto

Abre una terminal en la carpeta principal del proyecto y ejecuta:

```bash
dotnet run
```

Este comando compila y ejecuta el proyecto de consola.

Para compilar el proyecto sin ejecutarlo, utiliza:

```bash
dotnet build
```

Si deseas compilar la solución completa, ejecuta:

```bash
dotnet build RetoEstructurasIterativas.sln
```

## Ejemplos de ejecución

### Ejercicio 1: Registro de calificaciones

```text
=== REGISTRO DE CALIFICACIONES ===
Estudiante 1: 72
Estudiante 2: 85
Estudiante 3: 91
Estudiante 4: 60
Estudiante 5: 43
Estudiante 6: 78
Estudiante 7: 95
Estudiante 8: 55
Estudiante 9: 88
Estudiante 10: 67

=== ORDEN DESCENDENTE ===
Estudiante 10: 67
Estudiante 9: 88
Estudiante 8: 55
Estudiante 7: 95
Estudiante 6: 78
Estudiante 5: 43
Estudiante 4: 60
Estudiante 3: 91
Estudiante 2: 85
Estudiante 1: 72

=== PROMEDIO DEL GRUPO ===
Suma total: 734
Promedio: 73.4

=== POSICIONES PARES ===
Posición par: 72
Posición par: 91
Posición par: 43
Posición par: 95
Posición par: 88
```

### Ejercicio 2: Control de acceso y menú

```text
=== CONTROL DE ACCESO ===
Ingresa la clave: sena2026
Acceso concedido.

=== MENÚ PRINCIPAL ===
1. Ver promedio del grupo
2. Ver calificación más alta
3. Salir
Elige una opción: 1
Promedio del grupo: 73.4

Elige una opción: 2
Calificación más alta: 95

Elige una opción: 3
Hasta luego.
```

### Ejercicio 3: Break y Continue

```text
=== PRIMERA CALIFICACIÓN REPROBATORIA ===
Encontrada en posición 5: 43

=== ESTUDIANTES APROBADOS ===
Aprobado: 72
Aprobado: 85
Aprobado: 91
Aprobado: 60
Aprobado: 78
Aprobado: 95
Aprobado: 88
Aprobado: 67
Total aprobados: 8

=== FILTRO COMBINADO ===
Calificación procesada: 72
Calificación procesada: 85
Calificación procesada: 91
Calificación procesada: 78
Búsqueda detenida al encontrar: 95
```

**Nota:** Las salidas presentadas son ejemplos de ejecución. La salida real puede variar según la interacción con el programa.

## Verificación de compilación

Para comprobar que el proyecto compila correctamente, ejecuta:

```bash
dotnet build
```

Si la compilación finaliza sin errores, el proyecto estará listo para ejecutarse.

## Control de versiones

Git se utiliza para registrar los cambios realizados durante el desarrollo, mientras que GitHub permite alojar el repositorio y compartir el código fuente.

## Autor

**Aprendiz:** Samuel Vanegas Quintero

## Conclusión

El desarrollo de este reto permite practicar las estructuras de control iterativo en C#, fortalecer la lógica de programación y comprender cómo recorrer colecciones, validar datos y controlar la ejecución de los bucles mediante condiciones y sentencias de control de flujo.
