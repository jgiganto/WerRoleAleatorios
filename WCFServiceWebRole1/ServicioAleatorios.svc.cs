using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace WCFServiceWebRole1
{
    [AspNetCompatibilityRequirements(
    RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioAleatorios" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioAleatorios.svc or ServicioAleatorios.svc.cs at the Solution Explorer and start debugging.
    public class ServicioAleatorios : IServicioAleatorios
    {
        public void DoWork()
        {
        }

        public List<int> GetNumerosAleatorios()
        {
            List<int> listanumeros = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i <= 20; i++)
            {
                int num = rnd.Next(1, 590);
                listanumeros.Add(num);
            }
            return listanumeros;
        }

    }
}
}
