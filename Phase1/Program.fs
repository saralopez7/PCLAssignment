open DrinkModel

[<EntryPoint>]
let main argv =
    
    // Create InCups
    let blackCoffee = InCup( { Drink=Dark; Size=DrinkSize.Large } )
    printfn "Large Size black coffee cup costs: %f" blackCoffee.Price
    
    let americanoCoffee = InCup( { Drink=Americano; Size=DrinkSize.Medium } )
    printfn "Medium Size americano cup costs: %f" americanoCoffee.Price

    let espressoCoffee = InCup( { Drink=Espresso; Size=DrinkSize.Small } )
    printfn "Small Size espresso cup costs: %f" espressoCoffee.Price

    // Create InCans
    let fantaInCan = InCan( { Drink=Fanta; Size=DrinkSize.Small} )
    printfn "Small Size fanta can costs: %f" fantaInCan.Price

    let cocacolaInCan = InCan( { Drink=Cocacola; Size=DrinkSize.Large} )
    printfn "Large Size cocacola can costs: %f" cocacolaInCan.Price

    let redbullInCan = InCan( { Drink=Redbull; Size=DrinkSize.Medium} )
    printfn "Medium Size redbull can costs: %f" redbullInCan.Price

    // Create InBottles
    let waterInBottle = InBottle( { Drink=Water; Size=DrinkSize.Small} )
    printfn "Small Size water bottle costs: %f" waterInBottle.Price

    let milkInBottle = InBottle( { Drink=Milk; Size=DrinkSize.Medium} )
    printfn "Medium Size milk bottle costs: %f" milkInBottle.Price

    let juiceInBottle = InBottle( { Drink=Juice; Size=DrinkSize.Large} )
    printfn "Large Size juice bottle costs: %f" juiceInBottle.Price

    System.Console.ReadKey() |> ignore
    0