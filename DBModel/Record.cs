//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Record
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> MainTableId { get; set; }
        public string ItemCode { get; set; }
        public string ItemLine { get; set; }
        public string ItemName { get; set; }
        public string ItemSpecifications { get; set; }
        public string ItemLocation { get; set; }
        public string ItemBatch { get; set; }
        public string ItemUnit { get; set; }
        public Nullable<double> Count { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<double> ReceiveCount { get; set; }
        public string Remark { get; set; }
    }
}
