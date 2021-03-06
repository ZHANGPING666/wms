﻿ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
   
	
	public partial interface IBackInputDal :IBaseDal<DBModel.BackInput>
    {
      
    }
	
	public partial interface IBackOutputDal :IBaseDal<DBModel.BackOutput>
    {
      
    }
	
	public partial interface ICheckBillDal :IBaseDal<DBModel.CheckBill>
    {
      
    }
	
	public partial interface IDIYBillDal :IBaseDal<DBModel.DIYBill>
    {
      
    }
	
	public partial interface IGiveBillDal :IBaseDal<DBModel.GiveBill>
    {
      
    }
	
	public partial interface IGoodItemDal :IBaseDal<DBModel.GoodItem>
    {
      
    }
	
	public partial interface IInWarehouseDal :IBaseDal<DBModel.InWarehouse>
    {
      
    }
	
	public partial interface ILocationDal :IBaseDal<DBModel.Location>
    {
      
    }
	
	public partial interface ILocationChangeDal :IBaseDal<DBModel.LocationChange>
    {
      
    }
	
	public partial interface IMenuADal :IBaseDal<DBModel.MenuA>
    {
      
    }
	
	public partial interface IMenuBDal :IBaseDal<DBModel.MenuB>
    {
      
    }
	
	public partial interface IOtherInputDal :IBaseDal<DBModel.OtherInput>
    {
      
    }
	
	public partial interface IOtherOutputDal :IBaseDal<DBModel.OtherOutput>
    {
      
    }
	
	public partial interface IRecordDal :IBaseDal<DBModel.Record>
    {
      
    }
	
	public partial interface ITaskBillDal :IBaseDal<DBModel.TaskBill>
    {
      
    }
	
	public partial interface ITransferBillDal :IBaseDal<DBModel.TransferBill>
    {
      
    }
	
	public partial interface IWarehouseDal :IBaseDal<DBModel.Warehouse>
    {
      
    }
	
}