Namespace Interfaces

    Public Interface IRepository(Of T As Class)

        Function GetAll() As List(Of T)
        Function GetByID(ByVal id As Object) As T

    End Interface
End Namespace
