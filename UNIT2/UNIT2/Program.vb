'Imports System

'Module Program

'    Public Class Car
'        Private carMake As String = "Tata"
'        Public carModel As String = "Nexon"


'        Public Overloads Function StartEngine(ByVal carKey As Integer) As Boolean
'            If carKey = 5 Then
'                Return True
'            Else
'                Return False
'            End If

'        End Function

'        Public Overloads Function StartEngine(ByVal carKey As String) As Boolean
'            If carKey = "please" Then
'                Return True
'            Else
'                Return False

'            End If
'        End Function

'        Public Function get_carMake() As String
'            Return carMake

'        End Function

'        Public Sub set_carMake(ByVal _carMake As String)
'            carMake = _carMake
'        End Sub

'        Public Property carMake__() As String
'            Get
'                Return carMake
'            End Get
'            Set(value As String)
'                carMake = value
'            End Set
'        End Property

'    End Class




'        Sub Main(args As String())
'            Console.WriteLine("Hello")

'            Dim obj As New Car()
'            Console.WriteLine("Car make is: " + obj.get_carMake())
'            obj.set_carMake("Jeep")

'            Console.WriteLine("Carkey You entered: " + obj.StartEngine(10).ToString())
'            Console.WriteLine("car Make is: " + obj.get_carMake())
'            Console.WriteLine("Use of Property : Car Make is: " + obj.carMake__)

'            obj.carMake__ = "Thar"

'            Console.WriteLine("Use of Property : Car Make is : " + obj.carMake__)



'        End Sub
'End Module

'    ctrl+k ctrl+C
'    ctrl+k ctrl+U