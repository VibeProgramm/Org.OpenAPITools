# Org.OpenAPITools.Model.SupplierTaskMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UploadID** | **int** | ID загрузки | [optional] 
**Status** | **int** | Статус загрузки:    * &#x60;3&#x60; — обработана, в товарах нет ошибок, цены и скидки обновились   * &#x60;4&#x60; — отменена   * &#x60;5&#x60; — обработана, но в товарах есть ошибки. Для товаров без ошибок цены и скидки обновились, а ошибки в остальных товарах можно получить с помощью метода [Детализация обработанной загрузки](./work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1history~1goods~1task/get)   * &#x60;6&#x60; — обработана, но во всех товарах есть ошибки. Их тоже можно получить с помощью метода [Детализация обработанной загрузки](./work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1history~1goods~1task/get)  | [optional] 
**UploadDate** | **DateOnly** | Дата и время, когда загрузка создана | [optional] 
**ActivationDate** | **DateOnly** | Дата и время, когда загрузка отправляется в обработку | [optional] 
**OverAllGoodsNumber** | **int** | Всего товаров | [optional] 
**SuccessGoodsNumber** | **int** | Товаров без ошибок | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

