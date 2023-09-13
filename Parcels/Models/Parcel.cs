namespace Parcels.Models
{
  public class Parcel
  {
    public double Weight { get; set; }
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Parcel(double weight, double length, double width, double height)
    {
        Weight = weight;
        Length = length;
        Width = width;
        Height = height;
    }
  }
}