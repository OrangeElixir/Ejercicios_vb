Imports System

Module Program2
    Sub Main(args As String())
        Dim f_angle, s_angle, t_angle As Integer

        Console.WriteLine("SUM OF ANGLES OF A TRIANGLE")
        Console.WriteLine("Enter a first angle value: ")
        f_angle = Console.ReadLine()

        Console.WriteLine("Enter a second angle value: ")
        s_angle = Console.ReadLine()

        t_angle = 180 - (f_angle + s_angle)
        Console.WriteLine("The third angle value is: " & t_angle)


    End Sub
End Module
