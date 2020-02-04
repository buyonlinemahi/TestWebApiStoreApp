

using System.Collections.Generic;
using DModel = OnlineStore.Domain.Model;


namespace OnlineStore.Domain.Model.Paged
{
    public class User
    {
        public IEnumerable<DModel.User> UserDetails { get; set; }
        public int TotalCount { get; set; }
    }
}
