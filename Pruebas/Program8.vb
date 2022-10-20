Module Program8
    Sub Main(args As String())
        Dim acceleration, time, distance As Double

        Console.WriteLine("Enter a value for the acceleration: ")
        acceleration = Console.ReadLine()
        Console.WriteLine("The acceleration value is: " & acceleration & "m/s²")

        Console.WriteLine("Enter a value for the time traveled: ")
        time = Console.ReadLine()
        Console.WriteLine("The time value is: " & time & " seconds")

        distance = 0.5 * acceleration * time ^ 2
        Console.WriteLine("The distance value is: " & distance & " meters")

    End Sub
End Module