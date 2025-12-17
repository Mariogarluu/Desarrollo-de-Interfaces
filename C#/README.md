# Proyectos en C#

← [Volver al Inicio](../README.md)

Esta carpeta contiene proyectos desarrollados en C# como parte del curso de Desarrollo de Interfaces.

## 📋 Descripción

C# es un lenguaje de programación moderno y orientado a objetos desarrollado por Microsoft. Es ampliamente utilizado para desarrollar aplicaciones de escritorio, web y móviles, especialmente dentro del ecosistema .NET.

## 📁 Proyectos

### Proyectos Básicos y de Consola

#### [Hola_Mundo](Hola_Mundo)
Proyecto inicial en C# que demuestra la estructura básica de una aplicación de consola.
- Aplicación de consola simple
- Primer contacto con la sintaxis de C#
- Estructura de un proyecto Visual Studio

#### [Tarea 3 - Ejercicios de Inicio](https://github.com/Mariogarluu/Ejercicios-Incio-C-)
Colección de ejercicios iniciales en C# (repositorio externo).
- **Nota**: Este es un submodule de Git que apunta a un repositorio externo
- Contiene ejercicios prácticos para reforzar los conceptos básicos de C#
- Para clonar con el submodule: `git clone --recurse-submodules <repo-url>`
- Para inicializar después de clonar: `git submodule update --init --recursive`

#### [Reloj](Reloj)
Aplicación de consola que implementa funcionalidades de reloj.
- Trabajo con tiempo y fechas en C#
- Uso de clases `Archivo` y `Asistente_Descarga`
- Aplicación práctica de conceptos de programación

### Proyectos WPF (Windows Presentation Foundation)

#### [Basicos_WPF](Basicos_WPF)
Proyecto introductorio a Windows Presentation Foundation.
- Introducción a XAML y WPF
- Estructura básica de una aplicación WPF
- Primeros pasos con interfaces gráficas en .NET

#### [DemoControles](DemoControles)
Demostración de diversos controles WPF.
- Ejemplos de controles básicos (Button, TextBox, Label, etc.)
- Layouts y organización de interfaces
- Interacción con controles

#### [Prueba](Prueba)
Proyecto de prueba para experimentar con WPF.
- Espacio de pruebas para nuevas funcionalidades
- Experimentación con controles y eventos

#### [Zoo](zoo)
Aplicación de gestión de zoo con base de datos SQLite.
- Integración con base de datos SQLite
- Operaciones CRUD (Create, Read, Update, Delete)
- Aplicación práctica de WPF con datos persistentes
- Uso de `Zoo.db` para almacenar información

#### [MiLibreriaWPF](MiLibreriaWPF)
Librería personalizada de controles WPF.
- Creación de controles personalizados
- Reutilización de componentes
- Uso de `Generic.xaml` para estilos
- Empaquetado como librería

#### [Proyecto_Series](Proyecto_Series)
Proyecto de gestión de series de televisión.
- Aplicación completa de gestión
- Práctica con WPF y datos estructurados

### Ejercicios de WPF

#### [Ejercicio6_eventos](Ejercicio6_eventos)
Ejercicio enfocado en el manejo de eventos en WPF.
- Eventos de controles
- Manejo de interacciones del usuario

#### [Ejercicio10_WPF](Ejercicio10_WPF)
Ejercicio práctico de WPF #10.
- Consolidación de conceptos de WPF
- Práctica con interfaces gráficas

#### [Ejercicio11_WPF](Ejercicio11_WPF)
Ejercicio práctico de WPF #11.
- Continuación de práctica con WPF
- Interfaces más complejas

#### [Ej_9Textblock](Ej_9Textblock)
Ejercicio específico sobre el control TextBlock.
- Uso y personalización de TextBlock
- Formato de texto en WPF

#### [Ej12 Prop](Ej12%20Prop)
Ejercicio sobre propiedades en WPF.
- Propiedades de dependencia
- Binding de datos

#### [Ej13](Ej13)
Ejercicio práctico #13.
- Ejercicio avanzado de WPF

### Eventos y Delegados

#### [Ej_Delegados_1](Ej_Delegados_1)
Primer ejercicio sobre delegados en C#.
- Conceptos básicos de delegados
- Uso de callbacks

#### [Ej_Delegados_2](Ej_Delegados_2)
Segundo ejercicio sobre delegados.
- Delegados avanzados
- Delegados multidifusión

#### [EventosyDelegados_2](EventosyDelegados_2)
Ejercicio combinado de eventos y delegados.
- Relación entre eventos y delegados
- Patrones de diseño

#### [EventosyDelegados_v2](EventosyDelegados_v2)
Versión mejorada del ejercicio de eventos y delegados.
- Implementación refinada
- Mejores prácticas

#### [Ej_Inciales_Eventos](Ej_Inciales_Eventos)
Ejercicios iniciales sobre eventos.
- Introducción a eventos en C#
- Event handlers básicos

#### [Ej_Anonimas](Ej_Anonimas)
Ejercicio sobre funciones anónimas y expresiones lambda.
- Delegates anónimos
- Expresiones lambda
- LINQ básico

