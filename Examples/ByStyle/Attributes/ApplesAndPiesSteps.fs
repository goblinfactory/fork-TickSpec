﻿module ApplesAndPiesSteps

open TickSpec
open NUnit.Framework
  
let applesEaten = ref 0
let applePiesEaten = ref 0

let [<BeforeScenario>] Setup () =
    applesEaten := 0
    applePiesEaten := 0

let [<When>] ``I eat an apple`` () =
    incr applesEaten

let [<When>] ``I eat an apple pie`` () =
    incr applePiesEaten

let [<Then>] ``(\d+) apples have been eaten`` (expectedApplesEaten:int) =
    Assert.AreEqual(expectedApplesEaten, !applesEaten)

let [<Then>] ``(\d+) apple pies have been eaten`` (expectedApplePiesEaten:int) =
    Assert.AreEqual(expectedApplePiesEaten, !applePiesEaten)
