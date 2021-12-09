using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Kompas6API5;
using Kompas6Constants3D;

namespace Kompas
{
    public class Connecter
    {
		public KompasObject KompasObject { get; private set; }

        /// <summary>
        /// Запускает Компас 3D
        /// </summary>
        public void RunKompas()
        {
            if (KompasObject == null)
            {
                var kompasType = Type.GetTypeFromProgID("KOMPAS.Application.5");
                KompasObject = (KompasObject) Activator.CreateInstance(kompasType);
            }


            if (KompasObject != null)
            {
                var retry = true;
                while (retry)
                {
                    try
                    {
                        KompasObject.Visible = true;
                        retry = false;
                    }
                    catch (COMException)
                    {
                        var kompasType = Type.GetTypeFromProgID("KOMPAS.Application.5");
                        KompasObject = (KompasObject) Activator.CreateInstance(kompasType);
                    }
                }

                KompasObject.ActivateControllerAPI();
            }
        }
	}
}
