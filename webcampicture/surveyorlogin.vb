Public Class surveyorlogin

    Private Sub SurveyorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SurveyorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SurveypasswordsDataSet)

    End Sub

    Private Sub surveyorlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SurveypasswordsDataSet.surveyor' table. You can move, or remove it, as needed.
        Me.SurveyorTableAdapter1.Fill(Me.SurveypasswordsDataSet.surveyor)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim login = Me.SurveyorTableAdapter1.surveyorpasswordstring(Username.Text, Password.Text)
        If login Is Nothing Then
            MsgBox("Incorrect details")
        Else
            Me.Hide()
            PROTOTYPE.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SurveyorBindingSource.AddNew()
        Me.Hide()
        surveyorcreation.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Validate()
        Me.SurveyorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SurveypasswordsDataSet)
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Validate()
        Me.SurveyorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SurveypasswordsDataSet)
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub SurveyorBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SurveyorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SurveypasswordsDataSet)

    End Sub
End Class