using System;
using System.IO;

namespace Plantillas.Carteleras
{
    public class Carteleras
    {
        string url;
        int IdPelicula;
        string DirectorioBase;
        string Raiz;

        public Carteleras(int IdPelicula)
        {
            this.DirectorioBase = AppContext.BaseDirectory;
            this.IdPelicula = IdPelicula;
            this.url = "";
            this.Raiz = Directory.GetParent(this.DirectorioBase).Parent.Parent.Parent.Parent.FullName;
        }

        public string obtenerUrl()
        {
            if (string.IsNullOrEmpty(url))
            {
                string Carpeta = Path.Combine(Raiz, "Recursos", "Carteleras");
                string jpg = Path.Combine(Carpeta, $"{IdPelicula}.jpg");
                string png = Path.Combine(Carpeta, $"{IdPelicula}.png");
                if (File.Exists(jpg))
                {
                    url = jpg;
                }
                else if (File.Exists(png))
                {
                    url = png;
                }
                else
                {
                    url = Path.Combine(Raiz, "Recursos", "Carteleras", "default.jpeg");
                }
            }
            return url;
        }

        private string Carpeta()
        {
            string carpeta = Path.Combine(Raiz, "Recursos", "Carteleras");
            Directory.CreateDirectory(carpeta);
            return carpeta;
        }

        public bool TieneImagen()
        {
            string carpeta = Path.Combine(Raiz, "Recursos", "Carteleras");
            return File.Exists(Path.Combine(carpeta, $"{IdPelicula}.jpg"))
                || File.Exists(Path.Combine(carpeta, $"{IdPelicula}.png"));
        }

        public string Guardar(string rutaOrigen)
        {
            if (string.IsNullOrWhiteSpace(rutaOrigen) || !File.Exists(rutaOrigen))
                throw new FileNotFoundException("No se encontró la imagen de origen.", rutaOrigen);

            string ext = Path.GetExtension(rutaOrigen).ToLowerInvariant();
            if (ext == ".jpeg") ext = ".jpg";
            if (ext != ".jpg" && ext != ".png")
                throw new NotSupportedException("Solo se permiten imágenes .jpg o .png.");

            Eliminar(); 
            string destino = Path.Combine(Carpeta(), $"{IdPelicula}{ext}");
            File.Copy(rutaOrigen, destino, true);
            url = destino;
            return destino;
        }

        public void Eliminar()
        {
            string carpeta = Path.Combine(Raiz, "Recursos", "Carteleras");
            string jpg = Path.Combine(carpeta, $"{IdPelicula}.jpg");
            string png = Path.Combine(carpeta, $"{IdPelicula}.png");
            if (File.Exists(jpg)) File.Delete(jpg);
            if (File.Exists(png)) File.Delete(png);
            url = "";
        }
    }
}