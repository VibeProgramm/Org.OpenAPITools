# Org.OpenAPITools.Model.ContentV2CardsUpdatePostRequestInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NmID** | **int** | Артикул WB | 
**VendorCode** | **string** | Артикул продавца | 
**Brand** | **string** | Бренд | [optional] 
**Title** | **string** | Наименование товара | [optional] 
**Description** | **string** | Описание товара. Максимальное количество символов зависит от категории товара. Стандарт — 2000, минимум — 1000, максимум — 5000.&lt;br&gt; Подробно о правилах описания в **Правилах заполнения карточки товара** в разделе [Инструкции](https://seller.wildberries.ru/help-center/article/A-113#описание) на портале продавцов.  | [optional] 
**Dimensions** | [**ContentV2CardsUpdatePostRequestInnerDimensions**](ContentV2CardsUpdatePostRequestInnerDimensions.md) |  | [optional] 
**Characteristics** | [**List&lt;ContentV2CardsUpdatePostRequestInnerCharacteristicsInner&gt;**](ContentV2CardsUpdatePostRequestInnerCharacteristicsInner.md) | Характеристики товара | [optional] 
**Sizes** | [**List&lt;ContentV2CardsUpdatePostRequestInnerSizesInner&gt;**](ContentV2CardsUpdatePostRequestInnerSizesInner.md) | Массив размеров артикула. &lt;br&gt; Для безразмерного товара все равно нужно передавать данный массив без параметров (wbSize и techSize), но с баркодом.                            | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

