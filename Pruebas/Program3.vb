Imports System

Module Program3
	Sub Main(args As String())
		Dim grade1, grade2, grade3, grade4, grade_average As Integer

		Console.WriteLine("KNOW UR GRADE AVERAGE...")
		Console.WriteLine("Enter your first grade: ")
		grade1 = Console.ReadLine()

		Console.WriteLine("Enter your second grade: ")
		grade2 = Console.ReadLine()

		Console.WriteLine("Enter your third grade: ")
		grade3 = Console.ReadLine()

		Console.WriteLine("Enter your fourth grade: ")
		grade4 = Console.ReadLine()

		grade_average = (grade1 + grade2 + grade3 + grade4) / 4
		Console.WriteLine("Your grade average is: " & grade_average)


	End Sub
End Module