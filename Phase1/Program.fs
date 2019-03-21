open DrinkModel

[<EntryPoint>]
let main argv =

    // Cups
    let blackCoffee = Cup( { cupType=Dark; size=DrinkSize.Large } )
    printfn "Large size black coffee cup costs: %M" blackCoffee.Price
    
    let americanoCoffee = Cup( { cupType=Americano; size=DrinkSize.Medium } )
    printfn "Medium size americano cup costs: %M" americanoCoffee.Price

    let espressoCoffee = Cup( { cupType=Espresso; size=DrinkSize.Small } )
    printfn "Small size espresso cup costs: %M" espressoCoffee.Price

    // Cans
    let fantaCan = Can( { canType=Fanta; size=DrinkSize.Small} )
    printfn "Small size fanta can costs: %M" fantaCan.Price

    let cocacolaCan = Can( { canType=Fanta; size=DrinkSize.Large} )
    printfn "Large size cocacola can costs: %M" cocacolaCan.Price

    let redbullCan = Can( { canType=Redbull; size=DrinkSize.Medium} )
    printfn "Medium size redbull can costs: %M" redbullCan.Price

    // Bottles
    let waterBottle = Bottle( { bottleType=Water; size=DrinkSize.Small} )
    printfn "Small size water bottle costs: %M" waterBottle.Price

    let milkBottle = Bottle( { bottleType=Milk; size=DrinkSize.Medium} )
    printfn "Medium size milk bottle costs: %M" milkBottle.Price

    let juiceBottle = Bottle( { bottleType=Juice; size=DrinkSize.Large} )
    printfn "Large size juice bottle costs: %M" juiceBottle.Price

    System.Console.ReadKey() |> ignore
    0