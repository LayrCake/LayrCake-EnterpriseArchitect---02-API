﻿/*------------------------------------------------------------------------------
<auto-generated>
     This code was generated by a tool.
	    Code originates from EA Uml ClassTemplate.t4
     Changes to this file will be lost if the code is regenerated.
	    Code Generated Date: 	10 June 2018
	    ProjectModel: 			LayrCake
	    Requested Namespace:	Model$2. Hosting Model$LayrCake.StaticModel$LayrCake$StaticModel$ViewModelObjects$Implementation
</auto-generated>
------------------------------------------------------------------------------*/
using LayrCake.StaticModel.Criteria.Implementation;
using LayrCake.StaticModel.Repositories;
using LayrCake.StaticModel.Repositories.Abstract;
using LayrCake.StaticModel.Repositories.Implementation;
using LayrCake.StaticModel.ViewModelObjects.Implementation;
using Infrastructure.TestsData.HelpersWeb;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using vwmo = Infrastructure.TestData._StaticModel.ViewModelObjects;

namespace LayrCake.StaticModel.Tests.Repositories.Generated.LiveModelTests
{
    [TestClass]
    public class StaticModel_6_AspNetUserClaimRepository_Tests : BaseTestInitialise
    {
        private IAspNetUserClaimRepository aspNetUserClaimRepository;

        [TestInitialize]
        public void Test_Setup()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                aspNetUserClaimRepository = new AspNetUserClaimRepository();
            }
        }
		
        [TestMethod]
        public void Generated_Repository_AspNetUserClaim_Initialise()
        {
            Assert.IsNotNull(aspNetUserClaimRepository);
        }

        [TestMethod]
        public void Generated_Repository_AspNetUserClaim_Insert_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = aspNetUserClaimRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<AspNetUserClaimVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.AspNetUserClaimID > 0, "Response AspNetUserClaimId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_AspNetUserClaim_Update_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = aspNetUserClaimRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<AspNetUserClaimVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.AspNetUserClaimID > 0, "Response AspNetUserClaimId is not greater than 0 - Insert Failed");

                var responseUpdate = aspNetUserClaimRepository.Update(response);
                Assert.IsNotNull(responseUpdate, "Response object is null");
                Assert.IsTrue(responseUpdate.AspNetUserClaimID == response.AspNetUserClaimID, "Response AspNetUserClaimId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_AspNetUserClaim_Delete_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = aspNetUserClaimRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<AspNetUserClaimVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.AspNetUserClaimID > 0, "ResponseAspNetUserClaimId is not greater than 0 - Insert Failed");

                var responseDelete = aspNetUserClaimRepository.Delete(response);
                Assert.IsNull(responseDelete, "Response object is not null");

                var responseGet = aspNetUserClaimRepository.Get(response.AspNetUserClaimID);
                Assert.IsNull(responseGet, "Response object was not deleted");
            }
        }

        [TestMethod]
        public void Generated_Repository_AspNetUserClaim_GetAll_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = aspNetUserClaimRepository.GetList();
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_AspNetUserClaim_GetAll_WithCriteria_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var criteria = new AspNetUserClaimVwmCriteria();
                var response = aspNetUserClaimRepository.GetList(criteria);
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_AspNetUserClaim_GetSingle_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = aspNetUserClaimRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<AspNetUserClaimVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.AspNetUserClaimID > 0, "Response AspNetUserClaimId is not greater than 0 - Insert Failed");

                var responseGet = aspNetUserClaimRepository.Get(response.AspNetUserClaimID);
                Assert.IsNotNull(responseGet, "Response object is null");
                Assert.IsTrue(responseGet.AspNetUserClaimID == response.AspNetUserClaimID, "Response didn't return the correct AspNetUserClaim record");
            }
        }
	}
}

