module lenc

let rec lenc xs k =
    match xs with
    | [] -> k 0
    | head::tail -> lenc tail (fun x ->  k (x + 1));;


let rec leni xs acc = 
    match xs with
    | [] -> acc
    | _::tail -> leni tail (acc + 1);;

let rec revc xs k = 
    match xs with
    | [] -> k []
    | head::tail -> revc tail (fun x -> k (x @ [head]));;

let rec revi xs acc = 
    match xs with
    | [] -> acc
    | head::tail -> revi tail (head :: acc);;

let rec prodc xs k =
    match xs with
    | [] -> k 1
    | head::tail -> prodc tail (fun x -> k (head * x));;

let rec prodc' xs k =
    match xs with
    | [] -> k 1
    | 0::_ -> k 0
    | head::tail -> prodc tail (fun x -> k (head * x));;

let rec prodi xs acc = 
    match xs with
    | [] -> acc
    | 0::_ -> 0
    | head::tail -> prodi tail (acc * head);;
