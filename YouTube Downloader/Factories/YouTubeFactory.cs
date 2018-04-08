﻿namespace YouTube.Downloader.Factories
{
    using Caliburn.Micro;

    using YouTube.Downloader.Factories.Interfaces;
    using YouTube.Downloader.Models;
    using YouTube.Downloader.ViewModels.Interfaces;

    internal class YouTubeFactory : IYouTubeFactory
    {
        public IVideoViewModel MakeVideoViewModel(YouTubeVideo video)
        {
            IVideoViewModel videoViewModel = IoC.Get<IVideoViewModel>();
            videoViewModel.Initialise(video);

            return videoViewModel;
        }
    }
}