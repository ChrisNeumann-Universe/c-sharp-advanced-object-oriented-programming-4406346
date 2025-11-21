// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using static classes


// Static classes are defined using the 'static' keyword
// They contain only static members (methods, properties, constants)
// They cannot be instantiated, and are sealed by default
// (so they cannot be derived from)
public static class Converter
{
    public static double INCH_CM_CONVERT = 2.54;
    // public int temp; // this doesn't work, since instanced member can't be declared in a static class
    public static double InToCm(double inches)
    {
        return inches * INCH_CM_CONVERT;
    }

    public static double CmToIn(double centimeters)
    {
        return centimeters / INCH_CM_CONVERT;
    }
}

// ststic lasses are sealed, so you can't derive a static class from another static class
// public static class NewConv : Converter
// {

// }