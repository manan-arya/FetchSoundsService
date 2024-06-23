using FetchSoundsService.Interfaces;
using FetchSoundsService.Model;

namespace FetchSoundsService
{
    public class WishlistingAgent : IWishlistAgent
    {
        ApplicationDBContext mDBContext;
        public WishlistingAgent(ApplicationDBContext dBContext)
        {
            mDBContext = dBContext;
        }

        public void AddToWishlist(int userID, string soundName)
        {
            throw new NotImplementedException();
        }

        public IList<SoundsData> GetWishlist(int userID)
        {
            IList<int> wishlistedSounds = mDBContext.Userwishlist.Where(w => w.UserID == userID).Select(x => x.SoundID).ToList();
            IList<SoundsData> sounds = mDBContext.SoundsInfo.Where(s => wishlistedSounds.Contains(s.ID)).ToList();
            return sounds;
        }

        public void RemoveFromWishlist(int userID, string soundName)
        {
            throw new NotImplementedException();
        }
    }
}
