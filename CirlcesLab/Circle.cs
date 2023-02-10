using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesLab;

public class Circle

{
    private double radius;

    public double Radius { get; set; }
}

public static class CalculateCircumferenceLab
{
    static double Circumference;
    public static double CalculateCircumference(double num)
    {
        Circumference = num * Math.PI * 2;
        return Circumference;
    }

    public static double CircumferenceFormatted(double num)
    {
        Circumference = Math.Round(Circumference, 2);
        return Circumference;
    }

}

public static class CalculateAreaeLab
{
    static double Area;
    public static double CalculateArea(double num)
    {
        Area = (Math.PI * num * num);
        return Area;
    }

    public static double CalculateFormattedArea(double num)
    {
        Area = Math.Round(Area, 2);
        return Area;
    }
}
