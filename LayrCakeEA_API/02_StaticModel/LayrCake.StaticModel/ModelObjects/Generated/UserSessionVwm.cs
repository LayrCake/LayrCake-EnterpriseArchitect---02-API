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
	public partial class UserSessionVwm : BaseViewModelObject, IViewModelObject
	{
		public int UserSessionID { get; set; }

		public string SessionID { get; set; }

		public int TriesLeft { get; set; }

		public DateTime? LastAccessed { get; set; }

		public int TotalHits { get; set; }

		public int SessionHits { get; set; }

		public string RemoteIP { get; set; }

		public int User_Ref { get; set; }

		public string MobileId { get; set; }

		public UserVwm User { get; set; }

		public UserSessionVwm()
		{
		}
	}
}

