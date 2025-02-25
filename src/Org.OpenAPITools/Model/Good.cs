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
    /// Good
    /// </summary>
    [DataContract(Name = "Good")]
    public partial class Good : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Good" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Good() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Good" /> class.
        /// </summary>
        /// <param name="nmID">Артикул WB (required).</param>
        /// <param name="price">Цена. Валюту можно получить с помощью метода [Получение списка товаров по артикулам](./work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1list~1goods~1filter/get), поле &#x60;currencyIsoCode4217&#x60;.</param>
        /// <param name="discount">Скидка, %.</param>
        public Good(int nmID = default(int), int price = default(int), int discount = default(int))
        {
            this.NmID = nmID;
            this.Price = price;
            this.Discount = discount;
        }

        /// <summary>
        /// Артикул WB
        /// </summary>
        /// <value>Артикул WB</value>
        /*
        <example>123</example>
        */
        [DataMember(Name = "nmID", IsRequired = true, EmitDefaultValue = true)]
        public int NmID { get; set; }

        /// <summary>
        /// Цена. Валюту можно получить с помощью метода [Получение списка товаров по артикулам](./work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1list~1goods~1filter/get), поле &#x60;currencyIsoCode4217&#x60;
        /// </summary>
        /// <value>Цена. Валюту можно получить с помощью метода [Получение списка товаров по артикулам](./work-with-products#tag/Ceny-i-skidki/paths/~1api~1v2~1list~1goods~1filter/get), поле &#x60;currencyIsoCode4217&#x60;</value>
        /*
        <example>999</example>
        */
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public int Price { get; set; }

        /// <summary>
        /// Скидка, %
        /// </summary>
        /// <value>Скидка, %</value>
        /*
        <example>30</example>
        */
        [DataMember(Name = "discount", EmitDefaultValue = false)]
        public int Discount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Good {\n");
            sb.Append("  NmID: ").Append(NmID).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
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
