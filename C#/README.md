# Proyectos en C#

Esta carpeta contiene proyectos desarrollados en C# como parte del curso de Desarrollo de Interfaces.

## 📋 Descripción

C# es un lenguaje de programación moderno y orientado a objetos desarrollado por Microsoft. Es ampliamente utilizado para desarrollar aplicaciones de escritorio, web y móviles, especialmente dentro del ecosistema .NET.

## 📁 Proyectos

### Hola_Mundo
Proyecto inicial en C# que demuestra la estructura básica de una aplicación de consola.
- Aplicación de consola simple
- Primer contacto con la sintaxis de C#
- Estructura de un proyecto Visual Studio

### Tarea 3
Próxima tarea a desarrollar en C#.

## 🛠️ Requisitos

Para trabajar con estos proyectos necesitas:

- **Visual Studio 2017 o superior** (recomendado)
  - [Descargar Visual Studio Community](https://visualstudio.microsoft.com/es/vs/community/) (gratis)
- **Visual Studio Code** (alternativa ligera)
  - Requiere la extensión de C#
  - [Descargar VS Code](https://code.visualstudio.com/)
- **.NET Framework** o **.NET Core/5+**
  - Incluido con Visual Studio
  - [Descargar .NET SDK](https://dotnet.microsoft.com/download)

## 🚀 Cómo Ejecutar los Proyectos

### Con Visual Studio
1. Abrir el archivo `.sln` (solución) con Visual Studio
2. Presionar `F5` o hacer clic en "Iniciar" para compilar y ejecutar
3. La aplicación se ejecutará en una ventana de consola

### Con Línea de Comandos
```bash
# Navegar a la carpeta del proyecto
cd "C#/Hola_Mundo"

# Compilar el proyecto
msbuild Hola_Mundo.sln

# Ejecutar el ejecutable generado
cd Hola_Mundo/bin/Debug
./Hola_Mundo.exe
```

### Con .NET CLI (si usas .NET Core)
```bash
# Navegar a la carpeta del proyecto
cd "C#/Hola_Mundo/Hola_Mundo"

# Compilar y ejecutar
dotnet run
```

## 📚 Conceptos Fundamentales de C#

### Estructura de un Programa C#
```csharp
using System;  // Importación de namespaces

namespace MiProyecto  // Namespace del proyecto
{
    class Program  // Clase principal
    {
        static void Main(string[] args)  // Punto de entrada
        {
            Console.WriteLine("Hola Mundo");
        }
    }
}
```

### Elementos Clave
- **using**: Importa namespaces (bibliotecas)
- **namespace**: Organiza el código en espacios de nombres
- **class**: Define una clase
- **Main**: Método principal (punto de entrada del programa)
- **Console.WriteLine**: Escribe texto en la consola

## 🎯 Objetivos de Aprendizaje

- Familiarizarse con la sintaxis de C#
- Comprender la estructura de un proyecto C#
- Aprender a compilar y ejecutar aplicaciones
- Dominar Visual Studio como IDE de desarrollo
- Prepararse para desarrollar interfaces gráficas con Windows Forms o WPF

## 🔗 Recursos Útiles

- [Documentación oficial de C#](https://docs.microsoft.com/es-es/dotnet/csharp/)
- [Tutorial de C# para principiantes](https://www.tutorialsteacher.com/csharp)
- [Microsoft Learn - C#](https://docs.microsoft.com/es-es/learn/paths/csharp-first-steps/)
- [C# Programming Guide](https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/)

## 💡 Próximos Pasos

Después de dominar las aplicaciones de consola, el siguiente paso es:
1. **Windows Forms**: Para crear aplicaciones de escritorio con interfaz gráfica
2. **WPF (Windows Presentation Foundation)**: Para interfaces más modernas y flexibles
3. **ASP.NET**: Para aplicaciones web
4. **Xamarin/MAUI**: Para aplicaciones móviles multiplataforma

## 📝 Notas

- Los archivos `.csproj` contienen la configuración del proyecto
- Los archivos `.sln` son soluciones que pueden contener múltiples proyectos
- La carpeta `bin/` contiene los archivos compilados
- La carpeta `obj/` contiene archivos temporales de compilación
- Las carpetas `.vs/` contienen configuraciones específicas de Visual Studio
