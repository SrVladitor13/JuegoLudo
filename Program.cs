namespace JuegoDeLudo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2());

            int cantidad_jugadores;
            Juego juego = new Juego(1);
        }
    }
}