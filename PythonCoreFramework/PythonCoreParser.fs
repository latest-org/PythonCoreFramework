﻿namespace PythonCoreFramework

type Trivia =
    |   Whitespace of char array
    |   Newline of char array
    |   Comment of char array

type Token =
    |   False of int * int * Trivia array
    |   None of int * int * Trivia array
    |   True of int * int * Trivia array
    |   And of int * int * Trivia array
    |   As of int * int * Trivia array
    |   Assert of int * int * Trivia array
    |   Async of int * int * Trivia array
    |   Await of int * int * Trivia array
    |   Break of int * int * Trivia array
    |   Class of int * int * Trivia array
    |   Continue of int * int * Trivia array
    |   Def of int * int * Trivia array
    |   Del of int * int * Trivia array
    |   Elif of int * int * Trivia array
    |   Else of int * int * Trivia array
    |   Except of int * int * Trivia array
    |   Finally of int * int * Trivia array
    |   For of int * int * Trivia array
    |   From of int * int * Trivia array
    |   Global of int * int * Trivia array
    |   If of int * int * Trivia array
    |   Import of int * int * Trivia array
    |   In of int * int * Trivia array
    |   Is of int * int * Trivia array
    |   Lambda of int * int * Trivia array
    |   Nonlocal of int * int * Trivia array
    |   Not of int * int * Trivia array
    |   Or of int * int * Trivia array
    |   Pass of int * int * Trivia array
    |   Raise of int * int * Trivia array
    |   Return of int * int * Trivia array
    |   Try of int * int * Trivia array
    |   While of int * int * Trivia array
    |   With of int * int * Trivia array
    |   Yield of int * int * Trivia array
    |   Plus of int * int * Trivia array
    |   Minus of int * int * Trivia array
    |   Mul of int * int * Trivia array
    |   Power of int * int * Trivia array
    |   Div of int * int * Trivia array
    |   FloorDiv of int * int * Trivia array
    |   Modulo of int * int * Trivia array
    |   Matrice of int * int * Trivia array
    |   ShiftLeft of int * int * Trivia array
    |   ShiftRight of int * int * Trivia array
    |   BitAnd of int * int * Trivia array
    |   BitOr of int * int * Trivia array
    |   BitXor of int * int * Trivia array
    |   BitInvert of int * int * Trivia array
    |   Less of int * int * Trivia array
    |   Greater of int * int * Trivia array
    |   LessEqual of int * int * Trivia array
    |   GreaterEqual of int * int * Trivia array
    |   Equal of int * int * Trivia array
    |   NotEqual of int * int * Trivia array
    |   LeftParen of int * int * Trivia array
    |   LeftBracket of int * int * Trivia array
    |   LeftCurly of int * int * Trivia array
    |   RightParen of int * int * Trivia array
    |   RightBracket of int * int * Trivia array
    |   RightCurly of int * int * Trivia array
    |   Comma of int * int * Trivia array
    |   Colon of int * int * Trivia array
    |   ColonAssign of int * int * Trivia array
    |   Dot of int * int * Trivia array
    |   Elipsis of int * int * Trivia array
    |   SemiColon of int * int * Trivia array
    |   Assign of int * int * Trivia array
    |   Ptr of int * int * Trivia array
    |   PlusAssign of int * int * Trivia array
    |   MinusAssign of int * int * Trivia array
    |   MulAssign of int * int * Trivia array
    |   PowerAssign of int * int * Trivia array
    |   DivAssign of int * int * Trivia array
    |   FloorDivAssign of int * int * Trivia array
    |   ModuloAssign of int * int * Trivia array
    |   BitAndAssign of int * int * Trivia array
    |   BitOrAssign of int * int * Trivia array
    |   BitXorAssign of int * int * Trivia array
    |   MatriceAssign of int * int * Trivia array
    |   ShiftLeftAssign of int * int * Trivia array
    |   ShiftRightAssign of int * int * Trivia array
    |   Name of int * int * string * Trivia array
    |   Number of int * int * string * Trivia array
    |   String of int * int * string array * Trivia array
    |   TypeComment of int * int * string
    |   Indent of Trivia array
    |   Dedent of Trivia array
    |   Newline of int * int * Trivia array
    |   EOF of Trivia array
    |   Empty

