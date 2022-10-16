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

            foreach(Instrument instrument in instruments)
            {
                dynamic usedInstrument = Convert.ChangeType(instrument, instrument.GetType());

                usedInstrument.Play();

                for (int i = 0; i < 5; i++)
                {
                    usedInstrument.Break();
                }

                usedInstrument.Clean();
                usedInstrument.Repair();

                for (int i = 0; i < 5; i++)
                {
                    usedInstrument.Break();
                }
            }
            Console.ReadLine();
        }
    }
}