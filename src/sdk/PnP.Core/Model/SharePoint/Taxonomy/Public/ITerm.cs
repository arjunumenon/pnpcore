﻿using System;
using System.Collections.Generic;

namespace PnP.Core.Model.SharePoint
{
    /// <summary>
    /// Represents a term used in a term store. A term can be used to represent an object which can then be used as a metadata to tag conent. Multiple terms can be organized in a hierarchical manner within a set.
    /// </summary>
    [ConcreteType(typeof(Term))]
    public interface ITerm : IDataModel<ITerm>, IDataModelUpdate, IDataModelDelete
    {
        /// <summary>
        /// The Unique ID of the term.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Name of the term set for each language.
        /// </summary>
        public List<ITermLocalizedLabel> Labels { get; }

        /// <summary>
        /// Name of the term set for each language.
        /// </summary>
        public List<ITermLocalizedDescription> Descriptions { get; }

        /// <summary>
        /// Last date and time of term modification. Read-only.
        /// </summary>
        public DateTimeOffset LastModifiedDateTime { get; }

        /// <summary>
        /// Date and time of term set creation. Read-only.
        /// </summary>
        public DateTimeOffset CreatedDateTime { get; }

        /// <summary>
        /// The term set of this term
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "<Pending>")]
        public ITermSet Set { get; }

        /// <summary>
        /// Collection of child terms of this term
        /// </summary>
        public ITermCollection Children { get; }

        /// <summary>
        /// Adds a term label and optional description for a given language
        /// </summary>
        /// <param name="label">Label for the term</param>
        /// <param name="languageTag">Language tag for the label and description</param>
        /// <param name="isDefault">Will this be the default label?</param>
        /// <param name="description">Optional description to set</param>
        public void AddLabelAndDescription(string label, string languageTag, bool isDefault = false, string description = null);
    }
}
