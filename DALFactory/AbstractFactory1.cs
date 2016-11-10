 

using IDAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DALFactory
{
    public partial class AbstractFactory
    {
      
   
		
	    public static IBackInputDal CreateBackInputDal()
        {

		 string fullClassName = NameSpace + ".BackInputDal";
          return CreateInstance(fullClassName) as IBackInputDal;

        }
		
	    public static IBackOutputDal CreateBackOutputDal()
        {

		 string fullClassName = NameSpace + ".BackOutputDal";
          return CreateInstance(fullClassName) as IBackOutputDal;

        }
		
	    public static ICheckBillDal CreateCheckBillDal()
        {

		 string fullClassName = NameSpace + ".CheckBillDal";
          return CreateInstance(fullClassName) as ICheckBillDal;

        }
		
	    public static IDIYBillDal CreateDIYBillDal()
        {

		 string fullClassName = NameSpace + ".DIYBillDal";
          return CreateInstance(fullClassName) as IDIYBillDal;

        }
		
	    public static IGiveBillDal CreateGiveBillDal()
        {

		 string fullClassName = NameSpace + ".GiveBillDal";
          return CreateInstance(fullClassName) as IGiveBillDal;

        }
		
	    public static IGoodItemDal CreateGoodItemDal()
        {

		 string fullClassName = NameSpace + ".GoodItemDal";
          return CreateInstance(fullClassName) as IGoodItemDal;

        }
		
	    public static IInWarehouseDal CreateInWarehouseDal()
        {

		 string fullClassName = NameSpace + ".InWarehouseDal";
          return CreateInstance(fullClassName) as IInWarehouseDal;

        }
		
	    public static ILocationDal CreateLocationDal()
        {

		 string fullClassName = NameSpace + ".LocationDal";
          return CreateInstance(fullClassName) as ILocationDal;

        }
		
	    public static ILocationChangeDal CreateLocationChangeDal()
        {

		 string fullClassName = NameSpace + ".LocationChangeDal";
          return CreateInstance(fullClassName) as ILocationChangeDal;

        }
		
	    public static IMenuADal CreateMenuADal()
        {

		 string fullClassName = NameSpace + ".MenuADal";
          return CreateInstance(fullClassName) as IMenuADal;

        }
		
	    public static IMenuBDal CreateMenuBDal()
        {

		 string fullClassName = NameSpace + ".MenuBDal";
          return CreateInstance(fullClassName) as IMenuBDal;

        }
		
	    public static IOtherInputDal CreateOtherInputDal()
        {

		 string fullClassName = NameSpace + ".OtherInputDal";
          return CreateInstance(fullClassName) as IOtherInputDal;

        }
		
	    public static IOtherOutputDal CreateOtherOutputDal()
        {

		 string fullClassName = NameSpace + ".OtherOutputDal";
          return CreateInstance(fullClassName) as IOtherOutputDal;

        }
		
	    public static IRecordDal CreateRecordDal()
        {

		 string fullClassName = NameSpace + ".RecordDal";
          return CreateInstance(fullClassName) as IRecordDal;

        }
		
	    public static ITaskBillDal CreateTaskBillDal()
        {

		 string fullClassName = NameSpace + ".TaskBillDal";
          return CreateInstance(fullClassName) as ITaskBillDal;

        }
		
	    public static ITransferBillDal CreateTransferBillDal()
        {

		 string fullClassName = NameSpace + ".TransferBillDal";
          return CreateInstance(fullClassName) as ITransferBillDal;

        }
		
	    public static IWarehouseDal CreateWarehouseDal()
        {

		 string fullClassName = NameSpace + ".WarehouseDal";
          return CreateInstance(fullClassName) as IWarehouseDal;

        }
	}
	
}