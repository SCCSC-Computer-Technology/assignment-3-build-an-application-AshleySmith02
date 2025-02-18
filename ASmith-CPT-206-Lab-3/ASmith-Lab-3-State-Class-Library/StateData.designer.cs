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

namespace ASmith_Lab_3_State_Class_Library
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Statelist")]
	public partial class StateDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertStateTable(StateTable instance);
    partial void UpdateStateTable(StateTable instance);
    partial void DeleteStateTable(StateTable instance);
    #endregion
		
		public StateDataDataContext() : 
				base(global::ASmith_Lab_3_State_Class_Library.Properties.Settings.Default.StatelistConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StateDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StateDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StateDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StateDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<StateTable> StateTables
		{
			get
			{
				return this.GetTable<StateTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StateTable")]
	public partial class StateTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _State_Name;
		
		private decimal _Population;
		
		private string _State_Flag_Description;
		
		private string _State_Flower;
		
		private string _State_Bird;
		
		private string _Three_Largest_Cities_;
		
		private string _State_Capitol;
		
		private decimal _State_Median_Income;
		
		private decimal _Percentage_of_Computer_related_jobs_offered__;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnState_NameChanging(string value);
    partial void OnState_NameChanged();
    partial void OnPopulationChanging(decimal value);
    partial void OnPopulationChanged();
    partial void OnState_Flag_DescriptionChanging(string value);
    partial void OnState_Flag_DescriptionChanged();
    partial void OnState_FlowerChanging(string value);
    partial void OnState_FlowerChanged();
    partial void OnState_BirdChanging(string value);
    partial void OnState_BirdChanged();
    partial void OnThree_Largest_Cities_Changing(string value);
    partial void OnThree_Largest_Cities_Changed();
    partial void OnState_CapitolChanging(string value);
    partial void OnState_CapitolChanged();
    partial void OnState_Median_IncomeChanging(decimal value);
    partial void OnState_Median_IncomeChanged();
    partial void OnPercentage_of_Computer_related_jobs_offered__Changing(decimal value);
    partial void OnPercentage_of_Computer_related_jobs_offered__Changed();
    #endregion
		
		public StateTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[State Name]", Storage="_State_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string State_Name
		{
			get
			{
				return this._State_Name;
			}
			set
			{
				if ((this._State_Name != value))
				{
					this.OnState_NameChanging(value);
					this.SendPropertyChanging();
					this._State_Name = value;
					this.SendPropertyChanged("State_Name");
					this.OnState_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Population", DbType="Decimal(18,0) NOT NULL")]
		public decimal Population
		{
			get
			{
				return this._Population;
			}
			set
			{
				if ((this._Population != value))
				{
					this.OnPopulationChanging(value);
					this.SendPropertyChanging();
					this._Population = value;
					this.SendPropertyChanged("Population");
					this.OnPopulationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[State Flag Description]", Storage="_State_Flag_Description", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string State_Flag_Description
		{
			get
			{
				return this._State_Flag_Description;
			}
			set
			{
				if ((this._State_Flag_Description != value))
				{
					this.OnState_Flag_DescriptionChanging(value);
					this.SendPropertyChanging();
					this._State_Flag_Description = value;
					this.SendPropertyChanged("State_Flag_Description");
					this.OnState_Flag_DescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[State Flower]", Storage="_State_Flower", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string State_Flower
		{
			get
			{
				return this._State_Flower;
			}
			set
			{
				if ((this._State_Flower != value))
				{
					this.OnState_FlowerChanging(value);
					this.SendPropertyChanging();
					this._State_Flower = value;
					this.SendPropertyChanged("State_Flower");
					this.OnState_FlowerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[State Bird]", Storage="_State_Bird", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string State_Bird
		{
			get
			{
				return this._State_Bird;
			}
			set
			{
				if ((this._State_Bird != value))
				{
					this.OnState_BirdChanging(value);
					this.SendPropertyChanging();
					this._State_Bird = value;
					this.SendPropertyChanged("State_Bird");
					this.OnState_BirdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Three Largest Cities:]", Storage="_Three_Largest_Cities_", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Three_Largest_Cities_
		{
			get
			{
				return this._Three_Largest_Cities_;
			}
			set
			{
				if ((this._Three_Largest_Cities_ != value))
				{
					this.OnThree_Largest_Cities_Changing(value);
					this.SendPropertyChanging();
					this._Three_Largest_Cities_ = value;
					this.SendPropertyChanged("Three_Largest_Cities_");
					this.OnThree_Largest_Cities_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[State Capitol]", Storage="_State_Capitol", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string State_Capitol
		{
			get
			{
				return this._State_Capitol;
			}
			set
			{
				if ((this._State_Capitol != value))
				{
					this.OnState_CapitolChanging(value);
					this.SendPropertyChanging();
					this._State_Capitol = value;
					this.SendPropertyChanged("State_Capitol");
					this.OnState_CapitolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[State Median Income]", Storage="_State_Median_Income", DbType="Decimal(8,2) NOT NULL")]
		public decimal State_Median_Income
		{
			get
			{
				return this._State_Median_Income;
			}
			set
			{
				if ((this._State_Median_Income != value))
				{
					this.OnState_Median_IncomeChanging(value);
					this.SendPropertyChanging();
					this._State_Median_Income = value;
					this.SendPropertyChanged("State_Median_Income");
					this.OnState_Median_IncomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Percentage of Computer-related jobs offered: ]", Storage="_Percentage_of_Computer_related_jobs_offered__", DbType="Decimal(18,1) NOT NULL")]
		public decimal Percentage_of_Computer_related_jobs_offered__
		{
			get
			{
				return this._Percentage_of_Computer_related_jobs_offered__;
			}
			set
			{
				if ((this._Percentage_of_Computer_related_jobs_offered__ != value))
				{
					this.OnPercentage_of_Computer_related_jobs_offered__Changing(value);
					this.SendPropertyChanging();
					this._Percentage_of_Computer_related_jobs_offered__ = value;
					this.SendPropertyChanged("Percentage_of_Computer_related_jobs_offered__");
					this.OnPercentage_of_Computer_related_jobs_offered__Changed();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
