open DrinkModel

[<EntryPoint>]
let main argv =
    
    printfn "Time to make an order...\n"
    printfn "Choose Your drink"
    printfn "1) Dark Coffee"
    printfn "2) Americano"
    printfn "3) Espresso"
    printfn "4) Fanta"
    printfn "5) Cocacola"
    printfn "6) Redbull"
    printfn "7) Water"
    printfn "8) Milk"
    printfn "9) Juice"

    let userDrinkChoice = System.Console.ReadLine(); 

    printfn "\nChoose a size"
    printfn "0) Small"
    printfn "1) Medium"
    printfn "2) Large"
    let userDrinkSizeChoice = System.Console.ReadLine(); 
    let selectedDrink = getSelectedDrink (int userDrinkChoice) (int userDrinkSizeChoice)
    printfn "A %s %s costs %M dkk" (selectedDrink.Type)  (selectedDrink.Size.ToString()) selectedDrink.Price

    //// Cups
    //let blackCoffee = Cup( { cupType=CupType.Dark; size=DrinkSize.Large } )
    //printfn "Large size black coffee cup costs: %i" blackCoffee.Price
    
    //let americanoCoffee = Cup( { cupType=CupType.Americano; size=DrinkSize.Medium } )
    //printfn "Medium size americano cup costs: %i" americanoCoffee.Price

    //let espressoCoffee = Cup( { cupType=CupType.Espresso; size=DrinkSize.Small } )
    //printfn "Small size espresso cup costs: %i" espressoCoffee.Price

    //// Cans
    //let fantaCan = Can( { canType=CanType.Fanta; size=DrinkSize.Small} )
    //printfn "Small size fanta can costs: %i" fantaCan.Price

    //let cocacolaCan = Can( { canType=CanType.Cocacola; size=DrinkSize.Large} )
    //printfn "Large size cocacola can costs: %i" cocacolaCan.Price

    //let redbullCan = Can( { canType=CanType.Redbull; size=DrinkSize.Medium} )
    //printfn "Medium size redbull can costs: %i" redbullCan.Price

    //// Bottles
    //let waterBottle = Bottle( { bottleType=BottleType.Water; size=DrinkSize.Small} )
    //printfn "Small size water bottle costs: %i" waterBottle.Price

    //let milkBottle = Bottle( { bottleType=BottleType.Milk; size=DrinkSize.Medium} )
    //printfn "Medium size milk bottle costs: %i" milkBottle.Price

    //let juiceBottle = Bottle( { bottleType=BottleType.Juice; size=DrinkSize.Large} )
    //printfn "Large size juice bottle costs: %i" juiceBottle.Price

    System.Console.ReadKey() |> ignore
    0