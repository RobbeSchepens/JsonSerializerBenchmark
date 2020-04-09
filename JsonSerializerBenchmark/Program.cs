using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using MessagePack;
using Newtonsoft.Json;
using ServiceStack;

namespace JsonSerializerBenchmark
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SerializationBenchmark>();
            Console.ReadKey();
        }
    }

    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MemoryDiagnoser]
    [MinColumn, MaxColumn]
    public class SerializationBenchmark
    {
        [Benchmark]
        public void SerializeAndDeserializeInNewtonSoft()
        {
            var userProfile = CreateNewUserProfile();

            for (var i = 0; i < 1_000_000; i++)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(userProfile);
                var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<UserProfile>(json);
            }
        }

        //[Benchmark]
        //public void SerializeAndDeserializeInMessagePack()
        //{
        //    MessagePackSerializer.SetDefaultResolver(MessagePack.Resolvers.ContractlessStandardResolver.Instance);
        //    var userProfile = CreateNewUserProfile();

        //    for (var i = 0; i < 1_000_000; i++)
        //    {
        //        var json = MessagePackSerializer.SerializeToJson(userProfile);
        //        var obj = MessagePackSerializer.ConvertFromJson(json);
        //    }
        //}

        [Benchmark]
        public void SerializeAndDeserializeInServiceStackText()
        {
            var userProfile = CreateNewUserProfile();

            for (var i = 0; i < 1_000_000; i++)
            {
                var json = userProfile.ToJson();
                var obj = json.FromJson<UserProfile>();
            }
        }

        [Benchmark]
        public void SerializeAndDeserializeInJil()
        {
            var userProfile = CreateNewUserProfile();

            for (var i = 0; i < 1_000_000; i++)
            {
                var json = Jil.JSON.Serialize(userProfile);
                var obj = Jil.JSON.Deserialize<UserProfile>(json);
            }
        }

        [Benchmark(Baseline = true)]
        public void SerializeAndDeserializeInTextJson()
        {
            var userProfile = CreateNewUserProfile();

            for (var i = 0; i < 1_000_000; i++)
            {
                var json = System.Text.Json.JsonSerializer.Serialize(userProfile);
                var obj = System.Text.Json.JsonSerializer.Deserialize<UserProfile>(json);
            }
        }

        [Benchmark]
        public void SerializeAndDeserializeInUtf8Json()
        {
            var userProfile = CreateNewUserProfile();

            for (var i = 0; i < 1_000_000; i++)
            {
                var json = Utf8Json.JsonSerializer.Serialize(userProfile);
                var obj = Utf8Json.JsonSerializer.Deserialize<UserProfile>(json);
            }
        }

        private UserProfile CreateNewUserProfile()
        {
            return new UserProfile
            {
                ID = 1234,
                NetworkID = "1234",
                Domain = "WHTN",
                CICSOPID = "WTS",
                CCN = "WHTN",
                EmployeeNbr = "1234",
                LastName = "Robbe",
                FirstName = "Robbe",
                MiddleInit = "",
                MfgLocationID = "",
                LanguageCode = "",
                TimeZone = "",
                DivMDTCode = "",
                DateFormat = "sdddddddd",
                ActiveCD = "",
                AMAPSOPID = "",
                AMAPSPWD = "",
                PrimaryRepDeptNo = "",
                Email = "sqQDSQSDQDSQSDDQS",
                NativeLastName = "",
                NativeFirstName = "",
                MgrEmpCode = "",
                ShortLangCode = "",
                SecondaryRepNos = "",
                ViewCommissions = true,
                DeptNos = "sddddddddd",
                ViewCostData = true,
                ViewIntraFacility = false,
                PurchasingSpentLimit = "",
                lastUpdateDate = DateTime.Now,
                firstUpdateDate = DateTime.UtcNow,
                IntraFacilityRepNos = "",
                GMTID = 9,
                ViewGrossMargin = true,
                AssignedSalesmanCDs = "",
                SSCoEmp = "",
                AzureObjectId = new Guid("F0E999CA-05F0-4DF2-9DE7-1D533B82EC0B"),
                UserPrincipalName = "",
                dhGuid = new Guid("F0E999CA-05F0-4DF2-9DE7-1D533B82EC0B"),
                Test = new Test(),
            };
        }
    }
}
