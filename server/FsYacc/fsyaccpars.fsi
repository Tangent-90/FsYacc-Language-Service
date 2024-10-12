// Signature file for parser generated by fsyacc
module FsLexYacc.FsYacc.Parser
type token = 
  | BAR
  | PERCENT_PERCENT
  | START
  | LEFT
  | RIGHT
  | NONASSOC
  | LESS
  | GREATER
  | COLON
  | PREC
  | SEMI
  | EOF
  | ERROR
  | HEADER of (AST.Code)
  | CODE of (AST.Code)
  | TOKEN of (AST.Identifier option)
  | IDENT of (AST.Identifier)
  | TYPE of (AST.Identifier)
type tokenId = 
    | TOKEN_BAR
    | TOKEN_PERCENT_PERCENT
    | TOKEN_START
    | TOKEN_LEFT
    | TOKEN_RIGHT
    | TOKEN_NONASSOC
    | TOKEN_LESS
    | TOKEN_GREATER
    | TOKEN_COLON
    | TOKEN_PREC
    | TOKEN_SEMI
    | TOKEN_EOF
    | TOKEN_ERROR
    | TOKEN_HEADER
    | TOKEN_CODE
    | TOKEN_TOKEN
    | TOKEN_IDENT
    | TOKEN_TYPE
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startspec
    | NONTERM_spec
    | NONTERM_headeropt
    | NONTERM_decls
    | NONTERM_decl
    | NONTERM_idents
    | NONTERM_rules
    | NONTERM_rule
    | NONTERM_optbar
    | NONTERM_optsemi
    | NONTERM_clauses
    | NONTERM_clause
    | NONTERM_syms
    | NONTERM_optprec
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val spec : (FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> FSharp.Text.Lexing.LexBuffer<'cty> -> (AST.ParserSpec) 
