# Org.OpenAPITools.Model.ContentV2GetCardsListPost200ResponseCardsInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NmID** | **int** | Артикул WB | [optional] 
**ImtID** | **int** | ID карточки товара. &lt;br&gt; Артикулы WB из одной карточки товара будут иметь одинаковый imtID | [optional] 
**NmUUID** | **Guid** | Внутренний технический ID товара | [optional] 
**SubjectID** | **int** | ID предмета | [optional] 
**VendorCode** | **string** | Артикул продавца | [optional] 
**SubjectName** | **string** | Название предмета | [optional] 
**Brand** | **string** | Бренд | [optional] 
**Title** | **string** | Наименование товара | [optional] 
**Photos** | [**List&lt;ContentV2GetCardsListPost200ResponseCardsInnerPhotosInner&gt;**](ContentV2GetCardsListPost200ResponseCardsInnerPhotosInner.md) | Массив фото | [optional] 
**Video** | **string** | URL видео | [optional] 
**Dimensions** | [**ContentV2GetCardsListPost200ResponseCardsInnerDimensions**](ContentV2GetCardsListPost200ResponseCardsInnerDimensions.md) |  | [optional] 
**Characteristics** | [**List&lt;ContentV2GetCardsListPost200ResponseCardsInnerCharacteristicsInner&gt;**](ContentV2GetCardsListPost200ResponseCardsInnerCharacteristicsInner.md) | Характеристики | [optional] 
**Sizes** | [**List&lt;ContentV2GetCardsListPost200ResponseCardsInnerSizesInner&gt;**](ContentV2GetCardsListPost200ResponseCardsInnerSizesInner.md) | Размеры товара | [optional] 
**Tags** | [**List&lt;ContentV2GetCardsListPost200ResponseCardsInnerTagsInner&gt;**](ContentV2GetCardsListPost200ResponseCardsInnerTagsInner.md) | Ярлыки | [optional] 
**CreatedAt** | **string** | Дата создания | [optional] 
**UpdatedAt** | **string** | Дата изменения | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

