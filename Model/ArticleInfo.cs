//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ArticleInfo
    {
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public Nullable<System.DateTime> ArticleDate { get; set; }
        public string Author { get; set; }
        public Nullable<int> IsEnable { get; set; }
        public Nullable<int> IsTop { get; set; }
        public Nullable<int> IsNew { get; set; }
        public Nullable<int> IsHot { get; set; }
        public string Remark { get; set; }
        public Nullable<int> AddUser { get; set; }
        public Nullable<int> MenuId { get; set; }
    }
}