using Newtonsoft.Json;

[System.Serializable]
public class Event
{
    public string Action;

    [JsonProperty(PropertyName = "interface")]
    public string Interface;

    public string Value;
}