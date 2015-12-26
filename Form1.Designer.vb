<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.firstChemComp = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.secondChemComp = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Weight_Of_Beaker_lbl = New System.Windows.Forms.Label()
        Me.Weight_Of_BEAKER_WITH_FIL = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Weight_Of_Beaker_txtbox = New System.Windows.Forms.TextBox()
        Me.Weight_of_BeakerwithFil_txtbox = New System.Windows.Forms.TextBox()
        Me.Actual_Mass_txtbox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Starting_mass_txtbox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Theoretical_mass_txtbox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PercentYield_txtbox = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Product_lbl = New System.Windows.Forms.Label()
        Me.CalculateItems_button = New System.Windows.Forms.Button()
        Me.Reset_button = New System.Windows.Forms.Button()
        Me.Clear_button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Starting_mass2_txtbox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'firstChemComp
        '
        Me.firstChemComp.FormattingEnabled = True
        Me.firstChemComp.ItemHeight = 16
        Me.firstChemComp.Items.AddRange(New Object() {"Hydrogen", "Boron", "Sodium", "Nitrogen", "Potassium"})
        Me.firstChemComp.Location = New System.Drawing.Point(25, 44)
        Me.firstChemComp.Margin = New System.Windows.Forms.Padding(4)
        Me.firstChemComp.Name = "firstChemComp"
        Me.firstChemComp.Size = New System.Drawing.Size(197, 84)
        Me.firstChemComp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "+"
        '
        'secondChemComp
        '
        Me.secondChemComp.FormattingEnabled = True
        Me.secondChemComp.ItemHeight = 16
        Me.secondChemComp.Items.AddRange(New Object() {"Carbon", "Oxygen", "Magnesium", "Neon", "Iodine"})
        Me.secondChemComp.Location = New System.Drawing.Point(315, 46)
        Me.secondChemComp.Margin = New System.Windows.Forms.Padding(4)
        Me.secondChemComp.Name = "secondChemComp"
        Me.secondChemComp.Size = New System.Drawing.Size(193, 84)
        Me.secondChemComp.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(523, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "-->"
        '
        'Weight_Of_Beaker_lbl
        '
        Me.Weight_Of_Beaker_lbl.AutoSize = True
        Me.Weight_Of_Beaker_lbl.Location = New System.Drawing.Point(43, 201)
        Me.Weight_Of_Beaker_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Weight_Of_Beaker_lbl.Name = "Weight_Of_Beaker_lbl"
        Me.Weight_Of_Beaker_lbl.Size = New System.Drawing.Size(120, 17)
        Me.Weight_Of_Beaker_lbl.TabIndex = 5
        Me.Weight_Of_Beaker_lbl.Text = "Weight of beaker:"
        '
        'Weight_Of_BEAKER_WITH_FIL
        '
        Me.Weight_Of_BEAKER_WITH_FIL.AutoSize = True
        Me.Weight_Of_BEAKER_WITH_FIL.Location = New System.Drawing.Point(43, 237)
        Me.Weight_Of_BEAKER_WITH_FIL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Weight_Of_BEAKER_WITH_FIL.Name = "Weight_Of_BEAKER_WITH_FIL"
        Me.Weight_Of_BEAKER_WITH_FIL.Size = New System.Drawing.Size(200, 17)
        Me.Weight_Of_BEAKER_WITH_FIL.TabIndex = 6
        Me.Weight_Of_BEAKER_WITH_FIL.Text = "Weight of beaker with product:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 416)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Actual Mass:"
        '
        'Weight_Of_Beaker_txtbox
        '
        Me.Weight_Of_Beaker_txtbox.Location = New System.Drawing.Point(172, 197)
        Me.Weight_Of_Beaker_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Weight_Of_Beaker_txtbox.Name = "Weight_Of_Beaker_txtbox"
        Me.Weight_Of_Beaker_txtbox.Size = New System.Drawing.Size(132, 22)
        Me.Weight_Of_Beaker_txtbox.TabIndex = 8
        '
        'Weight_of_BeakerwithFil_txtbox
        '
        Me.Weight_of_BeakerwithFil_txtbox.Location = New System.Drawing.Point(244, 237)
        Me.Weight_of_BeakerwithFil_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Weight_of_BeakerwithFil_txtbox.Name = "Weight_of_BeakerwithFil_txtbox"
        Me.Weight_of_BeakerwithFil_txtbox.Size = New System.Drawing.Size(132, 22)
        Me.Weight_of_BeakerwithFil_txtbox.TabIndex = 9
        '
        'Actual_Mass_txtbox
        '
        Me.Actual_Mass_txtbox.Location = New System.Drawing.Point(159, 411)
        Me.Actual_Mass_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Actual_Mass_txtbox.Name = "Actual_Mass_txtbox"
        Me.Actual_Mass_txtbox.Size = New System.Drawing.Size(132, 22)
        Me.Actual_Mass_txtbox.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 281)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(182, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Starting mass of reactant 1:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(313, 201)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "grams"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(418, 286)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 17)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "grams"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(385, 240)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "grams"
        '
        'Starting_mass_txtbox
        '
        Me.Starting_mass_txtbox.Location = New System.Drawing.Point(268, 281)
        Me.Starting_mass_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Starting_mass_txtbox.Name = "Starting_mass_txtbox"
        Me.Starting_mass_txtbox.Size = New System.Drawing.Size(132, 22)
        Me.Starting_mass_txtbox.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(303, 411)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 17)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "grams"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 475)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 17)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Percent Yield ="
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(30, 442)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 17)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Theoretical Mass:"
        '
        'Theoretical_mass_txtbox
        '
        Me.Theoretical_mass_txtbox.Location = New System.Drawing.Point(159, 438)
        Me.Theoretical_mass_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Theoretical_mass_txtbox.Name = "Theoretical_mass_txtbox"
        Me.Theoretical_mass_txtbox.Size = New System.Drawing.Size(132, 22)
        Me.Theoretical_mass_txtbox.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(303, 447)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 17)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "grams"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(140, 475)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(260, 17)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "(Actual Yield / Theoretical Yield) x 100%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PercentYield_txtbox
        '
        Me.PercentYield_txtbox.Location = New System.Drawing.Point(421, 475)
        Me.PercentYield_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.PercentYield_txtbox.Name = "PercentYield_txtbox"
        Me.PercentYield_txtbox.Size = New System.Drawing.Size(132, 22)
        Me.PercentYield_txtbox.TabIndex = 25
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(561, 475)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 17)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "%"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(397, 475)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 17)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "="
        '
        'Product_lbl
        '
        Me.Product_lbl.AutoSize = True
        Me.Product_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_lbl.Location = New System.Drawing.Point(562, 72)
        Me.Product_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Product_lbl.Name = "Product_lbl"
        Me.Product_lbl.Size = New System.Drawing.Size(350, 29)
        Me.Product_lbl.TabIndex = 4
        Me.Product_lbl.Text = "Product(Chemical Compounds)"
        '
        'CalculateItems_button
        '
        Me.CalculateItems_button.Location = New System.Drawing.Point(67, 552)
        Me.CalculateItems_button.Name = "CalculateItems_button"
        Me.CalculateItems_button.Size = New System.Drawing.Size(125, 23)
        Me.CalculateItems_button.TabIndex = 28
        Me.CalculateItems_button.Text = "Calculate"
        Me.CalculateItems_button.UseVisualStyleBackColor = True
        '
        'Reset_button
        '
        Me.Reset_button.Location = New System.Drawing.Point(269, 552)
        Me.Reset_button.Name = "Reset_button"
        Me.Reset_button.Size = New System.Drawing.Size(75, 23)
        Me.Reset_button.TabIndex = 29
        Me.Reset_button.Text = "Reset"
        Me.Reset_button.UseVisualStyleBackColor = True
        '
        'Clear_button
        '
        Me.Clear_button.Location = New System.Drawing.Point(433, 552)
        Me.Clear_button.Name = "Clear_button"
        Me.Clear_button.Size = New System.Drawing.Size(75, 23)
        Me.Clear_button.TabIndex = 30
        Me.Clear_button.Text = "Exit"
        Me.Clear_button.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 369)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(938, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "---------------------------------------------------------------------------------" & _
    "--------------------------------------------------------------------------------" & _
    "-------------------------"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 386)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Output"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(183, 157)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Input"
        '
        'Starting_mass2_txtbox
        '
        Me.Starting_mass2_txtbox.Location = New System.Drawing.Point(269, 317)
        Me.Starting_mass2_txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Starting_mass2_txtbox.Name = "Starting_mass2_txtbox"
        Me.Starting_mass2_txtbox.Size = New System.Drawing.Size(132, 22)
        Me.Starting_mass2_txtbox.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(419, 322)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "grams"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(43, 317)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(182, 17)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Starting mass of reactant 2:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(20, 9)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(247, 29)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "Reactant 1 (+ Charge)"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(301, 13)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(241, 29)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Reactant 2 (- Charge)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 626)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Starting_mass2_txtbox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Clear_button)
        Me.Controls.Add(Me.Reset_button)
        Me.Controls.Add(Me.CalculateItems_button)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.PercentYield_txtbox)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Theoretical_mass_txtbox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Starting_mass_txtbox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Actual_Mass_txtbox)
        Me.Controls.Add(Me.Weight_of_BeakerwithFil_txtbox)
        Me.Controls.Add(Me.Weight_Of_Beaker_txtbox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Weight_Of_BEAKER_WITH_FIL)
        Me.Controls.Add(Me.Weight_Of_Beaker_lbl)
        Me.Controls.Add(Me.Product_lbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.secondChemComp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.firstChemComp)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Percent Yield Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents firstChemComp As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents secondChemComp As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Weight_Of_Beaker_lbl As System.Windows.Forms.Label
    Friend WithEvents Weight_Of_BEAKER_WITH_FIL As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Weight_Of_Beaker_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Weight_of_BeakerwithFil_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Actual_Mass_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Starting_mass_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Theoretical_mass_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PercentYield_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Product_lbl As System.Windows.Forms.Label
    Friend WithEvents CalculateItems_button As System.Windows.Forms.Button
    Friend WithEvents Reset_button As System.Windows.Forms.Button
    Friend WithEvents Clear_button As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Starting_mass2_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label

End Class
