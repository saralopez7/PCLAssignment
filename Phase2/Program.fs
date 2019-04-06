
open Canteen
open DrinkModel

canteenDrinkAgent.Post (OrderDrink(InCup {Size=DrinkSize.Small; Drink=Cappuccino}, 2));;
canteenDrinkAgent.Post (OrderDrink(InCan {Size=DrinkSize.Medium; Drink=Cocacola}, 5));;
canteenDrinkAgent.Post (OrderDrink(InBottle {Size=DrinkSize.Large; Drink=Milk}, 10));;

canteenDrinkAgent.Post (LeaveAComment("Thank you for the water"));;
canteenDrinkAgent.Post (LeaveAComment("The coffee was really bad"));;

printfn "Orders in the canteen %A" Orders.Value
printfn "Comments received %A" Comments.Value

System.Console.ReadKey() |> ignore
0