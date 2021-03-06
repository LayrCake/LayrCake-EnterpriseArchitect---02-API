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
using LayrCake.WebApi.Models.Implementation;
using LayrCake.StaticModel.ViewModelObjects.Implementation;
using MapTool = AutoMapper;

#pragma warning disable CS0618
namespace LayrCake.WebApi.ModelMapper
{
	// ReSharper disable InconsistentNaming
	#region Maps

	public partial class MapperLoader
	{
		internal bool Mapper_Loader() { 
			bool returnValue = false;
			CreateMap_AspNetRole();
			CreateMap_AspGoogleUser();
			CreateMap_AspNetUser();
			CreateMap_AspNetUserClaim();
			CreateMap_AspNetUserLogin();
			CreateMap_AspNetUserRole();
			CreateMap_Company();
			CreateMap_Config();
			CreateMap_DDDAttribute();
			CreateMap_DDDConnector();
			CreateMap_DDDElement();
			CreateMap_DDDLayer();
			CreateMap_DDDLayerTemplate();
			CreateMap_DDDMethod();
			CreateMap_DDDPackage();
			CreateMap_DDDProblemDomain();
			CreateMap_DDDProject();
			CreateMap_DDDProperty();
			CreateMap_DDDSolution();
			CreateMap_FileUpload();
			CreateMap_PasswordHistory();
			CreateMap_TrafficDetail();
			CreateMap_User();
			CreateMap_UserAccess();
			CreateMap_UserProfile();
			CreateMap_UserRegistration();
			CreateMap_UserSession();
			CreateMap_UserSessionHistory();

			returnValue = true;
			return returnValue;
		}

			#region Convert IMethods

