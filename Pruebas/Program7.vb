Imports System

Module Program7
    Sub Main(args As String())
        Const TIP = 0.1
        Const TAX = 0.07
        Dim meal_cost, tip_amount, tax_amount, total_cost As Double

        Console.WriteLine("Enter your meal charge: ")
        meal_cost = Console.ReadLine()

        tip_amount = TIP * meal_cost
        Console.WriteLine("The amount of a tip: " & tip_amount)

        tax_amount = TAX * meal_cost
        Console.WriteLine("The amount of a tax: " & tax_amount)

        total_cost = meal_cost + tip_amount + tax_amount
        Console.WriteLine("The total amount is: " & total_cost)
    End Sub
End Module