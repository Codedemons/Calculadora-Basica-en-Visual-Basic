'
' Created by SharpDevelop.
' User: Coderp
' Date: 03/09/2021
' Time: 11:56
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmCalculardora
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCalculardora))
		Me.btnSuma = New System.Windows.Forms.Button()
		Me.btnSiete = New System.Windows.Forms.Button()
		Me.btnOcho = New System.Windows.Forms.Button()
		Me.btnResta = New System.Windows.Forms.Button()
		Me.btnNueve = New System.Windows.Forms.Button()
		Me.btnSeis = New System.Windows.Forms.Button()
		Me.btnCinco = New System.Windows.Forms.Button()
		Me.btnCuatro = New System.Windows.Forms.Button()
		Me.btnTres = New System.Windows.Forms.Button()
		Me.btnDivision = New System.Windows.Forms.Button()
		Me.btnDos = New System.Windows.Forms.Button()
		Me.btnUno = New System.Windows.Forms.Button()
		Me.btnIgual = New System.Windows.Forms.Button()
		Me.btnVaciar = New System.Windows.Forms.Button()
		Me.btnPunto = New System.Windows.Forms.Button()
		Me.btnZero = New System.Windows.Forms.Button()
		Me.btnMultiplicacion = New System.Windows.Forms.Button()
		Me.pnlTitulo = New System.Windows.Forms.Panel()
		Me.pbLogo = New System.Windows.Forms.PictureBox()
		Me.pbMini = New System.Windows.Forms.PictureBox()
		Me.pbClose = New System.Windows.Forms.PictureBox()
		Me.lblOperacion = New System.Windows.Forms.Label()
		Me.lblProceso = New System.Windows.Forms.Label()
		Me.pnlTitulo.SuspendLayout
		CType(Me.pbLogo,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pbMini,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pbClose,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'btnSuma
		'
		Me.btnSuma.BackColor = System.Drawing.Color.Transparent
		Me.btnSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSuma.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnSuma.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnSuma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnSuma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSuma.ForeColor = System.Drawing.Color.White
		Me.btnSuma.Location = New System.Drawing.Point(268, 48)
		Me.btnSuma.Name = "btnSuma"
		Me.btnSuma.Size = New System.Drawing.Size(75, 58)
		Me.btnSuma.TabIndex = 1
		Me.btnSuma.Text = "+"
		Me.btnSuma.UseVisualStyleBackColor = false
		AddHandler Me.btnSuma.Click, AddressOf Me.BtnSumaClick
		'
		'btnSiete
		'
		Me.btnSiete.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnSiete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnSiete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnSiete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSiete.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSiete.ForeColor = System.Drawing.Color.White
		Me.btnSiete.Location = New System.Drawing.Point(26, 120)
		Me.btnSiete.Name = "btnSiete"
		Me.btnSiete.Size = New System.Drawing.Size(75, 51)
		Me.btnSiete.TabIndex = 2
		Me.btnSiete.Text = "7"
		Me.btnSiete.UseVisualStyleBackColor = true
		AddHandler Me.btnSiete.Click, AddressOf Me.BtnSieteClick
		'
		'btnOcho
		'
		Me.btnOcho.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnOcho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnOcho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnOcho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnOcho.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnOcho.ForeColor = System.Drawing.Color.White
		Me.btnOcho.Location = New System.Drawing.Point(109, 120)
		Me.btnOcho.Name = "btnOcho"
		Me.btnOcho.Size = New System.Drawing.Size(75, 51)
		Me.btnOcho.TabIndex = 3
		Me.btnOcho.Text = "8"
		Me.btnOcho.UseVisualStyleBackColor = true
		AddHandler Me.btnOcho.Click, AddressOf Me.BtnOchoClick
		'
		'btnResta
		'
		Me.btnResta.BackColor = System.Drawing.Color.Transparent
		Me.btnResta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnResta.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnResta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnResta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnResta.ForeColor = System.Drawing.Color.White
		Me.btnResta.Location = New System.Drawing.Point(269, 119)
		Me.btnResta.Name = "btnResta"
		Me.btnResta.Size = New System.Drawing.Size(75, 51)
		Me.btnResta.TabIndex = 4
		Me.btnResta.Text = "-"
		Me.btnResta.UseVisualStyleBackColor = true
		AddHandler Me.btnResta.Click, AddressOf Me.BtnRestaClick
		'
		'btnNueve
		'
		Me.btnNueve.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnNueve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnNueve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnNueve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNueve.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnNueve.ForeColor = System.Drawing.Color.White
		Me.btnNueve.Location = New System.Drawing.Point(189, 119)
		Me.btnNueve.Name = "btnNueve"
		Me.btnNueve.Size = New System.Drawing.Size(75, 51)
		Me.btnNueve.TabIndex = 5
		Me.btnNueve.Text = "9"
		Me.btnNueve.UseVisualStyleBackColor = true
		AddHandler Me.btnNueve.Click, AddressOf Me.BtnNueveClick
		'
		'btnSeis
		'
		Me.btnSeis.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnSeis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnSeis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSeis.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSeis.ForeColor = System.Drawing.Color.White
		Me.btnSeis.Location = New System.Drawing.Point(188, 185)
		Me.btnSeis.Name = "btnSeis"
		Me.btnSeis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.btnSeis.Size = New System.Drawing.Size(75, 51)
		Me.btnSeis.TabIndex = 9
		Me.btnSeis.Text = "6"
		Me.btnSeis.UseVisualStyleBackColor = true
		AddHandler Me.btnSeis.Click, AddressOf Me.BtnSeisClick
		'
		'btnCinco
		'
		Me.btnCinco.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnCinco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnCinco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCinco.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnCinco.ForeColor = System.Drawing.Color.White
		Me.btnCinco.Location = New System.Drawing.Point(108, 186)
		Me.btnCinco.Name = "btnCinco"
		Me.btnCinco.Size = New System.Drawing.Size(75, 51)
		Me.btnCinco.TabIndex = 7
		Me.btnCinco.Text = "5"
		Me.btnCinco.UseVisualStyleBackColor = true
		AddHandler Me.btnCinco.Click, AddressOf Me.BtnCincoClick
		'
		'btnCuatro
		'
		Me.btnCuatro.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnCuatro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnCuatro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnCuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCuatro.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnCuatro.ForeColor = System.Drawing.Color.White
		Me.btnCuatro.Location = New System.Drawing.Point(25, 186)
		Me.btnCuatro.Name = "btnCuatro"
		Me.btnCuatro.Size = New System.Drawing.Size(75, 51)
		Me.btnCuatro.TabIndex = 6
		Me.btnCuatro.Text = "4"
		Me.btnCuatro.UseVisualStyleBackColor = true
		AddHandler Me.btnCuatro.Click, AddressOf Me.BtnCuatroClick
		'
		'btnTres
		'
		Me.btnTres.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnTres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnTres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnTres.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnTres.ForeColor = System.Drawing.Color.White
		Me.btnTres.Location = New System.Drawing.Point(188, 256)
		Me.btnTres.Name = "btnTres"
		Me.btnTres.Size = New System.Drawing.Size(75, 51)
		Me.btnTres.TabIndex = 13
		Me.btnTres.Text = "3"
		Me.btnTres.UseVisualStyleBackColor = true
		AddHandler Me.btnTres.Click, AddressOf Me.BtnTresClick
		'
		'btnDivision
		'
		Me.btnDivision.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnDivision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnDivision.ForeColor = System.Drawing.Color.White
		Me.btnDivision.Location = New System.Drawing.Point(268, 256)
		Me.btnDivision.Name = "btnDivision"
		Me.btnDivision.Size = New System.Drawing.Size(75, 51)
		Me.btnDivision.TabIndex = 12
		Me.btnDivision.Text = "/"
		Me.btnDivision.UseVisualStyleBackColor = true
		AddHandler Me.btnDivision.Click, AddressOf Me.BtnDivisionClick
		'
		'btnDos
		'
		Me.btnDos.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnDos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnDos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnDos.ForeColor = System.Drawing.Color.White
		Me.btnDos.Location = New System.Drawing.Point(108, 257)
		Me.btnDos.Name = "btnDos"
		Me.btnDos.Size = New System.Drawing.Size(75, 51)
		Me.btnDos.TabIndex = 11
		Me.btnDos.Text = "2"
		Me.btnDos.UseVisualStyleBackColor = true
		AddHandler Me.btnDos.Click, AddressOf Me.BtnDosClick
		'
		'btnUno
		'
		Me.btnUno.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnUno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnUno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUno.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnUno.ForeColor = System.Drawing.Color.White
		Me.btnUno.Location = New System.Drawing.Point(25, 257)
		Me.btnUno.Name = "btnUno"
		Me.btnUno.Size = New System.Drawing.Size(75, 51)
		Me.btnUno.TabIndex = 10
		Me.btnUno.Text = "1"
		Me.btnUno.UseVisualStyleBackColor = true
		AddHandler Me.btnUno.Click, AddressOf Me.BtnUnoClick
		'
		'btnIgual
		'
		Me.btnIgual.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnIgual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnIgual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnIgual.ForeColor = System.Drawing.Color.White
		Me.btnIgual.Location = New System.Drawing.Point(188, 325)
		Me.btnIgual.Name = "btnIgual"
		Me.btnIgual.Size = New System.Drawing.Size(75, 51)
		Me.btnIgual.TabIndex = 17
		Me.btnIgual.Text = "="
		Me.btnIgual.UseVisualStyleBackColor = true
		AddHandler Me.btnIgual.Click, AddressOf Me.BtnIgualClick
		'
		'btnVaciar
		'
		Me.btnVaciar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnVaciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnVaciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnVaciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnVaciar.ForeColor = System.Drawing.Color.White
		Me.btnVaciar.Location = New System.Drawing.Point(268, 325)
		Me.btnVaciar.Name = "btnVaciar"
		Me.btnVaciar.Size = New System.Drawing.Size(75, 51)
		Me.btnVaciar.TabIndex = 16
		Me.btnVaciar.Text = "C"
		Me.btnVaciar.UseVisualStyleBackColor = true
		AddHandler Me.btnVaciar.Click, AddressOf Me.BtnVaciarClick
		'
		'btnPunto
		'
		Me.btnPunto.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnPunto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnPunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnPunto.ForeColor = System.Drawing.Color.White
		Me.btnPunto.Location = New System.Drawing.Point(108, 326)
		Me.btnPunto.Name = "btnPunto"
		Me.btnPunto.Size = New System.Drawing.Size(75, 51)
		Me.btnPunto.TabIndex = 15
		Me.btnPunto.Text = "."
		Me.btnPunto.UseVisualStyleBackColor = true
		AddHandler Me.btnPunto.Click, AddressOf Me.BtnPuntoClick
		'
		'btnZero
		'
		Me.btnZero.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnZero.ForeColor = System.Drawing.Color.White
		Me.btnZero.Location = New System.Drawing.Point(25, 326)
		Me.btnZero.Name = "btnZero"
		Me.btnZero.Size = New System.Drawing.Size(75, 51)
		Me.btnZero.TabIndex = 14
		Me.btnZero.Text = "0"
		Me.btnZero.UseVisualStyleBackColor = true
		AddHandler Me.btnZero.Click, AddressOf Me.BtnZeroClick
		'
		'btnMultiplicacion
		'
		Me.btnMultiplicacion.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnMultiplicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(207,Byte),Integer))
		Me.btnMultiplicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(185,Byte),Integer))
		Me.btnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnMultiplicacion.ForeColor = System.Drawing.Color.White
		Me.btnMultiplicacion.Location = New System.Drawing.Point(268, 185)
		Me.btnMultiplicacion.Name = "btnMultiplicacion"
		Me.btnMultiplicacion.Size = New System.Drawing.Size(75, 51)
		Me.btnMultiplicacion.TabIndex = 18
		Me.btnMultiplicacion.Text = "*"
		Me.btnMultiplicacion.UseVisualStyleBackColor = true
		AddHandler Me.btnMultiplicacion.Click, AddressOf Me.BtnMultiplicacionClick
		'
		'pnlTitulo
		'
		Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(51,Byte),Integer), CType(CType(51,Byte),Integer))
		Me.pnlTitulo.Controls.Add(Me.pbLogo)
		Me.pnlTitulo.Controls.Add(Me.pbMini)
		Me.pnlTitulo.Controls.Add(Me.pbClose)
		Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
		Me.pnlTitulo.Name = "pnlTitulo"
		Me.pnlTitulo.Size = New System.Drawing.Size(369, 38)
		Me.pnlTitulo.TabIndex = 0
		AddHandler Me.pnlTitulo.MouseDown, AddressOf Me.PnlTituloMouseDown
		'
		'pbLogo
		'
		Me.pbLogo.Dock = System.Windows.Forms.DockStyle.Left
		Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"),System.Drawing.Image)
		Me.pbLogo.Location = New System.Drawing.Point(0, 0)
		Me.pbLogo.Name = "pbLogo"
		Me.pbLogo.Size = New System.Drawing.Size(34, 38)
		Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbLogo.TabIndex = 3
		Me.pbLogo.TabStop = false
		AddHandler Me.pbLogo.MouseDown, AddressOf Me.PbLogoMouseDown
		'
		'pbMini
		'
		Me.pbMini.Dock = System.Windows.Forms.DockStyle.Right
		Me.pbMini.Image = CType(resources.GetObject("pbMini.Image"),System.Drawing.Image)
		Me.pbMini.Location = New System.Drawing.Point(297, 0)
		Me.pbMini.Name = "pbMini"
		Me.pbMini.Size = New System.Drawing.Size(36, 38)
		Me.pbMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbMini.TabIndex = 2
		Me.pbMini.TabStop = false
		AddHandler Me.pbMini.Click, AddressOf Me.PbMiniClick
		'
		'pbClose
		'
		Me.pbClose.Dock = System.Windows.Forms.DockStyle.Right
		Me.pbClose.Image = CType(resources.GetObject("pbClose.Image"),System.Drawing.Image)
		Me.pbClose.Location = New System.Drawing.Point(333, 0)
		Me.pbClose.Name = "pbClose"
		Me.pbClose.Size = New System.Drawing.Size(36, 38)
		Me.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbClose.TabIndex = 1
		Me.pbClose.TabStop = false
		AddHandler Me.pbClose.Click, AddressOf Me.PbCloseClick
		'
		'lblOperacion
		'
		Me.lblOperacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(28,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(208,Byte),Integer))
		Me.lblOperacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.lblOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblOperacion.Location = New System.Drawing.Point(25, 71)
		Me.lblOperacion.Name = "lblOperacion"
		Me.lblOperacion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblOperacion.Size = New System.Drawing.Size(239, 35)
		Me.lblOperacion.TabIndex = 19
		Me.lblOperacion.Text = "0"
		Me.lblOperacion.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblProceso
		'
		Me.lblProceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(28,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(208,Byte),Integer))
		Me.lblProceso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblProceso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.lblProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblProceso.Location = New System.Drawing.Point(25, 48)
		Me.lblProceso.Name = "lblProceso"
		Me.lblProceso.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblProceso.Size = New System.Drawing.Size(239, 23)
		Me.lblProceso.TabIndex = 20
		Me.lblProceso.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'FrmCalculardora
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(91,Byte),Integer), CType(CType(100,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(369, 395)
		Me.Controls.Add(Me.lblOperacion)
		Me.Controls.Add(Me.lblProceso)
		Me.Controls.Add(Me.pnlTitulo)
		Me.Controls.Add(Me.btnMultiplicacion)
		Me.Controls.Add(Me.btnIgual)
		Me.Controls.Add(Me.btnVaciar)
		Me.Controls.Add(Me.btnPunto)
		Me.Controls.Add(Me.btnZero)
		Me.Controls.Add(Me.btnTres)
		Me.Controls.Add(Me.btnDivision)
		Me.Controls.Add(Me.btnDos)
		Me.Controls.Add(Me.btnUno)
		Me.Controls.Add(Me.btnSeis)
		Me.Controls.Add(Me.btnCinco)
		Me.Controls.Add(Me.btnCuatro)
		Me.Controls.Add(Me.btnNueve)
		Me.Controls.Add(Me.btnResta)
		Me.Controls.Add(Me.btnOcho)
		Me.Controls.Add(Me.btnSiete)
		Me.Controls.Add(Me.btnSuma)
		Me.ForeColor = System.Drawing.Color.White
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FrmCalculardora"
		Me.Text = "Calculadora"
		Me.pnlTitulo.ResumeLayout(false)
		CType(Me.pbLogo,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pbMini,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pbClose,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private lblProceso As System.Windows.Forms.Label
	Private lblOperacion As System.Windows.Forms.Label
	Private pbClose As System.Windows.Forms.PictureBox
	Private pbMini As System.Windows.Forms.PictureBox
	Private pbLogo As System.Windows.Forms.PictureBox
	Private pnlTitulo As System.Windows.Forms.Panel
	Private btnZero As System.Windows.Forms.Button
	Private btnPunto As System.Windows.Forms.Button
	Private btnVaciar As System.Windows.Forms.Button
	Private btnIgual As System.Windows.Forms.Button
	Private btnUno As System.Windows.Forms.Button
	Private btnDos As System.Windows.Forms.Button
	Private btnDivision As System.Windows.Forms.Button
	Private btnTres As System.Windows.Forms.Button
	Private btnCuatro As System.Windows.Forms.Button
	Private btnCinco As System.Windows.Forms.Button
	Private btnMultiplicacion As System.Windows.Forms.Button
	Private btnSeis As System.Windows.Forms.Button
	Private btnNueve As System.Windows.Forms.Button
	Private btnResta As System.Windows.Forms.Button
	Private btnOcho As System.Windows.Forms.Button
	Private btnSiete As System.Windows.Forms.Button
	Private btnSuma As System.Windows.Forms.Button
End Class
