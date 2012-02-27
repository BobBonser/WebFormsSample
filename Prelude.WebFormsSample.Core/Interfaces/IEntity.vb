Namespace Interfaces

    Public Interface IEntity(Of T)
        Inherits IEquatable(Of T)

        ReadOnly Property ID As T

    End Interface
End Namespace