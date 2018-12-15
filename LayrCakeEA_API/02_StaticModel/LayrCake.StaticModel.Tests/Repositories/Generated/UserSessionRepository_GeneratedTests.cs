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
    public class StaticModel_6_UserSessionRepository_Tests : BaseTestInitialise
    {
        private IUserSessionRepository userSessionRepository;

        [TestInitialize]
        public void Test_Setup()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                userSessionRepository = new UserSessionRepository();
            }
        }
		
        [TestMethod]
        public void Generated_Repository_UserSession_Initialise()
        {
            Assert.IsNotNull(userSessionRepository);
        }

        [TestMethod]
        public void Generated_Repository_UserSession_Insert_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = userSessionRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<UserSessionVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.UserSessionID > 0, "Response UserSessionId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_UserSession_Update_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = userSessionRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<UserSessionVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.UserSessionID > 0, "Response UserSessionId is not greater than 0 - Insert Failed");

                var responseUpdate = userSessionRepository.Update(response);
                Assert.IsNotNull(responseUpdate, "Response object is null");
                Assert.IsTrue(responseUpdate.UserSessionID == response.UserSessionID, "Response UserSessionId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_UserSession_Delete_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = userSessionRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<UserSessionVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.UserSessionID > 0, "ResponseUserSessionId is not greater than 0 - Insert Failed");

                var responseDelete = userSessionRepository.Delete(response);
                Assert.IsNull(responseDelete, "Response object is not null");

                var responseGet = userSessionRepository.Get(response.UserSessionID);
                Assert.IsNull(responseGet, "Response object was not deleted");
            }
        }

        [TestMethod]
        public void Generated_Repository_UserSession_GetAll_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = userSessionRepository.GetList();
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_UserSession_GetAll_WithCriteria_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var criteria = new UserSessionVwmCriteria();
                var response = userSessionRepository.GetList(criteria);
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_UserSession_GetSingle_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = userSessionRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<UserSessionVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.UserSessionID > 0, "Response UserSessionId is not greater than 0 - Insert Failed");

                var responseGet = userSessionRepository.Get(response.UserSessionID);
                Assert.IsNotNull(responseGet, "Response object is null");
                Assert.IsTrue(responseGet.UserSessionID == response.UserSessionID, "Response didn't return the correct UserSession record");
            }
        }
	}
}

