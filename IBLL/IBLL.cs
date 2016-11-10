 

using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  IBLL
{
	
	public partial interface IBackInputService : IBaseService<BackInput>
    {
       
    }   
	
	public partial interface IBackOutputService : IBaseService<BackOutput>
    {
       
    }   
	
	public partial interface ICheckBillService : IBaseService<CheckBill>
    {
       
    }   
	
	public partial interface IDIYBillService : IBaseService<DIYBill>
    {
       
    }   
	
	public partial interface IGiveBillService : IBaseService<GiveBill>
    {
       
    }   
	
	public partial interface IGoodItemService : IBaseService<GoodItem>
    {
       
    }   
	
	public partial interface IInWarehouseService : IBaseService<InWarehouse>
    {
       
    }   
	
	public partial interface ILocationService : IBaseService<Location>
    {
       
    }   
	
	public partial interface ILocationChangeService : IBaseService<LocationChange>
    {
       
    }   
	
	public partial interface IMenuAService : IBaseService<MenuA>
    {
       
    }   
	
	public partial interface IMenuBService : IBaseService<MenuB>
    {
       
    }   
	
	public partial interface IOtherInputService : IBaseService<OtherInput>
    {
       
    }   
	
	public partial interface IOtherOutputService : IBaseService<OtherOutput>
    {
       
    }   
	
	public partial interface IRecordService : IBaseService<Record>
    {
       
    }   
	
	public partial interface ITaskBillService : IBaseService<TaskBill>
    {
       
    }   
	
	public partial interface ITransferBillService : IBaseService<TransferBill>
    {
       
    }   
	
	public partial interface IWarehouseService : IBaseService<Warehouse>
    {
       
    }   
	
}