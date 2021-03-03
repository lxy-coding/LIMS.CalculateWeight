using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel
{


    [ActiveRecord()]
    public class ExchangeBufferL2Tcwl : ActiveRecordValidationBase<ExchangeBufferL2Tcwl>
    {

        [Property(Column = "MSG_COUNTER", Length = 22, NotNull = true)]
        public virtual long MsgCounter { get; set; }

        [Property(Column = "MSG_TIME", Length = 7)]
        public virtual System.DateTime MsgTime { get; set; }

        [Property(Column = "READ_TIME", Length = 7)]
        public virtual System.DateTime ReadTime { get; set; }

        [Property(Column = "MSG_STATUS", Length = 8)]
        public virtual string MsgStatus { get; set; }

        [Property(Column = "TABLE_NAME", Length = 25)]
        public virtual string TableName { get; set; }

        [Property(Column = "DATA_ID", Length = 22)]
        public virtual long DataId { get; set; }

        [Property(Column = "INSERT_SOURCE", Length = 1)]
        public virtual string InsertSource { get; set; }

        [Property(Column = "LEVEL2_MSG_STATUS", Length = 1)]
        public virtual string Level2MsgStatus { get; set; }

        [Property(Column = "LEVEL2_UPDATE_TIME", Length = 7)]
        public virtual System.DateTime Level2UpdateTime { get; set; }

        [Property(Column = "LEVEL3_MSG_STATUS", Length = 1)]
        public virtual string Level3MsgStatus { get; set; }

        [Property(Column = "LEVEL3_UPDATE_TIME", Length = 7)]
        public virtual System.DateTime Level3UpdateTime { get; set; }
    }
}
