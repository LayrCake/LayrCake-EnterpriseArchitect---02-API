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
	public partial class DDDMethodVwm : BaseViewModelObject, IViewModelObject
	{
		public int DDDMethodID { get; set; }

		public string MobileId { get; set; }

		public string Name { get; set; }

		public int? SortOrder { get; set; }

		public int? DDDElement_Ref { get; set; }

		public string DataType { get; set; }

		public bool IsArray { get; set; }

		public bool IsComplexType { get; set; }

		public bool IsActive { get; set; }

		public bool IsNullable { get; set; }

		public bool IsForeignKey { get; set; }

		public string ShortDescription { get; set; }

		public DDDElementVwm DDDElement { get; set; }

		public List<DDDAttributeVwm> DDDAttributes { get; set; }

		public DDDMethodVwm()
		{
		    DDDAttributes = new List<DDDAttributeVwm>();
		}
	}
}

