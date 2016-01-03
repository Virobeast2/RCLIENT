namespace Facepunch.Load
{
    using System;

    public interface IDownloaderDispatch
    {
        void BindLoader(Facepunch.Load.Loader loader);
        IDownloader CreateDownloaderForJob(Job job);
        void DeleteDownloader(Job job, IDownloader downloader);
        void UnbindLoader(Facepunch.Load.Loader loader);
    }
}

