Imports System.Data
Imports System.Data.SqlClient

Class MainWindow
    Dim con As SqlConnection = New SqlConnection("Data Source=PROCYON-W10\SQLEXPRESS;Initial Catalog=loginform;User ID=Pooja;Password=***********;Trusted_Connection=False;MultipleActiveResultSets=true;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub Btn_login_Click(sender As Object, e As RoutedEventArgs) Handles Btn_login.Click
        If con.State = ConnectionState.Open Then
            con.Close()
            con.Open()
            If Txt_username.Text = "" Then
                MsgBox("Enter Username..", MsgBoxStyle.Critical)
            ElseIf Txt_password.Text = "" Then
                MsgBox("Enter Password..", MsgBoxStyle.Critical)
            Else
                Dim query As String
                query = "select * from login where username='" + Txt_username.Text + "' and password='" + Txt_password.Text + "' and type='" + combo.SelectedItem + "'"
                cmd = New SqlCommand(query, con)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim ds As DataSet = New DataSet()
                da.Fill(ds)
                Dim a As Integer
                a = ds.Tables(0).Rows.Count
                If a = 0 Then
                    MsgBox("login Failed nter Valid ID,Password and Type", MsgBoxStyle.Critical)
                ElseIf combo.SelectedItem = "Admin" Then






                End If




            End If
        End If



    End Sub
End Class



