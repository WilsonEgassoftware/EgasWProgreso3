using System.Security.Cryptography.X509Certificates;

namespace EgasWProgreso3.Controller;

public partial class Registro : ContentPage
{
    private Button btnRegistro; // Cambiar el tipo de 'btnRegistro' a 'Button'  

    public Registro()
    {
        InitializeComponent();
        // Aquí puedes inicializar los componentes de la página  
        // Por ejemplo, asignar eventos a los botones  
        btnRegistro = new Button(); // Inicializar el botón  
        btnRegistro.Clicked += GuardarDatos;
    }

    private void GuardarDatos(object sender, EventArgs e)
    {
        // Aquí puedes manejar el evento del botón de registro  
        // Por ejemplo, validar los campos y enviar los datos al servidor  
        DisplayAlert("Registro", "Botón de registro presionado", "Confirmación");
    }

    private void InitializeComponent()
    {
        // Aquí se inicializan los componentes de la página  
        // Esto normalmente se genera automáticamente por el diseñador de XAML  
        throw new NotImplementedException();
    }
}
