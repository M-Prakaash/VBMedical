Public Class surveyorpart1

    Private Sub Copy_of_Surveytable1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Copy_of_Surveytable1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Surveyor1editedDataSet)

    End Sub

    Private Sub surveyorpart1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Surveyor1editedDataSet.Copy_of_Surveytable1' table. You can move, or remove it, as needed.
        Me.Copy_of_Surveytable1TableAdapter.Fill(Me.Surveyor1editedDataSet.Copy_of_Surveytable1)

    End Sub

    Private Sub Road_nameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RadioButton1.Checked Then
            Place_of_SurveyTextBox1.Text = "Urban"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RadioButton2.Checked Then
            Place_of_SurveyTextBox1.Text = "Rural"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        PROTOTYPE.Show()

    End Sub

   

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Place_of_SurveyTextBox1.Text = "Urban"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Place_of_SurveyTextBox1.Text = "Rural"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.Copy_of_Surveytable1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Surveyor1editedDataSet)
        Me.Hide()
        Form1.Show()
    End Sub
End Class