﻿var walletModel = function () {
    this.Id = ko.observable("");
    this.Code = ko.observable("");
    this.TransportMethod = ko.observable("");
    this.Status = ko.observable("");
    this.TotalValue = ko.observable("");
    this.TotalWeight = ko.observable("");
    this.TotalActualWeight = ko.observable("");
    this.TotalConversionWeight = ko.observable("");
    this.TotalVolume = ko.observable("");
    this.TotalPackage = ko.observable("");
    this.CreatedWarehouseId = ko.observable("");
    this.CreatedWarehouseCode = ko.observable("");
    this.CreatedWarehouseName = ko.observable("");
    this.CurrentWarehouseId = ko.observable("");
    this.CurrentWarehouseCode = ko.observable("");
    this.CurrentWarehouseName = ko.observable("");
    this.UserId = ko.observable("");
    this.UserCode = ko.observable("");
    this.UserName = ko.observable("");
    this.CreatedWarehouseManagerId = ko.observable("");
    this.CreatedWarehouseManagerCode = ko.observable("");
    this.CreatedWarehouseManagerName = ko.observable("");
    this.CreatedWarehouseAccountantId = ko.observable("");
    this.CreatedWarehouseAccountantCode = ko.observable("");
    this.CreatedWarehouseAccountantName = ko.observable("");
    this.CurrentZone = ko.observable("");
    this.Created = ko.observable("");
    this.LastUpdate = ko.observable("");
};