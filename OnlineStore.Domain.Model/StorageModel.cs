using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Model
{
    public class StorageModel
    {
        public int ID { get; set; }
        public string path { get; set; }
        public string FolderName { get; set; }
        public string SubFolderName { get; set; }
      
    }
}
