Public Class Article
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
  Friend WithEvents tbID As System.Windows.Forms.TextBox
  Friend WithEvents lSupplier As System.Windows.Forms.Label
  Friend WithEvents tbCount As System.Windows.Forms.TextBox
  Friend WithEvents lCount As System.Windows.Forms.Label
  Friend WithEvents tbExistence As System.Windows.Forms.TextBox
  Friend WithEvents lExistence As System.Windows.Forms.Label
  Friend WithEvents tbCode As System.Windows.Forms.TextBox
  Friend WithEvents lCode As System.Windows.Forms.Label
  Friend WithEvents lU As System.Windows.Forms.Label
  Friend WithEvents tbArticle As System.Windows.Forms.TextBox
  Friend WithEvents lArticle As System.Windows.Forms.Label
  Friend WithEvents tbPrice As System.Windows.Forms.TextBox
  Friend WithEvents lPrice As System.Windows.Forms.Label
  Friend WithEvents gbSupplier As System.Windows.Forms.GroupBox
  Friend WithEvents gbArticle As System.Windows.Forms.GroupBox
  Friend WithEvents bCancel As System.Windows.Forms.Button
  Friend WithEvents bOK As System.Windows.Forms.Button
  Friend WithEvents tbU As System.Windows.Forms.TextBox
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.gbSupplier = New System.Windows.Forms.GroupBox
    Me.tbID = New System.Windows.Forms.TextBox
    Me.lSupplier = New System.Windows.Forms.Label
    Me.gbArticle = New System.Windows.Forms.GroupBox
    Me.tbPrice = New System.Windows.Forms.TextBox
    Me.lPrice = New System.Windows.Forms.Label
    Me.tbCount = New System.Windows.Forms.TextBox
    Me.lCount = New System.Windows.Forms.Label
    Me.tbExistence = New System.Windows.Forms.TextBox
    Me.lExistence = New System.Windows.Forms.Label
    Me.tbCode = New System.Windows.Forms.TextBox
    Me.lCode = New System.Windows.Forms.Label
    Me.tbU = New System.Windows.Forms.TextBox
    Me.lU = New System.Windows.Forms.Label
    Me.tbArticle = New System.Windows.Forms.TextBox
    Me.lArticle = New System.Windows.Forms.Label
    Me.bCancel = New System.Windows.Forms.Button
    Me.bOK = New System.Windows.Forms.Button
    Me.gbSupplier.SuspendLayout()
    Me.gbArticle.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbSupplier
    '
    Me.gbSupplier.Controls.Add(Me.tbID)
    Me.gbSupplier.Controls.Add(Me.lSupplier)
    Me.gbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.gbSupplier.Location = New System.Drawing.Point(16, 160)
    Me.gbSupplier.Name = "gbSupplier"
    Me.gbSupplier.Size = New System.Drawing.Size(360, 40)
    Me.gbSupplier.TabIndex = 0
    Me.gbSupplier.TabStop = False
    '
    'tbID
    '
    Me.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbID.Location = New System.Drawing.Point(80, 16)
    Me.tbID.Name = "tbID"
    Me.tbID.Size = New System.Drawing.Size(264, 13)
    Me.tbID.TabIndex = 7
    Me.tbID.Text = ""
    '
    'lSupplier
    '
    Me.lSupplier.Location = New System.Drawing.Point(8, 16)
    Me.lSupplier.Name = "lSupplier"
    Me.lSupplier.Size = New System.Drawing.Size(72, 16)
    Me.lSupplier.TabIndex = 0
    Me.lSupplier.Text = "Proveedor:"
    '
    'gbArticle
    '
    Me.gbArticle.Controls.Add(Me.tbPrice)
    Me.gbArticle.Controls.Add(Me.lPrice)
    Me.gbArticle.Controls.Add(Me.tbCount)
    Me.gbArticle.Controls.Add(Me.lCount)
    Me.gbArticle.Controls.Add(Me.tbExistence)
    Me.gbArticle.Controls.Add(Me.lExistence)
    Me.gbArticle.Controls.Add(Me.tbCode)
    Me.gbArticle.Controls.Add(Me.lCode)
    Me.gbArticle.Controls.Add(Me.tbU)
    Me.gbArticle.Controls.Add(Me.lU)
    Me.gbArticle.Controls.Add(Me.tbArticle)
    Me.gbArticle.Controls.Add(Me.lArticle)
    Me.gbArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.gbArticle.Location = New System.Drawing.Point(16, 8)
    Me.gbArticle.Name = "gbArticle"
    Me.gbArticle.Size = New System.Drawing.Size(360, 152)
    Me.gbArticle.TabIndex = 0
    Me.gbArticle.TabStop = False
    '
    'tbPrice
    '
    Me.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbPrice.Location = New System.Drawing.Point(80, 112)
    Me.tbPrice.Name = "tbPrice"
    Me.tbPrice.Size = New System.Drawing.Size(264, 13)
    Me.tbPrice.TabIndex = 6
    Me.tbPrice.Text = ""
    '
    'lPrice
    '
    Me.lPrice.Location = New System.Drawing.Point(8, 112)
    Me.lPrice.Name = "lPrice"
    Me.lPrice.Size = New System.Drawing.Size(72, 16)
    Me.lPrice.TabIndex = 0
    Me.lPrice.Text = "Precio:"
    '
    'tbCount
    '
    Me.tbCount.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbCount.Location = New System.Drawing.Point(80, 80)
    Me.tbCount.Name = "tbCount"
    Me.tbCount.Size = New System.Drawing.Size(264, 13)
    Me.tbCount.TabIndex = 5
    Me.tbCount.Text = ""
    '
    'lCount
    '
    Me.lCount.Location = New System.Drawing.Point(8, 80)
    Me.lCount.Name = "lCount"
    Me.lCount.Size = New System.Drawing.Size(72, 16)
    Me.lCount.TabIndex = 0
    Me.lCount.Text = "Cuenta:"
    '
    'tbExistence
    '
    Me.tbExistence.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbExistence.Location = New System.Drawing.Point(80, 64)
    Me.tbExistence.Name = "tbExistence"
    Me.tbExistence.Size = New System.Drawing.Size(264, 13)
    Me.tbExistence.TabIndex = 4
    Me.tbExistence.Text = ""
    '
    'lExistence
    '
    Me.lExistence.Location = New System.Drawing.Point(8, 64)
    Me.lExistence.Name = "lExistence"
    Me.lExistence.Size = New System.Drawing.Size(72, 16)
    Me.lExistence.TabIndex = 0
    Me.lExistence.Text = "Existencia:"
    '
    'tbCode
    '
    Me.tbCode.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbCode.Location = New System.Drawing.Point(80, 48)
    Me.tbCode.Name = "tbCode"
    Me.tbCode.Size = New System.Drawing.Size(264, 13)
    Me.tbCode.TabIndex = 3
    Me.tbCode.Text = ""
    '
    'lCode
    '
    Me.lCode.Location = New System.Drawing.Point(8, 48)
    Me.lCode.Name = "lCode"
    Me.lCode.Size = New System.Drawing.Size(72, 16)
    Me.lCode.TabIndex = 0
    Me.lCode.Text = "Código:"
    '
    'tbU
    '
    Me.tbU.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbU.Location = New System.Drawing.Point(80, 32)
    Me.tbU.Name = "tbU"
    Me.tbU.Size = New System.Drawing.Size(264, 13)
    Me.tbU.TabIndex = 2
    Me.tbU.Text = ""
    '
    'lU
    '
    Me.lU.Location = New System.Drawing.Point(8, 32)
    Me.lU.Name = "lU"
    Me.lU.Size = New System.Drawing.Size(72, 16)
    Me.lU.TabIndex = 0
    Me.lU.Text = "Unidad"
    '
    'tbArticle
    '
    Me.tbArticle.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbArticle.Location = New System.Drawing.Point(80, 16)
    Me.tbArticle.Name = "tbArticle"
    Me.tbArticle.Size = New System.Drawing.Size(264, 13)
    Me.tbArticle.TabIndex = 1
    Me.tbArticle.Text = ""
    '
    'lArticle
    '
    Me.lArticle.Location = New System.Drawing.Point(8, 16)
    Me.lArticle.Name = "lArticle"
    Me.lArticle.Size = New System.Drawing.Size(72, 16)
    Me.lArticle.TabIndex = 0
    Me.lArticle.Text = "Descripción:"
    '
    'bCancel
    '
    Me.bCancel.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bCancel.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bCancel.Location = New System.Drawing.Point(296, 208)
    Me.bCancel.Name = "bCancel"
    Me.bCancel.TabIndex = 9
    Me.bCancel.Text = "Cancelar"
    '
    'bOK
    '
    Me.bOK.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bOK.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bOK.Location = New System.Drawing.Point(216, 208)
    Me.bOK.Name = "bOK"
    Me.bOK.TabIndex = 8
    Me.bOK.Text = "Aceptar"
    '
    'Article
    '
    Me.AcceptButton = Me.bOK
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
    Me.BackColor = System.Drawing.Color.FromArgb(CType(240, Byte), CType(240, Byte), CType(240, Byte))
    Me.CancelButton = Me.bCancel
    Me.ClientSize = New System.Drawing.Size(394, 253)
    Me.ControlBox = False
    Me.Controls.Add(Me.bCancel)
    Me.Controls.Add(Me.bOK)
    Me.Controls.Add(Me.gbArticle)
    Me.Controls.Add(Me.gbSupplier)
    Me.Font = New System.Drawing.Font("Verdana", 8.0!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximizeBox = False
    Me.Name = "Article"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Artículo"
    Me.gbSupplier.ResumeLayout(False)
    Me.gbArticle.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub bOK_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOK.Click
    If addArticle(tbCode.Text, tbArticle.Text, tbU.Text, tbCount.Text, Val(tbPrice.Text), 0) Then
      Close()
    Else
      MsgBox("Error al insertar el artículo!", MsgBoxStyle.Exclamation, "Error")
    End If
  End Sub

  Private Sub bCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancel.Click
    Close()
  End Sub
End Class
