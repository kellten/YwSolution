Imports System.IO
Imports System.Xml

Public Class ClsDataTable
    ''' <summary>
    ''' DataTable Filter 하는 법
    ''' </summary>
    Private Sub DataTableFilter()
        Dim dt As New DataTable

        For Each dr As DataRow In dt.Select("CHART_NO = .... AND BEDIN_DATE = ....")

        Next

    End Sub

    Private Sub XmlStringToDaTaSet()
        Dim ds As New DataSet

        ds.ReadXml(New XmlTextReader(New StringReader("xml")))
        ' DataSet이 여러개일 때..
        ds.ReadXml(New XmlTextReader(New StringReader("<root>" & "xml" & "</root>")))

    End Sub

End Class
