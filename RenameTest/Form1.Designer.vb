<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ExcelListDGV = New System.Windows.Forms.DataGridView()
        Me.ImportListButton = New System.Windows.Forms.Button()
        Me.LocateFileButton = New System.Windows.Forms.Button()
        Me.DirectoryTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.DialogF = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenDialogF = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SearchCheckList = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FileCountLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.WorkProgressBar = New System.Windows.Forms.ProgressBar()
        CType(Me.ExcelListDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExcelListDGV
        '
        Me.ExcelListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ExcelListDGV.Location = New System.Drawing.Point(12, 12)
        Me.ExcelListDGV.Name = "ExcelListDGV"
        Me.ExcelListDGV.Size = New System.Drawing.Size(312, 392)
        Me.ExcelListDGV.TabIndex = 0
        '
        'ImportListButton
        '
        Me.ImportListButton.Location = New System.Drawing.Point(491, 29)
        Me.ImportListButton.Name = "ImportListButton"
        Me.ImportListButton.Size = New System.Drawing.Size(75, 23)
        Me.ImportListButton.TabIndex = 1
        Me.ImportListButton.Text = "Naming List"
        Me.ImportListButton.UseVisualStyleBackColor = True
        '
        'LocateFileButton
        '
        Me.LocateFileButton.Location = New System.Drawing.Point(491, 71)
        Me.LocateFileButton.Name = "LocateFileButton"
        Me.LocateFileButton.Size = New System.Drawing.Size(75, 23)
        Me.LocateFileButton.TabIndex = 2
        Me.LocateFileButton.Text = "Locate Files"
        Me.LocateFileButton.UseVisualStyleBackColor = True
        '
        'DirectoryTextbox
        '
        Me.DirectoryTextbox.Location = New System.Drawing.Point(402, 100)
        Me.DirectoryTextbox.Name = "DirectoryTextbox"
        Me.DirectoryTextbox.ReadOnly = True
        Me.DirectoryTextbox.Size = New System.Drawing.Size(206, 20)
        Me.DirectoryTextbox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(347, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Directory"
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(491, 267)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(75, 23)
        Me.GoButton.TabIndex = 5
        Me.GoButton.Text = "GO"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'OpenDialogF
        '
        Me.OpenDialogF.Filter = "Excel Documents (*.XLSX)|*.XLSX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(330, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Import your Excel file with the naming convention you desire."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Choose what directory the files are in."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(502, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Rename!"
        '
        'SearchCheckList
        '
        Me.SearchCheckList.CheckOnClick = True
        Me.SearchCheckList.FormattingEnabled = True
        Me.SearchCheckList.Location = New System.Drawing.Point(464, 139)
        Me.SearchCheckList.Name = "SearchCheckList"
        Me.SearchCheckList.Size = New System.Drawing.Size(120, 94)
        Me.SearchCheckList.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(470, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "What am I looking for?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(470, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Files to change:"
        '
        'FileCountLabel
        '
        Me.FileCountLabel.AutoSize = True
        Me.FileCountLabel.Location = New System.Drawing.Point(558, 300)
        Me.FileCountLabel.Name = "FileCountLabel"
        Me.FileCountLabel.Size = New System.Drawing.Size(13, 13)
        Me.FileCountLabel.TabIndex = 14
        Me.FileCountLabel.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(333, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Check List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(368, 320)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(250, 23)
        Me.ProgressBar1.TabIndex = 16
        '
        'WorkProgressBar
        '
        Me.WorkProgressBar.Location = New System.Drawing.Point(368, 347)
        Me.WorkProgressBar.Name = "WorkProgressBar"
        Me.WorkProgressBar.Size = New System.Drawing.Size(250, 23)
        Me.WorkProgressBar.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 411)
        Me.Controls.Add(Me.WorkProgressBar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FileCountLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SearchCheckList)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DirectoryTextbox)
        Me.Controls.Add(Me.LocateFileButton)
        Me.Controls.Add(Me.ImportListButton)
        Me.Controls.Add(Me.ExcelListDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Renamer V 1.0"
        CType(Me.ExcelListDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExcelListDGV As System.Windows.Forms.DataGridView
    Friend WithEvents ImportListButton As System.Windows.Forms.Button
    Friend WithEvents LocateFileButton As System.Windows.Forms.Button
    Friend WithEvents DirectoryTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GoButton As System.Windows.Forms.Button
    Friend WithEvents DialogF As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenDialogF As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SearchCheckList As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FileCountLabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents WorkProgressBar As System.Windows.Forms.ProgressBar

End Class
