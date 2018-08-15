Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.IO.Ports
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms



Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim serialPort As System.IO.Ports.SerialPort = New System.IO.Ports.SerialPort()
        Dim charArrayRankOne(4) As Char
        Dim text As System.IO.Ports.SerialPort = serialPort
        text.PortName = Me.ComBox.Text
        text.BaudRate = 4800
        text.DataBits = 8
        text.Parity = Parity.None
        text.Handshake = Handshake.None
        Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.FileSelect.Text)
        Dim [integer] As Integer = Conversions.ToInteger(Me.Linenum.Text)
        serialPort.Open()
        Dim num As Integer = [integer]
        Dim num1 As Integer = 0
        Do
            Thread.Sleep(20)
            charArrayRankOne = Conversions.ToCharArrayRankOne("t")
            Dim str As String = streamReader.ReadLine()
            Me.Text2.Text = str
            serialPort.Write(str)
            serialPort.Write(str)
            While Operators.CompareString(New String(charArrayRankOne), "t", False) = 0
                charArrayRankOne = Conversions.ToCharArrayRankOne("t")
                serialPort.Read(charArrayRankOne, 0, 1)
            End While
            num1 = num1 + 1
        Loop While num1 <= num
        serialPort.Close()
        text = Nothing
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pth As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        FileSelect.Text = pth & "\rcode.txt"
    End Sub
End Class
