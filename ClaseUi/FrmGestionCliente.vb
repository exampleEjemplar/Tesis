Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe


Public Class FrmGestionProveedor

    Private clientemetodo As New ClientesLN
    Private cli As New ClientesNE
    Private helpersLN As New HelpersLN
    Private busqdni As String
    Private busqape As String
    Public idcliente As Integer
    Public usuarioid As Integer
    Public IdProvincia As Integer

    Private Sub FrmGestionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbProvincias.SelectedValue = 0
        cbtipodni.SelectedValue = 0
        LlenarCMBDoc()
        'llenarCMBLocalidades()
        LlenarCMBProvincias()
        DgvclientesSet()

    End Sub

    Public Sub DgvclientesSet()
        Dim dsa1 As DataSet
        dsa1 = clientemetodo.CargaGrillaclientes(busqdni, busqape)
        dgvclientes.DataSource = dsa1.Tables(0)
        dgvclientes.Columns(0).Visible = False
        dgvclientes.Columns(1).Visible = False
        dgvclientes.Columns(5).Visible = False
        dgvclientes.Columns(6).Visible = False
        dgvclientes.Columns(7).Visible = False
        dgvclientes.Columns(8).Visible = False
        dgvclientes.Columns(9).Visible = False
        dgvclientes.Columns(10).Visible = False
        dgvclientes.Columns(11).Visible = False
        dgvclientes.Columns(12).Visible = False
        dgvclientes.Columns(13).Visible = False
        dgvclientes.Columns(14).Visible = False
        dgvclientes.Columns(15).Visible = False
        ' dgvclientes.Columns(16).Visible = False
        ' dgvclientes.Columns(17).Visible = False
        dgvclientes.Columns(2).HeaderText = "Nro. Doc."
        dgvclientes.Columns(4).HeaderText = "Apellido"
        dgvclientes.Columns(3).HeaderText = "Nombre"
        dgvclientes.Columns(3).HeaderText = "Nombre"
        dgvclientes.Columns(16).HeaderText = "E-Mail"
        dgvclientes.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvclientes.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvclientes.Columns(16).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvclientes.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvclientes.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvclientes.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvclientes.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvclientes.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvclientes.Sort(dgvclientes.Columns(4), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Public Sub LlenarCMBProvincias()
        Try
            Dim ds1 As DataSet
            ds1 = helpersLN.CargarCMBProvincias()
            cmbProvincias.DataSource = ds1.Tables(0)
            cmbProvincias.DisplayMember = "nombre_prov"
            cmbProvincias.ValueMember = "idprovincia"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LlenarCMBLocalidades()
        Try
            Dim ds1 As DataSet
            ds1 = helpersLN.CargarCMBLocalidades()
            cmbLocalidades.DataSource = ds1.Tables(0)
            cmbLocalidades.DisplayMember = "loc_nombre"
            cmbLocalidades.ValueMember = "loc_id"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Llena ComboBox Tipo DNI
    Public Sub LlenarCMBDoc()
        Try
            Dim ds1 As DataSet
            ds1 = helpersLN.CargarCMBDoc()
            cbtipodni.DataSource = ds1.Tables(0)
            cbtipodni.DisplayMember = "nombretipodni"
            cbtipodni.ValueMember = "id_tipodni"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CmbProvincias_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbProvincias.SelectionChangeCommitted

        helpersLN.idprov = cmbProvincias.SelectedValue.ToString
        LlenarCMBLocalidades()

    End Sub

    Public Sub MoverDatosClientes()
        cli = New ClientesNE With {
            .Id = idcliente,
            .TipoDocumentoId = cbtipodni.SelectedValue,
            .NumeroDocumento = tbNroDoc.Text,
            .Nombre = tbNombre.Text,
            .Apellido = tbApellido.Text,
            .FechaNacimiento = dtpfechanac.Value,
            .Email = tbmail.Text,
            .UsuarioId = usuarioid
        }

        If tbcalle.Text <> "" Then
            cli.Calle = tbcalle.Text
        Else
            cli.Calle = "S/D"
        End If

        If tbNro.Text <> "" Then
            cli.NumeroCalle = tbNro.Text
        Else
            cli.NumeroCalle = "S/N"
        End If

        If tbDpto.Text <> "" Then
            cli.Departamento = tbDpto.Text
        Else
            cli.Departamento = "S/N"
        End If
        cli.CiudadId = cmbProvincias.SelectedValue

        If tbtelefono.Text <> "" Then
            cli.NumeroTelefono = tbtelefono.Text
        Else
            cli.NumeroTelefono = "NULL"
        End If

        If tbcel.Text <> "" Then
            cli.NumeroCelular = tbcel.Text
        Else
            cli.NumeroCelular = "NULL"
        End If

        If tbcodcel.Text <> "" Then
            cli.Car_Celular = tbcodcel.Text
        Else
            cli.Car_Celular = "NULL"
        End If

        If tbcodtel.Text <> "" Then
            cli.Car_Telefono = tbcodtel.Text
        Else
            cli.Car_Telefono = "NULL"
        End If

    End Sub

    Private Sub TxbTelNumero_KeyPress(sender As System.Object, e As KeyPressEventArgs) Handles tbcodcel.KeyPress, tbcodtel.KeyPress, tbcel.KeyPress, tbNroDoc.KeyPress, tbNro.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TbNombre_KeyPress(sender As System.Object, e As KeyPressEventArgs) Handles tbNombre.KeyPress, tbApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    'Private Sub txbBusquedaNombre_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txbBusquedaNombre.KeyPress
    '    If Char.IsLetter(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MoverDatosClientes()
        clientemetodo.GrabarClientes(cli)
        DgvclientesSet()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Dgvcliente_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvclientes.DoubleClick

        idcliente = (dgvclientes.Item(0, dgvclientes.CurrentRow.Index).Value)
        cbtipodni.SelectedValue = (dgvclientes.Item(1, dgvclientes.CurrentRow.Index).Value)
        tbNroDoc.Text = (dgvclientes.Item(2, dgvclientes.CurrentRow.Index).Value)
        dtpfechanac.Value = (dgvclientes.Item(5, dgvclientes.CurrentRow.Index).Value)
        tbNombre.Text = (dgvclientes.Item(3, dgvclientes.CurrentRow.Index).Value)
        tbApellido.Text = (dgvclientes.Item(4, dgvclientes.CurrentRow.Index).Value)
        tbcalle.Text = (dgvclientes.Item(7, dgvclientes.CurrentRow.Index).Value)
        tbNro.Text = (dgvclientes.Item(8, dgvclientes.CurrentRow.Index).Value)
        tbDpto.Text = (dgvclientes.Item(9, dgvclientes.CurrentRow.Index).Value)
        ' cmbLocalidades.SelectedValue = (dgvclientes.Item(10, dgvclientes.CurrentRow.Index).Value)
        'cmbProvincias.SelectedValue = (dgvclientes.Item(1, dgvclientes.CurrentRow.Index).Value)
        IdProvincia = Convert.ToString((dgvclientes.Item(10, dgvclientes.CurrentRow.Index).Value))
        helpersLN.idprov = IdProvincia 'TODO Aca esto se puede evitar pasando como parametro el int directamente 
        LlenarCMBLocalidades()
        tbcodtel.Text = (dgvclientes.Item(14, dgvclientes.CurrentRow.Index).Value)
        tbtelefono.Text = (dgvclientes.Item(12, dgvclientes.CurrentRow.Index).Value)
        tbcel.Text = (dgvclientes.Item(11, dgvclientes.CurrentRow.Index).Value)
        tbcodcel.Text = (dgvclientes.Item(13, dgvclientes.CurrentRow.Index).Value)
        tbmail.Text = (dgvclientes.Item(16, dgvclientes.CurrentRow.Index).Value)

    End Sub
End Class