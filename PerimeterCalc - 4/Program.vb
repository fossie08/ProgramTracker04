'
' Created by SharpDevelop.
' User: 19ofoster
' Date: 11/10/2021
' Time: 10:04
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'Defines some variables for use in the prgram
		Dim num1 As Double = 0
		Dim num2 As Double = 0
		Dim answer As Double = 0
		
		'Asks the user for some data
		Console.WriteLine("Please enter the length . . . ")
		num1 = Val(Console.ReadLine())
		Console.WriteLine("Please enter the width . . . ")
		num2 = Val(Console.ReadLine())
		
		'Finds the product of num1 and num2 and adds them together
		answer = (num1 * 2) + (num2 * 2)
		
		'Displays the answer
		Console.WriteLine("The perimeter is " & answer)
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
