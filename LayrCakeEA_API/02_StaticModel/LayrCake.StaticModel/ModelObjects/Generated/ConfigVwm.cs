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
	public partial class ConfigVwm : BaseViewModelObject, IViewModelObject
	{
		public int ConfigID { get; set; }

		public string ConfigSetting { get; set; }

		public string ConfigValue { get; set; }

		public string ModuleExclusionFilter { get; set; }

		public string ConfigNotes { get; set; }

		public string ConfigCategory { get; set; }

		public string SystemProtected { get; set; }

		public string MobileId { get; set; }

		public ConfigVwm()
		{
		}
	}
}

