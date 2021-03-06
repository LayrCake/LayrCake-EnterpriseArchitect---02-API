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
    public class StaticModel_6_AspNetUserRepository_Tests : BaseTestInitialise
    {
        private IAspNetUserRepository aspNetUserRepository;

        [TestInitialize]
        public void Test_Setup()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                aspNetUserRepository = new AspNetUserRepository();
            }
        }
		
        [TestMethod]
        public void Generated_Repository_AspNetUser_Initialise()
        {
            Assert.IsNotNull(aspNetUserRepository);
        }

        [TestMethod]
        public void Generated_Repository_AspNetUser_Insert_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = aspNetUserRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<AspNetUserVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.AspNetUserID > 0, "Response AspNetUserId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_AspNetUser_Update_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = aspNetUserRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<AspNetUserVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.AspNetUserID > 0, "Response AspNetUserId is not greater than 0 - Insert Failed");

                var responseUpdate = aspNetUserRepository.Update(response);
                Assert.IsNotNull(responseUpdate, "Response object is null");
                Assert.IsTrue(responseUpdate.AspNetUserID == response.AspNetUserID, "Response AspNetUserId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_AspNetUser_Delete_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = aspNetUserRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<AspNetUserVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.AspNetUserID > 0, "ResponseAspNetUserId is not greater than 0 - Insert Failed");

                var responseDelete = aspNetUserRepository.Delete(response);
                Assert.IsNull(responseDelete, "Response object is not null");

                var responseGet = aspNetUserRepository.Get(response.AspNetUserID);
                Assert.IsNull(responseGet, "Response object was not deleted");
            }
        }

        [TestMethod]
        public void Generated_Repository_AspNetUser_GetAll_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = aspNetUserRepository.GetList();
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_AspNetUser_GetAll_WithCriteria_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var criteria = new AspNetUserVwmCriteria();
                var response = aspNetUserRepository.GetList(criteria);
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_AspNetUser_GetSingle_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = aspNetUserRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<AspNetUserVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.AspNetUserID > 0, "Response AspNetUserId is not greater than 0 - Insert Failed");

                var responseGet = aspNetUserRepository.Get(response.AspNetUserID);
                Assert.IsNotNull(responseGet, "Response object is null");
                Assert.IsTrue(responseGet.AspNetUserID == response.AspNetUserID, "Response didn't return the correct AspNetUser record");
            }
        }
	}
}

