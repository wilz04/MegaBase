Public Class Supplier
  Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

  Public Sub New()
    MyBase.New()

    'El Diseñador de Windows Forms requiere esta llamada.
    InitializeComponent()

    'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    Cx_init()

  End Sub

  'Form reemplaza a Dispose para limpiar la lista de componentes.
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing Then
      If Not (components Is Nothing) Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
  'Puede modificarse utilizando el Diseñador de Windows Forms. 
  'No lo modifique con el editor de código.
  Friend WithEvents tbName As System.Windows.Forms.TextBox
  Friend WithEvents lName As System.Windows.Forms.Label
  Friend WithEvents tbID As System.Windows.Forms.TextBox
  Friend WithEvents lID As System.Windows.Forms.Label
  Friend WithEvents tbPhone As System.Windows.Forms.TextBox
  Friend WithEvents lPhone As System.Windows.Forms.Label
  Friend WithEvents tbCountry As System.Windows.Forms.TextBox
  Friend WithEvents lCountry As System.Windows.Forms.Label
  Friend WithEvents tbCounty As System.Windows.Forms.TextBox
  Friend WithEvents lCounty As System.Windows.Forms.Label
  Friend WithEvents gbCredit As System.Windows.Forms.GroupBox
  Friend WithEvents rbFalse As System.Windows.Forms.RadioButton
  Friend WithEvents rbTrue As System.Windows.Forms.RadioButton
  Friend WithEvents bCancel As System.Windows.Forms.Button
  Friend WithEvents bOK As System.Windows.Forms.Button
  Friend WithEvents tbCode As System.Windows.Forms.TextBox
  Friend WithEvents lCode As System.Windows.Forms.Label
  Friend WithEvents gbPersonalData As System.Windows.Forms.GroupBox
  Friend WithEvents gbCommercialData As System.Windows.Forms.GroupBox
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.gbPersonalData = New System.Windows.Forms.GroupBox
    Me.tbCounty = New System.Windows.Forms.TextBox
    Me.lCounty = New System.Windows.Forms.Label
    Me.tbCountry = New System.Windows.Forms.TextBox
    Me.lCountry = New System.Windows.Forms.Label
    Me.tbPhone = New System.Windows.Forms.TextBox
    Me.lPhone = New System.Windows.Forms.Label
    Me.tbID = New System.Windows.Forms.TextBox
    Me.lID = New System.Windows.Forms.Label
    Me.tbName = New System.Windows.Forms.TextBox
    Me.lName = New System.Windows.Forms.Label
    Me.gbCommercialData = New System.Windows.Forms.GroupBox
    Me.gbCredit = New System.Windows.Forms.GroupBox
    Me.rbFalse = New System.Windows.Forms.RadioButton
    Me.rbTrue = New System.Windows.Forms.RadioButton
    Me.tbCode = New System.Windows.Forms.TextBox
    Me.lCode = New System.Windows.Forms.Label
    Me.bCancel = New System.Windows.Forms.Button
    Me.bOK = New System.Windows.Forms.Button
    Me.gbPersonalData.SuspendLayout()
    Me.gbCommercialData.SuspendLayout()
    Me.gbCredit.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbPersonalData
    '
    Me.gbPersonalData.Controls.Add(Me.tbCounty)
    Me.gbPersonalData.Controls.Add(Me.lCounty)
    Me.gbPersonalData.Controls.Add(Me.tbCountry)
    Me.gbPersonalData.Controls.Add(Me.lCountry)
    Me.gbPersonalData.Controls.Add(Me.tbPhone)
    Me.gbPersonalData.Controls.Add(Me.lPhone)
    Me.gbPersonalData.Controls.Add(Me.tbID)
    Me.gbPersonalData.Controls.Add(Me.lID)
    Me.gbPersonalData.Controls.Add(Me.tbName)
    Me.gbPersonalData.Controls.Add(Me.lName)
    Me.gbPersonalData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.gbPersonalData.Location = New System.Drawing.Point(16, 8)
    Me.gbPersonalData.Name = "gbPersonalData"
    Me.gbPersonalData.Size = New System.Drawing.Size(360, 104)
    Me.gbPersonalData.TabIndex = 0
    Me.gbPersonalData.TabStop = False
    '
    'tbCounty
    '
    Me.tbCounty.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbCounty.Location = New System.Drawing.Point(80, 80)
    Me.tbCounty.Name = "tbCounty"
    Me.tbCounty.Size = New System.Drawing.Size(264, 13)
    Me.tbCounty.TabIndex = 5
    Me.tbCounty.Text = ""
    '
    'lCounty
    '
    Me.lCounty.Location = New System.Drawing.Point(8, 80)
    Me.lCounty.Name = "lCounty"
    Me.lCounty.Size = New System.Drawing.Size(72, 16)
    Me.lCounty.TabIndex = 0
    Me.lCounty.Text = "Provincia:"
    '
    'tbCountry
    '
    Me.tbCountry.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbCountry.Location = New System.Drawing.Point(80, 64)
    Me.tbCountry.Name = "tbCountry"
    Me.tbCountry.Size = New System.Drawing.Size(264, 13)
    Me.tbCountry.TabIndex = 4
    Me.tbCountry.Text = ""
    '
    'lCountry
    '
    Me.lCountry.Location = New System.Drawing.Point(8, 64)
    Me.lCountry.Name = "lCountry"
    Me.lCountry.Size = New System.Drawing.Size(72, 16)
    Me.lCountry.TabIndex = 0
    Me.lCountry.Text = "País:"
    '
    'tbPhone
    '
    Me.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbPhone.Location = New System.Drawing.Point(80, 48)
    Me.tbPhone.Name = "tbPhone"
    Me.tbPhone.Size = New System.Drawing.Size(264, 13)
    Me.tbPhone.TabIndex = 3
    Me.tbPhone.Text = ""
    '
    'lPhone
    '
    Me.lPhone.Location = New System.Drawing.Point(8, 48)
    Me.lPhone.Name = "lPhone"
    Me.lPhone.Size = New System.Drawing.Size(72, 16)
    Me.lPhone.TabIndex = 0
    Me.lPhone.Text = "Teléfono:"
    '
    'tbID
    '
    Me.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbID.Location = New System.Drawing.Point(80, 32)
    Me.tbID.Name = "tbID"
    Me.tbID.Size = New System.Drawing.Size(264, 13)
    Me.tbID.TabIndex = 2
    Me.tbID.Text = ""
    '
    'lID
    '
    Me.lID.Location = New System.Drawing.Point(8, 32)
    Me.lID.Name = "lID"
    Me.lID.Size = New System.Drawing.Size(72, 16)
    Me.lID.TabIndex = 0
    Me.lID.Text = "Cédula:"
    '
    'tbName
    '
    Me.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbName.Location = New System.Drawing.Point(80, 16)
    Me.tbName.Name = "tbName"
    Me.tbName.Size = New System.Drawing.Size(264, 13)
    Me.tbName.TabIndex = 1
    Me.tbName.Text = ""
    '
    'lName
    '
    Me.lName.Location = New System.Drawing.Point(8, 16)
    Me.lName.Name = "lName"
    Me.lName.Size = New System.Drawing.Size(72, 16)
    Me.lName.TabIndex = 0
    Me.lName.Text = "Nombre:"
    '
    'gbCommercialData
    '
    Me.gbCommercialData.Controls.Add(Me.gbCredit)
    Me.gbCommercialData.Controls.Add(Me.tbCode)
    Me.gbCommercialData.Controls.Add(Me.lCode)
    Me.gbCommercialData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.gbCommercialData.Location = New System.Drawing.Point(16, 112)
    Me.gbCommercialData.Name = "gbCommercialData"
    Me.gbCommercialData.Size = New System.Drawing.Size(360, 144)
    Me.gbCommercialData.TabIndex = 0
    Me.gbCommercialData.TabStop = False
    '
    'gbCredit
    '
    Me.gbCredit.Controls.Add(Me.rbFalse)
    Me.gbCredit.Controls.Add(Me.rbTrue)
    Me.gbCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.gbCredit.Location = New System.Drawing.Point(8, 40)
    Me.gbCredit.Name = "gbCredit"
    Me.gbCredit.Size = New System.Drawing.Size(336, 80)
    Me.gbCredit.TabIndex = 0
    Me.gbCredit.TabStop = False
    Me.gbCredit.Text = "Da Crédito"
    '
    'rbFalse
    '
    Me.rbFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbFalse.Location = New System.Drawing.Point(16, 48)
    Me.rbFalse.Name = "rbFalse"
    Me.rbFalse.Size = New System.Drawing.Size(72, 16)
    Me.rbFalse.TabIndex = 0
    Me.rbFalse.Text = "No"
    '
    'rbTrue
    '
    Me.rbTrue.Checked = True
    Me.rbTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbTrue.Location = New System.Drawing.Point(16, 24)
    Me.rbTrue.Name = "rbTrue"
    Me.rbTrue.Size = New System.Drawing.Size(72, 16)
    Me.rbTrue.TabIndex = 7
    Me.rbTrue.TabStop = True
    Me.rbTrue.Text = "Sí"
    '
    'tbCode
    '
    Me.tbCode.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbCode.Location = New System.Drawing.Point(80, 16)
    Me.tbCode.Name = "tbCode"
    Me.tbCode.Size = New System.Drawing.Size(264, 13)
    Me.tbCode.TabIndex = 6
    Me.tbCode.Text = ""
    '
    'lCode
    '
    Me.lCode.Location = New System.Drawing.Point(8, 16)
    Me.lCode.Name = "lCode"
    Me.lCode.Size = New System.Drawing.Size(72, 16)
    Me.lCode.TabIndex = 0
    Me.lCode.Text = "Código:"
    '
    'bCancel
    '
    Me.bCancel.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bCancel.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bCancel.Location = New System.Drawing.Point(296, 264)
    Me.bCancel.Name = "bCancel"
    Me.bCancel.TabIndex = 9
    Me.bCancel.Text = "Cancelar"
    '
    'bOK
    '
    Me.bOK.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bOK.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bOK.Location = New System.Drawing.Point(216, 264)
    Me.bOK.Name = "bOK"
    Me.bOK.TabIndex = 8
    Me.bOK.Text = "Aceptar"
    '
    'Supplier
    '
    Me.AcceptButton = Me.bOK
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
    Me.BackColor = System.Drawing.Color.FromArgb(CType(240, Byte), CType(240, Byte), CType(240, Byte))
    Me.CancelButton = Me.bCancel
    Me.ClientSize = New System.Drawing.Size(394, 303)
    Me.ControlBox = False
    Me.Controls.Add(Me.bCancel)
    Me.Controls.Add(Me.bOK)
    Me.Controls.Add(Me.gbCommercialData)
    Me.Controls.Add(Me.gbPersonalData)
    Me.Font = New System.Drawing.Font("Verdana", 8.0!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximizeBox = False
    Me.Name = "Supplier"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Proveedor"
    Me.gbPersonalData.ResumeLayout(False)
    Me.gbCommercialData.ResumeLayout(False)
    Me.gbCredit.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub bOK_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOK.Click
    Dim setCredit As String
    If rbTrue.Checked Then
      setCredit = "Sí"
    ElseIf rbFalse.Checked Then
      setCredit = "No"
    End If

    If addSupplier(tbCode.Text, tbName.Text, tbID.Text, setCredit, tbPhone.Text, tbCountry.Text, tbCounty.Text) Then
      Close()
    Else
      MsgBox("Error al insertar el proveedor!", MsgBoxStyle.Exclamation, "Error")
    End If
  End Sub

  Private Sub bCancel_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancel.Click
    Close()
  End Sub
End Class
