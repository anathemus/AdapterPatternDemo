using System;

namespace AdapterPatternDemo
{
    public interface IMediaPlayer
    {
        void Play(string audioType, string fileName);
    }
}
