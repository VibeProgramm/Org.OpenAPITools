# Org.OpenAPITools.Model.SizeGood
Информация о размере

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NmID** | **int** | Артикул WB | [optional] 
**SizeID** | **int** | ID размера. Можно получить с помощью метода [Получение списка товаров по артикулам](./work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1list~1goods~1filter/get), поле &#x60;sizeID&#x60;. В методах контента это поле &#x60;chrtID&#x60; | [optional] 
**VendorCode** | **string** | Артикул продавца | [optional] 
**Price** | **int** | Цена | [optional] 
**CurrencyIsoCode4217** | **string** | Валюта, по стандарту ISO 4217 | [optional] 
**DiscountedPrice** | **decimal** | Цена со скидкой | [optional] 
**ClubDiscountedPrice** | **decimal** | Цена со скидкой, включая скидку WB Клуба | [optional] 
**Discount** | **int** | Скидка, % | [optional] 
**ClubDiscount** | **int** | Скидка WB Клуба, % | [optional] 
**TechSizeName** | **string** | Размер товара | [optional] 
**EditableSizePrice** | **bool** | Можно ли устанавливать цены отдельно для разных размеров: &#x60;true&#x60; — можно, &#x60;false&#x60; — нельзя. Эта возможность зависит от категории товара  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

