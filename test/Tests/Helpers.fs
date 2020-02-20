﻿module Helpers

let successFull parsed=
    match parsed with
    | Choice1Of2 v-> v
    | Choice2Of2 e->failwithf "%s" (e.ToString())
let unSuccessFull parsed=
    match parsed with
    | Choice1Of2 v-> failwithf "%A" v
    | Choice2Of2 e->e

let toString (pin)=pin.ToString()

