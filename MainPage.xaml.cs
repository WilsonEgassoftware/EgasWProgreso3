using System.Threading.Tasks;

namespace EgasWProgreso3
{
    public partial class MainPage : ContentPage
    {
        private async Task OnCounterClicked(object sender, EventArgs e)
        {
            string texto = "¡Hola. Binevenido a la pagina de recetas";
            await GuardarDatos( texto);
            await ConfirmarDatos("Información", texto, "Aceptar");

        }

        private async Task ConfirmarDatos(string v1, string texto, string v2)
        {
            throw new NotImplementedException();
        }

        private async Task GuardarDatos(string texto)
        {
            throw new NotImplementedException();
        }

        private async void ObtenerInfodeGustos(object sender, EventArgs e)
        {
            // Aquí puedes manejar el evento del botón para obtener información de gustos
            // Por ejemplo, mostrar un mensaje o realizar una acción específica
            await DisplayAlert("Información", "Botón de obtener información de gustos presionado", "Aceptar");
        }
    }

}
