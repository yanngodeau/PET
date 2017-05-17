using System.Collections.Generic;

public class RootObject
{
    public int ActTime { get; set; }
    public string ServerTime { get; set; }
    public string Sunrise { get; set; }
    public string Sunset { get; set; }
    public List<Result> result { get; set; }
    public string status { get; set; }
    public string title { get; set; }
}