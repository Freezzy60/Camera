using System;
using System.Collections.Generic;
using System.Text;

namespace Camera
{
    class Camera
    {
        #region  Get Set

        string alleFunktionen;
        public int Preis { get; set; }

        public string GenaueBezeichnug { get; set; }

        public int Megapixel { get; set; }

        public Objective Objective { get; set; }

       

        public MemoryCard Memory { get; set; }
        public string Herkunftsland { get; set; }

        public string Besitzer { get; set; }

        public string CameraName { get; set; }

        public List<FunktionsListe> Funktionen { get; set; }

        
        #endregion


        #region Constructor 


        public Camera(string cameraName, int preis, string genaueBezeichnung, int megapixel, string herkunftsland,  string besitzer)
        {
            CameraName = cameraName;
            Preis = preis;
            GenaueBezeichnug = genaueBezeichnung;
            Megapixel = megapixel;
            Herkunftsland = herkunftsland;
            Besitzer = besitzer;

        }
        #endregion
        #region Variante 3

        public void GetGenaueBezichnung(string genauebezeichnung)
        {
            GenaueBezeichnug = genauebezeichnung;
        }

        public void GetMegapixel(int megapixel)
        {
            Megapixel = megapixel;
        }



        public void GetHerkunftsland(string herkunftsland)
        {
            Herkunftsland = herkunftsland;
        }

        public void GetBesitzer(string besitzer)
        {
            Besitzer = besitzer;
        }

        public void GetCamerName(string cameraName)
        {
            CameraName = cameraName;
        }


        #endregion

        public void TakePhoto()
        {
            int makePhoto = 5;
            Memory.OccupiedMSize += makePhoto;
            Console.WriteLine(Memory);
        }

        public string PrintCamera()
        {
            foreach (FunktionsListe funkt in Funktionen)
            {
                alleFunktionen += $"{funkt}, ";
            }

           

            return $"CameraName:\t{CameraName}\nOwner:\t\t{Besitzer}\nCamera Typ:\t{GenaueBezeichnug}\nMegapixel:\t{Megapixel}\nOrgin:\t\t{Herkunftsland}\nFocal Lenngth:\t{Objective.GetBrennweiteFromTo()}mm\nFunktion:\t{alleFunktionen}\n{Memory.ToString()}";
        }


       
    }
}
