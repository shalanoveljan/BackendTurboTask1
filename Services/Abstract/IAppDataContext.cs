using TurboazTask1.Models;

namespace TurboazTask1.Services.Abstract
{
    public interface IAppDataContext
    {
        List<Brend> Brends { get; }
        List<CarModel> CarModels { get; }

        List<Car> Cars { get; }
    }
}
