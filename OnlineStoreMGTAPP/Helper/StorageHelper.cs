using OnlineStore.Domain.Model;
using System;
using System.IO;
using System.Web;

namespace OnlineStoreMGTAPP.Helper
{
    public class StorageHelper
    {

        public const string ProductPhotos = "ProductPhotos";

        public string SetProductPhotoStoragePath(string storagePath, string fileName)
        {
            string path = Path.Combine(storagePath, ProductPhotos);
            CreateDirectory(path);
            return Path.Combine(path, Guid.NewGuid().ToString() + Path.GetExtension(fileName));
        }

        public bool CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                return true;
            }
            return false;
        }

        public string GeneateStorage(StorageModel _storageModel)
        {
            string path = "";
            path = Path.Combine(_storageModel.path, _storageModel.FolderName, _storageModel.ID.ToString());
            CreateDirectory(path);
            return path;
        }
    }
}
