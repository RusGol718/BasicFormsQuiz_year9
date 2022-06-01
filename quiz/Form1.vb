Public Class Form1

    Structure question
        Dim text As String
        Dim answerA, answerB, answerC As String
        Dim correctoption As String
        Sub New(ByVal t As String, ByVal ans() As String, ByVal c As String)
            text = t            
            answerA = ans(0)
            answerB = ans(1)
            answerC = ans(2)
            correctoption = c
        End Sub
    End Structure

    Dim quiz As New List(Of question)
    Dim qn As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qn = 0
        quiz.Add(New question("Capital of England?", {"London", "Paris", "Cardiff"}, "A"))
        quiz.Add(New question("Capital of France?", {"Dublin", "Madrid", "Paris"}, "C"))
        quiz.Add(New question("Capital of Germany?", {"Milan", "Berlin", "Naples"}, "B"))
        LoadQuestion()
    End Sub

    Private Sub LoadQuestion()
        lblQuestionNumber.Text = qn + 1 & "."
        lblQuestionText.Text = quiz(qn).text
        cmdOptionA.Text = quiz(qn).answerA
        cmdOptionB.Text = quiz(qn).answerB
        cmdOptionC.Text = quiz(qn).answerC
    End Sub

    Private Sub OptionA_Click(sender As Object, e As EventArgs) Handles cmdOptionA.Click
        If quiz(qn).correctoption = "A" Then
            MsgBox("Correct!")
        Else
            MsgBox("No")
        End If
        qn += 1
        LoadQuestion()
    End Sub

    Private Sub cmdOptionB_Click(sender As Object, e As EventArgs) Handles cmdOptionB.Click
        If quiz(qn).correctoption = "B" Then
            MsgBox("Correct!")
        Else
            MsgBox("No")
        End If
        qn += 1
        LoadQuestion()
    End Sub

    Private Sub cmdOptionC_Click(sender As Object, e As EventArgs) Handles cmdOptionC.Click
        If quiz(qn).correctoption = "C" Then
            MsgBox("Correct!")
        Else
            MsgBox("No")
        End If
        qn += 1
        LoadQuestion()
    End Sub
End Class
