Public Class Payment_Form
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub PaymentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PaymentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaymentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pay_Junction_Database_Management_SysDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pay_Junction_Database_Management_SysDataSet.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.Pay_Junction_Database_Management_SysDataSet.Payments)
        Payment_CodeTextBox.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.PaymentsBindingSource.AddNew()
        Payment_CodeTextBox.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.PaymentsBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.PaymentsBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.PaymentsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.PaymentsBindingSource.EndEdit()
        Me.PaymentsTableAdapter.Update(Me.Pay_Junction_Database_Management_SysDataSet.Payments)
    End Sub
End Class