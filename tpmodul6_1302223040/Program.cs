namespace tpmodul6_1302223040
{
    public class SayaTubeVideo
    {
        public int Id;
        public string Title;
        public int PlayCount;

        public SayaTubeVideo(string title)
        {
            if (title == null || title.Length > 100)
            {
                throw new ArgumentException("title tidak boleh null dan harus kurang dari 100 karakter");
            }

            Random random = new Random();
            this.Id = random.Next(10000, 99999);
            this.Title = title;
            this.PlayCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 10000000)
            {
                throw new ArgumentException("Count tidak bisa lebih dari 10,000,000.");
            }

            try
            {
                checked
                {
                    this.PlayCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("overflow.");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.Id + " Title: " + this.Title + " Play Count: " + this.PlayCount);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Naufal Ajhar");
            video.PrintVideoDetails();
            for (int i = 0; i < 10000000; i++)
            {
                video.IncreasePlayCount(1);
            }
            video.PrintVideoDetails();
        }
    }
}
