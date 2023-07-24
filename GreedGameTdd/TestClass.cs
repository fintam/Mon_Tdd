using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GreedGameTdd
{
    //Greed Scoring explanation: https://brendoneus.com/katas/greed-kata
    public class TestClass
    {
        [Theory]
        [InlineData(new int[] { 1, 5, 6 }, 150)]
        [InlineData(new int[] { 1, 1, 1, 5, 1, 6 },1050)]
        [InlineData(new int[] { 2, 2, 3, 3, 4, 6 },0)]
        [InlineData(new int[] { 3, 4, 5, 3, 3, 4 },350)]
        [InlineData(new int[] { 3, 3, 3, 4, 4, 4 },700)]
        [InlineData(new int[] { 5, 5, 5, 1, 1, 4 },700)]
        [InlineData(new int[] { 5, 4, 5, 4, 1, 4 },600)]
        public void Can_Calculate_Score(int[] diceRolls, int expectedScore)
        {
            var scoring = new GreedScoring();

            var result = scoring.GetScore(diceRolls);

            Assert.Equal(expectedScore, result);
        }
    }
}
