module DrinkModel

type DrinkSize = Small = 0 | Medium = 1 | Large = 2

type CupType = 
    Dark | Americano | Espresso
    member this.price = 
        match this with
        | Dark -> 50m
        | Americano-> 40m
        | Espresso  -> 55m

type CanType = 
    Fanta | Cocacola | Redbull
    member this.price = 
        match this with
        | Fanta -> 25m
        | Cocacola-> 30m
        | Redbull  -> 15m

type BottleType = 
    Water | Milk | Juice
    member this.price = 
        match this with
        | Water -> 5m
        | Milk-> 7m
        | Juice  -> 10m

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
        | Cup (cup) -> cup.cupType.price + (10m * (decimal cup.size))
        | Can (can) -> can.canType.price + (10m * (decimal can.size))
        | Bottle (bottle) -> bottle.bottleType.price + (10m * (decimal bottle.size))

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
                       