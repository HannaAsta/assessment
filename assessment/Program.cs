
int[] asses = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int minNumber = asses [0];
int maxNumber = asses[0];

int Sum = 0;


for (int i = 0; i < asses.Length; i ++) 
{
   Sum += asses [i];

    if (asses[i] < minNumber)
        minNumber = asses[i];

    if (asses[i] > maxNumber)
        maxNumber = asses[i];
}

float average = (float)Sum / asses.Length;


Console.WriteLine($"min={minNumber}");
Console.WriteLine($"max={maxNumber}");

Console.WriteLine($"average={average}");

