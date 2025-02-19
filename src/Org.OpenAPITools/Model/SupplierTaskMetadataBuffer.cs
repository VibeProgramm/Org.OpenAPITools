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
    /// SupplierTaskMetadataBuffer
    /// </summary>
    [DataContract(Name = "SupplierTaskMetadataBuffer")]
    public partial class SupplierTaskMetadataBuffer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupplierTaskMetadataBuffer" /> class.
        /// </summary>
        /// <param name="uploadID">ID загрузки.</param>
        /// <param name="status">Статус загрузки: &#x60;1&#x60; — в обработке .</param>
        /// <param name="uploadDate">Дата и время, когда загрузка создана.</param>
        /// <param name="activationDate">Дата и время, когда загрузка отправляется в обработку.</param>
        /// <param name="overAllGoodsNumber">Всего товаров.</param>
        /// <param name="successGoodsNumber">Товаров без ошибок (0, потому что загрузка в обработке).</param>
        public SupplierTaskMetadataBuffer(int uploadID = default(int), int status = default(int), DateOnly uploadDate = default(DateOnly), DateOnly activationDate = default(DateOnly), int overAllGoodsNumber = default(int), int successGoodsNumber = default(int))
        {
            this.UploadID = uploadID;
            this.Status = status;
            this.UploadDate = uploadDate;
            this.ActivationDate = activationDate;
            this.OverAllGoodsNumber = overAllGoodsNumber;
            this.SuccessGoodsNumber = successGoodsNumber;
        }

        /// <summary>
        /// ID загрузки
        /// </summary>
        /// <value>ID загрузки</value>
        /*
        <example>395643565</example>
        */
        [DataMember(Name = "uploadID", EmitDefaultValue = false)]
        public int UploadID { get; set; }

        /// <summary>
        /// Статус загрузки: &#x60;1&#x60; — в обработке 
        /// </summary>
        /// <value>Статус загрузки: &#x60;1&#x60; — в обработке </value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// Дата и время, когда загрузка создана
        /// </summary>
        /// <value>Дата и время, когда загрузка создана</value>
        [DataMember(Name = "uploadDate", EmitDefaultValue = false)]
        public DateOnly UploadDate { get; set; }

        /// <summary>
        /// Дата и время, когда загрузка отправляется в обработку
        /// </summary>
        /// <value>Дата и время, когда загрузка отправляется в обработку</value>
        [DataMember(Name = "activationDate", EmitDefaultValue = false)]
        public DateOnly ActivationDate { get; set; }

        /// <summary>
        /// Всего товаров
        /// </summary>
        /// <value>Всего товаров</value>
        /*
        <example>100</example>
        */
        [DataMember(Name = "overAllGoodsNumber", EmitDefaultValue = false)]
        public int OverAllGoodsNumber { get; set; }

        /// <summary>
        /// Товаров без ошибок (0, потому что загрузка в обработке)
        /// </summary>
        /// <value>Товаров без ошибок (0, потому что загрузка в обработке)</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "successGoodsNumber", EmitDefaultValue = false)]
        public int SuccessGoodsNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupplierTaskMetadataBuffer {\n");
            sb.Append("  UploadID: ").Append(UploadID).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UploadDate: ").Append(UploadDate).Append("\n");
            sb.Append("  ActivationDate: ").Append(ActivationDate).Append("\n");
            sb.Append("  OverAllGoodsNumber: ").Append(OverAllGoodsNumber).Append("\n");
            sb.Append("  SuccessGoodsNumber: ").Append(SuccessGoodsNumber).Append("\n");
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
            if (this.UploadDate != null) {
                // UploadDate (DateOnly) pattern
                Regex regexUploadDate = new Regex(@"YYYY-MM-DDTHH:MM:SSZ", RegexOptions.CultureInvariant);
                if (!regexUploadDate.Match(this.UploadDate).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UploadDate, must match a pattern of " + regexUploadDate, new [] { "UploadDate" });
                }
            }

            if (this.ActivationDate != null) {
                // ActivationDate (DateOnly) pattern
                Regex regexActivationDate = new Regex(@"YYYY-MM-DDTHH:MM:SSZ", RegexOptions.CultureInvariant);
                if (!regexActivationDate.Match(this.ActivationDate).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ActivationDate, must match a pattern of " + regexActivationDate, new [] { "ActivationDate" });
                }
            }

            yield break;
        }
    }

}
