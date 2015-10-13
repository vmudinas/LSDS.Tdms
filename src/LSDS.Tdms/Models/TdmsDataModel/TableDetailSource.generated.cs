
using System.ComponentModel;

namespace LSDS.Tdms.Models.TdmsDataModel	
{
	
	[System.Serializable()]
	public partial class TableDetailSource : IDataErrorInfo, INotifyPropertyChanging, INotifyPropertyChanged, System.Runtime.Serialization.ISerializable
	{
		private string _sourceName;
	
		[System.ComponentModel.DataAnnotations.StringLength(50)]
		[System.ComponentModel.DataAnnotations.Required()]
		[System.ComponentModel.DataAnnotations.Key()]
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
		
		private string _sourceNameDisplay;

		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string SourceNameDisplay
		{
			get
			{
				return this._sourceNameDisplay;
			}
			set
			{
				if(this._sourceNameDisplay != value)
				{
					this.OnPropertyChanging("SourceNameDisplay");
					this._sourceNameDisplay = value;
					this.OnPropertyChanged("SourceNameDisplay");
				}
			}
		}
		
		private bool? _userDefine;
	
		public virtual bool? UserDefine
		{
			get
			{
				return this._userDefine;
			}
			set
			{
				if(this._userDefine != value)
				{
					this.OnPropertyChanging("UserDefine");
					this._userDefine = value;
					this.OnPropertyChanged("UserDefine");
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
		
		public TableDetailSource()
		{
		}
		
		protected TableDetailSource(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.SourceName = info.GetString("SourceName");
			this.SourceNameDisplay = info.GetString("SourceNameDisplay");
			this.UserDefine = (bool?)info.GetValue("UserDefine", typeof(bool?));
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("SourceName", this.SourceName, typeof(string));
			info.AddValue("SourceNameDisplay", this.SourceNameDisplay, typeof(string));
			info.AddValue("UserDefine", this.UserDefine, typeof(bool?));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}

