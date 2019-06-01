using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternDemo
{
    class MediaAdapter : IMediaPlayer
    {
        private IAdvancedMediaPlayer _advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.ToLower().Equals("vlc"))
            {
                _advancedMediaPlayer = new VlcPlayer();
            }
            else if (audioType.ToLower().Equals("mp4"))
            {
                _advancedMediaPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.ToLower().Equals("vlc"))
            {
                _advancedMediaPlayer.PlayVlc(fileName);
            }
            else if (audioType.ToLower().Equals("mp4"))
            {
                _advancedMediaPlayer.PlayMp4(fileName);
            }
        }
    }
}
