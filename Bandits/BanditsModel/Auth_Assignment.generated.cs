#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using BanditsModel;

namespace BanditsModel	
{
	public partial class Auth_Assignment
	{
		private long _assignmentId;
		public virtual long AssignmentId
		{
			get
			{
				return this._assignmentId;
			}
			set
			{
				this._assignmentId = value;
			}
		}
		
		private bool _isExplicit;
		public virtual bool IsExplicit
		{
			get
			{
				return this._isExplicit;
			}
			set
			{
				this._isExplicit = value;
			}
		}
		
		private int _userId;
		public virtual int UserId
		{
			get
			{
				return this._userId;
			}
			set
			{
				this._userId = value;
			}
		}
		
		private int? _permissionId;
		public virtual int? PermissionId
		{
			get
			{
				return this._permissionId;
			}
			set
			{
				this._permissionId = value;
			}
		}
		
		private int? _roleId;
		public virtual int? RoleId
		{
			get
			{
				return this._roleId;
			}
			set
			{
				this._roleId = value;
			}
		}
		
		private Auth_Role _auth_Role;
		public virtual Auth_Role Role
		{
			get
			{
				return this._auth_Role;
			}
			set
			{
				this._auth_Role = value;
			}
		}
		
		private Auth_Permission _auth_Permission;
		public virtual Auth_Permission Permission
		{
			get
			{
				return this._auth_Permission;
			}
			set
			{
				this._auth_Permission = value;
			}
		}
		
		private WebUser _webUser;
		public virtual WebUser WebUser
		{
			get
			{
				return this._webUser;
			}
			set
			{
				this._webUser = value;
			}
		}
		
		private IList<Auth_ScopeAssignment> _auth_ScopeAssignments = new List<Auth_ScopeAssignment>();
		public virtual IList<Auth_ScopeAssignment> Auth_ScopeAssignments
		{
			get
			{
				return this._auth_ScopeAssignments;
			}
		}
		
	}
}
#pragma warning restore 1591
