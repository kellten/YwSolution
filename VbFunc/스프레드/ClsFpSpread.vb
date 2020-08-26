Public Class ClsFpSpread
    'Private Sub SetAutoAllColumnHeader(ByVal oSpread As FarPoint.Win.Spread.FpSpread)

    '    For Each col As FarPoint.Win.Spread.Column In oSpread.ActiveSheet.Columns
    '        col.Width = col.GetPreferredWidth + 5
    '        col.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
    '    Next

    '    With oSpread.ActiveSheet
    '        For i As Integer = 0 To .Columns.Count - 1
    '            For Each dr As DataRow In _dtColumnDesc.Rows
    '                If .ColumnHeader.Cells(0, i).Text.Contains(Trim(dr("COL_NAME"))) = True Then
    '                    If Trim(dr("COL_DESC").ToString()) <> "" Then
    '                        .ColumnHeader.Cells(0, i).Text = .ColumnHeader.Cells(0, i).Text.Replace(Trim(dr("COL_NAME").ToString()), Trim(dr("COL_DESC").ToString()))
    '                    End If
    '                End If
    '            Next
    '        Next
    '    End With

    'End Sub
End Class
