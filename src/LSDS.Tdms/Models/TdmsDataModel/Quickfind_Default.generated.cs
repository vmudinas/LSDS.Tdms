using System.ComponentModel;

namespace LSDS.Tdms.Models.TdmsDataModel
{

	[System.Serializable()]
	public partial class Quickfind_Default : IDataErrorInfo, INotifyPropertyChanging, INotifyPropertyChanged, System.Runtime.Serialization.ISerializable
	{
		private string _sourceName;
		[System.ComponentModel.DataAnnotations.StringLength(100)]
		[System.ComponentModel.DataAnnotations.Required()]
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
		[System.ComponentModel.DataAnnotations.StringLength(10)]
		[System.ComponentModel.DataAnnotations.Required()]
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
		
		private int? _defaultQuickfind;
		public virtual int? DefaultQuickfind
		{
			get
			{
				return this._defaultQuickfind;
			}
			set
			{
				if(this._defaultQuickfind != value)
				{
					this.OnPropertyChanging("DefaultQuickfind");
					this._defaultQuickfind = value;
					this.OnPropertyChanged("DefaultQuickfind");
				}
			}
		}
		
		private int _quickfind_DefaultId;

		[System.ComponentModel.DataAnnotations.Required()]
		[System.ComponentModel.DataAnnotations.Key()]
		public virtual int Quickfind_DefaultId
		{
			get
			{
				return this._quickfind_DefaultId;
			}
			set
			{
				if(this._quickfind_DefaultId != value)
				{
					this.OnPropertyChanging("Quickfind_DefaultId");
					this._quickfind_DefaultId = value;
					this.OnPropertyChanged("Quickfind_DefaultId");
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
		
		public Quickfind_Default()
		{
		}
		
		protected Quickfind_Default(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.SourceName = info.GetString("SourceName");
			this.User_name = info.GetString("User_name");
			this.DefaultQuickfind = (int?)info.GetValue("DefaultQuickfind", typeof(int?));
			this.Quickfind_DefaultId = info.GetInt32("Quickfind_DefaultId");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("SourceName", this.SourceName, typeof(string));
			info.AddValue("User_name", this.User_name, typeof(string));
			info.AddValue("DefaultQuickfind", this.DefaultQuickfind, typeof(int?));
			info.AddValue("Quickfind_DefaultId", this.Quickfind_DefaultId, typeof(int));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}

