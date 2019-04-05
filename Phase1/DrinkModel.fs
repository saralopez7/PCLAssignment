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

type InCup = {Size: DrinkSize; Drink: CupDrinks}
type InCan = {Size: DrinkSize; Drink: CanDrinks}
type InBottle = {Size: DrinkSize; Drink: BottleDrinks}

type AllDrinks =
    | InCup of InCup
    | InCan of InCan
    | InBottle of InBottle
     member this.Price = 
        match this with 
        | InCup (inCup) -> inCup.Drink.price + (15.0 * (float inCup.Size))
        | InCan (inCan) -> inCan.Drink.price + (5.0 * (float inCan.Size))
        | InBottle (inBottle) -> inBottle.Drink.price + (10.0 * (float inBottle.Size))
