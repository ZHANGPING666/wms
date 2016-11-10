 
using IBLL;
using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	
	public partial class BackInputService :BaseService<BackInput>,IBackInputService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.BackInputDal;
        }
    }   
	
	public partial class BackOutputService :BaseService<BackOutput>,IBackOutputService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.BackOutputDal;
        }
    }   
	
	public partial class CheckBillService :BaseService<CheckBill>,ICheckBillService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.CheckBillDal;
        }
    }   
	
	public partial class DIYBillService :BaseService<DIYBill>,IDIYBillService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.DIYBillDal;
        }
    }   
	
	public partial class GiveBillService :BaseService<GiveBill>,IGiveBillService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.GiveBillDal;
        }
    }   
	
	public partial class GoodItemService :BaseService<GoodItem>,IGoodItemService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.GoodItemDal;
        }
    }   
	
	public partial class InWarehouseService :BaseService<InWarehouse>,IInWarehouseService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.InWarehouseDal;
        }
    }   
	
	public partial class LocationService :BaseService<Location>,ILocationService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.LocationDal;
        }
    }   
	
	public partial class LocationChangeService :BaseService<LocationChange>,ILocationChangeService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.LocationChangeDal;
        }
    }   
	
	public partial class MenuAService :BaseService<MenuA>,IMenuAService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.MenuADal;
        }
    }   
	
	public partial class MenuBService :BaseService<MenuB>,IMenuBService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.MenuBDal;
        }
    }   
	
	public partial class OtherInputService :BaseService<OtherInput>,IOtherInputService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.OtherInputDal;
        }
    }   
	
	public partial class OtherOutputService :BaseService<OtherOutput>,IOtherOutputService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.OtherOutputDal;
        }
    }   
	
	public partial class RecordService :BaseService<Record>,IRecordService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.RecordDal;
        }
    }   
	
	public partial class TaskBillService :BaseService<TaskBill>,ITaskBillService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.TaskBillDal;
        }
    }   
	
	public partial class TransferBillService :BaseService<TransferBill>,ITransferBillService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.TransferBillDal;
        }
    }   
	
	public partial class WarehouseService :BaseService<Warehouse>,IWarehouseService
    {
    
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.WarehouseDal;
        }
    }   
	
}