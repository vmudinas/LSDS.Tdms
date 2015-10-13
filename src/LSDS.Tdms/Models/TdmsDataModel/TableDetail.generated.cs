
using System.ComponentModel;

namespace LSDS.Tdms.Models.TdmsDataModel
{
    [System.Serializable()]
	public partial class TableDetail : IDataErrorInfo, INotifyPropertyChanging, INotifyPropertyChanged, System.Runtime.Serialization.ISerializable
	{
		private int _tableDetail_ID;
	
		[System.ComponentModel.DataAnnotations.Required()]
		[System.ComponentModel.DataAnnotations.Key()]
		public virtual int TableDetail_ID
		{
			get
			{
				return this._tableDetail_ID;
			}
			set
			{
				if(this._tableDetail_ID != value)
				{
					this.OnPropertyChanging("TableDetail_ID");
					this._tableDetail_ID = value;
					this.OnPropertyChanged("TableDetail_ID");
				}
			}
		}
		
		private string _sourceName;
	
		[System.ComponentModel.DataAnnotations.StringLength(50)]
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
		
		private int? _row_Position;
	
		public virtual int? Row_Position
		{
			get
			{
				return this._row_Position;
			}
			set
			{
				if(this._row_Position != value)
				{
					this.OnPropertyChanging("Row_Position");
					this._row_Position = value;
					this.OnPropertyChanged("Row_Position");
				}
			}
		}
		
		private int? _column_Position;
	
		public virtual int? Column_Position
		{
			get
			{
				return this._column_Position;
			}
			set
			{
				if(this._column_Position != value)
				{
					this.OnPropertyChanging("Column_Position");
					this._column_Position = value;
					this.OnPropertyChanged("Column_Position");
				}
			}
		}
		
		private int? _column_Span;
	
		public virtual int? Column_Span
		{
			get
			{
				return this._column_Span;
			}
			set
			{
				if(this._column_Span != value)
				{
					this.OnPropertyChanging("Column_Span");
					this._column_Span = value;
					this.OnPropertyChanged("Column_Span");
				}
			}
		}
		
		private int? _row_Span;
	
		public virtual int? Row_Span
		{
			get
			{
				return this._row_Span;
			}
			set
			{
				if(this._row_Span != value)
				{
					this.OnPropertyChanging("Row_Span");
					this._row_Span = value;
					this.OnPropertyChanged("Row_Span");
				}
			}
		}
		
		private string _column_Name;

		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string Column_Name
		{
			get
			{
				return this._column_Name;
			}
			set
			{
				if(this._column_Name != value)
				{
					this.OnPropertyChanging("Column_Name");
					this._column_Name = value;
					this.OnPropertyChanged("Column_Name");
				}
			}
		}
		
		private string _column_Header;

		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string Column_Header
		{
			get
			{
				return this._column_Header;
			}
			set
			{
				if(this._column_Header != value)
				{
					this.OnPropertyChanging("Column_Header");
					this._column_Header = value;
					this.OnPropertyChanged("Column_Header");
				}
			}
		}
		
		private int? _column_Width;
	
		public virtual int? Column_Width
		{
			get
			{
				return this._column_Width;
			}
			set
			{
				if(this._column_Width != value)
				{
					this.OnPropertyChanging("Column_Width");
					this._column_Width = value;
					this.OnPropertyChanged("Column_Width");
				}
			}
		}
		
		private string _group_Header;
		
		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string Group_Header
		{
			get
			{
				return this._group_Header;
			}
			set
			{
				if(this._group_Header != value)
				{
					this.OnPropertyChanging("Group_Header");
					this._group_Header = value;
					this.OnPropertyChanged("Group_Header");
				}
			}
		}
		
		private string _datatype;
	
		[System.ComponentModel.DataAnnotations.StringLength(15)]
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual string Datatype
		{
			get
			{
				return this._datatype;
			}
			set
			{
				if(this._datatype != value)
				{
					this.OnPropertyChanging("Datatype");
					this._datatype = value;
					this.OnPropertyChanged("Datatype");
				}
			}
		}
		
		private string _formatString;
	
		[System.ComponentModel.DataAnnotations.StringLength(25)]
		public virtual string FormatString
		{
			get
			{
				return this._formatString;
			}
			set
			{
				if(this._formatString != value)
				{
					this.OnPropertyChanging("FormatString");
					this._formatString = value;
					this.OnPropertyChanged("FormatString");
				}
			}
		}
		
