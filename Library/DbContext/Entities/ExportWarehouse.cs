using System;

namespace Library.DbContext.Entities
{
    // ExportWarehouse
    public partial class ExportWarehouse
    {
        public int Id { get; set; } // Id (Primary key)

        ///<summary>
        /// Mã phiếu nhập kho
        ///</summary>
        public string Code { get; set; } // Code (length: 20)

        ///<summary>
        /// Trạng thái nhập kho (0: Mới khởi tạo, 1: Đã duyệt)
        ///</summary>
        public byte Status { get; set; } // Status

        ///<summary>
        /// Số kiện
        ///</summary>
        public int OrderNo { get; set; } // OrderNo

        ///<summary>
        /// Id kho xuất hàng
        ///</summary>
        public int WarehouseId { get; set; } // WarehouseId
        public string WarehouseIdPath { get; set; } // WarehouseIdPath (length: 300)

        ///<summary>
        /// Tên kho nhập hàng
        ///</summary>
        public string WarehouseName { get; set; } // WarehouseName (length: 300)

        ///<summary>
        /// Địa chỉ kho xuất hàng
        ///</summary>
        public string WarehouseAddress { get; set; } // WarehouseAddress (length: 300)

        ///<summary>
        /// Id nhân viên tạo phiếu
        ///</summary>
        public int? UserId { get; set; } // UserId
        public string UserName { get; set; } // UserName (length: 30)

        ///<summary>
        /// Họ tên nhân viên tạo phiếu
        ///</summary>
        public string UserFullName { get; set; } // UserFullName (length: 300)
        public string UnsignedText { get; set; } // UnsignedText
        public string Note { get; set; } // Note (length: 500)

        ///<summary>
        /// Ngày khởi tạo
        ///</summary>
        public DateTime Created { get; set; } // Created
        public DateTime Updated { get; set; } // Updated
        public bool IsDelete { get; set; } // IsDelete

        public ExportWarehouse()
        {
            OrderNo = 0;
            UnsignedText = "";
            Created = DateTime.Now;
            Updated = DateTime.Now;
            IsDelete = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}