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
    public partial class DDDMethodRepository : RepositoryBase, IDDDMethodRepository
    {
        public List<DDDMethodVwm> GetList(IVwmCriteria criterion = null) //Criterion
        {
            var request = new DDDMethodRequest().Prepare();
			var dDDMethodVwmList = new List<DDDMethodVwm>();
            request.LoadOptions = ServiceLoadOptions.List;
            request.Action = PersistType.Read;
            if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((DDDMethodVwmCriteria)criterion);
            }

            var response = Client.GetDDDMethods(request);
            Correlate(request, response);

            if (response.DDDMethods != null && response.DDDMethods.Length > 0)
            {
                foreach (var dDDMethod in response.DDDMethods)
                    dDDMethodVwmList.Add(Mapper.ToViewModelObject(dDDMethod));
                //dDDMethodVwmList.AddRange(response.DDDMethods.ToList().Select(x => Mapper.ToViewModelObject(x)));
                return dDDMethodVwmList;
            }
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return new List<DDDMethodVwm>();
        }

		public IQueryable<DDDMethodVwm> GetListQuery(IVwmCriteria criterion = null)
        {
            return GetList(criterion).AsQueryable();
        }

        public DDDMethodVwm Get(int id)
        {
            var request = new DDDMethodRequest().Prepare();
            request.Action = PersistType.Read;
            request.LoadOptions = ServiceLoadOptions.Single;
            request.GetByPrimaryKey = id;

            var response = Client.GetDDDMethods(request);
            Correlate(request, response);

            if (response.DDDMethod != null && response.DDDMethod.DDDMethodID == id)
                return Mapper.ToViewModelObject(response.DDDMethod);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

		public DDDMethodVwm Get(IVwmCriteria criterion = null)
        {
            var request = new DDDMethodRequest().Prepare();
            request.Action = PersistType.Read;
            request.LoadOptions = ServiceLoadOptions.Single;

			if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((DDDMethodVwmCriteria)criterion);
            }

            var response = Client.GetDDDMethods(request);
            Correlate(request, response);

            if (response.DDDMethod != null)
                return Mapper.ToViewModelObject(response.DDDMethod);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        public int GetCount(IVwmCriteria criterion = null)
        {
            return GetList(criterion).Count;
        }

        public DDDMethodVwm Insert(DDDMethodVwm viewModelObj)
        {
            var request = new DDDMethodRequest().Prepare();
            request.Action = PersistType.Insert;
            request.DDDMethod = Mapper.FromViewModelObject(viewModelObj);

            var response = Client.SetDDDMethods(request);
            Correlate(request, response);

            if (response.DDDMethod != null && response.DDDMethod.DDDMethodID > 0)
                return Mapper.ToViewModelObject(response.DDDMethod);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        public DDDMethodVwm Update(DDDMethodVwm viewModelObj)
        {
            var request = new DDDMethodRequest().Prepare();

            request.Action = PersistType.Update;
            request.DDDMethod = Mapper.FromViewModelObject(viewModelObj);

            var response = Client.SetDDDMethods(request);
            Correlate(request, response);

            if (response.DDDMethod != null && response.DDDMethod.DDDMethodID > 0)
                return Mapper.ToViewModelObject(response.DDDMethod);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

		/// <summary>
        /// Updates all records based upon an Where Statement Criteria
        /// </summary>
        /// <param name="viewModelObj"></param>
        /// <returns></returns>
		public List<DDDMethodVwm> Update(IVwmCriteria criterion = null)
        {
            var request = new DDDMethodRequest().Prepare();
            var dDDMethodVwmList = new List<DDDMethodVwm>();

            request.Action = PersistType.Update;

			if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((DDDMethodVwmCriteria)criterion);
            }

            var response = Client.SetDDDMethods(request);
            Correlate(request, response);

            if (response.DDDMethods != null && response.DDDMethods.Length > 0)
            {
                foreach (var dDDMethod in response.DDDMethods)
                    dDDMethodVwmList.Add(Mapper.ToViewModelObject(dDDMethod));
                //dDDMethodVwmList.AddRange(response.DDDMethods.ToList().Select(x => Mapper.ToViewModelObject(x)));
                return dDDMethodVwmList;
            }
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return new List<DDDMethodVwm>();
        }


        public DDDMethodVwm Delete(int id)
        {
            var request = new DDDMethodRequest().Prepare();

            request.Action = PersistType.Delete;
            request.DDDMethod = new DDDMethod() { DDDMethodID = id };
			//request.Criteria = new DDDMethodCriteria() { DDDMethodID = id };

            var response = Client.SetDDDMethods(request);
            Correlate(request, response);

            if (response.DDDMethod != null && response.DDDMethod.DDDMethodID == id)
                return Mapper.ToViewModelObject(response.DDDMethod);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        public DDDMethodVwm Delete(DDDMethodVwm viewModelObj)
        {
            var request = new DDDMethodRequest().Prepare();

            request.Action = PersistType.Delete;
            request.DDDMethod = Mapper.FromViewModelObject(viewModelObj);

            var response = Client.SetDDDMethods(request);
            Correlate(request, response);

            if (response.DDDMethod != null && response.DDDMethod.DDDMethodID > 0 && response.DDDMethod.DDDMethodID == viewModelObj.DDDMethodID)
                return Mapper.ToViewModelObject(response.DDDMethod);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        /// <summary>
        /// Deletes all records based upon an Where Statement Criteria
        /// </summary>
        /// <param name="viewModelObj"></param>
        /// <returns></returns>
		public DDDMethodVwm Delete(IVwmCriteria criterion = null)
        {
            var request = new DDDMethodRequest().Prepare();

            request.Action = PersistType.Delete;

			if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((DDDMethodVwmCriteria)criterion);
            }

            var response = Client.SetDDDMethods(request);
            Correlate(request, response);

			if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }
	}
}

