﻿namespace HomeAutio.Mqtt.GoogleHome.Models.Response
{
    /// <summary>
    /// Error response payload reponse object.
    /// </summary>
    public class ErrorResponsePayload
    {
        /// <summary>
        /// Debug string.
        /// </summary>
        public string DebugString { get; set; }

        /// <summary>
        /// Error code.
        /// </summary>
        public string ErrorCode { get; set; }
    }
}
