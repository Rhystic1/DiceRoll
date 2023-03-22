// See https://aka.ms/new-console-template for more information
using DiceRoll;
using System.Runtime.CompilerServices;

Calculations calculations = new Calculations();
bool programRunning = true;
int min = 1;
while (programRunning)
{
    int max = calculations.SelectDie();
    calculations.GenerateResult(min, max);

    char userResponse = Console.ReadKey(true).KeyChar;
    if (userResponse == 'n')
    {
        programRunning = false;
    }
}


