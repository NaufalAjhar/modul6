namespace tpmodul6_1302223040
{
    public class SayaTubeVideo
    {
        public int Id;
        public string Title;
        public int PlayCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.Id = random.Next(10000, 99999);
            this.Title = title;
            this.PlayCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.PlayCount += count;
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
        }
    }
}
