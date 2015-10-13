using System.ComponentModel;

namespace LSDS.Tdms.Models.TdmsDataModel	
{
	[System.Serializable()]
	public partial class TdGridsterModel : IDataErrorInfo, INotifyPropertyChanging, INotifyPropertyChanged, System.Runtime.Serialization.ISerializable
	{
		private int _gridsterId;
		
		[System.ComponentModel.DataAnnotations.Required()]
		[System.ComponentModel.DataAnnotations.Key()]
		public virtual int GridsterId
		{
			get
			{
				return this._gridsterId;
			}
			set
			{
				if(this._gridsterId != value)
				{
					this.OnPropertyChanging("GridsterId");
					this._gridsterId = value;
					this.OnPropertyChanged("GridsterId");
				}
			}
		}
		
		private string _id;
		
		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				if(this._id != value)
				{
					this.OnPropertyChanging("Id");
					this._id = value;
					this.OnPropertyChanged("Id");
				}
			}
		}
		
		private string _col;
		
		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string Col
		{
			get
			{
				return this._col;
			}
			set
			{
				if(this._col != value)
				{
					this.OnPropertyChanging("Col");
					this._col = value;
					this.OnPropertyChanged("Col");
				}
			}
		}
		
		private string _row;
		
		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string Row
		{
			get
			{
				return this._row;
			}
			set
			{
				if(this._row != value)
				{
					this.OnPropertyChanging("Row");
					this._row = value;
					this.OnPropertyChanged("Row");
				}
			}
		}
		
		private string _size_x;
	
		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string Size_x
		{
			get
			{
				return this._size_x;
			}
			set
			{
				if(this._size_x != value)
				{
					this.OnPropertyChanging("Size_x");
					this._size_x = value;
					this.OnPropertyChanged("Size_x");
				}
			}
		}
		
		private string _size_y;
	
		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string Size_y
		{
			get
			{
				return this._size_y;
			}
			set
			{
				if(this._size_y != value)
				{
					this.OnPropertyChanging("Size_y");
					this._size_y = value;
					this.OnPropertyChanged("Size_y");
				}
			}
		}
		
		private string _htmlContent;
	
		public virtual string HtmlContent
		{
			get
			{
				return this._htmlContent;
			}
			set
			{
				if(this._htmlContent != value)
				{
					this.OnPropertyChanging("HtmlContent");
					this._htmlContent = value;
					this.OnPropertyChanged("HtmlContent");
				}
			}
		}
		
		private string _user_name;	
		[System.ComponentModel.DataAnnotations.StringLength(50)]
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
		
		public TdGridsterModel()
		{
		}
		
		protected TdGridsterModel(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.GridsterId = info.GetInt32("GridsterId");
			this.Id = info.GetString("Id");
			this.Col = info.GetString("Col");
			this.Row = info.GetString("Row");
			this.Size_x = info.GetString("Size_x");
			this.Size_y = info.GetString("Size_y");
			this.HtmlContent = info.GetString("HtmlContent");
			this.User_name = info.GetString("User_name");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("GridsterId", this.GridsterId, typeof(int));
			info.AddValue("Id", this.Id, typeof(string));
			info.AddValue("Col", this.Col, typeof(string));
			info.AddValue("Row", this.Row, typeof(string));
			info.AddValue("Size_x", this.Size_x, typeof(string));
			info.AddValue("Size_y", this.Size_y, typeof(string));
			info.AddValue("HtmlContent", this.HtmlContent, typeof(string));
			info.AddValue("User_name", this.User_name, typeof(string));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}

