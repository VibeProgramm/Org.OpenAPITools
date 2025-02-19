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
    /// GoodsListSizesInner
    /// </summary>
    [DataContract(Name = "GoodsList_sizes_inner")]
    public partial class GoodsListSizesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoodsListSizesInner" /> class.
        /// </summary>
        /// <param name="sizeID">ID размера. В методах контента это поле &#x60;chrtID&#x60;.</param>
        /// <param name="price">Цена.</param>
        /// <param name="discountedPrice">Цена со скидкой.</param>
        /// <param name="clubDiscountedPrice">Цена со скидкой, включая скидку WB Клуба.</param>
        /// <param name="techSizeName">Размер товара.</param>
        public GoodsListSizesInner(long sizeID = default(long), int price = default(int), decimal discountedPrice = default(decimal), decimal clubDiscountedPrice = default(decimal), string techSizeName = default(string))
        {
            this.SizeID = sizeID;
            this.Price = price;
            this.DiscountedPrice = discountedPrice;
            this.ClubDiscountedPrice = clubDiscountedPrice;
            this.TechSizeName = techSizeName;
        }

        /// <summary>
        /// ID размера. В методах контента это поле &#x60;chrtID&#x60;
        /// </summary>
        /// <value>ID размера. В методах контента это поле &#x60;chrtID&#x60;</value>
        /*
        <example>3123515574</example>
        */
        [DataMember(Name = "sizeID", EmitDefaultValue = false)]
        public long SizeID { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        /// <value>Цена</value>
        /*
        <example>500</example>
        */
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public int Price { get; set; }

        /// <summary>
        /// Цена со скидкой
        /// </summary>
        /// <value>Цена со скидкой</value>
        /*
        <example>350</example>
        */
        [DataMember(Name = "discountedPrice", EmitDefaultValue = false)]
        public decimal DiscountedPrice { get; set; }

        /// <summary>
        /// Цена со скидкой, включая скидку WB Клуба
        /// </summary>
        /// <value>Цена со скидкой, включая скидку WB Клуба</value>
        /*
        <example>332.5</example>
        */
        [DataMember(Name = "clubDiscountedPrice", EmitDefaultValue = false)]
        public decimal ClubDiscountedPrice { get; set; }

        /// <summary>
        /// Размер товара
        /// </summary>
        /// <value>Размер товара</value>
        /*
        <example>42</example>
        */
        [DataMember(Name = "techSizeName", EmitDefaultValue = false)]
        public string TechSizeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoodsListSizesInner {\n");
            sb.Append("  SizeID: ").Append(SizeID).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  DiscountedPrice: ").Append(DiscountedPrice).Append("\n");
            sb.Append("  ClubDiscountedPrice: ").Append(ClubDiscountedPrice).Append("\n");
            sb.Append("  TechSizeName: ").Append(TechSizeName).Append("\n");
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
