Public Class Bill
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
  Friend WithEvents lFactura As System.Windows.Forms.Label
  Friend WithEvents rbCount As System.Windows.Forms.RadioButton
  Friend WithEvents rbCred As System.Windows.Forms.RadioButton
  Friend WithEvents lPayType As System.Windows.Forms.Label
  Friend WithEvents lPayTime As System.Windows.Forms.Label
  Friend WithEvents tbQuantity As System.Windows.Forms.TextBox
  Friend WithEvents lQuantity As System.Windows.Forms.Label
  Friend WithEvents tbU As System.Windows.Forms.TextBox
  Friend WithEvents lU As System.Windows.Forms.Label
  Friend WithEvents tbArticle As System.Windows.Forms.TextBox
  Friend WithEvents lArticle As System.Windows.Forms.Label
  Friend WithEvents tbMount As System.Windows.Forms.TextBox
  Friend WithEvents lMount As System.Windows.Forms.Label
  Friend WithEvents tbSubTotal As System.Windows.Forms.TextBox
  Friend WithEvents lSubTotal As System.Windows.Forms.Label
  Friend WithEvents tbDiscount As System.Windows.Forms.TextBox
  Friend WithEvents lDiscount As System.Windows.Forms.Label
  Friend WithEvents tbTotal As System.Windows.Forms.TextBox
  Friend WithEvents lTotal As System.Windows.Forms.Label
  Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
  Friend WithEvents bOK As System.Windows.Forms.Button
  Friend WithEvents bCancel As System.Windows.Forms.Button
  Friend WithEvents tbID As System.Windows.Forms.TextBox
  Friend WithEvents lID As System.Windows.Forms.Label
  Friend WithEvents gbID As System.Windows.Forms.GroupBox
  Friend WithEvents gbState As System.Windows.Forms.GroupBox
  Friend WithEvents gbPay As System.Windows.Forms.GroupBox
  Friend WithEvents tbBill As System.Windows.Forms.TextBox
  Friend WithEvents tbPayType As System.Windows.Forms.TextBox
  Friend WithEvents lPercent As System.Windows.Forms.Label
  Friend WithEvents tbPayTime As System.Windows.Forms.TextBox
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.lFactura = New System.Windows.Forms.Label
    Me.tbBill = New System.Windows.Forms.TextBox
    Me.rbCount = New System.Windows.Forms.RadioButton
    Me.rbCred = New System.Windows.Forms.RadioButton
    Me.dtpDate = New System.Windows.Forms.DateTimePicker
    Me.gbID = New System.Windows.Forms.GroupBox
    Me.tbID = New System.Windows.Forms.TextBox
    Me.lID = New System.Windows.Forms.Label
    Me.lPayType = New System.Windows.Forms.Label
    Me.lPayTime = New System.Windows.Forms.Label
    Me.tbQuantity = New System.Windows.Forms.TextBox
    Me.lQuantity = New System.Windows.Forms.Label
    Me.tbU = New System.Windows.Forms.TextBox
    Me.lU = New System.Windows.Forms.Label
    Me.tbArticle = New System.Windows.Forms.TextBox
    Me.lArticle = New System.Windows.Forms.Label
    Me.tbMount = New System.Windows.Forms.TextBox
    Me.lMount = New System.Windows.Forms.Label
    Me.tbSubTotal = New System.Windows.Forms.TextBox
    Me.lSubTotal = New System.Windows.Forms.Label
    Me.tbDiscount = New System.Windows.Forms.TextBox
    Me.lDiscount = New System.Windows.Forms.Label
    Me.tbTotal = New System.Windows.Forms.TextBox
    Me.lTotal = New System.Windows.Forms.Label
    Me.gbState = New System.Windows.Forms.GroupBox
    Me.lPercent = New System.Windows.Forms.Label
    Me.gbPay = New System.Windows.Forms.GroupBox
    Me.tbPayTime = New System.Windows.Forms.TextBox
    Me.tbPayType = New System.Windows.Forms.TextBox
    Me.bOK = New System.Windows.Forms.Button
    Me.bCancel = New System.Windows.Forms.Button
    Me.gbID.SuspendLayout()
    Me.gbState.SuspendLayout()
    Me.gbPay.SuspendLayout()
    Me.SuspendLayout()
    '
    'lFactura
    '
    Me.lFactura.Location = New System.Drawing.Point(24, 16)
    Me.lFactura.Name = "lFactura"
    Me.lFactura.Size = New System.Drawing.Size(72, 16)
    Me.lFactura.TabIndex = 0
    Me.lFactura.Text = "Factura #"
    '
    'tbBill
    '
    Me.tbBill.BackColor = System.Drawing.SystemColors.Window
    Me.tbBill.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbBill.ForeColor = System.Drawing.Color.DarkRed
    Me.tbBill.Location = New System.Drawing.Point(96, 16)
    Me.tbBill.Name = "tbBill"
    Me.tbBill.Size = New System.Drawing.Size(56, 13)
    Me.tbBill.TabIndex = 1
    Me.tbBill.Text = ""
    '
    'rbCount
    '
    Me.rbCount.Checked = True
    Me.rbCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbCount.Location = New System.Drawing.Point(352, 16)
    Me.rbCount.Name = "rbCount"
    Me.rbCount.Size = New System.Drawing.Size(72, 16)
    Me.rbCount.TabIndex = 2
    Me.rbCount.TabStop = True
    Me.rbCount.Text = "Contado"
    '
    'rbCred
    '
    Me.rbCred.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbCred.Location = New System.Drawing.Point(456, 16)
    Me.rbCred.Name = "rbCred"
    Me.rbCred.Size = New System.Drawing.Size(64, 16)
    Me.rbCred.TabIndex = 0
    Me.rbCred.Text = "Crédito"
    '
    'dtpDate
    '
    Me.dtpDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
    Me.dtpDate.Location = New System.Drawing.Point(392, 40)
    Me.dtpDate.MinDate = New Date(2006, 1, 1, 0, 0, 0, 0)
    Me.dtpDate.Name = "dtpDate"
    Me.dtpDate.Size = New System.Drawing.Size(96, 20)
    Me.dtpDate.TabIndex = 3
    '
    'gbID
    '
    Me.gbID.Controls.Add(Me.tbID)
    Me.gbID.Controls.Add(Me.lID)
    Me.gbID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.gbID.Location = New System.Drawing.Point(16, 64)
    Me.gbID.Name = "gbID"
    Me.gbID.Size = New System.Drawing.Size(512, 40)
    Me.gbID.TabIndex = 0
    Me.gbID.TabStop = False
    '
    'tbID
    '
    Me.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbID.Location = New System.Drawing.Point(80, 16)
    Me.tbID.Name = "tbID"
    Me.tbID.Size = New System.Drawing.Size(248, 13)
    Me.tbID.TabIndex = 4
    Me.tbID.Text = ""
    '
    'lID
    '
    Me.lID.Location = New System.Drawing.Point(8, 16)
    Me.lID.Name = "lID"
    Me.lID.Size = New System.Drawing.Size(72, 16)
    Me.lID.TabIndex = 0
    '
    'lPayType
    '
    Me.lPayType.Location = New System.Drawing.Point(8, 16)
    Me.lPayType.Name = "lPayType"
    Me.lPayType.Size = New System.Drawing.Size(88, 16)
    Me.lPayType.TabIndex = 0
    Me.lPayType.Text = "Tipo de pago:"
    '
    'lPayTime
    '
    Me.lPayTime.Location = New System.Drawing.Point(8, 40)
    Me.lPayTime.Name = "lPayTime"
    Me.lPayTime.Size = New System.Drawing.Size(88, 16)
    Me.lPayTime.TabIndex = 0
    Me.lPayTime.Text = "Días de pago:"
    '
    'tbQuantity
    '
    Me.tbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbQuantity.Location = New System.Drawing.Point(336, 32)
    Me.tbQuantity.Name = "tbQuantity"
    Me.tbQuantity.Size = New System.Drawing.Size(80, 13)
    Me.tbQuantity.TabIndex = 7
    Me.tbQuantity.Text = ""
    '
    'lQuantity
    '
    Me.lQuantity.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.lQuantity.Location = New System.Drawing.Point(336, 16)
    Me.lQuantity.Name = "lQuantity"
    Me.lQuantity.Size = New System.Drawing.Size(80, 16)
    Me.lQuantity.TabIndex = 0
    Me.lQuantity.Text = "Cantidad"
    Me.lQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'tbU
    '
    Me.tbU.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbU.Location = New System.Drawing.Point(248, 32)
    Me.tbU.Name = "tbU"
    Me.tbU.Size = New System.Drawing.Size(80, 13)
    Me.tbU.TabIndex = 6
    Me.tbU.Text = ""
    '
    'lU
    '
    Me.lU.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.lU.Location = New System.Drawing.Point(248, 16)
    Me.lU.Name = "lU"
    Me.lU.Size = New System.Drawing.Size(80, 16)
    Me.lU.TabIndex = 0
    Me.lU.Text = "Unidad"
    Me.lU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'tbArticle
    '
    Me.tbArticle.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbArticle.Location = New System.Drawing.Point(8, 32)
    Me.tbArticle.Name = "tbArticle"
    Me.tbArticle.Size = New System.Drawing.Size(232, 13)
    Me.tbArticle.TabIndex = 5
    Me.tbArticle.Text = ""
    '
    'lArticle
    '
    Me.lArticle.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.lArticle.Location = New System.Drawing.Point(8, 16)
    Me.lArticle.Name = "lArticle"
    Me.lArticle.Size = New System.Drawing.Size(232, 16)
    Me.lArticle.TabIndex = 0
    Me.lArticle.Text = "Artículo"
    Me.lArticle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'tbMount
    '
    Me.tbMount.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbMount.Location = New System.Drawing.Point(424, 32)
    Me.tbMount.Name = "tbMount"
    Me.tbMount.Size = New System.Drawing.Size(80, 13)
    Me.tbMount.TabIndex = 8
    Me.tbMount.Text = ""
    '
    'lMount
    '
    Me.lMount.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.lMount.Location = New System.Drawing.Point(424, 16)
    Me.lMount.Name = "lMount"
    Me.lMount.Size = New System.Drawing.Size(80, 16)
    Me.lMount.TabIndex = 0
    Me.lMount.Text = "Monto"
    Me.lMount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'tbSubTotal
    '
    Me.tbSubTotal.BackColor = System.Drawing.Color.White
    Me.tbSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbSubTotal.Location = New System.Drawing.Point(424, 56)
    Me.tbSubTotal.Name = "tbSubTotal"
    Me.tbSubTotal.ReadOnly = True
    Me.tbSubTotal.Size = New System.Drawing.Size(80, 13)
    Me.tbSubTotal.TabIndex = 9
    Me.tbSubTotal.Text = ""
    '
    'lSubTotal
    '
    Me.lSubTotal.Location = New System.Drawing.Point(336, 56)
    Me.lSubTotal.Name = "lSubTotal"
    Me.lSubTotal.Size = New System.Drawing.Size(80, 16)
    Me.lSubTotal.TabIndex = 0
    Me.lSubTotal.Text = "Subtotal:"
    Me.lSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'tbDiscount
    '
    Me.tbDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbDiscount.Location = New System.Drawing.Point(424, 72)
    Me.tbDiscount.Name = "tbDiscount"
    Me.tbDiscount.Size = New System.Drawing.Size(64, 13)
    Me.tbDiscount.TabIndex = 10
    Me.tbDiscount.Text = ""
    '
    'lDiscount
    '
    Me.lDiscount.Location = New System.Drawing.Point(336, 72)
    Me.lDiscount.Name = "lDiscount"
    Me.lDiscount.Size = New System.Drawing.Size(80, 16)
    Me.lDiscount.TabIndex = 0
    Me.lDiscount.Text = "Descuento:"
    Me.lDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'tbTotal
    '
    Me.tbTotal.BackColor = System.Drawing.Color.White
    Me.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbTotal.ForeColor = System.Drawing.Color.DarkRed
    Me.tbTotal.Location = New System.Drawing.Point(424, 96)
    Me.tbTotal.Name = "tbTotal"
    Me.tbTotal.ReadOnly = True
    Me.tbTotal.Size = New System.Drawing.Size(80, 13)
    Me.tbTotal.TabIndex = 11
    Me.tbTotal.Text = ""
    '
    'lTotal
    '
    Me.lTotal.Location = New System.Drawing.Point(336, 96)
    Me.lTotal.Name = "lTotal"
    Me.lTotal.Size = New System.Drawing.Size(80, 16)
    Me.lTotal.TabIndex = 0
    Me.lTotal.Text = "Total:"
    Me.lTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'gbState
    '
    Me.gbState.Controls.Add(Me.lPercent)
    Me.gbState.Controls.Add(Me.tbQuantity)
    Me.gbState.Controls.Add(Me.lQuantity)
    Me.gbState.Controls.Add(Me.tbArticle)
    Me.gbState.Controls.Add(Me.lArticle)
    Me.gbState.Controls.Add(Me.tbMount)
    Me.gbState.Controls.Add(Me.lMount)
    Me.gbState.Controls.Add(Me.tbSubTotal)
    Me.gbState.Controls.Add(Me.lSubTotal)
    Me.gbState.Controls.Add(Me.lDiscount)
    Me.gbState.Controls.Add(Me.tbDiscount)
    Me.gbState.Controls.Add(Me.tbTotal)
    Me.gbState.Controls.Add(Me.lTotal)
    Me.gbState.Controls.Add(Me.tbU)
    Me.gbState.Controls.Add(Me.lU)
    Me.gbState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.gbState.Location = New System.Drawing.Point(16, 104)
    Me.gbState.Name = "gbState"
    Me.gbState.Size = New System.Drawing.Size(512, 120)
    Me.gbState.TabIndex = 0
    Me.gbState.TabStop = False
    '
    'lPercent
    '
    Me.lPercent.BackColor = System.Drawing.SystemColors.Window
    Me.lPercent.Location = New System.Drawing.Point(488, 72)
    Me.lPercent.Name = "lPercent"
    Me.lPercent.Size = New System.Drawing.Size(16, 13)
    Me.lPercent.TabIndex = 0
    Me.lPercent.Text = "%"
    Me.lPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'gbPay
    '
    Me.gbPay.Controls.Add(Me.tbPayTime)
    Me.gbPay.Controls.Add(Me.tbPayType)
    Me.gbPay.Controls.Add(Me.lPayTime)
    Me.gbPay.Controls.Add(Me.lPayType)
    Me.gbPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.gbPay.Location = New System.Drawing.Point(16, 224)
    Me.gbPay.Name = "gbPay"
    Me.gbPay.Size = New System.Drawing.Size(512, 72)
    Me.gbPay.TabIndex = 0
    Me.gbPay.TabStop = False
    '
    'tbPayTime
    '
    Me.tbPayTime.BackColor = System.Drawing.Color.White
    Me.tbPayTime.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbPayTime.ForeColor = System.Drawing.SystemColors.WindowText
    Me.tbPayTime.Location = New System.Drawing.Point(96, 40)
    Me.tbPayTime.Name = "tbPayTime"
    Me.tbPayTime.Size = New System.Drawing.Size(144, 13)
    Me.tbPayTime.TabIndex = 13
    Me.tbPayTime.Text = ""
    '
    'tbPayType
    '
    Me.tbPayType.BackColor = System.Drawing.Color.White
    Me.tbPayType.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.tbPayType.ForeColor = System.Drawing.SystemColors.WindowText
    Me.tbPayType.Location = New System.Drawing.Point(96, 16)
    Me.tbPayType.Name = "tbPayType"
    Me.tbPayType.Size = New System.Drawing.Size(144, 13)
    Me.tbPayType.TabIndex = 12
    Me.tbPayType.Text = ""
    '
    'bOK
    '
    Me.bOK.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bOK.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bOK.Location = New System.Drawing.Point(368, 304)
    Me.bOK.Name = "bOK"
    Me.bOK.TabIndex = 14
    Me.bOK.Text = "Aceptar"
    '
    'bCancel
    '
    Me.bCancel.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bCancel.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bCancel.Location = New System.Drawing.Point(448, 304)
    Me.bCancel.Name = "bCancel"
    Me.bCancel.TabIndex = 15
    Me.bCancel.Text = "Cancelar"
    '
    'Bill
    '
    Me.AcceptButton = Me.bOK
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
    Me.BackColor = System.Drawing.Color.FromArgb(CType(240, Byte), CType(240, Byte), CType(240, Byte))
    Me.CancelButton = Me.bCancel
    Me.ClientSize = New System.Drawing.Size(544, 348)
    Me.ControlBox = False
    Me.Controls.Add(Me.bCancel)
    Me.Controls.Add(Me.bOK)
    Me.Controls.Add(Me.gbPay)
    Me.Controls.Add(Me.gbState)
    Me.Controls.Add(Me.gbID)
    Me.Controls.Add(Me.dtpDate)
    Me.Controls.Add(Me.rbCred)
    Me.Controls.Add(Me.rbCount)
    Me.Controls.Add(Me.tbBill)
    Me.Controls.Add(Me.lFactura)
    Me.Font = New System.Drawing.Font("Verdana", 8.0!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximizeBox = False
    Me.Name = "Bill"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Factura"
    Me.gbID.ResumeLayout(False)
    Me.gbState.ResumeLayout(False)
    Me.gbPay.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub _onLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    If Name = "SaleBill" Then
      tbBill.Text = getN()
      tbBill.ReadOnly = True
    End If
  End Sub

  Private Sub subTotal_onChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbQuantity.TextChanged, tbMount.TextChanged, tbDiscount.TextChanged
    tbSubTotal.Text = Trim(Str(Val(tbQuantity.Text) * Val(tbMount.Text)))
    tbTotal.Text = Trim(Str(Val(tbSubTotal.Text) - Val(tbDiscount.Text) / 100 * Val(tbSubTotal.Text)))
  End Sub

  Private Sub bOK_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOK.Click
    Dim cont_cred As String
    If rbCount.Checked Then
      cont_cred = "Contado"
    ElseIf rbCred.Checked Then
      cont_cred = "Crédito"
    End If

    Dim success As Boolean
    If Name = "PurchaseBill" Then
      success = addPurchaseBill(tbBill.Text, dtpDate.Text, tbID.Text, tbPayType.Text, cont_cred, tbPayTime.Text, tbU.Text, tbArticle.Text, Val(tbQuantity.Text), Val(tbDiscount.Text), Val(tbTotal.Text))
    ElseIf Name = "SaleBill" Then
      success = addSaleBill(tbBill.Text, dtpDate.Text, tbID.Text, tbPayType.Text, cont_cred, tbPayTime.Text, tbArticle.Text, Val(tbQuantity.Text), Val(tbDiscount.Text))
    End If

    If success Then
      Close()
    Else
      MsgBox("Error al insertar la factura!", MsgBoxStyle.Exclamation, "Error")
    End If
  End Sub

  Private Sub bCancel_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancel.Click
    Close()
  End Sub

End Class
