using System.Collections;

namespace Experian.API.Automation.TestCaseData
{
    public class AlbumTestCaseData
    {
        public static IEnumerable AlbumsTestData
        {
            get
            {
                yield return
                    new NUnit.Framework.TestCaseData(4, 10)
                        .SetDescription("UserId 4 with 10 albums");
                yield return
                    new NUnit.Framework.TestCaseData(2, 10)
                        .SetDescription("UserId 2 with 10 albums");
            }
        }
    }
}
