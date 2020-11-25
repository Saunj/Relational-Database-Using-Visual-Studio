Public Class Employee_Form
    Private Sub EmployeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pay_Junction_Database_Management_SysDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pay_Junction_Database_Management_SysDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.Pay_Junction_Database_Management_SysDataSet.Employees)
        Emp_CodeTextBox.Enabled = False
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.EmployeesBindingSource.AddNew()
        Emp_CodeTextBox.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.EmployeesBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.EmployeesBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.EmployeesBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.EmployeesTableAdapter.Update(Me.Pay_Junction_Database_Management_SysDataSet.Employees)
    End Sub
End Class