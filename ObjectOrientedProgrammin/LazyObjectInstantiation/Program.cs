// This caller does not care about getting all songs,
// but indirectly created 10,000 objects!
MediaPlayer myPlayer = new MediaPlayer();
myPlayer.Play();
class Song
{
    public string Artist { get; set; } = "";
    public string TrackName { get; set; } = "";
    public double TrackLength { get; set; }
}

class AllTracks
{
    // Our media player can have a maximum
    // of 10,000 songs.
    private Song[] _allSongs = new Song[10000];
    public AllTracks()
    {
        // Assume we fill up the array
        // of Song objects here.
        Console.WriteLine("Filling up the songs!");
    }
}

class MediaPlayer
{
    // Assume these methods do something useful.
    public void Play() { /* Play a song */ }
    public void Pause() { /* Pause the song */ }
    public void Stop() { /* Stop playback */ }
    private Lazy<AllTracks> _allSongs = new Lazy<AllTracks>();
    public Lazy<AllTracks> GetAllTracks()
    {
        // Return all of the songs.
        return _allSongs;
    }
}