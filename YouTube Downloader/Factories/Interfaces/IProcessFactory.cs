﻿namespace YouTube.Downloader.Factories.Interfaces
{
    using YouTube.Downloader.Core.Downloading;
    using YouTube.Downloader.Models;
    using YouTube.Downloader.ViewModels.Interfaces;
    using YouTube.Downloader.ViewModels.Interfaces.Process;
    using YouTube.Downloader.ViewModels.Interfaces.Process.Entities;

    internal interface IProcessFactory
    {
        IDownloadProcessViewModel MakeDownloadProcessViewModel(IVideoViewModel videoViewModel);

        IConvertProcessViewModel MakeConvertProcessViewModel(IVideoViewModel videoViewModel, ConvertProcess process, ConvertProgress progress);

        ICompleteProcessViewModel MakeCompleteProcessViewModel(IVideoViewModel videoViewModel);
    }
}