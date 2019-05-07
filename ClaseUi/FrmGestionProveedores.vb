Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe


Public Class FrmGestionProveedores

    Private proveedormetodo As New ProveedoresLN
    Private pro As New ProveedoresNE
    Private helpersLN As New HelpersLN
    Private busqdni As String
    Private busqape As String
    Public idproveedor As Integer
    Public usuarioid As Integer
    Public IdProvincia As Integer

    Private Sub FrmGestionproveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbProvincias.SelectedValue = 0
        cbtipodni.SelectedValue = 0
        LlenarCMBDoc()
        'llenarCMBLocalidades()
        LlenarCMBProvincias()
        DgvproveedoresSet()

    End Sub

    Public Sub DgvproveedoresSet()
        Dim dsa1 As DataSet
        dsa1 = proveedormetodo.CargaGrillaproveedores(busqdni, busqape)
        dgvproveedores.DataSource = dsa1.Tables(0)
        dgvproveedores.Columns(0).Visible = False
        dgvproveedores.Columns(1).Visible = False
        dgvproveedores.Columns(5).Visible = False
        dgvproveedores.Columns(6).Visible = False
        dgvproveedores.Columns(7).Visible = False
        dgvproveedores.Columns(8).Visible = False
        dgvproveedores.Columns(9).Visible = False
        dgvproveedores.Columns(10).Visible = False
        dgvproveedores.Columns(11).Visible = False
        dgvproveedores.Columns(12).Visible = False
        dgvproveedores.Columns(13).Visible = False
        dgvproveedores.Columns(14).Visible = False
        dgvproveedores.Columns(15).Visible = False
        ' dgvproveedores.Columns(16).Visible = False
        ' dgvproveedores.Columns(17).Visible = False
        dgvproveedores.Columns(2).HeaderText = "Nro. Doc."
        dgvproveedores.Columns(4).HeaderText = "Apellido"
        dgvproveedores.Columns(3).HeaderText = "Nombre"
        dgvproveedores.Columns(3).HeaderText = "Nombre"
        dgvproveedores.Columns(16).HeaderText = "E-Mail"
        dgvproveedores.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvproveedores.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvproveedores.Columns(16).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvproveedores.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvproveedores.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvproveedores.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvproveedores.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvproveedores.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvproveedores.Sort(dgvproveedores.Columns(4), System.ComponentModel.ListSortDirection.Ascending)

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
            'ds1 = helpersLN.CargarCMBLocalidades()
            cmbLocalidades.DataSource = ds1.Tables(0)
            cmbLocalidades.DisplayMember = "loc_nombre"
            cmbLocalidades.ValueMember = "loc_id"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LlenarCMBDoc()
        Try
            Dim ds1 As DataSet
            'ds1 = helpersLN.CargarCMBDoc()
            cbtipodni.DataSource = ds1.Tables(0)
            cbtipodni.DisplayMember = "nombretipodni"
            cbtipodni.ValueMember = "id_tipodni"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CmbProvincias_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbProvincias.SelectionChangeCommitted

        'helpersLN.idprov = cmbProvincias.SelectedValue.ToString
        LlenarCMBLocalidades()

    End Sub

    Public Sub MoverDatosPacientes()
        Dim pro = New ProveedoresNE With {
            .Id = idproveedor,
            .TipoDocumentoId = cbtipodni.SelectedValue,
            .NumeroDocumento = tbNroDoc.Text,
            .Nombre = tbNombre.Text,
            .Apellido = tbApellido.Text,
            .FechaNacimiento = dtpfechanac.Value,
            .Email = tbmail.Text,
            .UsuarioId = usuarioid
        }

        If tbcalle.Text <> "" Then
            pro.Calle = tbcalle.Text
        Else
            pro.Calle = "S/D"
        End If

        If tbNro.Text <> "" Then
            pro.NumeroCalle = tbNro.Text
        Else
            pro.NumeroCalle = "S/N"
        End If

        If tbDpto.Text <> "" Then
            pro.Departamento = tbDpto.Text
        Else
            pro.Departamento = "S/N"
        End If
        pro.CiudadId = cmbProvincias.SelectedValue

        If tbtelefono.Text <> "" Then
            pro.NumeroTelefono = tbtelefono.Text
        Else
            pro.NumeroTelefono = "NULL"
        End If

        If tbcel.Text <> "" Then
            pro.NumeroCelular = tbcel.Text
        Else
            pro.NumeroCelular = "NULL"
        End If

        If tbcodcel.Text <> "" Then
            pro.Car_Celular = tbcodcel.Text
        Else
            pro.Car_Celular = "NULL"
        End If

        If tbcodtel.Text <> "" Then
            pro.Car_Telefono = tbcodtel.Text
        Else
            pro.Car_Telefono = "NULL"
        End If

    End Sub

    Private Sub TxbTelNumero_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbcodcel.KeyPress, tbcodtel.KeyPress, tbcel.KeyPress, tbNroDoc.KeyPress, tbNro.KeyPress
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MoverDatosPacientes()
        proveedormetodo.Grabarproveedores(pro)
        DgvproveedoresSet()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Dgvproveedor_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvproveedores.DoubleClick

        idproveedor = (dgvproveedores.Item(0, dgvproveedores.CurrentRow.Index).Value)
        cbtipodni.SelectedValue = (dgvproveedores.Item(1, dgvproveedores.CurrentRow.Index).Value)
        tbNroDoc.Text = (dgvproveedores.Item(2, dgvproveedores.CurrentRow.Index).Value)
        dtpfechanac.Value = (dgvproveedores.Item(5, dgvproveedores.CurrentRow.Index).Value)
        tbNombre.Text = (dgvproveedores.Item(3, dgvproveedores.CurrentRow.Index).Value)
        tbApellido.Text = (dgvproveedores.Item(4, dgvproveedores.CurrentRow.Index).Value)
        tbcalle.Text = (dgvproveedores.Item(7, dgvproveedores.CurrentRow.Index).Value)
        tbNro.Text = (dgvproveedores.Item(8, dgvproveedores.CurrentRow.Index).Value)
        tbDpto.Text = (dgvproveedores.Item(9, dgvproveedores.CurrentRow.Index).Value)
        ' cmbLocalidades.SelectedValue = (dgvproveedores.Item(10, dgvproveedores.CurrentRow.Index).Value)
        'cmbProvincias.SelectedValue = (dgvproveedores.Item(1, dgvproveedores.CurrentRow.Index).Value)
        IdProvincia = Convert.ToString((dgvproveedores.Item(10, dgvproveedores.CurrentRow.Index).Value))
        'helpersLN.idprov = IdProvincia
        LlenarCMBLocalidades()
        tbcodtel.Text = (dgvproveedores.Item(14, dgvproveedores.CurrentRow.Index).Value)
        tbtelefono.Text = (dgvproveedores.Item(12, dgvproveedores.CurrentRow.Index).Value)
        tbcel.Text = (dgvproveedores.Item(11, dgvproveedores.CurrentRow.Index).Value)
        tbcodcel.Text = (dgvproveedores.Item(13, dgvproveedores.CurrentRow.Index).Value)
        tbmail.Text = (dgvproveedores.Item(16, dgvproveedores.CurrentRow.Index).Value)

    End Sub
End Class