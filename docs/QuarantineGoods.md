# Org.OpenAPITools.Model.QuarantineGoods

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NmID** | **int** | Артикул WB | [optional] 
**SizeID** | **int** | Не используется | [optional] 
**TechSizeName** | **string** | Не используется | [optional] 
**CurrencyIsoCode4217** | **string** | Валюта по стандарту ISO 4217 | [optional] 
**NewPrice** | **float** | Новая цена продавца до скидки | [optional] 
**OldPrice** | **float** | Текущая цена продавца до скидки | [optional] 
**NewDiscount** | **int** | Новая скидка продавца, % | [optional] 
**OldDiscount** | **int** | Текущая скидка продавца, % | [optional] 
**PriceDiff** | **float** | Разница: &#x60;newPrice&#x60; * (1 - &#x60;newDiscount&#x60; / 100) - &#x60;oldPrice&#x60; * (1 - &#x60;oldDiscount&#x60; / 100) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

