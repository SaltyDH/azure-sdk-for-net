// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Represents an Azure SQL Database data masking rule.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class DataMaskingRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the DataMaskingRule class.
        /// </summary>
        public DataMaskingRule() { }

        /// <summary>
        /// Initializes a new instance of the DataMaskingRule class.
        /// </summary>
        /// <param name="dataMaskingRuleId">Gets or sets the rule Id.</param>
        /// <param name="ruleState">Gets or sets the rule state.</param>
        /// <param name="maskingFunction">Gets or sets the masking function
        /// that is used for the data masking rule.</param>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource Id</param>
        /// <param name="schemaName">Gets or sets the schema name on which the
        /// data masking rule is applied.</param>
        /// <param name="tableName">Gets or sets the table name on which the
        /// data masking rule is applied.</param>
        /// <param name="columnName">Gets or sets the column name on which the
        /// data masking rule is applied.</param>
        /// <param name="numberFrom">Gets or sets the numberFrom property of
        /// the masking rule.</param>
        /// <param name="numberTo">Gets or sets the numberTo property of the
        /// data masking rule.</param>
        /// <param name="prefixSize">Gets or sets the prefixSize property that
        /// is used for the data masking rule.</param>
        /// <param name="suffixSize">Gets or sets the suffixSize property that
        /// is used for the data masking rule.</param>
        /// <param name="replacementString">Gets or sets the replacementString
        /// property that is used for the data masking rule.</param>
        public DataMaskingRule(string dataMaskingRuleId, string ruleState, string maskingFunction, string name = default(string), string id = default(string), string schemaName = default(string), string tableName = default(string), string columnName = default(string), string numberFrom = default(string), string numberTo = default(string), string prefixSize = default(string), string suffixSize = default(string), string replacementString = default(string))
            : base(name, id)
        {
            DataMaskingRuleId = dataMaskingRuleId;
            RuleState = ruleState;
            SchemaName = schemaName;
            TableName = tableName;
            ColumnName = columnName;
            MaskingFunction = maskingFunction;
            NumberFrom = numberFrom;
            NumberTo = numberTo;
            PrefixSize = prefixSize;
            SuffixSize = suffixSize;
            ReplacementString = replacementString;
        }

        /// <summary>
        /// Gets or sets the rule Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.id")]
        public string DataMaskingRuleId { get; set; }

        /// <summary>
        /// Gets or sets the rule state.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.ruleState")]
        public string RuleState { get; set; }

        /// <summary>
        /// Gets or sets the schema name on which the data masking rule is
        /// applied.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Gets or sets the table name on which the data masking rule is
        /// applied.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tableName")]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the column name on which the data masking rule is
        /// applied.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.columnName")]
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets or sets the masking function that is used for the data
        /// masking rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.maskingFunction")]
        public string MaskingFunction { get; set; }

        /// <summary>
        /// Gets or sets the numberFrom property of the masking rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.numberFrom")]
        public string NumberFrom { get; set; }

        /// <summary>
        /// Gets or sets the numberTo property of the data masking rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.numberTo")]
        public string NumberTo { get; set; }

        /// <summary>
        /// Gets or sets the prefixSize property that is used for the data
        /// masking rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.prefixSize")]
        public string PrefixSize { get; set; }

        /// <summary>
        /// Gets or sets the suffixSize property that is used for the data
        /// masking rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.suffixSize")]
        public string SuffixSize { get; set; }

        /// <summary>
        /// Gets or sets the replacementString property that is used for the
        /// data masking rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.replacementString")]
        public string ReplacementString { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataMaskingRuleId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DataMaskingRuleId");
            }
            if (RuleState == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "RuleState");
            }
            if (MaskingFunction == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "MaskingFunction");
            }
        }
    }
}
