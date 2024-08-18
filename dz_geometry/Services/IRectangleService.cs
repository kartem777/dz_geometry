using dz_geometry.Models;
namespace dz_geometry.Services
{
    public interface IRectangleService
    {
        double CalculateArea(Rectangle rectangle);
        double CalculatePerimeter(Rectangle rectangle);
    }

}
