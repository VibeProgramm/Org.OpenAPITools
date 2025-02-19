# Org.OpenAPITools.Model.ContentV2CardsUploadPostRequestInnerVariantsInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Brand** | **string** | Бренд | [optional] 
**Title** | **string** | Наименование товара | [optional] 
**Description** | **string** | Описание товара. Максимальное количество символов зависит от категории товара. Стандарт — 2000, минимум — 1000, максимум — 5000.&lt;br&gt; Подробно о правилах описания в **Правилах заполнения карточки товара** в разделе [Инструкции](https://seller.wildberries.ru/help-center/article/A-113#описание) на портале продавцов.  | [optional] 
**VendorCode** | **string** | Артикул продавца | 
**Dimensions** | [**ContentV2CardsUploadPostRequestInnerVariantsInnerDimensions**](ContentV2CardsUploadPostRequestInnerVariantsInnerDimensions.md) |  | [optional] 
**Sizes** | [**List&lt;ContentV2CardsUploadPostRequestInnerVariantsInnerSizesInner&gt;**](ContentV2CardsUploadPostRequestInnerVariantsInnerSizesInner.md) | Массив с размерами. &lt;br&gt;  Если для размерного товара (обувь, одежда и др.) не указать этот массив, то системой в карточке он будет сгенерирован автоматически с &#x60;techSize&#x60; &#x3D; \&quot;A\&quot; и &#x60;wbSize&#x60; &#x3D; \&quot;1\&quot; и баркодом.  | [optional] 
**Characteristics** | [**List&lt;ContentV2CardsUploadPostRequestInnerVariantsInnerCharacteristicsInner&gt;**](ContentV2CardsUploadPostRequestInnerVariantsInnerCharacteristicsInner.md) | Массив характеристик товара | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