type ASTNode =
    |   SingleInput of int * int * ASTNode * Token
    |   FileInput of int * int * ASTNode array * Token array * Token
    |   EvalInput of int * int * ASTNode * Token array * Token
    |   Decorator of int * int *Token * ASTNode * Token * ASTNode * Token * Token
    |   Decorators of int * int * ASTNode array
    |   Decorated of int * int * ASTNode * ASTNode
    |   Class of int * int * Token * ASTNode * Token * ASTNode * Token * Token * ASTNode
    |   AsyncFuncDef of int * int * Token * ASTNode
    |   FuncDef of int * int * Token * ASTNode * ASTNode * Token * ASTNode * Token * ASTNode * ASTNode
    |   Parameters of int * int * Token * ASTNode * Token
    |   TypedArgsList of int * int * ASTNode array * Token array
    |   TypedAssign of int * int * ASTNode * ASTNode * Token * ASTNode
    |   TypedMul of int * int * Token * ASTNode
    |   TypedPower of int * int * Token * ASTNode
    |   TFPDef of int * int * ASTNode * Token * ASTNode
    |   VarArgsList of int * int * ASTNode array * Token array
    |   VarAssign of int * int * ASTNode * ASTNode * Token * ASTNode
    |   VarMul of int * int * Token * ASTNode
    |   VarPower of int * int * Token * ASTNode
    |   SimpleStmtList of int * int * ASTNode array * Token array * Token
    |   PlusAssign of int * int * ASTNode * Token * ASTNode
    |   MinusAssign of int * int * ASTNode * Token * ASTNode
    |   MulAssign of int * int * ASTNode * Token * ASTNode
    |   MatriceAssign of int * int * ASTNode * Token * ASTNode
    |   DivAssign of int * int * ASTNode * Token * ASTNode
    |   ModuloAssign of int * int * ASTNode * Token * ASTNode
    |   AndAssign of int * int * ASTNode * Token * ASTNode
    |   OrAssign of int * int * ASTNode * Token * ASTNode
    |   XorAssign of int * int * ASTNode * Token * ASTNode
    |   ShiftLeftAssign of int * int * ASTNode * Token * ASTNode
    |   ShiftRightAssign of int * int * ASTNode * Token * ASTNode
    |   PowerAssign of int * int * ASTNode * Token * ASTNode
    |   FloorDivAssign of int * int * ASTNode * Token * ASTNode
    |   AnnAssign of int * int * ASTNode * Token * ASTNode * Token * ASTNode
    |   Assign of int * int * ASTNode * Token * ASTNode
    |   Del of int * int * Token * ASTNode
    |   Pass of int * int * Token
    |   Break of int * int * Token
    |   Continue of int * int * Token
    |   Return of int * int * Token * ASTNode
    |   Raise of int * int * Token * ASTNode * Token * ASTNode
    |   Import of int * int *ASTNode
    |   ImportFrom of int * int * Token array * ASTNode * Token * Token * ASTNode * Token
    |   ImportAsName of int * int * ASTNode * Token * ASTNode
    |   DottedAsName of int * int * ASTNode * Token * ASTNode
    |   ImportAsNames of int * int * ASTNode array
    |   DottedAsNames of int * int *ASTNode array
    |   DottedName of int * int * ASTNode array
    |   Global of int * int * Token * ASTNode array * Token array
    |   Nonlocal of int * int * Token * ASTNode array * Token array
    |   Assert of int * int * Token * ASTNode * Token * ASTNode
    |   AsyncStmt of int * int * Token * ASTNode
    |   If of int * int * Token * ASTNode * Token * ASTNode * ASTNode array * ASTNode
    |   Elif of int * int * Token * ASTNode * Token * ASTNode
    |   Else of int * int * Token * Token * ASTNode
    |   While of int * int * Token * ASTNode * Token * ASTNode * ASTNode
    |   For of int * int * Token * ASTNode * Token * ASTNode * Token * Token * ASTNode * ASTNode
    |   Try of int * int * Token * Token * ASTNode * ASTNode array * ASTNode * ASTNode
    |   Finally of int * int * Token * Token * ASTNode
    |   With of int * int * Token * ASTNode array * Token * ASTNode * ASTNode
    |   WithItem of int * int * ASTNode * Token * ASTNode
    |   Except of int * int * Token * ASTNode * Token * ASTNode * Token * ASTNode
    |   Suite of int * int * Token * Token * ASTNode array * Token
    |   NamedExpr of int * int * ASTNode * Token * ASTNode
    |   Test of int * int * ASTNode * Token * ASTNode * Token * ASTNode
    |   Lambda of int * int * Token * ASTNode * Token * ASTNode
    |   OrTest of int * int * ASTNode * Token * ASTNode
    |   AndTest of int * int * ASTNode * Token * ASTNode
    |   NotTest of int * int * Token * ASTNode
    |   Less of int * int * ASTNode * Token * ASTNode
    |   LessEqual of int * int * ASTNode * Token * ASTNode
    |   Equal of int * int * ASTNode * Token * ASTNode
    |   GreaterEqual of int * int * ASTNode * Token * ASTNode
    |   Greater of int * int * ASTNode * Token * ASTNode
    |   NotEqual of int * int * ASTNode * Token * ASTNode
    |   Is of int * int * ASTNode * Token * ASTNode
    |   IsNot of int * int * ASTNode * Token * Token * ASTNode
    |   NotIn of int * int * ASTNode * Token * Token * ASTNode
    |   In of int * int * ASTNode * Token * ASTNode
    |   StarExpr of int * int * Token * ASTNode
    |   OrExpr of int * int * ASTNode * Token * ASTNode
    |   XorExpr of int * int * ASTNode * Token * ASTNode
    |   AndExpr of int * int * ASTNode * Token * ASTNode
    |   ShiftLeft of int * int * ASTNode * Token * ASTNode
    |   ShiftRight of int * int * ASTNode * Token * ASTNode
    |   Plus of int * int * ASTNode * Token * ASTNode
    |   Minus of int * int * ASTNode * Token * ASTNode
    |   Mul of int * int * ASTNode * Token * ASTNode
    |   Matrice of int * int * ASTNode * Token * ASTNode
    |   Div of int * int * ASTNode * Token * ASTNode
    |   Modulo of int * int * ASTNode * Token * ASTNode
    |   FloorDiv of int * int * ASTNode * Token * ASTNode
    |   UnaryPlus of int * int * Token * ASTNode
    |   UnaryMinus of int * int * Token * ASTNode
    |   UnaryInvert of int * int * Token * ASTNode
    |   Power of int * int * ASTNode * Token * ASTNode
    |   AtomExpr of int * int * Token * ASTNode * ASTNode array
    |   Name of int * int * Token
    |   Number of int * int * Token
    |   String of int * int * Token array
    |   Elipsis of int * int * Token
    |   None of int * int * Token
    |   True of int * int * Token
    |   False of int * int * Token
    |   Tuple of int * int * Token * ASTNode * Token
    |   List of int * int * Token * ASTNode * Token
    |   Dictionary of int * int * Token * ASTNode array * Token array * Token
    |   Set of int * int * Token * ASTNode array * Token array * Token
    |   Call of int * int * Token * ASTNode * Token
    |   Index of int * int * Token * ASTNode * Token
    |   DotName of int * int * Token * ASTNode
    |   SubscriptList of int * int * ASTNode array * Token array
    |   Subscript of int * int * ASTNode * Token * ASTNode * Token * ASTNode
    |   ExprList of int * int * ASTNode array * Token array
    |   TestList of int * int * ASTNode array * Token array
    |   DictionaryEntry of int * int * ASTNode * Token * ASTNode
    |   SetEntry of int * int * ASTNode
    |   ArgumentList of int * int * ASTNode array * Token array
    |   Argument of int * int * ASTNode * Token * ASTNode
    |   SyncCompFor of int * int * Token * ASTNode * Token * ASTNode * ASTNode
    |   CompFor of int * int * Token * ASTNode
    |   CompIf of int * int * Token * ASTNode * ASTNode
    |   YieldExpr of int * int * Token * ASTNode
    |   YieldFromExpr of int * int * Token * Token * ASTNode
    |   FuncBodySuite of int * int * Token * ASTNode * Token * Token * ASTNode array * Token
    |   FuncTypeInput of int * int * ASTNode * Token * Token
    |   FuncType of int * int * Token * ASTNode * Token * Token * ASTNode
    |   TypeList of int * int * ASTNode array * Token array
    |   TypeListStar of int * int * Token * ASTNode
    |   TypeListPower of int * int * Token * ASTNode
    |   Empty 

