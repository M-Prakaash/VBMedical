Public Class database

    Private Sub Copy_of_Surveytable1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Copy_of_Surveytable1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Surveyor1editedDataSet)

    End Sub

    Private Sub database_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Surveyor1editedDataSet.Copy_of_Surveytable1' table. You can move, or remove it, as needed.
        Me.Copy_of_Surveytable1TableAdapter.Fill(Me.Surveyor1editedDataSet.Copy_of_Surveytable1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        adminpage1.Show()

    End Sub
End Class