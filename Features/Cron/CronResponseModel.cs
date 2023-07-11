﻿namespace HangfireDotNetCoreExample.Features.Cron;

public class CronResponseModel
{
    public string JobId { get; set; }
    public string Name { get; set; }
    public string LastTime { get; set; }
    public string NextTime { get; set; }
    public bool IsRunning { get; set; }

    public string Status
    {
        get => IsRunning ? "Running" : "Stopped";
    }
    public string StopUrl
    {
        get => IsRunning ? $"/Blog/StopCron?jobId={JobId}" : "#";
    }
}