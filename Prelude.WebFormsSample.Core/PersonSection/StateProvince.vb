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

    Partial Public Class StateProvince
        Public Property StateProvinceID As Integer
        Public Property StateProvinceCode As String
        Public Property CountryRegionCode As String
        Public Property IsOnlyStateProvinceFlag As Boolean
        Public Property Name As String
        Public Property TerritoryID As Integer
        Public Property rowguid As System.Guid
        Public Property ModifiedDate As Date
    
        Public Overridable Property Address As ICollection(Of Address) = New HashSet(Of Address)
        Public Overridable Property CountryRegion As CountryRegion
    
    End Class

End Namespace
