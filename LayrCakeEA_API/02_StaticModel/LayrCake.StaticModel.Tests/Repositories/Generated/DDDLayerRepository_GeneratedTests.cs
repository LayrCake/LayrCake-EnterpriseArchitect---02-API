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
    public class StaticModel_6_DDDLayerRepository_Tests : BaseTestInitialise
    {
        private IDDDLayerRepository dDDLayerRepository;

        [TestInitialize]
        public void Test_Setup()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                dDDLayerRepository = new DDDLayerRepository();
            }
        }
		
        [TestMethod]
        public void Generated_Repository_DDDLayer_Initialise()
        {
            Assert.IsNotNull(dDDLayerRepository);
        }

        [TestMethod]
        public void Generated_Repository_DDDLayer_Insert_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDLayerRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDLayerVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDLayerID > 0, "Response DDDLayerId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDLayer_Update_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDLayerRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDLayerVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDLayerID > 0, "Response DDDLayerId is not greater than 0 - Insert Failed");

                var responseUpdate = dDDLayerRepository.Update(response);
                Assert.IsNotNull(responseUpdate, "Response object is null");
                Assert.IsTrue(responseUpdate.DDDLayerID == response.DDDLayerID, "Response DDDLayerId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDLayer_Delete_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDLayerRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDLayerVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDLayerID > 0, "ResponseDDDLayerId is not greater than 0 - Insert Failed");

                var responseDelete = dDDLayerRepository.Delete(response);
                Assert.IsNull(responseDelete, "Response object is not null");

                var responseGet = dDDLayerRepository.Get(response.DDDLayerID);
                Assert.IsNull(responseGet, "Response object was not deleted");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDLayer_GetAll_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDLayerRepository.GetList();
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDLayer_GetAll_WithCriteria_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var criteria = new DDDLayerVwmCriteria();
                var response = dDDLayerRepository.GetList(criteria);
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDLayer_GetSingle_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDLayerRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDLayerVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDLayerID > 0, "Response DDDLayerId is not greater than 0 - Insert Failed");

                var responseGet = dDDLayerRepository.Get(response.DDDLayerID);
                Assert.IsNotNull(responseGet, "Response object is null");
                Assert.IsTrue(responseGet.DDDLayerID == response.DDDLayerID, "Response didn't return the correct DDDLayer record");
            }
        }
	}
}

