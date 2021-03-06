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
    public class StaticModel_6_CompanyRepository_Tests : BaseTestInitialise
    {
        private ICompanyRepository companyRepository;

        [TestInitialize]
        public void Test_Setup()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                companyRepository = new CompanyRepository();
            }
        }
		
        [TestMethod]
        public void Generated_Repository_Company_Initialise()
        {
            Assert.IsNotNull(companyRepository);
        }

        [TestMethod]
        public void Generated_Repository_Company_Insert_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = companyRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<CompanyVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.CompanyID > 0, "Response CompanyId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_Company_Update_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = companyRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<CompanyVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.CompanyID > 0, "Response CompanyId is not greater than 0 - Insert Failed");

                var responseUpdate = companyRepository.Update(response);
                Assert.IsNotNull(responseUpdate, "Response object is null");
                Assert.IsTrue(responseUpdate.CompanyID == response.CompanyID, "Response CompanyId is not greater than 0 - Insert Failed");
            }
        }

        [TestMethod]
        public void Generated_Repository_Company_Delete_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = companyRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<CompanyVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.CompanyID > 0, "ResponseCompanyId is not greater than 0 - Insert Failed");

                var responseDelete = companyRepository.Delete(response);
                Assert.IsNull(responseDelete, "Response object is not null");

                var responseGet = companyRepository.Get(response.CompanyID);
                Assert.IsNull(responseGet, "Response object was not deleted");
            }
        }

        [TestMethod]
        public void Generated_Repository_Company_GetAll_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = companyRepository.GetList();
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_Company_GetAll_WithCriteria_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var criteria = new CompanyVwmCriteria();
                var response = companyRepository.GetList(criteria);
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.Count > 0, "Response object count is 0");
            }
        }

        [TestMethod]
        public void Generated_Repository_Company_GetSingle_Test()
        {
            using (new HttpSimulator("/", @"c:\inetpub\").SimulateRequest())
            {
                var response = companyRepository.Insert(vwmo.VWMbjectsFactory.CreateNew<CompanyVwm>());
                Assert.IsNotNull(response, "Response object is null");
                Assert.IsTrue(response.CompanyID > 0, "Response CompanyId is not greater than 0 - Insert Failed");

                var responseGet = companyRepository.Get(response.CompanyID);
                Assert.IsNotNull(responseGet, "Response object is null");
                Assert.IsTrue(responseGet.CompanyID == response.CompanyID, "Response didn't return the correct Company record");
            }
        }
	}
}

