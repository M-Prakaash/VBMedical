Public Class adminlogin

    Private Sub AdminBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdminpasswordsDataSet1)

    End Sub

    Private Sub adminlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdminpasswordsDataSet.admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter1.Fill(Me.AdminpasswordsDataSet1.admin)

    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Username.TextChanged

    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim login = Me.AdminTableAdapter1.adminpasswordstring(Username.Text, Password.Text)
        If login Is Nothing Then
            MsgBox("Incorrect details")
        Else
            Me.Hide()
            adminpage1.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub AdminBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdminpasswordsDataSet1)

    End Sub
End Class