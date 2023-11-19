using NUnit.Framework;
using System;

namespace TestApp.Tests
{
    public class PlantsTests
    {
        [Test]
        public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
        {
            string[] input = Array.Empty<string>();

            string result = Plants.GetFastestGrowing(input);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
        {
            string[] input = { "one" };

            string result = Plants.GetFastestGrowing(input);
            string expected = "Plants with 3 letters:\r\none";

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
        {
            string[] input = { "one", "two", "three", "four" };

            string result = Plants.GetFastestGrowing(input);
            string expected = "Plants with 3 letters:\r\none\r\ntwo\r\nPlants with 4 letters:\r\nfour\r\nPlants with 5 letters:\r\nthree";

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
        {
            string[] input = { "one", "Two", "Three", "four" };

            string result = Plants.GetFastestGrowing(input);
            string expected = "Plants with 3 letters:\r\none\r\nTwo\r\nPlants with 4 letters:\r\nfour\r\nPlants with 5 letters:\r\nThree";

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
