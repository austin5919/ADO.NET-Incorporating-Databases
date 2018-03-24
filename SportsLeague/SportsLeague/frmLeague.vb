' Program Name:     Sports League Baseball National All-Stars Co-ed 
'                   Team Windows Application
' Author:           Austin Ash
' Date:             December 5, 2013
' Purpose:          This Windows application opens an Access database with
'                   22 boys and girls ages 12-14 who are playing in the 
'                   national Sports legue co-ed championship. The database
'                   can be viewed, updated, and deleted in the Windows form.
'                   The application also computes the number of 12,13, and 
'                   14 year olds on the team in three seperate counts and 
'                   the average of the team.

Option Strict On

Public Class frmLittleLeague
    Private Sub frmLeague_Load() Handles MyBase.Load
        'Executes when frmLeague (MyBase) Loads and then sets up DataSet
        Try
            Me.TeamTableAdapter.Fill(Me.LittleleagueDataSet.Team)
        Catch ex As Exception
            MsgBox("The Database file is Unavailable", , "Error")
            Close()
        End Try
    End Sub

    Private Sub bnavSave_Click() Handles bnavSave.Click
        'When bnavSave is clicked the Access Database is updated
        Try
            Me.Validate()
            Me.TeamBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.LittleleagueDataSet)
        Catch ex As SystemException
            MsgBox(ex.Message.ToString, , "Invalid Entry")
        End Try
        displayAverage()
    End Sub

    Private Sub displayAverage() Handles btnAverage.Click, MyBase.Load
        ' Displays count for 12, 13, 14 year olds and average age on team
        Dim strSql As String = "SELECT * FROM Team;"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" _
                                & "Data Source=E:\School - First Semester\Introduction To Programming\Chapter 10\CPA 5\SportsLeague\SportsLeague\bin\Debug\Resources\littleleague.accdb"
        Dim odaLeague As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datAge As New DataTable
        Dim intCount As Integer
        Dim decAgeAverage As Decimal
        Dim strAges(2) As Integer
        odaLeague.Fill(datAge)
        odaLeague.Dispose()
        For intCount = 0 To datAge.Rows.Count - 1
            Dim age = Convert.ToDecimal(datAge.Rows(intCount)("Age"))
            decAgeAverage += age
            Select Case age
                Case 12D
                    strAges(0) += 1
                Case 13D
                    strAges(1) += 1
                Case 14D
                    strAges(2) += 1
            End Select
        Next
        decAgeAverage /= datAge.Rows.Count
        lblAges.Text = "12 Year Olds: " & strAges(0) & vbNewLine & _
                      "13 Year Olds: " & strAges(1) & vbNewLine & _
                      "14 Year Olds: " & strAges(2) & vbNewLine & _
                      "Average Age: " & decAgeAverage.ToString("F1")
    End Sub
End Class