exception SyntaxError of Token * string

type Tokenizer() =
    
    member val Symbol = Token.Empty with get, set
    member val Position = 0 with get, set

    member public this.Advance() =
        ()
    


type Parser(lexer : Tokenizer) =
    
    member val Lexer = lexer with get, set
    member val FlowLevel = 0 with get, set
    member val FuncFlowLevel = 0 with get, set


    member this.ParseVarArgsList() =
        ASTNode.Empty


    // Statement rules in Python 3.9 grammar //////////////////////////////////////////////////////
    
    member this.ParseCompoundStmt() =
        match this.Lexer.Symbol with
        |   Token.If _ -> this.ParseIfStmt()
        |   Token.While _ -> this.ParseWhileStmt()
        |   Token.For _ -> this.ParseForStmt()
        |   Token.Try _ -> this.ParseTryStmt()
        |   Token.With _ -> this.ParseWithStmt()
        |   Token.Def _
        |   Token.Class _
        |   Token.Matrice _
        |   Token.Async _ -> this.ParseAsyncStmt()
        |   _ -> raise ( SyntaxError(this.Lexer.Symbol, "Unexpected statement!") )

    member this.ParseAsyncStmt() =
        ASTNode.Empty

    member this.ParseIfStmt() =
        let startPos = this.Lexer.Position
        match this.Lexer.Symbol with
        |   Token.If _ ->
                let op1 = this.Lexer.Symbol
                this.Lexer.Advance()
                let left = this.ParseNamedExpr()
                match this.Lexer.Symbol with
                |   Token.Colon _ ->
                        let op2 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseSuite()
                        let mutable nodes : ASTNode list = []
                        while   match this.Lexer.Symbol with
                                |   Token.Elif _ ->
                                        let start2 = this.Lexer.Position
                                        let op3 = this.Lexer.Symbol
                                        this.Lexer.Advance()
                                        let left2 = this.ParseNamedExpr()
                                        match this.Lexer.Symbol with
                                        |   Token.Colon _ ->
                                                let op4 = this.Lexer.Symbol
                                                this.Lexer.Advance()
                                                let right2 = this.ParseSuite()
                                                nodes <- ASTNode.Elif(start2, this.Lexer.Position, op3, left2, op4, right2) :: nodes
                                        |   _   ->
                                                raise ( SyntaxError(this.Lexer.Symbol, "Missing ':' in elif statement!") )
                                        true
                                |   _   ->  
                                        false
                            do ()
                        match this.Lexer.Symbol with
                        |   Token.Else _    ->
                                let start3 = this.Lexer.Position
                                let op5 = this.Lexer.Symbol
                                this.Lexer.Advance()
                                match this.Lexer.Symbol with
                                |   Token.Colon _ ->
                                        let op6 = this.Lexer.Symbol
                                        this.Lexer.Advance()
                                        let right3 = this.ParseSuite()
                                        let node = ASTNode.Else(start3, this.Lexer.Position, op5, op6, right3)
                                        ASTNode.If(startPos, this.Lexer.Position, op1, left, op2, right, List.toArray(List.rev nodes), node)
                                |   _ ->
                                        raise ( SyntaxError(this.Lexer.Symbol, "Expected ':' in else statement!") )
                        |   _   ->
                                ASTNode.If(startPos, this.Lexer.Position, op1, left, op2, right, List.toArray(List.rev nodes), ASTNode.Empty)
                |   _ -> 
                        raise ( SyntaxError(this.Lexer.Symbol, "Expecting ':' in if statement!") )
        |   _   ->
                raise ( SyntaxError(this.Lexer.Symbol, "Expecting 'if' statement!") )

    member this.ParseWhileStmt() =
        let startPos = this.Lexer.Position
        match this.Lexer.Symbol with
        |   Token.While _ ->
                let op1 = this.Lexer.Symbol
                this.Lexer.Advance()
                let left = this.ParseNamedExpr()
                match this.Lexer.Symbol with
                |   Token.Colon _ ->
                        let op2 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseSuite()
                        match this.Lexer.Symbol with
                        |   Token.Else _ ->
                                let start2 = this.Lexer.Position
                                let op3 = this.Lexer.Symbol
                                this.Lexer.Advance()
                                match this.Lexer.Symbol with
                                |   Token.Colon _ ->
                                        let op4 = this.Lexer.Symbol
                                        this.Lexer.Advance()
                                        let right2 = this.ParseSuite()
                                        let node = ASTNode.Else(start2, this.Lexer.Position, op3, op4, right2)
                                        ASTNode.While(startPos, this.Lexer.Position, op1, left, op2, right, node)
                                |   _ ->
                                        raise ( SyntaxError(this.Lexer.Symbol, "Expected ':' in else statement!") )
                        |   _ ->
                                ASTNode.While(startPos, this.Lexer.Position, op1, left, op2, right, ASTNode.Empty)
                |   _ ->
                        raise ( SyntaxError(this.Lexer.Symbol, "Missing ':' in while statement!") )
        |   _ ->
                raise ( SyntaxError(this.Lexer.Symbol, "Expected 'while' statement!") )

    member this.ParseForStmt() =
        let startPos = this.Lexer.Position
        match this.Lexer.Symbol with
        |   Token.For _ ->
                let op1 = this.Lexer.Symbol
                this.Lexer.Advance()
                let left = this.ParseExprList()
                match this.Lexer.Symbol with
                |   Token.In _ ->
                        let op2 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseTestList()
                        match this.Lexer.Symbol with
                        |   Token.Colon _ ->
                                let op3 = this.Lexer.Symbol
                                this.Lexer.Advance()
                                let op4 =   match this.Lexer.Symbol with
                                            |   Token.TypeComment _ ->
                                                    let tmpOp = this.Lexer.Symbol
                                                    this.Lexer.Advance()
                                                    tmpOp
                                            |   _   ->
                                                    Token.Empty
                                let next = this.ParseSuite()
                                match this.Lexer.Symbol with
                                |   Token.Else _ ->
                                        let start2 = this.Lexer.Position
                                        let op5 = this.Lexer.Symbol
                                        this.Lexer.Advance()
                                        match this.Lexer.Symbol with
                                        |   Token.Colon _ ->
                                                let op6 = this.Lexer.Symbol
                                                this.Lexer.Advance()
                                                let right2 = this.ParseSuite()
                                                let node = ASTNode.Else(start2, this.Lexer.Position, op5, op6, right2)
                                                ASTNode.For(startPos, this.Lexer.Position, op1, left, op2, right, op3, op4, next, node)
                                        |   _ ->
                                                raise ( SyntaxError(this.Lexer.Symbol, "Expected ':' in else statement!") )
                                |   _   ->
                                        ASTNode.For(startPos, this.Lexer.Position, op1, left, op2, right, op3, op4, next, ASTNode.Empty)
                        |   _   ->
                                raise ( SyntaxError(this.Lexer.Symbol, "Expected ':' in for statement!") )
                |   _   ->
                        raise ( SyntaxError(this.Lexer.Symbol, "Expected 'in' in for statement!") )
        |   _   ->
                raise ( SyntaxError(this.Lexer.Symbol, "Expecting 'for' statement!") )

    member this.ParseTryStmt() =
        let startPos = this.Lexer.Position
        ASTNode.Empty

    member this.ParseWithStmt() =
        let startPos = this.Lexer.Position
        ASTNode.Empty

    member this.ParseWithItem() =
        let startPos = this.Lexer.Position
        ASTNode.Empty

    member this.ParseExceptClause() =
        let startPos = this.Lexer.Position
        ASTNode.Empty

    member this.ParseSuite() =
        let startPos = this.Lexer.Position
        ASTNode.Empty

    // Expression rules in Python 3.9 grammar /////////////////////////////////////////////////////

    member this.ParseNamedExpr() =
        let startPos = this.Lexer.Position
        let left = this.ParseTest()
        match this.Lexer.Symbol with
        |   Token.ColonAssign _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                let right = this.ParseTest();
                ASTNode.NamedExpr(startPos, this.Lexer.Position, left, op, right)
        |   _   ->  left

    member this.ParseTest() =
        match this.Lexer.Symbol with
        |   Token.Lambda _ ->   this.ParseLambda()
        |   _   ->
                let startPos = this.Lexer.Position
                let left = this.ParseOrTest()
                match this.Lexer.Symbol with
                |   Token.If _ ->
                        let op1 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseOrTest()
                        match this.Lexer.Symbol with
                        |   Token.Else _ ->
                                let op2 = this.Lexer.Symbol
                                this.Lexer.Advance()
                                let next = this.ParseTest()
                                ASTNode.Test(startPos, this.Lexer.Position, left, op1, right , op2, next)
                        |   _   ->
                                raise ( SyntaxError(this.Lexer.Symbol, "Expected 'else' in test expression!") )
                |   _   ->
                        left

    member this.ParseTestNoCond() =
        match this.Lexer.Symbol with | Token.Lambda _ -> this.ParseLambda(false) | _ -> this.ParseOrTest()

    member this.ParseLambda(?isCond : bool) =
        let conditional = match isCond with Some x -> x | _ -> true
        match this.Lexer.Symbol with
        |   Token.Lambda _ ->
                let startPos = this.Lexer.Position
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                let left =  match this.Lexer.Symbol with
                            |   Token.Colon _ ->
                                    ASTNode.Empty
                            |   _   ->
                                    this.ParseVarArgsList()
                let op2 =   match this.Lexer.Symbol with
                            |   Token.Colon _ ->
                                    let tmpOp = this.Lexer.Symbol
                                    this.Lexer.Advance()
                                    tmpOp
                            |   _ ->    raise ( SyntaxError(this.Lexer.Symbol, "Expected ':' in lambda expression!") )
                let right = match conditional with
                            |   true ->
                                    this.ParseTest()
                            |   _   ->
                                    this.ParseTestNoCond()
                ASTNode.Lambda(startPos, this.Lexer.Position, op, left, op2, right)
        |   _   ->
                raise ( SyntaxError(this.Lexer.Symbol, "Expected 'lambda' in lambda expression!") )

    member this.ParseOrTest() =
        let startPos = this.Lexer.Position
        let mutable res = this.ParseAndTest()
        while   match this.Lexer.Symbol with
                |   Token.Or _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseAndTest()
                        res <- ASTNode.OrTest(startPos, this.Lexer.Position, res, op, right)
                        true
                |   _   ->  false
            do ()
        res

    member this.ParseAndTest() =
        let startPos = this.Lexer.Position
        let mutable res = this.ParseNotTest()
        while   match this.Lexer.Symbol with
                |   Token.And _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseNotTest()
                        res <- ASTNode.AndTest(startPos, this.Lexer.Position, res, op, right)
                        true
                |   _   ->  false
            do ()
        res

    member this.ParseNotTest() =
        let startPos = this.Lexer.Position
        match this.Lexer.Symbol with
        |   Token.Not _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                let right = this.ParseNotTest()
                ASTNode.NotTest(startPos, this.Lexer.Position, op, right)
        |   _   ->  this.ParseComparison()

    member this.ParseComparison() =
        let startPos = this.Lexer.Position
        let mutable res = this.ParseExpr()
        while   match lexer.Symbol with
                |   Token.Less _ ->
                        let op = lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseExpr()
                        res <- ASTNode.Less(startPos, this.Lexer.Position, res, op, right)
                        true
                |   Token.LessEqual _   ->
                        let op = lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseExpr()
                        res <- ASTNode.LessEqual(startPos, this.Lexer.Position, res, op, right)
                        true
                |   Token.Equal _ ->
                        let op = lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseExpr()
                        res <- ASTNode.Equal(startPos, this.Lexer.Position, res, op, right)
                        true
                |   Token.GreaterEqual _ ->
                        let op = lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseExpr()
                        res <- ASTNode.GreaterEqual(startPos, this.Lexer.Position, res, op, right)
                        true
                |   Token.Greater _ ->
                        let op = lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseExpr()
                        res <- ASTNode.Greater(startPos, this.Lexer.Position, res, op, right)
                        true
                |   Token.NotEqual _ ->
                        let op = lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseExpr()
                        res <- ASTNode.NotEqual(startPos, this.Lexer.Position, res, op, right)
                        true
                |   Token.In _ ->
                        let op = lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseExpr()
                        res <- ASTNode.In(startPos, this.Lexer.Position, res, op, right)
                        true
                |   Token.Not _ ->
                        let op1 = lexer.Symbol
                        this.Lexer.Advance()
                        match lexer.Symbol with
                        |   Token.In _ ->
                                let op2 = this.Lexer.Symbol
                                this.Lexer.Advance()
                                let right = this.ParseExpr()
                                res <- ASTNode.NotIn(startPos, this.Lexer.Position, res, op1, op2, right)
                        |   _   ->  raise ( SyntaxError(this.Lexer.Symbol, "Missing 'in' in 'not in ' expression!") )
                        true
                |   Token.Is _ ->
                        let op1 = lexer.Symbol
                        this.Lexer.Advance()
                        match lexer.Symbol with
                        |   Token.Not _ ->
                                let op2 = this.Lexer.Symbol
                                this.Lexer.Advance()
                                let right = this.ParseExpr()
                                res <- ASTNode.IsNot(startPos, this.Lexer.Position, res, op1, op2, right)
                        |   _   ->
                                let right = this.ParseExpr()
                                res <- ASTNode.Is(startPos, this.Lexer.Position, res, op1, right)
                        true
                |   _   ->  false
            do ()
        res

    member this.ParseStarExpr() =
        let startPos = this.Lexer.Position
        match this.Lexer.Symbol with
        |   Token.Mul _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                let right = this.ParseExpr()
                ASTNode.StarExpr(startPos, this.Lexer.Position, op, right)
        |   _   ->  raise ( SyntaxError(this.Lexer.Symbol, "Expecting '*' in expression!") )

    member this.ParseExpr() =
        let startPos = this.Lexer.Position
        let mutable res = this.ParseXorExpr()
        while   match this.Lexer.Symbol with
                |   Token.BitOr _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseXorExpr()
                        res <- ASTNode.OrExpr(startPos, this.Lexer.Position, res, op, right)
                        true
                |   _   ->  false
            do ()
        res

    member this.ParseXorExpr() =
        let startPos = this.Lexer.Position
        let mutable res = this.ParseAndExpr()
        while   match this.Lexer.Symbol with
                |   Token.BitXor _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseAndExpr()
                        res <- ASTNode.XorExpr(startPos, this.Lexer.Position, res, op, right)
                        true
                |   _   ->  false
            do ()
        res

    member this.ParseAndExpr() =
        let startPos = this.Lexer.Position
        let mutable res = this.ParseShiftExpr()
        while   match this.Lexer.Symbol with
                |   Token.BitAnd _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseShiftExpr()
                        res <- ASTNode.AndExpr(startPos, this.Lexer.Position, res, op, right)
                        true
                |   _   ->  false
            do ()
        res

    member this.ParseShiftExpr() =
        let startPos = this.Lexer.Position
        let mutable res = this.ParseArithExpr()
        while   match this.Lexer.Symbol with
                |   Token.ShiftLeft _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseArithExpr()
                        res <- ASTNode.ShiftLeft(startPos, this.Lexer.Position, res, op, right)
                        true
                |   Token.ShiftRight _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseArithExpr()
                        res <- ASTNode.ShiftRight(startPos, this.Lexer.Position, res, op, right)
                        true
                |   _   ->  false
            do ()
        res

    member this.ParseArithExpr() =
        let startPos = this.Lexer.Position
        let mutable res = this.ParseTerm()
        while   match this.Lexer.Symbol with
                |   Token.Plus _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseTerm()
                        res <- ASTNode.Plus(startPos, this.Lexer.Position, res, op, right)
                        true
                |   Token.Minus _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseTerm()
                        res <- ASTNode.Minus(startPos, this.Lexer.Position, res, op, right)
                        true
                |   _   ->  false
            do ()
        res

    member this.ParseTerm() =
        let startPos = this.Lexer.Position
        let mutable res = this.ParseFactor()
        while   match this.Lexer.Symbol with
                |   Token.Mul _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseFactor()
                        res <- ASTNode.Mul(startPos, this.Lexer.Position, res, op, right)
                        true
                |   Token.Div _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseFactor()
                        res <- ASTNode.Div(startPos, this.Lexer.Position, res, op, right)
                        true
                |   Token.Matrice _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseFactor()
                        res <- ASTNode.Matrice(startPos, this.Lexer.Position, res, op, right)
                        true
                |   Token.Modulo _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseFactor()
                        res <- ASTNode.Modulo(startPos, this.Lexer.Position, res, op, right)
                        true
                |   Token.FloorDiv _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseFactor()
                        res <- ASTNode.FloorDiv(startPos, this.Lexer.Position, res, op, right)
                        true
                |   _   ->  false
            do ()
        res

    member this.ParseFactor() =
        let startPos = this.Lexer.Position
        match this.Lexer.Symbol with
        |   Token.Plus _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                let right = this.ParseFactor()
                ASTNode.UnaryPlus(startPos, this.Lexer.Position, op, right)
        |   Token.Minus _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                let right = this.ParseFactor()
                ASTNode.UnaryMinus(startPos, this.Lexer.Position, op, right)
        |   Token.BitInvert _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                let right = this.ParseFactor()
                ASTNode.UnaryInvert(startPos, this.Lexer.Position, op, right)
        |   _   ->  this.ParsePower();

    member this.ParsePower() =
        let startPos = this.Lexer.Position
        let mutable res = this.ParseAtomExpr()
        while   match this.Lexer.Symbol with
                |   Token.Power _ ->
                        let op = this.Lexer.Symbol;
                        this.Lexer.Advance()
                        let right = this.ParseFactor()
                        res <- ASTNode.Power(startPos, this.Lexer.Position, res, op, right)
                        true
                |   _   ->  false
            do ()
        res

    member this.ParseAtomExpr() =
        let startPos = this.Lexer.Position
        let op = match this.Lexer.Symbol with
                 |  Token.Async _ ->
                        let tmpOp = this.Lexer.Symbol
                        this.Lexer.Advance()
                        tmpOp
                 |   _   ->  Token.Empty
        let right = this.ParseAtom()
        let mutable nodes : ASTNode list = []
        while   match this.Lexer.Symbol with
                |   Token.LeftParen _ 
                |   Token.LeftBracket _ 
                |   Token.Dot _ ->
                        nodes <- this.ParseTrailer() :: nodes
                        true
                |   _   ->  false
            do ()
        match op, nodes with
        |   Token.Empty, [] ->
                right
        |   _   ->
                ASTNode.AtomExpr(startPos, this.Lexer.Position, op, right, List.toArray( List.rev nodes ))

    member this.ParseAtom() =
        let startPos = this.Lexer.Position
        match this.Lexer.Symbol with
        |   Token.Name _    ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                ASTNode.Name(startPos, this.Lexer.Position, op)
        |   Token.Number _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                ASTNode.Number(startPos, this.Lexer.Position, op)
        |   Token.String _  ->
                let mutable nodes : Token list = []
                while   match this.Lexer.Symbol with
                        |   Token.String _ ->
                                nodes <- this.Lexer.Symbol :: nodes
                                this.Lexer.Advance()
                                true
                        |   _   -> false
                    do ()
                ASTNode.String(startPos, this.Lexer.Position, List.toArray( List.rev nodes ))
        |   Token.Elipsis _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                ASTNode.Elipsis(startPos, this.Lexer.Position, op)
        |   Token.None _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                ASTNode.None(startPos, this.Lexer.Position, op)
        |   Token.True _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                ASTNode.True(startPos, this.Lexer.Position, op)
        |   Token.False _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                ASTNode.False(startPos, this.Lexer.Position, op)
        |   Token.LeftParen _   ->
                let op1 = this.Lexer.Symbol
                this.Lexer.Advance()
                match this.Lexer.Symbol with
                |   Token.RightParen _ ->
                        let op2 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        ASTNode.Call(startPos, this.Lexer.Position, op1, ASTNode.Empty, op2)
                |   _ ->
                        let node =  match this.Lexer.Symbol with
                                    |   Token.Yield _   ->  this.ParseYieldExpr()
                                    |   _   ->  this.ParseTestListComp()
                        match this.Lexer.Symbol with
                        |   Token.RightParen _  ->
                                let op2 = this.Lexer.Symbol
                                this.Lexer.Advance()
                                ASTNode.Call(startPos, this.Lexer.Position, op1, node, op2)
                        |   _   ->
                                raise ( SyntaxError(this.Lexer.Symbol, "Missing ')' in expression!") )
        |   Token.LeftBracket _ ->
                let op1 = this.Lexer.Symbol
                this.Lexer.Advance()
                match this.Lexer.Symbol with
                |   Token.RightBracket _ ->
                        let op2 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        ASTNode.Call(startPos, this.Lexer.Position, op1, ASTNode.Empty, op2)
                |   _ ->
                        let node = this.ParseTestListComp()
                        match this.Lexer.Symbol with
                        |   Token.RightBracket _  ->
                                let op2 = this.Lexer.Symbol
                                this.Lexer.Advance()
                                ASTNode.Index(startPos, this.Lexer.Position, op1, node, op2)
                        |   _   ->
                                raise ( SyntaxError(this.Lexer.Symbol, "Missing ']' in expression!") )
        |   Token.LeftCurly _   ->
                let mutable nodes : ASTNode list = []
                let mutable ops : Token list = []
                let op1 = this.Lexer.Symbol
                this.Lexer.Advance()
                match this.Lexer.Symbol with
                |   Token.RightCurly _ ->
                        let op2 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        ASTNode.Dictionary(startPos, this.Lexer.Position, op1, [| |], [| |], op2)
                |   _   ->
                        let a, b, c = this.ParseDictorSetMaker() // a = nodes, b = commas, c = isSet 
                        match this.Lexer.Symbol with
                        |   Token.RightCurly _ ->
                                let op2 = this.Lexer.Symbol
                                this.Lexer.Advance()
                                match c with
                                |   true    ->
                                        ASTNode.Set(startPos, this.Lexer.Position, op1, List.toArray(List.rev a), List.toArray(List.rev b), op2)
                                |   _ ->
                                        ASTNode.Dictionary(startPos, this.Lexer.Position, op1, List.toArray(List.rev a), List.toArray(List.rev b), op2)
                        |   _   ->
                                raise ( SyntaxError(this.Lexer.Symbol, "Missing '} in dictionary!") )
        |   _   ->
                raise ( SyntaxError(this.Lexer.Symbol, "Illegal literal!") )

    member this.ParseTestListComp() =
        let startPos = this.Lexer.Position
        let mutable nodes : ASTNode list = []
        let mutable ops : Token list = []
        nodes <- ( match this.Lexer.Symbol with | Token.Mul _ -> this.ParseStarExpr() | _ -> this.ParseTest() ) :: nodes
        match this.Lexer.Symbol with
        |   Token.Async _ 
        |   Token.For _ ->
                nodes <- this.ParseCompFor() :: nodes
        |   _   ->
                while   match this.Lexer.Symbol with
                        |   Token.Comma _   ->  
                                ops <- this.Lexer.Symbol :: ops
                                this.Lexer.Advance()
                                match this.Lexer.Symbol with
                                |   Token.RightParen _
                                |   Token.RightBracket _ -> ()
                                |   _   ->
                                        nodes <- ( match this.Lexer.Symbol with | Token.Mul _ -> this.ParseStarExpr() | _ -> this.ParseTest() ) :: nodes
                                true
                        |   _   -> false
                    do ()
        ASTNode.TestList(startPos, this.Lexer.Position, List.toArray(List.rev nodes), List.toArray(List.rev ops))

    member this.ParseTrailer() =
        let startPos = this.Lexer.Position
        match this.Lexer.Symbol with
        |   Token.LeftParen _   ->
                let op1 = this.Lexer.Symbol
                this.Lexer.Advance()
                let right = match this.Lexer.Symbol with
                            |   Token.RightParen _ ->
                                    ASTNode.Empty
                            |   _   ->
                                    this.ParseArgsList()
                match this.Lexer.Symbol with
                |   Token.RightParen _  ->
                        let op2 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        ASTNode.Call(startPos, this.Lexer.Position, op1, right, op2)
                |   _   ->  raise ( SyntaxError(this.Lexer.Symbol, "") )
        |   Token.LeftBracket _ ->
                let op1 = this.Lexer.Symbol
                this.Lexer.Advance()
                let right = match this.Lexer.Symbol with
                            |   Token.RightBracket _ ->
                                    ASTNode.Empty
                            |   _   ->
                                    this.ParseSubscriptList()
                match this.Lexer.Symbol with
                |   Token.RightBracket _  ->
                        let op2 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        ASTNode.Index(startPos, this.Lexer.Position, op1, right, op2)
                |   _   ->  raise ( SyntaxError(this.Lexer.Symbol, "") )
        |   Token.Dot _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                match this.Lexer.Symbol with
                |   Token.Name _    ->
                        let op2 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        ASTNode.DotName(startPos, this.Lexer.Position, op, ASTNode.Name(startPos, this.Lexer.Position, op2))
                |   _   ->  raise ( SyntaxError(this.Lexer.Symbol, "Expecting name literal after '.'") )
        |   _   ->  raise ( SyntaxError(this.Lexer.Symbol, "Expected '(', '[' or '.' in trailer expression!") )
    
    member this.ParseSubscriptList() =
        let startPos = this.Lexer.Position
        let mutable nodes : ASTNode list = []
        let mutable ops : Token list = []
        nodes <- this.ParseSubscript() :: nodes
        while   match this.Lexer.Symbol with
                |   Token.Comma _ ->
                        ops <- this.Lexer.Symbol :: ops
                        this.Lexer.Advance()
                        match this.Lexer.Symbol with
                        |   Token.RightBracket _    ->  ()
                        |   _   ->
                                nodes <- this.ParseSubscript() :: nodes
                        true
                |   _   ->  false
            do ()
        ASTNode.SubscriptList(startPos, this.Lexer.Position, List.toArray( List.rev nodes ), List.toArray( List.rev ops ))

    member this.ParseSubscript() =
        let startPos = this.Lexer.Position
        let left =  match this.Lexer.Symbol with
                    |   Token.Colon _ ->    ASTNode.Empty
                    |   Token.Comma _
                    |   Token.RightBracket _ ->   raise ( SyntaxError(this.Lexer.Symbol, "Missing subscript item!") )
                    |   _   ->  this.ParseTest()
        match this.Lexer.Symbol with
        |   Token.Colon _ ->
                let op1 = this.Lexer.Symbol
                this.Lexer.Advance()
                let right = match this.Lexer.Symbol with
                            |   Token.RightParen _
                            |   Token.Comma _
                            |   Token.Colon _   ->  ASTNode.Empty
                            |   _   ->  this.ParseTest()
                match this.Lexer.Symbol with
                |   Token.Colon _ ->
                        let op2 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        match this.Lexer.Symbol with
                        |   Token.RightBracket _
                        |   Token.Comma _ ->
                                ASTNode.Subscript(startPos, this.Lexer.Position, left, op1, right, op2, ASTNode.Empty)
                        |   _   ->
                                let next = this.ParseTest()
                                ASTNode.Subscript(startPos, this.Lexer.Position, left, op1, right, op2, next)
                |   _   ->
                        ASTNode.Subscript(startPos, this.Lexer.Position, left, op1, right, Token.Empty, ASTNode.Empty)
        |   _   ->
            ASTNode.Subscript(startPos, this.Lexer.Position, left, Token.Empty, ASTNode.Empty, Token.Empty, ASTNode.Empty)

    member this.ParseExprList() =
        let startPos = this.Lexer.Position
        let mutable nodes : ASTNode list = []
        let mutable ops : Token list = []
        nodes <- ( match this.Lexer.Symbol with | Token.Mul _ -> this.ParseStarExpr() | _ -> this.ParseTest() ) :: nodes
        while   match this.Lexer.Symbol with
                |   Token.Comma _ ->
                        ops <- this.Lexer.Symbol :: ops
                        this.Lexer.Advance()
                        match this.Lexer.Symbol with
                        |   Token.In _  ->  ()
                        |   _   ->
                                nodes <- ( match this.Lexer.Symbol with | Token.Mul _ -> this.ParseStarExpr() | _ -> this.ParseTest() ) :: nodes
                        true
                |   _   ->  false
            do ()
        ASTNode.ExprList(startPos, this.Lexer.Position, List.toArray(List.rev nodes), List.toArray(List.rev ops))

    member this.ParseTestList() =
        let startPos = this.Lexer.Position
        let mutable nodes : ASTNode list = []
        let mutable ops : Token list = []
        nodes <- this.ParseTest() :: nodes
        while   match this.Lexer.Symbol with
                |   Token.Comma _   ->
                        ops <- this.Lexer.Symbol :: ops
                        match this.Lexer.Symbol with
                        |   Token.SemiColon _
                        |   Token.Newline _     ->  false
                        |   _   ->
                                nodes <- this.ParseTest() :: nodes
                                true
                |   _   ->  false
            do ()
        ASTNode.TestList(startPos, this.Lexer.Position, List.toArray(List.rev nodes), List.toArray(List.rev ops))

    member this.ParseDictorSetMaker() : ASTNode list * Token list * bool =
        let startPos = this.Lexer.Position
        let mutable nodes : ASTNode list = []
        let mutable ops : Token list = []
        let mutable isSet = true
        match this.Lexer.Symbol with
        |   Token.Mul _ ->
                let right = this.ParseStarExpr()
                nodes <- ASTNode.SetEntry(startPos, this.Lexer.Position, right) :: nodes
        |   Token.Power _   ->
                let op1 = this.Lexer.Symbol
                this.Lexer.Advance()
                let right = this.ParseExpr()
                isSet <- false
                nodes <- ASTNode.DictionaryEntry(startPos, this.Lexer.Position, ASTNode.Empty, op1, right) :: nodes
        |   _   ->
                let left = this.ParseTest()
                match this.Lexer.Symbol with
                |   Token.Colon _   ->
                        let op1 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseTest()
                        isSet <- false
                        nodes <- ASTNode.DictionaryEntry(startPos, this.Lexer.Position, left, op1, right) :: nodes
                |   _   ->
                        nodes <- ASTNode.SetEntry(startPos, this.Lexer.Position, left) :: nodes
        match this.Lexer.Symbol with
        |   Token.Async _
        |   Token.For _ ->
                let right = this.ParseCompIter()
                match isSet with
                |   true    ->
                        nodes <- ASTNode.SetEntry(startPos, this.Lexer.Position, right) :: nodes
                |   _   ->
                        nodes <- ASTNode.DictionaryEntry(startPos, this.Lexer.Position, ASTNode.Empty, Token.Empty, right) :: nodes
        |   _   ->  
                while   match this.Lexer.Symbol with
                        |   Token.Comma _   ->
                                ops <- this.Lexer.Symbol :: ops
                                this.Lexer.Advance()
                                match this.Lexer.Symbol with
                                |   Token.RightCurly _ ->
                                        false
                                |   _   ->
                                        match isSet with
                                        |   true    ->
                                                match this.Lexer.Symbol with
                                                |   Token.Mul _ ->
                                                        let right = this.ParseStarExpr()
                                                        nodes <- ASTNode.SetEntry(startPos, this.Lexer.Position, right) :: nodes
                                                        true
                                                |   _   ->  
                                                        let right = this.ParseTest()
                                                        nodes <- ASTNode.SetEntry(startPos, this.Lexer.Position, right) :: nodes
                                                        true
                                        |   _   ->
                                                match this.Lexer.Symbol with
                                                |   Token.Power _   ->
                                                        let op1 = this.Lexer.Symbol
                                                        this.Lexer.Advance()
                                                        let right = this.ParseExpr()
                                                        nodes <- ASTNode.DictionaryEntry(startPos, this.Lexer.Position, ASTNode.Empty, op1, right) :: nodes
                                                        true
                                                |   _   ->
                                                        let left = this.ParseTest()
                                                        match this.Lexer.Symbol with
                                                        |   Token.Colon _ ->
                                                                let op1 = this.Lexer.Symbol
                                                                this.Lexer.Advance()
                                                                let right = this.ParseTest()
                                                                nodes <- ASTNode.DictionaryEntry(startPos, this.Lexer.Position, left, op1, right) :: nodes
                                                                true
                                                        |   _   ->
                                                                raise ( SyntaxError(this.Lexer.Symbol, "Missing ':' in dictionary entry!") )
                        |   _   ->
                                false
                    do ()
        ( nodes, ops, isSet )

    member this.ParseArgsList() =
        let startPos = this.Lexer.Position
        let mutable nodes : ASTNode list = []
        let mutable ops : Token list = []
        nodes <- this.ParseArgument() :: nodes
        while   match this.Lexer.Symbol with
                |   Token.Comma _   ->
                        ops <- this.Lexer.Symbol :: ops
                        match this.Lexer.Symbol with
                        |   Token.RightParen _ ->   false
                        |   _   ->
                                nodes <- this.ParseArgument() :: nodes
                                true
                |   _   ->  false
            do ()
        ASTNode.ArgumentList(startPos, this.Lexer.Position, List.toArray(List.rev nodes), List.toArray(List.rev ops))

    member this.ParseArgument() =
        let startPos = this.Lexer.Position
        match this.Lexer.Symbol with
        |   Token.Mul _ 
        |   Token.Power _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                match this.Lexer.Symbol with
                |   Token.Name _    ->
                        let name = this.Lexer.Symbol
                        this.Lexer.Advance()
                        ASTNode.Argument(startPos, this.Lexer.Position, ASTNode.Empty, op, ASTNode.Name(startPos, this.Lexer.Position, name))
                |   _   ->  raise ( SyntaxError(this.Lexer.Symbol, "Missing argument!") )     
        |   Token.Name _    ->
                let name = this.Lexer.Symbol
                this.Lexer.Advance()
                let left = ASTNode.Name(startPos, this.Lexer.Position, name)
                match this.Lexer.Symbol with
                |   Token.Async _
                |   Token.For _ ->
                        let right = this.ParseCompFor()
                        ASTNode.Argument(startPos, this.Lexer.Position, left, Token.Empty, right)
                |   Token.ColonAssign _
                |   Token.Assign _   ->
                        let op = this.Lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseTest()
                        ASTNode.Argument(startPos, this.Lexer.Position, left, op, right)
                |   _   ->
                        ASTNode.Argument(startPos, this.Lexer.Position, left, Token.Empty, ASTNode.Empty)
        |   _   ->  raise ( SyntaxError(this.Lexer.Symbol, "Missing argument!") ) 
                
    member this.ParseCompIter() =
        match this.Lexer.Symbol with
        |   Token.Async _
        |   Token.For _     ->
                this.ParseCompFor()
        |   _   ->
                this.ParseCompIf()

    member this.ParseCompFor() =
        let startPos = this.Lexer.Position
        match this.Lexer.Symbol with
        |   Token.Async _ ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                let right = this.ParseSyncCompFor()
                ASTNode.CompFor(startPos, this.Lexer.Position, op, right)
        |   _   ->
                this.ParseSyncCompFor()

    member this.ParseSyncCompFor() =
        let startPos = this.Lexer.Position
        match this.Lexer.Symbol with
        |   Token.For _ ->
                let op1 = this.Lexer.Symbol
                this.Lexer.Advance()
                let left = this.ParseExprList()
                match this.Lexer.Symbol with
                |   Token.In _  ->
                        let op2 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseOrTest()
                        match this.Lexer.Symbol with
                        |   Token.Async _
                        |   Token.For _
                        |   Token.If _  ->
                                let next = this.ParseCompIter()
                                ASTNode.SyncCompFor(startPos, this.Lexer.Position, op1, left, op2, right, next)
                        |   _   ->
                                ASTNode.SyncCompFor(startPos, this.Lexer.Position, op1, left, op2, right, ASTNode.Empty)
                |   _   ->
                        raise ( SyntaxError(this.Lexer.Symbol, "Missing 'in' in for comprehension expression!") )
        |   _   ->
                raise ( SyntaxError(this.Lexer.Symbol, "Missing 'for' in comprehension expression!") )
       
    member this.ParseCompIf() =
        let startPos = this.Lexer.Position
        match this.Lexer.Symbol with
        |   Token.If _  ->
                let op = this.Lexer.Symbol
                this.Lexer.Advance()
                let right = this.ParseTestNoCond()
                match this.Lexer.Symbol with
                |   Token.Async _
                |   Token.For _
                |   Token.If _  ->
                        let next = this.ParseCompIter()
                        ASTNode.CompIf(startPos, this.Lexer.Position, op, right, next)
                |   _   ->
                        ASTNode.CompIf(startPos, this.Lexer.Position, op, right, ASTNode.Empty)
        |   _   ->
                raise ( SyntaxError(this.Lexer.Symbol, "Missing 'if' in comprehension expression!") )

    member this.ParseYieldExpr() =
        let startPos = this.Lexer.Position
        match this.Lexer.Symbol with
        |   Token.Yield _   ->
                let op1 = this.Lexer.Symbol
                this.Lexer.Advance()
                match this.Lexer.Symbol with
                |   Token.From _ ->
                        let op2 = this.Lexer.Symbol
                        this.Lexer.Advance()
                        let right = this.ParseTest()
                        ASTNode.YieldFromExpr(startPos, this.Lexer.Position, op1, op2, right)
                |   _   ->
                        let right = this.ParseTestListComp()
                        ASTNode.YieldExpr(startPos, this.Lexer.Position, op1, right)
        |   _   ->
                raise ( SyntaxError(this.Lexer.Symbol, "Missing 'yield' in yield expression!") )