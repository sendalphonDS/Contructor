using System;
using System.Collections.Generic;
using System.Text;

namespace Tatarea02
{



    public class Cliente

    {
        public Cliente(string DniAux, string NombreAux, string ApellidoPaternoAux, string ApellidoMaternoAux, int EdadAux, string TelefonoAux)
        {
            this.Dni = DniAux;
            this.Nombre = NombreAux;
            this.ApellidoPaterno = ApellidoPaternoAux;
            this.ApellidoMaterno = ApellidoMaternoAux;
            this.Edad = EdadAux;
            this.Telefono = TelefonoAux;

        }


        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }

  

    }
}
