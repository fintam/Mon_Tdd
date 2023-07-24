using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedGameTdd
{
    public class GreedScoring
    {
        public int GetScore(int[] diceRolls)
        {
            var score = 0;
            score += Calc1(diceRolls);
            score += Calc2(diceRolls);
            score += Calc3(diceRolls);
            score += Calc4(diceRolls);
            score += Calc5(diceRolls);
            score += Calc6(diceRolls);
            return score;
        }
        private int Calc1(int[] diceRolls)
        {
            var score = 0;
            int count = diceRolls.Count(x => x == 1);
            if(count >= 1 && count < 4)
            {
                score += count * 100;
            }
            else if (count == 4)
            {
                score += 1000;
            }
            return score;
        }
        private int Calc2(int[] diceRolls)
        {
            var score = 0;
            int count = diceRolls.Count(x => x == 2);
            if(count == 3)
            {
                score += 200;
            }
            return score;
        }
        private int Calc3(int[] diceRolls)
        {
            var score = 0;
            int count = diceRolls.Count(x => x == 3);
            if(count == 3)
            {
                score += 300;
            }
            return score;
        }
        private int Calc4(int[] diceRolls)
        {
            var score = 0;
            int count = diceRolls.Count(x => x == 4);
            if (count == 3)
            {
                score += 400;
            }
            return score;
        }
        private int Calc5(int[] diceRolls)
        {
            var score = 0;
            int count = diceRolls.Count(x => x == 5);
            if(count >= 1 && count < 3)
            {
                score += count * 50;
            }
            else if (count == 3)
            {
                score += 500;
            }
            return score;
        }
        private int Calc6(int[] diceRolls)
        {
            var score = 0;
            int count = diceRolls.Count(x => x == 6);
            if(count == 3)
            {
                score += 600;
            }
            return score;
        }
    }
}
