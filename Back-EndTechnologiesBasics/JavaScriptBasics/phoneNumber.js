function PhoneBook(inputArr){
    let phoneBook = {}
    for(let index in inputArr)
    {
        let nameAndPhone = inputArr[index].split(" ");
        phoneBook[nameAndPhone[0]] = nameAndPhone[1]
    }
    for(let key in phoneBook){
        console.log(key + " -> " + phoneBook[key])
    } 
}

let books = ['Tim 0834212554',
'Peter 0877547887',
'Bill 0896543112',
'Tim 0876566344']

PhoneBook(books)