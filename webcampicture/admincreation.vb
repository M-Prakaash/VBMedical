Public Class admincreation

    Private Sub SurveyorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub admincreation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AdminBindingNavigator.Hide()
        'TODO: This line of code loads data into the 'AdminpasswordsDataSet.admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.AdminpasswordsDataSet.admin)
        'TODO: This line of code loads data into the 'AdminpasswordsDataSet.admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.AdminpasswordsDataSet.admin)
        'TODO: This line of code loads data into the 'SurveypasswordsDataSet.surveyor' table. You can move, or remove it, as needed.



    End Sub

    Private Sub AdminBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdminpasswordsDataSet)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        AdminBindingSource.AddNew()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdminpasswordsDataSet)
        Me.Hide()
        adminlogin.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub AdminBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdminpasswordsDataSet)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AdminBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AdminBindingNavigatorSaveItem.PerformClick()
        Me.Hide()
        adminlogin.Show()

    End Sub
End Class

