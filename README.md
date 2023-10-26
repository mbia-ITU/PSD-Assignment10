# Assignment 10

Solved by the group Recursive Rebels.

## Exercises

PLC: 11.1, 11.2, 11.3, 11.4, 11.8.

## Run instructions

```{}
fslex --unicode <LexerSpecification>.fsl
fsyacc --module <ParserName> <ParserSpecification>.fsy
dotnet fsi -r FsLexYacc.Runtime.dll ...
```

On MacBook

```{}
mono ~/bin/fsharp/fslex.exe --unicode <LexerSpefication>.fsl
mono ~/bin/fsharp/fsyacc.exe --module <ParserName> <ParserSpecification>.fsy
dotnet fsi -r FsLexYacc.Runtime.dll ...
```

## Handin details

Handin file name:

- BPRD-10-AMDH-EMNO-MBIA.zip

Files to handin:

- 
