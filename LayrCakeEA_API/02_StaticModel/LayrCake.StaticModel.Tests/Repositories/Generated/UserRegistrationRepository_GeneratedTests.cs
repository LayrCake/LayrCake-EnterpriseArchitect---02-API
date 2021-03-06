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
    public class StaticModel_6_UserRegistrationRepository_Tests : BaseTestInitialise
    {
        private IUserRegistrationRepository userRegistrationRepository;

        [TestInitialize]
        public void Test_Setup()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                userRegistrationRepository = new UserRegistrationRepository();
            }
        }
		
        [TestMethod]
        public void Generated_Repository_UserRegistration_Initialise()
        {
            Assert.IsNotNull(userRegistrationRepository);
        }

        [TestMethod]
        public void Generated_Repository_UserRegistration_Insert_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = userRegistrationRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<UserRegistrationVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.UserRegistrationID > 0, "Response UserRegistrationId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_UserRegistration_Update_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = userRegistrationRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<UserRegistrationVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.UserRegistrationID > 0, "Response UserRegistrationId is not greater than 0 - Insert Failed");

                var responseUpdate = userRegistrationRepository.Update(response);
                Assert.IsNotNull(responseUpdate, "Response object is null");
                Assert.IsTrue(responseUpdate.UserRegistrationID == response.UserRegistrationID, "Response UserRegistrationId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_UserRegistration_Delete_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = userRegistrationRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<UserRegistrationVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.UserRegistrationID > 0, "ResponseUserRegistrationId is not greater than 0 - Insert Failed");

                var responseDelete = userRegistrationRepository.Delete(response);
                Assert.IsNull(responseDelete, "Response object is not null");

                var responseGet = userRegistrationRepository.Get(response.UserRegistrationID);
                Assert.IsNull(responseGet, "Response object was not deleted");
            }
        }

        [TestMethod]
        public void Generated_Repository_UserRegistration_GetAll_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = userRegistrationRepository.GetList();
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_UserRegistration_GetAll_WithCriteria_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var criteria = new UserRegistrationVwmCriteria();
                var response = userRegistrationRepository.GetList(criteria);
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_UserRegistration_GetSingle_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = userRegistrationRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<UserRegistrationVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.UserRegistrationID > 0, "Response UserRegistrationId is not greater than 0 - Insert Failed");

                var responseGet = userRegistrationRepository.Get(response.UserRegistrationID);
                Assert.IsNotNull(responseGet, "Response object is null");
                Assert.IsTrue(responseGet.UserRegistrationID == response.UserRegistrationID, "Response didn't return the correct UserRegistration record");
            }
        }
	}
}

