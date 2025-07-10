namespace EgasWProgreso3
{
    public partial class App : Application
    {
        public App(object confirmar)
        {
            InitializeComponent();

            var EgasWProgreso3Page = new Page();

            

            // Fix: Use explicit type checking and casting instead of 'dynamic' in pattern matching  
            if (confirmar is not null && confirmar.GetType().GetProperty("text") != null)
            {
                var textProperty = confirmar.GetType().GetProperty("text");
                textProperty?.SetValue(confirmar, "Confirmar");
            }

            Confirmar = confirmar;
        }

        public object Confirmar { get; }
        public object Properties { get; internal set; }
    }
}
