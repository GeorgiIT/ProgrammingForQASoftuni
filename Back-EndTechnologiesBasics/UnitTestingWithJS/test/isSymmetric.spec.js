import { isSymmetric } from "../isSymmetric.js"
import { expect } from "chai";

describe("isSymmetric function testing", () =>{
    it("Should return true with symmetric input", () =>{
        const arr = [3,2,1,2,3];

        const result = isSymmetric(arr);

        expect(result).to.be.true;
    });

    it("Should return false with object input", () =>{
        const arr = {};

        const result = isSymmetric(arr);

        expect(result).to.be.false;
    })

    it("Should return false with NaN input", () =>{

        const result = isSymmetric(NaN);

        expect(result).to.be.false;
    })

    it("Should return false with non-symmetric input using strings", () =>{
        const arr = ["Hello", "dummy"];

        const result = isSymmetric(arr);

        expect(result).to.be.false;
    })
    it("Should return false with non-symmetric input v2", () =>{
        const arr = [1,2,3,4,5,6];

        const result = isSymmetric(arr);

        expect(result).to.be.false;
    })

    it("Should return false with multiple different types", () =>{
        const arr = ["b", "o",true, 2, "b","is"];

        const result = isSymmetric(arr);

        expect(result).to.be.false;
    })
    it("Should return false with undefined ", () =>{

        const result = isSymmetric(undefined);

        expect(result).to.be.false;
    })
    it("Should return false with null input ", () =>{

        const result = isSymmetric(null);

        expect(result).to.be.false;
    })
    
})