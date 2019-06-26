Imports System.Globalization
Imports System.Windows.Forms
Imports ClaseLn
Public Class FrmGestionMaterial

	Private materialesLN As New MaterialesLN
	Private modificando As Boolean = False
	Public materialId As Integer
	Public modificado As Boolean = False

	Private Sub FrmGestionCategorías_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		GroupBox1.Visible = False
		CargarGrilla()
		btnGuardar.Enabled = False
		modificado = False
	End Sub
	Public Sub CargarGrilla()
		Dim ds As DataSet = materialesLN.CargarGrillaMateriales()
		Dim examples As List(Of Example) = New List(Of Example)

		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

			If examples.Where(Function(s) s.Id = ds.Tables(0).Rows(i)(0).ToString()).FirstOrDefault() IsNot Nothing Then

				For Each example As Example In examples
					If example.Id = ds.Tables(0).Rows(i)(0).ToString() And Date.ParseExact(example.Fecha, "dd/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture) < Date.ParseExact(ds.Tables(0).Rows(i)(3).ToString(), "dd/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture) Then
						examples.Add(New Example With {
					.Id = ds.Tables(0).Rows(i)(0).ToString(),
					.Material = ds.Tables(0).Rows(i)(1).ToString(),
					.Cotizacion = ds.Tables(0).Rows(i)(2).ToString(),
					.Fecha = ds.Tables(0).Rows(i)(3).ToString()
					})
						examples.Remove(example)
						Exit For
					End If
				Next
			Else
				examples.Add(New Example With {
					.Id = ds.Tables(0).Rows(i)(0).ToString(),
					.Material = ds.Tables(0).Rows(i)(1).ToString(),
					.Cotizacion = ds.Tables(0).Rows(i)(2).ToString(),
					.Fecha = ds.Tables(0).Rows(i)(3).ToString()
					})
			End If

		Next

		dgvCategorias.DataSource = examples
		dgvCategorias.Columns("Id").Visible = False
		dgvCategorias.Columns("Material").DisplayIndex = 0
		dgvCategorias.Columns("Cotizacion").DisplayIndex = 1
		dgvCategorias.Columns("Fecha").DisplayIndex = 2

		dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		dgvCategorias.AutoResizeColumns()
	End Sub
	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvCategorias.CellMouseDoubleClick
		Dim selectedRow As DataGridViewRow
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = dgvCategorias.Rows(e.RowIndex)
		End If
		Dim ds As DataSet = materialesLN.ConsultaModificacion(selectedRow.Cells("id").Value)
		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
			txtNombre.Text = ds.Tables(0).Rows(i)(0).ToString()
			txtCoti.Text = ds.Tables(0).Rows(i)(1).ToString()
			dtpfecha.Value = ds.Tables(0).Rows(i)(2).ToString()
			dtpfecha.Enabled = False
			materialId = ds.Tables(0).Rows(i)(3).ToString()
			modificando = True
			GroupBox1.Visible = True
			btnGuardar.Enabled = True
		Next

	End Sub

	Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

		If String.IsNullOrWhiteSpace(txtNombre.Text) Then
			MsgBox("Ingrese el nombre del material", MsgBoxStyle.Critical, "Material")
			Return
		End If

		If String.IsNullOrWhiteSpace(txtCoti.Text) Then
			MsgBox("Ingrese la cotizacion del material", MsgBoxStyle.Critical, "Material")
			Return
		End If


		Dim value As Decimal
		txtCoti.Text.Replace(",", ".")
		If Not Decimal.TryParse(txtCoti.Text, value) Then
			MsgBox("Ingrese la cotizacion del material en un formato correcto (123.00)", MsgBoxStyle.Critical, "Material")
			Return
		Else
			value = Decimal.Parse(txtCoti.Text, CultureInfo.InvariantCulture)
		End If

		If modificando Then
			materialesLN.NuevaCotizacion(materialId, value)
			MsgBox("Cotizacion de material agregada", MsgBoxStyle.OkOnly, "Material")
		Else
			materialesLN.GuardarNuevo(txtNombre.Text, value)
			MsgBox("Material agregado", MsgBoxStyle.OkOnly, "Material")
		End If

		modificando = False
		btnNuevo.Enabled = True
		btnGuardar.Enabled = False
		txtCoti.Text = ""
		txtNombre.Text = ""
		GroupBox1.Visible = False
		CargarGrilla()

	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCotizacionesHist.Click
		FrmConsultaCotizaciones.Show()
	End Sub

	Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		GroupBox1.Visible = True
		lblFecha.Visible = False
		dtpfecha.Visible = False
		btnGuardar.Enabled = True
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalirr.Click
		With FrmGestionProducto
		End With
		FrmGestionProducto.Show()
		modificado = True
		Me.Close()
	End Sub

	Private Sub FrmGestionMaterial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		modificado = True
	End Sub
End Class

Public Class Example
	Private _Id As String

	Public Property Id As String
		Get
			Return _Id
		End Get
		Set(ByVal value As String)
			_Id = CStr(value)
		End Set
	End Property
	Private _Coti As String

	Public Property Cotizacion As String
		Get
			Return _Coti
		End Get
		Set(ByVal value As String)
			_Coti = CStr(value)
		End Set
	End Property
	Private _Fecha As String

	Public Property Fecha As String
		Get
			Return _Fecha
		End Get
		Set(ByVal value As String)
			_Fecha = CStr(value)
		End Set
	End Property
	Private _Nombre As String

	Public Property Material As String
		Get
			Return _Nombre
		End Get
		Set(ByVal value As String)
			_Nombre = CStr(value)
		End Set
	End Property
End Class