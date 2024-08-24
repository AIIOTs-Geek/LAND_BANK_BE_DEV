﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataContext.DataClasses
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LandBank")]
	public partial class PrDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public PrDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PrDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PrDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PrDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetStatus")]
		public ISingleResult<GetStatusResult> GetStatus([global::System.Data.Linq.Mapping.ParameterAttribute(Name="StatusType", DbType="NVarChar(50)")] string statusType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), statusType);
			return ((ISingleResult<GetStatusResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetCities")]
		public ISingleResult<GetCitiesResult> GetCities()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetCitiesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetDistrictByCityId")]
		public ISingleResult<GetDistrictByCityIdResult> GetDistrictByCityId([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CityId", DbType="Int")] System.Nullable<int> cityId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cityId);
			return ((ISingleResult<GetDistrictByCityIdResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAssetNames")]
		public ISingleResult<GetAssetNamesResult> GetAssetNames()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetAssetNamesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAssetsWithLandCount")]
		public ISingleResult<GetAssetsWithLandCountResult> GetAssetsWithLandCount([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SearchText", DbType="NVarChar(50)")] string searchText, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CityId", DbType="Int")] System.Nullable<int> cityId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DistrictId", DbType="Int")] System.Nullable<int> districtId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AssetId", DbType="Int")] System.Nullable<int> assetId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), searchText, cityId, districtId, assetId);
			return ((ISingleResult<GetAssetsWithLandCountResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetLandDetails")]
		public ISingleResult<GetLandDetailsResult> GetLandDetails([global::System.Data.Linq.Mapping.ParameterAttribute(Name="LandId", DbType="Int")] System.Nullable<int> landId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Deptt", DbType="VarChar(50)")] string deptt)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), landId, deptt);
			return ((ISingleResult<GetLandDetailsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetLandByAssetId")]
		public ISingleResult<GetLandByAssetIdResult> GetLandByAssetId([global::System.Data.Linq.Mapping.ParameterAttribute(Name="AssetId", DbType="Int")] System.Nullable<int> assetId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SearchText", DbType="VarChar(100)")] string searchText, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CityId", DbType="Int")] System.Nullable<int> cityId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DistrictId", DbType="Int")] System.Nullable<int> districtId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LandUseId", DbType="Int")] System.Nullable<int> landUseId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="BusinessPlanId", DbType="Int")] System.Nullable<int> businessPlanId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WLTStatus", DbType="Bit")] System.Nullable<bool> wLTStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), assetId, searchText, cityId, districtId, userId, landUseId, businessPlanId, wLTStatus);
			return ((ISingleResult<GetLandByAssetIdResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetLandDetailsFilters")]
		public ISingleResult<GetLandDetailsFiltersResult> GetLandDetailsFilters([global::System.Data.Linq.Mapping.ParameterAttribute(Name="LandId", DbType="Int")] System.Nullable<int> landId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Deptt", DbType="VarChar(50)")] string deptt)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), landId, deptt);
			return ((ISingleResult<GetLandDetailsFiltersResult>)(result.ReturnValue));
		}
	}
	
	public partial class GetStatusResult
	{
		
		private int _Id;
		
		private string _Status;
		
		public GetStatusResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this._Status = value;
				}
			}
		}
	}
	
	public partial class GetCitiesResult
	{
		
		private int _Id;
		
		private string _CityName;
		
		public GetCitiesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string CityName
		{
			get
			{
				return this._CityName;
			}
			set
			{
				if ((this._CityName != value))
				{
					this._CityName = value;
				}
			}
		}
	}
	
	public partial class GetDistrictByCityIdResult
	{
		
		private int _Id;
		
		private string _DistrictName;
		
		public GetDistrictByCityIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DistrictName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string DistrictName
		{
			get
			{
				return this._DistrictName;
			}
			set
			{
				if ((this._DistrictName != value))
				{
					this._DistrictName = value;
				}
			}
		}
	}
	
	public partial class GetAssetNamesResult
	{
		
		private int _Id;
		
		private string _AssetName;
		
		public GetAssetNamesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetName", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string AssetName
		{
			get
			{
				return this._AssetName;
			}
			set
			{
				if ((this._AssetName != value))
				{
					this._AssetName = value;
				}
			}
		}
	}
	
	public partial class GetAssetsWithLandCountResult
	{
		
		private int _AssetId;
		
		private string _AssetName;
		
		private string _SubAssetName;
		
		private System.Nullable<int> _NumberOfLands;
		
		private System.Nullable<decimal> _TotalLandArea;
		
		public GetAssetsWithLandCountResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetId", DbType="Int NOT NULL")]
		public int AssetId
		{
			get
			{
				return this._AssetId;
			}
			set
			{
				if ((this._AssetId != value))
				{
					this._AssetId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetName", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string AssetName
		{
			get
			{
				return this._AssetName;
			}
			set
			{
				if ((this._AssetName != value))
				{
					this._AssetName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubAssetName", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string SubAssetName
		{
			get
			{
				return this._SubAssetName;
			}
			set
			{
				if ((this._SubAssetName != value))
				{
					this._SubAssetName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfLands", DbType="Int")]
		public System.Nullable<int> NumberOfLands
		{
			get
			{
				return this._NumberOfLands;
			}
			set
			{
				if ((this._NumberOfLands != value))
				{
					this._NumberOfLands = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalLandArea", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> TotalLandArea
		{
			get
			{
				return this._TotalLandArea;
			}
			set
			{
				if ((this._TotalLandArea != value))
				{
					this._TotalLandArea = value;
				}
			}
		}
	}
	
	public partial class GetLandDetailsResult
	{
		
		private long _LandId;
		
		private int _SubAssetId;
		
		private string _SubAssetName;
		
		private string _SubAssetCode;
		
		private string _AssetName;
		
		private string _AssetCode;
		
		private string _LandInformation;
		
		private string _Location;
		
		private decimal _Area;
		
		private string _MapImageURL;
		
		private string _BusinessPlanDetails;
		
		private string _BusinessPlanName;
		
		private string _BusinessPlanStatus;
		
		private string _LandStatus;
		
		private string _LandType;
		
		private string _LandUse;
		
		private string _DistrictName;
		
		private string _CityName;
		
		private string _TDNo;
		
		private System.Nullable<int> _TDType;
		
		private System.Nullable<int> _TDStatus;
		
		private string _ReferenceNumber;
		
		public GetLandDetailsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandId", DbType="BigInt NOT NULL")]
		public long LandId
		{
			get
			{
				return this._LandId;
			}
			set
			{
				if ((this._LandId != value))
				{
					this._LandId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubAssetId", DbType="Int NOT NULL")]
		public int SubAssetId
		{
			get
			{
				return this._SubAssetId;
			}
			set
			{
				if ((this._SubAssetId != value))
				{
					this._SubAssetId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubAssetName", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string SubAssetName
		{
			get
			{
				return this._SubAssetName;
			}
			set
			{
				if ((this._SubAssetName != value))
				{
					this._SubAssetName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubAssetCode", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SubAssetCode
		{
			get
			{
				return this._SubAssetCode;
			}
			set
			{
				if ((this._SubAssetCode != value))
				{
					this._SubAssetCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetName", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string AssetName
		{
			get
			{
				return this._AssetName;
			}
			set
			{
				if ((this._AssetName != value))
				{
					this._AssetName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetCode", DbType="NVarChar(50)")]
		public string AssetCode
		{
			get
			{
				return this._AssetCode;
			}
			set
			{
				if ((this._AssetCode != value))
				{
					this._AssetCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandInformation", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string LandInformation
		{
			get
			{
				return this._LandInformation;
			}
			set
			{
				if ((this._LandInformation != value))
				{
					this._LandInformation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this._Location = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="Decimal(18,0) NOT NULL")]
		public decimal Area
		{
			get
			{
				return this._Area;
			}
			set
			{
				if ((this._Area != value))
				{
					this._Area = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MapImageURL", DbType="VarChar(1000)")]
		public string MapImageURL
		{
			get
			{
				return this._MapImageURL;
			}
			set
			{
				if ((this._MapImageURL != value))
				{
					this._MapImageURL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessPlanDetails", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string BusinessPlanDetails
		{
			get
			{
				return this._BusinessPlanDetails;
			}
			set
			{
				if ((this._BusinessPlanDetails != value))
				{
					this._BusinessPlanDetails = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessPlanName", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string BusinessPlanName
		{
			get
			{
				return this._BusinessPlanName;
			}
			set
			{
				if ((this._BusinessPlanName != value))
				{
					this._BusinessPlanName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessPlanStatus", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string BusinessPlanStatus
		{
			get
			{
				return this._BusinessPlanStatus;
			}
			set
			{
				if ((this._BusinessPlanStatus != value))
				{
					this._BusinessPlanStatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandStatus", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LandStatus
		{
			get
			{
				return this._LandStatus;
			}
			set
			{
				if ((this._LandStatus != value))
				{
					this._LandStatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandType", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LandType
		{
			get
			{
				return this._LandType;
			}
			set
			{
				if ((this._LandType != value))
				{
					this._LandType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandUse", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LandUse
		{
			get
			{
				return this._LandUse;
			}
			set
			{
				if ((this._LandUse != value))
				{
					this._LandUse = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DistrictName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string DistrictName
		{
			get
			{
				return this._DistrictName;
			}
			set
			{
				if ((this._DistrictName != value))
				{
					this._DistrictName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string CityName
		{
			get
			{
				return this._CityName;
			}
			set
			{
				if ((this._CityName != value))
				{
					this._CityName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TDNo", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string TDNo
		{
			get
			{
				return this._TDNo;
			}
			set
			{
				if ((this._TDNo != value))
				{
					this._TDNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TDType", DbType="Int")]
		public System.Nullable<int> TDType
		{
			get
			{
				return this._TDType;
			}
			set
			{
				if ((this._TDType != value))
				{
					this._TDType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TDStatus", DbType="Int")]
		public System.Nullable<int> TDStatus
		{
			get
			{
				return this._TDStatus;
			}
			set
			{
				if ((this._TDStatus != value))
				{
					this._TDStatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReferenceNumber", DbType="VarChar(20)")]
		public string ReferenceNumber
		{
			get
			{
				return this._ReferenceNumber;
			}
			set
			{
				if ((this._ReferenceNumber != value))
				{
					this._ReferenceNumber = value;
				}
			}
		}
	}
	
	public partial class GetLandByAssetIdResult
	{
		
		private long _LandId;
		
		private decimal _Area;
		
		private string _Location;
		
		private string _AssetName;
		
		private string _SubAssetName;
		
		private string _LandStatus;
		
		private string _LandType;
		
		private string _LandUse;
		
		private string _DistrictName;
		
		private string _CityName;
		
		private string _ReferenceNumber;
		
		public GetLandByAssetIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandId", DbType="BigInt NOT NULL")]
		public long LandId
		{
			get
			{
				return this._LandId;
			}
			set
			{
				if ((this._LandId != value))
				{
					this._LandId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="Decimal(18,0) NOT NULL")]
		public decimal Area
		{
			get
			{
				return this._Area;
			}
			set
			{
				if ((this._Area != value))
				{
					this._Area = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this._Location = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetName", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string AssetName
		{
			get
			{
				return this._AssetName;
			}
			set
			{
				if ((this._AssetName != value))
				{
					this._AssetName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubAssetName", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string SubAssetName
		{
			get
			{
				return this._SubAssetName;
			}
			set
			{
				if ((this._SubAssetName != value))
				{
					this._SubAssetName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandStatus", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LandStatus
		{
			get
			{
				return this._LandStatus;
			}
			set
			{
				if ((this._LandStatus != value))
				{
					this._LandStatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandType", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LandType
		{
			get
			{
				return this._LandType;
			}
			set
			{
				if ((this._LandType != value))
				{
					this._LandType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandUse", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LandUse
		{
			get
			{
				return this._LandUse;
			}
			set
			{
				if ((this._LandUse != value))
				{
					this._LandUse = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DistrictName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string DistrictName
		{
			get
			{
				return this._DistrictName;
			}
			set
			{
				if ((this._DistrictName != value))
				{
					this._DistrictName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string CityName
		{
			get
			{
				return this._CityName;
			}
			set
			{
				if ((this._CityName != value))
				{
					this._CityName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReferenceNumber", DbType="VarChar(20)")]
		public string ReferenceNumber
		{
			get
			{
				return this._ReferenceNumber;
			}
			set
			{
				if ((this._ReferenceNumber != value))
				{
					this._ReferenceNumber = value;
				}
			}
		}
	}
	
	public partial class GetLandDetailsFiltersResult
	{
		
		private long _LandId;
		
		private int _SubAssetId;
		
		private string _SubAssetName;
		
		private string _SubAssetCode;
		
		private string _AssetName;
		
		private string _AssetCode;
		
		private string _LandInformation;
		
		private string _Location;
		
		private decimal _Area;
		
		private string _MapImageURL;
		
		private string _BusinessPlanDetails;
		
		private string _BusinessPlanName;
		
		private string _BusinessPlanStatus;
		
		private string _LandStatus;
		
		private string _LandType;
		
		private string _LandUse;
		
		private string _DistrictName;
		
		private string _CityName;
		
		private string _TDNo;
		
		private System.Nullable<int> _TDType;
		
		private System.Nullable<int> _TDStatus;
		
		private string _ReferenceNumber;
		
		private string _TitleDeeds;
		
		public GetLandDetailsFiltersResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandId", DbType="BigInt NOT NULL")]
		public long LandId
		{
			get
			{
				return this._LandId;
			}
			set
			{
				if ((this._LandId != value))
				{
					this._LandId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubAssetId", DbType="Int NOT NULL")]
		public int SubAssetId
		{
			get
			{
				return this._SubAssetId;
			}
			set
			{
				if ((this._SubAssetId != value))
				{
					this._SubAssetId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubAssetName", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string SubAssetName
		{
			get
			{
				return this._SubAssetName;
			}
			set
			{
				if ((this._SubAssetName != value))
				{
					this._SubAssetName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubAssetCode", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SubAssetCode
		{
			get
			{
				return this._SubAssetCode;
			}
			set
			{
				if ((this._SubAssetCode != value))
				{
					this._SubAssetCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetName", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string AssetName
		{
			get
			{
				return this._AssetName;
			}
			set
			{
				if ((this._AssetName != value))
				{
					this._AssetName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetCode", DbType="NVarChar(50)")]
		public string AssetCode
		{
			get
			{
				return this._AssetCode;
			}
			set
			{
				if ((this._AssetCode != value))
				{
					this._AssetCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandInformation", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string LandInformation
		{
			get
			{
				return this._LandInformation;
			}
			set
			{
				if ((this._LandInformation != value))
				{
					this._LandInformation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this._Location = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="Decimal(18,0) NOT NULL")]
		public decimal Area
		{
			get
			{
				return this._Area;
			}
			set
			{
				if ((this._Area != value))
				{
					this._Area = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MapImageURL", DbType="VarChar(1000)")]
		public string MapImageURL
		{
			get
			{
				return this._MapImageURL;
			}
			set
			{
				if ((this._MapImageURL != value))
				{
					this._MapImageURL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessPlanDetails", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string BusinessPlanDetails
		{
			get
			{
				return this._BusinessPlanDetails;
			}
			set
			{
				if ((this._BusinessPlanDetails != value))
				{
					this._BusinessPlanDetails = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessPlanName", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string BusinessPlanName
		{
			get
			{
				return this._BusinessPlanName;
			}
			set
			{
				if ((this._BusinessPlanName != value))
				{
					this._BusinessPlanName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessPlanStatus", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string BusinessPlanStatus
		{
			get
			{
				return this._BusinessPlanStatus;
			}
			set
			{
				if ((this._BusinessPlanStatus != value))
				{
					this._BusinessPlanStatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandStatus", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LandStatus
		{
			get
			{
				return this._LandStatus;
			}
			set
			{
				if ((this._LandStatus != value))
				{
					this._LandStatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandType", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LandType
		{
			get
			{
				return this._LandType;
			}
			set
			{
				if ((this._LandType != value))
				{
					this._LandType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandUse", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LandUse
		{
			get
			{
				return this._LandUse;
			}
			set
			{
				if ((this._LandUse != value))
				{
					this._LandUse = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DistrictName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string DistrictName
		{
			get
			{
				return this._DistrictName;
			}
			set
			{
				if ((this._DistrictName != value))
				{
					this._DistrictName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string CityName
		{
			get
			{
				return this._CityName;
			}
			set
			{
				if ((this._CityName != value))
				{
					this._CityName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TDNo", DbType="NVarChar(500)")]
		public string TDNo
		{
			get
			{
				return this._TDNo;
			}
			set
			{
				if ((this._TDNo != value))
				{
					this._TDNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TDType", DbType="Int")]
		public System.Nullable<int> TDType
		{
			get
			{
				return this._TDType;
			}
			set
			{
				if ((this._TDType != value))
				{
					this._TDType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TDStatus", DbType="Int")]
		public System.Nullable<int> TDStatus
		{
			get
			{
				return this._TDStatus;
			}
			set
			{
				if ((this._TDStatus != value))
				{
					this._TDStatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReferenceNumber", DbType="VarChar(20)")]
		public string ReferenceNumber
		{
			get
			{
				return this._ReferenceNumber;
			}
			set
			{
				if ((this._ReferenceNumber != value))
				{
					this._ReferenceNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleDeeds", DbType="NVarChar(MAX)")]
		public string TitleDeeds
		{
			get
			{
				return this._TitleDeeds;
			}
			set
			{
				if ((this._TitleDeeds != value))
				{
					this._TitleDeeds = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
