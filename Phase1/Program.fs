open DrinkModel

[<EntryPoint>]
let main argv =
    
    // Create InCups
    let blackCoffee = InCup(DrinkSize.Large, Dark)
    printfn "Large size black coffee cup costs: %f" blackCoffee.Price
    
    let americanoCoffee = InCup(DrinkSize.Medium, Americano)
    printfn "Medium size americano cup costs: %f" americanoCoffee.Price

    let espressoCoffee = InCup(DrinkSize.Small, Espresso)
    printfn "Small size espresso cup costs: %f" espressoCoffee.Price

    // Create InCans
    let fantaInCan = InCan(DrinkSize.Small, Fanta)
    printfn "Small size fanta can costs: %f" fantaInCan.Price

    let cocacolaInCan = InCan(DrinkSize.Large, Cocacola)
    printfn "Large size cocacola can costs: %f" cocacolaInCan.Price

    let redbullInCan = InCan(DrinkSize.Medium, Redbull)
    printfn "Medium size redbull can costs: %f" redbullInCan.Price

    // Create InBottles
    let waterInBottle = InBottle(DrinkSize.Small, Water)
    printfn "Small size water bottle costs: %f" waterInBottle.Price

    let milkInBottle = InBottle(DrinkSize.Medium, Milk)
    printfn "Medium size milk bottle costs: %f" milkInBottle.Price

    let juiceInBottle = InBottle(DrinkSize.Large, Juice)
    printfn "Large size juice bottle costs: %f" juiceInBottle.Price

    System.Console.ReadKey() |> ignore
    0