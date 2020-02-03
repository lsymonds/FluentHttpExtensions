using System.Threading.Tasks;
using Xunit;

namespace Moogie.Http.Tests.Unit.GeneralExtensionsTests
{
    public class WithUserAgentTests : UnitTest
    {
        [Fact]
        public async Task User_Agent_Is_Set_In_MoogieHttpRequest_Object()
        {
            OnRequestMade(r => Assert.Equal("moogie-http", r.Headers.UserAgent.ToString()));

            await MoogieHttpRequest
                .WithUserAgent("moogie-http")
                .Get()
                .EnsureResponseSuccessful();
        }
    }
}
