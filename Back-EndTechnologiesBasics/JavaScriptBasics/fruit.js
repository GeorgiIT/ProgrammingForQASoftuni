function fruit(fruit, grams, kgPrice){
    let totalPrice = ((grams / 1000) * kgPrice).toFixed(2);
    console.log(`I need $${totalPrice} to buy ${(grams/1000).toFixed(2)} kilograms ${fruit}.`)
}

fruit("apple", 1500, 1.5)