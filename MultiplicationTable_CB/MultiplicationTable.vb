'Carson Bogart
'RCET 0265
'Spring 22
'Multiplication Table
'

Option Explicit On
Option Strict On
Option Compare Text
Module MultiplicationTable
    Sub Main()
        Dim size As Integer
        Console.WriteLine("Enter the size of table you desire")
        size = CInt(Console.ReadLine())
        For col = 1 To size
            For row = 1 To size
                Console.Write(Str(col * row).PadLeft(8))
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub

End Module