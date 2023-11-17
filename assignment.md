# Assignment 10

## 11.1

Code written for `lenc` and `leni`

```{}
let rec lenc xs k =
    match xs with
    | [] -> k 0
    | head::tail -> lenc tail (fun x ->  k (x + 1));;

let rec leni xs acc = 
    match xs with
    | [] -> acc
    | _::tail -> leni tail (acc + 1);;
```

### 11.1.i

```{}
> lenc [2;5;7] id;;
val it: int = 3

> lenc [2;5;7] (printf "The answer is '%d'\n");;
The answer is '3'
val it: unit = ()
```

### 11.1.ii

```{}
> let xs = [2;5;7];;
val xs: int list = [2; 5; 7]

> lenc xs (fun v -> v*2);;
val it: int = 6
```

When the `lenc` function is called with the function `fun v -> v*2`, as its base case, it doubles the result.
This happens, because the base continuation is called at the end of the function call.

### 11.1.iii

```{}
> let xs = [2;5;7];;
val xs: int list = [2; 5; 7]

> leni xs 0;;
val it: int = 3
```

Both lenc and leni are tail recursive functions.
`lenc` uses CPS, where `leni` uses an accumulator.
`lenc` has an added overhead of generating and storing closures, where `leni` uses only a constant amount of extra space.

## 11.2

### 11.2.i

```{}
> let xs = [2;5;7];;
val xs: int list = [2; 5; 7]
> revc xs id;;
val it: int list = [7; 5; 2]
```

### 11.2.ii

```{}
> revc xs (fun v -> v @ v);;
val it: int list = [7; 5; 2; 7; 5; 2]
```

### 11.2.iii

```{}
> revi [2;5;7] [];;
val it: int list = [7; 5; 2]
```

## 11.3

```{}
let rec prodc xs k =
    match xs with
    | [] -> k 1
    | head::tail -> prodc tail (fun x -> k (head * x))
```

```{}
> prodc [2;3;9] id;;
val it: int = 54
```

## 11.4

```{}
let rec prodc' xs k =
    match xs with
    | [] -> k 1
    | 0::_ -> k 0
    | head::tail -> prodc tail (fun x -> k (head * x));;
```

```{}
> prodc' [1;2;3;0] id;;
val it: int = 0

> prodc' [1;2;0;3] id;;
val it: int = 0

> prodc' [0;1;2;3] id;;
val it: int = 0

> prodc' [0;1;2;3] (fun v -> v*2);;
val it: int = 0
```

```{}
let rec prodi xs acc = 
    match xs with
    | [] -> acc
    | 0::_ -> 0
    | head::tail -> prodi tail (acc * head);;
```

```{}
> prodi [2;4;6] 1;;
val it: int = 48

> prodi [2;4;0;6] 1;;
val it: int = 0
```

## 11.8
