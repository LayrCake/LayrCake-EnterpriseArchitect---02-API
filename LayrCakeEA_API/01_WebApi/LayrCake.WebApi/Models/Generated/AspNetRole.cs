﻿/*------------------------------------------------------------------------------
<auto-generated>
     This code was generated by a tool.
	    Code originates from EA Uml ClassTemplate.t4
     Changes to this file will be lost if the code is regenerated.
	    Code Generated Date: 	08 June 2018
	    ProjectModel: 			LayrCake
	    Requested Namespace:	Model$2. Hosting Model$LayrCake.StaticModel$LayrCake$StaticModel$ViewModelObjects$Implementation
</auto-generated>
------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LayrCake.WebApi.Models.Implementation
{
	// Render the class
	public partial class AspNetRole : AzureEntityModel, IAzureTableData // IApiModelObject
	{
		public int AspNetRoleID { get; set; }

		public string Name { get; set; }

		public AspNetRole()
		{
		}
	}
}

