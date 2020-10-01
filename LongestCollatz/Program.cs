using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            //The following iterative sequence is defined for the set of positive integers:

            //n → n / 2(n is even)
            //n → 3n + 1(n is odd)

            //Using the rule above and starting with 13, we generate the following sequence:
            //13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

            //It can be seen that this sequence(starting at 13 and finishing at 1) contains 10 terms.Although it
            //has not been proven yet(Collatz Problem), it is thought that all starting numbers finish at 1.

            //Which starting number, under one thousand, produces the longest chain ?

            //NOTE : Once the chain starts the terms are allowed to go above one thousand.

            //commented this out because numbers started exceeding the upper limit for int very quickly.
            //Console.WriteLine("What number would you like to start with?");
            //int nStart = Convert.ToInt32(Console.ReadLine());

            int nStart = 1000;
            int seqSteps = 0, startingNumber = 0;
            //had to do this to make i usable.
            int seq;

            //start the loop looking for the length of sequence for every number under what the user inputs. because the equation looks for an answer of 1, started at the number 2.
            for (int i = 2; i <= nStart; i++)
            {
                //tracking length of the instance of the sequence
                int length = 1;
                //made i usable 
                seq = i;
                while (seq != 1)
                {
                    if ((seq % 2) == 0)
                    {
                        seq = seq / 2;
                    }
                    else
                    {
                        seq = seq * 3 + 1;
                    }
                    length++;
                }

                //is this the most steps needed so far
                if (length > seqSteps)
                {
                    seqSteps = length;
                    startingNumber = i;
                }
            }
            Console.WriteLine($"The longest Collatz sequence under {nStart} is {seqSteps} produced by the number {startingNumber}.");

        }
    }
}
