namespace Library.DbContext.Entities
{
    // CustomerWallet

    public partial class CustomerWallet
    {

        ///<summary>
        /// Mã Định khoản thu-chi
        ///</summary>
        public int Id { get; set; } // Id
        public int? Idd { get; set; } // IDD
        public string IdPath { get; set; } // IdPath (length: 400)

        ///<summary>
        /// Tên đường dẫn
        ///</summary>
        public string NamePath { get; set; } // NamePath (length: 500)

        ///<summary>
        /// Tên định khoản thu - chi
        ///</summary>
        public string Name { get; set; } // Name (length: 300)

        ///<summary>
        /// Mã cha kế thừa,  cha có mã là:0
        ///</summary>
        public int ParentId { get; set; } // ParentId

        ///<summary>
        /// Tên cha
        ///</summary>
        public string ParentName { get; set; } // ParentName (length: 300)

        ///<summary>
        /// Toán tử  FALSE: trừ , TRUE: cộng
        ///</summary>
        public bool? Operator { get; set; } // Operator

        ///<summary>
        /// 0: chưa xóa. 1: đã xóa
        ///</summary>
        public bool IsDelete { get; set; } // IsDelete

        ///<summary>
        /// 0: hoạt động, 1:tạm ngưng
        ///</summary>
        public byte Status { get; set; } // Status

        ///<summary>
        /// Mô tả
        ///</summary>
        public string Description { get; set; } // Description (length: 600)

        ///<summary>
        /// True là cha, false là con
        ///</summary>
        public bool IsParent { get; set; } // IsParent
        ///<summary>
        /// định tự tạo: 1, định khoản tạo từ bên ngoài: 0
        ///</summary>
        public bool IsIdSystem { get; set; } // IsIdSystem

        public CustomerWallet()
        {
            IsDelete = false;
            Status = 0;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
