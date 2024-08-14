using shapeCalculator;
using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        InputHandler inputHandler = new InputHandler();
        ShapeCalculator shapeCalculator = new ShapeCalculator();
        string shapeType =inputHandler.GetShapeType().ToLower();
        
        Shape shape;

        switch (shapeType)
        {
            case "daire":
                double radius = inputHandler.GetDoubleInput("Yarıçap değerini giriniz:");
                shape = new Circle(radius);
                break;
            case "üçgen":
                double sideA = inputHandler.GetDoubleInput("Birinci kenarın uzunluğunu giriniz:");
                double sideB = inputHandler.GetDoubleInput("İkinci kenarın uzunluğunu girin: ");
                double sideC = inputHandler.GetDoubleInput("Üçüncü kenarın uzunluğunu girin: ");
                shape = new Triangle(sideA, sideB, sideC);
                break;
            case "kare":
                double sideLength = inputHandler.GetDoubleInput("Kenar uzunluğunu giriniz:");
                shape = new Square(sideLength);
                break;
            case "dikdörtgen":
                double length = inputHandler.GetDoubleInput("Uzunluğu giriniz:");
                double width = inputHandler.GetDoubleInput("Genişliği giriniz:");
                shape = new Rectangle(length, width);
                break;
            case "küp":
                double cubeSide = inputHandler.GetDoubleInput("Küpün bir kenarının uzunluğunu giriniz:");
                shape = new Cube(cubeSide);
                break;
            case "küre":
                double sphereRadius = inputHandler.GetDoubleInput("Kürenin yarıçapını giriniz:");
                shape = new Sphere(sphereRadius);
                break;
            case "silindir":
                double cylinderRadius = inputHandler.GetDoubleInput("Silindirin yarıçapını giriniz:");
                double cylinderHeight = inputHandler.GetDoubleInput("Silindirin yüksekliğini giriniz:");
                shape = new Cylinder(cylinderRadius, cylinderHeight);
                break;
            case "üçgen prizma":
                double baseLength = inputHandler.GetDoubleInput("Üçgen prizmanın taban uzunluğunu giriniz:");
                double prismHeight = inputHandler.GetDoubleInput("Üçgen prizmanın yüksekliğini giriniz.");
                double prismLength = inputHandler.GetDoubleInput("Üçgen prizmanın uzunluğunu giriniz:");
                shape = new TriangularPrism(baseLength, prismHeight, prismLength);
                break;
            case "koni":
                double coneRadius = inputHandler.GetDoubleInput("Koni tabanının yarıçapını giriniz:");
                double coneHeight = inputHandler.GetDoubleInput("Koni yüksekliğini giriniz:");
                shape = new Cone(coneRadius, coneHeight);
                break;
            case "piramit":
                double pyramidBase = inputHandler.GetDoubleInput("Piramit taban uzunluğunu giriniz:");
                double pyramidHeight = inputHandler.GetDoubleInput("Piramit yüksekliğini giriniz:");
                shape = new Pyramid(pyramidBase, pyramidHeight);
                break;
            default:
                throw new ArgumentException("Geçersiz Şekil Türü!");
        }
        double area = shape.CalculateArea();
        double volume = shape.CalculateVolume();
        double perimeter = shape.CalculatePerimeter();

        Console.WriteLine($"\nSeçtiğiniz şekil: {shapeType.ToUpper()}");
        if ( perimeter> 0 )
        {
            Console.WriteLine($"Çevre: {perimeter}");

        }
        Console.WriteLine($"Yüzey Alanı: {area}");

        if ( volume > 0 )
        {
            Console.WriteLine($"Hacim: {volume}");
        }

    }
    
}