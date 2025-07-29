Public Class formMain
    'VILLAGE COORDINATOR BUTTON
    Private Sub btnVillage_HOME_Click(sender As Object, e As EventArgs) Handles btnVillage_HOME.Click
        Village_Coordinator_Team.Show()
    End Sub

    'ORGANISING TEAM BUTTON
    Private Sub btnOrg_Home_Click(sender As Object, e As EventArgs) Handles btnOrg_Home.Click
        InputDialogBox.Show()
    End Sub

    Private Sub btnActivity_HOME_Click(sender As Object, e As EventArgs) Handles btnActivity_HOME.Click
        Activities.Show()
    End Sub

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fix layout at design-time resolution
        Me.AutoScaleMode = AutoScaleMode.None
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Optional fixed size
        'Me.Size = New Size(1164, 89    3)
    End Sub
End Class
