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
    public class StaticModel_6_DDDPropertyRepository_Tests : BaseTestInitialise
    {
        private IDDDPropertyRepository dDDPropertyRepository;

        [TestInitialize]
        public void Test_Setup()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                dDDPropertyRepository = new DDDPropertyRepository();
            }
        }
		
        [TestMethod]
        public void Generated_Repository_DDDProperty_Initialise()
        {
            Assert.IsNotNull(dDDPropertyRepository);
        }

        [TestMethod]
        public void Generated_Repository_DDDProperty_Insert_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDPropertyRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDPropertyVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDPropertyID > 0, "Response DDDPropertyId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDProperty_Update_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDPropertyRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDPropertyVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDPropertyID > 0, "Response DDDPropertyId is not greater than 0 - Insert Failed");

                var responseUpdate = dDDPropertyRepository.Update(response);
                Assert.IsNotNull(responseUpdate, "Response object is null");
                Assert.IsTrue(responseUpdate.DDDPropertyID == response.DDDPropertyID, "Response DDDPropertyId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDProperty_Delete_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDPropertyRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDPropertyVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDPropertyID > 0, "ResponseDDDPropertyId is not greater than 0 - Insert Failed");

                var responseDelete = dDDPropertyRepository.Delete(response);
                Assert.IsNull(responseDelete, "Response object is not null");

                var responseGet = dDDPropertyRepository.Get(response.DDDPropertyID);
                Assert.IsNull(responseGet, "Response object was not deleted");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDProperty_GetAll_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDPropertyRepository.GetList();
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDProperty_GetAll_WithCriteria_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var criteria = new DDDPropertyVwmCriteria();
                var response = dDDPropertyRepository.GetList(criteria);
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDProperty_GetSingle_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDPropertyRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDPropertyVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDPropertyID > 0, "Response DDDPropertyId is not greater than 0 - Insert Failed");

                var responseGet = dDDPropertyRepository.Get(response.DDDPropertyID);
                Assert.IsNotNull(responseGet, "Response object is null");
                Assert.IsTrue(responseGet.DDDPropertyID == response.DDDPropertyID, "Response didn't return the correct DDDProperty record");
            }
        }
	}
}

