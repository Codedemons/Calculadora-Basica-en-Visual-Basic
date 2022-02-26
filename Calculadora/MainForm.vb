'
' Created by SharpDevelop.
' User: Coderp
' Date: 03/09/2021
' Time: 11:56
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Runtime.InteropServices
Public Partial Class FrmCalculardora
	
	Dim Operacion As String
	Dim Resultado As Nullable(Of Double) = Nothing
	Dim Valor As Nullable(Of Double) = Nothing
	Dim Operador As Boolean
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	Sub BtnUnoClick(sender As Object, e As EventArgs)
		RestriccionesConcatenadas()		
		Me.lblOperacion.Text &= "1"
		Me.lblProceso.Text &= "1"
	End Sub
	
	Sub BtnDosClick(sender As Object, e As EventArgs)
		RestriccionesConcatenadas()
		Me.lblOperacion.Text &= "2"
		Me.lblProceso.Text &= "2"
	End Sub
	
	Sub BtnTresClick(sender As Object, e As EventArgs)
		RestriccionesConcatenadas()
		Me.lblOperacion.Text &= "3"
		Me.lblProceso.Text &= "3"
	End Sub
	
	Sub BtnCuatroClick(sender As Object, e As EventArgs)
		RestriccionesConcatenadas()
		Me.lblOperacion.Text &= "4"
		Me.lblProceso.Text &= "4"
	End Sub
	
	Sub BtnCincoClick(sender As Object, e As EventArgs)
		RestriccionesConcatenadas()
		Me.lblOperacion.Text &= "5"
		Me.lblProceso.Text &= "5"
	End Sub
	
	Sub BtnSeisClick(sender As Object, e As EventArgs)
		RestriccionesConcatenadas()
		Me.lblOperacion.Text &= "6"
		Me.lblProceso.Text &= "6"
	End Sub
	
	Sub BtnSieteClick(sender As Object, e As EventArgs)
		RestriccionesConcatenadas()
		Me.lblOperacion.Text &= "7"
		Me.lblProceso.Text &= "7"
	End Sub
	
	Sub BtnOchoClick(sender As Object, e As EventArgs)
		RestriccionesConcatenadas()
		Me.lblOperacion.Text &= "8"
		Me.lblProceso.Text &= "8"
	End Sub
	
	Sub BtnNueveClick(sender As Object, e As EventArgs)
		RestriccionesConcatenadas()
		Me.lblOperacion.Text &= "9"
		Me.lblProceso.Text &= "9"
	End Sub
	
	Sub BtnZeroClick(sender As Object, e As EventArgs)
		RestriccionesConcatenadas()
		Me.lblOperacion.Text &= "0"
	End Sub
	
	Sub BtnPuntoClick(sender As Object, e As EventArgs)
		RestriccionesConcatenadas()
		If InStr(lblOperacion.Text, ".", CompareMethod.Text) = 0 Then
				lblOperacion.Text &= "."
		End If
		If InStr(lblProceso.Text, ".", CompareMethod.Text) = 0 Then
				lblProceso.Text &= "."
		End If
	End Sub
	
	Sub BtnSumaClick(sender As Object, e As EventArgs)
		Operaciones()
		Operacion = "+"
		Me.lblProceso.Text &= "+"
	End Sub
	
	Sub BtnRestaClick(sender As Object, e As EventArgs)
		Operaciones()
		Operacion = "-"
		Me.lblProceso.Text &= "-"
	End Sub

	Sub BtnMultiplicacionClick(sender As Object, e As EventArgs)
		Operaciones()
		Operacion = "*"
		Me.lblProceso.Text &= "*"
	End Sub
	
	Sub BtnDivisionClick(sender As Object, e As EventArgs)
		Operaciones()
		Operacion = "/"
		Me.lblProceso.Text &= "/"
	End Sub
	
	Sub BtnIgualClick(sender As Object, e As EventArgs)
		Operaciones()
		Operacion = ""
		'lblProceso.Text = ""
	End Sub
	
	Sub BtnVaciarClick(sender As Object, e As EventArgs)
		lblOperacion.Text = "0"
		lblProceso.Text = ""
		Valor = Nothing
		Resultado = Nothing
	End Sub
	
	Public Sub Operaciones()
		Me.Operador = True
		Valor = Val(Me.lblOperacion.Text)
		If Resultado IsNot Nothing Then
			Select Case Operacion
				Case "+"
					Resultado += Valor
				Case "-"
					Resultado -= Valor
				Case "*"
					Resultado *= Valor
				Case "/"
					Resultado /= Valor
			End Select
			Me.lblOperacion.Text = CStr(Resultado)
		Else
			Resultado = Valor
		End If
		
	End Sub
	
	Public Sub RestriccionesConcatenadas()
		If Operador = True Then 
			lblOperacion.Text = ""
			Operador = False
		ElseIf lblOperacion.Text = "0" Then
			lblOperacion.Text = ""
		End If
			
	End Sub
	
	
	Sub PbCloseClick(sender As Object, e As EventArgs)
		Application.Exit
	End Sub
	
	
	Sub PbMiniClick(sender As Object, e As EventArgs)
		WindowState  = FormWindowState.Minimized
	End Sub
	
	#Region "Movimiento del Formulario"
	'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    
    	
	Sub PnlTituloMouseDown(sender As Object, e As MouseEventArgs)
		 ReleaseCapture()
		 SendMessage(Me.Handle, &H112, &HF012, 0)
	End Sub
	
	Sub PbLogoMouseDown(sender As Object, e As MouseEventArgs)
		 ReleaseCapture()
		 SendMessage(Me.Handle, &H112, &HF012, 0)
	End Sub
	
    #End Region
	

End Class
