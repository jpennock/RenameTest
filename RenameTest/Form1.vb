Imports System.Text
Imports System.Data.OleDb
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser
Imports System
Imports System.IO
Imports System.Collections
Public Class Form1
    Dim PDFtable As New DataTable
    Private Sub LocateFileButton_Click(sender As Object, e As EventArgs) Handles LocateFileButton.Click
        If DialogF.ShowDialog() = Windows.Forms.DialogResult.OK Then
            DirectoryTextbox.Text = DialogF.SelectedPath
            Try
                PDFtable.Clear()
                'MsgBox("Yes")
                Dim Count As Integer = 0
                Dim dirs As String() = Directory.GetFiles(DirectoryTextbox.Text, "*batch*")
                Dim dir As String
                For Each dir In dirs
                    PDFtable.Rows.Add(dir)
                    Count += 1
                Next
                FileCountLabel.Text = Count
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        PDFtable.Columns.Add("File")
    End Sub

    Private Sub ImportListButton_Click(sender As Object, e As EventArgs) Handles ImportListButton.Click
        Dim FileChoice As String = ""
        Dim ExcelConnect As String = ""
        If OpenDialogF.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FileChoice = OpenDialogF.FileName
            ExcelConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & FileChoice & ";Extended Properties=""Excel 12.0 Xml"";"

            Dim ExcelQuery As String = "Select * from [Sheet1$]"
            Dim Exceladapt As New OleDbDataAdapter(ExcelQuery, ExcelConnect)
            Dim ExcelTable As New DataTable
            Exceladapt.Fill(ExcelTable)
            Try
                If ExcelTable.Rows.Count > 0 Then
                    ExcelListDGV.DataSource = ExcelTable
                    For r = 0 To ExcelListDGV.Rows.Count - 2
                        For c = 1 To 2
                            Dim tobesplit As String = ExcelListDGV.Rows(r).Cells(c).Value.ToString
                            'MsgBox(tobesplit)
                            Dim split() As String = tobesplit.Split(New Char() {"-"})
                            ExcelListDGV.Rows(r).Cells(c).Value = split(0)
                        Next
                    Next
                    SearchCheckList.Items.Clear()
                    For Each column As DataGridViewColumn In ExcelListDGV.Columns
                        SearchCheckList.Items.Add(column.HeaderText)
                    Next
                    For i = 1 To SearchCheckList.Items.Count - 1
                        SearchCheckList.SetItemChecked(i, True)
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If

    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Try
            ProgressBar1.Maximum = PDFtable.Rows.Count
            WorkProgressBar.Maximum = PDFtable.Rows.Count
            Dim STPWatch As New Stopwatch
            STPWatch.Start()
            For i = 0 To PDFtable.Rows.Count - 1
                ProgressBar1.Value += 1
                Dim Page As Integer = 0
                Dim SearchFile As String = PDFtable.Rows(i)(0)
                Dim Search(SearchCheckList.CheckedItems.Count - 1) As String
                Dim CountIt As Integer = 0
                Dim IndexChecked As Integer = 0
                Dim IndexCheck(SearchCheckList.CheckedItems.Count - 1) As Integer
                Dim SearchVIN = ""
                Dim SearchName = ""
                Dim VINFound As Boolean = False
                Dim NameFound As Boolean = False
                Dim TextPDF As String = ""
                Dim Reader = New PdfReader(SearchFile)
                For Each IndexChecked In SearchCheckList.CheckedIndices 'which DGV items do I need to search for (by index)
                    If IndexChecked <> 0 Then
                        IndexCheck(CountIt) = IndexChecked
                        CountIt += 1
                    End If
                Next
                For Page = 1 To Reader.NumberOfPages
                    TextPDF += PdfTextExtractor.GetTextFromPage(Reader, Page)
                Next
                For r = 0 To ExcelListDGV.Rows.Count - 2
                    For s = 0 To IndexCheck.Count - 1 'add the searchable strings to this array (by DGV index) then use this array later when searching for items!
                        'MsgBox(IndexCheck(s).ToString & " " & s & " " & r)
                        Search(s) = ExcelListDGV.Rows(r).Cells(IndexCheck(s)).Value.ToString
                    Next
                    'MsgBox(TextPDF)
                    For ck = 0 To Search.Count - 1
                        'MsgBox(Search(ck).ToString)
                        If TextPDF.Contains(Search(ck)) Then
                            'MsgBox("Success @ " & SearchFile.ToString & " WITH: " & Search(ck).ToString & " ")
                            VINFound = True
                        End If
                        If VINFound = True Then
                            Reader.Close()
                            My.Computer.FileSystem.RenameFile(SearchFile, ExcelListDGV.Rows(r).Cells(0).Value.ToString.ToUpper & "_" & ExcelListDGV.Rows(r).Cells(2).Value.ToString.ToUpper & "_" & ExcelListDGV.Rows(r).Cells(1).Value.ToString.ToUpper & "(" & i & ")" & ".PDF")
                            WorkProgressBar.Value += 1
                            GoTo FOUND
                        End If
                    Next
                Next

                    '                For s = 0 To ExcelListDGV.Rows.Count - 2
                    '                    TextPDF = ""
                    '                    SearchVIN = ExcelListDGV.Rows(s).Cells(1).Value.ToString
                    '                    SearchName = ExcelListDGV.Rows(s).Cells(2).Value.ToString
                    '                    For Page = 1 To Reader.NumberOfPages
                    '                        TextPDF += PdfTextExtractor.GetTextFromPage(Reader, Page)
                    '                    Next
                    '                    VINFound = TextPDF.Contains(SearchVIN)
                    '                    If VINFound = False Then
                    '                        Dim SearchVin5 As String = ""
                    '                        For SVIN = 0 To SearchVIN.Count - 1
                    '                            SearchVin5 += SearchVIN(SVIN)
                    '                        Next
                    '                        VINFound = TextPDF.Contains(SearchVin5)
                    '                        If VINFound = False Then
                    '                            Dim SearchVIN5Top As String = ""
                    '                            For TVIN = 1 To SearchVIN.Count - 1
                    '                                SearchVIN5Top += SearchVIN(TVIN)
                    '                            Next
                    '                            VINFound = TextPDF.Contains(SearchVIN5Top)
                    '                            If VINFound = False Then
                    '                                Dim SearchVin4 As String = ""
                    '                                For VIN4 = 1 To SearchVIN.Count - 2
                    '                                    SearchVin4 += SearchVIN(VIN4)
                    '                                Next
                    '                                VINFound = TextPDF.Contains(SearchVin4)
                    '                            End If
                    '                        End If
                    '                    End If
                    '                    NameFound = TextPDF.Contains(SearchName)
                    '                    If NameFound = False Then
                    '                        NameFound = TextPDF.Contains(SearchName.ToUpper)
                    '                        If NameFound = False Then
                    '                            Dim SearchNameLess As String = ""
                    '                            For SNAME = 0 To SearchName.Count - 1
                    '                                SearchNameLess += SearchName(SNAME)
                    '                            Next
                    '                            NameFound = TextPDF.Contains(SearchNameLess)
                    '                        End If
                    '                    End If
                    '                    'If VINFound Or NameFound Then
                    '                    '    MsgBox(VINFound & " <--VIN NAME--> " & NameFound & " " & ExcelListDGV.Rows(s).Cells(2).Value.ToString)
                    '                    'End If

                    '                    If VINFound And NameFound Then
                    '                        WorkProgressBar.Value += 1
                    '                        Reader.Close()
                    '                        My.Computer.FileSystem.RenameFile(SearchFile, ExcelListDGV.Rows(s).Cells(0).Value.ToString.ToUpper & "_" & ExcelListDGV.Rows(s).Cells(1).Value.ToString.ToUpper & "_" & ExcelListDGV.Rows(s).Cells(2).Value.ToString.ToUpper & ".PDF")
                    '                        GoTo FOUND
                    '                    End If
                    '                Next
FOUND:
                Next
                STPWatch.Stop()
                PDFtable.Clear()
                MsgBox(STPWatch.ElapsedMilliseconds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If PDFtable.Rows.Count > 0 Then
                CheckList.Show()
                CheckList.CheckListDGV.DataSource = PDFtable
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub SearchCheckList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchCheckList.SelectedIndexChanged

    End Sub
End Class
