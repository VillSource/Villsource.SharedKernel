
using Villsource.SharedKernel;

interface IVah { }

class Car : IVah { }
class Bik : IVah { }



class _main
{
    public _main()
    {
        Car car = new();
        Bik bik = new();

        Result<Car> car_im = car;
        Result<Bik> bik_im = bik;


        IResult a = car_im;
        IResult b = bik_im;

        IResult<IVah> c = car_im;

        var x = Result.Failure();
        Result<Bik> y = x;
    }
}
