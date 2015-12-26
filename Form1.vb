'Name: Karina Torres, Ngoc Nguyen'
' things to figure out 
'1.) how to select two items from the listbox 1 and listbox 2
'2.) 100 grams in inputs for the weight of the beaker.
'3.) converting given volume 

Public Class Form1

    ' Reset all the items in the form...
    Private Sub Reset_button_Click(sender As Object, e As EventArgs) Handles Reset_button.Click
        ' clearing all the text boxes before user can enter some data if the user clicked the reset button
        Weight_Of_Beaker_txtbox.Clear()
        'clear the beaker with fill textbox
        Weight_of_BeakerwithFil_txtbox.Clear()
        ' clear the actual mass textbox
        Actual_Mass_txtbox.Clear()
        ' clear the starting mass rectant 1 text box 
        Starting_mass_txtbox.Clear()
        ' clear the starting mass reactant 2 text box 
        Starting_mass2_txtbox.Clear()
        ' clear the theorectical textbox
        Theoretical_mass_txtbox.Clear()
        ' clear the precent yield textbox
        PercentYield_txtbox.Clear()
        ' reset the label when the user click reset
        Product_lbl.Text = "Product(Chemical Compounds)"
        'set the focus to the weight of the beaker textbox 
        Weight_Of_Beaker_txtbox.Focus()
        ' clear the list box of the first chem compound
        firstChemComp.ClearSelected()
        ' clear the listbox of the second chem compount
        secondChemComp.ClearSelected()


    End Sub

    Private Sub Clear_button_Click(sender As Object, e As EventArgs) Handles Clear_button.Click
        'simply close the form...'
        Me.Close()
    End Sub

    Private Sub CalculateItems_button_Click(sender As Object, e As EventArgs) Handles CalculateItems_button.Click
        ' declare all the varibles as needed for the calculations...'

        ' the weight of the beaker
        Dim weightOfBeakervar As Double
        ' the weight of the beaker of the product 
        Dim weightOfBeaker_WithFilvar As Double
        ' the actual mass
        Dim actualMassvar As Double
        ' the starting mass reactant 
        Dim startingMassvar As Double
        ' the starting mass reactant 2
        Dim startingMassvarRec_two As Double
        ' the theroical mass 
        Dim theroricalMassvar As Double
        ' the percentyield
        Dim percentYieldvar As Double
        ' the mole 
        Dim mole As Double
        ' to compute the vaules either we compute or dont compute 
        Dim compute As Boolean

        ' not sure if we need this -> Dim product As Double

        ' we declare element 1 and element 2 so we can compare values in the list boxes provided
        Dim element1 As Integer
        Dim element2 As Integer

        'show a message if we want to write it to a file
        Dim filemsg = "Do you want to write the results to a file?"
        Dim inputFile As System.IO.StreamWriter
        ' Display the message box and save the response, Yes or No. 
        ''Using writer As New System.IO.StreamWriter("", True)

        ''End Using
        Dim response

        Dim element_Mass = New Double() {1.01, 10.81, 22.99, 14.01, 39.1, 12.01, 16.0, 24.31, 20.18, 126.9}
        ' starting mass of rec 1 / element_mass 
        element1 = firstChemComp.SelectedIndex
        element2 = secondChemComp.SelectedIndex
        mole = 1.0
        compute = False

        'this will compute the reactant 1(+charge) and reactant 2(-charge) knowing the reactants are a 1:1 ratio... 
        If element1 = 0 Then
            Select Case element2
                Case 0
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 1
                    Product_lbl.Text = "H20"
                    compute = True
                Case 2
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 3
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 4
                    Product_lbl.Text = "HI"
                    compute = True
                Case Else

            End Select
        ElseIf element1 = 1 Then

            Select Case element2

                Case 0
                    MessageBox.Show("ERROR Cant Compute this  reactant...")
                Case 1
                    Product_lbl.Text = "BO3"
                    compute = True
                Case 2
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 3
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 4
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case Else

            End Select
        ElseIf element1 = 2 Then
            Select Case element2
                Case 0
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 1
                    Product_lbl.Text = "Na2O"
                    compute = True
                Case 2
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 3
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 4
                    Product_lbl.Text = "Nal"
                    compute = True
                Case Else

            End Select
        ElseIf element1 = 3 Then
            Select Case element2
                Case 0
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 1
                    Product_lbl.Text = "NO2"
                    compute = True
                Case 2
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 3
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 4
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case Else

            End Select

        ElseIf element1 = 4 Then
            Select Case element2
                Case 0
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 1
                    Product_lbl.Text = "K2O"
                    compute = True
                Case 2
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 3
                    MessageBox.Show("ERROR Cant Compute this reactant...")
                Case 4
                    Product_lbl.Text = "KI"
                    compute = True
                Case Else

            End Select
        End If

        If (Not compute) Then
            Return
        End If

        While Not compute
            Return
        End While
        '' input varibles with there respective textboxes for input
        weightOfBeakervar = Weight_Of_Beaker_txtbox.Text()
        weightOfBeaker_WithFilvar = Weight_of_BeakerwithFil_txtbox.Text()
        startingMassvar = Starting_mass_txtbox.Text()
        startingMassvarRec_two = Starting_mass2_txtbox.Text()
        ' using if statements to check if each varible is less than 0 if so display a error message 
        If weightOfBeakervar < 0 Then
            MessageBox.Show("invalid input please enter a postive number...")
            Weight_Of_Beaker_txtbox.Clear()
            Weight_Of_Beaker_txtbox.Focus()
            Return
        End If

        If weightOfBeaker_WithFilvar < 0 Then
            MessageBox.Show("invalid input please enter a postive number...")
            Weight_of_BeakerwithFil_txtbox.Clear()
            Return
        End If

        If startingMassvar < 0 Then
            MessageBox.Show("invalid input please enter a postive number...")
            Starting_mass_txtbox.Clear()
            Return
        End If

        If startingMassvarRec_two < 0 Then
            MessageBox.Show("invalid input please enter a postive number...")
            Starting_mass2_txtbox.Clear()
            Return
        End If

        '---- where the calulcations will go 



        ' convert all the input text boxes to a double 
        startingMassvar = CDbl(Starting_mass_txtbox.Text())
        startingMassvarRec_two = CDbl(Starting_mass2_txtbox.Text())
        weightOfBeakervar = CDbl(Weight_Of_Beaker_txtbox.Text())
        weightOfBeaker_WithFilvar = CDbl(Weight_of_BeakerwithFil_txtbox.Text())

        ' have the actual mass textbox calcualted from the weightofbeaker with product - weightofbeaker
        actualMassvar = weightOfBeaker_WithFilvar - weightOfBeakervar


        ' check if the actual mass is a negitve number if so display a error code if not go on
        If actualMassvar < 0 Then
            MessageBox.Show("Weight of beaker must be less than weight of beaker with product")
            Actual_Mass_txtbox.Clear()

        Else
            ' else assign the testbox a postive number 
            Actual_Mass_txtbox.Text() = actualMassvar
        End If

        ' we check the index of the first chem comp listbox and second chem compound listbox its -1 means its not in the listbox
        If firstChemComp.SelectedIndex = -1 Or secondChemComp.SelectedIndex = -1 Then
            Return
        End If


        ' we calculate the limiting reagent  for the first chemical compound in the first list box
        startingMassvar = element_Mass(firstChemComp.SelectedIndex) / startingMassvar
        ' calculating the limiting reagent for the second chemical compound 
        startingMassvarRec_two = element_Mass(5 + secondChemComp.SelectedIndex) / startingMassvar


        ' to calculate the limiting reagent we take the less of the starting mass reac 1 and the starting mass reac 2 
        If startingMassvar > startingMassvarRec_two Then
            ' if starting mass 2 is less than we assign that the theroical mass
            theroricalMassvar = startingMassvarRec_two
        Else
            ' else assign the first starting mass the theroical since its smaller 
            theroricalMassvar = startingMassvar
        End If

        ' the theoretical mass being calcualted 
        Theoretical_mass_txtbox.Text = theroricalMassvar

        ' now the percent yield is being calculated
        percentYieldvar = (actualMassvar / theroricalMassvar) * 100
        ' now we assign the results to the precent yield textbox which comes from the actual mass and the thero mass * 100
        PercentYield_txtbox.Text = CDbl(percentYieldvar)

       
        ' Now define a style for the message box. In this example, the 
        ' message box will have Yes and No buttons, the default will be 
        ' the No button, and a Critical Message icon will be present. 
        Dim style = MsgBoxStyle.YesNo Or _
                   MsgBoxStyle.Information

        response = MsgBox(filemsg, style, "File Save Menu")


        'if yes is selected then 
        If response = MsgBoxResult.Yes Then
            ' try to write contents to a file'
            ' make a streamwriter varible so we can write results to the file  please replace this with your file path dr harris so you can see the results as well
            inputFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\JoeyCPuno\Desktop\Basic Chemistry 1 - Percent Yield Application\test.txt", True)
            inputFile.Write("Input(Data)" & vbCrLf)
            inputFile.Write("-------------------------------------" & vbCrLf)
            inputFile.Write("Weight of the beaker: " & weightOfBeakervar & vbCrLf)
            inputFile.Write("Weight of the beaker with product: " & weightOfBeaker_WithFilvar & vbCrLf)
            inputFile.Write("Starting mass of reactant 1: " & startingMassvar & vbCrLf)
            inputFile.Write("Starting mass of reactant 2: " & startingMassvarRec_two & vbCrLf)
            inputFile.Write("output (Data)" & vbCrLf)
            inputFile.Write("-------------------------------------" & vbCrLf)
            inputFile.Write("Actual Mass: " & actualMassvar & vbCrLf)
            inputFile.Write("Theoretical Mass: " & theroricalMassvar & vbCrLf)
            inputFile.Write("Percent Yield: " & percentYieldvar & vbCrLf)

            ' close the file contents when were done writing to the file...
            inputFile.Close()
        End If
        If response = MsgBoxResult.No Then
            ' if no is chosen then we just simply dont do anything...
            MessageBox.Show("Data is not saved to a file...")
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' show the form
        Me.Show()
        'give the weight of beaker textbox focus 
        Weight_Of_Beaker_txtbox.Focus()

        ' Define the message you want to see inside the message box. 
        Dim msg = "This application is designed only for chemistry students to calculate the percent yield of a 1:1 mole reaction in chemistry 1 lecture and lab"
        Dim msg2 = "Do you want to proceed with the application and do some chemistry select yes or no"
        ' Display the simple message box.
        MsgBox(msg)

        ' Define a title for the message box. 
        Dim title = "Basic Chemistry Percent Yield Application"

        ' Now define a style for the message box. In this example, the 
        ' message box will have Yes and No buttons, the default will be 
        ' the No button, and a Critical Message icon will be present. 
        Dim style = MsgBoxStyle.YesNo Or _
                   MsgBoxStyle.Information

        ' Display the message box and save the response, Yes or No. 
        Dim response = MsgBox(msg2, style, title)

        ' Take some action based on the response. 
        If response = MsgBoxResult.Yes Then
            MsgBox("Lets do some chemistry! :D", , title)
        Else
            MsgBox("Chemistry application killed D:", , title)
            Me.Close()
        End If
    End Sub
End Class
