using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Module_18
{
    /// <summary>
    /// Class describes download command
    /// </summary>
    class CommandDownoadVideo : Command
    {
        Reciever reciever;

        public CommandDownoadVideo(Reciever _reciever)
        {
            reciever = _reciever;
        }

        /// <summary>
        /// Method downloads video
        /// </summary>
        public override async void Run(string link)
        {
            reciever.Operation();

            YoutubeClient f = new YoutubeClient();

            var stream = await f.Videos.Streams.GetManifestAsync(link);
            var streamInfo = stream
                .GetVideoOnlyStreams()
                .Where(s => s.Container == Container.Mp4)
                .GetWithHighestVideoQuality();

            await f.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
        }


    }
}
