Module Program9
    Sub Main(args As String())
        Dim f_degrees, c_degrees As Double

        Console.WriteLine("Degrees Farenheit to degrees Celcius")
        Console.WriteLine("Enter degrees Farenheit: ")
        f_degrees = Console.ReadLine()
        Console.WriteLine("Value entered: " & f_degrees & "° Farenheit")

        c_degrees = 5 * (f_degrees - 32) / 9
        Console.WriteLine("Degrees Celsius equivalent is: " & c_degrees & "° Celsius")
    End Sub
End Module