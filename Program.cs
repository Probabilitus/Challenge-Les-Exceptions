namespace LES_EXCEPTIONS
{
    public class Program
    {
        static void ThrowError()
        {
            throw new CustomException("Une erreur personnalisée s'est produite.");
        }
        static void Main(string[] args)
        {
            try
            {
                ThrowError();
            }
            catch (CustomException e)
            {
                Console.WriteLine($"Message d'erreur' : {e.Message}");
                Console.WriteLine($"Heure de l'erreur' : {e.ErrorTime}");
            }
        }
    }
}
