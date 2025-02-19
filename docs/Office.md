# Org.OpenAPITools.Model.Office
Данные о складе WB

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | Адрес | [optional] 
**Name** | **string** | Название | [optional] 
**City** | **string** | Город | [optional] 
**Id** | **long** | ID | [optional] 
**Longitude** | **decimal** | Долгота | [optional] 
**Latitude** | **decimal** | Широта | [optional] 
**CargoType** | **int** | &lt;dl&gt; &lt;dt&gt;Тип товара, который принимает склад:&lt;/dt&gt; &lt;dd&gt;1 - стандартный&lt;/dd&gt; &lt;dd&gt;2 - СГТ (Сверхгабаритный товар)&lt;/dd&gt; &lt;dd&gt;3 - КГТ+ (Крупногабаритный товар)&lt;/dd&gt; &lt;/dl&gt;  | [optional] 
**DeliveryType** | **int** | &lt;dl&gt; &lt;dt&gt;Тип доставки, который принимает склад:&lt;/dt&gt; &lt;dd&gt;1 - доставка на склад WB&lt;/dd&gt; &lt;dd&gt;2 - доставка силами продавца&lt;/dd&gt; &lt;dd&gt;3 - доставка курьером WB&lt;/dd&gt; &lt;/dl&gt;  | [optional] 
**Selected** | **bool** | Признак того, что склад уже выбран продавцом | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

