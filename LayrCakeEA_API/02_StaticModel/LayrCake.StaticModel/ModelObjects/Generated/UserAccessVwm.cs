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
	public partial class UserAccessVwm : BaseViewModelObject, IViewModelObject
	{
		public int UserAccessID { get; set; }

		public int UserID { get; set; }

		public string UserStatusCode { get; set; }

		public DateTime AccessStartDate { get; set; }

		public TimeSpan AccessStartTime { get; set; }

		public DateTime? AccessEndDate { get; set; }

		public TimeSpan? AccessEndTime { get; set; }

		public string MobileId { get; set; }

		public UserAccessVwm()
		{
		}
	}
}

