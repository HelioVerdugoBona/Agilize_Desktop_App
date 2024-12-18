using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Agilize
{
    internal class Fonts
    {
        private PrivateFontCollection privateFonts = new PrivateFontCollection();

        public Font LoadCustomFont(string relativeFontPath, float fontSize)
        {
            // Obtener la ruta absoluta del archivo
            string fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeFontPath);

            // Verificar si el archivo existe
            if (!File.Exists(fontPath))
            {
                throw new FileNotFoundException($"El archivo de fuente no se encontró: {fontPath}");
            }

            // Cargar la fuente desde el archivo
            privateFonts.AddFontFile(fontPath);

            // Crear un objeto Font usando la fuente cargada
            return new Font(privateFonts.Families[0], fontSize);
        }
    }
}
