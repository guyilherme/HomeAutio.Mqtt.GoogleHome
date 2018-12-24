﻿using System.Collections.Generic;

namespace HomeAutio.Mqtt.GoogleHome.Validation
{
    /// <summary>
    /// CustomData validator.
    /// </summary>
    public static class CustomDataValidator
    {
        /// <summary>
        /// Validates a CustomData dictionary.
        /// </summary>
        /// <param name="customData">The CustomData to validate.</param>
        /// <returns>Validation errors.</returns>
        public static IEnumerable<string> Validate(IDictionary<string, object> customData)
        {
            return new List<string>();
        }
    }
}
