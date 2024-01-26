import { sum } from '../sum.js'
import { expect } from 'chai'

describe('Testing the sum function', () => {
    it('Should return 0 is the array is empty', () =>{

        const arr = [];

        const result = sum(arr);

        expect(result).to.equals(0);
    })
    it('Should return a single element as a sum if a single element in the array is given', () => {
        const arr = [2];

        const result = sum(arr);

        expect(result).to.be.equals(2);
    })

    it('Should return the total sum of an array if a multi value array is given', () =>{
        const arr = [1,2,3,4,5];

        const result = sum(arr);

        expect(result).to.be.equals(15);
    })
})