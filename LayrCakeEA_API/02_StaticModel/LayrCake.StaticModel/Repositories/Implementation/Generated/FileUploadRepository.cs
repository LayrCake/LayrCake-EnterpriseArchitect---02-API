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
    public partial class FileUploadRepository : RepositoryBase, IFileUploadRepository
    {
        public List<FileUploadVwm> GetList(IVwmCriteria criterion = null) //Criterion
        {
            var request = new FileUploadRequest().Prepare();
			var fileUploadVwmList = new List<FileUploadVwm>();
            request.LoadOptions = ServiceLoadOptions.List;
            request.Action = PersistType.Read;
            if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((FileUploadVwmCriteria)criterion);
            }

            var response = Client.GetFileUploads(request);
            Correlate(request, response);

            if (response.FileUploads != null && response.FileUploads.Length > 0)
            {
                foreach (var fileUpload in response.FileUploads)
                    fileUploadVwmList.Add(Mapper.ToViewModelObject(fileUpload));
                //fileUploadVwmList.AddRange(response.FileUploads.ToList().Select(x => Mapper.ToViewModelObject(x)));
                return fileUploadVwmList;
            }
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return new List<FileUploadVwm>();
        }

		public IQueryable<FileUploadVwm> GetListQuery(IVwmCriteria criterion = null)
        {
            return GetList(criterion).AsQueryable();
        }

        public FileUploadVwm Get(int id)
        {
            var request = new FileUploadRequest().Prepare();
            request.Action = PersistType.Read;
            request.LoadOptions = ServiceLoadOptions.Single;
            request.GetByPrimaryKey = id;

            var response = Client.GetFileUploads(request);
            Correlate(request, response);

            if (response.FileUpload != null && response.FileUpload.FileUploadID == id)
                return Mapper.ToViewModelObject(response.FileUpload);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

		public FileUploadVwm Get(IVwmCriteria criterion = null)
        {
            var request = new FileUploadRequest().Prepare();
            request.Action = PersistType.Read;
            request.LoadOptions = ServiceLoadOptions.Single;

			if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((FileUploadVwmCriteria)criterion);
            }

            var response = Client.GetFileUploads(request);
            Correlate(request, response);

            if (response.FileUpload != null)
                return Mapper.ToViewModelObject(response.FileUpload);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        public int GetCount(IVwmCriteria criterion = null)
        {
            return GetList(criterion).Count;
        }

        public FileUploadVwm Insert(FileUploadVwm viewModelObj)
        {
            var request = new FileUploadRequest().Prepare();
            request.Action = PersistType.Insert;
            request.FileUpload = Mapper.FromViewModelObject(viewModelObj);

            var response = Client.SetFileUploads(request);
            Correlate(request, response);

            if (response.FileUpload != null && response.FileUpload.FileUploadID > 0)
                return Mapper.ToViewModelObject(response.FileUpload);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        public FileUploadVwm Update(FileUploadVwm viewModelObj)
        {
            var request = new FileUploadRequest().Prepare();

            request.Action = PersistType.Update;
            request.FileUpload = Mapper.FromViewModelObject(viewModelObj);

            var response = Client.SetFileUploads(request);
            Correlate(request, response);

            if (response.FileUpload != null && response.FileUpload.FileUploadID > 0)
                return Mapper.ToViewModelObject(response.FileUpload);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

		/// <summary>
        /// Updates all records based upon an Where Statement Criteria
        /// </summary>
        /// <param name="viewModelObj"></param>
        /// <returns></returns>
		public List<FileUploadVwm> Update(IVwmCriteria criterion = null)
        {
            var request = new FileUploadRequest().Prepare();
            var fileUploadVwmList = new List<FileUploadVwm>();

            request.Action = PersistType.Update;

			if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((FileUploadVwmCriteria)criterion);
            }

            var response = Client.SetFileUploads(request);
            Correlate(request, response);

            if (response.FileUploads != null && response.FileUploads.Length > 0)
            {
                foreach (var fileUpload in response.FileUploads)
                    fileUploadVwmList.Add(Mapper.ToViewModelObject(fileUpload));
                //fileUploadVwmList.AddRange(response.FileUploads.ToList().Select(x => Mapper.ToViewModelObject(x)));
                return fileUploadVwmList;
            }
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return new List<FileUploadVwm>();
        }


        public FileUploadVwm Delete(int id)
        {
            var request = new FileUploadRequest().Prepare();

            request.Action = PersistType.Delete;
            request.FileUpload = new FileUpload() { FileUploadID = id };
			//request.Criteria = new FileUploadCriteria() { FileUploadID = id };

            var response = Client.SetFileUploads(request);
            Correlate(request, response);

            if (response.FileUpload != null && response.FileUpload.FileUploadID == id)
                return Mapper.ToViewModelObject(response.FileUpload);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        public FileUploadVwm Delete(FileUploadVwm viewModelObj)
        {
            var request = new FileUploadRequest().Prepare();

            request.Action = PersistType.Delete;
            request.FileUpload = Mapper.FromViewModelObject(viewModelObj);

            var response = Client.SetFileUploads(request);
            Correlate(request, response);

            if (response.FileUpload != null && response.FileUpload.FileUploadID > 0 && response.FileUpload.FileUploadID == viewModelObj.FileUploadID)
                return Mapper.ToViewModelObject(response.FileUpload);
            else if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }

        /// <summary>
        /// Deletes all records based upon an Where Statement Criteria
        /// </summary>
        /// <param name="viewModelObj"></param>
        /// <returns></returns>
		public FileUploadVwm Delete(IVwmCriteria criterion = null)
        {
            var request = new FileUploadRequest().Prepare();

            request.Action = PersistType.Delete;

			if (criterion != null)
            {
			    request.Criteria = Mapper.FromViewModelCriteria((FileUploadVwmCriteria)criterion);
            }

            var response = Client.SetFileUploads(request);
            Correlate(request, response);

			if (!string.IsNullOrEmpty(response.Message)) throw new Exception(response.Message);
            return null;
        }
	}
}

