'Seth Rasmussen
'RCET 0265
'Spring 2022
'Address Label Program
'https://github.com/SethRas/AddressLabel.git


Public Class AddressLabelForm
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        DisplayLabel.Text = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}
            {StreetAddressTextBox.Text}
            {CityTextBox.Text}, {StateTextBox.Text} {ZipTextBox.Text}"

    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class
