Public Class Order_Process_Form
    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OrdersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pay_Junction_Database_Management_SysDataSet)

    End Sub

    Private Sub Order_Process_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pay_Junction_Database_Management_SysDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.Pay_Junction_Database_Management_SysDataSet.Orders)
        Order_CodeTextBox.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.OrdersBindingSource.AddNew()
        Order_CodeTextBox.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.OrdersBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.OrdersBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.OrdersBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.OrdersTableAdapter.Update(Me.Pay_Junction_Database_Management_SysDataSet.Orders)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class