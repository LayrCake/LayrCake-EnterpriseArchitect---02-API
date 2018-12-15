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
    public class StaticModel_6_DDDProjectRepository_Tests : BaseTestInitialise
    {
        private IDDDProjectRepository dDDProjectRepository;

        [TestInitialize]
        public void Test_Setup()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                dDDProjectRepository = new DDDProjectRepository();
            }
        }
		
        [TestMethod]
        public void Generated_Repository_DDDProject_Initialise()
        {
            Assert.IsNotNull(dDDProjectRepository);
        }

        [TestMethod]
        public void Generated_Repository_DDDProject_Insert_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDProjectRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDProjectVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDProjectID > 0, "Response DDDProjectId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDProject_Update_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDProjectRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDProjectVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDProjectID > 0, "Response DDDProjectId is not greater than 0 - Insert Failed");

                var responseUpdate = dDDProjectRepository.Update(response);
                Assert.IsNotNull(responseUpdate, "Response object is null");
                Assert.IsTrue(responseUpdate.DDDProjectID == response.DDDProjectID, "Response DDDProjectId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDProject_Delete_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDProjectRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDProjectVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDProjectID > 0, "ResponseDDDProjectId is not greater than 0 - Insert Failed");

                var responseDelete = dDDProjectRepository.Delete(response);
                Assert.IsNull(responseDelete, "Response object is not null");

                var responseGet = dDDProjectRepository.Get(response.DDDProjectID);
                Assert.IsNull(responseGet, "Response object was not deleted");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDProject_GetAll_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDProjectRepository.GetList();
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDProject_GetAll_WithCriteria_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var criteria = new DDDProjectVwmCriteria();
                var response = dDDProjectRepository.GetList(criteria);
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDProject_GetSingle_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDProjectRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDProjectVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDProjectID > 0, "Response DDDProjectId is not greater than 0 - Insert Failed");

                var responseGet = dDDProjectRepository.Get(response.DDDProjectID);
                Assert.IsNotNull(responseGet, "Response object is null");
                Assert.IsTrue(responseGet.DDDProjectID == response.DDDProjectID, "Response didn't return the correct DDDProject record");
            }
        }
	}
}