		private string _defaultValue;
	
		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string DefaultValue
		{
			get
			{
				return this._defaultValue;
			}
			set
			{
				if(this._defaultValue != value)
				{
					this.OnPropertyChanging("DefaultValue");
					this._defaultValue = value;
					this.OnPropertyChanged("DefaultValue");
				}
			}
		}
		
		private string _defaultValueDesc;
	
		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string DefaultValueDesc
		{
			get
			{
				return this._defaultValueDesc;
			}
			set
			{
				if(this._defaultValueDesc != value)
				{
					this.OnPropertyChanging("DefaultValueDesc");
					this._defaultValueDesc = value;
					this.OnPropertyChanged("DefaultValueDesc");
				}
			}
		}
		
		private int? _operatorCode;
	
		public virtual int? OperatorCode
		{
			get
			{
				return this._operatorCode;
			}
			set
			{
				if(this._operatorCode != value)
				{
					this.OnPropertyChanging("OperatorCode");
					this._operatorCode = value;
					this.OnPropertyChanged("OperatorCode");
				}
			}
		}
		
		private bool _sort;
	
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual bool Sort
		{
			get
			{
				return this._sort;
			}
			set
			{
				if(this._sort != value)
				{
					this.OnPropertyChanging("Sort");
					this._sort = value;
					this.OnPropertyChanged("Sort");
				}
			}
		}
		
		private bool _filter;
	
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual bool Filter
		{
			get
			{
				return this._filter;
			}
			set
			{
				if(this._filter != value)
				{
					this.OnPropertyChanging("Filter");
					this._filter = value;
					this.OnPropertyChanged("Filter");
				}
			}
		}
		
		private bool _wrapText;
	
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual bool WrapText
		{
			get
			{
				return this._wrapText;
			}
			set
			{
				if(this._wrapText != value)
				{
					this.OnPropertyChanging("WrapText");
					this._wrapText = value;
					this.OnPropertyChanged("WrapText");
				}
			}
		}
		
		private bool _isDropdown;
	
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual bool IsDropdown
		{
			get
			{
				return this._isDropdown;
			}
			set
			{
				if(this._isDropdown != value)
				{
					this.OnPropertyChanging("IsDropdown");
					this._isDropdown = value;
					this.OnPropertyChanged("IsDropdown");
				}
			}
		}
		
		private bool _isBoolPic;
		
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual bool IsBoolPic
		{
			get
			{
				return this._isBoolPic;
			}
			set
			{
				if(this._isBoolPic != value)
				{
					this.OnPropertyChanging("IsBoolPic");
					this._isBoolPic = value;
					this.OnPropertyChanged("IsBoolPic");
				}
			}
		}
		
		private bool _isNumPic;
	
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual bool IsNumPic
		{
			get
			{
				return this._isNumPic;
			}
			set
			{
				if(this._isNumPic != value)
				{
					this.OnPropertyChanging("IsNumPic");
					this._isNumPic = value;
					this.OnPropertyChanged("IsNumPic");
				}
			}
		}
		
		private bool _isCheckbox;
		
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual bool IsCheckbox
		{
			get
			{
				return this._isCheckbox;
			}
			set
			{
				if(this._isCheckbox != value)
				{
					this.OnPropertyChanging("IsCheckbox");
					this._isCheckbox = value;
					this.OnPropertyChanged("IsCheckbox");
				}
			}
		}
		
		private string _numOptions;
	
		[System.ComponentModel.DataAnnotations.StringLength(200)]
		public virtual string NumOptions
		{
			get
			{
				return this._numOptions;
			}
			set
			{
				if(this._numOptions != value)
				{
					this.OnPropertyChanging("NumOptions");
					this._numOptions = value;
					this.OnPropertyChanged("NumOptions");
				}
			}
		}
		
		private string _numPics;
	
		[System.ComponentModel.DataAnnotations.StringLength(200)]
		public virtual string NumPics
		{
			get
			{
				return this._numPics;
			}
			set
			{
				if(this._numPics != value)
				{
					this.OnPropertyChanging("NumPics");
					this._numPics = value;
					this.OnPropertyChanged("NumPics");
				}
			}
		}
		
		private string _checkName;
	
		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string CheckName
		{
			get
			{
				return this._checkName;
			}
			set
			{
				if(this._checkName != value)
				{
					this.OnPropertyChanging("CheckName");
					this._checkName = value;
					this.OnPropertyChanged("CheckName");
				}
			}
		}
		
		private string _refPrefix;
		
		[System.ComponentModel.DataAnnotations.StringLength(25)]
		public virtual string RefPrefix
		{
			get
			{
				return this._refPrefix;
			}
			set
			{
				if(this._refPrefix != value)
				{
					this.OnPropertyChanging("RefPrefix");
					this._refPrefix = value;
					this.OnPropertyChanged("RefPrefix");
				}
			}
		}
		
