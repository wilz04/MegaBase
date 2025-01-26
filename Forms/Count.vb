Public Class Count
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
  Friend WithEvents bCancel As System.Windows.Forms.Button
  Friend WithEvents bOK As System.Windows.Forms.Button
  Friend WithEvents tbCode As System.Windows.Forms.TextBox
  Friend WithEvents lCode As System.Windows.Forms.Label
  Friend WithEvents gbCount As System.Windows.Forms.GroupBox
  Friend WithEvents rbSecond As System.Windows.Forms.RadioButton
  Friend WithEvents rbFirst As System.Windows.Forms.RadioButton
  Friend WithEvents gbLevel As System.Windows.Forms.GroupBox
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.bCancel = New System.Windows.Forms.Button
    Me.bOK = New System.Windows.Forms.Button
    Me.gbCount = New System.Windows.Forms.GroupBox
    Me.gbLevel = New System.Windows.Forms.GroupBox
    Me.rbSecond = New System.Windows.Forms.RadioButton
    Me.rbFirst = New System.Windows.Forms.RadioButton
    Me.tbCode = New System.Windows.Forms.TextBox
    Me.lCode = New System.Windows.Forms.Label
    Me.gbCount.SuspendLayout()
    Me.gbLevel.SuspendLayout()
    Me.SuspendLayout()
    '
    'bCancel
    '
    Me.bCancel.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bCancel.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bCancel.Location = New System.Drawing.Point(296, 160)
    Me.bCancel.Name = "bCancel"
    Me.bCancel.TabIndex = 4
    Me.bCancel.Text = "Cancelar"
    '
    'bOK
    '
    Me.bOK.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bOK.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bOK.Location = New System.Drawing.Point(216, 160)
    Me.bOK.Name = "bOK"
    Me.bOK.TabIndex = 3
    Me.bOK.Text = "Aceptar"
    '
    'gbCount
    '
    Me.gbCount.Controls.Add(Me.gbLevel)
    Me.gbCount.Controls.Add(Me.tbCode)
    Me.gbCount.Controls.Add(Me.lCode)
    Me.gbCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.gbCount.Location = New System.Drawing.Point(16, 8)
    Me.gbCount.Name = "gbCount"
    Me.gbCount.Size = New System.Drawing.Size(360, 144)
    Me.gbCount.TabIndex = 0
    Me.gbCount.TabStop = False
    '
    'gbLevel
    '
    Me.gbLevel.Controls.Add(Me.rbSecond)
    Me.gbLevel.Controls.Add(Me.rbFirst)
    Me.gbLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.gbLevel.Location = New System.Drawing.Point(8, 40)
    Me.gbLevel.Name = "gbLevel"
    Me.gbLevel.Size = New System.Drawing.Size(336, 80)
    Me.gbLevel.TabIndex = 0
    Me.gbLevel.TabStop = False
    Me.gbLevel.Text = "Nivel"
    '
    'rbSecond
    '
    Me.rbSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbSecond.Location = New System.Drawing.Point(16, 48)
    Me.rbSecond.Name = "rbSecond"
    Me.rbSecond.Size = New System.Drawing.Size(104, 16)
    Me.rbSecond.TabIndex = 0
    Me.rbSecond.Text = "Segundo nivel"
    '
    'rbFirst
    '
    Me.rbFirst.Checked = True
    Me.rbFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbFirst.Location = New System.Drawing.Point(16, 24)
    Me.rbFirst.Name = "rbFirst"
    Me.rbFirst.Size = New System.Drawing.Size(104, 16)
    Me.rbFirst.TabIndex = 2
    Me.rbFirst.TabStop = True
    Me.rbFirst.Text = "Primer nivel"
    '
    'tbCode
    '
    Me.tbCode.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbCode.Location = New System.Drawing.Point(80, 16)
    Me.tbCode.Name = "tbCode"
    Me.tbCode.Size = New System.Drawing.Size(264, 13)
    Me.tbCode.TabIndex = 1
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
    'Count
    '
    Me.AcceptButton = Me.bOK
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
    Me.BackColor = System.Drawing.Color.FromArgb(CType(240, Byte), CType(240, Byte), CType(240, Byte))
    Me.CancelButton = Me.bCancel
    Me.ClientSize = New System.Drawing.Size(394, 203)
    Me.ControlBox = False
    Me.Controls.Add(Me.bCancel)
    Me.Controls.Add(Me.bOK)
    Me.Controls.Add(Me.gbCount)
    Me.Font = New System.Drawing.Font("Verdana", 8.0!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Count"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Cuenta contable"
    Me.gbCount.ResumeLayout(False)
    Me.gbLevel.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub bOK_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOK.Click
    Dim level As String
    If rbFirst.Checked Then
      level = "Primero"
    ElseIf rbSecond.Checked Then
      level = "Segundo"
    End If

    If addCount(tbCode.Text, level) Then
      Close()
    Else
      MsgBox("Error al insertar la cuenta contable!", MsgBoxStyle.Exclamation, "Error")
    End If
  End Sub

  Private Sub bCancel_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancel.Click
    Close()
  End Sub

End Class
