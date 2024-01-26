import { isOddOrEven } from '../evenOrOdd.js'
import { expect } from 'chai';

describe("isOddOrEven", () => {
    describe('testing with strings', () =>{
        it("Testing with odd string", () => {
            const str = "hello" 
            const result = isOddOrEven(str);
    
            expect(result).to.be.equals("odd")
        })
        it("Testing with even string", () => {
            const str = "helloo" 
            const result = isOddOrEven(str);
    
            expect(result).to.be.equals("even")
        })   
    })

    describe("Testing with integers, float and etc.", () =>{
        it('testing with integers', () => {
            const str = "123" 
            const result = isOddOrEven(str);
    
            expect(result).to.be.equals("odd")
        })
        it('testing with integers', () => {
            const str = "1234" 
            const result = isOddOrEven(str);
    
            expect(result).to.be.equals("even")
        })
        it('testing with float', () => {
            const str = "123.1" 
            const result = isOddOrEven(str);
    
            expect(result).to.be.equals("odd")
        })
        it('testing with float', () => {
            const str = "123.12" 
            const result = isOddOrEven(str);
    
            expect(result).to.be.equals("even")
        })
        
    })
    describe('testing with undefined, NaN, Null, object', () =>{
        it('test with undefined', () => {
            const result = isOddOrEven(undefined);
    
            expect(result).to.be.equals(undefined)
        })
        it('test with NaN', () => {
            const result = isOddOrEven(NaN);
    
            expect(result).to.be.equals(undefined)
        })
        it('test with Null', () => {
            const result = isOddOrEven(null);
    
            expect(result).to.be.equals(undefined)
        })
        it('test with object {}', () => {
            const result = isOddOrEven({});
    
            expect(result).to.be.equals(undefined)
        })
    })
    
})