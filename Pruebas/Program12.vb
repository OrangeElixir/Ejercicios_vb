Module Program12
    Sub Main(args As String())
        Const IVA = 0.2
        Dim p_1, p_2, p_3, a_t_p_1, a_t_p_2, a_t_p_3, t_p1, t_p2, t_p3 As Double

        Console.WriteLine("Enter a value for the first product: ")
        p_1 = Console.ReadLine()
        Console.WriteLine(vbCrLf)

        Console.WriteLine("Enter a value for the second product: ")
        p_2 = Console.ReadLine()
        Console.WriteLine(vbCrLf)

        Console.WriteLine("Enter a value for the third product: ")
        p_3 = Console.ReadLine()
        Console.WriteLine(vbCrLf)

        t_p1 = p_1 * IVA
        a_t_p_1 = p_1 + t_p1
        Console.WriteLine("The price after tax of the first product is: $" & a_t_p_1)
        Console.WriteLine("The average price after tax is : $" & a_t_p_1 / 2)
        Console.WriteLine(vbCrLf
                          )
        t_p2 = p_2 * IVA
        a_t_p_2 = p_2 + t_p2
        Console.WriteLine("The price after tax of the second product is: $" & a_t_p_2)
        Console.WriteLine("The average price after tax is : $" & a_t_p_2 / 2)
        Console.WriteLine(vbCrLf)

        t_p3 = p_3 * IVA
        a_t_p_3 = p_3 + t_p3
        Console.WriteLine("The price after tax of the third product is: $" & a_t_p_3)
        Console.WriteLine("The average price after tax is : $" & a_t_p_3 / 2)


    End Sub
End Module