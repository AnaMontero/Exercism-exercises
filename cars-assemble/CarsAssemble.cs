using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed >= 1 && speed <= 4)
            return 1;
        if(speed >= 5 && speed <= 8)
            return 0.9;
        if(speed == 9)
            return 0.8;
        if(speed == 10)
            return 0.77;
        return 0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return 1;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return 2;
    }
}