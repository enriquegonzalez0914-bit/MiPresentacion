using Avalonia.Markup.Xaml;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MiPresentacion;

public partial class MainWindow : Window
{
    private TextBox txtNombre = null!;
    private TextBox txtApellido = null!;
    private TextBox txtEdad = null!;
    private TextBlock txtResultado = null!;

    // Variable para controlar el cambio de saludo
    private bool saludoAlternativo = false;

    public MainWindow()
{
    AvaloniaXamlLoader.Load(this);

    txtNombre = this.FindControl<TextBox>("txtNombre")!;
    txtApellido = this.FindControl<TextBox>("txtApellido")!;
    txtEdad = this.FindControl<TextBox>("txtEdad")!;
    txtResultado = this.FindControl<TextBlock>("txtResultado")!;
}

    // Boton Presentarme
    private void BtnPresentarme_Click(object? sender, RoutedEventArgs e)
    {
        Presentar();
    }

    // Metodo para validar y mostrar la presentacion
    private void Presentar()
    {
        string nombre = txtNombre.Text?.Trim() ?? "";
        string apellido = txtApellido.Text?.Trim() ?? "";
        string edadTexto = txtEdad.Text?.Trim() ?? "";

        // Validar nombre
        if (string.IsNullOrWhiteSpace(nombre))
        {
            txtResultado.Text = "Advertencia: Debe ingresar su nombre.";
            return;
        }

        // Validar apellido
        if (string.IsNullOrWhiteSpace(apellido))
        {
            txtResultado.Text = "Advertencia: Debe ingresar su apellido.";
            return;
        }

        // Validar que la edad sea un numero entero
        if (!int.TryParse(edadTexto, out int edad))
        {
            txtResultado.Text = "Advertencia: Ingrese una edad numerica.";
            return;
        }

        // Validar que la edad sea positiva
        if (edad <= 0)
        {
            txtResultado.Text = "Advertencia: La edad debe ser mayor que cero.";
            return;
        }

        // Mostrar presentacion
        if (saludoAlternativo == false)
        {
            txtResultado.Text =
                $"¡Hola! Mi nombre es {nombre} {apellido}, " +
                $"tengo {edad} años y estoy aprendiendo " +
                "a desarrollar interfaces graficas con C#.";
        }
        else
        {
            txtResultado.Text =
                $"¡Mucho gusto! Soy {nombre} {apellido}, " +
                $"tengo {edad} años y estoy dando mis primeros " +
                "pasos en el desarrollo de aplicaciones con C#.";
        }
    }

    // Boton Limpiar
    private void BtnLimpiar_Click(object? sender, RoutedEventArgs e)
    {
        txtNombre.Text = "";
        txtApellido.Text = "";
        txtEdad.Text = "";

        saludoAlternativo = false;

        txtResultado.Text = "Aquí aparecerá tu presentación.";

        // Colocar el cursor en el campo nombre
        txtNombre.Focus();
    }

    // Boton Cambiar saludo
    private void BtnCambiarSaludo_Click(object? sender, RoutedEventArgs e)
    {
        saludoAlternativo = !saludoAlternativo;

        Presentar();
    }
}
