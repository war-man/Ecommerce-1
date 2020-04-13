﻿using System;

namespace Library.DbContext.Results
{
    public class PackingResult
    {
        public int Id { get; set; } // Id (Primary key)

        ///<summary>
        /// Mã kiện hàng
        ///</summary>
        public string Code { get; set; } // Code (length: 30)

        ///<summary>
        /// Trạng thái kiện hàng: 0: Chờ nhập kho, 1: Đang trong kho, 2: Đang điều chuyển, 3: Mất mã, 4: Hoàn thành, 5: Mất hàng
        ///</summary>
        public byte Status { get; set; } // Status

        ///<summary>
        /// Ghi chú kiện hàng
        ///</summary>
        public string Note { get; set; } // Note (length: 600)

        ///<summary>
        /// Id đơn hàng
        ///</summary>
        public int OrderId { get; set; } // OrderId

        ///<summary>
        /// Mã đơn hàng
        ///</summary>
        public string OrderCode { get; set; } // OrderCode (length: 50)

        ///<summary>
        /// Ghi chú các dịch vụ trong đơn hàng: (Kiểm đếm, Đóng kiện,..)
        ///</summary>
        public string OrderServices { get; set; } // OrderServices (length: 500)

        ///<summary>
        /// Id khách hàng
        ///</summary>
        public int CustomerId { get; set; } // CustomerId

        ///<summary>
        /// Tên khách hàng
        ///</summary>
        public string CustomerName { get; set; } // CustomerName (length: 300)

        ///<summary>
        /// Tài khoản khách hàng
        ///</summary>
        public string CustomerUserName { get; set; } // CustomerUserName (length: 300)

        ///<summary>
        /// Độ Vip của khách hàng
        ///</summary>
        public byte CustomerLevelId { get; set; } // CustomerLevelId

        ///<summary>
        /// Tên độ Vip của khách hàng
        ///</summary>
        public string CustomerLevelName { get; set; } // CustomerLevelName (length: 300)

        ///<summary>
        /// Kho hàng
        ///</summary>
        public int CustomerWarehouseId { get; set; } // CustomerWarehouseId

        ///<summary>
        /// Tên kho hàng
        ///</summary>
        public string CustomerWarehouseAddress { get; set; } // CustomerWarehouseAddress (length: 500)

        ///<summary>
        /// Tên kho hàng
        ///</summary>
        public string CustomerWarehouseName { get; set; } // CustomerWarehouseName (length: 300)
        public string CustomerWarehouseIdPath { get; set; } // CustomerWarehouseIdPath (length: 300)

        ///<summary>
        /// Mã vận đơn của kiện hàng
        ///</summary>
        public string TransportCode { get; set; } // TransportCode (length: 50)

        ///<summary>
        /// Cân nặng kiện hàng
        ///</summary>
        public decimal? Weight { get; set; } // Weight

        ///<summary>
        /// Cân nặng chuyển đổi
        ///</summary>
        public decimal? WeightConverted { get; set; } // WeightConverted
        public decimal? WeightActual { get; set; } // WeightActual

        ///<summary>
        /// % Cân nặng của kiện trong tổng cân nặng của kiện gỗ
        ///</summary>
        public decimal? WeightWapperPercent { get; set; } // WeightWapperPercent

        ///<summary>
        /// Cân nặng bì gỗ khi kiện đóng kiện gỗ
        ///</summary>
        public decimal? WeightWapper { get; set; } // WeightWapper

        ///<summary>
        /// Tiền đóng kiện gỗ của kiện hàng
        ///</summary>
        public decimal? TotalPriceWapper { get; set; } // TotalPriceWapper

        ///<summary>
        /// Thể tích m3 của kiện hàng
        ///</summary>
        public decimal? Volume { get; set; } // Volume

        ///<summary>
        /// Thể tích m3 tính tiền của kiện hàng
        ///</summary>
        public decimal? VolumeActual { get; set; } // VolumeActual

        ///<summary>
        /// % thể tích trong bao m3 của kiện hàng
        ///</summary>
        public decimal? VolumeWapperPercent { get; set; } // VolumeWapperPercent

        ///<summary>
        /// Thể tích chệnh lệch m3 của kiện hàng
        ///</summary>
        public decimal? VolumeWapper { get; set; } // VolumeWapper

        ///<summary>
        /// Chi tiết kích thước kiện hàng: Rộng x Dài x Cao
        ///</summary>
        public string Size { get; set; } // Size (length: 500)

        ///<summary>
        /// Chiều rộng của kiện hàng
        ///</summary>
        public decimal? Width { get; set; } // Width

        ///<summary>
        /// Chiều cao của kiện hàng
        ///</summary>
        public decimal? Height { get; set; } // Height

        ///<summary>
        /// Chiều dài kiện hàng
        ///</summary>
        public decimal? Length { get; set; } // Length

        ///<summary>
        /// Thành tiền
        ///</summary>
        public decimal? TotalPrice { get; set; } // TotalPrice

