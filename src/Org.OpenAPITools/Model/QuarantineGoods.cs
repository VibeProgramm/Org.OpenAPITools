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
    /// QuarantineGoods
    /// </summary>
    [DataContract(Name = "QuarantineGoods")]
    public partial class QuarantineGoods : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuarantineGoods" /> class.
        /// </summary>
        /// <param name="nmID">Артикул WB.</param>
        /// <param name="sizeID">Не используется.</param>
        /// <param name="techSizeName">Не используется.</param>
        /// <param name="currencyIsoCode4217">Валюта по стандарту ISO 4217.</param>
        /// <param name="newPrice">Новая цена продавца до скидки.</param>
        /// <param name="oldPrice">Текущая цена продавца до скидки.</param>
        /// <param name="newDiscount">Новая скидка продавца, %.</param>
        /// <param name="oldDiscount">Текущая скидка продавца, %.</param>
        /// <param name="priceDiff">Разница: &#x60;newPrice&#x60; * (1 - &#x60;newDiscount&#x60; / 100) - &#x60;oldPrice&#x60; * (1 - &#x60;oldDiscount&#x60; / 100).</param>
        public QuarantineGoods(int nmID = default(int), int sizeID = default(int), string techSizeName = default(string), string currencyIsoCode4217 = default(string), float newPrice = default(float), float oldPrice = default(float), int newDiscount = default(int), int oldDiscount = default(int), float priceDiff = default(float))
        {
            this.NmID = nmID;
            this.SizeID = sizeID;
            this.TechSizeName = techSizeName;
            this.CurrencyIsoCode4217 = currencyIsoCode4217;
            this.NewPrice = newPrice;
            this.OldPrice = oldPrice;
            this.NewDiscount = newDiscount;
            this.OldDiscount = oldDiscount;
            this.PriceDiff = priceDiff;
        }

        /// <summary>
        /// Артикул WB
        /// </summary>
        /// <value>Артикул WB</value>
        /*
        <example>206025152</example>
        */
        [DataMember(Name = "nmID", EmitDefaultValue = false)]
        public int NmID { get; set; }

        /// <summary>
        /// Не используется
        /// </summary>
        /// <value>Не используется</value>
        [DataMember(Name = "sizeID", EmitDefaultValue = false)]
        public int SizeID { get; set; }

        /// <summary>
        /// Не используется
        /// </summary>
        /// <value>Не используется</value>
        [DataMember(Name = "techSizeName", EmitDefaultValue = false)]
        public string TechSizeName { get; set; }

        /// <summary>
        /// Валюта по стандарту ISO 4217
        /// </summary>
        /// <value>Валюта по стандарту ISO 4217</value>
        /*
        <example>RUB</example>
        */
        [DataMember(Name = "currencyIsoCode4217", EmitDefaultValue = false)]
        public string CurrencyIsoCode4217 { get; set; }

        /// <summary>
        /// Новая цена продавца до скидки
        /// </summary>
        /// <value>Новая цена продавца до скидки</value>
        /*
        <example>134</example>
        */
        [DataMember(Name = "newPrice", EmitDefaultValue = false)]
        public float NewPrice { get; set; }

        /// <summary>
        /// Текущая цена продавца до скидки
        /// </summary>
        /// <value>Текущая цена продавца до скидки</value>
        /*
        <example>4000</example>
        */
        [DataMember(Name = "oldPrice", EmitDefaultValue = false)]
        public float OldPrice { get; set; }

        /// <summary>
        /// Новая скидка продавца, %
        /// </summary>
        /// <value>Новая скидка продавца, %</value>
        /*
        <example>25</example>
        */
        [DataMember(Name = "newDiscount", EmitDefaultValue = false)]
        public int NewDiscount { get; set; }

        /// <summary>
        /// Текущая скидка продавца, %
        /// </summary>
        /// <value>Текущая скидка продавца, %</value>
        /*
        <example>25</example>
        */
        [DataMember(Name = "oldDiscount", EmitDefaultValue = false)]
        public int OldDiscount { get; set; }

        /// <summary>
        /// Разница: &#x60;newPrice&#x60; * (1 - &#x60;newDiscount&#x60; / 100) - &#x60;oldPrice&#x60; * (1 - &#x60;oldDiscount&#x60; / 100)
        /// </summary>
        /// <value>Разница: &#x60;newPrice&#x60; * (1 - &#x60;newDiscount&#x60; / 100) - &#x60;oldPrice&#x60; * (1 - &#x60;oldDiscount&#x60; / 100)</value>
        /*
        <example>-2899.5</example>
        */
        [DataMember(Name = "priceDiff", EmitDefaultValue = false)]
        public float PriceDiff { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuarantineGoods {\n");
            sb.Append("  NmID: ").Append(NmID).Append("\n");
            sb.Append("  SizeID: ").Append(SizeID).Append("\n");
            sb.Append("  TechSizeName: ").Append(TechSizeName).Append("\n");
            sb.Append("  CurrencyIsoCode4217: ").Append(CurrencyIsoCode4217).Append("\n");
            sb.Append("  NewPrice: ").Append(NewPrice).Append("\n");
            sb.Append("  OldPrice: ").Append(OldPrice).Append("\n");
            sb.Append("  NewDiscount: ").Append(NewDiscount).Append("\n");
            sb.Append("  OldDiscount: ").Append(OldDiscount).Append("\n");
            sb.Append("  PriceDiff: ").Append(PriceDiff).Append("\n");
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
