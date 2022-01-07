using System;
using System.Diagnostics;
using System.IO;
using Core;
using Kompas;
using Microsoft.VisualBasic.Devices;

namespace StressTest
{
    /// <summary>
    /// Класс запуска стресс теста 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод запукающий стресс тест
        /// </summary>
        static void Main()
        {
            var parameters = new LinkPinParameter();
            parameters.RodLength = 20;
            parameters.HeadLength = 4;
            parameters.HoleDistance = 4;
            parameters.HoleRadius = 1;
            parameters.RodRadius = 4;
            parameters.HeadRadius = 5;
            parameters.RodChamferDepth = 0.5;
            parameters.HeadChamferDepth = 0.5;
            parameters.RodAngleDepth = 15;
            parameters.HeadAngleDepth = 15;
            parameters.Cutting = false;
            var compas = new Connecter();
            compas.RunKompas();
            var builder = new Builder();
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var streamWriter = new StreamWriter("log.txt", true);
            var count = 0;
            while (true)
            {
                builder.Build(compas.KompasObject, parameters);
                var computerInfo = new ComputerInfo();
                var usedMemory = (computerInfo.TotalPhysicalMemory -
                                  computerInfo.AvailablePhysicalMemory) / Math.Pow(1024, 3);
                streamWriter.WriteLine(
                    $"{++count}\t{stopWatch.Elapsed:hh\\:mm\\:ss}\t{usedMemory}");
                streamWriter.Flush();
            }
        }
    }
}
