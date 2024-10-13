Imports System
Public Class Vehicle
    Inherits Object
    Public ReadOnly VIN As String
    Public ReadOnly Model As String
    Public WheelQuantity As Integer
    Public EngineSize As Integer

    Public Sub New(ByVal VIN As String)
        Me.VIN = VIN
    End Sub

    Public Sub New(ByVal VIN As String, ByVal Model As String)
        Me.VIN = VIN
        Me.Model = Model
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String
        s = "VIN: " & VIN & " : Model: " & Model
        s = s & "_" & MyBase.ToString()
        Return s
    End Function
End Class

Module Module1

    Sub Main()
        Console.WriteLine("Inheritance Example: ")

        Dim obj As New Vehicle("1111", "Nexon")
        Console.WriteLine(obj.ToString())
    End Sub
End Module