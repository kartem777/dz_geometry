using dz_geometry.Models;
namespace dz_geometry.Services
{
    public interface ICircleService
    {
        double CalculateArea(Circle circle);
        double CalculatePerimeter(Circle circle);
    }

}
