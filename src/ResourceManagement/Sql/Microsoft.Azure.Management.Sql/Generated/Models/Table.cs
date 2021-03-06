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
    /// Represents an Azure SQL Database table.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Table : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        public Table() { }

        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource Id</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="tableType">Gets the type of Azure SQL Database table.
        /// Possible values include: 'BaseTable', 'View'</param>
        /// <param name="columns">Gets the columns from this table.</param>
        /// <param name="recommendedIndexes">Gets the recommended indices for
        /// this table.</param>
        public Table(string location, string name = default(string), string id = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string tableType = default(string), System.Collections.Generic.IList<Column> columns = default(System.Collections.Generic.IList<Column>), System.Collections.Generic.IList<RecommendedIndex> recommendedIndexes = default(System.Collections.Generic.IList<RecommendedIndex>))
            : base(location, name, id, type, tags)
        {
            TableType = tableType;
            Columns = columns;
            RecommendedIndexes = recommendedIndexes;
        }

        /// <summary>
        /// Gets the type of Azure SQL Database table. Possible values
        /// include: 'BaseTable', 'View'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tableType")]
        public string TableType { get; private set; }

        /// <summary>
        /// Gets the columns from this table.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.columns")]
        public System.Collections.Generic.IList<Column> Columns { get; private set; }

        /// <summary>
        /// Gets the recommended indices for this table.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.recommendedIndexes")]
        public System.Collections.Generic.IList<RecommendedIndex> RecommendedIndexes { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.Columns != null)
            {
                foreach (var element in this.Columns)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.RecommendedIndexes != null)
            {
                foreach (var element1 in this.RecommendedIndexes)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
