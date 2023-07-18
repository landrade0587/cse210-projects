class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();

        DateOnly date1 = new DateOnly(2023,7,20);
        DateOnly date2 = new DateOnly(2023,8,7);
        DateOnly date3 = new DateOnly(2023,9,15);
                  
        RunningActivity running = new RunningActivity(date1, 30, (float)4.8);
        activityList.Add(running);

        CyclingActivity cycling = new CyclingActivity(date2, 30, (float)6.0);
        activityList.Add(cycling);

        SwimmingActivity swimming = new SwimmingActivity(date3, 30, 50);
        activityList.Add(swimming);

        foreach (Activity activity in activityList)
        {
            activity.GetSummary(activity.GetDistance(), activity.GetSpeed(), activity.GetPace());
        }        
    }
    
}