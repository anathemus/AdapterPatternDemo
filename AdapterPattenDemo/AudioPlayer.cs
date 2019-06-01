using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternDemo
{
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter _mediaAdapter;
        public void Play(string audioType, string fileName)
        {
            // base class support to play mp3s
            if (audioType.ToLower().Equals("mp3"))
            {
                Console.WriteLine("Playing mp3 filename: " + fileName);
            }

            // MediaAdapter comes into play here to support other formats
            else if (audioType.ToLower().Equals("vlc") || audioType.ToLower().Equals("mp4"))
            {
                _mediaAdapter = new MediaAdapter(audioType);
                _mediaAdapter.Play(audioType, fileName);
            }

            else
            {
                Console.WriteLine("Invalid media type. " + audioType + " format not supported.");
            }
        }
    }
}
