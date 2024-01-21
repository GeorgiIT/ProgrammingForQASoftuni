function calculate(product, quantity){
    coffeePrice = 1.5;
    waterPrice = 1;
    cokePrice = 1.4;
    snacksPrice = 2.00;

    switch(product){
        case "coffee":
            console.log(`${(coffeePrice * quantity).toFixed(2)}`);
            break;
        case "water":
            console.log(`${(waterPrice * quantity).toFixed(2)}`);
            break;
        case "coke":
            console.log(`${(cokePrice * quantity).toFixed(2)}`);
            break;
        case "snacks":
            console.log(`${(snacksPrice * quantity).toFixed(2)}`);
            break;
    }
}

calculate("water", 5)