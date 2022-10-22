Imports System

Module Program
    Sub Main(args As String())
        Dim current_month, current_day, days_p, days_l As Integer

        Console.WriteLine("Enter the current month in range(1-12): ")
        current_month = Console.ReadLine()

        Console.WriteLine("Enter the current day in range(1-30)")
        current_day = Console.ReadLine()

        days_p = (current_month - 1) * 30 + current_day
        days_l = 365 - days_p

        Console.WriteLine("Days passed: " & days_p & ", and days lefted: " & days_l)

    End Sub
End Module
