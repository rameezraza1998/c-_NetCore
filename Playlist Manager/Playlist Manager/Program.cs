public class PlaylistManager
{
    
    HashSet<string> addSong = new HashSet<string>();
    Queue<string> playQueue = new Queue<string>();
    Stack<string> prevSong = new Stack<string>();


    public void AddSong(string song)
    {
        bool newSong = addSong.Add(song);
        if (newSong)
        {
            playQueue.Enqueue(song);
            Console.WriteLine($"{song} is added to your playlist");
        }
       else
        {
            Console.WriteLine($"the {song} is already exist in the playlist");
        }
    }

    public void NextSong(string song)
    {
        if (playQueue.Count > 0)
        {
           string newSong =  playQueue.Dequeue();
            prevSong.Push(newSong);
           Console.WriteLine($"the next song is playing {newSong}");
        }
        else
        {
            Console.WriteLine("No song left in Queue");
        }
    }

    public void PreviousSong(string song)
    {
        if (prevSong.Count > 1)
        {
            prevSong.Pop(); // Remove current
            Console.WriteLine($"Back to: {prevSong.Peek()}");
        }
        else
        {
            Console.WriteLine("No previous song.");
        }
    }

}

internal class Program
{
    private static void Main(string[] args)
    {
        PlaylistManager playlistManager = new PlaylistManager();
        playlistManager.AddSong("Hello by Adele");

        playlistManager.AddSong("That's my name");


        playlistManager.NextSong("Hello by Adele");
        playlistManager.NextSong("aaa");
        playlistManager.PreviousSong("That's my name");
        
        
        //Console.WriteLine("Hello, World!");
    }
}