module CS220.Quiz1.Program

open CS220.Quiz1.Math

[<EntryPoint>]
let main _args =
  printfn "You can test your program by directly modifying Program.fs"
  printfn "Or, you can change the unit tests in the `tests` directory."
  printfn "---"
let collatz n =
  let rec iter n counter = 
    if n = 1 then counter
    elif n % 2 = 0 then iter (n / 2) (counter + 1)
    else iter (n * 3 + 1) (counter + 1)
  iter n 0
collatz 4 |> printfn "# of steps to reach one = %d"
  
