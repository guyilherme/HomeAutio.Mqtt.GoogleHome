﻿using System.Collections.Generic;

namespace HomeAutio.Mqtt.GoogleHome.Models.Request
{
    /// <summary>
    /// Device request object.
    /// </summary>
    public class Device
    {
        /// <summary>
        /// Device id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Custom device data.
        /// </summary>
        public IDictionary<string, object> CustomData { get; set; }
    }
}
