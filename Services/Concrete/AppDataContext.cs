using TurboazTask1.Models;
using TurboazTask1.Services.Abstract;

namespace TurboazTask1.Services.Concrete
{
    public class AppDataContext : IAppDataContext
    {

        private readonly List<Brend> _brends;
        public List<Brend> Brends { get; }

        private readonly List<CarModel> _carModels;

        public List<CarModel> CarModels { get; }

        private readonly List<Car> _cars;
        public List<Car> Cars { get; }


        public AppDataContext()
        {
            _brends= new List<Brend>
            {
                new Brend{BrandName="BMW",BrandId=1},
                new Brend{BrandName="Mercedes",BrandId=2}

            };

            _carModels = new List<CarModel>
            {

                new CarModel{ modelname="X5",ModelId=1,BrendId=1},
                new CarModel{ modelname="X7",ModelId=2,BrendId=1},
                new CarModel{ modelname="M5",ModelId=3,BrendId=1},
                new CarModel{ modelname="I5",ModelId=4,BrendId=1},
                new CarModel{ modelname="A200",ModelId=5,BrendId=2},
                new CarModel{ modelname="C250",ModelId=6,BrendId=2},
                new CarModel{ modelname="CLS400",ModelId=7,BrendId=2},
                new CarModel{ modelname="CLS500",ModelId=8,BrendId=2}
            };

            _cars = new List<Car>
            {
                new Car{ Name="Car1", price=15000, year=2012,CarId=1,CarModelId=1},
                new Car{ Name="Car2", price=25000, year=2017,CarId=2,CarModelId=1},
                new Car{ Name="Car3", price=33000, year=2015,CarId=3,CarModelId=2},
                new Car{ Name="Car4", price=38000, year=2014,CarId=4,CarModelId=2},
                new Car{ Name="Car5", price=42000, year=2018,CarId=5,CarModelId=3},
                new Car{ Name="Car6", price=27000, year=2019,CarId=6,CarModelId=4},
                new Car{ Name="Car7", price=53000, year=2016,CarId=7,CarModelId=4},
                new Car{ Name="Car8", price=70000, year=2023,CarId=8,CarModelId=5},
                new Car{ Name="Car9", price=22000, year=2011,CarId=9,CarModelId=5},
                new Car{ Name="Car10", price=64000, year=2023,CarId=10,CarModelId=6},
                new Car{ Name="Car11", price=77000, year=2020,CarId=11,CarModelId=7},
                new Car{ Name="Car12", price=83000, year=2023,CarId=12,CarModelId=8}
            };

            Brends = _brends;
            CarModels = _carModels;
             Cars=_cars;
        }
    }
}
