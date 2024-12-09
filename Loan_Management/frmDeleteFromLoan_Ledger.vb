Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmDeleteFromLoan_Ledger

    Private com As MySqlCommand
    Private reader As MySqlDataReader
    Dim db As programCode

    Public loanid As String
    Public borrowerid As String
    Public fullname As String
    Public dor As Date

    Dim bw As BackgroundWorker = New BackgroundWorker
    Public Delegate Sub PictureVisibilityDelegate(ByVal visibility As Boolean)
    Dim ChangePictureVisibility As PictureVisibilityDelegate

    Public Sub changeVisibility(ByVal visibility As Boolean)
        pictureBox1.Visible = visibility
    End Sub

    Private Sub bw_DoWork(sender As Object, e As DoWorkEventArgs)
        Me.Invoke(ChangePictureVisibility, True)
        db = New programCode
        Dim ex As String = $"select fullname,loan_type,duration,release_date,interest_rate,loan_amnt,released_amnt,total_amnt,due_date,paid_amnt,balance,perday,loan_status,payment_date,payed_amnt,or_no from loan_information as LI,borrowers_information as BI, loan_ledger as LL where (LI.borrowerid=@borrowerid and BI.borrowerid =@borrowerid) and (LI.loanid=@loanid and LL.loanid=@loanid)"
        com = New MySqlCommand(ex, db.getDBCon)
        com.Parameters.Add("@loanid", MySqlDbType.VarChar).Value = loanid
        com.Parameters.Add("@borrowerid", MySqlDbType.VarChar).Value = borrowerid

        Dim table As New System.Data.DataTable
        Dim adapter As New MySqlDataAdapter(com)
        adapter.Fill(table)
        datatableToExcel(table)
        delete_From_Ledger()
        delete_From_Loan()
    End Sub

    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        Me.Invoke(ChangePictureVisibility, False)
        Me.Close()
    End Sub

    Private Sub delete_From_Loan()
        db = New programCode
        Dim ex As String = $"delete from loan_information where loanid=@loanid"
        com = New MySqlCommand(ex, db.getDBCon)
        com.Parameters.Add("@loanid", MySqlDbType.VarChar).Value = loanid

        db.openConnection()
        com.ExecuteNonQuery()
        db.closeConnection()
    End Sub

    Private Sub delete_From_Ledger()
        db = New programCode
        Dim ex As String = $"delete from loan_ledger where loanid=@loanid"
        com = New MySqlCommand(ex, db.getDBCon)
        com.Parameters.Add("@loanid", MySqlDbType.VarChar).Value = loanid

        db.openConnection()
        com.ExecuteNonQuery()
        db.closeConnection()
    End Sub

    Private Sub datatableToExcel(ByVal dtTemp As DataTable)

        'Dim dir As String = "D:\LM_Record\"
        'Dim dir As String = "D:\CHONA_TALAN_LENDING\"
        Dim dir As String = "D:\_LENDING_\"
        Dim password As String = loanid
        Dim fileName As String = loanid & "_" & fullname & "_" & Format(dor, "yyyy-MMM-dd")

        Dim di As DirectoryInfo
        If Not (Directory.Exists(dir)) Then
            di = Directory.CreateDirectory(dir)
            di.Attributes = FileAttributes.Hidden
        End If

        Dim _excel As New Microsoft.Office.Interop.Excel.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim strFileName As String = dir & fileName & ".xlsx"

        wBook = _excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        Dim dt As System.Data.DataTable = dtTemp
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc In dt.Columns
            colIndex = colIndex + 1
            _excel.Cells(1, colIndex) = dc.ColumnName
        Next
        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                _excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next
        wSheet.Columns.AutoFit()

        If System.IO.File.Exists(strFileName) Then
            System.IO.File.Delete(strFileName)
        End If

        wBook.Password = password
        wBook.SaveAs(strFileName)
        wBook.Close()
        _excel.Quit()
    End Sub

    Private Sub frmDeleteFromLoan_Ledger_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
        ChangePictureVisibility = AddressOf changeVisibility

        If Not bw.IsBusy = True Then
            bw.RunWorkerAsync()
        End If
    End Sub
End Class