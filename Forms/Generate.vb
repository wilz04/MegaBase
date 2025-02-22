Public Class Generate
  Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

  Public Sub New()
    MyBase.New()

    'El Diseñador de Windows Forms requiere esta llamada.
    InitializeComponent()

    'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
  Friend WithEvents gbReport As System.Windows.Forms.GroupBox
  Friend WithEvents rbSuppliers As System.Windows.Forms.RadioButton
  Friend WithEvents rbOldGetPay As System.Windows.Forms.RadioButton
  Friend WithEvents rbOldSetPay As System.Windows.Forms.RadioButton
  Friend WithEvents rbPayForms As System.Windows.Forms.RadioButton
  Friend WithEvents rbTime As System.Windows.Forms.RadioButton
  Friend WithEvents rbInventoryRotation As System.Windows.Forms.RadioButton
  Friend WithEvents rbInventoryDetail As System.Windows.Forms.RadioButton
  Friend WithEvents rbBuysDetail As System.Windows.Forms.RadioButton
  Friend WithEvents rbSalesByTime As System.Windows.Forms.RadioButton
  Friend WithEvents rbUtility As System.Windows.Forms.RadioButton
  Friend WithEvents rbArticles As System.Windows.Forms.RadioButton
  Friend WithEvents rbBuysBySupplier As System.Windows.Forms.RadioButton
  Friend WithEvents rbSalesByTimeAndSupplider As System.Windows.Forms.RadioButton
  Friend WithEvents rbBuysByTimeAndSupplier As System.Windows.Forms.RadioButton
  Friend WithEvents rbSalesByCount As System.Windows.Forms.RadioButton
  Friend WithEvents bOK As System.Windows.Forms.Button
  Friend WithEvents bCancel As System.Windows.Forms.Button
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.gbReport = New System.Windows.Forms.GroupBox
    Me.rbBuysBySupplier = New System.Windows.Forms.RadioButton
    Me.rbSuppliers = New System.Windows.Forms.RadioButton
    Me.rbOldGetPay = New System.Windows.Forms.RadioButton
    Me.rbOldSetPay = New System.Windows.Forms.RadioButton
    Me.rbPayForms = New System.Windows.Forms.RadioButton
    Me.rbTime = New System.Windows.Forms.RadioButton
    Me.rbInventoryRotation = New System.Windows.Forms.RadioButton
    Me.rbInventoryDetail = New System.Windows.Forms.RadioButton
    Me.rbSalesByTimeAndSupplider = New System.Windows.Forms.RadioButton
    Me.rbBuysDetail = New System.Windows.Forms.RadioButton
    Me.rbBuysByTimeAndSupplier = New System.Windows.Forms.RadioButton
    Me.rbSalesByCount = New System.Windows.Forms.RadioButton
    Me.rbSalesByTime = New System.Windows.Forms.RadioButton
    Me.rbUtility = New System.Windows.Forms.RadioButton
    Me.rbArticles = New System.Windows.Forms.RadioButton
    Me.bOK = New System.Windows.Forms.Button
    Me.bCancel = New System.Windows.Forms.Button
    Me.gbReport.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbReport
    '
    Me.gbReport.Controls.Add(Me.rbBuysBySupplier)
    Me.gbReport.Controls.Add(Me.rbSuppliers)
    Me.gbReport.Controls.Add(Me.rbOldGetPay)
    Me.gbReport.Controls.Add(Me.rbOldSetPay)
    Me.gbReport.Controls.Add(Me.rbPayForms)
    Me.gbReport.Controls.Add(Me.rbTime)
    Me.gbReport.Controls.Add(Me.rbInventoryRotation)
    Me.gbReport.Controls.Add(Me.rbInventoryDetail)
    Me.gbReport.Controls.Add(Me.rbSalesByTimeAndSupplider)
    Me.gbReport.Controls.Add(Me.rbBuysDetail)
    Me.gbReport.Controls.Add(Me.rbBuysByTimeAndSupplier)
    Me.gbReport.Controls.Add(Me.rbSalesByCount)
    Me.gbReport.Controls.Add(Me.rbSalesByTime)
    Me.gbReport.Controls.Add(Me.rbUtility)
    Me.gbReport.Controls.Add(Me.rbArticles)
    Me.gbReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.gbReport.Location = New System.Drawing.Point(8, 8)
    Me.gbReport.Name = "gbReport"
    Me.gbReport.Size = New System.Drawing.Size(576, 504)
    Me.gbReport.TabIndex = 0
    Me.gbReport.TabStop = False
    Me.gbReport.Text = "Generar Reporte"
    '
    'rbBuysBySupplier
    '
    Me.rbBuysBySupplier.Checked = True
    Me.rbBuysBySupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbBuysBySupplier.Location = New System.Drawing.Point(8, 24)
    Me.rbBuysBySupplier.Name = "rbBuysBySupplier"
    Me.rbBuysBySupplier.Size = New System.Drawing.Size(552, 24)
    Me.rbBuysBySupplier.TabIndex = 1
    Me.rbBuysBySupplier.TabStop = True
    Me.rbBuysBySupplier.Text = "Compras por Proveedor"
    '
    'rbSuppliers
    '
    Me.rbSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbSuppliers.Location = New System.Drawing.Point(8, 56)
    Me.rbSuppliers.Name = "rbSuppliers"
    Me.rbSuppliers.Size = New System.Drawing.Size(552, 24)
    Me.rbSuppliers.TabIndex = 0
    Me.rbSuppliers.Text = "Proveedores que dan crédito"
    '
    'rbOldGetPay
    '
    Me.rbOldGetPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbOldGetPay.Location = New System.Drawing.Point(8, 88)
    Me.rbOldGetPay.Name = "rbOldGetPay"
    Me.rbOldGetPay.Size = New System.Drawing.Size(552, 24)
    Me.rbOldGetPay.TabIndex = 0
    Me.rbOldGetPay.Text = "Antiguedad de Saltos (Cuentas por Cobrar)"
    '
    'rbOldSetPay
    '
    Me.rbOldSetPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbOldSetPay.Location = New System.Drawing.Point(8, 120)
    Me.rbOldSetPay.Name = "rbOldSetPay"
    Me.rbOldSetPay.Size = New System.Drawing.Size(552, 24)
    Me.rbOldSetPay.TabIndex = 0
    Me.rbOldSetPay.Text = "Antiguedad de Saltos (Cuentas por Pagar)"
    '
    'rbPayForms
    '
    Me.rbPayForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbPayForms.Location = New System.Drawing.Point(8, 152)
    Me.rbPayForms.Name = "rbPayForms"
    Me.rbPayForms.Size = New System.Drawing.Size(552, 24)
    Me.rbPayForms.TabIndex = 0
    Me.rbPayForms.Text = "Ventas pagados por: Efectivo, Cheque y Tarjeta"
    '
    'rbTime
    '
    Me.rbTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbTime.Location = New System.Drawing.Point(8, 184)
    Me.rbTime.Name = "rbTime"
    Me.rbTime.Size = New System.Drawing.Size(552, 24)
    Me.rbTime.TabIndex = 0
    Me.rbTime.Text = "Días promedio de cancelación de facturas (por cada medio de pago)"
    '
    'rbInventoryRotation
    '
    Me.rbInventoryRotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbInventoryRotation.Location = New System.Drawing.Point(8, 216)
    Me.rbInventoryRotation.Name = "rbInventoryRotation"
    Me.rbInventoryRotation.Size = New System.Drawing.Size(552, 24)
    Me.rbInventoryRotation.TabIndex = 0
    Me.rbInventoryRotation.Text = "Rotación de inventarios (Total, Por Cuenta y Por Artículo)"
    '
    'rbInventoryDetail
    '
    Me.rbInventoryDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbInventoryDetail.Location = New System.Drawing.Point(8, 248)
    Me.rbInventoryDetail.Name = "rbInventoryDetail"
    Me.rbInventoryDetail.Size = New System.Drawing.Size(552, 24)
    Me.rbInventoryDetail.TabIndex = 0
    Me.rbInventoryDetail.Text = "Detalle de inventario (incluye Artículo, Cantidad, Unid.Med., Precio Promedio y C" & _
    "osto Total)"
    '
    'rbSalesByTimeAndSupplider
    '
    Me.rbSalesByTimeAndSupplider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbSalesByTimeAndSupplider.Location = New System.Drawing.Point(8, 280)
    Me.rbSalesByTimeAndSupplider.Name = "rbSalesByTimeAndSupplider"
    Me.rbSalesByTimeAndSupplider.Size = New System.Drawing.Size(552, 24)
    Me.rbSalesByTimeAndSupplider.TabIndex = 0
    Me.rbSalesByTimeAndSupplider.Text = "Ventas Mensuales y Anuales por Cliente"
    '
    'rbBuysDetail
    '
    Me.rbBuysDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbBuysDetail.Location = New System.Drawing.Point(8, 312)
    Me.rbBuysDetail.Name = "rbBuysDetail"
    Me.rbBuysDetail.Size = New System.Drawing.Size(552, 24)
    Me.rbBuysDetail.TabIndex = 0
    Me.rbBuysDetail.Text = "Detalle Compras (incluye Artículo, Cantidad, Unid.Med., Precio Promedio y Costo T" & _
    "otal)"
    '
    'rbBuysByTimeAndSupplier
    '
    Me.rbBuysByTimeAndSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbBuysByTimeAndSupplier.Location = New System.Drawing.Point(8, 344)
    Me.rbBuysByTimeAndSupplier.Name = "rbBuysByTimeAndSupplier"
    Me.rbBuysByTimeAndSupplier.Size = New System.Drawing.Size(552, 24)
    Me.rbBuysByTimeAndSupplier.TabIndex = 0
    Me.rbBuysByTimeAndSupplier.Text = "Compras Mensuales y Anuales por Proveedor"
    '
    'rbSalesByCount
    '
    Me.rbSalesByCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbSalesByCount.Location = New System.Drawing.Point(8, 376)
    Me.rbSalesByCount.Name = "rbSalesByCount"
    Me.rbSalesByCount.Size = New System.Drawing.Size(552, 24)
    Me.rbSalesByCount.TabIndex = 0
    Me.rbSalesByCount.Text = "Ventas por Cuenta Contable (Línea de Producto)"
    '
    'rbSalesByTime
    '
    Me.rbSalesByTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbSalesByTime.Location = New System.Drawing.Point(8, 408)
    Me.rbSalesByTime.Name = "rbSalesByTime"
    Me.rbSalesByTime.Size = New System.Drawing.Size(552, 24)
    Me.rbSalesByTime.TabIndex = 0
    Me.rbSalesByTime.Text = "Ventas por Atículo y Día"
    '
    'rbUtility
    '
    Me.rbUtility.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbUtility.Location = New System.Drawing.Point(8, 440)
    Me.rbUtility.Name = "rbUtility"
    Me.rbUtility.Size = New System.Drawing.Size(552, 24)
    Me.rbUtility.TabIndex = 0
    Me.rbUtility.Text = "Margenes de Utilidad por Cuenta y Artículo"
    '
    'rbArticles
    '
    Me.rbArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.rbArticles.Location = New System.Drawing.Point(8, 472)
    Me.rbArticles.Name = "rbArticles"
    Me.rbArticles.Size = New System.Drawing.Size(552, 24)
    Me.rbArticles.TabIndex = 0
    Me.rbArticles.Text = "Listado de artículos sin movimiento (última semana, mes, bimestre, trimestre, etc" & _
    ".)"
    '
    'bOK
    '
    Me.bOK.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bOK.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bOK.Location = New System.Drawing.Point(416, 520)
    Me.bOK.Name = "bOK"
    Me.bOK.TabIndex = 2
    Me.bOK.Text = "Aceptar"
    '
    'bCancel
    '
    Me.bCancel.BackColor = System.Drawing.Color.FromArgb(CType(163, Byte), CType(184, Byte), CType(204, Byte))
    Me.bCancel.Cursor = System.Windows.Forms.Cursors.Hand
    Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bCancel.Location = New System.Drawing.Point(504, 520)
    Me.bCancel.Name = "bCancel"
    Me.bCancel.TabIndex = 3
    Me.bCancel.Text = "Cancelar"
    '
    'Generate
    '
    Me.AcceptButton = Me.bOK
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
    Me.BackColor = System.Drawing.Color.FromArgb(CType(240, Byte), CType(240, Byte), CType(240, Byte))
    Me.CancelButton = Me.bCancel
    Me.ClientSize = New System.Drawing.Size(594, 556)
    Me.ControlBox = False
    Me.Controls.Add(Me.bCancel)
    Me.Controls.Add(Me.bOK)
    Me.Controls.Add(Me.gbReport)
    Me.Font = New System.Drawing.Font("Verdana", 8.0!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximizeBox = False
    Me.Name = "Generate"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Nuevo"
    Me.gbReport.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

#End Region

  Public inform As New Report

  Private Sub bOK_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOK.Click
    Select Case True
      Case rbBuysBySupplier.Checked
        inform.type = "BuysBySupplier"
      Case rbSuppliers.Checked
        inform.type = "Suppliers"
      Case rbOldGetPay.Checked
        inform.type = "OldGetPay"
      Case rbOldSetPay.Checked
        inform.type = "OldSetPay"
      Case rbPayForms.Checked
        inform.type = "PayForms"
      Case rbTime.Checked
        inform.type = "Time"
      Case rbInventoryRotation.Checked
        inform.type = "InventoryRotation"
      Case rbInventoryDetail.Checked
        inform.type = "InventoryDetail"
      Case rbSalesByTimeAndSupplider.Checked
        inform.type = "SalesByTimeAndClient"
      Case rbBuysDetail.Checked
        inform.type = "BuysDetail"
      Case rbBuysByTimeAndSupplier.Checked
        inform.type = "BuysByTimeAndSupplier"
      Case rbSalesByCount.Checked
        inform.type = "SalesByCount"
      Case rbSalesByTime.Checked
        inform.type = "SalesByTime"
      Case rbUtility.Checked
        inform.type = "Utility"
      Case rbArticles.Checked
        inform.type = "Articles"
    End Select

    inform.MdiParent = Me.MdiParent
    inform.Show()
    Hide()
  End Sub

  Private Sub bCancel_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancel.Click
    Hide()
  End Sub

End Class
