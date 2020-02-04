using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Infrastructure.ApplicationServices.Contracts
{
    public interface IStorage
    {
        string SetProductPhotoStoragePath(string storagePath, string fileName);
    }
}
