Public Class Price
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
  Friend WithEvents tbDiscount As System.Windows.Forms.TextBox
  Friend WithEvents lDiscount As System.Windows.Forms.Label
  Friend WithEvents tbPrice As System.Windows.Forms.TextBox
  Friend WithEvents lPrice As System.Windows.Forms.Label
  Friend WithEvents tbCode As System.Windows.Forms.TextBox
  Friend WithEvents lCode As System.Windows.Forms.Label
  Friend WithEvents tbArticle As System.Windows.Forms.TextBox
  Friend WithEvents lArticle As System.Windows.Forms.Label
  Friend WithEvents bCancel As System.Windows.Forms.Button
  Friend WithEvents bOK As System.Windows.Forms.Button
  Friend WithEvents gbPrice As System.Windows.Forms.GroupBox
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.gbPrice = New System.Windows.Forms.GroupBox
    Me.tbDiscount = New System.Windows.Forms.TextBox
    Me.lDiscount = New System.Windows.Forms.Label
    Me.tbPrice = New System.Windows.Forms.TextBox
    Me.lPrice = New System.Windows.Forms.Label
    Me.tbCode = New System.Windows.Forms.TextBox
    Me.lCode = New System.Windows.Forms.Label
    Me.tbArticle = New System.Windows.Forms.TextBox
    Me.lArticle = New System.Windows.Forms.Label
    Me.bCancel = New System.Windows.Forms.Button
    Me.bOK = New System.Windows.Forms.Button
    Me.gbPrice.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbPrice
    '
    Me.gbPrice.Controls.Add(Me.tbDiscount)
    Me.gbPrice.Controls.Add(Me.lDiscount)
    Me.gbPrice.Controls.Add(Me.tbPrice)
    Me.gbPrice.Controls.Add(Me.lPrice)
    Me.gbPrice.Controls.Add(Me.tbCode)
    Me.gbPrice.Controls.Add(Me.lCode)
    Me.gbPrice.Controls.Add(Me.tbArticle)
    Me.gbPrice.Controls.Add(Me.lArticle)
    Me.gbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.gbPrice.Location = New System.Drawing.Point(16, 8)
    Me.gbPrice.Name = "gbPrice"
    Me.gbPrice.Size = New System.Drawing.Size(360, 88)
    Me.gbPrice.TabIndex = 0
    Me.gbPrice.TabStop = False
    '
    'tbDiscount
    '
    Me.tbDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbDiscount.Location = New System.Drawing.Point(208, 64)
    Me.tbDiscount.Name = "tbDiscount"
    Me.tbDiscount.Size = New System.Drawing.Size(136, 14)
    Me.tbDiscount.TabIndex = 4
    Me.tbDiscount.Text = ""
    '
    'lDiscount
    '
    Me.lDiscount.Location = New System.Drawing.Point(8, 64)
    Me.lDiscount.Name = "lDiscount"
    Me.lDiscount.Size = New System.Drawing.Size(192, 16)
    Me.lDiscount.TabIndex = 0
    Me.lDiscount.Text = "Descuento por pago en efectivo:"
    '
    'tbPrice
    '
    Me.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbPrice.Location = New System.Drawing.Point(208, 48)
    Me.tbPrice.Name = "tbPrice"
    Me.tbPrice.Size = New System.Drawing.Size(136, 14)
    Me.tbPrice.TabIndex = 3
    Me.tbPrice.Text = ""
    '
    'lPrice
    '
    Me.lPrice.Location = New System.Drawing.Point(8, 48)
    Me.lPrice.Name = "lPrice"
    Me.lPrice.Size = New System.Drawing.Size(192, 16)
    Me.lPrice.TabIndex = 0
    Me.lPrice.Text = "Precio:"
    '
    'tbCode
    '
    Me.tbCode.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbCode.Location = New System.Drawing.Point(208, 32)
    Me.tbCode.Name = "tbCode"
    Me.tbCode.Size = New System.Drawing.Size(136, 14)
    Me.tbCode.TabIndex = 2
    Me.tbCode.Text = ""
    '
    'lCode
    '
    Me.lCode.Location = New System.Drawing.Point(8, 32)
    Me.lCode.Name = "lCode"
    Me.lCode.Size = New System.Drawing.Size(192, 16)
    Me.lCode.TabIndex = 0
    Me.lCode.Text = "Código de artículo:"
    '
    'tbArticle
    '
    Me.tbArticle.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbArticle.Location = New System.Drawing.Point(208, 16)
    Me.tbArticle.Name = "tbArticle"
    Me.tbArticle.Size = New System.Drawing.Size(136, 14)
    Me.tbArticle.TabIndex = 1
    Me.tbArticle.Text = ""
    '
    'lArticle
    '
    Me.lArticle.Location = New System.Drawing.Point(8, 16)
    Me.lArticle.Name = "lArticle"
    Me.lArticle.Size = New System.Drawing.Size(192, 16)
    Me.lArticle.TabIndex = 0
    Me.lArticle.Text = "Artículo:"
    '
    'bCancel
    '
    Me.bCancel.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bCancel.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bCancel.Location = New System.Drawing.Point(296, 104)
    Me.bCancel.Name = "bCancel"
    Me.bCancel.TabIndex = 6
    Me.bCancel.Text = "Cancelar"
    '
    'bOK
    '
    Me.bOK.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bOK.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bOK.Location = New System.Drawing.Point(216, 104)
    Me.bOK.Name = "bOK"
    Me.bOK.TabIndex = 5
    Me.bOK.Text = "Aceptar"
    '
    'Price
    '
    Me.AcceptButton = Me.bOK
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
    Me.BackColor = System.Drawing.Color.FromArgb(CType(240, Byte), CType(240, Byte), CType(240, Byte))
    Me.CancelButton = Me.bCancel
    Me.ClientSize = New System.Drawing.Size(394, 138)
    Me.ControlBox = False
    Me.Controls.Add(Me.bCancel)
    Me.Controls.Add(Me.bOK)
    Me.Controls.Add(Me.gbPrice)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximizeBox = False
    Me.Name = "Price"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Precio"
    Me.gbPrice.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub bOK_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOK.Click
    If addPrice(tbCode.Text, tbArticle.Text, Val(tbPrice.Text), Val(tbDiscount.Text)) Then
      Close()
    Else
      MsgBox("Error al insertar el precio!", MsgBoxStyle.Exclamation, "Error")
    End If
  End Sub

  Private Sub bCancel_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancel.Click
    Close()
  End Sub
End Class
