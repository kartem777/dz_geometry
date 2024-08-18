using dz_geometry.Models;
namespace dz_geometry.Services
{
    public class SquareService : ISquareService
    {
        public double CalculateArea(Square square)
        {
            return square.Side * square.Side;
        }

        public double CalculatePerimeter(Square square)
        {
            return 4 * square.Side;
        }
    }
}
