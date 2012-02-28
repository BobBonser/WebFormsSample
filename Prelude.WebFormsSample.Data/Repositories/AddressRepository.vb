Imports Prelude.WebFormsSample.Core.Interfaces
Imports Prelude.WebFormsSample.Core.PersonSection
Imports System.Data.Entity.Infrastructure

Namespace Repositories

    Public Class AddressRepository
        Inherits Repository(Of Address)
        Implements IAddressRepository

        Private ReadOnly ctx As IPersonEntities

        Public Sub New(context As Func(Of IPersonEntities))
            MyBase.New(context)
            Me.ctx = context()
        End Sub

        Public Function GettAddressFromContext(id As Integer) As Address Implements IAddressRepository.GettAddressFromContext

            Dim context = Me.ctx.Context
            Dim objectCtx = CType(context, IObjectContextAdapter).ObjectContext
            Dim entityKeyValues As IEnumerable(Of KeyValuePair(Of String, Object)) = New KeyValuePair(Of String, Object)() {New KeyValuePair(Of String, Object)("AddressID", id)}
            Dim key As New EntityKey("PersonEntities.Address", entityKeyValues)
            Dim address234 As Address = Nothing
            objectCtx.TryGetObjectByKey(key, address234)

            Return address234
        End Function

    End Class

End Namespace
