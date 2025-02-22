Public Class MainForm
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
  Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
  Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
  Friend WithEvents miFile As System.Windows.Forms.MenuItem
  Friend WithEvents miNew As System.Windows.Forms.MenuItem
  Friend WithEvents miClose As System.Windows.Forms.MenuItem
  Friend WithEvents miExit As System.Windows.Forms.MenuItem
  Friend WithEvents miInsert As System.Windows.Forms.MenuItem
  Friend WithEvents miPurchase As System.Windows.Forms.MenuItem
  Friend WithEvents miOptions As System.Windows.Forms.MenuItem
  Friend WithEvents miHelp As System.Windows.Forms.MenuItem
  Friend WithEvents miSale As System.Windows.Forms.MenuItem
  Friend WithEvents miSupplier As System.Windows.Forms.MenuItem
  Friend WithEvents miArticle As System.Windows.Forms.MenuItem
  Friend WithEvents miPayType As System.Windows.Forms.MenuItem
  Friend WithEvents miCount As System.Windows.Forms.MenuItem
  Friend WithEvents miPrice As System.Windows.Forms.MenuItem
  Friend WithEvents miStatusBar As System.Windows.Forms.MenuItem
  Friend WithEvents miExecute As System.Windows.Forms.MenuItem
  Friend WithEvents pbInit As System.Windows.Forms.PictureBox
  Friend WithEvents statusBar As System.Windows.Forms.StatusBar
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
    Me.MainMenu = New System.Windows.Forms.MainMenu
    Me.miFile = New System.Windows.Forms.MenuItem
    Me.miNew = New System.Windows.Forms.MenuItem
    Me.miClose = New System.Windows.Forms.MenuItem
    Me.MenuItem12 = New System.Windows.Forms.MenuItem
    Me.miExit = New System.Windows.Forms.MenuItem
    Me.miInsert = New System.Windows.Forms.MenuItem
    Me.miPurchase = New System.Windows.Forms.MenuItem
    Me.miSupplier = New System.Windows.Forms.MenuItem
    Me.miArticle = New System.Windows.Forms.MenuItem
    Me.miPayType = New System.Windows.Forms.MenuItem
    Me.miCount = New System.Windows.Forms.MenuItem
    Me.miSale = New System.Windows.Forms.MenuItem
    Me.miPrice = New System.Windows.Forms.MenuItem
    Me.miOptions = New System.Windows.Forms.MenuItem
    Me.miStatusBar = New System.Windows.Forms.MenuItem
    Me.miExecute = New System.Windows.Forms.MenuItem
    Me.miHelp = New System.Windows.Forms.MenuItem
    Me.pbInit = New System.Windows.Forms.PictureBox
    Me.statusBar = New System.Windows.Forms.StatusBar
    Me.SuspendLayout()
    '
    'MainMenu
    '
    Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miFile, Me.miInsert, Me.miOptions, Me.miHelp})
    '
    'miFile
    '
    Me.miFile.Index = 0
    Me.miFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miNew, Me.miClose, Me.MenuItem12, Me.miExit})
    Me.miFile.Text = "Archivo"
    '
    'miNew
    '
    Me.miNew.Index = 0
    Me.miNew.Text = "Nuevo..."
    '
    'miClose
    '
    Me.miClose.Index = 1
    Me.miClose.Text = "Cerrar"
    '
    'MenuItem12
    '
    Me.MenuItem12.Index = 2
    Me.MenuItem12.Text = "-"
    '
    'miExit
    '
    Me.miExit.Index = 3
    Me.miExit.Text = "Salir"
    '
    'miInsert
    '
    Me.miInsert.Index = 1
    Me.miInsert.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miPurchase, Me.miSupplier, Me.miArticle, Me.miPayType, Me.miCount, Me.miSale, Me.miPrice})
    Me.miInsert.Text = "Insertar"
    '
    'miPurchase
    '
    Me.miPurchase.Index = 0
    Me.miPurchase.Text = "Factura de compra"
    '
    'miSupplier
    '
    Me.miSupplier.Index = 1
    Me.miSupplier.Text = "Proveedor"
    '
    'miArticle
    '
    Me.miArticle.Index = 2
    Me.miArticle.Text = "Artículo"
    '
    'miPayType
    '
    Me.miPayType.Index = 3
    Me.miPayType.Text = "Tipo de pago"
    '
    'miCount
    '
    Me.miCount.Index = 4
    Me.miCount.Text = "Cuenta contable"
    '
    'miSale
    '
    Me.miSale.Index = 5
    Me.miSale.Text = "Factura de venta"
    '
    'miPrice
    '
    Me.miPrice.Index = 6
    Me.miPrice.Text = "Precio"
    '
    'miOptions
    '
    Me.miOptions.Index = 2
    Me.miOptions.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miStatusBar, Me.miExecute})
    Me.miOptions.Text = "Opciones"
    '
    'miStatusBar
    '
    Me.miStatusBar.Checked = True
    Me.miStatusBar.Index = 0
    Me.miStatusBar.Text = "Barra de estado"
    '
    'miExecute
    '
    Me.miExecute.Enabled = False
    Me.miExecute.Index = 1
    Me.miExecute.Text = "Ejecutar..."
    '
    'miHelp
    '
    Me.miHelp.Index = 3
    Me.miHelp.Text = "Ayuda"
    '
    'pbInit
    '
    Me.pbInit.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.pbInit.Image = CType(resources.GetObject("pbInit.Image"), System.Drawing.Image)
    Me.pbInit.Location = New System.Drawing.Point(145, 80)
    Me.pbInit.Name = "pbInit"
    Me.pbInit.Size = New System.Drawing.Size(504, 491)
    Me.pbInit.TabIndex = 11
    Me.pbInit.TabStop = False
    '
    'statusBar
    '
    Me.statusBar.Font = New System.Drawing.Font("Verdana", 8.0!)
    Me.statusBar.Location = New System.Drawing.Point(0, 629)
    Me.statusBar.Name = "statusBar"
    Me.statusBar.Size = New System.Drawing.Size(794, 22)
    Me.statusBar.TabIndex = 0
    '
    'MainForm
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
    Me.BackColor = System.Drawing.Color.FromArgb(CType(240, Byte), CType(240, Byte), CType(240, Byte))
    Me.ClientSize = New System.Drawing.Size(794, 651)
    Me.Controls.Add(Me.pbInit)
    Me.Controls.Add(Me.statusBar)
    Me.Font = New System.Drawing.Font("Verdana", 8.0!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.IsMdiContainer = True
    Me.MaximizeBox = False
    Me.Menu = Me.MainMenu
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Tag = ""
    Me.Text = "MegaBase"
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private report As New Generate

  Private Sub _onLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    report.MdiParent = Me
  End Sub

#Region " Opciones de menu "

  Private Sub miNew_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miNew.Click
    pbInit.Visible = False
    report.inform.Hide()
    report.Show()
  End Sub

  Private Sub miClose_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miClose.Click
    report.inform.Hide()
  End Sub

  Private Sub miExit_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miExit.Click
    Close()
  End Sub

  Private Sub miPurchase_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miPurchase.Click
    Dim bill As New PurchaseBill
    bill.MdiParent = Me
    pbInit.Visible = False
    report.inform.Hide()
    bill.Show()
  End Sub

  Private Sub miSupplier_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miSupplier.Click
    Dim supplier As New Supplier
    supplier.MdiParent = Me
    pbInit.Visible = False
    report.inform.Hide()
    supplier.Show()
  End Sub

  Private Sub miArticle_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miArticle.Click
    Dim article As New Article
    article.MdiParent = Me
    pbInit.Visible = False
    report.inform.Hide()
    article.Show()
  End Sub

  Private Sub miPayType_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miPayType.Click
    Dim payType As New PayType
    payType.MdiParent = Me
    pbInit.Visible = False
    report.inform.Hide()
    payType.Show()
  End Sub

  Private Sub miCount_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miCount.Click
    Dim count As New Count
    count.MdiParent = Me
    pbInit.Visible = False
    report.inform.Hide()
    count.Show()
  End Sub

  Private Sub miSale_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miSale.Click
    Dim bill As New SaleBill
    bill.MdiParent = Me
    pbInit.Visible = False
    report.inform.Hide()
    bill.Show()
  End Sub

  Private Sub miPrice_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miPrice.Click
    Dim price As New Price
    price.MdiParent = Me
    pbInit.Visible = False
    report.inform.Hide()
    price.Show()
  End Sub

  Private Sub miStatusBar_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miStatusBar.Click
    miStatusBar.Checked = Not miStatusBar.Checked
    statusBar.Visible = miStatusBar.Checked
  End Sub

  Private Sub miExecute_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miExecute.Click
    getURL("MegaData.exe")
  End Sub

  Private Sub miHelp_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miHelp.Click
    MsgBox("Desarrolladores:" & Chr(10) & "                                         " & Chr(10) & "Wilberth Castro" & Chr(10) & "Sergio Claudel", MsgBoxStyle.Information, "MegaBase")
  End Sub

#End Region

End Class
