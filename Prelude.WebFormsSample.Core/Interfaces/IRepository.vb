Namespace Interfaces

    Public Interface IRepository(Of T As Class)

        Function GetAll() As List(Of T)
        Function GetByID(Of U)(ByVal id As U) As T

    End Interface
End Namespace
