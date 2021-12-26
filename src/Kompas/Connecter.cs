using System;
using System.Runtime.InteropServices;
using Kompas6API5;

namespace Kompas
{
    /// <summary>
    /// Класс, запускающий Компас-3D
    /// </summary>
    public class Connecter
    {
        /// <summary>
        /// Свойство объекта KompasObject
        /// </summary>
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
                        KompasObject = (KompasObject)Activator.CreateInstance(kompasType);
                    }
                }

                KompasObject.ActivateControllerAPI();
            }
        }
	}
}
