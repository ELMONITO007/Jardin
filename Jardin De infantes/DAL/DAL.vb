﻿Imports DAL

Public MustInherit Class DAL(Of T)
    Implements IdatosCompleto(Of T)




    Public MustOverride Sub IdatosCompleto_Modificar(HT As Hashtable) Implements IdatosCompleto(Of T).Modificar


    Public MustOverride Sub IdatosCompleto_Eliminar(HT As Hashtable) Implements IdatosCompleto(Of T).Eliminar


    Public MustOverride Sub IdatosCompleto_Agregar(HT As Hashtable) Implements IdatosCompleto(Of T).Agregar



    Public MustOverride Function IdatosCompleto_Buscar(ID As Integer) As DataTable Implements IdatosCompleto(Of T).Buscar


    Public MustOverride Function IdatosCompleto_Listar() As List(Of T) Implements IdatosCompleto(Of T).Listar

End Class