using System.Net;
using System.Runtime.Intrinsics.X86;
using System;
using System.Text.Json.Nodes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Runtime.Serialization;

namespace SpiceRanch
{
    internal class Utils
    {
        /**
         * Error message when the client returns null
         */
        public const string ClientLoginError = "Could not find a user with those credentials, Please try again!";

        /**
         * Mock REST API response for products
         * (*) Uses given data in scenario
         * (*) http://localhost:3000/api/products
         */
        public const string APIRestProductResponse = @"[
          {
            ""id"": 1,
            ""uuid"": ""d24bcac5-daac-4872-93c3-befd60d92c30"",
            ""name"": ""Chicken Korma"",
            ""price"": 3.99
          },
          {
            ""id"": 2,
            ""uuid"": ""34aebce3-f68f-4ae9-ba10-567c0c1a1c6b"",
            ""name"": ""Chicken Tikka"",
            ""price"": 4.99
          },
          {
            ""id"": 3,
            ""uuid"": ""c441e3f3-b5ee-4101-8c4a-9fdd954bb503"",
            ""name"": ""King Prawn"",
            ""price"": 5.99
          },
          {
            ""id"": 4,
            ""uuid"": ""9f078de8-269b-4337-a124-b5927a3018c5"",
            ""name"": ""Margherita Pizza"",
            ""price"": 6.99
          },
          {
            ""id"": 5,
            ""uuid"": ""9971c492-638e-452a-9bbc-f713e86c3333"",
            ""name"": ""Pepperoni Pizza"",
            ""price"": 7.99
          },
          {
            ""id"": 6,
            ""uuid"": ""616e0b4c-97dd-4a84-80c6-15ac67b95581"",
            ""name"": ""Vegetarian Pizza"",
            ""price"": 5.99
          },
          {
            ""id"": 7,
            ""uuid"": ""a2dd4c2e-6e67-41b8-91e4-63a3a5ae6744"",
            ""name"": ""CheeseBurger"",
            ""price"": 3.99,
            ""size"": ""1/4"",
            ""sides"": [
              ""Fries""
            ]
          },
          {
            ""id"": 8,
            ""uuid"": ""ad5879fe-cbf1-492a-83cb-37383c122c09"",
            ""name"": ""CheeseBurger"",
            ""price"": 4.59,
            ""size"": ""1/2"",
            ""sides"": [
              ""Fries""
            ]
          },
          {
            ""id"": 9,
            ""uuid"": ""10eff3e1-9f75-4fb5-9855-d6e0f2f57b09"",
            ""name"": ""Chicken Burger"",
            ""price"": 4.69,
            ""sides"": [
              ""Fries""
            ]
          }
        ]"
        ;

        /**
         * Mock client response
         * (*) Doesn't use data specified by scenario. (All Mock Data)
         * (*) http://localhost:3000/api/clients
         */
        public const string APIRestClientResponse = @"[
          {
            ""id"": 1,
            ""uuid"": ""dca206e5-da29-4b66-bf08-e58bade0f170"",
            ""name"": ""Jarvis"",
            ""password"": ""Jarvis22Tst"",
            ""address"": ""123 Cultson Ave."",
            ""postcode"": ""LH7 2AG"",
            ""email"": ""something @gmail.com"",
            ""contact_number"": ""01946 849362""
          },
          {
            ""id"": 2,
            ""uuid"": ""71576db0-4965-4ca3-9248-67454a4a8bb2"",
            ""name"": ""Noah"",
            ""password"": ""Noah22Tst"",
            ""address"": ""123 Cultson Ave."",
            ""postcode"": ""PD2 7KA"",
            ""email"": ""something @gmail.com"",
            ""contact_number"": ""02165 648633""
          },
          {
            ""id"": 3,
            ""uuid"": ""5a9c101c-9fc9-40d7-a49b-8fb4b12304a4"",
            ""name"": ""Bryan"",
            ""password"": ""Bran22Tst"",
            ""address"": ""123 Cultson Ave."",
            ""postcode"": ""DJ3 8EH"",
            ""email"": ""something @gmail.com"",
            ""contact_number"": ""09674 781565""
          }
        ]";
    }
}
