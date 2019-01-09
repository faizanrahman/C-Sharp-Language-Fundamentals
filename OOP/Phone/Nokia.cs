namespace Phone
{
    public class Nokia:Phone,IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
                : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            // your code here
            return $"...{RingTone}...";
        }
        public string Unlock() 
        {
            // your code here
            return $"Nokia {Version} unlocked with passcode";
        }
        public override void DisplayInfo() 
        {
            // your code here
            System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            System.Console.WriteLine(Version);
            System.Console.WriteLine(Battery);
            System.Console.WriteLine(Carrier);
            System.Console.WriteLine(RingTone);
            System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$");            
        }
            
    }
}