### Controles de Usuario Personalizados

#### [Ejercicio1User_Control](Ejercicio1User_Control)
Primer ejercicio de creación de controles de usuario.
- Creación de UserControls
- Encapsulación de funcionalidad

#### [Ejercicio2_UserControl](Ejercicio2_UserControl)
Segundo ejercicio de controles de usuario.
- UserControls avanzados
- Propiedades personalizadas

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

## 📦 Trabajar con Submodules

Esta carpeta contiene un submodule (Tarea 3) que apunta a un repositorio externo. Para trabajar con submodules:

### Clonar el repositorio con submodules
```bash
git clone --recurse-submodules https://github.com/Mariogarluu/Desarrollo-de-Interfaces.git
```

### Inicializar submodules en un repositorio ya clonado
```bash
git submodule update --init --recursive
```

### Actualizar submodules a la última versión
```bash
git submodule update --remote
```

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

## 🎨 Introducción a WPF (Windows Presentation Foundation)

WPF es el framework de Microsoft para crear aplicaciones de escritorio con interfaces gráficas modernas en Windows.

### Características Principales de WPF
- **XAML**: Lenguaje de marcado basado en XML para definir interfaces
- **Separación de diseño y lógica**: UI en XAML, lógica en C#
- **Data Binding**: Vinculación automática de datos entre UI y código
- **Estilos y Templates**: Personalización completa de controles
- **Gráficos vectoriales**: Interfaces escalables y de alta calidad
- **Animaciones**: Soporte nativo para animaciones fluidas

### Estructura Básica de una Aplicación WPF

#### MainWindow.xaml (Interfaz)
```xaml
<Window x:Class="MiApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Mi Aplicación" Height="450" Width="800">
    <Grid>
        <Button Content="Haz clic" Click="Button_Click"/>
    </Grid>
</Window>
```

#### MainWindow.xaml.cs (Lógica)
```csharp
using System.Windows;

namespace MiApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¡Botón presionado!");
        }
    }
}
```

### Conceptos Clave de WPF
- **Window**: Ventana principal de la aplicación
- **Grid, StackPanel, DockPanel**: Contenedores para organizar controles
- **Button, TextBox, Label**: Controles básicos de UI
- **Events**: Respuesta a interacciones del usuario (Click, KeyPress, etc.)
- **UserControls**: Controles personalizados reutilizables
- **Styles**: Definición de apariencia reutilizable
- **Resources**: Recursos compartidos (estilos, templates, etc.)

### Delegados y Eventos en C#

Los delegados son tipos que representan referencias a métodos. Los eventos utilizan delegados para notificar cuando algo sucede.

```csharp
// Definición de un delegado
public delegate void MiDelegado(string mensaje);

// Uso de un delegado
MiDelegado del = MostrarMensaje;
del("Hola desde delegado");

// Definición de un evento
public event EventHandler MiEvento;

// Invocar un evento
MiEvento?.Invoke(this, EventArgs.Empty);
```

## 🎯 Objetivos de Aprendizaje

- Familiarizarse con la sintaxis de C#
- Comprender la estructura de un proyecto C#
- Aprender a compilar y ejecutar aplicaciones
- Dominar Visual Studio como IDE de desarrollo
- Desarrollar interfaces gráficas con WPF (Windows Presentation Foundation)
- Entender y aplicar el patrón XAML para diseño de interfaces
- Manejar eventos y delegados en C#
- Crear controles de usuario personalizados
- Integrar bases de datos (SQLite) en aplicaciones de escritorio
- Aplicar buenas prácticas de desarrollo en .NET

## 🔗 Recursos Útiles

- [Documentación oficial de C#](https://docs.microsoft.com/es-es/dotnet/csharp/)
- [Tutorial de C# para principiantes](https://www.tutorialsteacher.com/csharp)
- [Microsoft Learn - C#](https://docs.microsoft.com/es-es/learn/paths/csharp-first-steps/)
- [C# Programming Guide](https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/)

## 💡 Progreso y Próximos Pasos

### Ya Completado ✅
1. **Consola C#**: Aplicaciones básicas de consola
2. **WPF Básico**: Interfaces gráficas con Windows Presentation Foundation
3. **Controles WPF**: Trabajo con controles estándar y personalizados
4. **Eventos y Delegados**: Manejo de eventos y callbacks
5. **Base de Datos**: Integración con SQLite
6. **UserControls**: Creación de componentes reutilizables

### Próximos Temas
1. **WPF Avanzado**: MVVM pattern, Command binding
2. **ASP.NET**: Para aplicaciones web
3. **Xamarin/MAUI**: Para aplicaciones móviles multiplataforma
4. **Entity Framework**: ORM para bases de datos
5. **APIs REST**: Consumo y creación de servicios web

## 📝 Notas

- Los archivos `.csproj` contienen la configuración del proyecto
- Los archivos `.sln` son soluciones que pueden contener múltiples proyectos
- La carpeta `bin/` contiene los archivos compilados
- La carpeta `obj/` contiene archivos temporales de compilación
- Las carpetas `.vs/` contienen configuraciones específicas de Visual Studio
