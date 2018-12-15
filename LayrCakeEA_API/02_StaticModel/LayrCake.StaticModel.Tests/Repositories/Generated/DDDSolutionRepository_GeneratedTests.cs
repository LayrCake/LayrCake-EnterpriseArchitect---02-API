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
    public class StaticModel_6_DDDSolutionRepository_Tests : BaseTestInitialise
    {
        private IDDDSolutionRepository dDDSolutionRepository;

        [TestInitialize]
        public void Test_Setup()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                dDDSolutionRepository = new DDDSolutionRepository();
            }
        }
		
        [TestMethod]
        public void Generated_Repository_DDDSolution_Initialise()
        {
            Assert.IsNotNull(dDDSolutionRepository);
        }

        [TestMethod]
        public void Generated_Repository_DDDSolution_Insert_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDSolutionRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDSolutionVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDSolutionID > 0, "Response DDDSolutionId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDSolution_Update_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDSolutionRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDSolutionVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDSolutionID > 0, "Response DDDSolutionId is not greater than 0 - Insert Failed");

                var responseUpdate = dDDSolutionRepository.Update(response);
                Assert.IsNotNull(responseUpdate, "Response object is null");
                Assert.IsTrue(responseUpdate.DDDSolutionID == response.DDDSolutionID, "Response DDDSolutionId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDSolution_Delete_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDSolutionRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDSolutionVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDSolutionID > 0, "ResponseDDDSolutionId is not greater than 0 - Insert Failed");

                var responseDelete = dDDSolutionRepository.Delete(response);
                Assert.IsNull(responseDelete, "Response object is not null");

                var responseGet = dDDSolutionRepository.Get(response.DDDSolutionID);
                Assert.IsNull(responseGet, "Response object was not deleted");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDSolution_GetAll_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDSolutionRepository.GetList();
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDSolution_GetAll_WithCriteria_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var criteria = new DDDSolutionVwmCriteria();
                var response = dDDSolutionRepository.GetList(criteria);
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_DDDSolution_GetSingle_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = dDDSolutionRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<DDDSolutionVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.DDDSolutionID > 0, "Response DDDSolutionId is not greater than 0 - Insert Failed");

                var responseGet = dDDSolutionRepository.Get(response.DDDSolutionID);
                Assert.IsNotNull(responseGet, "Response object is null");
                Assert.IsTrue(responseGet.DDDSolutionID == response.DDDSolutionID, "Response didn't return the correct DDDSolution record");
            }
        }
	}
}

