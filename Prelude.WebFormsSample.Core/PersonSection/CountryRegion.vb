'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace PersonSection

    Partial Public Class CountryRegion
        Public Property CountryRegionCode As String
        Public Property Name As String
        Public Property ModifiedDate As Date
    
        Public Overridable Property StateProvince As ICollection(Of StateProvince) = New HashSet(Of StateProvince)
    
    End Class

End Namespace
