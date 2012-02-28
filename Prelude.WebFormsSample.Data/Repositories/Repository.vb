Imports Prelude.WebFormsSample.Core.Interfaces
Imports Prelude.WebFormsSample.Core.PersonSection
Imports System.Collections.Generic
Imports Prelude.WebFormsSample.Data.PersonSection

Public Class Repository(Of T As Class)
    Implements IRepository(Of T)

    Private ReadOnly ctx As PersonEntities

    Public Sub New(context As Func(Of IPersonEntities))
        ctx = context()
    End Sub

    Public Function GetAll() As List(Of T) Implements IRepository(Of T).GetAll

        Return ctx.Set(Of T).ToList()

    End Function

    Public Function GetByID(id As Object) As T Implements Core.Interfaces.IRepository(Of T).GetByID

        Return ctx.Set(Of T).Find(id)

    End Function



End Class
