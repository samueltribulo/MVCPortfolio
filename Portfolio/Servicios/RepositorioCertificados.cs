using Portfolio.Interfaces;
using Portfolio.Models;

namespace Portfolio.Servicios
{
    public class RepositorioCertificados : IRepositorioCertificados
    {

        public List<CertificadoDTO> ObtenerCertificados()
        {

            return new List<CertificadoDTO>()
            {
                new CertificadoDTO
                {
                    Titulo = "Full stack web developer",
                    Descripcion = "Henry",
                    Link = "https://certificates.soyhenry.com/cert?id=afba7c74-72f6-4f0a-9599-5ba32f3aa0cf",
                    ImageURL = "/imagenes/HenryCertificate.jpg"
                },
                new CertificadoDTO
                {
                    Titulo = "Cloud Practitioner",
                    Descripcion = "AWS re/start",
                    Link = "https://www.credly.com/badges/30e4775f-d7cd-4685-a49b-df7685bf51f7/public_url",
                    ImageURL = "/imagenes/CloudPractitioner.png"
                },
                new CertificadoDTO
                {
                    Titulo = "Programación Web NET Core",
                    Descripcion = "Educación IT",
                    Link = "https://api.educacionit.com/pdf/certificados/samuel-tribulo-890764/64274",
                    ImageURL = "/imagenes/Certificado-Programación-Web-NET-Core-EducaciónIT.jpeg"
                },
                new CertificadoDTO
                {
                    Titulo = "Web API .NET Core",
                    Descripcion = "Educación IT",
                    Link = "https://api.educacionit.com/pdf/certificados/samuel-tribulo-890764/64282",
                    ImageURL = "/imagenes/Certificado-Web-API-.Net-Core-EducaciónIT.jpeg"
                },
                new CertificadoDTO
                {
                    Titulo = "ASP.NET Core MVC",
                    Descripcion = "Educación IT",
                    Link = "https://www.educacionit.com/perfil/samuel-tribulo-890764/certificado/64284",
                    ImageURL = "/imagenes/Certificado-ASP.NET-Core-MVC-Programming-EducaciónIT.jpeg"
                },
                new CertificadoDTO
                {
                    Titulo = "C# para no programadores",
                    Descripcion = "Educación IT",
                    Link = "https://www.educacionit.com/perfil/samuel-tribulo-890764/certificado/64272",
                    ImageURL = "/imagenes/csharp.jpeg"
                },                
                new CertificadoDTO
                {
                    Titulo = "Maquetador web avanzado",
                    Descripcion = "Educación IT",
                    Link = "https://api.educacionit.com/pdf/certificados/samuel-tribulo-890764/64273",
                    ImageURL = "/imagenes/Certificado-Maquetador-Web-Avanzado-EducaciónIT.jpeg"
                },
                new CertificadoDTO
                {
                    Titulo = "Trabajo en equipo",
                    Descripcion = "Forge",
                    Link = "https://insignias.acreditta.com/insignias/public/42ccba15-cfea-464f-a4ff-933c993469a2",
                    ImageURL = "/imagenes/TrabajoEnEquipo.png"
                },
                new CertificadoDTO
                {
                    Titulo = "Liderazgo Personal",
                    Descripcion = "Forge",
                    Link = "https://insignias.acreditta.com/insignias/public/0261e311-aa5c-42c0-a3f6-1aaf52f9e19a",
                    ImageURL = "/imagenes/Liderazgo.png"
                },          
                new CertificadoDTO
                {
                    Titulo = "Orientación al logro",
                    Descripcion = "Forge",
                    Link = "https://insignias.acreditta.com/insignias/public/2c9fd3c3-71d2-4cd4-adc5-b78afd4a4134",
                    ImageURL = "/imagenes/Orientacion.png"
                }
            };


        }


    }
}
