using GeorgeCloney;
using ObjectDuplicatorApp.Model;

namespace ObjectDuplicatorApp.Duplicators.GeorgeCloneyApproach
{
    public static class GeorgeCloneyDuplicator
    {
        public static User Duplicate(User user)
        {
            return user.DeepClone();
        }
    }
}