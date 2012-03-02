Namespace PersonSection

    Public Enum AttrType
        PrimaryKey
        CreatedDate
        ModifiedDate
    End Enum


    <AttributeUsage(AttributeTargets.Property)>
    Public Class CustomAttribute
        Inherits Attribute

        Protected _attributeType As AttrType

        Public Sub New(ByVal type As AttrType)
            Me._AttributeType = type
        End Sub

        Public Property AttributeType() As AttrType
            Get
                Return Me._attributeType
            End Get
            Set(value As AttrType)
                _attributeType = value
            End Set
        End Property
    End Class
End Namespace
