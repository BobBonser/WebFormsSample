﻿'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Namespace PersonSection

    Public Interface IPersonEntities
    
        ReadOnly Property Context As DbContext
        Property Address() As DbSet(Of Address)
        Property CountryRegion() As DbSet(Of CountryRegion)
        Property StateProvince() As DbSet(Of StateProvince)

    End Interface

End Namespace
