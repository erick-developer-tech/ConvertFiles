ConvertFiles 📄🔄 LIMITADO A SOLO 3 HOJAS

**ConvertFiles** es una aplicación de escritorio ligera desarrollada en **C# con Windows Forms (WinForms)**. Su objetivo principal es permitir la conversión local de archivos de Microsoft Word (`.docx`) a formato `PDF` de manera rápida, intuitiva y sin necesidad de tener instalado Microsoft Office en el sistema.

Este proyecto fue diseñado con una arquitectura asíncrona para ofrecer una experiencia de usuario fluida, evitando que la interfaz se congele durante el procesamiento de archivos pesados.


✨ Características

* **Conversión Directa:** Transforma archivos `.docx` a `PDF` con un solo clic.
* **Automatización de Nombres:** Detecta el nombre del archivo original y lo asigna al PDF resultante de forma automática.
* **Procesamiento Asíncrono (`async/await`):** Incluye una barra de progreso animada mientras se realiza la conversión en un hilo secundario.
* **Sin Dependencias de Office:** No requiere Microsoft Word instalado (evita el uso de Office Interop).
* **Interfaz Limpia:** Panel de control intuitivo y validaciones en tiempo real para evitar errores de usuario.


🛠️ Tecnologías y Librerías Utilizadas

* **Lenguaje:** C# (.NET Framework / .NET Core)
* **Interfaz Gráfica:** Windows Forms (WinForms)
* **Conversión de Documentos:** [FreeSpire.Doc](https://www.e-iceblue.com/Introduce/free-doc-component.html) (instalado a través de NuGet).


🚀 Vista Previa del Funcionamiento

1.  **Seleccionar Archivo:** El usuario elige el documento `.docx` de origen (la interfaz muestra solo el nombre del archivo para mayor claridad).
2.  **Examinar Ruta:** Se define la carpeta de destino donde se exportará el resultado.
3.  **Convertir a PDF:** Se activa el botón de conversión, bloqueando temporalmente la UI y mostrando una ventana de carga animada hasta finalizar con éxito.
