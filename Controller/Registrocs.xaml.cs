using System.Security.Cryptography.X509Certificates;

namespace EgasWProgreso3.Controller;

public partial class Registro : ContentPage
{
    private Button btnRegistro; // Cambiar el tipo de 'btnRegistro' a 'Button'  

    public Registro()
    {
        InitializeComponent();
        // Aqu� puedes inicializar los componentes de la p�gina  
        // Por ejemplo, asignar eventos a los botones  
        btnRegistro = new Button(); // Inicializar el bot�n  
        btnRegistro.Clicked += GuardarDatos;
    }

    private void GuardarDatos(object sender, EventArgs e)
    {
        // Aqu� puedes manejar el evento del bot�n de registro  
        // Por ejemplo, validar los campos y enviar los datos al servidor  
        DisplayAlert("Registro", "Bot�n de registro presionado", "Confirmaci�n");
    }

    private void InitializeComponent()
    {
        // Aqu� se inicializan los componentes de la p�gina  
        // Esto normalmente se genera autom�ticamente por el dise�ador de XAML  
        throw new NotImplementedException();
    }
}