		internal virtual void CreateMap_AspNetRole() { 
			MapTool.Mapper.CreateMap<AspNetRole, AspNetRoleVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<AspNetRoleVwm, AspNetRole>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_AspGoogleUser() { 
			MapTool.Mapper.CreateMap<AspGoogleUser, AspGoogleUserVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<AspGoogleUserVwm, AspGoogleUser>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_AspNetUser() { 
			MapTool.Mapper.CreateMap<AspNetUser, AspNetUserVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.AfterMap((s, c) => { if (c != null && c.AspGoogleUsers != null) foreach (var l in c.AspGoogleUsers) { l.AspNetUser = c; } })
				.AfterMap((s, c) => { if (c != null && c.AspNetUserClaims != null) foreach (var l in c.AspNetUserClaims) { l.AspNetUser = c; } })
				.AfterMap((s, c) => { if (c != null && c.AspNetUserLogins != null) foreach (var l in c.AspNetUserLogins) { l.AspNetUser = c; } })
				.AfterMap((s, c) => { if (c != null && c.AspNetUserRoles != null) foreach (var l in c.AspNetUserRoles) { l.AspNetUser = c; } })
				.AfterMap((s, c) => { if (c != null && c.UserProfiles != null) foreach (var l in c.UserProfiles) { l.AspNetUser = c; } })
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<AspNetUserVwm, AspNetUser>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_AspNetUserClaim() { 
			MapTool.Mapper.CreateMap<AspNetUserClaim, AspNetUserClaimVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<AspNetUserClaimVwm, AspNetUserClaim>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_AspNetUserLogin() { 
			MapTool.Mapper.CreateMap<AspNetUserLogin, AspNetUserLoginVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<AspNetUserLoginVwm, AspNetUserLogin>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_AspNetUserRole() { 
			MapTool.Mapper.CreateMap<AspNetUserRole, AspNetUserRoleVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<AspNetUserRoleVwm, AspNetUserRole>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_Company() { 
			MapTool.Mapper.CreateMap<Company, CompanyVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<CompanyVwm, Company>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_Config() { 
			MapTool.Mapper.CreateMap<Config, ConfigVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<ConfigVwm, Config>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_DDDAttribute() { 
			MapTool.Mapper.CreateMap<DDDAttribute, DDDAttributeVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<DDDAttributeVwm, DDDAttribute>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_DDDConnector() { 
			MapTool.Mapper.CreateMap<DDDConnector, DDDConnectorVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<DDDConnectorVwm, DDDConnector>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_DDDElement() { 
			MapTool.Mapper.CreateMap<DDDElement, DDDElementVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.AfterMap((s, c) => { if (c != null && c.DDDMethods != null) foreach (var l in c.DDDMethods) { l.DDDElement = c; } })
				.AfterMap((s, c) => { if (c != null && c.DDDProperties != null) foreach (var l in c.DDDProperties) { l.DDDElement = c; } })
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<DDDElementVwm, DDDElement>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_DDDLayer() { 
			MapTool.Mapper.CreateMap<DDDLayer, DDDLayerVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.AfterMap((s, c) => { if (c != null && c.DDDPackages != null) foreach (var l in c.DDDPackages) { l.DDDLayer = c; } })
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<DDDLayerVwm, DDDLayer>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_DDDLayerTemplate() { 
			MapTool.Mapper.CreateMap<DDDLayerTemplate, DDDLayerTemplateVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<DDDLayerTemplateVwm, DDDLayerTemplate>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_DDDMethod() { 
			MapTool.Mapper.CreateMap<DDDMethod, DDDMethodVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.AfterMap((s, c) => { if (c != null && c.DDDAttributes != null) foreach (var l in c.DDDAttributes) { l.DDDMethod = c; } })
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<DDDMethodVwm, DDDMethod>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_DDDPackage() { 
			MapTool.Mapper.CreateMap<DDDPackage, DDDPackageVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.AfterMap((s, c) => { if (c != null && c.DDDElements != null) foreach (var l in c.DDDElements) { l.DDDPackage = c; } })
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<DDDPackageVwm, DDDPackage>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_DDDProblemDomain() { 
			MapTool.Mapper.CreateMap<DDDProblemDomain, DDDProblemDomainVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.AfterMap((s, c) => { if (c != null && c.DDDPackages != null) foreach (var l in c.DDDPackages) { l.DDDProblemDomain = c; } })
				.AfterMap((s, c) => { if (c != null && c.DDDSolutions != null) foreach (var l in c.DDDSolutions) { l.DDDProblemDomain = c; } })
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<DDDProblemDomainVwm, DDDProblemDomain>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_DDDProject() { 
			MapTool.Mapper.CreateMap<DDDProject, DDDProjectVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<DDDProjectVwm, DDDProject>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_DDDProperty() { 
			MapTool.Mapper.CreateMap<DDDProperty, DDDPropertyVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<DDDPropertyVwm, DDDProperty>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_DDDSolution() { 
			MapTool.Mapper.CreateMap<DDDSolution, DDDSolutionVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.AfterMap((s, c) => { if (c != null && c.DDDLayers != null) foreach (var l in c.DDDLayers) { l.DDDSolution = c; } })
				.AfterMap((s, c) => { if (c != null && c.DDDPackages != null) foreach (var l in c.DDDPackages) { l.DDDSolution = c; } })
				.AfterMap((s, c) => { if (c != null && c.DDDProjects != null) foreach (var l in c.DDDProjects) { l.DDDSolution = c; } })
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<DDDSolutionVwm, DDDSolution>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_FileUpload() { 
			MapTool.Mapper.CreateMap<FileUpload, FileUploadVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<FileUploadVwm, FileUpload>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_PasswordHistory() { 
			MapTool.Mapper.CreateMap<PasswordHistory, PasswordHistoryVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<PasswordHistoryVwm, PasswordHistory>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_TrafficDetail() { 
			MapTool.Mapper.CreateMap<TrafficDetail, TrafficDetailVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<TrafficDetailVwm, TrafficDetail>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_User() { 
			MapTool.Mapper.CreateMap<User, UserVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.AfterMap((s, c) => { if (c != null && c.AspNetUsers != null) foreach (var l in c.AspNetUsers) { l.User = c; } })
				.AfterMap((s, c) => { if (c != null && c.PasswordHistories != null) foreach (var l in c.PasswordHistories) { l.User = c; } })
				.AfterMap((s, c) => { if (c != null && c.UserProfiles != null) foreach (var l in c.UserProfiles) { l.User = c; } })
				.AfterMap((s, c) => { if (c != null && c.UserSessions != null) foreach (var l in c.UserSessions) { l.User = c; } })
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<UserVwm, User>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_UserAccess() { 
			MapTool.Mapper.CreateMap<UserAccess, UserAccessVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<UserAccessVwm, UserAccess>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_UserProfile() { 
			MapTool.Mapper.CreateMap<UserProfile, UserProfileVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.AfterMap((s, c) => { if (c != null && c.FileUploads != null) foreach (var l in c.FileUploads) { l.UserProfile = c; } })
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<UserProfileVwm, UserProfile>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_UserRegistration() { 
			MapTool.Mapper.CreateMap<UserRegistration, UserRegistrationVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<UserRegistrationVwm, UserRegistration>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_UserSession() { 
			MapTool.Mapper.CreateMap<UserSession, UserSessionVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<UserSessionVwm, UserSession>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}
		internal virtual void CreateMap_UserSessionHistory() { 
			MapTool.Mapper.CreateMap<UserSessionHistory, UserSessionHistoryVwm>()
					.ForMember(dest => dest.MobileId, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.Id)))
					.FixDataObjDest()
				.IgnoreAllNonExisting();
			MapTool.Mapper.CreateMap<UserSessionHistoryVwm, UserSessionHistory>()
					.ForMember(dest => dest.Id, map => map.MapFrom(
							src => MySqlFuncs.LTRIM(src.MobileId)))
					.FixApiObjDest()
					.IgnoreAllNonExisting();
			}

			#endregion Convert IMethods
	}

	#endregion Maps


	public partial class Mapper 
	{ 
		internal static bool Mapper_Load() { return new MapperOverride().Mapper_Loader(); }

		#region ToBusiness FromBusiness Map

			#region AspNetRole
	
				internal static AspNetRoleVwm ToBusinessObject(AspNetRole dataTransferObject) {
				  try { return MapTool.Mapper.Map<AspNetRole, AspNetRoleVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_AspNetRole();
				      return MapTool.Mapper.Map<AspNetRole, AspNetRoleVwm>(dataTransferObject); }
				}
	
				internal static AspNetRole FromBusinessObject(AspNetRoleVwm businessObject) {
				  try { return MapTool.Mapper.Map<AspNetRoleVwm, AspNetRole>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_AspNetRole();
				      return MapTool.Mapper.Map<AspNetRoleVwm, AspNetRole>(businessObject); }
				}
	
			#endregion AspNetRole
			#region AspGoogleUser
	
				internal static AspGoogleUserVwm ToBusinessObject(AspGoogleUser dataTransferObject) {
				  try { return MapTool.Mapper.Map<AspGoogleUser, AspGoogleUserVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_AspGoogleUser();
				      return MapTool.Mapper.Map<AspGoogleUser, AspGoogleUserVwm>(dataTransferObject); }
				}
	
				internal static AspGoogleUser FromBusinessObject(AspGoogleUserVwm businessObject) {
				  try { return MapTool.Mapper.Map<AspGoogleUserVwm, AspGoogleUser>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_AspGoogleUser();
				      return MapTool.Mapper.Map<AspGoogleUserVwm, AspGoogleUser>(businessObject); }
				}
	
			#endregion AspGoogleUser
			#region AspNetUser
	
				internal static AspNetUserVwm ToBusinessObject(AspNetUser dataTransferObject) {
				  try { return MapTool.Mapper.Map<AspNetUser, AspNetUserVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_AspNetUser();
				      return MapTool.Mapper.Map<AspNetUser, AspNetUserVwm>(dataTransferObject); }
				}
	
				internal static AspNetUser FromBusinessObject(AspNetUserVwm businessObject) {
				  try { return MapTool.Mapper.Map<AspNetUserVwm, AspNetUser>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_AspNetUser();
				      return MapTool.Mapper.Map<AspNetUserVwm, AspNetUser>(businessObject); }
				}
	
			#endregion AspNetUser
			#region AspNetUserClaim
	
				internal static AspNetUserClaimVwm ToBusinessObject(AspNetUserClaim dataTransferObject) {
				  try { return MapTool.Mapper.Map<AspNetUserClaim, AspNetUserClaimVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_AspNetUserClaim();
				      return MapTool.Mapper.Map<AspNetUserClaim, AspNetUserClaimVwm>(dataTransferObject); }
				}
	
				internal static AspNetUserClaim FromBusinessObject(AspNetUserClaimVwm businessObject) {
				  try { return MapTool.Mapper.Map<AspNetUserClaimVwm, AspNetUserClaim>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_AspNetUserClaim();
				      return MapTool.Mapper.Map<AspNetUserClaimVwm, AspNetUserClaim>(businessObject); }
				}
	
			#endregion AspNetUserClaim
			#region AspNetUserLogin
	
				internal static AspNetUserLoginVwm ToBusinessObject(AspNetUserLogin dataTransferObject) {
				  try { return MapTool.Mapper.Map<AspNetUserLogin, AspNetUserLoginVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_AspNetUserLogin();
				      return MapTool.Mapper.Map<AspNetUserLogin, AspNetUserLoginVwm>(dataTransferObject); }
				}
	
				internal static AspNetUserLogin FromBusinessObject(AspNetUserLoginVwm businessObject) {
				  try { return MapTool.Mapper.Map<AspNetUserLoginVwm, AspNetUserLogin>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_AspNetUserLogin();
				      return MapTool.Mapper.Map<AspNetUserLoginVwm, AspNetUserLogin>(businessObject); }
				}
	
			#endregion AspNetUserLogin
			#region AspNetUserRole
	
				internal static AspNetUserRoleVwm ToBusinessObject(AspNetUserRole dataTransferObject) {
				  try { return MapTool.Mapper.Map<AspNetUserRole, AspNetUserRoleVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_AspNetUserRole();
				      return MapTool.Mapper.Map<AspNetUserRole, AspNetUserRoleVwm>(dataTransferObject); }
				}
	
				internal static AspNetUserRole FromBusinessObject(AspNetUserRoleVwm businessObject) {
				  try { return MapTool.Mapper.Map<AspNetUserRoleVwm, AspNetUserRole>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_AspNetUserRole();
				      return MapTool.Mapper.Map<AspNetUserRoleVwm, AspNetUserRole>(businessObject); }
				}
	
			#endregion AspNetUserRole
			#region Company
	
				internal static CompanyVwm ToBusinessObject(Company dataTransferObject) {
				  try { return MapTool.Mapper.Map<Company, CompanyVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_Company();
				      return MapTool.Mapper.Map<Company, CompanyVwm>(dataTransferObject); }
				}
	
				internal static Company FromBusinessObject(CompanyVwm businessObject) {
				  try { return MapTool.Mapper.Map<CompanyVwm, Company>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_Company();
				      return MapTool.Mapper.Map<CompanyVwm, Company>(businessObject); }
				}
	
			#endregion Company
			#region Config
	
				internal static ConfigVwm ToBusinessObject(Config dataTransferObject) {
				  try { return MapTool.Mapper.Map<Config, ConfigVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_Config();
				      return MapTool.Mapper.Map<Config, ConfigVwm>(dataTransferObject); }
				}
	
				internal static Config FromBusinessObject(ConfigVwm businessObject) {
				  try { return MapTool.Mapper.Map<ConfigVwm, Config>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_Config();
				      return MapTool.Mapper.Map<ConfigVwm, Config>(businessObject); }
				}
	
			#endregion Config
			#region DDDAttribute
	
				internal static DDDAttributeVwm ToBusinessObject(DDDAttribute dataTransferObject) {
				  try { return MapTool.Mapper.Map<DDDAttribute, DDDAttributeVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDAttribute();
				      return MapTool.Mapper.Map<DDDAttribute, DDDAttributeVwm>(dataTransferObject); }
				}
	
				internal static DDDAttribute FromBusinessObject(DDDAttributeVwm businessObject) {
				  try { return MapTool.Mapper.Map<DDDAttributeVwm, DDDAttribute>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDAttribute();
				      return MapTool.Mapper.Map<DDDAttributeVwm, DDDAttribute>(businessObject); }
				}
	
			#endregion DDDAttribute
			#region DDDConnector
	
				internal static DDDConnectorVwm ToBusinessObject(DDDConnector dataTransferObject) {
				  try { return MapTool.Mapper.Map<DDDConnector, DDDConnectorVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDConnector();
				      return MapTool.Mapper.Map<DDDConnector, DDDConnectorVwm>(dataTransferObject); }
				}
	
				internal static DDDConnector FromBusinessObject(DDDConnectorVwm businessObject) {
				  try { return MapTool.Mapper.Map<DDDConnectorVwm, DDDConnector>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDConnector();
				      return MapTool.Mapper.Map<DDDConnectorVwm, DDDConnector>(businessObject); }
				}
	
			#endregion DDDConnector
			#region DDDElement
	
				internal static DDDElementVwm ToBusinessObject(DDDElement dataTransferObject) {
				  try { return MapTool.Mapper.Map<DDDElement, DDDElementVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDElement();
				      return MapTool.Mapper.Map<DDDElement, DDDElementVwm>(dataTransferObject); }
				}
	
				internal static DDDElement FromBusinessObject(DDDElementVwm businessObject) {
				  try { return MapTool.Mapper.Map<DDDElementVwm, DDDElement>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDElement();
				      return MapTool.Mapper.Map<DDDElementVwm, DDDElement>(businessObject); }
				}
	
			#endregion DDDElement
			#region DDDLayer
	
				internal static DDDLayerVwm ToBusinessObject(DDDLayer dataTransferObject) {
				  try { return MapTool.Mapper.Map<DDDLayer, DDDLayerVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDLayer();
				      return MapTool.Mapper.Map<DDDLayer, DDDLayerVwm>(dataTransferObject); }
				}
	
				internal static DDDLayer FromBusinessObject(DDDLayerVwm businessObject) {
				  try { return MapTool.Mapper.Map<DDDLayerVwm, DDDLayer>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDLayer();
				      return MapTool.Mapper.Map<DDDLayerVwm, DDDLayer>(businessObject); }
				}
	
			#endregion DDDLayer
			#region DDDLayerTemplate
	
				internal static DDDLayerTemplateVwm ToBusinessObject(DDDLayerTemplate dataTransferObject) {
				  try { return MapTool.Mapper.Map<DDDLayerTemplate, DDDLayerTemplateVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDLayerTemplate();
				      return MapTool.Mapper.Map<DDDLayerTemplate, DDDLayerTemplateVwm>(dataTransferObject); }
				}
	
				internal static DDDLayerTemplate FromBusinessObject(DDDLayerTemplateVwm businessObject) {
				  try { return MapTool.Mapper.Map<DDDLayerTemplateVwm, DDDLayerTemplate>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDLayerTemplate();
				      return MapTool.Mapper.Map<DDDLayerTemplateVwm, DDDLayerTemplate>(businessObject); }
				}
	
			#endregion DDDLayerTemplate
			#region DDDMethod
	
				internal static DDDMethodVwm ToBusinessObject(DDDMethod dataTransferObject) {
				  try { return MapTool.Mapper.Map<DDDMethod, DDDMethodVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDMethod();
				      return MapTool.Mapper.Map<DDDMethod, DDDMethodVwm>(dataTransferObject); }
				}
	
				internal static DDDMethod FromBusinessObject(DDDMethodVwm businessObject) {
				  try { return MapTool.Mapper.Map<DDDMethodVwm, DDDMethod>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDMethod();
				      return MapTool.Mapper.Map<DDDMethodVwm, DDDMethod>(businessObject); }
				}
	
			#endregion DDDMethod
			#region DDDPackage
	
				internal static DDDPackageVwm ToBusinessObject(DDDPackage dataTransferObject) {
				  try { return MapTool.Mapper.Map<DDDPackage, DDDPackageVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDPackage();
				      return MapTool.Mapper.Map<DDDPackage, DDDPackageVwm>(dataTransferObject); }
				}
	
				internal static DDDPackage FromBusinessObject(DDDPackageVwm businessObject) {
				  try { return MapTool.Mapper.Map<DDDPackageVwm, DDDPackage>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDPackage();
				      return MapTool.Mapper.Map<DDDPackageVwm, DDDPackage>(businessObject); }
				}
	
			#endregion DDDPackage
			#region DDDProblemDomain
	
				internal static DDDProblemDomainVwm ToBusinessObject(DDDProblemDomain dataTransferObject) {
				  try { return MapTool.Mapper.Map<DDDProblemDomain, DDDProblemDomainVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDProblemDomain();
				      return MapTool.Mapper.Map<DDDProblemDomain, DDDProblemDomainVwm>(dataTransferObject); }
				}
	
				internal static DDDProblemDomain FromBusinessObject(DDDProblemDomainVwm businessObject) {
				  try { return MapTool.Mapper.Map<DDDProblemDomainVwm, DDDProblemDomain>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDProblemDomain();
				      return MapTool.Mapper.Map<DDDProblemDomainVwm, DDDProblemDomain>(businessObject); }
				}
	
			#endregion DDDProblemDomain
			#region DDDProject
	
				internal static DDDProjectVwm ToBusinessObject(DDDProject dataTransferObject) {
				  try { return MapTool.Mapper.Map<DDDProject, DDDProjectVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDProject();
				      return MapTool.Mapper.Map<DDDProject, DDDProjectVwm>(dataTransferObject); }
				}
	
				internal static DDDProject FromBusinessObject(DDDProjectVwm businessObject) {
				  try { return MapTool.Mapper.Map<DDDProjectVwm, DDDProject>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDProject();
				      return MapTool.Mapper.Map<DDDProjectVwm, DDDProject>(businessObject); }
				}
	
			#endregion DDDProject
			#region DDDProperty
	
				internal static DDDPropertyVwm ToBusinessObject(DDDProperty dataTransferObject) {
				  try { return MapTool.Mapper.Map<DDDProperty, DDDPropertyVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDProperty();
				      return MapTool.Mapper.Map<DDDProperty, DDDPropertyVwm>(dataTransferObject); }
				}
	
				internal static DDDProperty FromBusinessObject(DDDPropertyVwm businessObject) {
				  try { return MapTool.Mapper.Map<DDDPropertyVwm, DDDProperty>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDProperty();
				      return MapTool.Mapper.Map<DDDPropertyVwm, DDDProperty>(businessObject); }
				}
	
			#endregion DDDProperty
			#region DDDSolution
	
				internal static DDDSolutionVwm ToBusinessObject(DDDSolution dataTransferObject) {
				  try { return MapTool.Mapper.Map<DDDSolution, DDDSolutionVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDSolution();
				      return MapTool.Mapper.Map<DDDSolution, DDDSolutionVwm>(dataTransferObject); }
				}
	
				internal static DDDSolution FromBusinessObject(DDDSolutionVwm businessObject) {
				  try { return MapTool.Mapper.Map<DDDSolutionVwm, DDDSolution>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_DDDSolution();
				      return MapTool.Mapper.Map<DDDSolutionVwm, DDDSolution>(businessObject); }
				}
	
			#endregion DDDSolution
			#region FileUpload
	
				internal static FileUploadVwm ToBusinessObject(FileUpload dataTransferObject) {
				  try { return MapTool.Mapper.Map<FileUpload, FileUploadVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_FileUpload();
				      return MapTool.Mapper.Map<FileUpload, FileUploadVwm>(dataTransferObject); }
				}
	
				internal static FileUpload FromBusinessObject(FileUploadVwm businessObject) {
				  try { return MapTool.Mapper.Map<FileUploadVwm, FileUpload>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_FileUpload();
				      return MapTool.Mapper.Map<FileUploadVwm, FileUpload>(businessObject); }
				}
	
			#endregion FileUpload
			#region PasswordHistory
	
				internal static PasswordHistoryVwm ToBusinessObject(PasswordHistory dataTransferObject) {
				  try { return MapTool.Mapper.Map<PasswordHistory, PasswordHistoryVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_PasswordHistory();
				      return MapTool.Mapper.Map<PasswordHistory, PasswordHistoryVwm>(dataTransferObject); }
				}
	
				internal static PasswordHistory FromBusinessObject(PasswordHistoryVwm businessObject) {
				  try { return MapTool.Mapper.Map<PasswordHistoryVwm, PasswordHistory>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_PasswordHistory();
				      return MapTool.Mapper.Map<PasswordHistoryVwm, PasswordHistory>(businessObject); }
				}
	
			#endregion PasswordHistory
			#region TrafficDetail
	
				internal static TrafficDetailVwm ToBusinessObject(TrafficDetail dataTransferObject) {
				  try { return MapTool.Mapper.Map<TrafficDetail, TrafficDetailVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_TrafficDetail();
				      return MapTool.Mapper.Map<TrafficDetail, TrafficDetailVwm>(dataTransferObject); }
				}
	
				internal static TrafficDetail FromBusinessObject(TrafficDetailVwm businessObject) {
				  try { return MapTool.Mapper.Map<TrafficDetailVwm, TrafficDetail>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_TrafficDetail();
				      return MapTool.Mapper.Map<TrafficDetailVwm, TrafficDetail>(businessObject); }
				}
	
			#endregion TrafficDetail
			#region User
	
				internal static UserVwm ToBusinessObject(User dataTransferObject) {
				  try { return MapTool.Mapper.Map<User, UserVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_User();
				      return MapTool.Mapper.Map<User, UserVwm>(dataTransferObject); }
				}
	
				internal static User FromBusinessObject(UserVwm businessObject) {
				  try { return MapTool.Mapper.Map<UserVwm, User>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_User();
				      return MapTool.Mapper.Map<UserVwm, User>(businessObject); }
				}
	
			#endregion User
			#region UserAccess
	
				internal static UserAccessVwm ToBusinessObject(UserAccess dataTransferObject) {
				  try { return MapTool.Mapper.Map<UserAccess, UserAccessVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_UserAccess();
				      return MapTool.Mapper.Map<UserAccess, UserAccessVwm>(dataTransferObject); }
				}
	
				internal static UserAccess FromBusinessObject(UserAccessVwm businessObject) {
				  try { return MapTool.Mapper.Map<UserAccessVwm, UserAccess>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_UserAccess();
				      return MapTool.Mapper.Map<UserAccessVwm, UserAccess>(businessObject); }
				}
	
			#endregion UserAccess
			#region UserProfile
	
				internal static UserProfileVwm ToBusinessObject(UserProfile dataTransferObject) {
				  try { return MapTool.Mapper.Map<UserProfile, UserProfileVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_UserProfile();
				      return MapTool.Mapper.Map<UserProfile, UserProfileVwm>(dataTransferObject); }
				}
	
				internal static UserProfile FromBusinessObject(UserProfileVwm businessObject) {
				  try { return MapTool.Mapper.Map<UserProfileVwm, UserProfile>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_UserProfile();
				      return MapTool.Mapper.Map<UserProfileVwm, UserProfile>(businessObject); }
				}
	
			#endregion UserProfile
			#region UserRegistration
	
				internal static UserRegistrationVwm ToBusinessObject(UserRegistration dataTransferObject) {
				  try { return MapTool.Mapper.Map<UserRegistration, UserRegistrationVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_UserRegistration();
				      return MapTool.Mapper.Map<UserRegistration, UserRegistrationVwm>(dataTransferObject); }
				}
	
				internal static UserRegistration FromBusinessObject(UserRegistrationVwm businessObject) {
				  try { return MapTool.Mapper.Map<UserRegistrationVwm, UserRegistration>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_UserRegistration();
				      return MapTool.Mapper.Map<UserRegistrationVwm, UserRegistration>(businessObject); }
				}
	
			#endregion UserRegistration
			#region UserSession
	
				internal static UserSessionVwm ToBusinessObject(UserSession dataTransferObject) {
				  try { return MapTool.Mapper.Map<UserSession, UserSessionVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_UserSession();
				      return MapTool.Mapper.Map<UserSession, UserSessionVwm>(dataTransferObject); }
				}
	
				internal static UserSession FromBusinessObject(UserSessionVwm businessObject) {
				  try { return MapTool.Mapper.Map<UserSessionVwm, UserSession>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_UserSession();
				      return MapTool.Mapper.Map<UserSessionVwm, UserSession>(businessObject); }
				}
	
			#endregion UserSession
			#region UserSessionHistory
	
				internal static UserSessionHistoryVwm ToBusinessObject(UserSessionHistory dataTransferObject) {
				  try { return MapTool.Mapper.Map<UserSessionHistory, UserSessionHistoryVwm>(dataTransferObject); }
				  catch (Exception) { new MapperOverride().CreateMap_UserSessionHistory();
				      return MapTool.Mapper.Map<UserSessionHistory, UserSessionHistoryVwm>(dataTransferObject); }
				}
	
				internal static UserSessionHistory FromBusinessObject(UserSessionHistoryVwm businessObject) {
				  try { return MapTool.Mapper.Map<UserSessionHistoryVwm, UserSessionHistory>(businessObject); }
				  catch (Exception) { new MapperOverride().CreateMap_UserSessionHistory();
				      return MapTool.Mapper.Map<UserSessionHistoryVwm, UserSessionHistory>(businessObject); }
				}
	
			#endregion UserSessionHistory

			#endregion ToBusiness FromBusiness Map
	}
	// ReSharper restore InconsistentNaming
}
#pragma warning restore CS0618
