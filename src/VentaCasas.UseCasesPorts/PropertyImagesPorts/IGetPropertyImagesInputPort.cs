using System.Threading.Tasks;

namespace VentaCasas.UseCasesPorts
{
    public interface IGetPropertyImagesInputPort
    {
        Task<Task> Handle(int propertyId);
    }
}
