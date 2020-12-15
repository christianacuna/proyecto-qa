using MelonLoader;
using NUnit.Framework;
using System.Collections.Generic;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace MelonTesting
{
    [TestFixture]
    public class Pruebas
    {
        [Test]
        public void PruebaMH1()
        {
            bool plugins = false;
            string directorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (plugins ? "Plugins" : "Mods"));
            bool PuedeCargarZips = MelonHandler.CanLoadZips(directorio);
            Console.WriteLine(PuedeCargarZips);
            Assert.IsTrue(PuedeCargarZips);
        }
        [Test]
        public void PruebaMH2()
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            bool plugins = false;
            string directorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (plugins ? "Plugins" : "Mods"));
            Console.WriteLine("Dirreccion:" + directorio);
            int cantItems = MelonHandler.GetCountFiles(directorio);
            Assert.IsTrue(cantItems > 0);
        }
        [Test]
        public void PruebaMH3()
        {
            bool plugins = false;
            string directorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (plugins ? "Plugins" : "Mods"));
            bool verificarDLL = MelonHandler.VerifyDLL(directorio);

            Console.WriteLine(verificarDLL);
            Assert.IsTrue(verificarDLL);
        }
        [Test]
        public void PruebaMH4()
        {
            bool plugins = false;
            string directorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (plugins ? "Plugins" : "Mods"));
            int cantItems = MelonHandler.GetCountFiles(directorio);

            Console.WriteLine(cantItems);
            Assert.IsTrue(cantItems > 1);
        }
        [Test]
        public void PruebaMH5()
        {
            bool pasaLaPrueba = false;
            try
            {
                MelonHandler.LoadMode loadDev = MelonHandler.LoadMode.DEV;
                MelonHandler.LoadMode loadNormal = MelonHandler.LoadMode.NORMAL;
                MelonHandler.LoadMode loadBoth = MelonHandler.LoadMode.BOTH;
                pasaLaPrueba = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.IsTrue(pasaLaPrueba);
        }

    }
}