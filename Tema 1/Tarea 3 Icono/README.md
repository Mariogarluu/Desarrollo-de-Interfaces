# Tarea 3: Iconografía Web

Esta tarea demuestra el uso de iconos SVG y Font Awesome en el diseño de interfaces web modernas.

## 📋 Descripción

Los iconos son elementos visuales esenciales en las interfaces modernas. Mejoran la usabilidad, la navegación y la estética general de una aplicación web. Este proyecto implementa un menú de navegación con iconos SVG inline de Font Awesome.

## 🎨 Características del Proyecto

### Menú de Navegación con Iconos
- **5 elementos de menú** con iconos representativos
- **SVG inline**: Iconos incrustados directamente en el HTML
- **Navegación interna**: Enlaces a diferentes secciones de la página
- **Diseño responsive**: Adaptable a diferentes tamaños de pantalla

### Iconos Utilizados

1. **Bandera** (Flag) - Sección de Bienvenida
2. **Corona** (Crown) - Sección Sobre Nosotros
3. **GitHub** - Sección de Contacto
4. **Facebook** - Sección de Servicios
5. **LinkedIn** - Sección de Equipo

### Footer con Iconos Locales
- Iconos descargados como archivos SVG
- Almacenados en la carpeta `img/`
- Incluyen: flechas, estrellas y otros elementos visuales

## 📁 Estructura de Archivos

```
Tarea 3 Icono/
├── index.html        # Página principal con iconos SVG
├── style.css         # Estilos para el menú y secciones
├── img/              # Iconos SVG descargados
│   ├── arrow-up-solid.svg
│   ├── arrow-up-from-bracket-solid.svg
│   ├── star-solid.svg
│   └── circle-up-solid.svg
└── README.md         # Este archivo
```

## 🚀 Cómo Visualizar

1. Abrir el archivo `index.html` en un navegador web
2. Observar el menú de navegación superior con iconos
3. Hacer clic en los iconos para navegar entre secciones
4. Inspeccionar el código SVG para ver su estructura

## 💻 Implementación de Iconos

### SVG Inline
Los iconos están incrustados directamente en el HTML:

```html
<a href="#1">
    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 640 640">
        <path d="M155.7 160C170.3 150.8..."/>
    </svg>
    1
</a>
```

**Ventajas del SVG Inline:**
- Control total sobre el estilo (color, tamaño)
- No requiere peticiones HTTP adicionales
- Escalable sin pérdida de calidad
- Manipulable con CSS y JavaScript

### Iconos desde Archivos
Para el footer, se usan iconos almacenados como archivos:

```html
<img src="img/arrow-up-solid.svg" alt="Volver arriba">
```

## 🎯 Objetivos de Aprendizaje

- Implementar iconos SVG de forma inline y como archivos
- Comprender la estructura de los elementos SVG
- Crear navegación visual con iconos
- Aplicar estilos CSS a elementos SVG
- Conocer Font Awesome y sus recursos

## 🔗 Recursos

- [Font Awesome](https://fontawesome.com/) - Biblioteca de iconos (versión 7.1.0 usada)
- [SVG Tutorial MDN](https://developer.mozilla.org/es/docs/Web/SVG/Tutorial) - Guía completa de SVG
- [Can I Use SVG](https://caniuse.com/svg) - Compatibilidad de SVG

## 💡 Ventajas de Usar SVG

1. **Escalabilidad**: Los iconos se ven nítidos en cualquier tamaño y resolución
2. **Rendimiento**: Tamaño de archivo pequeño
3. **Accesibilidad**: Pueden incluir atributos `aria-label` y `title`
4. **Flexibilidad**: Modificables con CSS (color, tamaño, animaciones)
5. **SEO**: Los motores de búsqueda pueden indexar el contenido SVG

## 📱 Secciones de la Página

1. **Bienvenido**: Introducción al sitio
2. **Sobre Nosotros**: Información de la empresa
3. **Contacto**: Formulario y datos de contacto
4. **Servicios**: Descripción de servicios ofrecidos
5. **Equipo**: Información sobre el equipo de trabajo

## 🎨 Personalización

Los iconos SVG pueden personalizarse fácilmente mediante CSS:

```css
svg {
    width: 24px;
    height: 24px;
    fill: #333;
    transition: fill 0.3s;
}

svg:hover {
    fill: #007bff;
}
```

## 📝 Notas Técnicas

- Los iconos de Font Awesome están licenciados bajo Font Awesome Free License
- Los SVG inline mantienen la semántica del HTML
- Es recomendable incluir atributos `alt` o `aria-label` para accesibilidad
