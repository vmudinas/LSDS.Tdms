
using System.ComponentModel;

namespace LSDS.Tdms.Models.TdmsDataModel
{
	
	[System.Serializable()]
	public partial class QuickFind_Query : IDataErrorInfo, INotifyPropertyChanging, INotifyPropertyChanged, System.Runtime.Serialization.ISerializable
	{
		private int _qF_QueryID;
	
		[System.ComponentModel.DataAnnotations.Required()]
		[System.ComponentModel.DataAnnotations.Key()]
		public virtual int QF_QueryID
		{
			get
			{
				return this._qF_QueryID;
			}
			set
			{
				if(this._qF_QueryID != value)
				{
					this.OnPropertyChanging("QF_QueryID");
					this._qF_QueryID = value;
					this.OnPropertyChanged("QF_QueryID");
				}
			}
		}
		
		private int? _quickFindID;
	
		public virtual int? QuickFindID
		{
			get
			{
				return this._quickFindID;
			}
			set
			{
				if(this._quickFindID != value)
				{
					this.OnPropertyChanging("QuickFindID");
					this._quickFindID = value;
					this.OnPropertyChanged("QuickFindID");
				}
			}
		}
     

        private string _queryString;
	
		[System.ComponentModel.DataAnnotations.StringLength(8000)]
		public virtual string QueryString
		{
			get
			{
				return this._queryString;
			}
			set
			{
				if(this._queryString != value)
				{
					this.OnPropertyChanging("QueryString");
					this._queryString = value;
					this.OnPropertyChanged("QueryString");
				}
			}
		}
		
		private string _qF_ColumnName;
	
		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string QF_ColumnName
		{
			get
			{
				return this._qF_ColumnName;
			}
			set
			{
				if(this._qF_ColumnName != value)
				{
					this.OnPropertyChanging("QF_ColumnName");
					this._qF_ColumnName = value;
					this.OnPropertyChanged("QF_ColumnName");
				}
			}
		}
		
		private string _qF_Operator;
	
		[System.ComponentModel.DataAnnotations.StringLength(10)]
		public virtual string QF_Operator
		{
			get
			{
				return this._qF_Operator;
			}
			set
			{
				if(this._qF_Operator != value)
				{
					this.OnPropertyChanging("QF_Operator");
					this._qF_Operator = value;
					this.OnPropertyChanged("QF_Operator");
				}
			}
		}
		
		private string _qF_Value1;
	
		[System.ComponentModel.DataAnnotations.StringLength(8000)]
		public virtual string QF_Value1
		{
			get
			{
				return this._qF_Value1;
			}
			set
			{
				if(this._qF_Value1 != value)
				{
					this.OnPropertyChanging("QF_Value1");
					this._qF_Value1 = value;
					this.OnPropertyChanged("QF_Value1");
				}
			}
		}
		
		private string _qF_Value2;
	
		[System.ComponentModel.DataAnnotations.StringLength(8000)]
		public virtual string QF_Value2
		{
			get
			{
				return this._qF_Value2;
			}
			set
			{
				if(this._qF_Value2 != value)
				{
					this.OnPropertyChanging("QF_Value2");
					this._qF_Value2 = value;
					this.OnPropertyChanged("QF_Value2");
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
		
	
		
		public QuickFind_Query()
		{
		}
		
		protected QuickFind_Query(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.QF_QueryID = info.GetInt32("QF_QueryID");
			this.QuickFindID = (int?)info.GetValue("QuickFindID", typeof(int?));
			this.QueryString = info.GetString("QueryString");
			this.QF_ColumnName = info.GetString("QF_ColumnName");
			this.QF_Operator = info.GetString("QF_Operator");
			this.QF_Value1 = info.GetString("QF_Value1");
			this.QF_Value2 = info.GetString("QF_Value2");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("QF_QueryID", this.QF_QueryID, typeof(int));
			info.AddValue("QuickFindID", this.QuickFindID, typeof(int?));
			info.AddValue("QueryString", this.QueryString, typeof(string));
			info.AddValue("QF_ColumnName", this.QF_ColumnName, typeof(string));
			info.AddValue("QF_Operator", this.QF_Operator, typeof(string));
			info.AddValue("QF_Value1", this.QF_Value1, typeof(string));
			info.AddValue("QF_Value2", this.QF_Value2, typeof(string));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);


}

}