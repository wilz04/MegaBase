Public Class Report
  Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

  Public Sub New()
    MyBase.New()

    'El Diseñador de Windows Forms requiere esta llamada.
    InitializeComponent()

    'Agregar cualquier inicialización después de la llamada a InitializeComponent()

  End Sub

  Public Sub New(ByVal type As String)
    MyBase.New()

    'El Diseñador de Windows Forms requiere esta llamada.
    InitializeComponent()

    'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    Me._type = type

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
  Friend WithEvents crvReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Report))
    Me.crvReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Me.SuspendLayout()
    '
    'crvReport
    '
    Me.crvReport.ActiveViewIndex = -1
    Me.crvReport.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crvReport.Location = New System.Drawing.Point(0, 0)
    Me.crvReport.Name = "crvReport"
    Me.crvReport.ReportSource = Nothing
    Me.crvReport.Size = New System.Drawing.Size(544, 378)
    Me.crvReport.TabIndex = 0
    '
    'Report
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
    Me.BackColor = System.Drawing.Color.FromArgb(CType(240, Byte), CType(240, Byte), CType(240, Byte))
    Me.ClientSize = New System.Drawing.Size(544, 378)
    Me.ControlBox = False
    Me.Controls.Add(Me.crvReport)
    Me.Font = New System.Drawing.Font("Verdana", 8.0!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "Report"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Reporte"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Const urlBase = "C:\Documents and Settings\wilz04\Escritorio\MegaBase\Reports\"
  Private _type As String

  Public Property type() As String
    Get
      'do nothing'
    End Get
    Set(ByVal value As String)
      _type = value
    End Set
  End Property

  Private Sub _onVisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
    If Me.Visible = True Then
      MdiParent.WindowState = FormWindowState.Maximized
      WindowState = FormWindowState.Maximized

      Text += " - " + _type
      crvReport.ReportSource = urlBase + _type + ".rpt"
    Else
      MdiParent.WindowState = FormWindowState.Normal
    End If
  End Sub

End Class
