Public Class Switch_Board


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Order_Detail_Form As Order_Detail_Form = New Order_Detail_Form
        Order_Detail_Form.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Product_Form As Product_Form = New Product_Form
        Product_Form.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Customer_Form As Customer_Form = New Customer_Form
        Customer_Form.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Employee_Form As Employee_Form = New Employee_Form
        Employee_Form.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Shipment_Method_Form As Shipment_Method_Form = New Shipment_Method_Form
        Shipment_Method_Form.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Payment_Form As Payment_Form = New Payment_Form
        Payment_Form.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim Payment_Mode_Form As Payment_Mode_Form = New Payment_Mode_Form
        Payment_Mode_Form.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        cExit.ExitSystem()
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Loginin_SystemDataSet.Loginin' table. You can move, or remove it, as needed.
        Me.LogininTableAdapter.Fill(Me.Loginin_SystemDataSet.Loginin)
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False

        Password.PasswordChar = "*"
    End Sub

    Private Sub LogininBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LogininBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LogininBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Loginin_SystemDataSet)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Log = Me.LogininTableAdapter.Userdetails(Me.User_Name.Text, Me.Password.Text)
        If Log Is Nothing Then
            User_Name.Clear()
            Password.Clear()
            MessageBox.Show("Invalidate Data Entered, Try Again", "Login Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            User_Name.Focus()
        Else
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True
            Button10.Enabled = True
            Button11.Enabled = True
            User_Name.Clear()
            Password.Clear()

            Label2.Visible = False
            Label3.Visible = False
            User_Name.Visible = False
            Password.Visible = False


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        User_Name.Clear()
        Password.Clear()
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Order_Process_Form As Order_Process_Form = New Order_Process_Form
        Order_Process_Form.Show()
    End Sub
End Class