		private string _refColumn;
		
		[System.ComponentModel.DataAnnotations.StringLength(25)]
		public virtual string RefColumn
		{
			get
			{
				return this._refColumn;
			}
			set
			{
				if(this._refColumn != value)
				{
					this.OnPropertyChanging("RefColumn");
					this._refColumn = value;
					this.OnPropertyChanged("RefColumn");
				}
			}
		}
		
		private string _refTableName;
	
		[System.ComponentModel.DataAnnotations.StringLength(20)]
		public virtual string RefTableName
		{
			get
			{
				return this._refTableName;
			}
			set
			{
				if(this._refTableName != value)
				{
					this.OnPropertyChanging("RefTableName");
					this._refTableName = value;
					this.OnPropertyChanged("RefTableName");
				}
			}
		}
		
		private string _refLookupColumn;
	
		[System.ComponentModel.DataAnnotations.StringLength(25)]
		public virtual string RefLookupColumn
		{
			get
			{
				return this._refLookupColumn;
			}
			set
			{
				if(this._refLookupColumn != value)
				{
					this.OnPropertyChanging("RefLookupColumn");
					this._refLookupColumn = value;
					this.OnPropertyChanged("RefLookupColumn");
				}
			}
		}
		
		private string _refDisplayColumn;
	
		[System.ComponentModel.DataAnnotations.StringLength(25)]
		public virtual string RefDisplayColumn
		{
			get
			{
				return this._refDisplayColumn;
			}
			set
			{
				if(this._refDisplayColumn != value)
				{
					this.OnPropertyChanging("RefDisplayColumn");
					this._refDisplayColumn = value;
					this.OnPropertyChanged("RefDisplayColumn");
				}
			}
		}
		
		private bool _quickSort;
	
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual bool QuickSort
		{
			get
			{
				return this._quickSort;
			}
			set
			{
				if(this._quickSort != value)
				{
					this.OnPropertyChanging("QuickSort");
					this._quickSort = value;
					this.OnPropertyChanged("QuickSort");
				}
			}
		}
		
		private bool _numericSort;
	
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual bool NumericSort
		{
			get
			{
				return this._numericSort;
			}
			set
			{
				if(this._numericSort != value)
				{
					this.OnPropertyChanging("NumericSort");
					this._numericSort = value;
					this.OnPropertyChanged("NumericSort");
				}
			}
		}
		
		private bool _quickFind;
	
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual bool QuickFind
		{
			get
			{
				return this._quickFind;
			}
			set
			{
				if(this._quickFind != value)
				{
					this.OnPropertyChanging("QuickFind");
					this._quickFind = value;
					this.OnPropertyChanged("QuickFind");
				}
			}
		}
		
		private bool _linkDiscrepancy;
	
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual bool LinkDiscrepancy
		{
			get
			{
				return this._linkDiscrepancy;
			}
			set
			{
				if(this._linkDiscrepancy != value)
				{
					this.OnPropertyChanging("LinkDiscrepancy");
					this._linkDiscrepancy = value;
					this.OnPropertyChanged("LinkDiscrepancy");
				}
			}
		}
		
		private string _discrepancyColor;
		
		[System.ComponentModel.DataAnnotations.StringLength(20)]
		public virtual string DiscrepancyColor
		{
			get
			{
				return this._discrepancyColor;
			}
			set
			{
				if(this._discrepancyColor != value)
				{
					this.OnPropertyChanging("DiscrepancyColor");
					this._discrepancyColor = value;
					this.OnPropertyChanged("DiscrepancyColor");
				}
			}
		}
		
		private string _colorControl;
	
		[System.ComponentModel.DataAnnotations.StringLength(250)]
		public virtual string ColorControl
		{
			get
			{
				return this._colorControl;
			}
			set
			{
				if(this._colorControl != value)
				{
					this.OnPropertyChanging("ColorControl");
					this._colorControl = value;
					this.OnPropertyChanged("ColorControl");
				}
			}
		}
		
		private string _colorReference;
	
		[System.ComponentModel.DataAnnotations.StringLength(250)]
		public virtual string ColorReference
		{
			get
			{
				return this._colorReference;
			}
			set
			{
				if(this._colorReference != value)
				{
					this.OnPropertyChanging("ColorReference");
					this._colorReference = value;
					this.OnPropertyChanged("ColorReference");
				}
			}
		}
		
		private string _colorReferenceControl;

