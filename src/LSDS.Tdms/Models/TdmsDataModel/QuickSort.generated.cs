
using System.ComponentModel;

namespace LSDS.Tdms.Models.TdmsDataModel
{
	
	[System.Serializable()]
	public partial class QuickSort : IDataErrorInfo, INotifyPropertyChanging, INotifyPropertyChanged, System.Runtime.Serialization.ISerializable
	{
		private int _quickSortID;
	
		[System.ComponentModel.DataAnnotations.Required()]
		[System.ComponentModel.DataAnnotations.Key()]
		public virtual int QuickSortID
		{
			get
			{
				return this._quickSortID;
			}
			set
			{
				if(this._quickSortID != value)
				{
					this.OnPropertyChanging("QuickSortID");
					this._quickSortID = value;
					this.OnPropertyChanged("QuickSortID");
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
		
		private bool? _systemQS;
	
		public virtual bool? SystemQS
		{
			get
			{
				return this._systemQS;
			}
			set
			{
				if(this._systemQS != value)
				{
					this.OnPropertyChanging("SystemQS");
					this._systemQS = value;
					this.OnPropertyChanged("SystemQS");
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
		
		private string _quickSort_Query;
	
		[System.ComponentModel.DataAnnotations.StringLength(1000)]
		public virtual string QuickSort_Query
		{
			get
			{
				return this._quickSort_Query;
			}
			set
			{
				if(this._quickSort_Query != value)
				{
					this.OnPropertyChanging("QuickSort_Query");
					this._quickSort_Query = value;
					this.OnPropertyChanged("QuickSort_Query");
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
		
		public QuickSort()
		{
		}
		
		protected QuickSort(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.QuickSortID = info.GetInt32("QuickSortID");
			this.SourceName = info.GetString("SourceName");
			this.User_name = info.GetString("User_name");
			this.Description = info.GetString("Description");
			this.SystemQS = (bool?)info.GetValue("SystemQS", typeof(bool?));
			this.LastUsed = (bool?)info.GetValue("LastUsed", typeof(bool?));
			this.QuickSort_Query = info.GetString("QuickSort_Query");
			this.LastUsedToday = (int?)info.GetValue("LastUsedToday", typeof(int?));
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("QuickSortID", this.QuickSortID, typeof(int));
			info.AddValue("SourceName", this.SourceName, typeof(string));
			info.AddValue("User_name", this.User_name, typeof(string));
			info.AddValue("Description", this.Description, typeof(string));
			info.AddValue("SystemQS", this.SystemQS, typeof(bool?));
			info.AddValue("LastUsed", this.LastUsed, typeof(bool?));
			info.AddValue("QuickSort_Query", this.QuickSort_Query, typeof(string));
			info.AddValue("LastUsedToday", this.LastUsedToday, typeof(int?));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}

