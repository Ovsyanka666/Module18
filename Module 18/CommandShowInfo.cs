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
    /// Class describes command which shows us inrmation about video
    /// </summary>
    class CommandShowInfo : Command
    {
        Reciever reciever;

        public CommandShowInfo(Reciever _reciever)
        {
            reciever = _reciever;
        }

        /// <summary>
        /// Method shows us information
        /// </summary>
        public override async void Run(string link)
        {
            reciever.Operation();

            YoutubeClient f = new YoutubeClient();
            var video = await f.Videos.GetAsync(link);
            Console.WriteLine($"Имя видео - {video.Title} \nАвтор видео - {video.Author.ChannelTitle} \nДлительность видео - {video.Duration}");
        }
    }
}
