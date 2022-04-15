using System;
using Twilio;
using Twilio.Rest.Verify.V2.Service;

namespace IndianStatesCensusAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            TwilioClient.Init("AC76c5cc6331189f66c3840531c1041461", "da7a762cab6f83fb95850dac003d924d");
            var veriSID = "VAecb9605eae1bd81e22756cac7802e237";
            var verificationResource = VerificationResource.Create(
                    to:"+919901233273",
                    channel: "sms",
                    pathServiceSid: veriSID
                );
            Console.WriteLine(verificationResource.Status);

        }
    }
}
