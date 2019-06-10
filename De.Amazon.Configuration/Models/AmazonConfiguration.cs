using Amazon;
using Amazon.Runtime;

namespace De.Amazon.Configuration.Models
{
    public class AmazonConfiguration
    {
        public AmazonConfiguration(AWSCredentials credentials,
                                   RegionEndpoint regionEndpoint)
        {
            Credentials = credentials;
            RegionEndpoint = regionEndpoint;
        }

        public AWSCredentials Credentials { get; }

        public RegionEndpoint RegionEndpoint { get; }
    }
}
