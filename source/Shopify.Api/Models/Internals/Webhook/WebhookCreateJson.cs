﻿#region Copyright Teference
// ************************************************************************************
// <copyright file="WebhookCreateJson.cs" company="Teference">
// Copyright © Teference 2015. All right reserved.
// </copyright>
// ************************************************************************************
// <author>Jaspalsinh Chauhan</author>
// <email>jachauhan@gmail.com</email>
// <project>Teference - Shopify API - C#.NET SDK</project>
// ************************************************************************************
#endregion

namespace Teference.Shopify.Api.Models.Internals
{
    using Newtonsoft.Json;

    internal sealed class WebhookCreateJson
    {
        [JsonProperty("topic")]
        public string Topic { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("format")]
        public string Format { get; set; }
    }
}