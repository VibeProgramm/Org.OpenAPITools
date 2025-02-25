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
    /// GoodHistory
    /// </summary>
    [DataContract(Name = "GoodHistory")]
    public partial class GoodHistory : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoodHistory" /> class.
        /// </summary>
        /// <param name="nmID">Артикул WB.</param>
        /// <param name="vendorCode">Артикул продавца.</param>
        /// <param name="sizeID">ID размера. В методах контента это поле &#x60;chrtID&#x60;.</param>
        /// <param name="techSizeName">Размер.</param>
        /// <param name="price">Цена.</param>
        /// <param name="currencyIsoCode4217">Валюта, по стандарту ISO 4217.</param>
        /// <param name="discount">Скидка, %.</param>
        /// <param name="clubDiscount">Скидка WB Клуба, %.</param>
        /// <param name="status">Статус товара:    * &#x60;2&#x60; — товар без ошибок, цена и/или скидка обновилась   * &#x60;3&#x60; — есть ошибки, данные не обновились .</param>
        /// <param name="errorText">Текст ошибки  &lt;div class&#x3D;\&quot;description_important\&quot;&gt;   Ошибка &lt;code&gt;The product is in quarantine&lt;/code&gt; возникает, если новая цена со скидкой хотя бы в 3 раза меньше старой. Вы можете изменить цену или скидку с помощью API либо вывести товар из карантина &lt;a href&#x3D;\&quot;https://seller.wildberries.ru/discount-and-prices/quarantine\&quot;&gt;в личном кабинете&lt;/a&gt; &lt;/div&gt; .</param>
        public GoodHistory(int nmID = default(int), string vendorCode = default(string), int sizeID = default(int), string techSizeName = default(string), int price = default(int), string currencyIsoCode4217 = default(string), int discount = default(int), int clubDiscount = default(int), int status = default(int), string errorText = default(string))
        {
            this.NmID = nmID;
            this.VendorCode = vendorCode;
            this.SizeID = sizeID;
            this.TechSizeName = techSizeName;
            this.Price = price;
            this.CurrencyIsoCode4217 = currencyIsoCode4217;
            this.Discount = discount;
            this.ClubDiscount = clubDiscount;
            this.Status = status;
            this.ErrorText = errorText;
        }

        /// <summary>
        /// Артикул WB
        /// </summary>
        /// <value>Артикул WB</value>
        /*
        <example>544833232</example>
        */
        [DataMember(Name = "nmID", EmitDefaultValue = false)]
        public int NmID { get; set; }

        /// <summary>
        /// Артикул продавца
        /// </summary>
        /// <value>Артикул продавца</value>
        /*
        <example>34552332</example>
        */
        [DataMember(Name = "vendorCode", EmitDefaultValue = false)]
        public string VendorCode { get; set; }

        /// <summary>
        /// ID размера. В методах контента это поле &#x60;chrtID&#x60;
        /// </summary>
        /// <value>ID размера. В методах контента это поле &#x60;chrtID&#x60;</value>
        /*
        <example>54483342</example>
        */
        [DataMember(Name = "sizeID", EmitDefaultValue = false)]
        public int SizeID { get; set; }

        /// <summary>
        /// Размер
        /// </summary>
        /// <value>Размер</value>
        /*
        <example>42</example>
        */
        [DataMember(Name = "techSizeName", EmitDefaultValue = false)]
        public string TechSizeName { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        /// <value>Цена</value>
        /*
        <example>1500</example>
        */
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public int Price { get; set; }

        /// <summary>
        /// Валюта, по стандарту ISO 4217
        /// </summary>
        /// <value>Валюта, по стандарту ISO 4217</value>
        /*
        <example>RUB</example>
        */
        [DataMember(Name = "currencyIsoCode4217", EmitDefaultValue = false)]
        public string CurrencyIsoCode4217 { get; set; }

        /// <summary>
        /// Скидка, %
        /// </summary>
        /// <value>Скидка, %</value>
        /*
        <example>25</example>
        */
        [DataMember(Name = "discount", EmitDefaultValue = false)]
        public int Discount { get; set; }

        /// <summary>
        /// Скидка WB Клуба, %
        /// </summary>
        /// <value>Скидка WB Клуба, %</value>
        /*
        <example>5</example>
        */
        [DataMember(Name = "clubDiscount", EmitDefaultValue = false)]
        public int ClubDiscount { get; set; }

        /// <summary>
        /// Статус товара:    * &#x60;2&#x60; — товар без ошибок, цена и/или скидка обновилась   * &#x60;3&#x60; — есть ошибки, данные не обновились 
        /// </summary>
        /// <value>Статус товара:    * &#x60;2&#x60; — товар без ошибок, цена и/или скидка обновилась   * &#x60;3&#x60; — есть ошибки, данные не обновились </value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// Текст ошибки  &lt;div class&#x3D;\&quot;description_important\&quot;&gt;   Ошибка &lt;code&gt;The product is in quarantine&lt;/code&gt; возникает, если новая цена со скидкой хотя бы в 3 раза меньше старой. Вы можете изменить цену или скидку с помощью API либо вывести товар из карантина &lt;a href&#x3D;\&quot;https://seller.wildberries.ru/discount-and-prices/quarantine\&quot;&gt;в личном кабинете&lt;/a&gt; &lt;/div&gt; 
        /// </summary>
        /// <value>Текст ошибки  &lt;div class&#x3D;\&quot;description_important\&quot;&gt;   Ошибка &lt;code&gt;The product is in quarantine&lt;/code&gt; возникает, если новая цена со скидкой хотя бы в 3 раза меньше старой. Вы можете изменить цену или скидку с помощью API либо вывести товар из карантина &lt;a href&#x3D;\&quot;https://seller.wildberries.ru/discount-and-prices/quarantine\&quot;&gt;в личном кабинете&lt;/a&gt; &lt;/div&gt; </value>
        /*
        <example>The product is in quarantine</example>
        */
        [DataMember(Name = "errorText", EmitDefaultValue = false)]
        public string ErrorText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoodHistory {\n");
            sb.Append("  NmID: ").Append(NmID).Append("\n");
            sb.Append("  VendorCode: ").Append(VendorCode).Append("\n");
            sb.Append("  SizeID: ").Append(SizeID).Append("\n");
            sb.Append("  TechSizeName: ").Append(TechSizeName).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  CurrencyIsoCode4217: ").Append(CurrencyIsoCode4217).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  ClubDiscount: ").Append(ClubDiscount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
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
