import { mathEnforcer } from "../mathEnforcer.js"
import { expect } from "chai"

describe("methEnforcer", () => {
    describe('testing addFive function', () => {
        it("should return undefined when testing with string ", () => {
            const num = "hello"; 
            const result = mathEnforcer.addFive(num);
    
            expect(result).to.be.equals(undefined)

        });
        it("should return undefined when testing with null ", () => {
            const num = null; 
            const result = mathEnforcer.addFive(num);
    
            expect(result).to.be.equals(undefined)
        });
        it("should return correct result when we test with integer ", () => {
            const num = 5; 
            const result = mathEnforcer.addFive(num);
    
            expect(result).to.be.equals(10)

        });
        it("should return correct result when we test with float ", () => {
            const num = 5.51; 
            const result = mathEnforcer.addFive(num);
    
            expect(result).to.be.equals(10.51)

        });
        it("should return correct result when we test with negative number ", () => {
            const num = -5; 
            const result = mathEnforcer.addFive(num);
    
            expect(result).to.be.equals(0)

        });
        
    });
    describe('testing subtractTen function', () => {
        it("should return undefined when testing with string ", () => {
            const num = "hello"; 
            const result = mathEnforcer.subtractTen(num);
    
            expect(result).to.be.equals(undefined)

        });
        it("should return undefined when testing with null ", () => {
            const num = null; 
            const result = mathEnforcer.subtractTen(num);
    
            expect(result).to.be.equals(undefined)
        });
        it("should return correct result when the input is integer", () => {
            const num = 10; 
            const result = mathEnforcer.subtractTen(num);
    
            expect(result).to.be.equals(0)

        });
        it("should return correct result when the input is integer and the result is negative number", () => {
            const num = 5; 
            const result = mathEnforcer.subtractTen(num);
    
            expect(result).to.be.equals(-5)
        });
        it("should return correct result when the input is float", () => {
            const num = 10.5000; 
            const result = mathEnforcer.subtractTen(num);
    
            expect(result).to.be.equals(0.50)
        });
        it("should return correct result when the input is negative", () => {
            const num = -5; 
            const result = mathEnforcer.subtractTen(num);
    
            expect(result).to.be.equals(-15)
        });
    });
    describe('testing sum function', () => {
        it("should return undefined when testing with string", () => {
            const num1 = "hello";
            const num2 = 2;
            const result = mathEnforcer.sum(num1, num2);
    
            expect(result).to.be.equals(undefined)

        });
        it("should return undefined when testing with string", () => {
            const num1 = 2;
            const num2 = "hi";
            const result = mathEnforcer.sum(num1, num2);
    
            expect(result).to.be.equals(undefined)

        });
        it("should return undefined when testing with null ", () => {
            const num1 = null;
            const num2 = 2;
            const result = mathEnforcer.sum(num1, num2);
    
            expect(result).to.be.equals(undefined)
        });
        it("should return correct result when we sum two integers", () => {
            const num1 = 5;
            const num2 = 2;
            const result = mathEnforcer.sum(num1, num2);
    
            expect(result).to.be.equals(7)
        });
        it("should return correct result when we sum an integers and negative number", () => {
            const num1 = 5;
            const num2 = -2;
            const result = mathEnforcer.sum(num1, num2);
    
            expect(result).to.be.equals(3)
        });
        it("should return correct result when we sum two negative numbers", () => {
            const num1 = -5;
            const num2 = -2;
            const result = mathEnforcer.sum(num1, num2);
    
            expect(result).to.be.equals(-7)
        });
        it("should return correct result when we sum two float numbers", () => {
            const num1 = 5.25;
            const num2 = 2.20;
            const result = mathEnforcer.sum(num1, num2);
    
            expect(result).to.be.equals(7.45)
        });
        it("should return correct result when we sum negative with float nunmbers", () => {
            const num1 = -5;
            const num2 = 1.2;
            const result = mathEnforcer.sum(num1, num2);
    
            expect(result).to.be.equals(-3.80)
        });
    })
})