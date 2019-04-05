open DrinkModel

[<EntryPoint>]
let main argv =
    
    // Create Cups
    let blackCoffee = Cup(Dark, DrinkSize.Large)
    printfn "Large size black coffee cup costs: %f" blackCoffee.Price
    
    let americanoCoffee = Cup(Americano, DrinkSize.Medium)
    printfn "Medium size americano cup costs: %f" americanoCoffee.Price

    let espressoCoffee = Cup(Espresso, DrinkSize.Small )
    printfn "Small size espresso cup costs: %f" espressoCoffee.Price

    // Create Cans
    let fantaCan = Can(Fanta, DrinkSize.Small)
    printfn "Small size fanta can costs: %f" fantaCan.Price

    let cocacolaCan = Can(Cocacola, DrinkSize.Large)
    printfn "Large size cocacola can costs: %f" cocacolaCan.Price

    let redbullCan = Can(Redbull, DrinkSize.Medium)
    printfn "Medium size redbull can costs: %f" redbullCan.Price

    // Create Bottles
    let waterBottle = Bottle(Water, DrinkSize.Small)
    printfn "Small size water bottle costs: %f" waterBottle.Price

    let milkBottle = Bottle(Milk, DrinkSize.Medium)
    printfn "Medium size milk bottle costs: %f" milkBottle.Price

    let juiceBottle = Bottle(Juice, DrinkSize.Large)
    printfn "Large size juice bottle costs: %f" juiceBottle.Price

      //printfn "Time to make an order...\n"
    //printfn "Choose Your drink"
    //printfn "1) Dark Coffee"
    //printfn "2) Americano"
    //printfn "3) Espresso"
    //printfn "4) Fanta"
    //printfn "5) Cocacola"
    //printfn "6) Redbull"
    //printfn "7) Water"
    //printfn "8) Milk"
    //printfn "9) Juice"

    //let userDrinkChoice = System.Console.ReadLine(); 

    //printfn "\nChoose a size"
    //printfn "0) Small"
    //printfn "1) Medium"
    //printfn "2) Large"
    //let userDrinkSizeChoice = System.Console.ReadLine(); 
    //let selectedDrink = getSelectedDrink (int userDrinkChoice) (int userDrinkSizeChoice)
    //printfn "A %s %s costs %M dkk" (selectedDrink.Type)  (selectedDrink.Size.ToString()) selectedDrink.Price


    System.Console.ReadKey() |> ignore
    0