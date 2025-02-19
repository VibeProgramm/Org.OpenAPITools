/*
 * Работа с товарами
 *
 * Работа с товарами включает в себя:   1. [Создание](/openapi/work-with-products#tag/Sozdanie-kartochek-tovarov) и [редактирование](/openapi/work-with-products#tag/Kartochki-tovarov) карточек товаров: в том числе, получение [категорий, предметов и характеристик товаров](/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki) и загрузку [медиафайлов](/openapi/work-with-products#tag/Mediafajly).   2. Настройку [ярлыков](/openapi/work-with-products#tag/Yarlyki) для удобного поиска товаров.   3. Установку [цен и скидок](/openapi/work-with-products#tag/Ceny-i-skidki).   4. Управление [остатками товаров](/openapi/work-with-products#tag/Ostatki-na-skladah-prodavca) и [складами](/openapi/work-with-products#tag/Sklady-prodavca), если вы работаете по модели продаж со склада продавца. 
 *
 * The version of the OpenAPI document: products
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// TaskCreatedData
    /// </summary>
    [DataContract(Name = "TaskCreated_data")]
    public partial class TaskCreatedData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskCreatedData" /> class.
        /// </summary>
        /// <param name="id">ID загрузки.</param>
        /// <param name="alreadyExists">Флаг дублирования загрузки: &#x60;true&#x60; — такая загрузка уже есть .</param>
        public TaskCreatedData(int id = default(int), bool alreadyExists = default(bool))
        {
            this.Id = id;
            this.AlreadyExists = alreadyExists;
        }

        /// <summary>
        /// ID загрузки
        /// </summary>
        /// <value>ID загрузки</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Флаг дублирования загрузки: &#x60;true&#x60; — такая загрузка уже есть 
        /// </summary>
        /// <value>Флаг дублирования загрузки: &#x60;true&#x60; — такая загрузка уже есть </value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "alreadyExists", EmitDefaultValue = true)]
        public bool AlreadyExists { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaskCreatedData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AlreadyExists: ").Append(AlreadyExists).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
