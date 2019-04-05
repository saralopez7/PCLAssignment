module DrinkModel

type DrinkSize = Small = 0 | Medium = 1 | Large = 2

type CupDrinks = 
    Dark | Americano | Espresso
    member this.price = 
        match this with
        | Dark -> 50.96
        | Americano-> 40.56
        | Espresso  -> 55.05

type CanDrinks = 
    Fanta | Cocacola | Redbull
    member this.price = 
        match this with
        | Fanta -> 25.55
        | Cocacola-> 30.5
        | Redbull  -> 15.3

type BottleDrinks = 
    Water | Milk | Juice
    member this.price = 
        match this with
        | Water -> 5.3
        | Milk-> 7.5
        | Juice  -> 10.7

type AllDrinks =
    | Cup of CupDrinks * DrinkSize
    | Can of CanDrinks * DrinkSize
    | Bottle of BottleDrinks * DrinkSize
     member this.Price = 
        match this with 
        | Cup (cupDrink, size) -> cupDrink.price + (15.0 * (float size))
        | Can (canDrink, size) -> canDrink.price + (5.0 * (float size))
        | Bottle (bottleDrink, size) -> bottleDrink.price + (10.0 * (float size))
