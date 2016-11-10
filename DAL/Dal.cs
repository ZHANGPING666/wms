 

using IDAL;
using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DAL
{
		
	public partial class BackInputDal :BaseDal<BackInput>,IBackInputDal
    {

    }
		
	public partial class BackOutputDal :BaseDal<BackOutput>,IBackOutputDal
    {

    }
		
	public partial class CheckBillDal :BaseDal<CheckBill>,ICheckBillDal
    {

    }
		
	public partial class DIYBillDal :BaseDal<DIYBill>,IDIYBillDal
    {

    }
		
	public partial class GiveBillDal :BaseDal<GiveBill>,IGiveBillDal
    {

    }
		
	public partial class GoodItemDal :BaseDal<GoodItem>,IGoodItemDal
    {

    }
		
	public partial class InWarehouseDal :BaseDal<InWarehouse>,IInWarehouseDal
    {

    }
		
	public partial class LocationDal :BaseDal<Location>,ILocationDal
    {

    }
		
	public partial class LocationChangeDal :BaseDal<LocationChange>,ILocationChangeDal
    {

    }
		
	public partial class MenuADal :BaseDal<MenuA>,IMenuADal
    {

    }
		
	public partial class MenuBDal :BaseDal<MenuB>,IMenuBDal
    {

    }
		
	public partial class OtherInputDal :BaseDal<OtherInput>,IOtherInputDal
    {

    }
		
	public partial class OtherOutputDal :BaseDal<OtherOutput>,IOtherOutputDal
    {

    }
		
	public partial class RecordDal :BaseDal<Record>,IRecordDal
    {

    }
		
	public partial class TaskBillDal :BaseDal<TaskBill>,ITaskBillDal
    {

    }
		
	public partial class TransferBillDal :BaseDal<TransferBill>,ITransferBillDal
    {

    }
		
	public partial class WarehouseDal :BaseDal<Warehouse>,IWarehouseDal
    {

    }
	
}