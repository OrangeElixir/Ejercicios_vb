Imports System

Module Prueba3
    Sub Main(args As String())
        Const VAT = 0.2
        Dim electric_meter_i, electric_meter_f, electric_meter_consumed As Integer
        Dim cost, cost_w_v As Double

        Console.WriteLine("Enter a kWh at the begginning of the month: ")
        electric_meter_i = Console.ReadLine()

        Console.WriteLine("Enter a kWh at the end of the month: ")
        electric_meter_f = Console.ReadLine()

        electric_meter_consumed = electric_meter_f - electric_meter_i
        cost = electric_meter_consumed * 0.06
        cost_w_v = cost + (cost * VAT)

        Console.WriteLine("Your monthly consumption is: " & cost & "$ " & "and total cost with VAT " & cost_w_v)


    End Sub
End Module
