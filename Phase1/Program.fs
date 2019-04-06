open DrinkModel

[<EntryPoint>]
let main argv =
    
    // Create InCups
    let cappuccinoCoffe = InCup( { Drink=Cappuccino; Size=DrinkSize.Large } )
    printfn "Large Size cappuccino coffee cup costs: %f" (getDrinkPrice cappuccinoCoffe)
    
    let americanoCoffee = InCup( { Drink=Americano; Size=DrinkSize.Medium } )
    printfn "Medium Size americano cup costs: %f" (getDrinkPrice americanoCoffee)

    let espressoCoffee = InCup( { Drink=Espresso; Size=DrinkSize.Small } )
    printfn "Small Size espresso cup costs: %f" (getDrinkPrice espressoCoffee)

    // Create InCans
    let fantaInCan = InCan( { Drink=Fanta; Size=DrinkSize.Small} )
    printfn "Small Size fanta can costs: %f" (getDrinkPrice fantaInCan)

    let cocacolaInCan = InCan( { Drink=Cocacola; Size=DrinkSize.Large} )
    printfn "Large Size cocacola can costs: %f" (getDrinkPrice cocacolaInCan)

    let redbullInCan = InCan( { Drink=Redbull; Size=DrinkSize.Medium} )
    printfn "Medium Size redbull can costs: %f" (getDrinkPrice redbullInCan)

    // Create InBottles
    let waterInBottle = InBottle( { Drink=Water; Size=DrinkSize.Small} )
    printfn "Small Size water bottle costs: %f" (getDrinkPrice waterInBottle)

    let milkInBottle = InBottle( { Drink=Milk; Size=DrinkSize.Medium} )
    printfn "Medium Size milk bottle costs: %f" (getDrinkPrice milkInBottle)

    let juiceInBottle = InBottle( { Drink=Juice; Size=DrinkSize.Large} )
    printfn "Large Size juice bottle costs: %f" (getDrinkPrice juiceInBottle)

    System.Console.ReadKey() |> ignore
    0