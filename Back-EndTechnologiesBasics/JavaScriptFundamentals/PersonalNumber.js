function solve(names){
    let employeeData = {}

    for(let name of names){
        employeeData[name] = name.length
    }

    for(key in employeeData){
        console.log(`Name: ${key} -- Personal Number: ${employeeData[key]}`)
    }
}

solve(['Silas Butler','Adnaan Buckley','Juan Peterson','Brendan Villarreal'])