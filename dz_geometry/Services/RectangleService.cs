using dz_geometry.Models;
namespace dz_geometry.Services
{
    public class RectangleService : IRectangleService
    {
        public double CalculateArea(Rectangle rectangle)
        {
            return rectangle.Length * rectangle.Width;
        }

        public double CalculatePerimeter(Rectangle rectangle)
        {
            return 2 * (rectangle.Length + rectangle.Width);
        }
    }

}
