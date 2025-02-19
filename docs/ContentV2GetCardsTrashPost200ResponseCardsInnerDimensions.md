# Org.OpenAPITools.Model.ContentV2GetCardsTrashPost200ResponseCardsInnerDimensions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Length** | **int** | Длина, см | [optional] 
**Width** | **int** | Ширина, см | [optional] 
**Height** | **int** | Высота, см | [optional] 
**IsValid** | **bool** | Потенциальная некорректность габаритов товара:    - &#x60;true&#x60; — не выявлена. &#x60;\&quot;isValid\&quot;:true&#x60; не гарантирует, что размеры указаны корректно. В отдельных случаях (например, при создании новой категории товаров) &#x60;\&quot;isValid\&quot;:true&#x60; будет возвращаться при любых значениях, кроме нулевых.  - &#x60;false&#x60; — указанные габариты значительно отличаются от средних по категории (предмету). Рекомендуется перепроверить, правильно ли указаны размеры товара в упаковке **в сантиметрах**. Функциональность карточки товара, в том числе начисление логистики и хранения, при этом ограничена не будет. Логистика и хранение продолжают начисляться — по текущим габаритам. Также &#x60;\&quot;isValid\&quot;:false&#x60; возвращается при отсутствии значений или нулевом значении любой стороны.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

