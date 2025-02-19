/*
 * Работа с товарами
 *
 * Работа с товарами включает в себя:   1. [Создание](/openapi/work-with-products#tag/Sozdanie-kartochek-tovarov) и [редактирование](/openapi/work-with-products#tag/Kartochki-tovarov) карточек товаров: в том числе, получение [категорий, предметов и характеристик товаров](/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki) и загрузку [медиафайлов](/openapi/work-with-products#tag/Mediafajly).   2. Настройку [ярлыков](/openapi/work-with-products#tag/Yarlyki) для удобного поиска товаров.   3. Установку [цен и скидок](/openapi/work-with-products#tag/Ceny-i-skidki).   4. Управление [остатками товаров](/openapi/work-with-products#tag/Ostatki-na-skladah-prodavca) и [складами](/openapi/work-with-products#tag/Sklady-prodavca), если вы работаете по модели продаж со склада продавца. 
 *
 * The version of the OpenAPI document: products
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing ContentV2CardsUploadPostRequestInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ContentV2CardsUploadPostRequestInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ContentV2CardsUploadPostRequestInner
        //private ContentV2CardsUploadPostRequestInner instance;

        public ContentV2CardsUploadPostRequestInnerTests()
        {
            // TODO uncomment below to create an instance of ContentV2CardsUploadPostRequestInner
            //instance = new ContentV2CardsUploadPostRequestInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ContentV2CardsUploadPostRequestInner
        /// </summary>
        [Fact]
        public void ContentV2CardsUploadPostRequestInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ContentV2CardsUploadPostRequestInner
            //Assert.IsType<ContentV2CardsUploadPostRequestInner>(instance);
        }

        /// <summary>
        /// Test the property 'SubjectID'
        /// </summary>
        [Fact]
        public void SubjectIDTest()
        {
            // TODO unit test for the property 'SubjectID'
        }

        /// <summary>
        /// Test the property 'Variants'
        /// </summary>
        [Fact]
        public void VariantsTest()
        {
            // TODO unit test for the property 'Variants'
        }
    }
}
