// See https://aka.ms/new-console-template for more information

static void Main(string[] args)
{
    int[] scores = { 10, 9, 8, 10, 7, 5, 3, 10, 7, 9 };
    float average = GetAverageScore(scores);
    int Maxint = scores[0];

        int[] scores1 = { 9, 9, 8, 8, 7, 10, 10, 10, 7, 9 };
    average = GetAverageScore(scores1);


    int[] scores2 = { 9, 9, 8, 10, 7, 5, 10, 10, 7, 9 };
    average = GetAverageScore(scores2);

    int[] scores3 = { 7, 10, 8, 10, 7, 5, 8, 10, 7, 9 };
    average = GetAverageScore(scores3);

    int[] scores4 = { 9, 7, 10, 9, 8, 8, 9, 10, 7, 9 };
    average = GetAverageScore(scores4);



    Console.WriteLine(average);
}





    


