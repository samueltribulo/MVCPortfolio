using Portfolio.Models;

namespace Portfolio.Interfaces
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoDTO contacto);
    }
}
