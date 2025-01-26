Imports System.Data.Odbc

Module Cx

  Private cx As OdbcConnection
  Private order As String
  Private command As New OdbcCommand

  Public Sub Cx_init()
    cx = New OdbcConnection("DSN=General; UID=USV08; PWD=USV08;")
  End Sub

  Public Function getN() As String
    Try
      cx.Open()
      order = "Select max(Numero_factura) From Factura_venta"
      command = New OdbcCommand(order, cx)
      Dim dataSet As OdbcDataReader
      dataSet = command.ExecuteReader()
      dataSet.Read()
      Dim n As String
      n = Trim(Str(Val(dataSet.Item(0)) + 1))
      dataSet.Close()
      cx.Close()
      Return n
    Catch e As Exception
      cx.Close()
      Return "1"
    End Try
  End Function

  Public Function addPurchaseBill(ByVal number As String, ByVal today As Date, ByVal supplier As String, ByVal payType As String, ByVal count_cred As String, ByVal days As String, ByVal u As String, ByVal article As String, ByVal quantity As Integer, ByVal discount As Integer, ByVal total As Integer) As Boolean
    Try
      cx.Open()
      order = "Insert Into Factura_compra Values('" & number & "', '" & today & "', '" & supplier & "', '" & payType & "', '" & count_cred & "', '" & days & "', '" & u & "', '" & article & "', '" & discount & "')"
      command = New OdbcCommand(order, cx)
      Dim dataSet As OdbcDataReader
      dataSet = command.ExecuteReader()
      dataSet.Close()

      order = "Insert Into Compras Values('" & supplier & "', '" & number & "', '" & article & "', '" & quantity & "', '" & total & "')"
      command = New OdbcCommand(order, cx)
      dataSet = command.ExecuteReader()
      dataSet.Close()

      cx.Close()
      Return True
    Catch e As Exception
      cx.Close()
      Return False
    End Try
  End Function

  Public Function addSupplier(ByVal code As String, ByVal name As String, ByVal id As String, ByVal setCredit As String, ByVal phone As String, ByVal country As String, ByVal county As String) As Boolean
    Try
      cx.Open()
      order = "Insert Into Proveedor Values('" & code & "', '" & name & "', '" & id & "', '" & setCredit & "', '" & phone & "', '" & country & "', '" & county & "')"
      command = New OdbcCommand(order, cx)
      Dim dataSet As OdbcDataReader
      dataSet = command.ExecuteReader()
      dataSet.Close()
      cx.Close()
      Return True
    Catch e As Exception
      cx.Close()
      Return False
    End Try
  End Function

  Public Function addArticle(ByVal code As String, ByVal name As String, ByVal u As String, ByVal count As String, ByVal price As Integer, ByVal discount As Integer) As Boolean
    Try
      cx.Open()
      order = "Insert Into Articulo Values('" & code & "', '" & name & "', '" & u & "', '" & count & "')"
      command = New OdbcCommand(order, cx)
      Dim dataSet As OdbcDataReader
      dataSet = command.ExecuteReader()
      dataSet.Close()

      order = "Insert Into Precios Values('" & code & "', '" & name & "', " & price & ", " & discount & ")"
      command = New OdbcCommand(order, cx)
      dataSet = command.ExecuteReader()
      dataSet.Close()

      cx.Close()
      Return True
    Catch e As Exception
      cx.Close()
      Return False
    End Try
  End Function

  Public Function addPayType(ByVal code As String, ByVal description As String) As Boolean
    Try
      cx.Open()
      order = "Insert Into Tipos_de_pago Values('" & code & "', '" & description & "')"
      command = New OdbcCommand(order, cx)
      Dim dataSet As OdbcDataReader
      dataSet = command.ExecuteReader()
      dataSet.Close()
      cx.Close()
      Return True
    Catch e As Exception
      cx.Close()
      Return False
    End Try
  End Function

  Public Function addCount(ByVal code As String, ByVal level As String) As Boolean
    Try
      cx.Open()
      order = "Insert Into Cuentas_cont Values('" & code & "', '" & level & "')"
      command = New OdbcCommand(order, cx)
      Dim dataSet As OdbcDataReader
      dataSet = command.ExecuteReader()
      dataSet.Close()
      cx.Close()
      Return True
    Catch e As Exception
      cx.Close()
      Return False
    End Try
  End Function

  Public Function addSaleBill(ByVal number As String, ByVal today As Date, ByVal client As String, ByVal payType As String, ByVal count_cred As String, ByVal days As String, ByVal article As String, ByVal quantity As Integer, ByVal discount As Integer) As Boolean
    Try
      cx.Open()
      order = "Insert Into Factura_venta Values('" & number & "', '" & today & "', '" & client & "', '" & payType & "', '" & count_cred & "', '" & days & "', '" & article & "', '" & discount & "')"
      command = New OdbcCommand(order, cx)
      Dim dataSet As OdbcDataReader
      dataSet = command.ExecuteReader()
      dataSet.Close()

      order = "Insert Into Ventas Values('" & client & "', '" & number & "', '" & article & "', '" & quantity & "')"
      command = New OdbcCommand(order, cx)
      dataSet = command.ExecuteReader()
      dataSet.Close()

      cx.Close()
      Return True
    Catch e As Exception
      cx.Close()
      Return False
    End Try
  End Function

  Public Function addPrice(ByVal code As String, ByVal name As String, ByVal price As Integer, ByVal discount As Integer) As Boolean
    Try
      cx.Open()
      order = "Select * From Articulo Where Codigo = '" & code & "' And Descripcion = '" & name & "'"
      command = New OdbcCommand(order, cx)
      Dim dataSet As OdbcDataReader
      dataSet = command.ExecuteReader()
      If dataSet.Read Then
        dataSet.Close()

        order = "Update Precios Set Precio = '" & price & "', Desc_pago_efect = '" & discount & "' Where Cod_Artic = '" & code & "' And Articulo = '" & name & "'"
        command = New OdbcCommand(order, cx)
        dataSet = command.ExecuteReader()
        dataSet.Close()

        If dataSet.RecordsAffected = 0 Then
          order = "Insert Into Precios Values('" & code & "', '" & name & "', " & price & ", " & discount & ")"
          command = New OdbcCommand(order, cx)
          dataSet = command.ExecuteReader()
          dataSet.Close()
        End If

        dataSet.Close()
        cx.Close()
        Return True
      Else
        dataSet.Close()
        cx.Close()
        Return False
      End If
    Catch e As Exception
      cx.Close()
      Return False
    End Try
  End Function

End Module
