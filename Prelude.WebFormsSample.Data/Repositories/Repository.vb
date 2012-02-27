Imports Prelude.WebFormsSample.Core.Interfaces
Imports Prelude.WebFormsSample.Core.PersonSection
Imports System.Collections.Generic
Imports Prelude.WebFormsSample.Data.PersonSection

Public Class Repository(Of T As Class)
    Implements IRepository(Of T)

    'http://stackoverflow.com/questions/3486837/unity-2-0-registering-generic-types-via-xml

    Private ReadOnly ctx As PersonEntities

    Public Sub New(context As Func(Of IPersonEntities))
        ctx = context()
    End Sub

    Public Function GetAll() As List(Of T) Implements IRepository(Of T).GetAll

        Return (From x In ctx.Set(Of T)() Select x).ToList()


    End Function

    Public Function GetByID(Of U)(id As U) As T Implements Core.Interfaces.IRepository(Of T).GetByID

        Return (From a As IEntity(Of U) In ctx.Set(Of T)() Where a.ID.Equals(id) Select a).FirstOrDefault()

    End Function
End Class
