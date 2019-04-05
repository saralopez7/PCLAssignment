module NewDrinkModel

type DrinkSize = Small = 0 | Medium = 1 | Large = 2

type CupDrinks = Dark | Americano | Espresso
type CanDrinks = Fanta | Cocacola | Redbull
type BottleDrinks = Water | Milk | Juice

type drinks =
    | Cup of CupDrinks * DrinkSize
    | Can of CanDrinks * DrinkSize
    | Bottle of BottleDrinks * DrinkSize
    member this.Price = 
        match this with 
        | Cup (drink, size) -> match (drink, size) with 
                                    | (Dark, DrinkSize.Small) ->  50
                                    | (Americano, DrinkSize.Small) ->  20
                                    | (Espresso, DrinkSize.Small) ->  40
                                    | (Dark, DrinkSize.Medium) ->  40
                                    | (Americano, DrinkSize.Medium) ->  55
                                    | (Espresso, DrinkSize.Medium) ->  10
                                    | (Dark, DrinkSize.Large) ->  50
                                    | (Americano, DrinkSize.Large) ->  10
                                    | (Espresso, DrinkSize.Large) ->  40
                                    | _ -> failwith "Combination not yet supported"
        | Can (drink, size) -> match (drink, size) with 
                                    | (Fanta, DrinkSize.Small) ->  50
                                    | (Cocacola, DrinkSize.Small) ->  20
                                    | (Redbull, DrinkSize.Small) ->  40
                                    | (Fanta, DrinkSize.Medium) ->  40
                                    | (Cocacola, DrinkSize.Medium) ->  55
                                    | (Redbull, DrinkSize.Medium) ->  10
                                    | (Fanta, DrinkSize.Large) ->  50
                                    | (Cocacola, DrinkSize.Large) ->  10
                                    | (Redbull, DrinkSize.Large) ->  40
                                    | _ -> failwith "Combination not yet supported"
        | Bottle (drink, size) -> match (drink, size) with 
                                    | (Water, DrinkSize.Small) ->  50
                                    | (Milk, DrinkSize.Small) ->  20
                                    | (Juice, DrinkSize.Small) ->  40
                                    | (Water, DrinkSize.Medium) ->  40
                                    | (Milk, DrinkSize.Medium) ->  55
                                    | (Juice, DrinkSize.Medium) ->  10
                                    | (Water, DrinkSize.Large) ->  50
                                    | (Milk, DrinkSize.Large) ->  10
                                    | (Juice, DrinkSize.Large) ->  40
                                    | _ -> failwith "Combination not yet supported"

 let getSelectedDrink drinkSelection sizeSelection = 
    let size =  enum<DrinkSize>(int32(sizeSelection))
    match drinkSelection with
    | 1 -> Cup (Dark, size)
    | 2 -> Cup (Americano, size)
    | 3 -> Cup (Espresso, size)
    | 4 -> Can (Fanta, size)
    | 5 -> Can (Cocacola, size)
    | 6 -> Can (Redbull, size)
    | 7 -> Bottle (Water, size)
    | 8 -> Bottle (Milk, size)
    | 9 -> Bottle (Juice, size) 
    | _ -> failwith "Drink not found"
                       