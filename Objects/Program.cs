namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Instrument> instruments = new List<Instrument>();
            instruments.Add(new Strings("Banjo", "Boing", true, 4, true));
            instruments.Add(new Strings("Violin", "Veeeee", true, 4, true));
            instruments.Add(new Percussion("Drumkit", "Bom", true, 5, true));

            foreach(dynamic instrument in instruments)
            {
                instrument.Play();

                for (int i = 0; i < 5; i++)
                {
                    instrument.Break();
                }

                instrument.Clean();
                instrument.Repair();

                for (int i = 0; i < 5; i++)
                {
                    instrument.Break();
                }
            }
            Console.ReadLine();
        }
    }
}