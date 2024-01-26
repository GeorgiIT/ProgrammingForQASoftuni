import { analyzeArray } from "../arrayAnalyzer.js"
import { expect } from 'chai'

describe('analyzeArray function', () => {
    it('should return undefined with empty array', () => {
        const arr = [];

        const result = analyzeArray(arr);

        expect(result).to.be.equals(undefined);
    });
    it('should return undefined with object', () => {
        const arr = {};

        const result = analyzeArray(arr);

        expect(result).to.be.equals(undefined);
    });
    it('should return undefined with string', () => {
        const arr = "some text";

        const result = analyzeArray(arr);

        expect(result).to.be.equals(undefined);
    });
    it('should return undefined with array of strings and integers', () => {
        const arr = [1,2,3, "4"];

        const result = analyzeArray(arr);

        expect(result).to.be.equals(undefined);
    });
    it('should return correct object with array of integers', () => {
        const arr = [1,2,3];

        const result = analyzeArray(arr);
        const expectedResult = {
            "min": 1,
            "max": 3,
            "length": 3
        }
        expect(result).to.be.eql(expectedResult);
    })
    it('should return correct object with array of single element', () => {
        const arr = [2];

        const result = analyzeArray(arr);
        const expectedResult = {
            "min": 2,
            "max": 2,
            "length": 1
        }
        expect(result).to.be.eql(expectedResult);
    })
    it('should return correct object with array of equal elements', () => {
        const arr = [2,2,2];

        const result = analyzeArray(arr);
        const expectedResult = {
            "min": 2,
            "max": 2,
            "length": 3
        }
        expect(result).to.be.eql(expectedResult);
    })
    it('should return correct object with array of equal elements', () => {
        const arr = [1,2,2,2];

        const result = analyzeArray(arr);
        const expectedResult = {
            "min": 1,
            "max": 2,
            "length": 4
        }
        expect(result).to.be.eql(expectedResult);
    })
    
});