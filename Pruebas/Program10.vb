Module Program10
	Sub Main(args As String())
		Dim weight, height, bmi As Double

		Console.WriteLine("Calculate ur body mass index...")

		Console.WriteLine("Enter your height: ")
		height = Console.ReadLine()
		Console.WriteLine("Height entered: " & height & " inches")
		Console.WriteLine(vbCrLf)

		Console.WriteLine("Enter your weight: ")
		weight = Console.ReadLine()
		Console.WriteLine("Weight entered: " & weight & " pounds")
		Console.WriteLine(vbCrLf)

		bmi = (weight * 703) / height ^ 2
		Console.WriteLine("Your BODY MASS INDEX is: " & bmi)

		Console.WriteLine(vbCrLf)
		Console.WriteLine("BMI CATEGORIES: " & vbCrLf & "Underweight = <18.5" &
						  vbCrLf & "Normal Weight = 18.5 - 24.9" & vbCrLf &
						  "Overweight = 25 - 29.9" & vbCrLf &
						  "Obesity = BMI of 30 or greater")
	End Sub
End Module