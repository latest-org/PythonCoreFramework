﻿
// PythonCoreFramework.Net - UnitTests for correct handling of SyntaxError during parsing of Python Grammar.
// Written by Richard Magnor Stenbro. 

namespace PythonCoreFramework.UnitTests

open Xunit
open PythonCoreFramework


module TestPythonCoreParserSyntaxErrorHandling =

    [<Fact>]
    let ``Illegal atom UnitTest`` () =
        try
            let lex = new MockTokenizer( [ ( Token.Comma(0, 1, [| |]), 0 ); ( Token.EOF([| |]), 2 ); ] )
            lex.Next()
            let parser = new Parser(lex)
            parser.ParseAtom() |> ignore
        with
        |   :? SyntaxError as ex ->
                Assert.Equal( Token.Comma(0, 1, [| |]), ex.Data0)
                Assert.Equal( "Illegal literal!", ex.Data1)
        |   _ ->
                Assert.False(false)

    [<Fact>]
    let ``star expr UnitTest`` () =
        try
            let lex = new MockTokenizer( [ ( Token.Comma(0, 1, [| |]), 0 ); ( Token.EOF([| |]), 2 ); ] )
            lex.Next()
            let parser = new Parser(lex)
            parser.ParseStarExpr() |> ignore
        with
        |   :? SyntaxError as ex ->
                Assert.Equal( Token.Comma(0, 1, [| |]), ex.Data0)
                Assert.Equal( "Expecting '*' in expression!", ex.Data1)
        |   _ ->
                Assert.False(false)

