# NexcraftDemo

Demo de la investigación **De Xamarin.Forms a .NET MAUI** (Programación para Dispositivos Móviles II).

Muestra cómo personalizar un control con un **handler** y el **mapper**, usando un cotizador de impresión 3D

## Qué hace

- Calcula el costo en Lempiras a partir de los gramos de filamento (L 2.50 por gramo).
- Compara un `Entry` normal con `NexEntry`, un control personalizado.
- `NexEntry` tiene borde redondeado, selecciona todo el texto al enfocarse y expone la propiedad `AccentColor`, que cambia el color del borde en vivo.


## Requisitos

- Visual Studio 2022 con la carga de trabajo **Desarrollo de interfaz de usuario de aplicaciones multiplataforma de .NET**
- .NET 8 o superior
- Emulador de Android o teléfono con depuración USB

## Cómo ejecutarla

1. Clona el repositorio:
```
   git clone https://github.com/TU-USUARIO/NexcraftDemo.git
```
2. Abre `NexcraftDemo.sln` en Visual Studio.
3. Selecciona **Android** como destino (emulador o teléfono).
4. Presiona **F5**.

## Cómo probarla

1. Escribe los gramos en el campo `NexEntry` y observa el costo.
2. Toca el campo de nuevo: se selecciona todo el texto.
3. Presiona **Cambiar color de acento**: el borde cambia en vivo.

## Limitaciones

- La personalización nativa está implementada solo para **Android**.
- El cálculo acepta únicamente punto como separador decimal.

## GRUPO 2

## Declaración de uso de IA

Se utilizó IA como apoyo para explicar conceptos y revisar el código. Los integrantes comprenden y pueden explicar el funcionamiento de la demo.

## Fuentes

- Microsoft. (s. f.). *Handlers*. .NET MAUI. https://learn.microsoft.com/dotnet/maui/user-interface/handlers/
