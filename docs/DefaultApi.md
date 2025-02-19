# Org.OpenAPITools.Api.DefaultApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2BufferGoodsTaskGet**](DefaultApi.md#apiv2buffergoodstaskget) | **GET** /api/v2/buffer/goods/task | Детализация необработанной загрузки |
| [**ApiV2BufferTasksGet**](DefaultApi.md#apiv2buffertasksget) | **GET** /api/v2/buffer/tasks | Состояние необработанной загрузки |
| [**ApiV2HistoryGoodsTaskGet**](DefaultApi.md#apiv2historygoodstaskget) | **GET** /api/v2/history/goods/task | Детализация обработанной загрузки |
| [**ApiV2HistoryTasksGet**](DefaultApi.md#apiv2historytasksget) | **GET** /api/v2/history/tasks | Состояние обработанной загрузки |
| [**ApiV2ListGoodsFilterGet**](DefaultApi.md#apiv2listgoodsfilterget) | **GET** /api/v2/list/goods/filter | Получить товары |
| [**ApiV2ListGoodsSizeNmGet**](DefaultApi.md#apiv2listgoodssizenmget) | **GET** /api/v2/list/goods/size/nm | Получить размеры товара |
| [**ApiV2QuarantineGoodsGet**](DefaultApi.md#apiv2quarantinegoodsget) | **GET** /api/v2/quarantine/goods | Получить товары в карантине |
| [**ApiV2UploadTaskClubDiscountPost**](DefaultApi.md#apiv2uploadtaskclubdiscountpost) | **POST** /api/v2/upload/task/club-discount | Установить скидки WB Клуба |
| [**ApiV2UploadTaskPost**](DefaultApi.md#apiv2uploadtaskpost) | **POST** /api/v2/upload/task | Установить цены и скидки |
| [**ApiV2UploadTaskSizePost**](DefaultApi.md#apiv2uploadtasksizepost) | **POST** /api/v2/upload/task/size | Установить цены для размеров |
| [**ApiV3OfficesGet**](DefaultApi.md#apiv3officesget) | **GET** /api/v3/offices | Получить список складов WB |
| [**ApiV3StocksWarehouseIdDelete**](DefaultApi.md#apiv3stockswarehouseiddelete) | **DELETE** /api/v3/stocks/{warehouseId} | Удалить остатки товаров |
| [**ApiV3StocksWarehouseIdPost**](DefaultApi.md#apiv3stockswarehouseidpost) | **POST** /api/v3/stocks/{warehouseId} | Получить остатки товаров |
| [**ApiV3StocksWarehouseIdPut**](DefaultApi.md#apiv3stockswarehouseidput) | **PUT** /api/v3/stocks/{warehouseId} | Обновить остатки товаров |
| [**ApiV3WarehousesGet**](DefaultApi.md#apiv3warehousesget) | **GET** /api/v3/warehouses | Получить список складов продавца |
| [**ApiV3WarehousesPost**](DefaultApi.md#apiv3warehousespost) | **POST** /api/v3/warehouses | Создать склад продавца |
| [**ApiV3WarehousesWarehouseIdDelete**](DefaultApi.md#apiv3warehouseswarehouseiddelete) | **DELETE** /api/v3/warehouses/{warehouseId} | Удалить склад продавца |
| [**ApiV3WarehousesWarehouseIdPut**](DefaultApi.md#apiv3warehouseswarehouseidput) | **PUT** /api/v3/warehouses/{warehouseId} | Обновить склад продавца |
| [**ContentV2BarcodesPost**](DefaultApi.md#contentv2barcodespost) | **POST** /content/v2/barcodes | Генерация баркодов |
| [**ContentV2CardsDeleteTrashPost**](DefaultApi.md#contentv2cardsdeletetrashpost) | **POST** /content/v2/cards/delete/trash | Перенос карточек товаров в корзину |
| [**ContentV2CardsErrorListGet**](DefaultApi.md#contentv2cardserrorlistget) | **GET** /content/v2/cards/error/list | Список несозданных карточек товаров с ошибками |
| [**ContentV2CardsLimitsGet**](DefaultApi.md#contentv2cardslimitsget) | **GET** /content/v2/cards/limits | Лимиты карточек товаров |
| [**ContentV2CardsMoveNmPost**](DefaultApi.md#contentv2cardsmovenmpost) | **POST** /content/v2/cards/moveNm | Объединение и разъединение карточек товаров |
| [**ContentV2CardsRecoverPost**](DefaultApi.md#contentv2cardsrecoverpost) | **POST** /content/v2/cards/recover | Восстановление карточек товаров из корзины |
| [**ContentV2CardsUpdatePost**](DefaultApi.md#contentv2cardsupdatepost) | **POST** /content/v2/cards/update | Редактирование карточек товаров |
| [**ContentV2CardsUploadAddPost**](DefaultApi.md#contentv2cardsuploadaddpost) | **POST** /content/v2/cards/upload/add | Создание карточек товаров с объединением |
| [**ContentV2CardsUploadPost**](DefaultApi.md#contentv2cardsuploadpost) | **POST** /content/v2/cards/upload | Создание карточек товаров |
| [**ContentV2DirectoryColorsGet**](DefaultApi.md#contentv2directorycolorsget) | **GET** /content/v2/directory/colors | Цвет |
| [**ContentV2DirectoryCountriesGet**](DefaultApi.md#contentv2directorycountriesget) | **GET** /content/v2/directory/countries | Страна производства |
| [**ContentV2DirectoryKindsGet**](DefaultApi.md#contentv2directorykindsget) | **GET** /content/v2/directory/kinds | Пол |
| [**ContentV2DirectorySeasonsGet**](DefaultApi.md#contentv2directoryseasonsget) | **GET** /content/v2/directory/seasons | Сезон |
| [**ContentV2DirectoryTnvedGet**](DefaultApi.md#contentv2directorytnvedget) | **GET** /content/v2/directory/tnved | ТНВЭД-код |
| [**ContentV2DirectoryVatGet**](DefaultApi.md#contentv2directoryvatget) | **GET** /content/v2/directory/vat | Ставка НДС |
| [**ContentV2GetCardsListPost**](DefaultApi.md#contentv2getcardslistpost) | **POST** /content/v2/get/cards/list | Список карточек товаров |
| [**ContentV2GetCardsTrashPost**](DefaultApi.md#contentv2getcardstrashpost) | **POST** /content/v2/get/cards/trash | Список карточек товаров в корзине |
| [**ContentV2ObjectAllGet**](DefaultApi.md#contentv2objectallget) | **GET** /content/v2/object/all | Список предметов |
| [**ContentV2ObjectCharcsSubjectIdGet**](DefaultApi.md#contentv2objectcharcssubjectidget) | **GET** /content/v2/object/charcs/{subjectId} | Характеристики предмета |
| [**ContentV2ObjectParentAllGet**](DefaultApi.md#contentv2objectparentallget) | **GET** /content/v2/object/parent/all | Родительские категории товаров |
| [**ContentV2TagIdDelete**](DefaultApi.md#contentv2tagiddelete) | **DELETE** /content/v2/tag/{id} | Удаление ярлыка |
| [**ContentV2TagIdPatch**](DefaultApi.md#contentv2tagidpatch) | **PATCH** /content/v2/tag/{id} | Изменение ярлыка |
| [**ContentV2TagNomenclatureLinkPost**](DefaultApi.md#contentv2tagnomenclaturelinkpost) | **POST** /content/v2/tag/nomenclature/link | Управление ярлыками в карточке товара |
| [**ContentV2TagPost**](DefaultApi.md#contentv2tagpost) | **POST** /content/v2/tag | Создание ярлыка |
| [**ContentV2TagsGet**](DefaultApi.md#contentv2tagsget) | **GET** /content/v2/tags | Список ярлыков |
| [**ContentV3MediaFilePost**](DefaultApi.md#contentv3mediafilepost) | **POST** /content/v3/media/file | Загрузить медиафайл |
| [**ContentV3MediaSavePost**](DefaultApi.md#contentv3mediasavepost) | **POST** /content/v3/media/save | Загрузить медиафайлы по ссылкам |

<a id="apiv2buffergoodstaskget"></a>
# **ApiV2BufferGoodsTaskGet**
> ApiV2BufferGoodsTaskGet200Response ApiV2BufferGoodsTaskGet (int limit, int uploadID, int? offset = null)

Детализация необработанной загрузки

Метод предоставляет информацию о товарах и ошибках в товарах из загрузки в обработке.  <div class=\"description_important\">   Необработанная загрузка — это загрузка скидок для <a href=\"/openapi/promotion#tag/Kalendar-akcij\">календаря акций</a>. Такие скидки применятся к товарам только в момент начала акции. </div>  <div class=\"description_limit\">   Максимум 10 запросов за 6 секунд для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Цены и скидки</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV2BufferGoodsTaskGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var limit = 10;  // int | Сколько элементов вывести на одной странице (пагинация). Максимум 1 000 элементов
            var uploadID = 146567;  // int | ID загрузки
            var offset = 0;  // int? | После какого элемента выдавать данные (optional) 

            try
            {
                // Детализация необработанной загрузки
                ApiV2BufferGoodsTaskGet200Response result = apiInstance.ApiV2BufferGoodsTaskGet(limit, uploadID, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV2BufferGoodsTaskGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2BufferGoodsTaskGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Детализация необработанной загрузки
    ApiResponse<ApiV2BufferGoodsTaskGet200Response> response = apiInstance.ApiV2BufferGoodsTaskGetWithHttpInfo(limit, uploadID, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV2BufferGoodsTaskGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Сколько элементов вывести на одной странице (пагинация). Максимум 1 000 элементов |  |
| **uploadID** | **int** | ID загрузки |  |
| **offset** | **int?** | После какого элемента выдавать данные | [optional]  |

### Return type

[**ApiV2BufferGoodsTaskGet200Response**](ApiV2BufferGoodsTaskGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2buffertasksget"></a>
# **ApiV2BufferTasksGet**
> ApiV2BufferTasksGet200Response ApiV2BufferTasksGet (int uploadID)

Состояние необработанной загрузки

Метод предоставляет информацию про загрузку скидок в обработке.  <div class=\"description_important\">   Необработанная загрузка — это загрузка скидок для <a href=\"/openapi/promotion#tag/Kalendar-akcij\">календаря акций</a>. Такие скидки применятся к товарам только в момент начала акции. </div>  <div class=\"description_limit\">   Максимум 10 запросов за 6 секунд для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Цены и скидки</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV2BufferTasksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var uploadID = 146567;  // int | ID загрузки

            try
            {
                // Состояние необработанной загрузки
                ApiV2BufferTasksGet200Response result = apiInstance.ApiV2BufferTasksGet(uploadID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV2BufferTasksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2BufferTasksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Состояние необработанной загрузки
    ApiResponse<ApiV2BufferTasksGet200Response> response = apiInstance.ApiV2BufferTasksGetWithHttpInfo(uploadID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV2BufferTasksGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uploadID** | **int** | ID загрузки |  |

### Return type

[**ApiV2BufferTasksGet200Response**](ApiV2BufferTasksGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2historygoodstaskget"></a>
# **ApiV2HistoryGoodsTaskGet**
> ApiV2HistoryGoodsTaskGet200Response ApiV2HistoryGoodsTaskGet (int limit, int uploadID, int? offset = null)

Детализация обработанной загрузки

Метод предоставляет информацию о товарах и об ошибках в товарах в обработанной загрузке.  <div class=\"description_important\">   Обработанная загрузка — это загрузка цен и скидок для <a href=\"/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1upload~1task/post\">товаров</a> и <a href=\"/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1upload~1task~1size/post\">размеров товаров</a>, а также скидок <a href=\"/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1upload~1task~1club-discount/post\">WB Клуба</a>. </div>  <div class=\"description_limit\">   Максимум 10 запросов за 6 секунд для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Цены и скидки</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV2HistoryGoodsTaskGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var limit = 10;  // int | Сколько элементов вывести на одной странице (пагинация). Максимум 1 000 элементов
            var uploadID = 146567;  // int | ID загрузки
            var offset = 0;  // int? | После какого элемента выдавать данные (optional) 

            try
            {
                // Детализация обработанной загрузки
                ApiV2HistoryGoodsTaskGet200Response result = apiInstance.ApiV2HistoryGoodsTaskGet(limit, uploadID, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV2HistoryGoodsTaskGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2HistoryGoodsTaskGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Детализация обработанной загрузки
    ApiResponse<ApiV2HistoryGoodsTaskGet200Response> response = apiInstance.ApiV2HistoryGoodsTaskGetWithHttpInfo(limit, uploadID, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV2HistoryGoodsTaskGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Сколько элементов вывести на одной странице (пагинация). Максимум 1 000 элементов |  |
| **uploadID** | **int** | ID загрузки |  |
| **offset** | **int?** | После какого элемента выдавать данные | [optional]  |

### Return type

[**ApiV2HistoryGoodsTaskGet200Response**](ApiV2HistoryGoodsTaskGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2historytasksget"></a>
# **ApiV2HistoryTasksGet**
> ApiV2HistoryTasksGet200Response ApiV2HistoryTasksGet (int uploadID)

Состояние обработанной загрузки

Метод предоставляет информацию об обработанной загрузке цен и скидок.  <div class=\"description_important\">   Обработанная загрузка — это загрузка цен и скидок для <a href=\"/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1upload~1task/post\">товаров</a> и <a href=\"/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1upload~1task~1size/post\">размеров товаров</a>, а также скидок <a href=\"/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1upload~1task~1club-discount/post\">WB Клуба</a>. </div>  <div class=\"description_limit\">   Максимум 10 запросов за 6 секунд для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Цены и скидки</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV2HistoryTasksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var uploadID = 146567;  // int | ID загрузки

            try
            {
                // Состояние обработанной загрузки
                ApiV2HistoryTasksGet200Response result = apiInstance.ApiV2HistoryTasksGet(uploadID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV2HistoryTasksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2HistoryTasksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Состояние обработанной загрузки
    ApiResponse<ApiV2HistoryTasksGet200Response> response = apiInstance.ApiV2HistoryTasksGetWithHttpInfo(uploadID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV2HistoryTasksGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uploadID** | **int** | ID загрузки |  |

### Return type

[**ApiV2HistoryTasksGet200Response**](ApiV2HistoryTasksGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2listgoodsfilterget"></a>
# **ApiV2ListGoodsFilterGet**
> ApiV2ListGoodsFilterGet200Response ApiV2ListGoodsFilterGet (int limit, int? offset = null, int? filterNmID = null)

Получить товары

Метод предоставляет информацию о товаре по его артикулу. <br><br> Чтобы получить информацию обо всех товарах продавца, оставьте артикул пустым. Чтобы получить информацию о размерах товара, используйте [отдельный метод](/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1list~1goods~1size~1nm/get).  <div class=\"description_limit\">   Максимум 10 запросов за 6 секунд для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Цены и скидки</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV2ListGoodsFilterGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var limit = 10;  // int | Сколько элементов вывести на одной странице (пагинация). Максимум 1 000 элементов
            var offset = 0;  // int? | После какого элемента выдавать данные (optional) 
            var filterNmID = 44589768676;  // int? | Артикул WB, по которому искать товар (optional) 

            try
            {
                // Получить товары
                ApiV2ListGoodsFilterGet200Response result = apiInstance.ApiV2ListGoodsFilterGet(limit, offset, filterNmID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV2ListGoodsFilterGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ListGoodsFilterGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получить товары
    ApiResponse<ApiV2ListGoodsFilterGet200Response> response = apiInstance.ApiV2ListGoodsFilterGetWithHttpInfo(limit, offset, filterNmID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV2ListGoodsFilterGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Сколько элементов вывести на одной странице (пагинация). Максимум 1 000 элементов |  |
| **offset** | **int?** | После какого элемента выдавать данные | [optional]  |
| **filterNmID** | **int?** | Артикул WB, по которому искать товар | [optional]  |

### Return type

[**ApiV2ListGoodsFilterGet200Response**](ApiV2ListGoodsFilterGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2listgoodssizenmget"></a>
# **ApiV2ListGoodsSizeNmGet**
> ApiV2ListGoodsSizeNmGet200Response ApiV2ListGoodsSizeNmGet (int limit, int nmID, int? offset = null)

Получить размеры товара

Метод предоставляет информацию обо всех размерах одного товара. <br><br> Работает только для товаров из категорий, где можно устанавливать цены отдельно для разных размеров. Для таких товаров `editableSizePrice: true`.  <br><br> Чтобы получить информацию о самом товаре, используйте [отдельный метод](/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1list~1goods~1filter/get).  <div class=\"description_limit\">   Максимум 10 запросов за 6 секунд для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Цены и скидки</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV2ListGoodsSizeNmGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var limit = 10;  // int | Сколько элементов вывести на одной странице (пагинация). Максимум 1 000 элементов
            var nmID = 1;  // int | Артикул WB
            var offset = 0;  // int? | После какого элемента выдавать данные (optional) 

            try
            {
                // Получить размеры товара
                ApiV2ListGoodsSizeNmGet200Response result = apiInstance.ApiV2ListGoodsSizeNmGet(limit, nmID, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV2ListGoodsSizeNmGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ListGoodsSizeNmGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получить размеры товара
    ApiResponse<ApiV2ListGoodsSizeNmGet200Response> response = apiInstance.ApiV2ListGoodsSizeNmGetWithHttpInfo(limit, nmID, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV2ListGoodsSizeNmGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Сколько элементов вывести на одной странице (пагинация). Максимум 1 000 элементов |  |
| **nmID** | **int** | Артикул WB |  |
| **offset** | **int?** | После какого элемента выдавать данные | [optional]  |

### Return type

[**ApiV2ListGoodsSizeNmGet200Response**](ApiV2ListGoodsSizeNmGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2quarantinegoodsget"></a>
# **ApiV2QuarantineGoodsGet**
> ApiV2QuarantineGoodsGet200Response ApiV2QuarantineGoodsGet (int limit, int? offset = null)

Получить товары в карантине

Метод предоставляет информацию о товарах в карантине. <br><br> Если новая цена товара со скидкой будет минимум в 3 раза меньше старой, товар попадёт [в карантин](https://seller.wildberries.ru/discount-and-prices/quarantine) и будет продаваться по старой цене. Ошибка об этом будет в ответах методов [состояний загрузок](/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1history~1tasks/get). <br><br> Вы можете изменить цену или скидку с помощью API либо вывести товар из карантина [в личном кабинете](https://seller.wildberries.ru/discount-and-prices/quarantine). <br><br> Для товаров с [поразмерной установкой цен](/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1upload~1task~1size/post) карантин не применяется.  <div class=\"description_limit\">   Максимум 10 запросов за 6 секунд для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Цены и скидки</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV2QuarantineGoodsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var limit = 10;  // int | Сколько элементов вывести на одной странице (пагинация). Максимум 1 000 элементов
            var offset = 0;  // int? | После какого элемента выдавать данные (optional) 

            try
            {
                // Получить товары в карантине
                ApiV2QuarantineGoodsGet200Response result = apiInstance.ApiV2QuarantineGoodsGet(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV2QuarantineGoodsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2QuarantineGoodsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получить товары в карантине
    ApiResponse<ApiV2QuarantineGoodsGet200Response> response = apiInstance.ApiV2QuarantineGoodsGetWithHttpInfo(limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV2QuarantineGoodsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Сколько элементов вывести на одной странице (пагинация). Максимум 1 000 элементов |  |
| **offset** | **int?** | После какого элемента выдавать данные | [optional]  |

### Return type

[**ApiV2QuarantineGoodsGet200Response**](ApiV2QuarantineGoodsGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **422** | Неожидаемый результат |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2uploadtaskclubdiscountpost"></a>
# **ApiV2UploadTaskClubDiscountPost**
> TaskCreated ApiV2UploadTaskClubDiscountPost (ApiV2UploadTaskClubDiscountPostRequest apiV2UploadTaskClubDiscountPostRequest)

Установить скидки WB Клуба

Устанавливает скидки для товаров в рамках подписки [WB Клуб](https://seller.wildberries.ru/help-center/article/A-337).  <div class=\"description_limit\">   Получить информацию о процессе установки цен и скидок можно с помощью методов <a href=\"/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1history~1tasks/get\">состояния</a> и <a href=\"/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1history~1goods~1task/get\">детализации</a> обработанной загрузки. </div>  <div class=\"description_limit\">   Максимум 10 запросов за 6 секунд для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Цены и скидки</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV2UploadTaskClubDiscountPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var apiV2UploadTaskClubDiscountPostRequest = new ApiV2UploadTaskClubDiscountPostRequest(); // ApiV2UploadTaskClubDiscountPostRequest | 

            try
            {
                // Установить скидки WB Клуба
                TaskCreated result = apiInstance.ApiV2UploadTaskClubDiscountPost(apiV2UploadTaskClubDiscountPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV2UploadTaskClubDiscountPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2UploadTaskClubDiscountPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Установить скидки WB Клуба
    ApiResponse<TaskCreated> response = apiInstance.ApiV2UploadTaskClubDiscountPostWithHttpInfo(apiV2UploadTaskClubDiscountPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV2UploadTaskClubDiscountPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiV2UploadTaskClubDiscountPostRequest** | [**ApiV2UploadTaskClubDiscountPostRequest**](ApiV2UploadTaskClubDiscountPostRequest.md) |  |  |

### Return type

[**TaskCreated**](TaskCreated.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **208** | Такая загрузка уже есть |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **422** | Неожидаемый результат |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2uploadtaskpost"></a>
# **ApiV2UploadTaskPost**
> TaskCreated ApiV2UploadTaskPost (ApiV2UploadTaskPostRequest apiV2UploadTaskPostRequest)

Установить цены и скидки

Метод устанавливает цены и скидки для товаров.  <br><br> Чтобы установить цены и скидки для размеров товара, используйте [отдельный метод](/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1upload~1task~1size/post).  <div class=\"description_limit\">   Получить информацию о процессе установки цен и скидок можно с помощью методов <a href=\"/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1history~1tasks/get\">состояния</a> и <a href=\"/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1history~1goods~1task/get\">детализации</a> обработанной загрузки. </div>  <div class=\"description_limit\">   Максимум 10 запросов за 6 секунд для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Цены и скидки</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV2UploadTaskPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var apiV2UploadTaskPostRequest = new ApiV2UploadTaskPostRequest(); // ApiV2UploadTaskPostRequest | 

            try
            {
                // Установить цены и скидки
                TaskCreated result = apiInstance.ApiV2UploadTaskPost(apiV2UploadTaskPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV2UploadTaskPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2UploadTaskPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Установить цены и скидки
    ApiResponse<TaskCreated> response = apiInstance.ApiV2UploadTaskPostWithHttpInfo(apiV2UploadTaskPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV2UploadTaskPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiV2UploadTaskPostRequest** | [**ApiV2UploadTaskPostRequest**](ApiV2UploadTaskPostRequest.md) |  |  |

### Return type

[**TaskCreated**](TaskCreated.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **208** | Такая загрузка уже есть |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **422** | Неожидаемый результат |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2uploadtasksizepost"></a>
# **ApiV2UploadTaskSizePost**
> TaskCreated ApiV2UploadTaskSizePost (ApiV2UploadTaskSizePostRequest apiV2UploadTaskSizePostRequest)

Установить цены для размеров

Метод устанавливает цены отдельно для размеров товаров.  Работает только для товаров из категорий, где можно устанавливать цены отдельно для разных размеров. Для [таких товаров](/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1list~1goods~1size~1nm/get) `editableSizePrice: true`.  Чтобы установить цены и скидки для самих товаров, используйте [отдельный метод](/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1upload~1task/post).  <div class=\"description_limit\">   Получить информацию о процессе установки цен и скидок можно с помощью методов <a href=\"/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1history~1tasks/get\">состояния</a> и <a href=\"/openapi/work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1history~1goods~1task/get\">детализации</a> обработанной загрузки. </div>  <div class=\"description_limit\">   Максимум 10 запросов за 6 секунд для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Цены и скидки</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV2UploadTaskSizePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var apiV2UploadTaskSizePostRequest = new ApiV2UploadTaskSizePostRequest(); // ApiV2UploadTaskSizePostRequest | 

            try
            {
                // Установить цены для размеров
                TaskCreated result = apiInstance.ApiV2UploadTaskSizePost(apiV2UploadTaskSizePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV2UploadTaskSizePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2UploadTaskSizePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Установить цены для размеров
    ApiResponse<TaskCreated> response = apiInstance.ApiV2UploadTaskSizePostWithHttpInfo(apiV2UploadTaskSizePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV2UploadTaskSizePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiV2UploadTaskSizePostRequest** | [**ApiV2UploadTaskSizePostRequest**](ApiV2UploadTaskSizePostRequest.md) |  |  |

### Return type

[**TaskCreated**](TaskCreated.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **208** | Такая загрузка уже есть |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **422** | Неожидаемый результат |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv3officesget"></a>
# **ApiV3OfficesGet**
> List&lt;Office&gt; ApiV3OfficesGet ()

Получить список складов WB

Метод предоставляет список всех складов WB для привязки к складам продавца. Предназначен для определения складов WB, чтобы сдавать готовые заказы по схеме [FBS](/openapi/orders-fbs#tag/Zakazy-FBS) (Fulfillment by Seller).  <div class=\"description_limit\">     Максимум 300 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Маркетплейс</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV3OfficesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);

            try
            {
                // Получить список складов WB
                List<Office> result = apiInstance.ApiV3OfficesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV3OfficesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV3OfficesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получить список складов WB
    ApiResponse<List<Office>> response = apiInstance.ApiV3OfficesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV3OfficesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Office&gt;**](Office.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv3stockswarehouseiddelete"></a>
# **ApiV3StocksWarehouseIdDelete**
> void ApiV3StocksWarehouseIdDelete (long warehouseId, ApiV3StocksWarehouseIdDeleteRequest apiV3StocksWarehouseIdDeleteRequest)

Удалить остатки товаров

Метод удаляет запись об остатках товаров продавца из [списка остатков](/openapi/work-with-products#tag/Ostatki-na-skladah-prodavca/paths/~1api~1v3~1stocks~1%7BwarehouseId%7D/post).  <div class=\"description_important\">   <strong>Действие необратимо</strong>. Удаленный остаток будет необходимо загрузить повторно для возобновления продаж. </div>  <div class=\"description_limit\">     Максимум 300 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Маркетплейс</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV3StocksWarehouseIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var warehouseId = 1;  // long | ID склада продавца
            var apiV3StocksWarehouseIdDeleteRequest = new ApiV3StocksWarehouseIdDeleteRequest(); // ApiV3StocksWarehouseIdDeleteRequest | 

            try
            {
                // Удалить остатки товаров
                apiInstance.ApiV3StocksWarehouseIdDelete(warehouseId, apiV3StocksWarehouseIdDeleteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV3StocksWarehouseIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV3StocksWarehouseIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Удалить остатки товаров
    apiInstance.ApiV3StocksWarehouseIdDeleteWithHttpInfo(warehouseId, apiV3StocksWarehouseIdDeleteRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV3StocksWarehouseIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **long** | ID склада продавца |  |
| **apiV3StocksWarehouseIdDeleteRequest** | [**ApiV3StocksWarehouseIdDeleteRequest**](ApiV3StocksWarehouseIdDeleteRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Удалено |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **404** | Не найдено |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv3stockswarehouseidpost"></a>
# **ApiV3StocksWarehouseIdPost**
> ApiV3StocksWarehouseIdPost200Response ApiV3StocksWarehouseIdPost (long warehouseId, ApiV3StocksWarehouseIdPostRequest apiV3StocksWarehouseIdPostRequest)

Получить остатки товаров

Метод предоставляет данные об остатках товаров на [складах продавца](/openapi/work-with-products#tag/Sklady-prodavca).  <div class=\"description_limit\">     Максимум 300 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Маркетплейс</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV3StocksWarehouseIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var warehouseId = 1;  // long | ID склада продавца
            var apiV3StocksWarehouseIdPostRequest = new ApiV3StocksWarehouseIdPostRequest(); // ApiV3StocksWarehouseIdPostRequest | 

            try
            {
                // Получить остатки товаров
                ApiV3StocksWarehouseIdPost200Response result = apiInstance.ApiV3StocksWarehouseIdPost(warehouseId, apiV3StocksWarehouseIdPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV3StocksWarehouseIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV3StocksWarehouseIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получить остатки товаров
    ApiResponse<ApiV3StocksWarehouseIdPost200Response> response = apiInstance.ApiV3StocksWarehouseIdPostWithHttpInfo(warehouseId, apiV3StocksWarehouseIdPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV3StocksWarehouseIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **long** | ID склада продавца |  |
| **apiV3StocksWarehouseIdPostRequest** | [**ApiV3StocksWarehouseIdPostRequest**](ApiV3StocksWarehouseIdPostRequest.md) |  |  |

### Return type

[**ApiV3StocksWarehouseIdPost200Response**](ApiV3StocksWarehouseIdPost200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **404** | Не найдено |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv3stockswarehouseidput"></a>
# **ApiV3StocksWarehouseIdPut**
> void ApiV3StocksWarehouseIdPut (long warehouseId, ApiV3StocksWarehouseIdPutRequest? apiV3StocksWarehouseIdPutRequest = null)

Обновить остатки товаров

Метод обновляет количество остатков товаров продавца [в списке](/openapi/work-with-products#tag/Ostatki-na-skladah-prodavca/paths/~1api~1v3~1stocks~1%7BwarehouseId%7D/post).  <div class=\"description_important\">   Названия параметров запроса не валидируются. При отправке некорректных названий вы получите успешный ответ (<code>204</code>), но остатки не обновятся. </div>  <div class=\"description_limit\">     Максимум 300 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Маркетплейс</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV3StocksWarehouseIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var warehouseId = 1;  // long | ID склада продавца
            var apiV3StocksWarehouseIdPutRequest = new ApiV3StocksWarehouseIdPutRequest?(); // ApiV3StocksWarehouseIdPutRequest? |  (optional) 

            try
            {
                // Обновить остатки товаров
                apiInstance.ApiV3StocksWarehouseIdPut(warehouseId, apiV3StocksWarehouseIdPutRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV3StocksWarehouseIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV3StocksWarehouseIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Обновить остатки товаров
    apiInstance.ApiV3StocksWarehouseIdPutWithHttpInfo(warehouseId, apiV3StocksWarehouseIdPutRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV3StocksWarehouseIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **long** | ID склада продавца |  |
| **apiV3StocksWarehouseIdPutRequest** | [**ApiV3StocksWarehouseIdPutRequest?**](ApiV3StocksWarehouseIdPutRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Обновлено |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **404** | Не найдено |  -  |
| **406** | Обновление остатков заблокировано |  -  |
| **409** | Ошибка обновления остатков |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv3warehousesget"></a>
# **ApiV3WarehousesGet**
> List&lt;Warehouse&gt; ApiV3WarehousesGet ()

Получить список складов продавца

Метод предоставляет список всех складов продавца. Может использоваться для получения [остатков товаров](/openapi/work-with-products#tag/Ostatki-na-skladah-prodavca/paths/~1api~1v3~1stocks~1%7BwarehouseId%7D/post).  <div class=\"description_limit\">     Максимум 300 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Маркетплейс</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV3WarehousesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);

            try
            {
                // Получить список складов продавца
                List<Warehouse> result = apiInstance.ApiV3WarehousesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV3WarehousesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV3WarehousesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получить список складов продавца
    ApiResponse<List<Warehouse>> response = apiInstance.ApiV3WarehousesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV3WarehousesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Warehouse&gt;**](Warehouse.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv3warehousespost"></a>
# **ApiV3WarehousesPost**
> ApiV3WarehousesPost201Response ApiV3WarehousesPost (ApiV3WarehousesPostRequest apiV3WarehousesPostRequest)

Создать склад продавца

Метод создаёт склад продавца для работы с [остатками товаров](/openapi/work-with-products#tag/Ostatki-na-skladah-prodavca/paths/~1api~1v3~1stocks~1%7BwarehouseId%7D/post). Нужно привязать к складу продавца [склад WB](/openapi/work-with-products#tag/Sklady-prodavca/paths/~1api~1v3~1offices/get) для работы по схеме [FBS](/openapi/orders-fbs#tag/Zakazy-FBS) (Fulfillment by Seller).  <div class=\"description_important\">     Нельзя привязывать склад WB, который уже используется </div>  <div class=\"description_limit\">     Максимум 300 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Маркетплейс</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV3WarehousesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var apiV3WarehousesPostRequest = new ApiV3WarehousesPostRequest(); // ApiV3WarehousesPostRequest | 

            try
            {
                // Создать склад продавца
                ApiV3WarehousesPost201Response result = apiInstance.ApiV3WarehousesPost(apiV3WarehousesPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV3WarehousesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV3WarehousesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Создать склад продавца
    ApiResponse<ApiV3WarehousesPost201Response> response = apiInstance.ApiV3WarehousesPostWithHttpInfo(apiV3WarehousesPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV3WarehousesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiV3WarehousesPostRequest** | [**ApiV3WarehousesPostRequest**](ApiV3WarehousesPostRequest.md) |  |  |

### Return type

[**ApiV3WarehousesPost201Response**](ApiV3WarehousesPost201Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Создано |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **404** | Не найдено |  -  |
| **409** | Ошибка создания нового склада |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv3warehouseswarehouseiddelete"></a>
# **ApiV3WarehousesWarehouseIdDelete**
> void ApiV3WarehousesWarehouseIdDelete (long warehouseId)

Удалить склад продавца

Метод удаляет склад продавца из [списка складов](/openapi/work-with-products#tag/Sklady-prodavca/paths/~1api~1v3~1warehouses/get).  <div class=\"description_limit\">     Максимум 300 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Маркетплейс</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV3WarehousesWarehouseIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var warehouseId = 1;  // long | ID склада продавца

            try
            {
                // Удалить склад продавца
                apiInstance.ApiV3WarehousesWarehouseIdDelete(warehouseId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV3WarehousesWarehouseIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV3WarehousesWarehouseIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Удалить склад продавца
    apiInstance.ApiV3WarehousesWarehouseIdDeleteWithHttpInfo(warehouseId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV3WarehousesWarehouseIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **long** | ID склада продавца |  |

### Return type

void (empty response body)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Удалено |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **404** | Не найдено |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv3warehouseswarehouseidput"></a>
# **ApiV3WarehousesWarehouseIdPut**
> void ApiV3WarehousesWarehouseIdPut (long warehouseId, ApiV3WarehousesPostRequest apiV3WarehousesPostRequest)

Обновить склад продавца

Метод обновляет данные склада продавца в [списке складов](/openapi/work-with-products#tag/Sklady-prodavca/paths/~1api~1v3~1warehouses/get). Данные о привязанном [складе WB](/openapi/work-with-products#tag/Sklady-prodavca/paths/~1api~1v3~1offices/get) можно изменить один раз в сутки.  <div class=\"description_important\">     Нельзя привязывать склад WB, который уже используется </div>  <div class=\"description_limit\">     Максимум 300 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Маркетплейс</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiV3WarehousesWarehouseIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var warehouseId = 1;  // long | ID склада продавца
            var apiV3WarehousesPostRequest = new ApiV3WarehousesPostRequest(); // ApiV3WarehousesPostRequest | 

            try
            {
                // Обновить склад продавца
                apiInstance.ApiV3WarehousesWarehouseIdPut(warehouseId, apiV3WarehousesPostRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiV3WarehousesWarehouseIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV3WarehousesWarehouseIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Обновить склад продавца
    apiInstance.ApiV3WarehousesWarehouseIdPutWithHttpInfo(warehouseId, apiV3WarehousesPostRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApiV3WarehousesWarehouseIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warehouseId** | **long** | ID склада продавца |  |
| **apiV3WarehousesPostRequest** | [**ApiV3WarehousesPostRequest**](ApiV3WarehousesPostRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Обновлено |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **404** | Не найдено |  -  |
| **409** | Ошибка обновления склада |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2barcodespost"></a>
# **ContentV2BarcodesPost**
> ContentV2BarcodesPost200Response ContentV2BarcodesPost (ContentV2BarcodesPostRequest contentV2BarcodesPostRequest)

Генерация баркодов

Метод генерирует массив уникальных баркодов для создания размера в [карточке товара](/openapi/work-with-products#tag/Sozdanie-kartochek-tovarov/paths/~1content~1v2~1cards~1upload/post). Можно использовать, если у вас нет собственных баркодов.  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2BarcodesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contentV2BarcodesPostRequest = new ContentV2BarcodesPostRequest(); // ContentV2BarcodesPostRequest | 

            try
            {
                // Генерация баркодов
                ContentV2BarcodesPost200Response result = apiInstance.ContentV2BarcodesPost(contentV2BarcodesPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2BarcodesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2BarcodesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Генерация баркодов
    ApiResponse<ContentV2BarcodesPost200Response> response = apiInstance.ContentV2BarcodesPostWithHttpInfo(contentV2BarcodesPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2BarcodesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentV2BarcodesPostRequest** | [**ContentV2BarcodesPostRequest**](ContentV2BarcodesPostRequest.md) |  |  |

### Return type

[**ContentV2BarcodesPost200Response**](ContentV2BarcodesPost200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2cardsdeletetrashpost"></a>
# **ContentV2CardsDeleteTrashPost**
> ContentV2CardsDeleteTrashPost200Response ContentV2CardsDeleteTrashPost (ContentV2CardsDeleteTrashPostRequest contentV2CardsDeleteTrashPostRequest)

Перенос карточек товаров в корзину

Метод переносит [карточки товаров в корзину](/openapi/work-with-products#tag/Kartochki-tovarov/paths/~1content~1v2~1get~1cards~1trash/post). При этом карточки товаров не удаляются, их можно [восстановить](/openapi/work-with-products#tag/Kartochki-tovarov/paths/~1content~1v2~1cards~1recover/post).  <div class=\"description_important\">   После переноса в корзину карточке товара присваивается новый <code>imtID</code>. </div>  Карточки товаров удаляются автоматически, если лежат в корзине больше 30 дней. Очистка корзины происходит каждую ночь по московскому времени.<br> Карточки товаров можно удалить в любое время в [личном кабинете](https://seller.wildberries.ru/new-goods/basket-cards).  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2CardsDeleteTrashPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contentV2CardsDeleteTrashPostRequest = new ContentV2CardsDeleteTrashPostRequest(); // ContentV2CardsDeleteTrashPostRequest | 

            try
            {
                // Перенос карточек товаров в корзину
                ContentV2CardsDeleteTrashPost200Response result = apiInstance.ContentV2CardsDeleteTrashPost(contentV2CardsDeleteTrashPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2CardsDeleteTrashPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2CardsDeleteTrashPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Перенос карточек товаров в корзину
    ApiResponse<ContentV2CardsDeleteTrashPost200Response> response = apiInstance.ContentV2CardsDeleteTrashPostWithHttpInfo(contentV2CardsDeleteTrashPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2CardsDeleteTrashPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentV2CardsDeleteTrashPostRequest** | [**ContentV2CardsDeleteTrashPostRequest**](ContentV2CardsDeleteTrashPostRequest.md) |  |  |

### Return type

[**ContentV2CardsDeleteTrashPost200Response**](ContentV2CardsDeleteTrashPost200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2cardserrorlistget"></a>
# **ContentV2CardsErrorListGet**
> ContentV2CardsErrorListGet200Response ContentV2CardsErrorListGet (string? locale = null)

Список несозданных карточек товаров с ошибками

Метод предоставляет список карточек товаров, при создании или редактировании которых произошли ошибки, с описанием этих ошибок.  <div class=\"description_important\">   Чтобы убрать карточку товара из списка, нужно повторно сделать запрос на <a href=\"/openapi/work-with-products#tag/Sozdanie-kartochek-tovarov/paths/~1content~1v2~1cards~1upload/post\">создание</a> или редактирование карточки товара с исправленными ошибками. </div>  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2CardsErrorListGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var locale = en;  // string? | Параметр выбора языка значений полей ответа (для которых предусмотрена мультиязычность).  Не используется в песочнице.  (optional) 

            try
            {
                // Список несозданных карточек товаров с ошибками
                ContentV2CardsErrorListGet200Response result = apiInstance.ContentV2CardsErrorListGet(locale);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2CardsErrorListGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2CardsErrorListGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список несозданных карточек товаров с ошибками
    ApiResponse<ContentV2CardsErrorListGet200Response> response = apiInstance.ContentV2CardsErrorListGetWithHttpInfo(locale);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2CardsErrorListGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locale** | **string?** | Параметр выбора языка значений полей ответа (для которых предусмотрена мультиязычность).  Не используется в песочнице.  | [optional]  |

### Return type

[**ContentV2CardsErrorListGet200Response**](ContentV2CardsErrorListGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2cardslimitsget"></a>
# **ContentV2CardsLimitsGet**
> ContentV2CardsLimitsGet200Response ContentV2CardsLimitsGet ()

Лимиты карточек товаров

Возвращает бесплатные и платные лимиты продавца на [создание карточек товаров](/openapi/work-with-products#tag/Sozdanie-kartochek-tovarov/paths/~1content~1v2~1cards~1upload/post).<br><br>  Формула для получения количества карточек, которые можно создать:    > (`freeLimits` + `paidLimits`) - количество созданных карточек  Созданными считаются карточки, которые можно получить через методы [список карточек товаров](/openapi/work-with-products#tag/Kartochki-tovarov/paths/~1content~1v2~1get~1cards~1list/post) и [список карточек товаров в корзине](/openapi/work-with-products#tag/Kartochki-tovarov/paths/~1content~1v2~1get~1cards~1trash/post).  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2CardsLimitsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);

            try
            {
                // Лимиты карточек товаров
                ContentV2CardsLimitsGet200Response result = apiInstance.ContentV2CardsLimitsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2CardsLimitsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2CardsLimitsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Лимиты карточек товаров
    ApiResponse<ContentV2CardsLimitsGet200Response> response = apiInstance.ContentV2CardsLimitsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2CardsLimitsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ContentV2CardsLimitsGet200Response**](ContentV2CardsLimitsGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2cardsmovenmpost"></a>
# **ContentV2CardsMoveNmPost**
> ResponseCardCreate ContentV2CardsMoveNmPost (ContentV2CardsMoveNmPostRequest? contentV2CardsMoveNmPostRequest = null)

Объединение и разъединение карточек товаров

Метод объединяет и разъединяет карточки товаров. Карточки товаров считаются объединёнными, если у них одинаковый <code>imtID</code>. <br><br> Для объединения карточек товаров сделайте запрос **с указанием** `imtID`. Можно объединять не более 30 карточек товаров.<br> Для разъединения карточек товаров сделайте запрос **без указания** `imtID`. Для разъединенных карточек будут сгенерированы новые `imtID`. <br><br> Если вы разъедините одновременно несколько карточек товаров, эти карточки объединятся в одну и получат новый `imtID`.<br> Чтобы присвоить каждой карточке товара уникальный `imtID`, необходимо передавать по одной карточке товара за запрос.<br> <br> Максимальный размер запроса 10 Мб.  <div class=\"description_important\">   Объединить можно только карточки товаров с одинаковыми предметами. </div>  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2CardsMoveNmPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contentV2CardsMoveNmPostRequest = new ContentV2CardsMoveNmPostRequest?(); // ContentV2CardsMoveNmPostRequest? |  (optional) 

            try
            {
                // Объединение и разъединение карточек товаров
                ResponseCardCreate result = apiInstance.ContentV2CardsMoveNmPost(contentV2CardsMoveNmPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2CardsMoveNmPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2CardsMoveNmPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Объединение и разъединение карточек товаров
    ApiResponse<ResponseCardCreate> response = apiInstance.ContentV2CardsMoveNmPostWithHttpInfo(contentV2CardsMoveNmPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2CardsMoveNmPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentV2CardsMoveNmPostRequest** | [**ContentV2CardsMoveNmPostRequest?**](ContentV2CardsMoveNmPostRequest?.md) |  | [optional]  |

### Return type

[**ResponseCardCreate**](ResponseCardCreate.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **413** | Превышен лимит объёма данных в запросе |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2cardsrecoverpost"></a>
# **ContentV2CardsRecoverPost**
> ContentV2CardsDeleteTrashPost200Response ContentV2CardsRecoverPost (ContentV2CardsDeleteTrashPostRequest contentV2CardsDeleteTrashPostRequest)

Восстановление карточек товаров из корзины

Метод восстанавливает [карточки товаров из корзины](/openapi/work-with-products#tag/Kartochki-tovarov/paths/~1content~1v2~1get~1cards~1trash/post).  <div class=\"description_important\">   Карточка товара сохраняет тот же <code>imtID</code>, что был присвоен ей при <a href=\"/openapi/work-with-products#tag/Kartochki-tovarov/paths/~1content~1v2~1cards~1delete~1trash/post\">перемещении в корзину</a>. </div>  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2CardsRecoverPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contentV2CardsDeleteTrashPostRequest = new ContentV2CardsDeleteTrashPostRequest(); // ContentV2CardsDeleteTrashPostRequest | 

            try
            {
                // Восстановление карточек товаров из корзины
                ContentV2CardsDeleteTrashPost200Response result = apiInstance.ContentV2CardsRecoverPost(contentV2CardsDeleteTrashPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2CardsRecoverPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2CardsRecoverPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Восстановление карточек товаров из корзины
    ApiResponse<ContentV2CardsDeleteTrashPost200Response> response = apiInstance.ContentV2CardsRecoverPostWithHttpInfo(contentV2CardsDeleteTrashPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2CardsRecoverPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentV2CardsDeleteTrashPostRequest** | [**ContentV2CardsDeleteTrashPostRequest**](ContentV2CardsDeleteTrashPostRequest.md) |  |  |

### Return type

[**ContentV2CardsDeleteTrashPost200Response**](ContentV2CardsDeleteTrashPost200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2cardsupdatepost"></a>
# **ContentV2CardsUpdatePost**
> ResponseCardCreate ContentV2CardsUpdatePost (List<ContentV2CardsUpdatePostRequestInner>? contentV2CardsUpdatePostRequestInner = null)

Редактирование карточек товаров

Метод обновляет карточки товаров. Данные для обновления можно получить через [список карточек товаров](/openapi/work-with-products#tag/Kartochki-tovarov/paths/~1content~1v2~1get~1cards~1list/post) и [список карточек товаров в корзине](/openapi/work-with-products#tag/Kartochki-tovarov/paths/~1content~1v2~1get~1cards~1trash/post).  <div class=\"description_important\">   Карточка товара перезаписывается при обновлении. Поэтому в запросе нужно передать <strong>все</strong> параметры карточки, в том числе те, которые вы не собираетесь обновлять. </div>  Нельзя редактировать или удалять баркоды, но можно добавить дополнительный баркод к карточке товара. Параметры `photos`, `video` и `tags` редактировать или удалять через данный метод нельзя.<br> Габариты товаров можно указать только в **сантиметрах**. <br><br> В одном запросе можно отредактировать максимум 3000 карточек товаров (`nmID`). Максимальный размер запроса 10 Мб.<br> Если ответ `Успешно` (`200`), но какие-то карточки не обновились, получите [список несозданных карточек товаров](/openapi/work-with-products#tag/Kartochki-tovarov/paths/~1content~1v2~1cards~1error~1list/get).  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2CardsUpdatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contentV2CardsUpdatePostRequestInner = new List<ContentV2CardsUpdatePostRequestInner>?(); // List<ContentV2CardsUpdatePostRequestInner>? |  (optional) 

            try
            {
                // Редактирование карточек товаров
                ResponseCardCreate result = apiInstance.ContentV2CardsUpdatePost(contentV2CardsUpdatePostRequestInner);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2CardsUpdatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2CardsUpdatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Редактирование карточек товаров
    ApiResponse<ResponseCardCreate> response = apiInstance.ContentV2CardsUpdatePostWithHttpInfo(contentV2CardsUpdatePostRequestInner);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2CardsUpdatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentV2CardsUpdatePostRequestInner** | [**List&lt;ContentV2CardsUpdatePostRequestInner&gt;?**](ContentV2CardsUpdatePostRequestInner.md) |  | [optional]  |

### Return type

[**ResponseCardCreate**](ResponseCardCreate.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **413** | Превышен лимит объёма данных в запросе |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2cardsuploadaddpost"></a>
# **ContentV2CardsUploadAddPost**
> ResponseCardCreate ContentV2CardsUploadAddPost (ContentV2CardsUploadAddPostRequest? contentV2CardsUploadAddPostRequest = null)

Создание карточек товаров с объединением

Метод создаёт новые карточки товаров, объединяя их с существующими карточками.  Габариты товаров можно указать только в **сантиметрах**. <br><br> Создание карточки товара происходит асинхронно. После отправки запрос становится в очередь на обработку.<br>Максимальный размер запроса 10 Мб.<br> Если ответ `Успешно` (`200`), но какие-то карточки не обновились, получите [список несозданных карточек товаров](/openapi/work-with-products#tag/Kartochki-tovarov/paths/~1content~1v2~1cards~1error~1list/get).  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2CardsUploadAddPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contentV2CardsUploadAddPostRequest = new ContentV2CardsUploadAddPostRequest?(); // ContentV2CardsUploadAddPostRequest? |  (optional) 

            try
            {
                // Создание карточек товаров с объединением
                ResponseCardCreate result = apiInstance.ContentV2CardsUploadAddPost(contentV2CardsUploadAddPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2CardsUploadAddPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2CardsUploadAddPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Создание карточек товаров с объединением
    ApiResponse<ResponseCardCreate> response = apiInstance.ContentV2CardsUploadAddPostWithHttpInfo(contentV2CardsUploadAddPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2CardsUploadAddPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentV2CardsUploadAddPostRequest** | [**ContentV2CardsUploadAddPostRequest?**](ContentV2CardsUploadAddPostRequest?.md) |  | [optional]  |

### Return type

[**ResponseCardCreate**](ResponseCardCreate.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **413** | Превышен лимит объёма данных в запросе |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2cardsuploadpost"></a>
# **ContentV2CardsUploadPost**
> ResponseCardCreate ContentV2CardsUploadPost (List<ContentV2CardsUploadPostRequestInner>? contentV2CardsUploadPostRequestInner = null)

Создание карточек товаров

Метод создаёт карточки товаров c указанием описаний и характеристик товаров.<br>  <div class=\"description_important\">   Есть две формы запроса: для создания отдельных и объединённых карточек товаров. </div>  Габариты товаров можно указать только в **сантиметрах**. <br><br> Создание карточки товара происходит асинхронно. После отправки запрос становится в очередь на обработку.<br> В одном запросе можно создать максимум 100 объединённых карточек товаров (`imtID`), по 30 карточек товаров в каждой. Максимальный размер запроса 10 Мб.<br> Если ответ `Успешно` (`200`), но какие-то карточки не обновились, получите [список несозданных карточек товаров](/openapi/work-with-products#tag/Kartochki-tovarov/paths/~1content~1v2~1cards~1error~1list/get).  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2CardsUploadPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contentV2CardsUploadPostRequestInner = new List<ContentV2CardsUploadPostRequestInner>?(); // List<ContentV2CardsUploadPostRequestInner>? |  (optional) 

            try
            {
                // Создание карточек товаров
                ResponseCardCreate result = apiInstance.ContentV2CardsUploadPost(contentV2CardsUploadPostRequestInner);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2CardsUploadPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2CardsUploadPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Создание карточек товаров
    ApiResponse<ResponseCardCreate> response = apiInstance.ContentV2CardsUploadPostWithHttpInfo(contentV2CardsUploadPostRequestInner);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2CardsUploadPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentV2CardsUploadPostRequestInner** | [**List&lt;ContentV2CardsUploadPostRequestInner&gt;?**](ContentV2CardsUploadPostRequestInner.md) |  | [optional]  |

### Return type

[**ResponseCardCreate**](ResponseCardCreate.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **413** | Превышен лимит объёма данных в запросе |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2directorycolorsget"></a>
# **ContentV2DirectoryColorsGet**
> ContentV2DirectoryColorsGet200Response ContentV2DirectoryColorsGet (string? locale = null)

Цвет

Метод предоставляет возможные значения [характеристики](/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1object~1charcs~1%7BsubjectId%7D/get) предмета `Цвет`.   <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2DirectoryColorsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var locale = en;  // string? | Язык полей ответа `subjectName` и `name`:     - `ru` — русский   - `en` — английский   - `zh` — китайский  Не используется в песочнице  (optional) 

            try
            {
                // Цвет
                ContentV2DirectoryColorsGet200Response result = apiInstance.ContentV2DirectoryColorsGet(locale);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2DirectoryColorsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2DirectoryColorsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Цвет
    ApiResponse<ContentV2DirectoryColorsGet200Response> response = apiInstance.ContentV2DirectoryColorsGetWithHttpInfo(locale);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2DirectoryColorsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locale** | **string?** | Язык полей ответа &#x60;subjectName&#x60; и &#x60;name&#x60;:     - &#x60;ru&#x60; — русский   - &#x60;en&#x60; — английский   - &#x60;zh&#x60; — китайский  Не используется в песочнице  | [optional]  |

### Return type

[**ContentV2DirectoryColorsGet200Response**](ContentV2DirectoryColorsGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2directorycountriesget"></a>
# **ContentV2DirectoryCountriesGet**
> ContentV2DirectoryCountriesGet200Response ContentV2DirectoryCountriesGet (string? locale = null)

Страна производства

Метод предоставляет возможные значения [характеристики](/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1object~1charcs~1%7BsubjectId%7D/get) предмета `Страна производства`.   <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2DirectoryCountriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var locale = en;  // string? | Язык полей ответа `subjectName` и `name`:     - `ru` — русский   - `en` — английский   - `zh` — китайский  Не используется в песочнице  (optional) 

            try
            {
                // Страна производства
                ContentV2DirectoryCountriesGet200Response result = apiInstance.ContentV2DirectoryCountriesGet(locale);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2DirectoryCountriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2DirectoryCountriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Страна производства
    ApiResponse<ContentV2DirectoryCountriesGet200Response> response = apiInstance.ContentV2DirectoryCountriesGetWithHttpInfo(locale);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2DirectoryCountriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locale** | **string?** | Язык полей ответа &#x60;subjectName&#x60; и &#x60;name&#x60;:     - &#x60;ru&#x60; — русский   - &#x60;en&#x60; — английский   - &#x60;zh&#x60; — китайский  Не используется в песочнице  | [optional]  |

### Return type

[**ContentV2DirectoryCountriesGet200Response**](ContentV2DirectoryCountriesGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2directorykindsget"></a>
# **ContentV2DirectoryKindsGet**
> ContentV2DirectoryKindsGet200Response ContentV2DirectoryKindsGet (string? locale = null)

Пол

Метод предоставляет возможные значения [характеристики](/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1object~1charcs~1%7BsubjectId%7D/get) предмета `Пол`.   <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2DirectoryKindsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var locale = en;  // string? | Язык полей ответа `subjectName` и `name`:     - `ru` — русский   - `en` — английский   - `zh` — китайский  Не используется в песочнице  (optional) 

            try
            {
                // Пол
                ContentV2DirectoryKindsGet200Response result = apiInstance.ContentV2DirectoryKindsGet(locale);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2DirectoryKindsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2DirectoryKindsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Пол
    ApiResponse<ContentV2DirectoryKindsGet200Response> response = apiInstance.ContentV2DirectoryKindsGetWithHttpInfo(locale);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2DirectoryKindsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locale** | **string?** | Язык полей ответа &#x60;subjectName&#x60; и &#x60;name&#x60;:     - &#x60;ru&#x60; — русский   - &#x60;en&#x60; — английский   - &#x60;zh&#x60; — китайский  Не используется в песочнице  | [optional]  |

### Return type

[**ContentV2DirectoryKindsGet200Response**](ContentV2DirectoryKindsGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2directoryseasonsget"></a>
# **ContentV2DirectorySeasonsGet**
> ContentV2DirectorySeasonsGet200Response ContentV2DirectorySeasonsGet (string? locale = null)

Сезон

Метод предоставляет возможные значения [характеристики](/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1object~1charcs~1%7BsubjectId%7D/get) предмета `Сезон`.   <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2DirectorySeasonsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var locale = en;  // string? | Язык полей ответа `subjectName` и `name`:     - `ru` — русский   - `en` — английский   - `zh` — китайский  Не используется в песочнице  (optional) 

            try
            {
                // Сезон
                ContentV2DirectorySeasonsGet200Response result = apiInstance.ContentV2DirectorySeasonsGet(locale);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2DirectorySeasonsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2DirectorySeasonsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Сезон
    ApiResponse<ContentV2DirectorySeasonsGet200Response> response = apiInstance.ContentV2DirectorySeasonsGetWithHttpInfo(locale);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2DirectorySeasonsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locale** | **string?** | Язык полей ответа &#x60;subjectName&#x60; и &#x60;name&#x60;:     - &#x60;ru&#x60; — русский   - &#x60;en&#x60; — английский   - &#x60;zh&#x60; — китайский  Не используется в песочнице  | [optional]  |

### Return type

[**ContentV2DirectorySeasonsGet200Response**](ContentV2DirectorySeasonsGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2directorytnvedget"></a>
# **ContentV2DirectoryTnvedGet**
> ContentV2DirectoryTnvedGet200Response ContentV2DirectoryTnvedGet (int subjectID, int? search = null, string? locale = null)

ТНВЭД-код

Метод предоставляет список ТНВЭД-кодов по ID [предмета](/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1object~1all/get) и фрагменту ТНВЭД-кода.   <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2DirectoryTnvedGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var subjectID = 105;  // int | ID предмета
            var search = 6106903000;  // int? | Поиск по ТНВЭД-коду. Работает только в паре с `subjectID` (optional) 
            var locale = en;  // string? | Язык полей ответа:     - `ru` — русский   - `en` — английский   - `zh` — китайский  Не используется в песочнице  (optional) 

            try
            {
                // ТНВЭД-код
                ContentV2DirectoryTnvedGet200Response result = apiInstance.ContentV2DirectoryTnvedGet(subjectID, search, locale);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2DirectoryTnvedGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2DirectoryTnvedGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ТНВЭД-код
    ApiResponse<ContentV2DirectoryTnvedGet200Response> response = apiInstance.ContentV2DirectoryTnvedGetWithHttpInfo(subjectID, search, locale);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2DirectoryTnvedGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subjectID** | **int** | ID предмета |  |
| **search** | **int?** | Поиск по ТНВЭД-коду. Работает только в паре с &#x60;subjectID&#x60; | [optional]  |
| **locale** | **string?** | Язык полей ответа:     - &#x60;ru&#x60; — русский   - &#x60;en&#x60; — английский   - &#x60;zh&#x60; — китайский  Не используется в песочнице  | [optional]  |

### Return type

[**ContentV2DirectoryTnvedGet200Response**](ContentV2DirectoryTnvedGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2directoryvatget"></a>
# **ContentV2DirectoryVatGet**
> ContentV2DirectoryVatGet200Response ContentV2DirectoryVatGet (string locale)

Ставка НДС

Метод предоставляет возможные значения [характеристики](/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1object~1charcs~1%7BsubjectId%7D/get) предмета `Ставка НДС`.   <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2DirectoryVatGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var locale = ru;  // string | Язык полей ответа `subjectName` и `name`:     - `ru` — русский   - `en` — английский   - `zh` — китайский  Не используется в песочнице 

            try
            {
                // Ставка НДС
                ContentV2DirectoryVatGet200Response result = apiInstance.ContentV2DirectoryVatGet(locale);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2DirectoryVatGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2DirectoryVatGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ставка НДС
    ApiResponse<ContentV2DirectoryVatGet200Response> response = apiInstance.ContentV2DirectoryVatGetWithHttpInfo(locale);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2DirectoryVatGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locale** | **string** | Язык полей ответа &#x60;subjectName&#x60; и &#x60;name&#x60;:     - &#x60;ru&#x60; — русский   - &#x60;en&#x60; — английский   - &#x60;zh&#x60; — китайский  Не используется в песочнице  |  |

### Return type

[**ContentV2DirectoryVatGet200Response**](ContentV2DirectoryVatGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2getcardslistpost"></a>
# **ContentV2GetCardsListPost**
> ContentV2GetCardsListPost200Response ContentV2GetCardsListPost (ContentV2GetCardsListPostRequest contentV2GetCardsListPostRequest, string? locale = null)

Список карточек товаров

<div class=\"description_auth\">     Метод доступен по <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">токену</a> с категорией <strong>Контент</strong> или <strong>Продвижение</strong> </div>  Метод предоставляет список созданных карточек товаров.  <div class=\"description_important\">   В ответе метода не будет карточек, находящихся в корзине. Получить такие карточки можно через <a href=\"/openapi/work-with-products#tag/Kartochki-tovarov/paths/~1content~1v2~1get~1cards~1trash/post\">отдельный метод</a>. </div>      Чтобы получить **больше 100** карточек товаров, воспользуйтесь пагинацией:    <ol>     <li>Сделайте первый запрос: <br>       <pre style=\"background-color: rgb(38 50 56 / 5%); color: #e53935\">         {           \"settings\": {                                   \"cursor\": {               \"limit\": 100             },             \"filter\": {               \"withPhoto\": -1             }           }         }</pre>                                    </li>     <li>Пройдите в конец полученного списка карточек товаров.</li>     <li>Скопируйте из <code>cursor</code> две строки:       <ul>         <li><code>\"updatedAt\": \"***\"</code></li>         <li><code>\"nmID\": ***</code></li>       </ul></li>     <li>Вставьте скопированные строки в параметр запроса <code>cursor</code>.</li>     <li>Повторите запрос. </li>     <li>Повторяйте пункты со <b>2</b> по <b>5</b>, пока поле <code>total</code> в ответе не станет меньше чем параметр <code>limit</code> в запросе. Это будет означать, что вы получили все карточки.   </ol>  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2GetCardsListPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contentV2GetCardsListPostRequest = new ContentV2GetCardsListPostRequest(); // ContentV2GetCardsListPostRequest | 
            var locale = ru;  // string? | Язык полей ответа `name`, `value` и `object`:     - `ru` — русский   - `en` — английский   - `zh` — китайский  Не используется в песочнице.    (optional) 

            try
            {
                // Список карточек товаров
                ContentV2GetCardsListPost200Response result = apiInstance.ContentV2GetCardsListPost(contentV2GetCardsListPostRequest, locale);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2GetCardsListPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2GetCardsListPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список карточек товаров
    ApiResponse<ContentV2GetCardsListPost200Response> response = apiInstance.ContentV2GetCardsListPostWithHttpInfo(contentV2GetCardsListPostRequest, locale);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2GetCardsListPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentV2GetCardsListPostRequest** | [**ContentV2GetCardsListPostRequest**](ContentV2GetCardsListPostRequest.md) |  |  |
| **locale** | **string?** | Язык полей ответа &#x60;name&#x60;, &#x60;value&#x60; и &#x60;object&#x60;:     - &#x60;ru&#x60; — русский   - &#x60;en&#x60; — английский   - &#x60;zh&#x60; — китайский  Не используется в песочнице.    | [optional]  |

### Return type

[**ContentV2GetCardsListPost200Response**](ContentV2GetCardsListPost200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2getcardstrashpost"></a>
# **ContentV2GetCardsTrashPost**
> ContentV2GetCardsTrashPost200Response ContentV2GetCardsTrashPost (ContentV2GetCardsTrashPostRequest contentV2GetCardsTrashPostRequest, string? locale = null)

Список карточек товаров в корзине

<div class=\"description_auth\">     Метод доступен по <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">токену</a> с категорией <strong>Контент</strong> или <strong>Продвижение</strong> </div>  Метод предоставляет список карточек товаров в корзине.<br><br>  Чтобы получить **больше 100** карточек товаров, воспользуйтесь пагинацией:    <ol>     <li>Сделайте первый запрос: <br>       <pre style=\"background-color: rgb(38 50 56 / 5%); color: #e53935\">         {           \"settings\": {                                   \"cursor\": {               \"limit\": 100             },             \"filter\": {               \"withPhoto\": -1             }           }         }</pre>                                    </li>     <li>Пройдите в конец полученного списка карточек товаров.</li>     <li>Скопируйте из <code>cursor</code> две строки:       <ul>         <li><code>\"updatedAt\": \"***\"</code></li>         <li><code>\"nmID\": ***</code></li>       </ul></li>     <li>Вставьте скопированные строки в параметр запроса <code>cursor</code>.</li>     <li>Повторите запрос. </li>     <li>Повторяйте пункты со <b>2</b> по <b>5</b>, пока поле <code>total</code> в ответе не станет меньше чем параметр <code>limit</code> в запросе. Это будет означать, что вы получили все карточки.   </ol>    <div class=\"description_limit\">     Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца   </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2GetCardsTrashPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contentV2GetCardsTrashPostRequest = new ContentV2GetCardsTrashPostRequest(); // ContentV2GetCardsTrashPostRequest | 
            var locale = "ru";  // string? | Язык полей ответа `name`, `value` и `object`: `ru`, `en`, `zh`.  Не используется в песочнице  (optional) 

            try
            {
                // Список карточек товаров в корзине
                ContentV2GetCardsTrashPost200Response result = apiInstance.ContentV2GetCardsTrashPost(contentV2GetCardsTrashPostRequest, locale);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2GetCardsTrashPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2GetCardsTrashPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список карточек товаров в корзине
    ApiResponse<ContentV2GetCardsTrashPost200Response> response = apiInstance.ContentV2GetCardsTrashPostWithHttpInfo(contentV2GetCardsTrashPostRequest, locale);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2GetCardsTrashPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentV2GetCardsTrashPostRequest** | [**ContentV2GetCardsTrashPostRequest**](ContentV2GetCardsTrashPostRequest.md) |  |  |
| **locale** | **string?** | Язык полей ответа &#x60;name&#x60;, &#x60;value&#x60; и &#x60;object&#x60;: &#x60;ru&#x60;, &#x60;en&#x60;, &#x60;zh&#x60;.  Не используется в песочнице  | [optional]  |

### Return type

[**ContentV2GetCardsTrashPost200Response**](ContentV2GetCardsTrashPost200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2objectallget"></a>
# **ContentV2ObjectAllGet**
> ContentV2ObjectAllGet200Response ContentV2ObjectAllGet (string? name = null, int? limit = null, string? locale = null, int? offset = null, int? parentID = null)

Список предметов

Метод предоставляет список названий [родительских категорий предметов](/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1object~1parent~1all/get) и их предметов с ID. Например, у категории `Игрушки` будут предметы `Калейдоскопы`, `Куклы`, `Мячики`.  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2ObjectAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var name = Носки;  // string? | Поиск по названию предмета (Носки), поиск работает по подстроке, искать можно на любом из поддерживаемых языков. (optional) 
            var limit = 1000;  // int? | Количество предметов, максимум 1 000 (optional) 
            var locale = en;  // string? | Язык полей ответа:     - `ru` — русский   - `en` — английский   - `zh` — китайский  Не используется в песочнице  (optional) 
            var offset = 5000;  // int? | Номер позиции, с которой необходимо получить ответ (optional) 
            var parentID = 1000;  // int? | ID родительской категории предмета (optional) 

            try
            {
                // Список предметов
                ContentV2ObjectAllGet200Response result = apiInstance.ContentV2ObjectAllGet(name, limit, locale, offset, parentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2ObjectAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2ObjectAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список предметов
    ApiResponse<ContentV2ObjectAllGet200Response> response = apiInstance.ContentV2ObjectAllGetWithHttpInfo(name, limit, locale, offset, parentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2ObjectAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string?** | Поиск по названию предмета (Носки), поиск работает по подстроке, искать можно на любом из поддерживаемых языков. | [optional]  |
| **limit** | **int?** | Количество предметов, максимум 1 000 | [optional]  |
| **locale** | **string?** | Язык полей ответа:     - &#x60;ru&#x60; — русский   - &#x60;en&#x60; — английский   - &#x60;zh&#x60; — китайский  Не используется в песочнице  | [optional]  |
| **offset** | **int?** | Номер позиции, с которой необходимо получить ответ | [optional]  |
| **parentID** | **int?** | ID родительской категории предмета | [optional]  |

### Return type

[**ContentV2ObjectAllGet200Response**](ContentV2ObjectAllGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **401** | Пользователь не авторизован |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2objectcharcssubjectidget"></a>
# **ContentV2ObjectCharcsSubjectIdGet**
> ContentV2ObjectCharcsSubjectIdGet200Response ContentV2ObjectCharcsSubjectIdGet (int subjectId, string? locale = null)

Характеристики предмета

Метод предоставляет параметры характеристик предмета: названия, типы данных, единицы измерения и так далее. В запросе необходимо указать ID [предмета](/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1object~1all/get).   <div class=\"description_important\">   Для получения характеристик <a href=\"/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1directory~1colors/get\">Цвет</a>, <a href=\"/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1directory~1kinds/get\">Пол</a>, <a href=\"/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1directory~1countries/get\">Страна производства</a>, <a href=\"/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1directory~1seasons/get\">Сезон</a>, <a href=\"/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1directory~1vat/get\">Ставка НДС</a> и <a href=\"/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki/paths/~1content~1v2~1directory~1tnved/get\">ТНВЭД-код</a> используйте отдельные методы </div>  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2ObjectCharcsSubjectIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var subjectId = 105;  // int | ID предмета
            var locale = en;  // string? | Язык полей ответа `subjectName` и `name`:     - `ru` — русский   - `en` — английский   - `zh` — китайский  Не используется в песочнице  (optional) 

            try
            {
                // Характеристики предмета
                ContentV2ObjectCharcsSubjectIdGet200Response result = apiInstance.ContentV2ObjectCharcsSubjectIdGet(subjectId, locale);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2ObjectCharcsSubjectIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2ObjectCharcsSubjectIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Характеристики предмета
    ApiResponse<ContentV2ObjectCharcsSubjectIdGet200Response> response = apiInstance.ContentV2ObjectCharcsSubjectIdGetWithHttpInfo(subjectId, locale);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2ObjectCharcsSubjectIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subjectId** | **int** | ID предмета |  |
| **locale** | **string?** | Язык полей ответа &#x60;subjectName&#x60; и &#x60;name&#x60;:     - &#x60;ru&#x60; — русский   - &#x60;en&#x60; — английский   - &#x60;zh&#x60; — китайский  Не используется в песочнице  | [optional]  |

### Return type

[**ContentV2ObjectCharcsSubjectIdGet200Response**](ContentV2ObjectCharcsSubjectIdGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2objectparentallget"></a>
# **ContentV2ObjectParentAllGet**
> ContentV2ObjectParentAllGet200Response ContentV2ObjectParentAllGet (string? locale = null)

Родительские категории товаров

Метод предоставляет названия и ID всех родительских категорий для [создания карточек товаров](/openapi/work-with-products#tag/Sozdanie-kartochek-tovarov): например, `Электроника`, `Бытовая химия`, `Рукоделие`.   <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2ObjectParentAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var locale = en;  // string? | Язык поля ответа `name`:     - `ru` — русский   - `en` — английский   - `zh` — китайский  Не используется в песочнице  (optional) 

            try
            {
                // Родительские категории товаров
                ContentV2ObjectParentAllGet200Response result = apiInstance.ContentV2ObjectParentAllGet(locale);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2ObjectParentAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2ObjectParentAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Родительские категории товаров
    ApiResponse<ContentV2ObjectParentAllGet200Response> response = apiInstance.ContentV2ObjectParentAllGetWithHttpInfo(locale);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2ObjectParentAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locale** | **string?** | Язык поля ответа &#x60;name&#x60;:     - &#x60;ru&#x60; — русский   - &#x60;en&#x60; — английский   - &#x60;zh&#x60; — китайский  Не используется в песочнице  | [optional]  |

### Return type

[**ContentV2ObjectParentAllGet200Response**](ContentV2ObjectParentAllGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2tagiddelete"></a>
# **ContentV2TagIdDelete**
> ContentV2TagIdDelete200Response ContentV2TagIdDelete (int id)

Удаление ярлыка

Метод удаляет ярлык из [списка ярлыков](/openapi/work-with-products#tag/Yarlyki/paths/~1content~1v2~1tags/get) продавца.  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2TagIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var id = 1;  // int | Числовой ID ярлыка

            try
            {
                // Удаление ярлыка
                ContentV2TagIdDelete200Response result = apiInstance.ContentV2TagIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2TagIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2TagIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Удаление ярлыка
    ApiResponse<ContentV2TagIdDelete200Response> response = apiInstance.ContentV2TagIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2TagIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Числовой ID ярлыка |  |

### Return type

[**ContentV2TagIdDelete200Response**](ContentV2TagIdDelete200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2tagidpatch"></a>
# **ContentV2TagIdPatch**
> ContentV2TagIdPatch200Response ContentV2TagIdPatch (int id, ContentV2TagIdPatchRequest contentV2TagIdPatchRequest)

Изменение ярлыка

Метод заменяет данные ярлыка: имя и цвет. <br>Новые данные можно получить в общем [списке](/openapi/work-with-products#tag/Yarlyki/paths/~1content~1v2~1tags/get).  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2TagIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var id = 1;  // int | Числовой ID ярлыка
            var contentV2TagIdPatchRequest = new ContentV2TagIdPatchRequest(); // ContentV2TagIdPatchRequest | 

            try
            {
                // Изменение ярлыка
                ContentV2TagIdPatch200Response result = apiInstance.ContentV2TagIdPatch(id, contentV2TagIdPatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2TagIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2TagIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Изменение ярлыка
    ApiResponse<ContentV2TagIdPatch200Response> response = apiInstance.ContentV2TagIdPatchWithHttpInfo(id, contentV2TagIdPatchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2TagIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Числовой ID ярлыка |  |
| **contentV2TagIdPatchRequest** | [**ContentV2TagIdPatchRequest**](ContentV2TagIdPatchRequest.md) |  |  |

### Return type

[**ContentV2TagIdPatch200Response**](ContentV2TagIdPatch200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2tagnomenclaturelinkpost"></a>
# **ContentV2TagNomenclatureLinkPost**
> ResponseContentError6 ContentV2TagNomenclatureLinkPost (ContentV2TagNomenclatureLinkPostRequest contentV2TagNomenclatureLinkPostRequest)

Управление ярлыками в карточке товара

Метод добавляет или снимает ярлык с карточки товара. К карточке можно добавить максимум 15 ярлыков.<br> При удалении ярлыка из карточки товара он не удаляется из [списка ярлыков](/openapi/work-with-products#tag/Yarlyki/paths/~1content~1v2~1tags/get) продавца.  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2TagNomenclatureLinkPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contentV2TagNomenclatureLinkPostRequest = new ContentV2TagNomenclatureLinkPostRequest(); // ContentV2TagNomenclatureLinkPostRequest | 

            try
            {
                // Управление ярлыками в карточке товара
                ResponseContentError6 result = apiInstance.ContentV2TagNomenclatureLinkPost(contentV2TagNomenclatureLinkPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2TagNomenclatureLinkPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2TagNomenclatureLinkPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Управление ярлыками в карточке товара
    ApiResponse<ResponseContentError6> response = apiInstance.ContentV2TagNomenclatureLinkPostWithHttpInfo(contentV2TagNomenclatureLinkPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2TagNomenclatureLinkPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentV2TagNomenclatureLinkPostRequest** | [**ContentV2TagNomenclatureLinkPostRequest**](ContentV2TagNomenclatureLinkPostRequest.md) |  |  |

### Return type

[**ResponseContentError6**](ResponseContentError6.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2tagpost"></a>
# **ContentV2TagPost**
> ResponseContentError6 ContentV2TagPost (ContentV2TagPostRequest contentV2TagPostRequest)

Создание ярлыка

Метод добавляет один ярлык продавца. Можно создать максимум 15 ярлыков для одного продавца. Максимальная длина ярлыка — 15 символов. <br>Созданный ярлык можно получить в общем [списке](/openapi/work-with-products#tag/Yarlyki/paths/~1content~1v2~1tags/get).  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2TagPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contentV2TagPostRequest = new ContentV2TagPostRequest(); // ContentV2TagPostRequest | 

            try
            {
                // Создание ярлыка
                ResponseContentError6 result = apiInstance.ContentV2TagPost(contentV2TagPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2TagPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2TagPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Создание ярлыка
    ApiResponse<ResponseContentError6> response = apiInstance.ContentV2TagPostWithHttpInfo(contentV2TagPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2TagPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentV2TagPostRequest** | [**ContentV2TagPostRequest**](ContentV2TagPostRequest.md) |  |  |

### Return type

[**ResponseContentError6**](ResponseContentError6.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv2tagsget"></a>
# **ContentV2TagsGet**
> ContentV2TagsGet200Response ContentV2TagsGet ()

Список ярлыков

Метод предоставляет список и характеристики всех ярлыков продавца для группировки и фильтрации товаров.  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV2TagsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);

            try
            {
                // Список ярлыков
                ContentV2TagsGet200Response result = apiInstance.ContentV2TagsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV2TagsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV2TagsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список ярлыков
    ApiResponse<ContentV2TagsGet200Response> response = apiInstance.ContentV2TagsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV2TagsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ContentV2TagsGet200Response**](ContentV2TagsGet200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv3mediafilepost"></a>
# **ContentV3MediaFilePost**
> ContentV3MediaFilePost200Response ContentV3MediaFilePost (string xNmId, int xPhotoNumber, System.IO.Stream? uploadfile = null)

Загрузить медиафайл

Метод загружает и добавляет один медиафайл к карточке товара.  Требования к изображениям:   * максимум изображений для одной карточки товара — 30   * минимальное разрешение — 700x900 px   * максимальный размер — 32 Мб   * минимальное качество — 65%   * форматы — JPG, PNG, BMP, GIF (статичные), WebP  Требования к видео:   * максимум одно видео для одной карточки товара   * максимальный размер — 50 Мб   * форматы — MOV, MP4  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV3MediaFilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var xNmId = 213864079;  // string | Артикул WB
            var xPhotoNumber = 2;  // int | Номер медиафайла на загрузку, начинается с `1`. При загрузке видео всегда указывайте `1`.  Чтобы добавить изображение к уже загруженным, номер медиафайла должен быть больше количества уже загруженных медиафайлов. 
            var uploadfile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? |  (optional) 

            try
            {
                // Загрузить медиафайл
                ContentV3MediaFilePost200Response result = apiInstance.ContentV3MediaFilePost(xNmId, xPhotoNumber, uploadfile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV3MediaFilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV3MediaFilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Загрузить медиафайл
    ApiResponse<ContentV3MediaFilePost200Response> response = apiInstance.ContentV3MediaFilePostWithHttpInfo(xNmId, xPhotoNumber, uploadfile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV3MediaFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xNmId** | **string** | Артикул WB |  |
| **xPhotoNumber** | **int** | Номер медиафайла на загрузку, начинается с &#x60;1&#x60;. При загрузке видео всегда указывайте &#x60;1&#x60;.  Чтобы добавить изображение к уже загруженным, номер медиафайла должен быть больше количества уже загруженных медиафайлов.  |  |
| **uploadfile** | **System.IO.Stream?****System.IO.Stream?** |  | [optional]  |

### Return type

[**ContentV3MediaFilePost200Response**](ContentV3MediaFilePost200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contentv3mediasavepost"></a>
# **ContentV3MediaSavePost**
> ContentV3MediaFilePost200Response ContentV3MediaSavePost (ContentV3MediaSavePostRequest contentV3MediaSavePostRequest)

Загрузить медиафайлы по ссылкам

Метод загружает набор медиафайлов в карточку товара через указание ссылок в запросе.  <div class=\"description_important\">   Новые медиафайлы полностью заменяют старые. Чтобы добавить новые медиафайлы, укажите в запросе ссылки одновременно на новые и старые медиафайлы. </div>  Требования к изображениям:   * максимум изображений для одной карточки товара — 30   * минимальное разрешение — 700×900 px   * максимальный размер — 32 Мб   * минимальное качество — 65%   * форматы — JPG, PNG, BMP, GIF (статичные), WebP  Требования к видео:   * максимум одно видео для одной карточки товара   * максимальный размер — 50 Мб   * форматы — MOV, MP4  Если видео или хотя бы одно изображение в запросе не соответствует требованиям, то даже при успешном ответе ни одно изображение/видео не загрузится.  <div class=\"description_limit\">   Максимум 100 запросов в минуту для всех методов категории <a href=\"/openapi/api-information#tag/Avtorizaciya/Kak-sozdat-token\">Контент</a> на один аккаунт продавца </div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContentV3MediaSavePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: HeaderApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contentV3MediaSavePostRequest = new ContentV3MediaSavePostRequest(); // ContentV3MediaSavePostRequest | 

            try
            {
                // Загрузить медиафайлы по ссылкам
                ContentV3MediaFilePost200Response result = apiInstance.ContentV3MediaSavePost(contentV3MediaSavePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContentV3MediaSavePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentV3MediaSavePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Загрузить медиафайлы по ссылкам
    ApiResponse<ContentV3MediaFilePost200Response> response = apiInstance.ContentV3MediaSavePostWithHttpInfo(contentV3MediaSavePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContentV3MediaSavePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentV3MediaSavePostRequest** | [**ContentV3MediaSavePostRequest**](ContentV3MediaSavePostRequest.md) |  |  |

### Return type

[**ContentV3MediaFilePost200Response**](ContentV3MediaFilePost200Response.md)

### Authorization

[HeaderApiKey](../README.md#HeaderApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Успешно |  -  |
| **400** | Неправильный запрос |  -  |
| **401** | Пользователь не авторизован |  -  |
| **403** | Доступ запрещён |  -  |
| **409** | Ошибка сохранения части ссылок |  -  |
| **422** | Отсутствует параметр nmId |  -  |
| **429** | Слишком много запросов |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

