Public Class Form1

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub GrayRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GrayRadioButton.CheckedChanged
        Me.BackColor = Color.Gray
    End Sub

    Private Sub YellowRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles YellowRadioButton.CheckedChanged
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        Me.BackColor = Color.Green

    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        Me.BackColor = Color.Blue

    End Sub

    Private Sub AutoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AutoRadioButton.CheckedChanged
        AutoPictureBox.Visible = True
        TruckPictureBox.Visible = False
        CommercialPictureBox.Visible = False
        VehicleInfoTextBox.Text = "Automatic Benz"


    End Sub

    Private Sub TruckRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TruckRadioButton.CheckedChanged
        AutoPictureBox.Visible = False
        TruckPictureBox.Visible = True
        CommercialPictureBox.Visible = False
        VehicleInfoTextBox.Text = "GMC Truck"

    End Sub

    Private Sub CommercialRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CommercialRadioButton.CheckedChanged
        AutoPictureBox.Visible = False
        TruckPictureBox.Visible = False
        CommercialPictureBox.Visible = True
        VehicleInfoTextBox.Text = "Commercial Truck"
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        OutputTextBox.Text = "Congratulations " & NameTextBox.Text & " !" & ControlChars.NewLine &
            " Discount repair parts for your selected " & VehicleInfoTextBox.Text & ControlChars.NewLine &
            " are available by contacting us on 800-555-1925 "


    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles VisibleCheckBox.CheckedChanged
        OutputTextBox.Visible = VisibleCheckBox.Checked
        VehicleInfoTextBox.Visible = VisibleCheckBox.Checked
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        NameTextBox.Clear()
        AddressTextBox.Clear()
        CityTextBox.Clear()
        StateTextBox.Clear()
        ZipMaskedTextBox.Clear()
        VehicleInfoTextBox.Clear()
        OutputTextBox.Clear()
        GrayRadioButton.Checked = True
        AutoRadioButton.Checked = True
        AutoPictureBox.Visible = True
        TruckPictureBox.Visible = False
        CommercialPictureBox.Visible = False
        VehicleInfoTextBox.Text = "Automatic Benz"
        VisibleCheckBox.Checked = True
        NameTextBox.Focus()



    End Sub
End Class
