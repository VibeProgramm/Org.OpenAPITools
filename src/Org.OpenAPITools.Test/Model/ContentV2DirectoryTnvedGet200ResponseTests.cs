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
    ///  Class for testing ContentV2DirectoryTnvedGet200Response
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ContentV2DirectoryTnvedGet200ResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ContentV2DirectoryTnvedGet200Response
        //private ContentV2DirectoryTnvedGet200Response instance;

        public ContentV2DirectoryTnvedGet200ResponseTests()
        {
            // TODO uncomment below to create an instance of ContentV2DirectoryTnvedGet200Response
            //instance = new ContentV2DirectoryTnvedGet200Response();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ContentV2DirectoryTnvedGet200Response
        /// </summary>
        [Fact]
        public void ContentV2DirectoryTnvedGet200ResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" ContentV2DirectoryTnvedGet200Response
            //Assert.IsType<ContentV2DirectoryTnvedGet200Response>(instance);
        }

        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }

        /// <summary>
        /// Test the property 'Error'
        /// </summary>
        [Fact]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }

        /// <summary>
        /// Test the property 'ErrorText'
        /// </summary>
        [Fact]
        public void ErrorTextTest()
        {
            // TODO unit test for the property 'ErrorText'
        }

        /// <summary>
        /// Test the property 'AdditionalErrors'
        /// </summary>
        [Fact]
        public void AdditionalErrorsTest()
        {
            // TODO unit test for the property 'AdditionalErrors'
        }
    }
}
