# Org.OpenAPITools.Model.ContentV2GetCardsListPostRequestSettingsFilter
Параметры фильтрации

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WithPhoto** | **int** | Фильтр по фото:      * &#x60;0&#x60; — только карточки без фото   * &#x60;1&#x60; — только карточки с фото   * &#x60;-1&#x60; — все карточки товара  | [optional] 
**TextSearch** | **string** | Поиск по артикулу продавца, артикулу WB, баркоду | [optional] 
**TagIDs** | **List&lt;int&gt;** | Поиск по ID ярлыков | [optional] 
**AllowedCategoriesOnly** | **bool** | Фильтр по категории. &#x60;true&#x60; - только разрешённые, &#x60;false&#x60; - все. Не используется в песочнице. | [optional] 
**ObjectIDs** | **List&lt;int&gt;** | Поиск по id предметов | [optional] 
**Brands** | **List&lt;string&gt;** | Поиск по брендам | [optional] 
**ImtID** | **int** | Поиск по ID карточки товара | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

