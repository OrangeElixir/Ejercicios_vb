Imports System

Module Program6
    Sub Main(args As String())
        Const PI = 3.1415
        Dim diameter, radius, perimeter, area, volume As Double

        Console.WriteLine("---ALL ABOUT OF A CIRCLE---")

        Console.WriteLine("Enter a diameter value: ")
        diameter = Console.ReadLine()
        radius = diameter / 2
        Console.WriteLine("The radius value entered for the user is: " & radius & " meters")

        perimeter = 2 * PI * radius
        Console.WriteLine("The value of the perimeter circle is: " & perimeter & " meters")

        area = PI * radius ^ 2
        Console.WriteLine("The value of the circle area is " & area & " square meters")

        volume = 4 / 3 * PI * radio ^ 3
        Console.WriteLine("The value of the volume sphere is: " & volume & " cubic meters")

    End Sub
End Module