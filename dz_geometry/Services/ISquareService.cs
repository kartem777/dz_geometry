using dz_geometry.Models;
namespace dz_geometry.Services
{
    public interface ISquareService
    {
        double CalculateArea(Square square);
        double CalculatePerimeter(Square square);
    }

}
