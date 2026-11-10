
# MiPresentacion

## Descripcion del proyecto

MiPresentacion es una aplicacion de escritorio desarrollada en C# utilizando Avalonia UI y XAML.

El programa permite ingresar los datos personales de una persona, como nombre, apellido y edad. Cuando se presiona el boton Presentarme, la aplicacion muestra un mensaje personalizado con la informacion ingresada.

Tambien cuenta con un boton para limpiar los campos y otro para cambiar el saludo.

## Tecnologias utilizadas

- C#
- .NET SDK 8.0.130
- Avalonia UI 12.1.6
- XAML
- Visual Studio Code

## Controles utilizados

- TextBlock: permite mostrar titulos, etiquetas y mensajes.
- TextBox: permite ingresar nombre, apellido y edad.
- Button: permite ejecutar las acciones del programa.
- StackPanel: organiza los controles verticalmente.
- Margin: establece espacios alrededor de los elementos.
- Spacing: establece la separacion entre controles.

## Funcionamiento de los botones

### Presentarme

Obtiene los datos ingresados por el usuario y realiza las siguientes validaciones:

- Comprueba que el nombre no este vacio.
- Comprueba que el apellido no este vacio.
- Utiliza int.TryParse() para verificar que la edad sea un numero entero.
- Comprueba que la edad sea mayor que cero.

Si todos los datos son correctos, muestra una presentacion personalizada.

### Limpiar

Borra la informacion de los tres campos, restaura el mensaje inicial y coloca nuevamente el cursor en el campo del nombre.

### Cambiar saludo

Permite alternar entre dos mensajes de presentacion diferentes sin cerrar la aplicacion.

## Relacion entre XAML y C#

El archivo MainWindow.axaml contiene el diseño visual de la aplicacion. En este archivo se crean los cuadros de texto, botones y mensajes que aparecen en pantalla.

Por otro lado, MainWindow.axaml.cs contiene el codigo C# que controla el funcionamiento de esos elementos.

La propiedad x:Name permite identificar los controles del archivo XAML para poder acceder a ellos desde C#.

Los eventos Click permiten ejecutar metodos cuando el usuario presiona un boton.

Por ejemplo, cuando se presiona Presentarme, se ejecuta el metodo BtnPresentarme_Click, que obtiene los datos, realiza las validaciones y muestra el resultado.

De esta manera, ambos archivos trabajan juntos para que el usuario pueda interactuar con la aplicacion.

## Instrucciones para ejecutar

1. Descargar o clonar el repositorio.
2. Abrir la carpeta MiPresentacion en Visual Studio Code.
3. Abrir una terminal.
4. Ejecutar el siguiente comando:

dotnet restore

5. Compilar el proyecto:

dotnet build

6. Ejecutar la aplicacion:

dotnet run

## Estructura del proyecto

- Program.cs
- App.axaml
- App.axaml.cs
- MainWindow.axaml
- MainWindow.axaml.cs
- MiPresentacion.csproj
- README.md

## Autor

Enrique Gonzalez

Proyecto academico de Profundizacion en .NET.
