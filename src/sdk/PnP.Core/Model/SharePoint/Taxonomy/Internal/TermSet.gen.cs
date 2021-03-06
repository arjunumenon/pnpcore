﻿using System;
using System.Collections.Generic;

namespace PnP.Core.Model.SharePoint
{

    internal partial class TermSet : BaseDataModel<ITermSet>, ITermSet
    {
        public string Id { get => GetValue<string>(); set => SetValue(value); }

        public List<ITermSetLocalizedName> LocalizedNames
        {
            get
            {
                if (!HasValue(nameof(LocalizedNames)))
                {
                    SetValue(new List<ITermSetLocalizedName>());
                }
                return GetValue<List<ITermSetLocalizedName>>();
            }
        }

        public string Description { get => GetValue<string>(); set => SetValue(value); }

        public DateTimeOffset CreatedDateTime { get => GetValue<DateTimeOffset>(); set => SetValue(value); }

        [GraphProperty("children", Get = "termstore/sets/{GraphId}/children")]
        public ITermCollection Children
        {
            get
            {
                if (!HasValue(nameof(Children)))
                {
                    var children = new TermCollection(this.PnPContext, this, "Children");
                    SetValue(children);
                }
                return GetValue<ITermCollection>();
            }
        }

        [GraphProperty("parentGroup", Expandable = true)]
        public ITermGroup Group 
        {
            get
            {
                // Since we quite often have the group already as part of the termset collection let's use that 
                if (Parent != null && Parent.Parent != null)
                {
                    InstantiateNavigationProperty();
                    SetValue(Parent.Parent as TermGroup);
                    return GetValue<ITermGroup>();
                }

                // Seems there was no group available, so process the loaded group and assign it
                if (!NavigationPropertyInstantiated())
                {
                    var termGroup = new TermGroup
                    {
                        PnPContext = this.PnPContext,
                        Parent = this,
                    };
                    SetValue(termGroup);
                    InstantiateNavigationProperty();
                }
                return GetValue<ITermGroup>();
            }
            set
            {
                // Only set if there was no proper parent 
                if (Parent == null || Parent.Parent != null)
                {
                    InstantiateNavigationProperty();
                    SetValue(value);
                }
            }
        }

        [KeyProperty("Id")]
        public override object Key { get => this.Id; set => this.Id = value.ToString(); }
    }
}
