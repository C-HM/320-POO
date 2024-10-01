namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Cr�ation de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            List<Buliding> bulidings = new List<Buliding>();
            List<Factory> factorys = new List<Factory>();
            List<Store> stores = new List<Store>();

            // Initialize buildings, factory, and store positions
            Buliding buliding = new Buliding();
            Buliding buliding2 = new Buliding();
            Factory factory = new Factory();
            Store store = new Store();


            bulidings.Add(buliding);
            bulidings.Add(buliding2);
            factorys.Add(factory);
            stores.Add(store);

            buliding.x = 400;
            buliding.y = 100;
            buliding2.y = 70;
            buliding2.x = 410;
            factory.y = 150;
            factory.x = 500;
            store.y = 130;
            store.x = 490;

            for(int i = 0; i < 10; i++)
            {
                string droneName = $"Drone{i}";
                Drone drone = new Drone(droneName);
                fleet.Add(drone);
            }

            if (fleet.Count() < 10)
            {
                throw new ArgumentException("La valeur de x est inf�rieure � 10 !");
            }
            try
            {
                // Start application
                Application.Run(new AirSpace(fleet, bulidings, factorys, stores));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Erreur : {e.Message}");
            }
        }
    }
}