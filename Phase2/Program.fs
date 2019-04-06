
open Canteen
open DrinkModel

canteenDrinkAgent.Post (OrderDrink(InCup {Size=DrinkSize.Small; Drink=Dark}, 2));;
canteenDrinkAgent.Post (OrderDrink(InBottle {Size=DrinkSize.Large; Drink=Water}, 10));;

printfn "Current canteen orders: %A" Orders

canteenDrinkAgent.Post (LeaveAComment("Thank you for the water"));;
canteenDrinkAgent.Post (LeaveAComment("The coffee was really bad"));;

printfn "Received comments: %A" Comments
