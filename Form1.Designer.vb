<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        CustomerInfoGroupBox = New GroupBox()
        StateTextBox = New TextBox()
        CityTextBox = New TextBox()
        ZipMaskedTextBox = New MaskedTextBox()
        AddressTextBox = New TextBox()
        NameTextBox = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        SelectColorGroupBox = New GroupBox()
        GrayRadioButton = New RadioButton()
        YellowRadioButton = New RadioButton()
        GreenRadioButton = New RadioButton()
        BlueRadioButton = New RadioButton()
        Label4 = New Label()
        AutoPictureBox = New PictureBox()
        OutputTextBox = New TextBox()
        DisplayButton = New Button()
        VisibleCheckBox = New CheckBox()
        VehicleInfoTextBox = New TextBox()
        ResetButton = New Button()
        ExitButton = New Button()
        CommercialPictureBox = New PictureBox()
        TruckPictureBox = New PictureBox()
        ToolTip1 = New ToolTip(components)
        GroupBox1 = New GroupBox()
        AutoRadioButton = New RadioButton()
        TruckRadioButton = New RadioButton()
        CommercialRadioButton = New RadioButton()
        CustomerInfoGroupBox.SuspendLayout()
        SelectColorGroupBox.SuspendLayout()
        CType(AutoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(CommercialPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(TruckPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' CustomerInfoGroupBox
        ' 
        CustomerInfoGroupBox.Controls.Add(GroupBox1)
        CustomerInfoGroupBox.Controls.Add(StateTextBox)
        CustomerInfoGroupBox.Controls.Add(CityTextBox)
        CustomerInfoGroupBox.Controls.Add(ZipMaskedTextBox)
        CustomerInfoGroupBox.Controls.Add(AddressTextBox)
        CustomerInfoGroupBox.Controls.Add(NameTextBox)
        CustomerInfoGroupBox.Controls.Add(Label1)
        CustomerInfoGroupBox.Controls.Add(Label3)
        CustomerInfoGroupBox.Controls.Add(Label2)
        CustomerInfoGroupBox.ForeColor = SystemColors.HotTrack
        CustomerInfoGroupBox.Location = New Point(12, 12)
        CustomerInfoGroupBox.Name = "CustomerInfoGroupBox"
        CustomerInfoGroupBox.Size = New Size(673, 149)
        CustomerInfoGroupBox.TabIndex = 0
        CustomerInfoGroupBox.TabStop = False
        CustomerInfoGroupBox.Text = "Customer Information"
        ' 
        ' StateTextBox
        ' 
        StateTextBox.Location = New Point(302, 98)
        StateTextBox.Name = "StateTextBox"
        StateTextBox.Size = New Size(56, 23)
        StateTextBox.TabIndex = 8
        ' 
        ' CityTextBox
        ' 
        CityTextBox.Location = New Point(117, 98)
        CityTextBox.Name = "CityTextBox"
        CityTextBox.Size = New Size(179, 23)
        CityTextBox.TabIndex = 7
        ' 
        ' ZipMaskedTextBox
        ' 
        ZipMaskedTextBox.Location = New Point(364, 99)
        ZipMaskedTextBox.Mask = "00000-9999"
        ZipMaskedTextBox.Name = "ZipMaskedTextBox"
        ZipMaskedTextBox.Size = New Size(96, 23)
        ZipMaskedTextBox.TabIndex = 6
        ' 
        ' AddressTextBox
        ' 
        AddressTextBox.Location = New Point(117, 64)
        AddressTextBox.Name = "AddressTextBox"
        AddressTextBox.Size = New Size(343, 23)
        AddressTextBox.TabIndex = 5
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(117, 32)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(343, 23)
        NameTextBox.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(17, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 15)
        Label1.TabIndex = 1
        Label1.Text = "Customer Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(17, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 3
        Label3.Text = "City/State/Zip:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(17, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 2
        Label2.Text = "Address:"
        ' 
        ' SelectColorGroupBox
        ' 
        SelectColorGroupBox.Controls.Add(GrayRadioButton)
        SelectColorGroupBox.Controls.Add(YellowRadioButton)
        SelectColorGroupBox.Controls.Add(GreenRadioButton)
        SelectColorGroupBox.Controls.Add(BlueRadioButton)
        SelectColorGroupBox.ForeColor = SystemColors.HotTrack
        SelectColorGroupBox.Location = New Point(710, 12)
        SelectColorGroupBox.Name = "SelectColorGroupBox"
        SelectColorGroupBox.Size = New Size(129, 149)
        SelectColorGroupBox.TabIndex = 1
        SelectColorGroupBox.TabStop = False
        SelectColorGroupBox.Text = "Select Color"
        ' 
        ' GrayRadioButton
        ' 
        GrayRadioButton.AutoSize = True
        GrayRadioButton.Checked = True
        GrayRadioButton.ForeColor = SystemColors.ControlText
        GrayRadioButton.Location = New Point(20, 31)
        GrayRadioButton.Name = "GrayRadioButton"
        GrayRadioButton.Size = New Size(49, 19)
        GrayRadioButton.TabIndex = 3
        GrayRadioButton.TabStop = True
        GrayRadioButton.Text = "Gray"
        GrayRadioButton.UseVisualStyleBackColor = True
        ' 
        ' YellowRadioButton
        ' 
        YellowRadioButton.AutoSize = True
        YellowRadioButton.ForeColor = SystemColors.ControlText
        YellowRadioButton.Location = New Point(20, 57)
        YellowRadioButton.Name = "YellowRadioButton"
        YellowRadioButton.Size = New Size(59, 19)
        YellowRadioButton.TabIndex = 4
        YellowRadioButton.Text = "Yellow"
        YellowRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GreenRadioButton
        ' 
        GreenRadioButton.AutoSize = True
        GreenRadioButton.ForeColor = SystemColors.ControlText
        GreenRadioButton.Location = New Point(20, 82)
        GreenRadioButton.Name = "GreenRadioButton"
        GreenRadioButton.Size = New Size(56, 19)
        GreenRadioButton.TabIndex = 5
        GreenRadioButton.Text = "Green"
        GreenRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BlueRadioButton
        ' 
        BlueRadioButton.AutoSize = True
        BlueRadioButton.ForeColor = SystemColors.ControlText
        BlueRadioButton.Location = New Point(20, 107)
        BlueRadioButton.Name = "BlueRadioButton"
        BlueRadioButton.Size = New Size(48, 19)
        BlueRadioButton.TabIndex = 6
        BlueRadioButton.Text = "Blue"
        BlueRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(223, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 4
        Label4.Text = "Vehicle Info:"
        ' 
        ' AutoPictureBox
        ' 
        AutoPictureBox.Image = CType(resources.GetObject("AutoPictureBox.Image"), Image)
        AutoPictureBox.Location = New Point(14, 184)
        AutoPictureBox.Name = "AutoPictureBox"
        AutoPictureBox.Size = New Size(191, 141)
        AutoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        AutoPictureBox.TabIndex = 5
        AutoPictureBox.TabStop = False
        ' 
        ' OutputTextBox
        ' 
        OutputTextBox.Location = New Point(223, 222)
        OutputTextBox.Multiline = True
        OutputTextBox.Name = "OutputTextBox"
        OutputTextBox.ReadOnly = True
        OutputTextBox.Size = New Size(394, 103)
        OutputTextBox.TabIndex = 6
        OutputTextBox.TabStop = False
        ' 
        ' DisplayButton
        ' 
        DisplayButton.Location = New Point(643, 222)
        DisplayButton.Name = "DisplayButton"
        DisplayButton.Size = New Size(94, 40)
        DisplayButton.TabIndex = 7
        DisplayButton.Text = "Display"
        ToolTip1.SetToolTip(DisplayButton, "Display congratulations message")
        DisplayButton.UseVisualStyleBackColor = True
        ' 
        ' VisibleCheckBox
        ' 
        VisibleCheckBox.AutoSize = True
        VisibleCheckBox.Checked = True
        VisibleCheckBox.CheckState = CheckState.Checked
        VisibleCheckBox.Location = New Point(677, 189)
        VisibleCheckBox.Name = "VisibleCheckBox"
        VisibleCheckBox.Size = New Size(108, 19)
        VisibleCheckBox.TabIndex = 11
        VisibleCheckBox.Text = "Visible/Invisible"
        VisibleCheckBox.UseVisualStyleBackColor = True
        ' 
        ' VehicleInfoTextBox
        ' 
        VehicleInfoTextBox.Location = New Point(300, 189)
        VehicleInfoTextBox.Name = "VehicleInfoTextBox"
        VehicleInfoTextBox.ReadOnly = True
        VehicleInfoTextBox.Size = New Size(317, 23)
        VehicleInfoTextBox.TabIndex = 12
        VehicleInfoTextBox.TabStop = False
        ' 
        ' ResetButton
        ' 
        ResetButton.Location = New Point(748, 222)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(94, 40)
        ResetButton.TabIndex = 13
        ResetButton.Text = "Reset"
        ToolTip1.SetToolTip(ResetButton, "Reset the form")
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(695, 268)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(94, 40)
        ExitButton.TabIndex = 15
        ExitButton.Text = "Exit"
        ToolTip1.SetToolTip(ExitButton, "Exit the application")
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' CommercialPictureBox
        ' 
        CommercialPictureBox.Image = CType(resources.GetObject("CommercialPictureBox.Image"), Image)
        CommercialPictureBox.Location = New Point(14, 184)
        CommercialPictureBox.Name = "CommercialPictureBox"
        CommercialPictureBox.Size = New Size(191, 141)
        CommercialPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        CommercialPictureBox.TabIndex = 16
        CommercialPictureBox.TabStop = False
        ' 
        ' TruckPictureBox
        ' 
        TruckPictureBox.Image = CType(resources.GetObject("TruckPictureBox.Image"), Image)
        TruckPictureBox.Location = New Point(14, 184)
        TruckPictureBox.Name = "TruckPictureBox"
        TruckPictureBox.Size = New Size(191, 141)
        TruckPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        TruckPictureBox.TabIndex = 17
        TruckPictureBox.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CommercialRadioButton)
        GroupBox1.Controls.Add(TruckRadioButton)
        GroupBox1.Controls.Add(AutoRadioButton)
        GroupBox1.ForeColor = SystemColors.HotTrack
        GroupBox1.Location = New Point(484, 22)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(174, 100)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Vehicle Type"
        ' 
        ' AutoRadioButton
        ' 
        AutoRadioButton.AutoSize = True
        AutoRadioButton.ForeColor = SystemColors.ControlText
        AutoRadioButton.Location = New Point(12, 16)
        AutoRadioButton.Name = "AutoRadioButton"
        AutoRadioButton.Size = New Size(51, 19)
        AutoRadioButton.TabIndex = 0
        AutoRadioButton.TabStop = True
        AutoRadioButton.Text = "Auto"
        AutoRadioButton.UseVisualStyleBackColor = True
        ' 
        ' TruckRadioButton
        ' 
        TruckRadioButton.AutoSize = True
        TruckRadioButton.ForeColor = SystemColors.ControlText
        TruckRadioButton.Location = New Point(12, 41)
        TruckRadioButton.Name = "TruckRadioButton"
        TruckRadioButton.Size = New Size(53, 19)
        TruckRadioButton.TabIndex = 1
        TruckRadioButton.TabStop = True
        TruckRadioButton.Text = "Truck"
        TruckRadioButton.UseVisualStyleBackColor = True
        ' 
        ' CommercialRadioButton
        ' 
        CommercialRadioButton.AutoSize = True
        CommercialRadioButton.ForeColor = SystemColors.ControlText
        CommercialRadioButton.Location = New Point(12, 66)
        CommercialRadioButton.Name = "CommercialRadioButton"
        CommercialRadioButton.Size = New Size(90, 19)
        CommercialRadioButton.TabIndex = 2
        CommercialRadioButton.TabStop = True
        CommercialRadioButton.Text = "Commercial"
        CommercialRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AcceptButton = DisplayButton
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = ExitButton
        ClientSize = New Size(854, 346)
        Controls.Add(TruckPictureBox)
        Controls.Add(CommercialPictureBox)
        Controls.Add(ExitButton)
        Controls.Add(ResetButton)
        Controls.Add(VehicleInfoTextBox)
        Controls.Add(VisibleCheckBox)
        Controls.Add(DisplayButton)
        Controls.Add(OutputTextBox)
        Controls.Add(SelectColorGroupBox)
        Controls.Add(AutoPictureBox)
        Controls.Add(Label4)
        Controls.Add(CustomerInfoGroupBox)
        Name = "Form1"
        Text = "Joker's Repair Parts"
        CustomerInfoGroupBox.ResumeLayout(False)
        CustomerInfoGroupBox.PerformLayout()
        SelectColorGroupBox.ResumeLayout(False)
        SelectColorGroupBox.PerformLayout()
        CType(AutoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(CommercialPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(TruckPictureBox, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CustomerInfoGroupBox As GroupBox
    Friend WithEvents SelectColorGroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AutoPictureBox As PictureBox
    Friend WithEvents ZipMaskedTextBox As MaskedTextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents GrayRadioButton As RadioButton
    Friend WithEvents YellowRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents DisplayButton As Button
    Friend WithEvents VisibleCheckBox As CheckBox
    Friend WithEvents VehicleInfoTextBox As TextBox
    Friend WithEvents ResetButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents CommercialPictureBox As PictureBox
    Friend WithEvents TruckPictureBox As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CommercialRadioButton As RadioButton
    Friend WithEvents TruckRadioButton As RadioButton
    Friend WithEvents AutoRadioButton As RadioButton
End Class
