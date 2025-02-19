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
    /// ContentV2GetCardsTrashPost200ResponseCardsInner
    /// </summary>
    [DataContract(Name = "_content_v2_get_cards_trash_post_200_response_cards_inner")]
    public partial class ContentV2GetCardsTrashPost200ResponseCardsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentV2GetCardsTrashPost200ResponseCardsInner" /> class.
        /// </summary>
        /// <param name="nmID">Артикул WB.</param>
        /// <param name="vendorCode">Артикул продавца.</param>
        /// <param name="subjectID">ID предмета.</param>
        /// <param name="subjectName">Название предмета.</param>
        /// <param name="photos">Массив фото.</param>
        /// <param name="video">URL видео.</param>
        /// <param name="sizes">Массив размеров.</param>
        /// <param name="dimensions">dimensions.</param>
        /// <param name="characteristics">Массив характеристик, при наличии.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="trashedAt">trashedAt.</param>
        public ContentV2GetCardsTrashPost200ResponseCardsInner(int nmID = default(int), string vendorCode = default(string), int subjectID = default(int), string subjectName = default(string), List<ContentV2GetCardsListPost200ResponseCardsInnerPhotosInner> photos = default(List<ContentV2GetCardsListPost200ResponseCardsInnerPhotosInner>), string video = default(string), List<ContentV2GetCardsTrashPost200ResponseCardsInnerSizesInner> sizes = default(List<ContentV2GetCardsTrashPost200ResponseCardsInnerSizesInner>), ContentV2GetCardsTrashPost200ResponseCardsInnerDimensions dimensions = default(ContentV2GetCardsTrashPost200ResponseCardsInnerDimensions), List<ContentV2GetCardsTrashPost200ResponseCardsInnerCharacteristicsInner> characteristics = default(List<ContentV2GetCardsTrashPost200ResponseCardsInnerCharacteristicsInner>), string createdAt = default(string), string trashedAt = default(string))
        {
            this.NmID = nmID;
            this.VendorCode = vendorCode;
            this.SubjectID = subjectID;
            this.SubjectName = subjectName;
            this.Photos = photos;
            this.Video = video;
            this.Sizes = sizes;
            this.Dimensions = dimensions;
            this.Characteristics = characteristics;
            this.CreatedAt = createdAt;
            this.TrashedAt = trashedAt;
        }

        /// <summary>
        /// Артикул WB
        /// </summary>
        /// <value>Артикул WB</value>
        [DataMember(Name = "nmID", EmitDefaultValue = false)]
        public int NmID { get; set; }

        /// <summary>
        /// Артикул продавца
        /// </summary>
        /// <value>Артикул продавца</value>
        [DataMember(Name = "vendorCode", EmitDefaultValue = false)]
        public string VendorCode { get; set; }

        /// <summary>
        /// ID предмета
        /// </summary>
        /// <value>ID предмета</value>
        [DataMember(Name = "subjectID", EmitDefaultValue = false)]
        public int SubjectID { get; set; }

        /// <summary>
        /// Название предмета
        /// </summary>
        /// <value>Название предмета</value>
        [DataMember(Name = "subjectName", EmitDefaultValue = false)]
        public string SubjectName { get; set; }

        /// <summary>
        /// Массив фото
        /// </summary>
        /// <value>Массив фото</value>
        [DataMember(Name = "photos", EmitDefaultValue = false)]
        public List<ContentV2GetCardsListPost200ResponseCardsInnerPhotosInner> Photos { get; set; }

        /// <summary>
        /// URL видео
        /// </summary>
        /// <value>URL видео</value>
        [DataMember(Name = "video", EmitDefaultValue = false)]
        public string Video { get; set; }

        /// <summary>
        /// Массив размеров
        /// </summary>
        /// <value>Массив размеров</value>
        [DataMember(Name = "sizes", EmitDefaultValue = false)]
        public List<ContentV2GetCardsTrashPost200ResponseCardsInnerSizesInner> Sizes { get; set; }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "dimensions", EmitDefaultValue = false)]
        public ContentV2GetCardsTrashPost200ResponseCardsInnerDimensions Dimensions { get; set; }

        /// <summary>
        /// Массив характеристик, при наличии
        /// </summary>
        /// <value>Массив характеристик, при наличии</value>
        [DataMember(Name = "characteristics", EmitDefaultValue = false)]
        public List<ContentV2GetCardsTrashPost200ResponseCardsInnerCharacteristicsInner> Characteristics { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets TrashedAt
        /// </summary>
        [DataMember(Name = "trashedAt", EmitDefaultValue = false)]
        public string TrashedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentV2GetCardsTrashPost200ResponseCardsInner {\n");
            sb.Append("  NmID: ").Append(NmID).Append("\n");
            sb.Append("  VendorCode: ").Append(VendorCode).Append("\n");
            sb.Append("  SubjectID: ").Append(SubjectID).Append("\n");
            sb.Append("  SubjectName: ").Append(SubjectName).Append("\n");
            sb.Append("  Photos: ").Append(Photos).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  Sizes: ").Append(Sizes).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Characteristics: ").Append(Characteristics).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  TrashedAt: ").Append(TrashedAt).Append("\n");
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
