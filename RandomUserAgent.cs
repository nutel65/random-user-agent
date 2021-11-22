using System;


namespace main
{
    public class Functions {
        public static Random random = new Random();

        public static string OperaUserAgent()
        {
            string version;
            string presto;

            switch (random.Next(4))
            {
                case 0:
                    version = "12.16";
                    presto = "2.12.388";
                    break;

                case 1:
                    version = "12.14";
                    presto = "2.12.388";
                    break;

                case 2:
                    version = "12.02";
                    presto = "2.10.289";
                    break;

                default:
                    version = "12.00";
                    presto = "2.10.181";
                    break;
            }

            return $"Opera/9.80 (Windows NT 10.0; Win64; x64); U) Presto/{presto} Version/{version}";
        }

        public static string ChromeUserAgent()
        {
            int major = random.Next(62, 96);
            int build = random.Next(2100, 4500);
            int branchBuild = random.Next(170);

            return $"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                $"Chrome/{major}.0.{build}.{branchBuild} Safari/537.36";
        }


        private static readonly byte[] FirefoxVersions = {60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93};

        public static string FirefoxUserAgent()
        {
            byte version = FirefoxVersions[random.Next(FirefoxVersions.Length - 1)];

            return $"Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:{version}.0) Gecko/20100101 Firefox/{version}.0";
        }

        public static string OperaMiniUserAgent()
        {
            string os;
            string miniVersion;
            string version;
            string presto;


            switch (random.Next(3))
            {
                case 0:
                    os = "iOS";
                    miniVersion = "7.0.73345";
                    version = "11.62";
                    presto = "2.10.229";
                    break;

                case 1:
                    os = "J2ME/MIDP";
                    miniVersion = "7.1.23511";
                    version = "12.00";
                    presto = "2.10.181";
                    break;

                default:
                    os = "Android";
                    miniVersion = "7.5.54678";
                    version = "12.02";
                    presto = "2.10.289";
                    break;
            }

            return $"Opera/9.80 ({os}; Opera Mini/{miniVersion}/28.2555; U; ru) Presto/{presto} Version/{version}";
        }

        
        public static string EdgeUserAgent()
        {
            int major = random.Next(62, 96);
            int build = random.Next(500, 15000);
            int build2 = random.Next(0, 100);
            
            return $"{ChromeUserAgent()} Edg/{major}.0.{build}.{build2}";

        }

        public static string RandomUserAgent()
        {
            int rand = random.Next(99) + 1;

            // TODO: edge, yandex browser, safari

            if (rand >= 1 && rand <= 60)
                return ChromeUserAgent();

            if (rand > 60 && rand <= 75)
                return FirefoxUserAgent();

            if (rand > 75 && rand <= 93)
                return EdgeUserAgent();

            if (rand > 93 && rand <= 96)
                return OperaUserAgent();

            return OperaMiniUserAgent();
            
        }
        public void GetUsers() {
            // Statements to Execute
        }
    }
    class Program {

        public static void Main(string[] args)
        {
            System.Console.Write(Functions.RandomUserAgent());
        }

        
    }
}