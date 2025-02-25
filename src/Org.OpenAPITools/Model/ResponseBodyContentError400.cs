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
    /// ResponseBodyContentError400
    /// </summary>
    [DataContract(Name = "responseBodyContentError400")]
    public partial class ResponseBodyContentError400 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBodyContentError400" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="error">Флаг ошибки.</param>
        /// <param name="errorText">Описание ошибки.</param>
        /// <param name="additionalErrors">additionalErrors.</param>
        public ResponseBodyContentError400(Object data = default(Object), bool error = default(bool), string errorText = default(string), ResponseBodyContentError400AdditionalErrors additionalErrors = default(ResponseBodyContentError400AdditionalErrors))
        {
            this.Data = data;
            this.Error = error;
            this.ErrorText = errorText;
            this.AdditionalErrors = additionalErrors;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public Object Data { get; set; }

        /// <summary>
        /// Флаг ошибки
        /// </summary>
        /// <value>Флаг ошибки</value>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public bool Error { get; set; }

        /// <summary>
        /// Описание ошибки
        /// </summary>
        /// <value>Описание ошибки</value>
        [DataMember(Name = "errorText", EmitDefaultValue = false)]
        public string ErrorText { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalErrors
        /// </summary>
        [DataMember(Name = "additionalErrors", EmitDefaultValue = false)]
        public ResponseBodyContentError400AdditionalErrors AdditionalErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseBodyContentError400 {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
            sb.Append("  AdditionalErrors: ").Append(AdditionalErrors).Append("\n");
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
