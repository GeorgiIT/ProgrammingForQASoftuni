function storeInventory(currentInventory, upcomingOrder) {
    let allProducts = {};

    // Populate the allProducts object with the currentInventory
    for (let i = 0; i < currentInventory.length; i += 2) {
        let productName = currentInventory[i];
        let quantity = parseInt(currentInventory[i + 1]);
        allProducts[productName] = quantity;
    }

    // Update the allProducts object with the upcomingOrder
    for (let i = 0; i < upcomingOrder.length; i += 2) {
        let productName = upcomingOrder[i];
        let quantityToAdd = parseInt(upcomingOrder[i + 1]);

        if (allProducts.hasOwnProperty(productName)) {
            allProducts[productName] += quantityToAdd;
        } else {
            allProducts[productName] = quantityToAdd;
        }
    }

    // Print the result
    for (let product in allProducts) {
        console.log(`${product} -> ${allProducts[product]}`);
    }
}

arr1 = ['Chips', '5', 'CocaCola', '9', 'Bananas','14', 'Pasta', '4', 'Beer', '2']
arr2 = ['Flour', '44', 'Oil', '12', 'Pasta', '7','Tomatoes', '70', 'Bananas', '30']

storeInventory(arr1, arr2);