# Org.OpenAPITools.Model.GoodHistory

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NmID** | **int** | Артикул WB | [optional] 
**VendorCode** | **string** | Артикул продавца | [optional] 
**SizeID** | **int** | ID размера. В методах контента это поле &#x60;chrtID&#x60; | [optional] 
**TechSizeName** | **string** | Размер | [optional] 
**Price** | **int** | Цена | [optional] 
**CurrencyIsoCode4217** | **string** | Валюта, по стандарту ISO 4217 | [optional] 
**Discount** | **int** | Скидка, % | [optional] 
**ClubDiscount** | **int** | Скидка WB Клуба, % | [optional] 
**Status** | **int** | Статус товара:    * &#x60;2&#x60; — товар без ошибок, цена и/или скидка обновилась   * &#x60;3&#x60; — есть ошибки, данные не обновились  | [optional] 
**ErrorText** | **string** | Текст ошибки  &lt;div class&#x3D;\&quot;description_important\&quot;&gt;   Ошибка &lt;code&gt;The product is in quarantine&lt;/code&gt; возникает, если новая цена со скидкой хотя бы в 3 раза меньше старой. Вы можете изменить цену или скидку с помощью API либо вывести товар из карантина &lt;a href&#x3D;\&quot;https://seller.wildberries.ru/discount-and-prices/quarantine\&quot;&gt;в личном кабинете&lt;/a&gt; &lt;/div&gt;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

