Imports Prelude.WebFormsSample.Core.Interfaces
Imports Prelude.WebFormsSample.Core.PersonSection
Imports System.Collections.Generic
Imports Prelude.WebFormsSample.Data.PersonSection
Imports System.Reflection
Imports System.Data.Objects.DataClasses

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

        Return CType(ctx.ObjectContext.GetObjectByKey(New EntityKey(ctx.ObjectContext.DefaultContainerName + "." +
                                                                    ctx.ObjectContext.CreateObjectSet(Of T).EntitySet.Name, GetPrimaryKey(AttrType.PrimaryKey), id)), T)

        'Return ctx.Set(Of T).Find(id)

    End Function

    Private Function GetPrimaryKey(atype As AttrType) As String
        Dim props = From p In GetType(T).GetProperties()
                    Let IsKey = (From attr In p.GetCustomAttributes(False)
                                 Select If(attr.GetType() = GetType(CustomAttribute) AndAlso CType(attr, CustomAttribute).AttributeType = atype, True, False)).FirstOrDefault()
                    Select New With
                    {
                        .Name = p.Name,
                        .IsKey = IsKey
                    }

        Dim pkey As String = props.Where(Function(p) p.IsKey = True).Select(Function(p) p.Name).FirstOrDefault()

        If (String.IsNullOrEmpty(pkey)) Then
            Throw New Exception("Cannot determine entity's primary key")
        End If

        Return pkey
    End Function

End Class
