'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace Assignment3_MVC

    Partial Public Class Fruit
        Public Property Fruit_ID As Integer
        Public Property Product_ID As Integer
        Public Property Fruit_Name As String
    
        Public Overridable Property Agri_Products As Agri_Products
        Public Overridable Property Apples As ICollection(Of Apple) = New HashSet(Of Apple)
        Public Overridable Property Apricots As ICollection(Of Apricot) = New HashSet(Of Apricot)
        Public Overridable Property Blueberries As ICollection(Of Blueberry) = New HashSet(Of Blueberry)
    
    End Class

End Namespace
