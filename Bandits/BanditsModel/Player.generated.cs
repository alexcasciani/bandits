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
	public partial class Player
	{
		private bool _isDeleted;
		public virtual bool IsDeleted
		{
			get
			{
				return this._isDeleted;
			}
			set
			{
				this._isDeleted = value;
			}
		}
		
		private int _playerId;
		public virtual int PlayerId
		{
			get
			{
				return this._playerId;
			}
			set
			{
				this._playerId = value;
			}
		}
		
		private DateTime _createDate;
		public virtual DateTime CreateDate
		{
			get
			{
				return this._createDate;
			}
			set
			{
				this._createDate = value;
			}
		}
		
		private DateTime? _modifyDate;
		public virtual DateTime? ModifyDate
		{
			get
			{
				return this._modifyDate;
			}
			set
			{
				this._modifyDate = value;
			}
		}
		
		private Person _person;
		public virtual Person Person
		{
			get
			{
				return this._person;
			}
			set
			{
				this._person = value;
			}
		}
		
		private IList<Guardian> _guardians = new List<Guardian>();
		public virtual IList<Guardian> Guardians
		{
			get
			{
				return this._guardians;
			}
		}
		
	}
}
#pragma warning restore 1591
