'Carson Bogart
'RCET 0265
'Spring 22
'Multiplication Table
'https://github.com/bogacars/MultiplicationTable_CB.git

Option Explicit On
Option Strict On
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