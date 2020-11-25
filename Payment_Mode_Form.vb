Public Class Payment_Mode_Form
    Private Sub Payment_ModesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Payment_ModesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Payment_ModesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pay_Junction_Database_Management_SysDataSet)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pay_Junction_Database_Management_SysDataSet.Payment_Modes' table. You can move, or remove it, as needed.
        Me.Payment_ModesTableAdapter.Fill(Me.Pay_Junction_Database_Management_SysDataSet.Payment_Modes)
        Payment_Mode_IDTextBox.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Payment_ModesBindingSource.AddNew()
        Payment_Mode_IDTextBox.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Payment_ModesBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Payment_ModesBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Payment_ModesBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Payment_ModesBindingSource.EndEdit()
        Me.Payment_ModesTableAdapter.Update(Me.Pay_Junction_Database_Management_SysDataSet.Payment_Modes)
    End Sub
End Class