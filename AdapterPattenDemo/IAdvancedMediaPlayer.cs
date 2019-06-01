using System;

namespace AdapterPatternDemo
{
    public interface IAdvancedMediaPlayer
    {
        void PlayVlc(string filename);
        void PlayMp4(string filename);
    }
}
