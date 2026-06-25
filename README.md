# StretchFilmApp

Aplicación de escritorio en **C# / Windows Forms** para la gestión comercial de
una empresa revendedora de **stretch film** (film plástico estirable para
embalaje industrial). El proyecto nace como trabajo estudiantil, pero está
pensado para resolver un problema real: la empresa que sirve de caso de
estudio gestionaba sus solicitudes de venta, proveedores, clientes y usuarios
de forma manual (hojas sueltas, WhatsApp, memoria), sin un sistema que
centralizara la información ni dejara trazabilidad de los cambios.

## Contexto del problema

El negocio de venta de stretch film (un commodity industrial con márgenes
ajustados y muchos clientes recurrentes) necesita controlar a diario:

- Qué solicitudes de compra ha hecho cada cliente y en qué estado están.
- Qué proveedores existen y si están activos.
- Qué productos se ofrecen, su stock y su precio.
- Qué órdenes de adquisición (compra a proveedores) están pendientes,
  confirmadas o ya recibidas.
- Qué clientes están aprobados para operar (sobre todo los que piden crédito)
  y cuáles siguen pendientes de validación.
- Qué usuarios (vendedoras y administradores) tienen acceso al sistema.
- Qué márgenes de precio se han pactado por producto/cliente, y si siguen
  vigentes.

`StretchFilmApp` resuelve esto con una aplicación de escritorio simple,
sin servidor ni base de datos externa, usando **archivos de texto (.txt)**
como almacenamiento. Esta decisión es deliberada: prioriza que cualquier
persona del equipo pueda entender, inspeccionar y hasta corregir los datos
a mano si algo falla, sin depender de un motor de base de datos instalado.

## Tecnologías

- **C# 7.3** sobre **.NET Framework** (WinForms)
- Persistencia en archivos **TXT delimitados por comas** (sin base de datos)
- Sin dependencias externas (no usa NuGet más allá de lo que trae WinForms)

## Estructura del proyecto

```
StretchFilmApp/
├── Solicitudes.cs / .Designer.cs        Pipeline de ventas: registro y seguimiento de solicitudes
├── Proveedores.cs / .Designer.cs        Alta y gestión de proveedores
├── Productos.cs / .Designer.cs          Catálogo de productos (con imagen, precio y stock)
├── Adquisicion.cs / .Designer.cs        Órdenes de compra generadas desde cotizaciones aprobadas
├── Clientes.cs / .Designer.cs           Clientes registrados, con flujo de aprobación
├── Usuarios.cs / .Designer.cs           Usuarios del sistema (vendedoras y administradores)
├── Margenes.cs / .Designer.cs           Márgenes de precio por producto/cliente, con vigencia
├── TARJETA_MARGEN.cs / .Designer.cs     UserControl: tarjeta visual de un margen individual
├── Utilitario.cs                        Lectura/escritura genérica de archivos TXT y grillas
├── PanelExtensiones.cs                  Botón de cierre reutilizable para paneles "Nuevo registro"
├── Theme.cs                             Estilos visuales compartidos (colores, grillas)
└── Data2/                               Carpeta de datos (se genera en tiempo de ejecución)
    ├── solicitudes.txt
    ├── proveedores.txt
    ├── productos.txt
    ├── adquisicion.txt
    ├── clientes.txt
    ├── vendedoras.txt
    ├── administradores.txt
    ├── margenes.txt
    └── Imagenes/                        Imágenes de productos subidas por el usuario
```

> La carpeta `Data2` y sus archivos TXT se crean automáticamente la primera
> vez que se abre cada módulo, con datos de ejemplo, si todavía no existen.
> Esto permite probar la aplicación desde cero sin configuración previa.

## Convenciones del proyecto

Para que cualquier integrante del equipo pueda extender un módulo sin
sorpresas, todos siguen el mismo patrón:

1. **Carga de datos en el constructor**, no en el evento `Load` del
   formulario — así no depende de que el diseñador haya enganchado
   correctamente el evento.
2. **Separador de campos único**: `Utilitario.SEPARADOR` (coma `,`),
   usado tanto al leer como al escribir, en todos los módulos.
3. **Archivo de ejemplo automático**: cada formulario tiene un método
   `AsegurarArchivoEjemplo()` que crea el TXT con datos de muestra si no
   existe, para que el sistema sea usable inmediatamente tras clonarlo.
4. **Persistencia inmediata**: cada alta, baja o cambio de estado se
   guarda en el TXT al momento (no hay un botón "guardar todo" al final).
5. **Botón de cierre reutilizable**: los paneles de "Nuevo registro" usan
   `PanelExtensiones.AgregarBotonCerrar(...)` para mostrar una ✕ que oculta
   el panel sin tener que reescribir esa lógica en cada formulario.

## Cómo ejecutar

1. Abrir la solución en Visual Studio.
2. Compilar (`Ctrl+Shift+B`).
3. Ejecutar (`F5`). La carpeta `Data2` con los archivos de ejemplo se crea
   automáticamente en la carpeta de salida (`bin/Debug/...`).

## Estado del proyecto / próximos pasos

Este es un proyecto en desarrollo activo con fines académicos. Algunas
limitaciones conocidas, abiertas para futuras mejoras:

- Las contraseñas de usuarios se almacenan en texto plano (aceptable para
  el alcance del curso, no para un entorno de producción real).
- No hay control de concurrencia: si dos instancias de la app escriben al
  mismo TXT al mismo tiempo, puede perderse información (último que
  guarda, gana).
- La relación entre módulos (por ejemplo, producto ↔ proveedor) es por
  texto libre, no por un identificador único, lo que permite errores de
  tipeo entre formularios.

Estas limitaciones son intencionalmente aceptadas en esta etapa para
priorizar la simplicidad y el aprendizaje sobre el manejo de archivos,
formularios y eventos en C#/WinForms, que es el objetivo principal del curso.