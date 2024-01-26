import { lookupChar } from "../charLookup.js"
import { expect } from 'chai'

describe('LookUpChar function test', () => {
    describe('unit test with incorrect type undefined', () => {
        it('should return undefined with incorrect type of string', () => {
            const str = 123;
            const index = 2;

            const result = lookupChar(str, index);

            expect(result).to.be.equals(undefined);
        })
        it('should return undefined with incorrect type of index', () => {
            const str = "Some random text here";
            const index = '2';

            const result = lookupChar(str, index);

            expect(result).to.be.equals(undefined);
        })

    })
    describe('should return incorrect index', () => {
        it('should return incorrect index with bigger index than string length', () => {
            const str = "Hello";
            const index = 6;

            const result = lookupChar(str, index);

            expect(result).to.be.equals("Incorrect index");
        })
        it('should return incorrect index with  index == string.length', () => {
            const str = "Hello";
            const index = 5;

            const result = lookupChar(str, index);

            expect(result).to.be.equals("Incorrect index");
        })
        it('should return incorrect index with negative index', () => {
            const str = "Hello";
            const index = -2;

            const result = lookupChar(str, index);

            expect(result).to.be.equals("Incorrect index");
        })
    })
    describe('should return the char at the specific index', () => {
        it('should return char on the specific index', () => {
            const str = "Hello";
            const index = 1;

            const result = lookupChar(str, index);

            expect(result).to.be.equals("e");
        })
        it('should return char on the specific index when the index is 0', () => {
            const str = "Hello";
            const index = 0;

            const result = lookupChar(str, index);

            expect(result).to.be.equals("H");
        })
        it('should return char on the specific index when the index is string.lentgh - 1', () => {
            const str = "Hello";
            const index = 4;

            const result = lookupChar(str, index);

            expect(result).to.be.equals("o");
        })

    })
} )