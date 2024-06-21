Public Class Form1
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize form components
    End Sub
    Private Sub View_Submission(sender As Object, e As EventArgs) Handles viewBtn.Click
        Dim viewForm As New ViewSubmissionForm()
        viewForm.Show()
    End Sub

    Private Sub New_Submission(sender As Object, e As EventArgs) Handles createBtn.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

Public Class ViewSubmissionForm
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmission(currentIndex)
    End Sub

    Private Sub LoadSubmission(index As Integer)
        ' Call backend API to get submission by index
        ' Populate the text fields with the submission data
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub
End Class

