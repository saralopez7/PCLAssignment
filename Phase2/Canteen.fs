module Canteen

open DrinkModel

type CanteenMessage = 
    | OrderDrink of AllDrinks * int 
    | LeaveAComment of string 
    
let Orders = ref []
let Comments = ref []

let ProcessOrderDrink (drink:AllDrinks, quantity:int) = 
    try
        let order = OrderDrink(drink, quantity)
        Orders :=  order :: !Orders
        printfn "Please pay DKK %f for your %i %s drinks. Thanks!" (getDrinkPrice(drink) * (double quantity)) quantity drink.Type
    with
        | Failure(msg) -> printfn "Something went wrong while processing your order. %s. Please try again" msg

let ProcessLeaveAComment (comment:string) =
    Comments := LeaveAComment(comment) :: !Comments
    printfn "Comment %s was received by the canteen." comment

let canteenDrinkAgent = 
    MailboxProcessor.Start(fun inbox->
        let rec messageLoop = 
            async { 
                let! (canteenMessage:CanteenMessage) = inbox.Receive()
                match canteenMessage with
                | OrderDrink (drink, quantity) -> ProcessOrderDrink (drink, quantity)
                | LeaveAComment (comment) -> ProcessLeaveAComment comment

                return! messageLoop
            }
        messageLoop
    )
   