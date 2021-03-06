﻿using System;
using System.Collections.Generic;

namespace PnP.Core.Model.SharePoint
{
    /// <summary>
    /// Represents the set used in a term store. The set represents a unit which contains a collection of hierarchical terms. A group can contain multiple sets.
    /// </summary>
    [ConcreteType(typeof(TermSet))]
    public interface ITermSet : IDataModel<ITermSet>, IDataModelUpdate, IDataModelDelete
    {
        /// <summary>
        /// The Unique ID of the term set.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Name of the term set for each language.
        /// </summary>
        public List<ITermSetLocalizedName> LocalizedNames { get; }

        /// <summary>
        /// Description giving details on the term set.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Date and time of term set creation. Read-only.
        /// </summary>
        public DateTimeOffset CreatedDateTime { get; }

        /// <summary>
        /// Collection of term in this term set
        /// </summary>
        public ITermCollection Children { get; }

        /// <summary>
        /// The parent group for this termset
        /// </summary>
        public ITermGroup Group { get; }
    }
}
