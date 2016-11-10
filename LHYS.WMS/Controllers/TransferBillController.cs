using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using DBModel;
using Newtonsoft.Json;

namespace LHYS.WMS.Controllers
{
    public class TransferBillController : Controller
    {
        // GET: TransferBill
        private ITransferBillService TransferBillService { get; set; }
        private IRecordService RecordService { get; set; }
        public ActionResult Index()
        {
            return View();
        }
        //获取表单数据
        public ActionResult GetData()
        {
            string str = Request.Params["TransferBillId"].ToString();
            //如果新单据 没有数据
            if (Request["TransferBillId"].ToString() =="")
            {
                return Json(new TransferBill());//返回一个新建的空对象
            }
            Guid TransferBillId = new Guid(Request["TransferBillId"]);//单据编号
            TransferBill bill = TransferBillService.LoadEntities(t => t.Id == TransferBillId).FirstOrDefault();//获取表单
            //return Content(res);//如果是拼接字符串  就用return Content();   如果是对象 就用 return Json();
            return Json(bill);
        }

        //保存表单数据
        public ActionResult SaveData()
        {
            bool result = true;
            string res = Request.Params["TransferBill"].ToString();
            TransferBill bill = JsonConvert.DeserializeObject<TransferBill>(res);
            //保存主表数据
            if (bill.Id == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                bill.Id = Guid.NewGuid();
                foreach (var item in bill.Record)
                {
                    if (item.Id == Guid.Parse("00000000-0000-0000-0000-000000000000")) {
                        item.Id = Guid.NewGuid();
                    }
                }
                TransferBillService.AddEntity(bill);  
                   
            }
            else
            {
                result = TransferBillService.EditEntity(bill);
            }

            //删除原子表数据
            //List<Record> list = RecordService.LoadEntities(a => a.MainTableId == bill.Id).ToList();
            //foreach (Record item in list)
            //{
            //    RecordService.DeleteEntity(item);
            //}
            //添加子表数据
            //foreach (Record record in bill.Record)
            //{
            //    if (record.Id == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            //    {
            //        record.Id = Guid.NewGuid();//新生成一个id
            //        record.MainTableId = bill.Id;
            //        RecordService.AddEntity(record);
            //    }
            //}
            return Content(result.ToString());
        }
    }
}