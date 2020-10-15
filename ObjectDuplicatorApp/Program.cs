using ObjectDuplicatorApp.Duplicators.AutoMapperApproach;
using ObjectDuplicatorApp.Duplicators.CloneableApproach;
using ObjectDuplicatorApp.Duplicators.GeorgeCloneyApproach;
using ObjectDuplicatorApp.Duplicators.ManualApproach;
using ObjectDuplicatorApp.Service;

namespace ObjectDuplicatorApp
{
    internal static class Program
    {
        private static void Main()
        {
            var originalUser = UserMock.GetUserFilled();

            //Deep Clone. Will copy all values.
            var userGeorgeCloneyDuplicator = GeorgeCloneyDuplicator.Duplicate(originalUser);

            //It is possible to configure to ignore some fields.
            var userAutoMapperDuplicator = AutoMapperDuplicator.Duplicate(originalUser);

            //It is possible to customize the clone by yourself.
            var userManualDuplicator = ManualDuplicator.Duplicate(originalUser);

            //Using the ICloneable native interface to create a shallow copy just for the first Object.
            var userCloneableDuplicator = CloneableDuplicator.Duplicate(originalUser);
        }
    }
}