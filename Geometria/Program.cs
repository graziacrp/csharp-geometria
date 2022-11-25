namespace Geometria
{

    //  Creo la classe rettangolo

    internal class Rettangolo
    {
        public int baseRettangolo;
        public int altezzaRettangolo;





        //Calcolo il perimetro del rettangolo

        public int PerimetroRettangolo()
        {
            int perimetro = 2 * (baseRettangolo + altezzaRettangolo);
            return perimetro;
        }

        //Calcolo l'area dello stesso       

        public int AreaRettangolo()
        {
            int area = baseRettangolo * altezzaRettangolo;
            return area;
        }
        //Stampo le informazioni
        public void StampaRettangoloConsole()
        {
            Console.WriteLine("perimetro è:  " + PerimetroRettangolo());
            Console.WriteLine("area è:  " + AreaRettangolo());
        }

        //Chiedo all'utente di inserire base ed altezza di un nuovo rettangolo
        namespace Geometria;

        { internal class AltezzaInputUtente;
    {
    {
    }
{internal class  BaseInputUtente;

{
    { 

}

        Console.WriteLine("Inserisci la base del rettangolo");
        int baseInputUtente = int.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci l'altezza del triangolo");
        int altezzaInputUtente = int.Parse(Console.ReadLine());

        private Geometria.Rettangolo = private new Rettangolo(BaseInputUtente, AltezzaInputUtente);

        Rettangolo.StampaRettangoloConsole();


