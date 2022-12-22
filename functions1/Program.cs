using static System.Formats.Asn1.AsnWriter;

namespace functions1
{
    internal class Program
    {
        static float GetAverageScore(byte[] scores)
        {

            float average = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                average += scores[i];

            }
            average /= scores.Length;
            return average;
        }

        static byte Min(byte[] scores) 
        {
            byte minNumber = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < minNumber)
                    minNumber = scores[i];
            }
            return minNumber;

        }

        static byte Max(byte[] scores)
        {
            byte maxNumber = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > maxNumber)
                    maxNumber = scores[i];
            }
            return maxNumber;
        }
        
        static void Print(byte[] assessments)
        {
           
            Console.WriteLine($"Average= {GetAverageScore(assessments)}");
            Console.WriteLine($"Min= {Min(assessments)}");
            Console.WriteLine($"Max= {Max(assessments)}");
        }
        static void Main(string[] args)
        {
            byte[] user1_assessments = { 10, 5, 8, 10, 7, 5, 3, 6, 7, 9 };
            byte[] user2_assessments = { 6, 7,  10, 10, 7, 5, 3, 10, 7, 9 };
            byte[] user3_assessments = { 9, 10, 7, 8, 7, 5, 3, 10, 7, 9 };
            byte[] user4_assessments = { 8, 4, 9, 7, 8, 5, 3, 10, 7, 9 };
            byte[] user5_assessments = { 10, 9, 8, 10, 7, 5, 3, 10, 7, 9 };

            Print(user1_assessments);
            Print(user2_assessments); 
            Print(user3_assessments);
            Print(user4_assessments);
            Print(user5_assessments);
        }
        
     }


}