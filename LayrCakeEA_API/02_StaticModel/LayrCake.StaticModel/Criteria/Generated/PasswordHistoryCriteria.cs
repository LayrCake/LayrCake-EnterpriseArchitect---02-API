﻿/*------------------------------------------------------------------------------
<auto-generated>
     This code was generated by a tool.
	    Code originates from EA Uml ClassTemplate.t4
     Changes to this file will be lost if the code is regenerated.
	    Code Generated Date: 	24 June 2018
	    ProjectModel: 			LayrCake
	    Requested Namespace:	Model$2. Hosting Model$LayrCake.StaticModel$LayrCake$StaticModel$ViewModelObjects$Implementation
</auto-generated>
------------------------------------------------------------------------------*/
using System.Collections.Generic;
using WebAppResources;
using NCommon.Specifications;
using LayrCake.StaticModel.ViewModelObjects.Implementation;

namespace LayrCake.StaticModel.Criteria.Implementation
{
	// Render the class
	public partial class PasswordHistoryVwmCriteria : VwmCriteria, IVwmCriteria
	{
		public int PasswordHistoryID { get; set; }

		private Specification<PasswordHistoryVwm> _specification;
		public Specification<PasswordHistoryVwm> Specification
		{
			get { return _specification; }
			set{
				_specification = value;
				base.WhereCondition = this.__expressionSerializer.SerializeText(new Visitor().Visit(InvocationExpander.Expand(value.Predicate)));
			}
		}
	}
}

