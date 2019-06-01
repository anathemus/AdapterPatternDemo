using System;

namespace AdapterPatternDemo
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string filename)
        {
            // do nothing
        }

        public void PlayVlc(string filename)
        {
            Console.WriteLine("Playing vlc filename: " + filename);
        }
    }
}