        ///<summary>
        /// Kho hàng
        ///</summary>
        public int WarehouseId { get; set; } // WarehouseId

        ///<summary>
        /// Tên kho hàng
        ///</summary>
        public string WarehouseName { get; set; } // WarehouseName (length: 300)
        public string WarehouseIdPath { get; set; } // WarehouseIdPath (length: 300)
        public string WarehouseAddress { get; set; } // WarehouseAddress (length: 300)

        ///<summary>
        /// Id nhân viên kho xử lý
        ///</summary>
        public int? UserId { get; set; } // UserId
        public string UserFullName { get; set; } // UserFullName (length: 300)

        ///<summary>
        /// Kiện hàng phát sinh từ hệ thống
        ///</summary>
        public int SystemId { get; set; } // SystemId

        ///<summary>
        /// Tên hệ thống
        ///</summary>
        public string SystemName { get; set; } // SystemName (length: 300)

        ///<summary>
        /// Ngày tạo kiện - Ngày Shop phát hàng
        ///</summary>
        public DateTime Created { get; set; } // Created
        public DateTime LastUpdate { get; set; } // LastUpdate

        ///<summary>
        /// Tag link toàn bộ hệ thống
        ///</summary>
        public string HashTag { get; set; } // HashTag

        ///<summary>
        /// Ngày dự kiến về kho
        ///</summary>
        public DateTime? ForcastDate { get; set; } // ForcastDate

        ///<summary>
        /// Tổng số kiện hàng trong cùng một đơn hàng
        ///</summary>
        public int PackageNo { get; set; } // PackageNo
        public string UnsignedText { get; set; } // UnsignedText (length: 500)

        ///<summary>
        /// Kho hàng
        ///</summary>
        public int? CurrentLayoutId { get; set; } // CurrentLayoutId

        ///<summary>
        /// Tên kho hàng
        ///</summary>
        public string CurrentLayoutName { get; set; } // CurrentLayoutName (length: 300)
        public string CurrentLayoutIdPath { get; set; } // CurrentLayoutIdPath (length: 300)

        ///<summary>
        /// Kho hàng
        ///</summary>
        public int? CurrentWarehouseId { get; set; } // CurrentWarehouseId

        ///<summary>
        /// Tên kho hàng
        ///</summary>
        public string CurrentWarehouseName { get; set; } // CurrentWarehouseName (length: 300)
        public string CurrentWarehouseIdPath { get; set; } // CurrentWarehouseIdPath (length: 300)
        public string CurrentWarehouseAddress { get; set; } // CurrentWarehouseAddress (length: 300)
        public string OrderCodes { get; set; } // OrderCodes (length: 1000)
        public string PackageCodes { get; set; } // PackageCodes (length: 1000)
        public string Customers { get; set; } // Customers (length: 1000)
        public string OrderCodesUnsigned { get; set; } // OrderCodesUnsigned (length: 1000)
        public string PackageCodesUnsigned { get; set; } // PackageCodesUnsigned (length: 1000)
        public string CustomersUnsigned { get; set; } // CustomersUnsigned (length: 1000)

        ///<summary>
        /// Loại packet, 0: đơn order, 1: đơn ký gửi
        ///</summary>
        public byte OrderType { get; set; } // OrderType

        ///<summary>
        /// Danh sách hình ảnh bằng json
        ///</summary>
        public string ImageJson { get; set; } // ImageJson

        public int? WalletId { get; set; } // WalletId
        public string WalletCode { get; set; } // WalletCode (length: 30)
        public decimal? WalletWidth { get; set; } // Width
        public decimal? WalletLength { get; set; } // Length
        public decimal? WalletHeight { get; set; } // Height
        public string WalletSize { get; set; } // Size (length: 500)
                                               
        ///<summary>
        /// Cân nặng của bao hàng
        ///</summary>
        public decimal? WalletWeight { get; set; } // Weight

        ///<summary>
        /// Cân nặng chuyển đổi của bao hàng
        ///</summary>
        public decimal? WalletWeightConverted { get; set; } // WeightConverted

        ///<summary>
        /// Cân nặng thực tế tính tiền của bao hàng
        ///</summary>
        public decimal? WalletWeightActual { get; set; } // WeightActual
                                             
        ///<summary>
        /// Id Nhân viên tạo phiếu nhập bao
        ///</summary>
        public int? WalletUserId { get; set; } // UserId

        ///<summary>
        /// Tên nhân viên thực hiện tạo bao
        ///</summary>
        public string WalletUserName { get; set; } // UserName (length: 50)

        ///<summary>
        /// Mã Code nhân viên thực hiện tạo phiếu
        ///</summary>
        public string WalletUserFullName { get; set; } // UserFullName (length: 300)

        ///<summary>
        /// Ngày bao được tạo
        ///</summary>
        public DateTime? WalletCreated { get; set; } // Created

        public string WalletNote { get; set; } // Note (length: 500)
    }
}
