﻿/*------------------------------------------------------------------------------
<auto-generated>
     This code was generated by a tool.
	    Code originates from EA Uml ClassTemplate.t4
     Changes to this file will be lost if the code is regenerated.
	    Code Generated Date: 	08 June 2018
	    ProjectModel: 			LayrCake
	    Requested Namespace:	Model$2. Hosting Model$LayrCake.WebApi$LayrCake$WebApi$Models$Implementation
</auto-generated>
------------------------------------------------------------------------------*/
using LayrCake.WebApi.Models.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

#pragma warning disable CS1998
namespace LayrCake.WebApi.Tests.Repositories.Generated.LiveModelTests
{
    public partial class Api_DDDPackage_Tests : BaseTestInitialise
    {
		public async Task<List<DDDPackage>> GetAll(HttpClient client = null)
		{
	        var request = client.GetAsync("tables/dddpackage");
            Assert.IsNotNull(request, "Request is null");
            var result = request.Result;
            Assert.IsNotNull(result, "Result is null");
            Assert.IsTrue(result.IsSuccessStatusCode, "IsSuccessStatusCode is false");
            Assert.IsTrue(result.StatusCode == HttpStatusCode.OK, "StatusCode is not OK");
            Assert.IsNotNull(result.Content, "Content is null");

            var stream = await result.Content.ReadAsStringAsync();

            var returnItems = JsonConvert.DeserializeObject<List<DDDPackage>>(stream);
			Assert.IsNotNull(returnItems, "Object failed to convert to type");
            Assert.IsNotNull(returnItems.Count > 0, "Challenges Object did not contain any items");
		    return returnItems;
		}

		public async Task Insert(DDDPackage insertItem, HttpClient client = null)
        {
            client = client ?? testClient;
			Uri location;

            // Post a new entity and verify entity returned
            HttpResponseMessage postResponse = client.PostAsJsonAsync("tables/dddpackage", insertItem).Result;
            Assert.AreEqual(HttpStatusCode.Created, postResponse.StatusCode);
            location = postResponse.Headers.Location;
            Assert.IsNotNull(location);

            DDDPackage resultPost = postResponse.Content.ReadAsAsync<DDDPackage>().Result;
                //this.VerifySimpleEntitiesEqual(entity, result);

            // Query the entity back using location header value to ensure it was inserted to the db
            UriBuilder queryUri = new UriBuilder(location) { };
            HttpResponseMessage queryResponse = client.GetAsync(queryUri.Uri).Result;
            Assert.AreEqual(HttpStatusCode.OK, queryResponse.StatusCode);
            DDDPackage resultRead = queryResponse.Content.ReadAsAsync<DDDPackage>().Result;
            //this.VerifySimpleEntitiesEqual(entity, result);

            //Assert.IsNotNull(resultRead.CreatedAt);
            //Assert.IsNotNull(resultRead.UpdatedAt);
        }
	}
}
#pragma warning restore CS1998

