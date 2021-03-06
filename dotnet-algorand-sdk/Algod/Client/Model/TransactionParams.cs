/* 
 * Algod REST API.
 *
 * API Endpoint for AlgoD Operations.
 *
 * OpenAPI spec version: 0.0.1
 * Contact: contact@algorand.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Algorand.Algod.Client.SwaggerDateConverter;

namespace Algorand.Algod.Client.Model
{
    /// <summary>
    /// TransactionParams contains the parameters that help a client construct a new transaction.
    /// </summary>
    [DataContract]
        public partial class TransactionParams :  IEquatable<TransactionParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionParams" /> class.
        /// </summary>
        /// <param name="consensusVersion">ConsensusVersion indicates the consensus protocol version as of LastRound. (required).</param>
        /// <param name="fee">Fee is the suggested transaction fee Fee is in units of micro-Algos per byte. Fee may fall to zero but transactions must still have a fee of at least MinTxnFee for the current network protocol. (required).</param>
        /// <param name="genesisID">Genesis ID (required).</param>
        /// <param name="genesishashb64">Genesis hash (required).</param>
        /// <param name="lastRound">LastRound indicates the last round seen (required).</param>
        /// <param name="minFee">The minimum transaction fee (not per byte) required for the txn to validate for the current network protocol..</param>
        public TransactionParams(string consensusVersion = default(string), ulong? fee = default(ulong?), string genesisID = default(string), string genesishashb64 = default(string), ulong? lastRound = default(ulong?), ulong? minFee = default(ulong?))
        {
            // to ensure "consensusVersion" is required (not null)
            if (consensusVersion == null)
            {
                throw new InvalidDataException("consensusVersion is a required property for TransactionParams and cannot be null");
            }
            else
            {
                this.ConsensusVersion = consensusVersion;
            }
            // to ensure "fee" is required (not null)
            if (fee == null)
            {
                throw new InvalidDataException("fee is a required property for TransactionParams and cannot be null");
            }
            else
            {
                this.Fee = fee;
            }
            // to ensure "genesisID" is required (not null)
            if (genesisID == null)
            {
                throw new InvalidDataException("genesisID is a required property for TransactionParams and cannot be null");
            }
            else
            {
                this.GenesisID = genesisID;
            }
            // to ensure "genesishashb64" is required (not null)
            if (genesishashb64 == null)
            {
                throw new InvalidDataException("genesishashb64 is a required property for TransactionParams and cannot be null");
            }
            else
            {
                this.Genesishashb64 = genesishashb64;
            }
            // to ensure "lastRound" is required (not null)
            if (lastRound == null)
            {
                throw new InvalidDataException("lastRound is a required property for TransactionParams and cannot be null");
            }
            else
            {
                this.LastRound = lastRound;
            }
            this.MinFee = minFee;
        }
        
        /// <summary>
        /// ConsensusVersion indicates the consensus protocol version as of LastRound.
        /// </summary>
        /// <value>ConsensusVersion indicates the consensus protocol version as of LastRound.</value>
        [DataMember(Name="consensusVersion", EmitDefaultValue=false)]
        public string ConsensusVersion { get; set; }

        /// <summary>
        /// Fee is the suggested transaction fee Fee is in units of micro-Algos per byte. Fee may fall to zero but transactions must still have a fee of at least MinTxnFee for the current network protocol.
        /// </summary>
        /// <value>Fee is the suggested transaction fee Fee is in units of micro-Algos per byte. Fee may fall to zero but transactions must still have a fee of at least MinTxnFee for the current network protocol.</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public ulong? Fee { get; set; }

        /// <summary>
        /// Genesis ID
        /// </summary>
        /// <value>Genesis ID</value>
        [DataMember(Name="genesisID", EmitDefaultValue=false)]
        public string GenesisID { get; set; }

        /// <summary>
        /// Genesis hash
        /// </summary>
        /// <value>Genesis hash</value>
        [DataMember(Name="genesishashb64", EmitDefaultValue=false)]
        public string Genesishashb64 { get; set; }

        /// <summary>
        /// LastRound indicates the last round seen
        /// </summary>
        /// <value>LastRound indicates the last round seen</value>
        [DataMember(Name="lastRound", EmitDefaultValue=false)]
        public ulong? LastRound { get; set; }

        /// <summary>
        /// The minimum transaction fee (not per byte) required for the txn to validate for the current network protocol.
        /// </summary>
        /// <value>The minimum transaction fee (not per byte) required for the txn to validate for the current network protocol.</value>
        [DataMember(Name="minFee", EmitDefaultValue=false)]
        public ulong? MinFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionParams {\n");
            sb.Append("  ConsensusVersion: ").Append(ConsensusVersion).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  GenesisID: ").Append(GenesisID).Append("\n");
            sb.Append("  Genesishashb64: ").Append(Genesishashb64).Append("\n");
            sb.Append("  LastRound: ").Append(LastRound).Append("\n");
            sb.Append("  MinFee: ").Append(MinFee).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransactionParams);
        }

        /// <summary>
        /// Returns true if TransactionParams instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsensusVersion == input.ConsensusVersion ||
                    (this.ConsensusVersion != null &&
                    this.ConsensusVersion.Equals(input.ConsensusVersion))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.GenesisID == input.GenesisID ||
                    (this.GenesisID != null &&
                    this.GenesisID.Equals(input.GenesisID))
                ) && 
                (
                    this.Genesishashb64 == input.Genesishashb64 ||
                    (this.Genesishashb64 != null &&
                    this.Genesishashb64.Equals(input.Genesishashb64))
                ) && 
                (
                    this.LastRound == input.LastRound ||
                    (this.LastRound != null &&
                    this.LastRound.Equals(input.LastRound))
                ) && 
                (
                    this.MinFee == input.MinFee ||
                    (this.MinFee != null &&
                    this.MinFee.Equals(input.MinFee))
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
                if (this.ConsensusVersion != null)
                    hashCode = hashCode * 59 + this.ConsensusVersion.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.GenesisID != null)
                    hashCode = hashCode * 59 + this.GenesisID.GetHashCode();
                if (this.Genesishashb64 != null)
                    hashCode = hashCode * 59 + this.Genesishashb64.GetHashCode();
                if (this.LastRound != null)
                    hashCode = hashCode * 59 + this.LastRound.GetHashCode();
                if (this.MinFee != null)
                    hashCode = hashCode * 59 + this.MinFee.GetHashCode();
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
            yield break;
        }
    }
}
