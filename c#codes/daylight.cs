using System;

class daylight
{
    static void Main()
    {
        // Get the local time zone
        TimeZoneInfo localZone = TimeZoneInfo.Local;
        Console.WriteLine("Local Time Zone: " + localZone.DisplayName);
        DisplayDaylightSavingInfo(localZone);

        
        
    }

    static void DisplayDaylightSavingInfo(TimeZoneInfo timeZone)
    {
        bool supportsDST = timeZone.SupportsDaylightSavingTime;

        if (supportsDST)
        {
            TimeSpan daylightDelta = timeZone.BaseUtcOffset - timeZone.GetUtcOffset(DateTime.UtcNow);
            TimeZoneInfo.AdjustmentRule[] adjustmentRules = timeZone.GetAdjustmentRules();

            foreach (var rule in adjustmentRules)
            {
                Console.WriteLine("Daylight Saving Time starts: " + rule.DaylightTransitionStart);
                Console.WriteLine("Daylight Saving Time ends: " + rule.DaylightTransitionEnd);
                Console.WriteLine("Daylight Delta: " + daylightDelta);
            }
        }
        else
        {
            Console.WriteLine("This time zone does not support daylight saving time.");
        }
    }
}

