﻿Public Class ClientesNE

    Private _Id As Integer

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = CStr(value)
        End Set
    End Property

    Private _TipoDocumentoId As Integer

    Public Property TipoDocumentoId As Integer
        Get
            Return _TipoDocumentoId
        End Get
        Set(ByVal value As Integer)
            _TipoDocumentoId = CStr(value)
        End Set
    End Property

    Private _NumeroDocumento As String

    Public Property NumeroDocumento As String
        Get
            Return _NumeroDocumento
        End Get
        Set(ByVal value As String)
            _NumeroDocumento = CStr(value)
        End Set
    End Property

    Private _NumeroCalle As String

    Public Property NumeroCalle As String
        Get
            Return _NumeroCalle
        End Get
        Set(ByVal value As String)
            _NumeroCalle = CStr(value)
        End Set
    End Property

    Private _Piso As String

    Public Property Piso As String
        Get
            Return _Piso
        End Get
        Set(ByVal value As String)
            _Piso = CStr(value)
        End Set
    End Property

    Private _Manzana As String

    Public Property Manzana As String
        Get
            Return _Manzana
        End Get
        Set(ByVal value As String)
            _Manzana = CStr(value)
        End Set
    End Property

    Private _Lote As String

    Public Property Lote As String
        Get
            Return _Lote
        End Get
        Set(ByVal value As String)
            _Lote = CStr(value)
        End Set
    End Property

    Private _CiudadId As Integer

    Public Property CiudadId As Integer
        Get
            Return _CiudadId
        End Get
        Set(ByVal value As Integer)
            _CiudadId = CStr(value)
        End Set
    End Property

    Private _Car_Telefono As String

    Public Property Car_Telefono As String
        Get
            Return _Car_Telefono
        End Get
        Set(ByVal value As String)
            _Car_Telefono = CStr(value)
        End Set
    End Property

    Private _NumeroTelefono As String

    Public Property NumeroTelefono As String
        Get
            Return _NumeroTelefono
        End Get
        Set(ByVal value As String)
            _NumeroTelefono = CStr(value)
        End Set
    End Property

    Private _Car_Celular As String

    Public Property Car_Celular As String
        Get
            Return _Car_Celular
        End Get
        Set(ByVal value As String)
            _Car_Celular = CStr(value)
        End Set
    End Property

    Private _NumeroCelular As String

    Public Property NumeroCelular As String
        Get
            Return _NumeroCelular
        End Get
        Set(ByVal value As String)
            _NumeroCelular = CStr(value)
        End Set
    End Property

    Private _Nombre As String

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = CStr(value)
        End Set
    End Property

    Private _UsuarioId As Integer

    Public Property UsuarioId As Integer
        Get
            Return _UsuarioId
        End Get
        Set(ByVal value As Integer)
            _UsuarioId = CStr(value)
        End Set
    End Property

    Private _Apellido As String

    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = CStr(value)
        End Set
    End Property

    Private _Calle As String

    Public Property Calle As String
        Get
            Return _Calle
        End Get
        Set(ByVal value As String)
            _Calle = CStr(value)
        End Set
    End Property

    Private _Departamento As String

    Public Property Departamento As String
        Get
            Return _Departamento
        End Get
        Set(ByVal value As String)
            _Departamento = CStr(value)
        End Set
    End Property

    Private _Barrio As String

    Public Property Barrio As String
        Get
            Return _Barrio
        End Get
        Set(ByVal value As String)
            _Barrio = CStr(value)
        End Set
    End Property

    Private _ActivoSN As String

    Public Property ActivoSN As String
        Get
            Return _ActivoSN
        End Get
        Set(ByVal value As String)
            _ActivoSN = CStr(value)
        End Set
    End Property

    Private _Email As String

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = CStr(value)
        End Set
    End Property

    Private _FisicaOJuridica As String

    Public Property FisicaOJuridica As String
        Get
            Return _FisicaOJuridica
        End Get
        Set(ByVal value As String)
            _FisicaOJuridica = CStr(value)
        End Set
    End Property

    Private _FechaNacimiento As Date

    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(ByVal value As Date)
            _FechaNacimiento = CStr(value)
        End Set
    End Property

    Private _FechaAlta As Date

    Public Property FechaAlta As Date
        Get
            Return _FechaAlta
        End Get
        Set(ByVal value As Date)
            _FechaAlta = CStr(value)
        End Set
    End Property
End Class
