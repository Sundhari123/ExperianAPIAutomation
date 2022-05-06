using System.Collections;

namespace Experian.API.Automation.TestCaseData
{
    public class PhotoTestCaseData
    {
        public static IEnumerable PhotoTestData
        {
            get
            {
                yield return
                    new NUnit.Framework.TestCaseData(1, 50)
                        .SetDescription("AlbumId 1 with 50 photos");
                yield return
                    new NUnit.Framework.TestCaseData(2, 50)
                        .SetDescription("AlbumId 2 with 50 photos");
            }
        }

        public static IEnumerable PhotoAlbumTestData
        {
            get
            {
                yield return
                    new NUnit.Framework.TestCaseData(1, 1, 50)
                        .SetDescription("UserId 1 having album 1 with 50 photos");
                yield return
                    new NUnit.Framework.TestCaseData(2, 11, 50)
                        .SetDescription("UserId 2 having album 10 with 50 photos");
                yield return
                    new NUnit.Framework.TestCaseData(4, 34, 50)
                        .SetDescription("UserId 4 having album 34 with 50 photos");
            }
        }
    }
}
