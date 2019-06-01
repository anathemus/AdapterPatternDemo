using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternDemo
{
    class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4(string filename)
        {
            Console.WriteLine("Playing mp4 filename: " + filename);
        }

        public void PlayVlc(string filename)
        {
            // do nothing
        }
    }
}
