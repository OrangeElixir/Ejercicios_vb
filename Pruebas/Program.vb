Imports System

Module Program
    Sub Main(args As String())
        Dim base, height, area As Integer

        Console.WriteLine("TRIANGLE AREA")
        Console.WriteLine("Enter a base value: ")
        base = Console.ReadLine()
        
        Console.WriteLine("Enter a height value: ")
        height = Console.ReadLine()

        area = 0.5*base*height 
        Console.WriteLine("The area value is: " & area)


    End Sub
End Module
