module NewDrinkModel

type DrinkSize = Small = 0 | Medium = 1 | Large = 2

type CupType = Dark | Americano | Espresso
type CanType = Fanta | Cocacola | Redbull
type BottleType = Water | Milk | Juice

type Cup = { cupType: CupType ; size: DrinkSize }
type Can = { canType: CanType ; size: DrinkSize }
type Bottle = { bottleType: BottleType ; size: DrinkSize }

type drinks =
    | Cup of Cup
    | Can of Can
    | Bottle of Bottle
    member this.Type =
        match this with
        | Cup (cup) -> cup.cupType.ToString()
        | Can (can) -> can.canType.ToString()
        | Bottle (bottle) -> bottle.bottleType.ToString()
    member this.Size =
        match this with
        | Cup (cup) -> cup.size
        | Can (can) -> can.size
        | Bottle (bottle) -> bottle.size
    member this.Price = 
        match this with 
        | Cup (cup) -> match (cup.cupType, cup.size) with 
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
        | Can (can) -> match (can.canType, can.size) with 
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
        | Bottle (bottle) -> match (bottle.bottleType, bottle.size) with 
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
    | 1 -> Cup({ cupType = Dark ; size = size })
    | 2 -> Cup({ cupType = Americano ; size = size })
    | 3 -> Cup({ cupType = Espresso ; size = size })
    | 4 -> Can({ canType = Fanta ; size = size })
    | 5 -> Can({ canType = Cocacola ; size = size })
    | 6 -> Can({ canType = Redbull ; size = size })
    | 7 -> Bottle({ bottleType = Water ; size = size })
    | 8 -> Bottle({ bottleType = Milk ; size = size })
    | 9 -> Bottle({ bottleType = Juice ; size = size }) 
    | _ -> failwith "Drink not found"
                       