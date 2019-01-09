namespace Phone
{
    public class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
                    : base(versionNumber, batteryPercentage, carrier, ringTone) {}
                public string Ring() 
                {
                    // your code here
                    return $"...{RingTone}...";
                }
                
                public string Unlock() 
                {
                    // your code here
                    return $"Galaxy {Version} unlocked with fingerprint scanner";
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