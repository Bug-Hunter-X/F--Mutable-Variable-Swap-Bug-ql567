let x = ref 10
let y = ref 20

let swap x y =
    let temp = !x
    x := !y
    y := temp

swap x y
printf "%d %d" !x !y