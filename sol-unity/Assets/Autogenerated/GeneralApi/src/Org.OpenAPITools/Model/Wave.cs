/*
 * ITPM admin panel API
 *
 * Admin panel for Telegram chat bot, which will help to improve user interactions with the chats.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Wave
    /// </summary>
    [DataContract]
    public partial class Wave :  IEquatable<Wave>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wave" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Wave() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Wave" /> class.
        /// </summary>
        /// <param name="enemies">enemies (required).</param>
        /// <param name="delayTime">delayTime (required).</param>
        /// <param name="level">level (required).</param>
        public Wave(List<Enemy> enemies = default(List<Enemy>), int delayTime = default(int), int level = default(int))
        {
            // to ensure "enemies" is required (not null)
            if (enemies == null)
            {
                throw new InvalidDataException("enemies is a required property for Wave and cannot be null");
            }
            else
            {
                this.Enemies = enemies;
            }

            // to ensure "delayTime" is required (not null)
            if (delayTime == null)
            {
                throw new InvalidDataException("delayTime is a required property for Wave and cannot be null");
            }
            else
            {
                this.DelayTime = delayTime;
            }

            // to ensure "level" is required (not null)
            if (level == null)
            {
                throw new InvalidDataException("level is a required property for Wave and cannot be null");
            }
            else
            {
                this.Level = level;
            }

        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int Id { get; private set; }

        /// <summary>
        /// Gets or Sets Enemies
        /// </summary>
        [DataMember(Name="enemies", EmitDefaultValue=true)]
        public List<Enemy> Enemies { get; set; }

        /// <summary>
        /// Gets or Sets DelayTime
        /// </summary>
        [DataMember(Name="delay_time", EmitDefaultValue=true)]
        public int DelayTime { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=true)]
        public int Level { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Wave {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Enemies: ").Append(Enemies).Append("\n");
            sb.Append("  DelayTime: ").Append(DelayTime).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Wave);
        }

        /// <summary>
        /// Returns true if Wave instances are equal
        /// </summary>
        /// <param name="input">Instance of Wave to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Wave input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Enemies == input.Enemies ||
                    this.Enemies != null &&
                    input.Enemies != null &&
                    this.Enemies.SequenceEqual(input.Enemies)
                ) && 
                (
                    this.DelayTime == input.DelayTime ||
                    (this.DelayTime != null &&
                    this.DelayTime.Equals(input.DelayTime))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Enemies != null)
                    hashCode = hashCode * 59 + this.Enemies.GetHashCode();
                if (this.DelayTime != null)
                    hashCode = hashCode * 59 + this.DelayTime.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {


            // DelayTime (int) maximum
            if(this.DelayTime > (int)86400000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DelayTime, must be a value less than or equal to 86400000.", new [] { "DelayTime" });
            }

            // DelayTime (int) minimum
            if(this.DelayTime < (int)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DelayTime, must be a value greater than or equal to 1000.", new [] { "DelayTime" });
            }

            yield break;
        }
    }

}
