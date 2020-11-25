Public Class Customer_Form
    Private Sub Customers_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Customers_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Customers_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pay_Junction_Database_Management_SysDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pay_Junction_Database_Management_SysDataSet.Customers_Details' table. You can move, or remove it, as needed.
        Me.Customers_DetailsTableAdapter.Fill(Me.Pay_Junction_Database_Management_SysDataSet.Customers_Details)
        Cust_CodeTextBox.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Customers_DetailsBindingSource.AddNew()
        Cust_CodeTextBox.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Customers_DetailsBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Customers_DetailsBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Customers_DetailsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Customers_DetailsBindingSource.EndEdit()
        Me.Customers_DetailsTableAdapter.Update(Me.Pay_Junction_Database_Management_SysDataSet.Customers_Details)
    End Sub

    Private Sub Cust_CodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles Cust_CodeTextBox.TextChanged

    End Sub
End Class