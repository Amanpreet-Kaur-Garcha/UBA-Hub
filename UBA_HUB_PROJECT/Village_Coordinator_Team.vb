Public Class Village_Coordinator_Team

    Dim conn As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim reader As System.Data.OleDb.OleDbDataReader

    Dim Img1 As String = ""
    Dim Img2 As String = ""
    Dim Img3 As String = ""
    Dim Video As String = ""

    'RESET
    Private Sub btnReset_VC_Click(sender As Object, e As EventArgs) Handles btnReset_VC.Click
        txtEmail_VC.Text = ""
        cmbxCoordinator_VC.Text = ""
        cmbxVillage_VC.Text = ""
        txtActivity_VC.Text = ""
        txtDesc_VC.Text = ""
        txtDetails_VC.Text = ""
        Img1 = ""
        Img2 = ""
        Img3 = ""
        Video = ""
        picbxImage1_VC.Image = Nothing
        picbxImage2_VC.Image = Nothing
        picbxImage3_VC.Image = Nothing
        lblNewVideo_VC.Text = ""
    End Sub

    'SUBMIT
    Private Sub btnSubmit_VC_Click(sender As Object, e As EventArgs) Handles btnSubmit_VC.Click
        ' Input validation
        If cmbxCoordinator_VC.SelectedIndex = -1 OrElse
       cmbxVillage_VC.SelectedIndex = -1 OrElse
       String.IsNullOrWhiteSpace(txtActivity_VC.Text) OrElse
       String.IsNullOrWhiteSpace(txtDesc_VC.Text) OrElse
       String.IsNullOrWhiteSpace(txtDetails_VC.Text) OrElse
       String.IsNullOrWhiteSpace(txtEmail_VC.Text) Then

            MessageBox.Show("Please fill in all the fields before submitting.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UBA_HUB\UBA_HUB_PROJECT_FINALLLLLLLLLLLLLLLLL\UBA_Dtbse.accdb"

            Dim query As String = "INSERT INTO UBA_Drives_Data (Coordinator, Village, Activity, Date_of_act, Raw_Description, Details, Image1, Image2, Image3, Video, Email_ID) " &
                      "VALUES ('" & cmbxCoordinator_VC.SelectedItem.ToString().Replace("'", "''") & "', '" &
                      cmbxVillage_VC.SelectedItem.ToString().Replace("'", "''") & "', '" &
                      txtActivity_VC.Text.Replace("'", "''") & "', #" &
                      DateTimePicker_VC.Value & "#, '" &
                      txtDesc_VC.Text.Replace("'", "''") & "', '" &
                      txtDetails_VC.Text.Replace("'", "''") & "', '" &
                      Img1 & "', '" & Img2 & "', '" & Img3 & "', '" & Video & "', '" &
                      txtEmail_VC.Text.Replace("'", "''") & "')"


            cmd = New OleDb.OleDbCommand(query, conn)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error submitting data: " & ex.Message, "Submission Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'IMAGE 1 UPLOAD BUTTON
    Private Sub btnUploadImage1_VC_Click(sender As Object, e As EventArgs) Handles btnUploadImage1_VC.Click
        Dim OpenDialog1_VC As New OpenFileDialog()
        If OpenDialog1_VC.ShowDialog() = DialogResult.OK Then
            Img1 = OpenDialog1_VC.FileName
            picbxImage1_VC.Image = Image.FromFile(Img1)
        End If
    End Sub

    'IMAGE 2 UPLOAD BUTTON
    Private Sub btnUploadImage2_VC_Click(sender As Object, e As EventArgs) Handles btnUploadImage2_VC.Click
        Dim OpenDialog2_VC As New OpenFileDialog()
        If OpenDialog2_VC.ShowDialog() = DialogResult.OK Then
            Img2 = OpenDialog2_VC.FileName
            picbxImage2_VC.Image = Image.FromFile(Img2)
        End If
    End Sub

    'IMAGE 3 UPLOAD BUTTON
    Private Sub btnUploadImage3_VC_Click(sender As Object, e As EventArgs) Handles btnUploadImage3_VC.Click
        Dim OpenDialog3_VC As New OpenFileDialog()
        If OpenDialog3_VC.ShowDialog() = DialogResult.OK Then
            Img3 = OpenDialog3_VC.FileName
            picbxImage3_VC.Image = Image.FromFile(Img3)
        End If
    End Sub

    'VIDEO UPLOAD BUTTON
    Private Sub btnUploadVideo_VC_Click(sender As Object, e As EventArgs) Handles btnUploadVideo_VC.Click
        Dim OpenDialog4Video_VC As New OpenFileDialog()
        If OpenDialog4Video_VC.ShowDialog() = DialogResult.OK Then
            Video = OpenDialog4Video_VC.FileName
            If Video = OpenDialog4Video_VC.FileName Then
                lblNewVideo_VC.Text = "VIDEO UPLOADED SUCCESSFULLY!!"
            End If
        End If
    End Sub
End Class