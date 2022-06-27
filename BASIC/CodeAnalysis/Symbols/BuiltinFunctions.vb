﻿Imports System.Collections.Immutable
Imports System.Reflection

Namespace Basic.CodeAnalysis.Symbols

  Friend Module BuiltinFunctions

    'Public ReadOnly Print As New FunctionSymbol("print", ImmutableArray.Create(New ParameterSymbol("text", TypeSymbol.String, 0)), TypeSymbol.Nothing)
    Public ReadOnly Input As New FunctionSymbol("input", ImmutableArray(Of ParameterSymbol).Empty, TypeSymbol.String)

    Public ReadOnly Asc As New FunctionSymbol("asc", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.String)), TypeSymbol.Integer)
    Public ReadOnly Abs As New FunctionSymbol("abs", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.Integer, 0)), TypeSymbol.Integer)
    Public ReadOnly Atn As New FunctionSymbol("atn", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.Integer, 0)), TypeSymbol.Integer)
    Public ReadOnly Cos As New FunctionSymbol("cos", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.Integer, 0)), TypeSymbol.Integer)
    Public ReadOnly Int As New FunctionSymbol("int", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.Integer, 0)), TypeSymbol.Integer)
    Public ReadOnly LBound As New FunctionSymbol("ubound", ImmutableArray.Create(New ParameterSymbol("lbound", TypeSymbol.Any)), TypeSymbol.Integer)
    Public ReadOnly Len As New FunctionSymbol("len", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.String)), TypeSymbol.Integer)
    Public ReadOnly Log As New FunctionSymbol("log", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.Integer, 0)), TypeSymbol.Integer)
    Public ReadOnly Rnd As New FunctionSymbol("rnd", ImmutableArray.Create(New ParameterSymbol("max", TypeSymbol.Integer, 0)), TypeSymbol.Integer)
    Public ReadOnly Sgn As New FunctionSymbol("sgn", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.Integer, 0)), TypeSymbol.Integer)
    Public ReadOnly Sin As New FunctionSymbol("sin", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.Integer, 0)), TypeSymbol.Integer)
    Public ReadOnly Sqr As New FunctionSymbol("sqr", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.Integer, 0)), TypeSymbol.Integer)
    Public ReadOnly Tan As New FunctionSymbol("tan", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.Integer, 0)), TypeSymbol.Integer)
    Public ReadOnly Val As New FunctionSymbol("val", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.String)), TypeSymbol.Integer)
    Public ReadOnly UBound As New FunctionSymbol("ubound", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.Any)), TypeSymbol.Integer)

    Public ReadOnly Chr As New FunctionSymbol("chr$", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.Integer)), TypeSymbol.String)
    Public ReadOnly Hex As New FunctionSymbol("hex$", ImmutableArray.Create(New ParameterSymbol("num", TypeSymbol.Integer)), TypeSymbol.String)
    Public ReadOnly LCase As New FunctionSymbol("lcase$", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.String)), TypeSymbol.String)
    Public ReadOnly Left As New FunctionSymbol("left$", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.String), New ParameterSymbol("num", TypeSymbol.Integer)), TypeSymbol.String)
    Public ReadOnly Oct As New FunctionSymbol("oct$", ImmutableArray.Create(New ParameterSymbol("num", TypeSymbol.Integer)), TypeSymbol.String)
    Public ReadOnly Right As New FunctionSymbol("right$", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.String), New ParameterSymbol("num", TypeSymbol.Integer)), TypeSymbol.String)
    Public ReadOnly Space As New FunctionSymbol("space$", ImmutableArray.Create(New ParameterSymbol("num", TypeSymbol.Integer)), TypeSymbol.String)
    Public ReadOnly Str As New FunctionSymbol("str$", ImmutableArray.Create(New ParameterSymbol("num", TypeSymbol.Integer)), TypeSymbol.String)
    Public ReadOnly UCase As New FunctionSymbol("ucase$", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.String)), TypeSymbol.String)

    Public ReadOnly Instr1 As New FunctionSymbol("instr", ImmutableArray.Create(New ParameterSymbol("string1", TypeSymbol.String), New ParameterSymbol("string2", TypeSymbol.String)), TypeSymbol.Integer)
    Public ReadOnly Instr2 As New FunctionSymbol("instr", ImmutableArray.Create(New ParameterSymbol("start", TypeSymbol.Integer), New ParameterSymbol("string1", TypeSymbol.String), New ParameterSymbol("string2", TypeSymbol.String)), TypeSymbol.Integer)
    Public ReadOnly Mid1 As New FunctionSymbol("mid$", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.String), New ParameterSymbol("start", TypeSymbol.Integer)), TypeSymbol.String)
    Public ReadOnly Mid2 As New FunctionSymbol("mid$", ImmutableArray.Create(New ParameterSymbol("value", TypeSymbol.String), New ParameterSymbol("start", TypeSymbol.Integer), New ParameterSymbol("length", TypeSymbol.Integer)), TypeSymbol.String)
    Public ReadOnly StringFunction As New FunctionSymbol("string$", ImmutableArray.Create(New ParameterSymbol("num", TypeSymbol.Integer), New ParameterSymbol("value", TypeSymbol.Integer)), TypeSymbol.String)

    Friend Function GetAll() As IEnumerable(Of FunctionSymbol)
      Return GetType(BuiltinFunctions).GetFields(BindingFlags.Public Or BindingFlags.Static).
                                       Where(Function(f) f.FieldType = GetType(FunctionSymbol)).
                                       Select(Function(f) CType(f.GetValue(Nothing), FunctionSymbol))
    End Function

  End Module

End Namespace