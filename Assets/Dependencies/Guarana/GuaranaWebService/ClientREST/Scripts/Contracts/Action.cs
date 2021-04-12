using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[JsonConverter(typeof(StringEnumConverter))]
public enum ActionOptions
{
    start,
    stop,
    pause,
    resume,
    prepare
}


    [JsonObject, Serializable]
    public class Action
    {
        [JsonProperty(PropertyName = "action")]
        public ActionOptions option;

        public float delay;
    }

