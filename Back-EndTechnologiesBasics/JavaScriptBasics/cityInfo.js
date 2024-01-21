function cityInfo(inputObj){
    for(let key in inputObj){
        console.log(key + " -> " + inputObj[key])
    }
}

input = {
    name: "Sofia",
    area: 492,
    population: 1238438,
    country: "Bulgaria",
    postCode: "1000" 
}

cityInfo(input)