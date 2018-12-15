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
    public partial class DDDProjectRepository : RepositoryBase, IDDDProjectRepository
    {
        public List<DDDProjectVwm> GetList(IVwmCriteria criterion = null) //Criterion
        {
            var request = new DDDProjectRequest().Prepare();
			var dDDProjectVwmList = new List<DDDProjectVwm>();
            request.LoadOptions = ServiceLoadOptions.List;
            request.Action = PersistType.Read;
            if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((DDDProjectVwmCriteria)criterion);
            }

            var response = Client.GetDDDProjects(request);
            Correlate(request, response);

            if (response.DDDProjects != null && response.DDDProjects.Length > 0)
            {
                foreach (var dDDProject in response.DDDProjects)
                    dDDProjectVwmList.Add(Mapper.ToViewModelObject(dDDProject));
                //dDDProjectVwmList.AddRange(response.DDDProjects.ToList().Select(x => Mapper.ToViewModelObject(x)));
                return dDDProjectVwmList;
            }
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return new List<DDDProjectVwm>();
        }

		public IQueryable<DDDProjectVwm> GetListQuery(IVwmCriteria criterion = null)
        {
            return GetList(criterion).AsQueryable();
        }

        public DDDProjectVwm Get(int id)
        {
            var request = new DDDProjectRequest().Prepare();
            request.Action = PersistType.Read;
            request.LoadOptions = ServiceLoadOptions.Single;
            request.GetByPrimaryKey = id;

            var response = Client.GetDDDProjects(request);
            Correlate(request, response);

            if (response.DDDProject != null && response.DDDProject.DDDProjectID == id)
                return Mapper.ToViewModelObject(response.DDDProject);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

		public DDDProjectVwm Get(IVwmCriteria criterion = null)
        {
            var request = new DDDProjectRequest().Prepare();
            request.Action = PersistType.Read;
            request.LoadOptions = ServiceLoadOptions.Single;

			if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((DDDProjectVwmCriteria)criterion);
            }

            var response = Client.GetDDDProjects(request);
            Correlate(request, response);

            if (response.DDDProject != null)
                return Mapper.ToViewModelObject(response.DDDProject);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        public int GetCount(IVwmCriteria criterion = null)
        {
            return GetList(criterion).Count;
        }

        public DDDProjectVwm Insert(DDDProjectVwm viewModelObj)
        {
            var request = new DDDProjectRequest().Prepare();
            request.Action = PersistType.Insert;
            request.DDDProject = Mapper.FromViewModelObject(viewModelObj);

            var response = Client.SetDDDProjects(request);
            Correlate(request, response);

            if (response.DDDProject != null && response.DDDProject.DDDProjectID > 0)
                return Mapper.ToViewModelObject(response.DDDProject);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        public DDDProjectVwm Update(DDDProjectVwm viewModelObj)
        {
            var request = new DDDProjectRequest().Prepare();

            request.Action = PersistType.Update;
            request.DDDProject = Mapper.FromViewModelObject(viewModelObj);

            var response = Client.SetDDDProjects(request);
            Correlate(request, response);

            if (response.DDDProject != null && response.DDDProject.DDDProjectID > 0)
                return Mapper.ToViewModelObject(response.DDDProject);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

		/// <summary>
        /// Updates all records based upon an Where Statement Criteria
        /// </summary>
        /// <param name="viewModelObj"></param>
        /// <returns></returns>
		public List<DDDProjectVwm> Update(IVwmCriteria criterion = null)
        {
            var request = new DDDProjectRequest().Prepare();
            var dDDProjectVwmList = new List<DDDProjectVwm>();

            request.Action = PersistType.Update;

			if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((DDDProjectVwmCriteria)criterion);
            }

            var response = Client.SetDDDProjects(request);
            Correlate(request, response);

            if (response.DDDProjects != null && response.DDDProjects.Length > 0)
            {
                foreach (var dDDProject in response.DDDProjects)
                    dDDProjectVwmList.Add(Mapper.ToViewModelObject(dDDProject));
                //dDDProjectVwmList.AddRange(response.DDDProjects.ToList().Select(x => Mapper.ToViewModelObject(x)));
                return dDDProjectVwmList;
            }
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return new List<DDDProjectVwm>();
        }


        public DDDProjectVwm Delete(int id)
        {
            var request = new DDDProjectRequest().Prepare();

            request.Action = PersistType.Delete;
            request.DDDProject = new DDDProject() { DDDProjectID = id };
			//request.Criteria = new DDDProjectCriteria() { DDDProjectID = id };

            var response = Client.SetDDDProjects(request);
            Correlate(request, response);

            if (response.DDDProject != null && response.DDDProject.DDDProjectID == id)
                return Mapper.ToViewModelObject(response.DDDProject);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        public DDDProjectVwm Delete(DDDProjectVwm viewModelObj)
        {
            var request = new DDDProjectRequest().Prepare();

            request.Action = PersistType.Delete;
            request.DDDProject = Mapper.FromViewModelObject(viewModelObj);

            var response = Client.SetDDDProjects(request);
            Correlate(request, response);

            if (response.DDDProject != null && response.DDDProject.DDDProjectID > 0 && response.DDDProject.DDDProjectID == viewModelObj.DDDProjectID)
                return Mapper.ToViewModelObject(response.DDDProject);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        /// <summary>
        /// Deletes all records based upon an Where Statement Criteria
        /// </summary>
        /// <param name="viewModelObj"></param>
        /// <returns></returns>
		public DDDProjectVwm Delete(IVwmCriteria criterion = null)
        {
            var request = new DDDProjectRequest().Prepare();

            request.Action = PersistType.Delete;

			if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((DDDProjectVwmCriteria)criterion);
            }

            var response = Client.SetDDDProjects(request);
            Correlate(request, response);

			if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }
	}
}

