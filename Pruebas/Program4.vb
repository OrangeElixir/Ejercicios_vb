Imports System

Module Program4
    Sub Main(args As String())
        Const PI = 3.1415
        Dim radius, perimeter As Double

        Console.WriteLine("---CIRCLE PERIMETER---")
        Console.WriteLine("Enter a radius value: ")
        radius = Console.ReadLine()

        perimeter = 2 * PI * radius
        Console.WriteLine("The perimeter value is: " & perimeter)

    End Sub
End Module