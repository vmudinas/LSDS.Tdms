
using System.ComponentModel;


namespace LSDS.Tdms.Models.TdmsDataModel
{

	[System.Serializable()]
	public partial class QuickfindMC : IDataErrorInfo, INotifyPropertyChanging, INotifyPropertyChanged, System.Runtime.Serialization.ISerializable
	{
		private int _quickfindID;
	
		[System.ComponentModel.DataAnnotations.Required()]
		[System.ComponentModel.DataAnnotations.Key()]
		public virtual int QuickfindID
		{
			get
			{
				return this._quickfindID;
			}
			set
			{
				if(this._quickfindID != value)
				{
					this.OnPropertyChanging("QuickfindID");
					this._quickfindID = value;
					this.OnPropertyChanged("QuickfindID");
				}
			}
		}
		
		private int? _table_ID;
	
		public virtual int? Table_ID
		{
			get
			{
				return this._table_ID;
			}
			set
			{
				if(this._table_ID != value)
				{
					this.OnPropertyChanging("Table_ID");
					this._table_ID = value;
					this.OnPropertyChanged("Table_ID");
				}
			}
		}
		
		private string _sourceName;
	
		[System.ComponentModel.DataAnnotations.StringLength(100)]
		public virtual string SourceName
		{
			get
			{
				return this._sourceName;
			}
			set
			{
				if(this._sourceName != value)
				{
					this.OnPropertyChanging("SourceName");
					this._sourceName = value;
					this.OnPropertyChanged("SourceName");
				}
			}
		}
		
		private string _user_name;
		
		[System.ComponentModel.DataAnnotations.StringLength(100)]
		public virtual string User_name
		{
			get
			{
				return this._user_name;
			}
			set
			{
				if(this._user_name != value)
				{
					this.OnPropertyChanging("User_name");
					this._user_name = value;
					this.OnPropertyChanged("User_name");
				}
			}
		}
		
		private string _description;
		
		[System.ComponentModel.DataAnnotations.StringLength(250)]
		public virtual string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if(this._description != value)
				{
					this.OnPropertyChanging("Description");
					this._description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}
		
		private bool? _systemQF;
	
		public virtual bool? SystemQF
		{
			get
			{
				return this._systemQF;
			}
			set
			{
				if(this._systemQF != value)
				{
					this.OnPropertyChanging("SystemQF");
					this._systemQF = value;
					this.OnPropertyChanged("SystemQF");
				}
			}
		}
		
		private bool? _lastUsed;
	
		public virtual bool? LastUsed
		{
			get
			{
				return this._lastUsed;
			}
			set
			{
				if(this._lastUsed != value)
				{
					this.OnPropertyChanging("LastUsed");
					this._lastUsed = value;
					this.OnPropertyChanged("LastUsed");
				}
			}
		}
		
		private int _tdUserGroupId;
		
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual int TdUserGroupId
		{
			get
			{
				return this._tdUserGroupId;
			}
			set
			{
				if(this._tdUserGroupId != value)
				{
					this.OnPropertyChanging("TdUserGroupId");
					this._tdUserGroupId = value;
					this.OnPropertyChanged("TdUserGroupId");
				}
			}
		}
		
		private int? _lastUsedToday;
		
		public virtual int? LastUsedToday
		{
			get
			{
				return this._lastUsedToday;
			}
			set
			{
				if(this._lastUsedToday != value)
				{
					this.OnPropertyChanging("LastUsedToday");
					this._lastUsedToday = value;
					this.OnPropertyChanged("LastUsedToday");
				}
			}
		}
		
		private int? _lastUsedRow;
		
		public virtual int? LastUsedRow
		{
			get
			{
				return this._lastUsedRow;
			}
			set
			{
				if(this._lastUsedRow != value)
				{
					this.OnPropertyChanging("LastUsedRow");
					this._lastUsedRow = value;
					this.OnPropertyChanged("LastUsedRow");
				}
			}
		}
		
		private int? _lastUsedPage;
		
		public virtual int? LastUsedPage
		{
			get
			{
				return this._lastUsedPage;
			}
			set
			{
				if(this._lastUsedPage != value)
				{
					this.OnPropertyChanging("LastUsedPage");
					this._lastUsedPage = value;
					this.OnPropertyChanged("LastUsedPage");
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
		
		public QuickfindMC()
		{
		}
		
		protected QuickfindMC(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.QuickfindID = info.GetInt32("QuickfindID");
			this.Table_ID = (int?)info.GetValue("Table_ID", typeof(int?));
			this.SourceName = info.GetString("SourceName");
			this.User_name = info.GetString("User_name");
			this.Description = info.GetString("Description");
			this.SystemQF = (bool?)info.GetValue("SystemQF", typeof(bool?));
			this.LastUsed = (bool?)info.GetValue("LastUsed", typeof(bool?));
			this.TdUserGroupId = info.GetInt32("TdUserGroupId");
			this.LastUsedToday = (int?)info.GetValue("LastUsedToday", typeof(int?));
			this.LastUsedRow = (int?)info.GetValue("LastUsedRow", typeof(int?));
			this.LastUsedPage = (int?)info.GetValue("LastUsedPage", typeof(int?));
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("QuickfindID", this.QuickfindID, typeof(int));
			info.AddValue("Table_ID", this.Table_ID, typeof(int?));
			info.AddValue("SourceName", this.SourceName, typeof(string));
			info.AddValue("User_name", this.User_name, typeof(string));
			info.AddValue("Description", this.Description, typeof(string));
			info.AddValue("SystemQF", this.SystemQF, typeof(bool?));
			info.AddValue("LastUsed", this.LastUsed, typeof(bool?));
			info.AddValue("TdUserGroupId", this.TdUserGroupId, typeof(int));
			info.AddValue("LastUsedToday", this.LastUsedToday, typeof(int?));
			info.AddValue("LastUsedRow", this.LastUsedRow, typeof(int?));
			info.AddValue("LastUsedPage", this.LastUsedPage, typeof(int?));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}

