function Sum(start, end){
    sum = 0;
    for(let i = start; i <= end; i++){
        sum += i;
        process.stdout.write(`${i} `);
    }
    console.log(`\nSum: ${sum}`)
}