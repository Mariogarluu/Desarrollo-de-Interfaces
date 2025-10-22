# Hola Mundo - Primer Proyecto en C#

Aplicación de consola básica en C# que muestra el mensaje "Hola Mundo" en la pantalla.

## 📋 Descripción

Este es el proyecto tradicional "Hola Mundo", el primer programa que se suele escribir al aprender un nuevo lenguaje de programación. Demuestra la estructura básica de una aplicación de consola en C# y familiariza al desarrollador con el entorno de Visual Studio.

## 📁 Estructura del Proyecto

```
Hola_Mundo/
├── .vs/                    # Configuración de Visual Studio (ignorar)
├── Hola_Mundo/             # Carpeta del proyecto principal
│   ├── bin/                # Archivos compilados (ejecutables)
│   ├── obj/                # Archivos temporales de compilación
│   ├── Properties/         # Propiedades del proyecto
│   ├── App.config          # Configuración de la aplicación
│   ├── Hola_Mundo.csproj   # Archivo de proyecto C#
│   └── Program.cs          # Código fuente principal
├── Hola_Mundo.sln          # Archivo de solución de Visual Studio
└── README.md               # Este archivo
```

## 💻 Código Fuente

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
        }
    }
}
```

## 🔍 Explicación del Código

### Directivas `using`
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
```
Importan los namespaces necesarios. `System` contiene la clase `Console` que se utiliza para la entrada/salida en consola.

### Namespace
```csharp
namespace Hola_Mundo
```
Organiza el código dentro de un espacio de nombres único, evitando conflictos de nombres con otras bibliotecas.

### Clase Program
```csharp
internal class Program
```
Define la clase principal del programa. `internal` significa que solo es accesible dentro del mismo ensamblado.

### Método Main
```csharp
static void Main(string[] args)
```
- **Punto de entrada** de la aplicación
- `static`: Se puede llamar sin crear una instancia de la clase
- `void`: No devuelve ningún valor
- `string[] args`: Parámetros de línea de comandos (no se usan en este ejemplo)

### Console.WriteLine
```csharp
Console.WriteLine("Hola Mundo");
```
Escribe el texto "Hola Mundo" en la consola y añade un salto de línea al final.

## 🚀 Cómo Ejecutar

### Opción 1: Visual Studio
1. Abrir el archivo `Hola_Mundo.sln` con Visual Studio
2. Presionar `F5` o hacer clic en el botón "Iniciar"
3. Se abrirá una ventana de consola mostrando "Hola Mundo"

### Opción 2: Línea de Comandos (con MSBuild)
```bash
# Compilar el proyecto
msbuild Hola_Mundo.sln

# Ejecutar el programa
cd Hola_Mundo\bin\Debug
Hola_Mundo.exe
```

### Opción 3: .NET CLI (si se migra a .NET Core)
```bash
cd Hola_Mundo
dotnet run
```

## 📊 Salida Esperada

```
Hola Mundo
```

## 🎯 Objetivos de Aprendizaje

1. **Familiarizarse con Visual Studio**: Aprender a navegar por el IDE
2. **Entender la estructura básica**: Conocer los componentes de un proyecto C#
3. **Compilar y ejecutar**: Proceso de build y ejecución
4. **Sintaxis fundamental**: Namespaces, clases, métodos
5. **Entrada/Salida**: Uso de la clase Console

## 🔧 Configuración del Proyecto

### App.config
Archivo de configuración XML que especifica la versión de .NET Framework:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.x" />
    </startup>
</configuration>
```

### Hola_Mundo.csproj
Archivo de proyecto que contiene:
- Referencias a bibliotecas
- Archivos incluidos en el proyecto
- Configuraciones de compilación
- Versión de .NET Framework

## 💡 Posibles Mejoras

Una vez comprendido este programa básico, puedes:

1. **Pedir nombre al usuario**:
```csharp
Console.Write("¿Cómo te llamas? ");
string nombre = Console.ReadLine();
Console.WriteLine($"Hola {nombre}!");
```

2. **Agregar colores**:
```csharp
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Hola Mundo");
Console.ResetColor();
```

3. **Mantener la ventana abierta**:
```csharp
Console.WriteLine("Hola Mundo");
Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();
```

## 🐛 Solución de Problemas

### El programa se cierra inmediatamente
Añadir al final del método Main:
```csharp
Console.ReadKey();
```

### Error de compilación
- Verificar que todas las llaves `{}` estén correctamente cerradas
- Comprobar que los puntos y comas `;` estén presentes
- Asegurarse de que el namespace `System` esté importado

### Visual Studio no encuentra el archivo
- Limpiar la solución: `Build > Clean Solution`
- Reconstruir: `Build > Rebuild Solution`

## 📚 Conceptos Relacionados

- **Aplicación de Consola**: Programa que se ejecuta en una ventana de terminal
- **Compilación**: Proceso de convertir código fuente a código ejecutable
- **.NET Framework**: Plataforma de desarrollo de Microsoft
- **IL (Intermediate Language)**: Código intermedio generado por el compilador de C#
- **CLR (Common Language Runtime)**: Máquina virtual que ejecuta el código .NET

## 🔗 Recursos Adicionales

- [Tu primer programa en C#](https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/inside-a-program/)
- [Console Class](https://docs.microsoft.com/es-es/dotnet/api/system.console)
- [Tutorial de C# para principiantes](https://www.tutorialsteacher.com/csharp/first-csharp-program)

---

**Siguiente paso**: Crear una aplicación con entrada de usuario y lógica más compleja.
