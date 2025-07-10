using System.Security.Cryptography.X509Certificates;

namespace EgasWProgreso3.Vista;

public partial class EleccióndeComida : ContentPage
{
    private Label ensalada; // Cambiar el tipo de 'ensalada' a 'Label'  

    public EleccióndeComida()
    {
        InitializeComponent();

        if (Application.Current is App app)
        {
            if (app.Properties is IDictionary<string, object> properties && properties.ContainsKey("ensalada"))
            {
                ensalada.Text = properties["ensalada"].ToString();
            }
        }
    }

    public async void ObtenerInfodeGustos(object sender, EventArgs e)
    {
        // Por ejemplo, mostrar un mensaje o realizar una acción específica  
        await DisplayAlert("Información", "Botón de obtener información de gustos presionado", "Aceptar");
    }
}
