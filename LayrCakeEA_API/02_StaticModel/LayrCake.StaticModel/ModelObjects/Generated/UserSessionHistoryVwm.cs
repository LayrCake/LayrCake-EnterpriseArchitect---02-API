﻿/*------------------------------------------------------------------------------
<auto-generated>
     This code was generated by a tool.
	    Code originates from EA Uml ClassTemplate.t4
     Changes to this file will be lost if the code is regenerated.
	    Code Generated Date: 	08 June 2018
	    ProjectModel: 			LayrCake
	    Requested Namespace:	Model$3. Service Model$LayrCake.ActionService$LayrCake$ActionService$DataTransferObjects$Implementation
</auto-generated>
------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using StaticModel.ViewModelObjects;

namespace LayrCake.StaticModel.ViewModelObjects.Implementation
{
	// Render the class
	public partial class UserSessionHistoryVwm : BaseViewModelObject, IViewModelObject
	{
		public int UserSessionHistoryID { get; set; }

		public DateTime LoginDateTime { get; set; }

		public string LoginStatus_Code { get; set; }

		public int User_Ref { get; set; }

		public string LoginName { get; set; }

		public string RemoteIP { get; set; }

		public string Browser { get; set; }

		public string BrowserVersion { get; set; }

		public string Platform { get; set; }

		public string ResolutionHeight { get; set; }

		public string ResolutionWidth { get; set; }

		public int SessionHits { get; set; }

		public string LogoutDateTime { get; set; }

		public string LogoutStatus_Code { get; set; }

		public string MobileId { get; set; }

		public UserSessionHistoryVwm()
		{
		}
	}
}
