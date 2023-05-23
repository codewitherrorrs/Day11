namespace Day11
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter the number of chapters in the book:");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] chapters = new int[N, 2];

            Console.WriteLine("Enter the start and end pages of each chapter:");
            for (int i = 0; i < N; i++)
            {
                string[] pages = Console.ReadLine().Split(' ');
                chapters[i, 0] = Convert.ToInt32(pages[0]);
                chapters[i, 1] = Convert.ToInt32(pages[1]);
            }

            Console.WriteLine("Enter the current reading page:");
            int K = Convert.ToInt32(Console.ReadLine());

            //int remainingChapters = GetRemainingChapters(N, chapters, K);
            Console.WriteLine("Number of chapters yet to read: " + GetRemainingChapters(N, chapters, K));
        }
    }
}