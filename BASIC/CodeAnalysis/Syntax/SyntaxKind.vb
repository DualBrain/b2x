﻿Namespace Basic.CodeAnalysis.Syntax

  Public Enum SyntaxKind

    BadToken
    EndOfFileToken

    ' Trivia
    LineNumberTrivia
    SkippedTextTrivia
    LineBreakTrivia
    WhiteSpaceTrivia
    SingleLineCommentTrivia

    ' Tokens
    BackslashToken
    CloseBraceToken
    CloseParenToken
    ColonToken
    CommaToken
    EqualToken
    GreaterThanEqualToken
    GreaterThanToken
    HatToken
    IdentifierToken
    LessThanEqualToken
    LessThanGreaterThanToken
    LessThanToken
    MinusToken
    NumberToken
    OpenBraceToken
    OpenParenToken
    PeriodToken
    PlusToken
    PoundToken
    QuestionToken
    SemicolonToken
    SlashToken
    StarToken
    StringToken

    ' Keywords

    AndAlsoKeyword
    AndKeyword
    AsKeyword
    ConstKeyword
    ContinueKeyword
    DimKeyword
    DoKeyword
    EachKeyword
    ElseIfKeyword
    ElseKeyword
    EndFunctionKeyword
    EndIfKeyword
    EqvKeyword
    ExitKeyword
    FalseKeyword
    ForKeyword
    FunctionKeyword
    GotoKeyword
    IfKeyword
    ImpKeyword
    InKeyword
    LetKeyword
    LoopKeyword
    ModKeyword
    NextKeyword
    NotKeyword
    OrElseKeyword
    OrKeyword
    PrintKeyword
    ReturnKeyword
    StepKeyword
    ThenKeyword
    ToKeyword
    TrueKeyword
    UntilKeyword
    WendKeyword
    WhileKeyword
    XorKeyword

    ' Nodes
    CompilationUnit
    GlobalStatement
    FunctionDeclaration
    Parameter
    AsClause
    SingleLineElseClause
    WhileClause
    UntilClause

    ' Statements
    BlockStatement
    ContinueStatement
    DoUntilStatement
    DoWhileStatement
    ElseIfStatement
    ElseStatement
    ExitStatement
    ExpressionStatement
    ForEachStatement
    ForStatement
    GotoStatement
    IfStatement
    MultiLineIfBlock
    PrintStatement
    ReturnStatement
    SingleLineIfStatement
    VariableDeclaration
    WhileStatement

    ' Expressions
    LiteralExpression
    NameExpression
    UnaryExpression
    BinaryExpression
    ParenExpression
    AssignmentExpression
    CallExpression

  End Enum

End Namespace