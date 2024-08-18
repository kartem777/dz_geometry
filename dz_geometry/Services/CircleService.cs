using dz_geometry.Models;
namespace dz_geometry.Services
{
    public class CircleService : ICircleService
    {
        public double CalculateArea(Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }

        public double CalculatePerimeter(Circle circle)
        {
            return 2 * Math.PI * circle.Radius;
        }
    }

}
