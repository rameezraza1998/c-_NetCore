public class PlaylistManager
{
    
    //HashSet<string> addSong = new HashSet<string>();
    //Queue<string> playQueue = new Queue<string>();
    //Stack<string> prevSong = new Stack<string>();

    HashSet<string> addNewSong = new HashSet<string>();
    Queue<string> nextSong = new Queue<string>();
    Stack<string> prevSong = new Stack<string>();




    //public void AddSong(string song)
    //{
    //    bool newSong = addSong.Add(song);
    //    if (newSong)
    //    {
    //        playQueue.Enqueue(song);
    //        Console.WriteLine($"{song} is added to your playlist");
    //    }
    //   else
    //    {
    //        Console.WriteLine($"the {song} is already exist in the playlist");
    //    }
    //}


    public void AddSong(string song)
    {
        if (addNewSong.Add(song))
        {
            //addNewSong.Add(song);
            nextSong.Enqueue(song);
            Console.WriteLine($"the {song} is added to your playlist");
        }
        else 
        {
            Console.WriteLine($"{song} already exist in the playlist");
        }

    }

    public void NextSong(string song)
    {

        if(nextSong.Count > 0)
        {
            string UpnextSong = nextSong.Dequeue();
            Console.WriteLine($"Now playing: {UpnextSong}");
            prevSong.Push( UpnextSong );
        }
        else 
        {
            Console.WriteLine("No song left in the QUeue");
        }
    }

    public void PrevSong(string song)
    {
       if(prevSong.Count > 1)
       { 
            prevSong.Pop();
            Console.WriteLine($"Back to {prevSong.Peek()}");
        }
        else 
        { 
            Console.WriteLine("No previous Song");
        }

    }
















    //public void NextSong(string song)
    //{
    //    if (playQueue.Count > 0)
    //    {
    //       string newSong =  playQueue.Dequeue();
    //        prevSong.Push(newSong);
    //       Console.WriteLine($"the next song is playing {newSong}");
    //    }
    //    else
    //    {
    //        Console.WriteLine("No song left in Queue");
    //    }
    //}

    //public void PreviousSong(string song)
    //{
    //    if (prevSong.Count > 1)
    //    {
    //        prevSong.Pop(); // Remove current
    //        Console.WriteLine($"Back to: {prevSong.Peek()}");
    //    }
    //    else
    //    {
    //        Console.WriteLine("No previous song.");
    //    }
    //}

}

internal class Program
{
    private static void Main(string[] args)
    {
        PlaylistManager playlistManager = new PlaylistManager();

        //playlistManager.AddSong("Hello by Adele");

        //playlistManager.AddSong("That's my name");


        //playlistManager.NextSong("Hello by Adele");
        //playlistManager.NextSong("aaa");
        //playlistManager.PreviousSong("That's my name");

        playlistManager.AddSong("Pal Pal by AFUSIC");
        playlistManager.AddSong("Pal Pal by AFUSIC");


    }
}