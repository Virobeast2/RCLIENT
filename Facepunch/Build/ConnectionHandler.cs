namespace Facepunch.Build
{
    using System;

    public interface ConnectionHandler : IDisposable
    {
        string address { get; }

        int? port { get; }
    }
}

