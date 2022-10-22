Imports System

Module Prueba2
    Sub Main(args As String())
        Dim e_price, discount, f_price, money_saved As Double

        Console.WriteLine("Discounts and money saved from a random product-." & vbCrLf)

        Console.WriteLine("Enter a price of a random product: ")
        e_price = Console.ReadLine()

        Console.WriteLine(vbCrLf & "Enter a discount as you want in scale (0-100) : ")
        discount = Console.ReadLine()

        f_price = e_price - (e_price * (discount / 100))
        money_saved = e_price - f_price

        Console.WriteLine(vbCrLf & "The final price of the product is: " & f_price & "$ ")
        Console.WriteLine("You save: " & money_saved & "$")

    End Sub
End Module
