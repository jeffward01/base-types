﻿namespace AD.BaseTypes.FSharp

open System
open AD.BaseTypes

/// Module for base types.
module BaseType =

    /// <summary>
    /// Creates a base type.
    /// </summary>
    /// <param name="value">The base type's value.</param>
    /// <returns>The created base type or an error message.</returns>
    let inline create<'baseType, 'wrapped when 'baseType :> IBaseType<'wrapped> and 'baseType : (static member Create: 'wrapped -> 'baseType)> value =
        try
            (^baseType : (static member Create: 'wrapped -> 'baseType) value) |> Ok
        with
        | :? ArgumentException as exn -> exn.Message |> Error

    /// Gets the base type's value.
    let (|Value|) (baseType : IBaseType<_>) = baseType.Value
