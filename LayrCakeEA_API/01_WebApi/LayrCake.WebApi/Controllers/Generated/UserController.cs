﻿/*------------------------------------------------------------------------------
<auto-generated>
     This code was generated by a tool.
	    Code originates from EA Uml ClassTemplate.t4
     Changes to this file will be lost if the code is regenerated.
	    Code Generated Date: 	29 July 2018
	    ProjectModel: 			LayrCake
	    Requested Namespace:	Model$2. Hosting Model$LayrCake.WebApi$LayrCake$WebApi$Models$Implementation
</auto-generated>
------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Config;
using NCommon.Specifications;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.Tracing;
using Infrastructure.Criteria;
using Infrastructure.Helpers;
using LayrCake.WebApi.Properties;
using LayrCake.WebApi.Models.Implementation;
using Mapper = LayrCake.WebApi.ModelMapper.Mapper;
using LayrCake.StaticModel.Repositories.Abstract;
using LayrCake.StaticModel.Repositories.Implementation;
using LayrCake.StaticModel.Criteria.Implementation;
using LayrCake.StaticModel.ViewModelObjects.Implementation;

namespace LayrCake.WebApi.Controllers.Implementation
{
	[Authorize]
	[MobileAppController]
	[RoutePrefix("tables/user")]
	public partial class UserController : ApiController //: AzureTableController<User>
	{
		internal IUserRepository _userRepository;
		internal ITraceWriter traceWriter;
		internal Specification<User> baseSpec = new Specification<User>(x => true);
        internal UserVwmCriteria criteria = new UserVwmCriteria();

		public UserController(IUserRepository repository)
		{
			_userRepository = repository ?? new UserRepository();
		}
		
        // GET tables/User
        [HttpGet]
        [Route("")]
		public IQueryable<User> GetAllUsers(ODataQueryOptions query)
        { // Temp use Vwm Name Until alternative option can be found to convert Expression (use method in WCF Action Service layer
		    try
            {
				if (query != null)
				{
                    if (query?.Filter?.FilterClause?.Expression != null)
                    {
						var expression = new Visitor().Visit(query.Filter.ToExpression<User>());
						expression = expression != null ? LambdaExpressionHelper<UserVwm, User>.Convert((Expression<Func<User, bool>>)expression, typeof(UserVwm)) : null;
						criteria.Specification = new Specification<UserVwm>((Expression<Func<UserVwm, bool>>)expression);
                    }
                    var top = 1000;
                    if (!string.IsNullOrEmpty(query?.Top?.RawValue))
                        int.TryParse(query.Top.RawValue, out top);
                    var skip = 0;
                    if (!string.IsNullOrEmpty(query?.Skip?.RawValue))
                        int.TryParse(query.Skip.RawValue, out skip);

                    criteria.Pagination = new Pagination()
                    {
                        PageSize = top, PageNumber = skip
                    };
                }

                // Before Fetch
                var result = new List<User>();
                foreach (var returnItem in _userRepository.GetListQuery(criteria))
                    result.Add(Mapper.FromBusinessObject(returnItem));
				// After Fetch
				Dispose();
                return result.AsQueryable();
            }
            catch (HttpResponseException ex)
            {
                this.traceWriter.Error(ex, this.Request, LogCategories.TableControllers);
                throw;
            }
            catch (Exception ex1)
            {
                this.traceWriter.Error(ex1, this.Request, LogCategories.TableControllers);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex1));
            }
        }
		
		// GET tables/Challenge/48D68C86-6EA6-4C25-AA33-223FC9A27959
        [HttpGet]
        [Route("{id}", Name = "GetUserId")]
        public User GetUser(string id)
        {
            try
            {
                var specPackageRef = new Specification<UserVwm>(i => i.MobileId == id);
                var criteria = new UserVwmCriteria { Specification = specPackageRef };

                var result = _userRepository.Get(criteria);
                return Mapper.FromBusinessObject(result);
            }
            catch (HttpResponseException ex)
            {
                this.traceWriter.Error(ex, this.Request, LogCategories.TableControllers);
                throw;
            }
            catch (Exception ex1)
            {
                this.traceWriter.Error(ex1, this.Request, LogCategories.TableControllers);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex1));
            }
        }
		/*
        // GET tables/Challenge/48D68C86-6EA6-4C25-AA33-223FC9A27959
        [HttpGet]
        [Route("{id:int}", Name="GetUserId")]
		public User GetUser(int id)
        {
		    try
            {
				var result = _userRepository.Get(id);
				return Mapper.FromBusinessObject(result);
            }
            catch (HttpResponseException ex)
            {
                this.traceWriter.Error(ex, this.Request, LogCategories.TableControllers);
                throw;
            }
            catch (Exception ex1)
            {
                this.traceWriter.Error(ex1, this.Request, LogCategories.TableControllers);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex1));
            }
        }
		*/
        // PATCH tables/User/48D68C86-6EA6-4C25-AA33-223FC9A27959
        [HttpPatch]
        [Route("{id}")]
		public User PatchUser(string id, User item)
        {
		    if (item == null)
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, TResources.TableController_NullRequestBody));

            if (!ModelState.IsValid)
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState));

            // Add ETag from request If-Match header
            byte[] version = this.Request.GetVersionFromIfMatch();
            if (version != null) item.Version = version;

            try
            {
				var result = _userRepository.Update(Mapper.ToBusinessObject(item));
				return Mapper.FromBusinessObject(result);
            }
            catch (HttpResponseException ex)
            {
                this.traceWriter.Error(ex, this.Request, LogCategories.TableControllers);
                throw;
            }
            catch (Exception ex1)
            {
                this.traceWriter.Error(ex1, this.Request, LogCategories.TableControllers);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex1));
            }
        }

		// POST tables/User
		[HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> PostUser(User item)
        {
		    if (item == null)
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, TResources.TableController_NullRequestBody));

            if (!ModelState.IsValid)
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState));

            try
            {
				var insert = _userRepository.Insert(Mapper.ToBusinessObject(item));
                var current = Mapper.FromBusinessObject(insert);
				return CreatedAtRoute("GetUserId", new { id = current.Id }, current);

			    //var insert = Task.Run(() => _userRepository.Insert(Mapper.ToBusinessObject(item)));
                //var mapping = insert.ContinueWith(map => Mapper.FromBusinessObject(map.Result));
                //return CreatedAtRoute("Tables", new { controller = "user", id = mapping.Result.Id }, mapping.Result);
            }
            catch (HttpResponseException ex)
            {
                this.traceWriter.Error(ex, this.Request, LogCategories.TableControllers);
                throw;
            }
            catch (Exception ex1)
            {
                this.traceWriter.Error(ex1, this.Request, LogCategories.TableControllers);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex1));
            }

        }

        // DELETE tables/Challenge/48D68C86-6EA6-4C25-AA33-223FC9A27959
		[HttpDelete]
        [Route("{id:int}")]
		public async Task<IHttpActionResult> DeleteUser(int id)
        {
			bool result = false;
            try
            {
				var item = _userRepository.Delete(id);
                if (item == null) result = true;
                return Ok(item); 
            }
            catch (HttpResponseException ex)
            {
                this.traceWriter.Error(ex, this.Request, LogCategories.TableControllers);
                throw;
            }
            catch (Exception ex)
            {
                this.traceWriter.Error(ex, this.Request, LogCategories.TableControllers);
                throw new HttpResponseException(this.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex));
            }
            finally
            {
                if (!result) throw new HttpResponseException(this.Request.CreateResponse(HttpStatusCode.NotFound));
            }
        }

		[HttpDelete]
        [Route("")]
		public async Task<IHttpActionResult> DeleteUser(User item)
        {
			bool result = false;
            try
            {
				var returnItem = _userRepository.Delete(Mapper.ToBusinessObject(item));
                if (returnItem == null) result = true;
                return Ok(returnItem); 
            }
            catch (HttpResponseException ex)
            {
                this.traceWriter.Error(ex, this.Request, LogCategories.TableControllers);
                throw;
            }
            catch (Exception ex)
            {
                this.traceWriter.Error(ex, this.Request, LogCategories.TableControllers);
                throw new HttpResponseException(this.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex));
            }
            finally
            {
                if (!result) throw new HttpResponseException(this.Request.CreateResponse(HttpStatusCode.NotFound));
            }
        }
	}
}

