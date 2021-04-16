using System;
using System.Collections.Generic;
namespace Camera
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Camera> cameraListe = new List<Camera>();
            Objective objective = new Objective(10, 80);
            Objective objective1 = new Objective(9, 146);
            Objective objective2 = new Objective(16, 50);

            MemoryCard memory = new MemoryCard(1000);
            MemoryCard memory2 = new MemoryCard(1000);
            MemoryCard memory3 = new MemoryCard(1000);


            Camera nikon = new Camera("Nikon", 209, "DigitalKamera", 21, "Tokio, Japan", "Peter");
            var nikonFunktionen = new List<FunktionsListe>() { FunktionsListe.Bildstabilisator, FunktionsListe.LiveFunktion, FunktionsListe.Selbstauslöser };// neue Variable für die funktionen was verwendet werden.
            nikon.Objective = objective;
            nikon.Memory = memory;
            nikon.Funktionen = nikonFunktionen;





            Camera panasonic = new Camera("Panasonic", 649, "Bridekamera", 20, "Osaka, Japan", "Herbert");
            var panasonicFunktionen = new List<FunktionsListe>() { FunktionsListe.LiveFunktion, FunktionsListe.Selbstauslöser, FunktionsListe.Serienbilder };// neue Variable für die funktionen was verwendet werden.                      
            panasonic.Objective = objective1;
            panasonic.Memory = memory2;
            panasonic.Funktionen = panasonicFunktionen;


            

            Camera sonyAlpha = new Camera("Sony Alpha", 849, "Systemkamera", 24, "Nihombashi, Japan", "Franz");
            var sonyAlphaFunktionen = new List<FunktionsListe>() { FunktionsListe.LiveFunktion, FunktionsListe.Selbstauslöser, FunktionsListe.Serienbilder, FunktionsListe.Panorama };// neue Variable für die funktionen was verwendet werden.
            sonyAlpha.Objective = objective2;
            sonyAlpha.Memory = memory3;
            sonyAlpha.Funktionen = sonyAlphaFunktionen;


            cameraListe.Add(nikon);
            cameraListe.Add(panasonic);
            cameraListe.Add(sonyAlpha);



            foreach (Camera cam in cameraListe)
            {
                Console.WriteLine(cam.PrintCamera());//zeigt mir die eigenschaften der kamera.               
                Console.WriteLine("Make a Photo...");
                cam.TakePhoto();//kamera macht ein foto und rechnet 5mb zum verbrauchten speicher dazu.
                Console.WriteLine();
            }

            //nikon.Objective = objective2;  //objectiv wechseln.
            //Console.WriteLine(nikon.PrintCamera());
            //Console.WriteLine();


        }




    }
   
}

