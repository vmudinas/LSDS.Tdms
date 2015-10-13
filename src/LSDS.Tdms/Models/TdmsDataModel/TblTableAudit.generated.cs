
using System;
using System.ComponentModel;

namespace LSDS.Tdms.Models.TdmsDataModel	
{

	[System.Serializable()]
	public partial class TblTableAudit : IDataErrorInfo, INotifyPropertyChanging, INotifyPropertyChanged, System.Runtime.Serialization.ISerializable
	{
		private int _tableAuditId;

		[System.ComponentModel.DataAnnotations.Required()]
		[System.ComponentModel.DataAnnotations.Key()]
		public virtual int TableAuditId
		{
			get
			{
				return this._tableAuditId;
			}
			set
			{
				if(this._tableAuditId != value)
				{
					this.OnPropertyChanging("TableAuditId");
					this._tableAuditId = value;
					this.OnPropertyChanged("TableAuditId");
				}
			}
		}
		
		private string _applicationFunction;

		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string ApplicationFunction
		{
			get
			{
				return this._applicationFunction;
			}
			set
			{
				if(this._applicationFunction != value)
				{
					this.OnPropertyChanging("ApplicationFunction");
					this._applicationFunction = value;
					this.OnPropertyChanged("ApplicationFunction");
				}
			}
		}
		
		private string _itemName;

		[System.ComponentModel.DataAnnotations.StringLength(25)]
		public virtual string ItemName
		{
			get
			{
				return this._itemName;
			}
			set
			{
				if(this._itemName != value)
				{
					this.OnPropertyChanging("ItemName");
					this._itemName = value;
					this.OnPropertyChanged("ItemName");
				}
			}
		}
		
		private int? _itemId;

		public virtual int? ItemId
		{
			get
			{
				return this._itemId;
			}
			set
			{
				if(this._itemId != value)
				{
					this.OnPropertyChanging("ItemId");
					this._itemId = value;
					this.OnPropertyChanged("ItemId");
				}
			}
		}
		
		private string _userId;
		[System.ComponentModel.DataAnnotations.StringLength(50)]
        		public virtual string UserId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if(this._userId != value)
				{
					this.OnPropertyChanging("UserId");
					this._userId = value;
					this.OnPropertyChanged("UserId");
				}
			}
		}
		
		private DateTime? _auditDate;

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.DateTime)]
		public virtual DateTime? AuditDate
		{
			get
			{
				return this._auditDate;
			}
			set
			{
				if(this._auditDate != value)
				{
					this.OnPropertyChanging("AuditDate");
					this._auditDate = value;
					this.OnPropertyChanged("AuditDate");
				}
			}
		}
		
		private string _audit;

		public virtual string Audit
		{
			get
			{
				return this._audit;
			}
			set
			{
				if(this._audit != value)
				{
					this.OnPropertyChanging("Audit");
					this._audit = value;
					this.OnPropertyChanged("Audit");
				}
			}
		}
		
		#region IDataErrorInfo members
		
		
		private string error = string.Empty;
		
		public string Error
		{
			get
			{
				return this.error;
			}
		}
		
		
		public string this[string propertyName]
		{
			get
			{
				this.ValidatePropertyInternal(propertyName, ref this.error);
		
				return this.error;
			}
		}
		
		protected virtual void ValidatePropertyInternal(string propertyName, ref string error)
		{
		    this.ValidateProperty(propertyName, ref error);
		}
		
		// Please implement this method in a partial class in order to provide the error message depending on each of the properties.
		partial void ValidateProperty(string propertyName, ref string error);
		
		#endregion
		
		#region INotifyPropertyChanging members
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		protected virtual void OnPropertyChanging(string propertyName)
		{
			if(this.PropertyChanging != null)
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		#endregion
		
		#region INotifyPropertyChanged members
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void OnPropertyChanged(string propertyName)
		{
			if(this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		#endregion
		
		#region ISerializable Implementation
		
		public TblTableAudit()
		{
		}
		
		protected TblTableAudit(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.TableAuditId = info.GetInt32("TableAuditId");
			this.ApplicationFunction = info.GetString("ApplicationFunction");
			this.ItemName = info.GetString("ItemName");
			this.ItemId = (int?)info.GetValue("ItemId", typeof(int?));
			this.UserId = info.GetString("UserId");
			this.AuditDate = (DateTime?)info.GetValue("AuditDate", typeof(DateTime?));
			this.Audit = info.GetString("Audit");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("TableAuditId", this.TableAuditId, typeof(int));
			info.AddValue("ApplicationFunction", this.ApplicationFunction, typeof(string));
			info.AddValue("ItemName", this.ItemName, typeof(string));
			info.AddValue("ItemId", this.ItemId, typeof(int?));
			info.AddValue("UserId", this.UserId, typeof(string));
			info.AddValue("AuditDate", this.AuditDate, typeof(DateTime?));
			info.AddValue("Audit", this.Audit, typeof(string));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}

