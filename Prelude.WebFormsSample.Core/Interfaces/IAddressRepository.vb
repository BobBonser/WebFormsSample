Imports Prelude.WebFormsSample.Core.PersonSection

Namespace Interfaces
    Public Interface IAddressRepository
        Inherits IRepository(Of Address)

        Function GettAddressFromContext(ByVal id As Integer) As Address

    End Interface
End Namespace