		[System.ComponentModel.DataAnnotations.StringLength(250)]
		public virtual string ColorReferenceControl
		{
			get
			{
				return this._colorReferenceControl;
			}
			set
			{
				if(this._colorReferenceControl != value)
				{
					this.OnPropertyChanging("ColorReferenceControl");
					this._colorReferenceControl = value;
					this.OnPropertyChanged("ColorReferenceControl");
				}
			}
		}
		
		private string _linkCommand;
		
		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string LinkCommand
		{
			get
			{
				return this._linkCommand;
			}
			set
			{
				if(this._linkCommand != value)
				{
					this.OnPropertyChanging("LinkCommand");
					this._linkCommand = value;
					this.OnPropertyChanged("LinkCommand");
				}
			}
		}
		
		private bool _required;
	
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual bool Required
		{
			get
			{
				return this._required;
			}
			set
			{
				if(this._required != value)
				{
					this.OnPropertyChanging("Required");
					this._required = value;
					this.OnPropertyChanged("Required");
				}
			}
		}
		
		private int? _maxLength;
	
		public virtual int? MaxLength
		{
			get
			{
				return this._maxLength;
			}
			set
			{
				if(this._maxLength != value)
				{
					this.OnPropertyChanging("MaxLength");
					this._maxLength = value;
					this.OnPropertyChanged("MaxLength");
				}
			}
		}
		
		private int? _width;

		public virtual int? Width
		{
			get
			{
				return this._width;
			}
			set
			{
				if(this._width != value)
				{
					this.OnPropertyChanging("Width");
					this._width = value;
					this.OnPropertyChanged("Width");
				}
			}
		}
		
		private string _displayClass;

		[System.ComponentModel.DataAnnotations.StringLength(50)]
		public virtual string DisplayClass
		{
			get
			{
				return this._displayClass;
			}
			set
			{
				if(this._displayClass != value)
				{
					this.OnPropertyChanging("DisplayClass");
					this._displayClass = value;
					this.OnPropertyChanged("DisplayClass");
				}
			}
		}
		
		private bool? _gridSuppress;

		public virtual bool? GridSuppress
		{
			get
			{
				return this._gridSuppress;
			}
			set
			{
				if(this._gridSuppress != value)
				{
					this.OnPropertyChanging("GridSuppress");
					this._gridSuppress = value;
					this.OnPropertyChanged("GridSuppress");
				}
			}
		}
		
		private string _summaryType;

