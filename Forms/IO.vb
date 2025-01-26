Option Strict Off
Option Explicit On 

Module IO

  Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer

  Public Const SW_NORMAL As Short = 1

  Public Sub getURL(ByRef url As String)
    If (ShellExecute(&O0S, "Open", url, vbNullString, vbNullString, SW_NORMAL)) Then
    End If
  End Sub

End Module
