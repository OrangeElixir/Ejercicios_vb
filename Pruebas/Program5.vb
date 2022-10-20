Imports System

Module Program5
    Sub Main(args As String())
        Const PI = 3.1415
        Dim diameter, radius, volume As Double

        Console.WriteLine("VOLUME OF A SPHERE")
        Console.WriteLine("Enter a diameter value: ")
        diameter = Console.ReadLine()
        radius = diameter / 2

        volume = 4 / 3 * PI * radius ^ 3
        Console.WriteLine("The value of a volume Sphere is: " & volume " cubic meters")
    End Sub
End Module