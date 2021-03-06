﻿ 

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
	public partial interface IDBSession
    {

	
		IBackInputDal BackInputDal{get;set;}
	
		IBackOutputDal BackOutputDal{get;set;}
	
		ICheckBillDal CheckBillDal{get;set;}
	
		IDIYBillDal DIYBillDal{get;set;}
	
		IGiveBillDal GiveBillDal{get;set;}
	
		IGoodItemDal GoodItemDal{get;set;}
	
		IInWarehouseDal InWarehouseDal{get;set;}
	
		ILocationDal LocationDal{get;set;}
	
		ILocationChangeDal LocationChangeDal{get;set;}
	
		IMenuADal MenuADal{get;set;}
	
		IMenuBDal MenuBDal{get;set;}
	
		IOtherInputDal OtherInputDal{get;set;}
	
		IOtherOutputDal OtherOutputDal{get;set;}
	
		IRecordDal RecordDal{get;set;}
	
		ITaskBillDal TaskBillDal{get;set;}
	
		ITransferBillDal TransferBillDal{get;set;}
	
		IWarehouseDal WarehouseDal{get;set;}
	}	
}