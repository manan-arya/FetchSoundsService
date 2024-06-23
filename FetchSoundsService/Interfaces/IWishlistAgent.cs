using FetchSoundsService.Model;

namespace FetchSoundsService.Interfaces
{
    public interface IWishlistAgent
    {
        public void AddToWishlist(int userID, string soundName);
        public void RemoveFromWishlist(int userID, string soundName);
        public IList<SoundsData> GetWishlist(int userID);
    }
}
