﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Text.Json
{
    public enum JsonToken
    {
        InvalidData,
        Eof,
        FalseLiteral,
        TrueLiteral,
        NullLiteral,
        String,
        Number,
        ObjectStart,
        ObjectEnd,
        ArrayStart,
        ArrayEnd,
        Comma,
        Colon,
        Comment
    }
}