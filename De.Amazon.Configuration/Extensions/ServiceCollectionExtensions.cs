using Amazon;
using Amazon.Runtime;
using De.Amazon.Configuration.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace De.Amazon.Configuration.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAwsConfiguration(this IServiceCollection services)
        {
            var accessKey = Environment.GetEnvironmentVariable("AWS_ACCESS_KEY");
            var secretKey = Environment.GetEnvironmentVariable("AWS_SECRET_KEY");

            var region = RegionEndpoint.USEast2;

            var credentials = new BasicAWSCredentials(accessKey, secretKey);

            var amazonConfig = new AmazonConfiguration(credentials, region);

            services.AddSingleton(amazonConfig);
        }
    }
}
