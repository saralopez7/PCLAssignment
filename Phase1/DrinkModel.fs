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
     member this.Price = 
        match this with 
        | Cup (cup) -> cup.cupType.price + (10m * (decimal cup.size))
        | Can (can) -> can.canType.price + (10m * (decimal can.size))
        | Bottle (bottle) -> bottle.bottleType.price + (10m * (decimal bottle.size))
