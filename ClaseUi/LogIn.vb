
Imports System.Drawing
Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe

Public Class LogIn
    Public nivelusr As Integer
    Private helpersUI As New HelpersUI

    Dim loginMetodo As New LoginLN



#Region "Eventos"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        Try

            If loginMetodo.usuarioRegistrado(txtUsuario.Text) = True Then
                Dim contra As String = loginMetodo.contrasena(txtUsuario.Text)
                If contra.Equals(txtContrasena.Text) = True Then
                    loginMetodo.rolUsuario = loginMetodo.ConsultarRolUsuario(txtUsuario.Text)
                    loginMetodo.usr_id = loginMetodo.ConsultarIDUsuario(txtUsuario.Text)
                    loginMetodo.EnSesion(loginMetodo.usr_id)
                    helpersUI.TextValidator("a", "a")
					nivelusr = loginMetodo.rolUsuario

					With MDIPrincipal
					End With
					MDIPrincipal.Show()
					Me.Close()

				Else

                    MessageBox.Show("Contraseña Inválida", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Show()
                End If
            Else


				MessageBox.Show("El usuario no se encuentra registrado", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.Show()

			End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "AVISO ", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region
#Region "Metodos"

	'Public Function ObtainUserId()

	'End Function

	Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = ""
        txtContrasena.Text = ""
        'Mostrar Fecha y Hora
        lblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub



    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles pictureBox1.MouseHover
        pictureBox1.Size = New Size(100, 92)
        'pictureBox1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles pictureBox1.MouseLeave
        pictureBox1.Size = New Size(90, 85)
        'pictureBox1.BackgroundImageLayout = ImageLayout.Zoom
    End Sub


#End Region

End Class

