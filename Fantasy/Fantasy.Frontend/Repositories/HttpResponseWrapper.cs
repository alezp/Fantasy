using System.Net;

namespace Fantasy.Frontend.Repositories;

public class HttpResponseWrapper
        {
            return "Recurso no encontrado.";
        }
        if (statusCode == HttpStatusCode.BadRequest)
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
        if (statusCode == HttpStatusCode.Unauthorized)
        {
            return "Tienes que estar logueado para ejecutar esta operación.";
        }
        if (statusCode == HttpStatusCode.Forbidden)
        {
            return "No tienes permisos para hacer esta operación.";
        }

        return "Ha ocurrido un error inesperado.";
    }
}