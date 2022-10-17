using System.Threading.Tasks;

namespace VentaCasas.UseCasesPorts
{
    public interface IGetPropertyInputPort
    {
        Task<Task> Handle(int id);
    }
}
