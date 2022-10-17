using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace VentaCasas.WebExceptions
{
    public interface IExceptionHandler
    {
        Task Handle(ExceptionContext context);
    }
}
