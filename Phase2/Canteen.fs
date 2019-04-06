module Canteen

open DrinkModel

type CanteenMessage = 
    | OrderDrink of AllDrinks * int 
    | LeaveAComment of string 
    
let mutable Orders = []
let mutable Comments = []

let ProcessOrderDrink (drink:AllDrinks, amount:int) = 
    try
        let order = OrderDrink(drink, amount)
        Orders <-  order :: Orders
        printfn "Please pay DKK %f for your %i %s drinks. Thanks!" (getDrinkPrice(drink) * (double amount)) amount drink.Type
    with
        | Failure(msg) -> printfn "Something went wrong while processing your order. %s. Please try again" msg

let ProcessLeaveAComment (comment:string) =
    Comments <- LeaveAComment(comment) :: Comments
    printfn "Comment %s received by the canteen." comment

let canteenDrinkAgent = 
    MailboxProcessor.Start(fun inbox->
        let rec messageLoop = 
            async { 
                let! (canteenMessage:CanteenMessage) = inbox.Receive()
                match canteenMessage with
                | OrderDrink (drink, amount) -> ProcessOrderDrink (drink, amount)
                | LeaveAComment (comment) -> ProcessLeaveAComment comment
                return! messageLoop
            }
        messageLoop
    )