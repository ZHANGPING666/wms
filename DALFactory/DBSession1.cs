 
using IDAL;
using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DALFactory
{
	public partial class DBSession : IDBSession
    {
	




		private IBackInputDal _BackInputDal;
        public IBackInputDal BackInputDal
        {
            get
            {
                if(_BackInputDal == null)
                {
                    _BackInputDal = AbstractFactory.CreateBackInputDal();
                }
                return _BackInputDal;
            }
            set { _BackInputDal = value; }
        }
	




		private IBackOutputDal _BackOutputDal;
        public IBackOutputDal BackOutputDal
        {
            get
            {
                if(_BackOutputDal == null)
                {
                    _BackOutputDal = AbstractFactory.CreateBackOutputDal();
                }
                return _BackOutputDal;
            }
            set { _BackOutputDal = value; }
        }
	




		private ICheckBillDal _CheckBillDal;
        public ICheckBillDal CheckBillDal
        {
            get
            {
                if(_CheckBillDal == null)
                {
                    _CheckBillDal = AbstractFactory.CreateCheckBillDal();
                }
                return _CheckBillDal;
            }
            set { _CheckBillDal = value; }
        }
	




		private IDIYBillDal _DIYBillDal;
        public IDIYBillDal DIYBillDal
        {
            get
            {
                if(_DIYBillDal == null)
                {
                    _DIYBillDal = AbstractFactory.CreateDIYBillDal();
                }
                return _DIYBillDal;
            }
            set { _DIYBillDal = value; }
        }
	




		private IGiveBillDal _GiveBillDal;
        public IGiveBillDal GiveBillDal
        {
            get
            {
                if(_GiveBillDal == null)
                {
                    _GiveBillDal = AbstractFactory.CreateGiveBillDal();
                }
                return _GiveBillDal;
            }
            set { _GiveBillDal = value; }
        }
	




		private IGoodItemDal _GoodItemDal;
        public IGoodItemDal GoodItemDal
        {
            get
            {
                if(_GoodItemDal == null)
                {
                    _GoodItemDal = AbstractFactory.CreateGoodItemDal();
                }
                return _GoodItemDal;
            }
            set { _GoodItemDal = value; }
        }
	




		private IInWarehouseDal _InWarehouseDal;
        public IInWarehouseDal InWarehouseDal
        {
            get
            {
                if(_InWarehouseDal == null)
                {
                    _InWarehouseDal = AbstractFactory.CreateInWarehouseDal();
                }
                return _InWarehouseDal;
            }
            set { _InWarehouseDal = value; }
        }
	




		private ILocationDal _LocationDal;
        public ILocationDal LocationDal
        {
            get
            {
                if(_LocationDal == null)
                {
                    _LocationDal = AbstractFactory.CreateLocationDal();
                }
                return _LocationDal;
            }
            set { _LocationDal = value; }
        }
	




		private ILocationChangeDal _LocationChangeDal;
        public ILocationChangeDal LocationChangeDal
        {
            get
            {
                if(_LocationChangeDal == null)
                {
                    _LocationChangeDal = AbstractFactory.CreateLocationChangeDal();
                }
                return _LocationChangeDal;
            }
            set { _LocationChangeDal = value; }
        }
	




		private IMenuADal _MenuADal;
        public IMenuADal MenuADal
        {
            get
            {
                if(_MenuADal == null)
                {
                    _MenuADal = AbstractFactory.CreateMenuADal();
                }
                return _MenuADal;
            }
            set { _MenuADal = value; }
        }
	




		private IMenuBDal _MenuBDal;
        public IMenuBDal MenuBDal
        {
            get
            {
                if(_MenuBDal == null)
                {
                    _MenuBDal = AbstractFactory.CreateMenuBDal();
                }
                return _MenuBDal;
            }
            set { _MenuBDal = value; }
        }
	




		private IOtherInputDal _OtherInputDal;
        public IOtherInputDal OtherInputDal
        {
            get
            {
                if(_OtherInputDal == null)
                {
                    _OtherInputDal = AbstractFactory.CreateOtherInputDal();
                }
                return _OtherInputDal;
            }
            set { _OtherInputDal = value; }
        }
	




		private IOtherOutputDal _OtherOutputDal;
        public IOtherOutputDal OtherOutputDal
        {
            get
            {
                if(_OtherOutputDal == null)
                {
                    _OtherOutputDal = AbstractFactory.CreateOtherOutputDal();
                }
                return _OtherOutputDal;
            }
            set { _OtherOutputDal = value; }
        }
	




		private IRecordDal _RecordDal;
        public IRecordDal RecordDal
        {
            get
            {
                if(_RecordDal == null)
                {
                    _RecordDal = AbstractFactory.CreateRecordDal();
                }
                return _RecordDal;
            }
            set { _RecordDal = value; }
        }
	




		private ITaskBillDal _TaskBillDal;
        public ITaskBillDal TaskBillDal
        {
            get
            {
                if(_TaskBillDal == null)
                {
                    _TaskBillDal = AbstractFactory.CreateTaskBillDal();
                }
                return _TaskBillDal;
            }
            set { _TaskBillDal = value; }
        }
	




		private ITransferBillDal _TransferBillDal;
        public ITransferBillDal TransferBillDal
        {
            get
            {
                if(_TransferBillDal == null)
                {
                    _TransferBillDal = AbstractFactory.CreateTransferBillDal();
                }
                return _TransferBillDal;
            }
            set { _TransferBillDal = value; }
        }
	




		private IWarehouseDal _WarehouseDal;
        public IWarehouseDal WarehouseDal
        {
            get
            {
                if(_WarehouseDal == null)
                {
                    _WarehouseDal = AbstractFactory.CreateWarehouseDal();
                }
                return _WarehouseDal;
            }
            set { _WarehouseDal = value; }
        }
	}	
}