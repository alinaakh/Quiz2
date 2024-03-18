module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec iter n counter = 
    if n = 1 then counter
    elif n % 2 = 0 then iter (n / 2) (counter + 1)
    else iter (n * 3 + 1) (counter + 1)
  iter n 0
collatz 5
  0
