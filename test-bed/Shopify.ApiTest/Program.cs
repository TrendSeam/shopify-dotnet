﻿namespace Shopify.ApiTest
{
    using System;
    using Shopify.Api;
    using Shopify.Api.Models;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            Task.Run(async () => await program.DoTask());
            Console.ReadLine();
        }

        private async Task DoTask()
        {
            ////IShopifyClient shopifyClient = new ShopifyClient();
            ////var responseCreate = await shopifyClient.Webhooks.CreateAsync("", "", "http://example.net/", WebhookTopic.ShopUpdate);
            ////var responseAll = await shopifyClient.Webhooks.GetAsync("", "");
            ////var responseSingle = await shopifyClient.Webhooks.GetAsync("", "", "");
            ////var updateResponse = await shopifyClient.Webhooks.UpdateAsync("", "", "", "http://example.com/");
            ////var deleteResponse = await shopifyClient.Webhooks.DeleteAsync("", "", "");
        }
    }
}