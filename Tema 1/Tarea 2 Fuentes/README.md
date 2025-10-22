# Tarea 2: Tipografías Web

← [Volver a Tema 1](../README.md) | [Inicio](../../README.md)

Esta tarea explora las diferentes formas de implementar y utilizar fuentes tipográficas en páginas web.

## 📋 Descripción

La tipografía es fundamental para la legibilidad y la estética de una interfaz web. Este proyecto demuestra tres métodos principales para implementar fuentes en páginas web.

## 🎨 Tipos de Fuentes Implementadas

### 1. Safe Fonts (Fuentes Seguras)
Fuentes que están preinstaladas en la mayoría de los sistemas operativos:
- **Ventajas**: No requieren descarga, cargan instantáneamente
- **Desventajas**: Opciones limitadas
- **Ejemplos**: Arial, Times New Roman, Georgia, Verdana

### 2. Google Fonts
Fuentes alojadas en los servidores de Google:
- **Ventajas**: Gran variedad de fuentes, fácil implementación
- **Desventajas**: Requieren conexión a internet
- **Implementación**: Se cargan mediante enlaces CDN
- **Fuente usada**: Michroma

### 3. Fuentes Personalizadas (TTF a WOFF)
Fuentes descargadas y convertidas al formato web:
- **Ventajas**: Control total sobre las fuentes, funcionan sin conexión
- **Desventajas**: Aumentan el tamaño de la página
- **Proceso**: 
  1. Descarga de fuente desde [Font Space](https://www.fontspace.com/category/calligraphy)
  2. Conversión de TTF a WOFF usando [Convert RouteNote](https://convert.routenote.com/ttf-to-woff)
  3. Implementación mediante `@font-face` en CSS

## 📁 Archivos

- **index.html**: Página HTML que demuestra los tres tipos de fuentes
- **style.css**: Hoja de estilos con las definiciones de fuentes
- **Fuentes/**: Carpeta con las fuentes personalizadas en formato WOFF

## 🚀 Cómo Visualizar

1. Abrir el archivo `index.html` en un navegador web
2. Observar las diferencias entre los tres tipos de fuentes
3. Inspeccionar el código para ver cómo se implementa cada tipo

## 💻 Código de Ejemplo

### Implementación de Google Fonts
```html
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Michroma&display=swap" rel="stylesheet">
```

### Implementación de @font-face
```css
@font-face {
    font-family: 'MiFuentePersonalizada';
    src: url('Fuentes/fuente.woff') format('woff');
}
```

## 🎯 Objetivos de Aprendizaje

- Comprender las diferentes formas de cargar fuentes en web
- Conocer las ventajas y desventajas de cada método
- Saber convertir fuentes de escritorio a formatos web
- Aplicar tipografías de manera efectiva en un proyecto

## 🔗 Recursos Utilizados

- [Font Space](https://www.fontspace.com/) - Descarga de fuentes
- [Convert RouteNote](https://convert.routenote.com/ttf-to-woff) - Conversión de formatos
- [Google Fonts](https://fonts.google.com/) - Fuentes de Google

## 📝 Notas

Las fuentes web modernas deben estar en formatos optimizados (WOFF, WOFF2) para garantizar tiempos de carga rápidos y compatibilidad con los navegadores actuales.
