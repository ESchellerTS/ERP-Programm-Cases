﻿Public Class CaseClass
    Private sap_proxy As _Case.Z_HH_CASEClient
    Private attributes As String
    Private record As String
    Private notes() As String
    Public Sub New()
        On Error GoTo errtrap
        sap_proxy = New _Case.Z_HH_CASEClient
        sap_proxy.ClientCredentials.UserName.UserName = "wsuser"
        sap_proxy.ClientCredentials.UserName.Password = "123456"

exitsub:
        Exit Sub
errtrap:
        Print(Err.Erl & ": " & Err.Description)
        Resume exitsub
    End Sub
    Public Function create(ContentList As String) As Boolean
        On Error GoTo errtrap
        Dim txt As String
        Dim inputTxt() As String
        Dim i As Integer
        i = 0
        inputTxt = Split(ContentList, "~~")

        For Each txt In inputTxt
            'Hier Reinschreiben
        Next

exitfunction:
        Exit Function
errtrap:
        Print(Err.Erl & ": " & Err.Description)
        Resume exitfunction
    End Function

    Public Function delete() As Boolean
        On Error GoTo errtrap
        If Me.deleteFromDB() Then
            delete = True
        End If

        Me.Finalize()
exitfunction:
        Exit Function
errtrap:
        delete = False
        Print(Err.Erl & ": " & Err.Description)
        Resume exitfunction
    End Function

    Private Function deleteFromDB() As Boolean
        On Error GoTo errtrap

        deleteFromDB = True
exitfunction:
        Exit Function
errtrap:
        deleteFromDB = False
        Print(Err.Erl & ": " & Err.Description)
        Resume exitfunction
    End Function

    Public Function save(ContentList As String) As Boolean
        On Error GoTo errtrap
        Dim txt As String
        Dim inputTxt() As String
        Dim i As Integer
        i = 0
        inputTxt = Split(ContentList, "~~")

        For Each txt In inputTxt
            'Hier Reinschreiben
            Me.notes(i) = txt
            i = i + 1
        Next

        Me.saveToDB()
        save = True
exitfunction:
        Exit Function
errtrap:
        save = False
        Print(Err.Erl & ": " & Err.Description)
        Resume exitfunction
    End Function

    Private Function saveToDB()
        On Error GoTo errtrap

exitfunction:
        Exit Function
errtrap:
        Print(Err.Erl & ": " & Err.Description)
        Resume exitfunction
    End Function

    Public Property Attributes1 As String
        Get
            Return attributes
        End Get
        Set(value As String)
            attributes = value
        End Set
    End Property

    Public Property Record1 As String
        Get
            Return record
        End Get
        Set(value As String)
            record = value
        End Set
    End Property

    Public Property Notes1 As String()
        Get
            Return notes
        End Get
        Set(value As String())
            notes = value
        End Set
    End Property
End Class