		[System.ComponentModel.DataAnnotations.StringLength(10)]
		public virtual string SummaryType
		{
			get
			{
				return this._summaryType;
			}
			set
			{
				if(this._summaryType != value)
				{
					this.OnPropertyChanging("SummaryType");
					this._summaryType = value;
					this.OnPropertyChanged("SummaryType");
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
		
		public TableDetail()
		{
		}
		
		protected TableDetail(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.TableDetail_ID = info.GetInt32("TableDetail_ID");
			this.SourceName = info.GetString("SourceName");
			this.Row_Position = (int?)info.GetValue("Row_Position", typeof(int?));
			this.Column_Position = (int?)info.GetValue("Column_Position", typeof(int?));
			this.Column_Span = (int?)info.GetValue("Column_Span", typeof(int?));
			this.Row_Span = (int?)info.GetValue("Row_Span", typeof(int?));
			this.Column_Name = info.GetString("Column_Name");
			this.Column_Header = info.GetString("Column_Header");
			this.Column_Width = (int?)info.GetValue("Column_Width", typeof(int?));
			this.Group_Header = info.GetString("Group_Header");
			this.Datatype = info.GetString("Datatype");
			this.FormatString = info.GetString("FormatString");
			this.DefaultValue = info.GetString("DefaultValue");
			this.DefaultValueDesc = info.GetString("DefaultValueDesc");
			this.OperatorCode = (int?)info.GetValue("OperatorCode", typeof(int?));
			this.Sort = info.GetBoolean("Sort");
			this.Filter = info.GetBoolean("Filter");
			this.WrapText = info.GetBoolean("WrapText");
			this.IsDropdown = info.GetBoolean("IsDropdown");
			this.IsBoolPic = info.GetBoolean("IsBoolPic");
			this.IsNumPic = info.GetBoolean("IsNumPic");
			this.IsCheckbox = info.GetBoolean("IsCheckbox");
			this.NumOptions = info.GetString("NumOptions");
			this.NumPics = info.GetString("NumPics");
			this.CheckName = info.GetString("CheckName");
			this.RefPrefix = info.GetString("RefPrefix");
			this.RefColumn = info.GetString("RefColumn");
			this.RefTableName = info.GetString("RefTableName");
			this.RefLookupColumn = info.GetString("RefLookupColumn");
			this.RefDisplayColumn = info.GetString("RefDisplayColumn");
			this.QuickSort = info.GetBoolean("QuickSort");
			this.NumericSort = info.GetBoolean("NumericSort");
			this.QuickFind = info.GetBoolean("QuickFind");
			this.LinkDiscrepancy = info.GetBoolean("LinkDiscrepancy");
			this.DiscrepancyColor = info.GetString("DiscrepancyColor");
			this.ColorControl = info.GetString("ColorControl");
			this.ColorReference = info.GetString("ColorReference");
			this.ColorReferenceControl = info.GetString("ColorReferenceControl");
			this.LinkCommand = info.GetString("LinkCommand");
			this.Required = info.GetBoolean("Required");
			this.MaxLength = (int?)info.GetValue("MaxLength", typeof(int?));
			this.Width = (int?)info.GetValue("Width", typeof(int?));
			this.DisplayClass = info.GetString("DisplayClass");
			this.GridSuppress = (bool?)info.GetValue("GridSuppress", typeof(bool?));
			this.SummaryType = info.GetString("SummaryType");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("TableDetail_ID", this.TableDetail_ID, typeof(int));
			info.AddValue("SourceName", this.SourceName, typeof(string));
			info.AddValue("Row_Position", this.Row_Position, typeof(int?));
			info.AddValue("Column_Position", this.Column_Position, typeof(int?));
			info.AddValue("Column_Span", this.Column_Span, typeof(int?));
			info.AddValue("Row_Span", this.Row_Span, typeof(int?));
			info.AddValue("Column_Name", this.Column_Name, typeof(string));
			info.AddValue("Column_Header", this.Column_Header, typeof(string));
			info.AddValue("Column_Width", this.Column_Width, typeof(int?));
			info.AddValue("Group_Header", this.Group_Header, typeof(string));
			info.AddValue("Datatype", this.Datatype, typeof(string));
			info.AddValue("FormatString", this.FormatString, typeof(string));
			info.AddValue("DefaultValue", this.DefaultValue, typeof(string));
			info.AddValue("DefaultValueDesc", this.DefaultValueDesc, typeof(string));
			info.AddValue("OperatorCode", this.OperatorCode, typeof(int?));
			info.AddValue("Sort", this.Sort, typeof(bool));
			info.AddValue("Filter", this.Filter, typeof(bool));
			info.AddValue("WrapText", this.WrapText, typeof(bool));
			info.AddValue("IsDropdown", this.IsDropdown, typeof(bool));
			info.AddValue("IsBoolPic", this.IsBoolPic, typeof(bool));
			info.AddValue("IsNumPic", this.IsNumPic, typeof(bool));
			info.AddValue("IsCheckbox", this.IsCheckbox, typeof(bool));
			info.AddValue("NumOptions", this.NumOptions, typeof(string));
			info.AddValue("NumPics", this.NumPics, typeof(string));
			info.AddValue("CheckName", this.CheckName, typeof(string));
			info.AddValue("RefPrefix", this.RefPrefix, typeof(string));
			info.AddValue("RefColumn", this.RefColumn, typeof(string));
			info.AddValue("RefTableName", this.RefTableName, typeof(string));
			info.AddValue("RefLookupColumn", this.RefLookupColumn, typeof(string));
			info.AddValue("RefDisplayColumn", this.RefDisplayColumn, typeof(string));
			info.AddValue("QuickSort", this.QuickSort, typeof(bool));
			info.AddValue("NumericSort", this.NumericSort, typeof(bool));
			info.AddValue("QuickFind", this.QuickFind, typeof(bool));
			info.AddValue("LinkDiscrepancy", this.LinkDiscrepancy, typeof(bool));
			info.AddValue("DiscrepancyColor", this.DiscrepancyColor, typeof(string));
			info.AddValue("ColorControl", this.ColorControl, typeof(string));
			info.AddValue("ColorReference", this.ColorReference, typeof(string));
			info.AddValue("ColorReferenceControl", this.ColorReferenceControl, typeof(string));
			info.AddValue("LinkCommand", this.LinkCommand, typeof(string));
			info.AddValue("Required", this.Required, typeof(bool));
			info.AddValue("MaxLength", this.MaxLength, typeof(int?));
			info.AddValue("Width", this.Width, typeof(int?));
			info.AddValue("DisplayClass", this.DisplayClass, typeof(string));
			info.AddValue("GridSuppress", this.GridSuppress, typeof(bool?));
			info.AddValue("SummaryType", this.SummaryType, typeof(string));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591
