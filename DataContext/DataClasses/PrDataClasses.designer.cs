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
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetLandUses")]
		public ISingleResult<GetLandUsesResult> GetLandUses([global::System.Data.Linq.Mapping.ParameterAttribute(Name="StatusType", DbType="VarChar(50)")] string statusType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), statusType);
			return ((ISingleResult<GetLandUsesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UserLogin")]
		public ISingleResult<UserLoginResult> UserLogin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="NVarChar(255)")] string email)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), email);
			return ((ISingleResult<UserLoginResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetLandDetailsFilters")]
		public ISingleResult<GetLandDetailsFiltersResult> GetLandDetailsFilters([global::System.Data.Linq.Mapping.ParameterAttribute(Name="LandId", DbType="Int")] System.Nullable<int> landId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Deptt", DbType="VarChar(50)")] string deptt, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), landId, deptt, userId);
			return ((ISingleResult<GetLandDetailsFiltersResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetLandByAssetId")]
		public ISingleResult<GetLandByAssetIdResult> GetLandByAssetId([global::System.Data.Linq.Mapping.ParameterAttribute(Name="AssetId", DbType="Int")] System.Nullable<int> assetId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SearchText", DbType="VarChar(100)")] string searchText, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CityId", DbType="Int")] System.Nullable<int> cityId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DistrictId", DbType="Int")] System.Nullable<int> districtId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="OwnerId", DbType="Int")] System.Nullable<int> ownerId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LandUseId", DbType="Int")] System.Nullable<int> landUseId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="BusinessPlanId", DbType="Int")] System.Nullable<int> businessPlanId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WLTStatus", DbType="Int")] System.Nullable<int> wLTStatus, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), assetId, searchText, cityId, districtId, ownerId, landUseId, businessPlanId, wLTStatus, userId);
			return ((ISingleResult<GetLandByAssetIdResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddBuyerDetails")]
		public ISingleResult<AddBuyerDetailsResult> AddBuyerDetails([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="BuyerId", DbType="VarChar(50)")] string buyerId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="BuyerName", DbType="NVarChar(50)")] string buyerName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CompanyId", DbType="Int")] System.Nullable<int> companyId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="NVarChar(50)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Mobile", DbType="NVarChar(50)")] string mobile)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userId, buyerId, buyerName, companyId, email, mobile);
			return ((ISingleResult<AddBuyerDetailsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetbuyerDetails")]
		public ISingleResult<GetbuyerDetailsResult> GetbuyerDetails([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Search", DbType="NVarChar(50)")] string search, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), search, userId);
			return ((ISingleResult<GetbuyerDetailsResult>)(result.ReturnValue));
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
		
		private string _AssetCode;
		
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalLandArea", DbType="Decimal(38,2)")]
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
	
	public partial class GetLandUsesResult
	{
		
		private string _JSON_F52E2B61_18A1_11d1_B105_00805F49916B;
		
		public GetLandUsesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[JSON_F52E2B61-18A1-11d1-B105-00805F49916B]", Storage="_JSON_F52E2B61_18A1_11d1_B105_00805F49916B", DbType="NVarChar(MAX)")]
		public string JSON_F52E2B61_18A1_11d1_B105_00805F49916B
		{
			get
			{
				return this._JSON_F52E2B61_18A1_11d1_B105_00805F49916B;
			}
			set
			{
				if ((this._JSON_F52E2B61_18A1_11d1_B105_00805F49916B != value))
				{
					this._JSON_F52E2B61_18A1_11d1_B105_00805F49916B = value;
				}
			}
		}
	}
	
	public partial class UserLoginResult
	{
		
		private int _Id;
		
		private string _AdId;
		
		private string _DisplayName;
		
		private string _FName;
		
		private string _MName;
		
		private string _LName;
		
		private string _Email;
		
		private string _MobilePhone;
		
		private string _JobTitle;
		
		private string _Position;
		
		private string _Password;
		
		private string _Role;
		
		private string _Company;
		
		private string _Department;
		
		public UserLoginResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdId", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string AdId
		{
			get
			{
				return this._AdId;
			}
			set
			{
				if ((this._AdId != value))
				{
					this._AdId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DisplayName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string DisplayName
		{
			get
			{
				return this._DisplayName;
			}
			set
			{
				if ((this._DisplayName != value))
				{
					this._DisplayName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string FName
		{
			get
			{
				return this._FName;
			}
			set
			{
				if ((this._FName != value))
				{
					this._FName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string MName
		{
			get
			{
				return this._MName;
			}
			set
			{
				if ((this._MName != value))
				{
					this._MName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string LName
		{
			get
			{
				return this._LName;
			}
			set
			{
				if ((this._LName != value))
				{
					this._LName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MobilePhone", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string MobilePhone
		{
			get
			{
				return this._MobilePhone;
			}
			set
			{
				if ((this._MobilePhone != value))
				{
					this._MobilePhone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobTitle", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string JobTitle
		{
			get
			{
				return this._JobTitle;
			}
			set
			{
				if ((this._JobTitle != value))
				{
					this._JobTitle = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this._Position = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this._Role = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="NVarChar(100)")]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this._Company = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="NVarChar(100)")]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this._Department = value;
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
		
		private string _PlotNo;
		
		private string _BusinessPlanDetails;
		
		private string _BusinessPlanName;
		
		private string _BusinessPlanStatus;
		
		private string _LandStatus;
		
		private string _LandType;
		
		private string _LandUse;
		
		private string _DistrictName;
		
		private string _CityName;
		
		private string _TDNo;
		
		private string _TDType;
		
		private string _TitleDeedStatus;
		
		private string _TDDate;
		
		private string _TDOwnership;
		
		private string _WLTStatus;
		
		private System.Nullable<decimal> _Latitude;
		
		private System.Nullable<decimal> _Longitude;
		
		private string _ReferenceNumber;
		
		private string _MasterPlan;
		
		private string _InfraApproval;
		
		private string _InfraContraction;
		
		private string _MHandingOver;
		
		private string _TitleDeeds;
		
		private string _Sales;
		
		private string _Finance;
		
		private string _Wlt;
		
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="Decimal(18,2) NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlotNo", DbType="NVarChar(500)")]
		public string PlotNo
		{
			get
			{
				return this._PlotNo;
			}
			set
			{
				if ((this._PlotNo != value))
				{
					this._PlotNo = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TDType", DbType="NVarChar(500)")]
		public string TDType
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleDeedStatus", DbType="NVarChar(500)")]
		public string TitleDeedStatus
		{
			get
			{
				return this._TitleDeedStatus;
			}
			set
			{
				if ((this._TitleDeedStatus != value))
				{
					this._TitleDeedStatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TDDate", DbType="NVarChar(30)")]
		public string TDDate
		{
			get
			{
				return this._TDDate;
			}
			set
			{
				if ((this._TDDate != value))
				{
					this._TDDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TDOwnership", DbType="NVarChar(50)")]
		public string TDOwnership
		{
			get
			{
				return this._TDOwnership;
			}
			set
			{
				if ((this._TDOwnership != value))
				{
					this._TDOwnership = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WLTStatus", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string WLTStatus
		{
			get
			{
				return this._WLTStatus;
			}
			set
			{
				if ((this._WLTStatus != value))
				{
					this._WLTStatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="Decimal(9,6)")]
		public System.Nullable<decimal> Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this._Latitude = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="Decimal(9,6)")]
		public System.Nullable<decimal> Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this._Longitude = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MasterPlan", DbType="VarChar(100)")]
		public string MasterPlan
		{
			get
			{
				return this._MasterPlan;
			}
			set
			{
				if ((this._MasterPlan != value))
				{
					this._MasterPlan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InfraApproval", DbType="VarChar(100)")]
		public string InfraApproval
		{
			get
			{
				return this._InfraApproval;
			}
			set
			{
				if ((this._InfraApproval != value))
				{
					this._InfraApproval = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InfraContraction", DbType="VarChar(100)")]
		public string InfraContraction
		{
			get
			{
				return this._InfraContraction;
			}
			set
			{
				if ((this._InfraContraction != value))
				{
					this._InfraContraction = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MHandingOver", DbType="VarChar(100)")]
		public string MHandingOver
		{
			get
			{
				return this._MHandingOver;
			}
			set
			{
				if ((this._MHandingOver != value))
				{
					this._MHandingOver = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sales", DbType="NVarChar(MAX)")]
		public string Sales
		{
			get
			{
				return this._Sales;
			}
			set
			{
				if ((this._Sales != value))
				{
					this._Sales = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Finance", DbType="NVarChar(MAX)")]
		public string Finance
		{
			get
			{
				return this._Finance;
			}
			set
			{
				if ((this._Finance != value))
				{
					this._Finance = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Wlt", DbType="NVarChar(MAX)")]
		public string Wlt
		{
			get
			{
				return this._Wlt;
			}
			set
			{
				if ((this._Wlt != value))
				{
					this._Wlt = value;
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
		
		private string _LandDeed;
		
		private string _BusinessPlan;
		
		private string _DeedOwner;
		
		private string _IsWlt;
		
		private string _TitleDeedStatus;
		
		private System.Nullable<int> _RandomNumber;
		
		private string _ReferenceNumber;
		
		private System.Nullable<long> _RowNum;
		
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="Decimal(18,2) NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandDeed", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string LandDeed
		{
			get
			{
				return this._LandDeed;
			}
			set
			{
				if ((this._LandDeed != value))
				{
					this._LandDeed = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessPlan", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string BusinessPlan
		{
			get
			{
				return this._BusinessPlan;
			}
			set
			{
				if ((this._BusinessPlan != value))
				{
					this._BusinessPlan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeedOwner", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DeedOwner
		{
			get
			{
				return this._DeedOwner;
			}
			set
			{
				if ((this._DeedOwner != value))
				{
					this._DeedOwner = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsWlt", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string IsWlt
		{
			get
			{
				return this._IsWlt;
			}
			set
			{
				if ((this._IsWlt != value))
				{
					this._IsWlt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TitleDeedStatus", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string TitleDeedStatus
		{
			get
			{
				return this._TitleDeedStatus;
			}
			set
			{
				if ((this._TitleDeedStatus != value))
				{
					this._TitleDeedStatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RandomNumber", DbType="Int")]
		public System.Nullable<int> RandomNumber
		{
			get
			{
				return this._RandomNumber;
			}
			set
			{
				if ((this._RandomNumber != value))
				{
					this._RandomNumber = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RowNum", DbType="BigInt")]
		public System.Nullable<long> RowNum
		{
			get
			{
				return this._RowNum;
			}
			set
			{
				if ((this._RowNum != value))
				{
					this._RowNum = value;
				}
			}
		}
	}
	
	public partial class AddBuyerDetailsResult
	{
		
		private System.Nullable<decimal> _NewBuyerId;
		
		public AddBuyerDetailsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewBuyerId", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> NewBuyerId
		{
			get
			{
				return this._NewBuyerId;
			}
			set
			{
				if ((this._NewBuyerId != value))
				{
					this._NewBuyerId = value;
				}
			}
		}
	}
	
	public partial class GetbuyerDetailsResult
	{
		
		private string _BuyerId;
		
		private string _BuyerName;
		
		private string _Email;
		
		private string _Mobile;
		
		private string _CompanyNameEn;
		
		public GetbuyerDetailsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuyerId", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string BuyerId
		{
			get
			{
				return this._BuyerId;
			}
			set
			{
				if ((this._BuyerId != value))
				{
					this._BuyerId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuyerName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string BuyerName
		{
			get
			{
				return this._BuyerName;
			}
			set
			{
				if ((this._BuyerName != value))
				{
					this._BuyerName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Mobile
		{
			get
			{
				return this._Mobile;
			}
			set
			{
				if ((this._Mobile != value))
				{
					this._Mobile = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyNameEn", DbType="NVarChar(100)")]
		public string CompanyNameEn
		{
			get
			{
				return this._CompanyNameEn;
			}
			set
			{
				if ((this._CompanyNameEn != value))
				{
					this._CompanyNameEn = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
