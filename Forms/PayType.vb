Public Class PayType
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
  Friend WithEvents tbCode As System.Windows.Forms.TextBox
  Friend WithEvents lCode As System.Windows.Forms.Label
  Friend WithEvents gbPayType As System.Windows.Forms.GroupBox
  Friend WithEvents tbPayType As System.Windows.Forms.TextBox
  Friend WithEvents lPayType As System.Windows.Forms.Label
  Friend WithEvents bCancel As System.Windows.Forms.Button
  Friend WithEvents bOK As System.Windows.Forms.Button
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.gbPayType = New System.Windows.Forms.GroupBox
    Me.tbCode = New System.Windows.Forms.TextBox
    Me.lCode = New System.Windows.Forms.Label
    Me.tbPayType = New System.Windows.Forms.TextBox
    Me.lPayType = New System.Windows.Forms.Label
    Me.bCancel = New System.Windows.Forms.Button
    Me.bOK = New System.Windows.Forms.Button
    Me.gbPayType.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbPayType
    '
    Me.gbPayType.Controls.Add(Me.tbCode)
    Me.gbPayType.Controls.Add(Me.lCode)
    Me.gbPayType.Controls.Add(Me.tbPayType)
    Me.gbPayType.Controls.Add(Me.lPayType)
    Me.gbPayType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.gbPayType.Location = New System.Drawing.Point(16, 8)
    Me.gbPayType.Name = "gbPayType"
    Me.gbPayType.Size = New System.Drawing.Size(360, 56)
    Me.gbPayType.TabIndex = 0
    Me.gbPayType.TabStop = False
    '
    'tbCode
    '
    Me.tbCode.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbCode.Location = New System.Drawing.Point(88, 32)
    Me.tbCode.Name = "tbCode"
    Me.tbCode.Size = New System.Drawing.Size(256, 13)
    Me.tbCode.TabIndex = 2
    Me.tbCode.Text = ""
    '
    'lCode
    '
    Me.lCode.Location = New System.Drawing.Point(8, 32)
    Me.lCode.Name = "lCode"
    Me.lCode.Size = New System.Drawing.Size(72, 16)
    Me.lCode.TabIndex = 0
    Me.lCode.Text = "Código:"
    '
    'tbPayType
    '
    Me.tbPayType.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbPayType.Location = New System.Drawing.Point(88, 16)
    Me.tbPayType.Name = "tbPayType"
    Me.tbPayType.Size = New System.Drawing.Size(256, 13)
    Me.tbPayType.TabIndex = 1
    Me.tbPayType.Text = ""
    '
    'lPayType
    '
    Me.lPayType.Location = New System.Drawing.Point(8, 16)
    Me.lPayType.Name = "lPayType"
    Me.lPayType.Size = New System.Drawing.Size(72, 16)
    Me.lPayType.TabIndex = 0
    Me.lPayType.Text = "Descripción:"
    '
    'bCancel
    '
    Me.bCancel.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bCancel.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bCancel.Location = New System.Drawing.Point(296, 72)
    Me.bCancel.Name = "bCancel"
    Me.bCancel.TabIndex = 4
    Me.bCancel.Text = "Cancelar"
    '
    'bOK
    '
    Me.bOK.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bOK.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bOK.Location = New System.Drawing.Point(216, 72)
    Me.bOK.Name = "bOK"
    Me.bOK.TabIndex = 3
    Me.bOK.Text = "Aceptar"
    '
    'PayType
    '
    Me.AcceptButton = Me.bOK
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
    Me.BackColor = System.Drawing.Color.FromArgb(CType(240, Byte), CType(240, Byte), CType(240, Byte))
    Me.CancelButton = Me.bCancel
    Me.ClientSize = New System.Drawing.Size(394, 103)
    Me.ControlBox = False
    Me.Controls.Add(Me.bCancel)
    Me.Controls.Add(Me.bOK)
    Me.Controls.Add(Me.gbPayType)
    Me.Font = New System.Drawing.Font("Verdana", 8.0!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "PayType"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Tipo de pago"
    Me.gbPayType.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub bOK_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOK.Click
    If addPayType(tbCode.Text, tbPayType.Text) Then
      Close()
    Else
      MsgBox("Error al insertar el tipo de pago!", MsgBoxStyle.Exclamation, "Error")
    End If
  End Sub

  Private Sub bCancel_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancel.Click
    Close()
  End Sub
End Class
