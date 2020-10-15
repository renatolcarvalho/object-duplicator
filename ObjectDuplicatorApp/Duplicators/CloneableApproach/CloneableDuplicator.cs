using ObjectDuplicatorApp.Model;

namespace ObjectDuplicatorApp.Duplicators.CloneableApproach
{
    public static class CloneableDuplicator
    {
        public static User Duplicate(User user)
        {
            return (User)user.Clone();
        }
    }
}
