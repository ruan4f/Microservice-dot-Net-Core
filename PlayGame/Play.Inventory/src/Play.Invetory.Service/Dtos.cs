using System;

namespace Play.Inventory.Service.Dtos
{
    public record GrantItemsDto(Guid UserId, Guid CatalogItemId, int Quantity);

    public record InventoryItemDto(Guid CatalogID, int Quantity, DateTimeOffset AcquiredDate);
}