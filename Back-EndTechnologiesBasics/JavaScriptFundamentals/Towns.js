function TownsData(rawData) {
    for (let data of rawData) {
        let splitData = data.split(" | ");
        let townName = splitData[0];
        let latitude = parseFloat(splitData[1]).toFixed(2);
        let longitude = parseFloat(splitData[2]).toFixed(2);

        console.log(`{ town: '${townName}', latitude: '${latitude}', longitude: '${longitude}' }`);
    }
}

TownsData(['Sofia | 42.696552 | 23.32601', 'Beijing | 39.913818 | 116.363625']);


