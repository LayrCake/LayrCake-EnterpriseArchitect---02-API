﻿/*------------------------------------------------------------------------------
<auto-generated>
     This code was generated by a tool.
	    Code originates from EA Uml ClassTemplate.t4
     Changes to this file will be lost if the code is regenerated.
	    Code Generated Date: 	11 June 2018
	    ProjectModel: 			LayrCake
	    Requested Namespace:	Model$2. Hosting Model$LayrCake.StaticModel$LayrCake$StaticModel$ViewModelObjects$Implementation
</auto-generated>
------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using LayrCake.StaticModel.Repositories.Abstract;
using LayrCake.StaticModel.StaticModelReserved;
using LayrCake.StaticModel.Criteria.Implementation;
using LayrCake.StaticModel.ViewModelObjects.Implementation;
using LayrCake.StaticModel.DataVisualiserServiceReference;
using IVwmCriteria = LayrCake.StaticModel.Criteria.IVwmCriteria;
using StaticModel.Repositories;
using System.Linq;
using Mapper = LayrCake.StaticModel.ModelMapper.Mapper;

namespace LayrCake.StaticModel.Repositories.Implementation
{
    public partial class DDDProblemDomainRepository : RepositoryBase, IDDDProblemDomainRepository
    {
        public List<DDDProblemDomainVwm> GetList(IVwmCriteria criterion = null) //Criterion
        {
            var request = new DDDProblemDomainRequest().Prepare();
			var dDDProblemDomainVwmList = new List<DDDProblemDomainVwm>();
            request.LoadOptions = ServiceLoadOptions.List;
            request.Action = PersistType.Read;
            if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((DDDProblemDomainVwmCriteria)criterion);
            }

            var response = Client.GetDDDProblemDomains(request);
            Correlate(request, response);

            if (response.DDDProblemDomains != null && response.DDDProblemDomains.Length > 0)
            {
                foreach (var dDDProblemDomain in response.DDDProblemDomains)
                    dDDProblemDomainVwmList.Add(Mapper.ToViewModelObject(dDDProblemDomain));
                //dDDProblemDomainVwmList.AddRange(response.DDDProblemDomains.ToList().Select(x => Mapper.ToViewModelObject(x)));
                return dDDProblemDomainVwmList;
            }
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return new List<DDDProblemDomainVwm>();
        }

		public IQueryable<DDDProblemDomainVwm> GetListQuery(IVwmCriteria criterion = null)
        {
            return GetList(criterion).AsQueryable();
        }

        public DDDProblemDomainVwm Get(int id)
        {
            var request = new DDDProblemDomainRequest().Prepare();
            request.Action = PersistType.Read;
            request.LoadOptions = ServiceLoadOptions.Single;
            request.GetByPrimaryKey = id;

            var response = Client.GetDDDProblemDomains(request);
            Correlate(request, response);

            if (response.DDDProblemDomain != null && response.DDDProblemDomain.DDDProblemDomainID == id)
                return Mapper.ToViewModelObject(response.DDDProblemDomain);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

		public DDDProblemDomainVwm Get(IVwmCriteria criterion = null)
        {
            var request = new DDDProblemDomainRequest().Prepare();
            request.Action = PersistType.Read;
            request.LoadOptions = ServiceLoadOptions.Single;

			if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((DDDProblemDomainVwmCriteria)criterion);
            }

            var response = Client.GetDDDProblemDomains(request);
            Correlate(request, response);

            if (response.DDDProblemDomain != null)
                return Mapper.ToViewModelObject(response.DDDProblemDomain);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        public int GetCount(IVwmCriteria criterion = null)
        {
            return GetList(criterion).Count;
        }

        public DDDProblemDomainVwm Insert(DDDProblemDomainVwm viewModelObj)
        {
            var request = new DDDProblemDomainRequest().Prepare();
            request.Action = PersistType.Insert;
            request.DDDProblemDomain = Mapper.FromViewModelObject(viewModelObj);

            var response = Client.SetDDDProblemDomains(request);
            Correlate(request, response);

            if (response.DDDProblemDomain != null && response.DDDProblemDomain.DDDProblemDomainID > 0)
                return Mapper.ToViewModelObject(response.DDDProblemDomain);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        public DDDProblemDomainVwm Update(DDDProblemDomainVwm viewModelObj)
        {
            var request = new DDDProblemDomainRequest().Prepare();

            request.Action = PersistType.Update;
            request.DDDProblemDomain = Mapper.FromViewModelObject(viewModelObj);

            var response = Client.SetDDDProblemDomains(request);
            Correlate(request, response);

            if (response.DDDProblemDomain != null && response.DDDProblemDomain.DDDProblemDomainID > 0)
                return Mapper.ToViewModelObject(response.DDDProblemDomain);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

		/// <summary>
        /// Updates all records based upon an Where Statement Criteria
        /// </summary>
        /// <param name="viewModelObj"></param>
        /// <returns></returns>
		public List<DDDProblemDomainVwm> Update(IVwmCriteria criterion = null)
        {
            var request = new DDDProblemDomainRequest().Prepare();
            var dDDProblemDomainVwmList = new List<DDDProblemDomainVwm>();

            request.Action = PersistType.Update;

			if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((DDDProblemDomainVwmCriteria)criterion);
            }

            var response = Client.SetDDDProblemDomains(request);
            Correlate(request, response);

            if (response.DDDProblemDomains != null && response.DDDProblemDomains.Length > 0)
            {
                foreach (var dDDProblemDomain in response.DDDProblemDomains)
                    dDDProblemDomainVwmList.Add(Mapper.ToViewModelObject(dDDProblemDomain));
                //dDDProblemDomainVwmList.AddRange(response.DDDProblemDomains.ToList().Select(x => Mapper.ToViewModelObject(x)));
                return dDDProblemDomainVwmList;
            }
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return new List<DDDProblemDomainVwm>();
        }


        public DDDProblemDomainVwm Delete(int id)
        {
            var request = new DDDProblemDomainRequest().Prepare();

            request.Action = PersistType.Delete;
            request.DDDProblemDomain = new DDDProblemDomain() { DDDProblemDomainID = id };
			//request.Criteria = new DDDProblemDomainCriteria() { DDDProblemDomainID = id };

            var response = Client.SetDDDProblemDomains(request);
            Correlate(request, response);

            if (response.DDDProblemDomain != null && response.DDDProblemDomain.DDDProblemDomainID == id)
                return Mapper.ToViewModelObject(response.DDDProblemDomain);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        public DDDProblemDomainVwm Delete(DDDProblemDomainVwm viewModelObj)
        {
            var request = new DDDProblemDomainRequest().Prepare();

            request.Action = PersistType.Delete;
            request.DDDProblemDomain = Mapper.FromViewModelObject(viewModelObj);

            var response = Client.SetDDDProblemDomains(request);
            Correlate(request, response);

            if (response.DDDProblemDomain != null && response.DDDProblemDomain.DDDProblemDomainID > 0 && response.DDDProblemDomain.DDDProblemDomainID == viewModelObj.DDDProblemDomainID)
                return Mapper.ToViewModelObject(response.DDDProblemDomain);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        /// <summary>
        /// Deletes all records based upon an Where Statement Criteria
        /// </summary>
        /// <param name="viewModelObj"></param>
        /// <returns></returns>
		public DDDProblemDomainVwm Delete(IVwmCriteria criterion = null)
        {
            var request = new DDDProblemDomainRequest().Prepare();

            request.Action = PersistType.Delete;

			if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((DDDProblemDomainVwmCriteria)criterion);
            }

            var response = Client.SetDDDProblemDomains(request);
            Correlate(request, response);

			if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }
	}
}

