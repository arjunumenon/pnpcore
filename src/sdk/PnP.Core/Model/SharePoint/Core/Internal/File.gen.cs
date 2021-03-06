using System;

namespace PnP.Core.Model.SharePoint
{
    /// <summary>
    /// Internal class representing a File object
    /// 
    /// Note: this class is generated, please don't modify this code by hand!
    /// 
    /// </summary>
    internal partial class File : BaseDataModel<IFile>, IFile
    {
        public string CheckInComment { get => GetValue<string>(); set => SetValue(value); }

        public CheckOutType CheckOutType { get => GetValue<CheckOutType>(); set => SetValue(value); }

        public string ContentTag { get => GetValue<string>(); set => SetValue(value); }

        public CustomizedPageStatus CustomizedPageStatus { get => GetValue<CustomizedPageStatus>(); set => SetValue(value); }

        public Guid ListId { get => GetValue<Guid>(); set => SetValue(value); }

        public string ETag { get => GetValue<string>(); set => SetValue(value); }

        public bool Exists { get => GetValue<bool>(); set => SetValue(value); }

        public bool IrmEnabled { get => GetValue<bool>(); set => SetValue(value); }

        public string LinkingUri { get => GetValue<string>(); set => SetValue(value); }

        public string LinkingUrl { get => GetValue<string>(); set => SetValue(value); }

        public int MajorVersion { get => GetValue<int>(); set => SetValue(value); }

        public int MinorVersion { get => GetValue<int>(); set => SetValue(value); }

        public string Name { get => GetValue<string>(); set => SetValue(value); }

        public ListPageRenderType PageRenderType { get => GetValue<ListPageRenderType>(); set => SetValue(value); }

        public string ServerRelativeUrl { get => GetValue<string>(); set => SetValue(value); }

        public Guid SiteId { get => GetValue<Guid>(); set => SetValue(value); }

        public DateTime TimeCreated { get => GetValue<DateTime>(); set => SetValue(value); }

        public DateTime TimeLastModified { get => GetValue<DateTime>(); set => SetValue(value); }

        public string Title { get => GetValue<string>(); set => SetValue(value); }

        public int UIVersion { get => GetValue<int>(); set => SetValue(value); }

        public string UIVersionLabel { get => GetValue<string>(); set => SetValue(value); }

        public Guid UniqueId { get => GetValue<Guid>(); set => SetValue(value); }

        public Guid WebId { get => GetValue<Guid>(); set => SetValue(value); }

        public IListItem ListItemAllFields
        {
            get
            {
                if (!NavigationPropertyInstantiated())
                {
                    var propertyValue = new ListItem
                    {
                        PnPContext = this.PnPContext,
                        Parent = this,
                    };
                    SetValue(propertyValue);
                    InstantiateNavigationProperty();
                }
                return GetValue<IListItem>();
            }
            set
            {
                InstantiateNavigationProperty();
                SetValue(value);
            }
        }


        #region Not Implemented yet
        //public IUser Author
        //{
        //    get
        //    {
        //        if (!NavigationPropertyInstantiated())
        //        {
        //            var propertyValue = new User
        //            {
        //                PnPContext = this.PnPContext,
        //                Parent = this,
        //            };
        //            SetValue(propertyValue);
        //            InstantiateNavigationProperty();
        //        }
        //        return GetValue<IUser>();
        //    }
        //    set
        //    {
        //        InstantiateNavigationProperty();
        //        SetValue(value);                
        //    }
        //}

        //public IUser CheckedOutByUser
        //{
        //    get
        //    {
        //        if (!NavigationPropertyInstantiated())
        //        {
        //            var propertyValue = new User
        //            {
        //                PnPContext = this.PnPContext,
        //                Parent = this,
        //            };
        //            SetValue(propertyValue);
        //            InstantiateNavigationProperty();
        //        }
        //        return GetValue<IUser>();
        //    }
        //    set
        //    {
        //        InstantiateNavigationProperty();
        //        SetValue(value);                
        //    }
        //}

        //public IEffectiveInformationRightsManagementSettings EffectiveInformationRightsManagementSettings
        //{
        //    get
        //    {
        //        if (!NavigationPropertyInstantiated())
        //        {
        //            var propertyValue = new EffectiveInformationRightsManagementSettings
        //            {
        //                PnPContext = this.PnPContext,
        //                Parent = this,
        //            };
        //            SetValue(propertyValue);
        //            InstantiateNavigationProperty();
        //        }
        //        return GetValue<IEffectiveInformationRightsManagementSettings>();
        //    }
        //    set
        //    {
        //        InstantiateNavigationProperty();
        //        SetValue(value);                
        //    }
        //}

        //public IInformationRightsManagementFileSettings InformationRightsManagementSettings
        //{
        //    get
        //    {
        //        if (!NavigationPropertyInstantiated())
        //        {
        //            var propertyValue = new InformationRightsManagementFileSettings
        //            {
        //                PnPContext = this.PnPContext,
        //                Parent = this,
        //            };
        //            SetValue(propertyValue);
        //            InstantiateNavigationProperty();
        //        }
        //        return GetValue<IInformationRightsManagementFileSettings>();
        //    }
        //    set
        //    {
        //        InstantiateNavigationProperty();
        //        SetValue(value);                
        //    }
        //}

        //public IUser LockedByUser
        //{
        //    get
        //    {
        //        if (!NavigationPropertyInstantiated())
        //        {
        //            var propertyValue = new User
        //            {
        //                PnPContext = this.PnPContext,
        //                Parent = this,
        //            };
        //            SetValue(propertyValue);
        //            InstantiateNavigationProperty();
        //        }
        //        return GetValue<IUser>();
        //    }
        //    set
        //    {
        //        InstantiateNavigationProperty();
        //        SetValue(value);                
        //    }
        //}

        //public IUser ModifiedBy
        //{
        //    get
        //    {
        //        if (!NavigationPropertyInstantiated())
        //        {
        //            var propertyValue = new User
        //            {
        //                PnPContext = this.PnPContext,
        //                Parent = this,
        //            };
        //            SetValue(propertyValue);
        //            InstantiateNavigationProperty();
        //        }
        //        return GetValue<IUser>();
        //    }
        //    set
        //    {
        //        InstantiateNavigationProperty();
        //        SetValue(value);                
        //    }
        //}

        //public IPropertyValues Properties
        //{
        //    get
        //    {
        //        if (!NavigationPropertyInstantiated())
        //        {
        //            var propertyValue = new PropertyValues
        //            {
        //                PnPContext = this.PnPContext,
        //                Parent = this,
        //            };
        //            SetValue(propertyValue);
        //            InstantiateNavigationProperty();
        //        }
        //        return GetValue<IPropertyValues>();
        //    }
        //    set
        //    {
        //        InstantiateNavigationProperty();
        //        SetValue(value);                
        //    }
        //}

        //[SharePointProperty("VersionEvents", Expandable = true)]
        //public IFileVersionEventCollection VersionEvents
        //{
        //    get
        //    {
        //        if (!HasValue(nameof(VersionEvents)))
        //        {
        //            var collection = new FileVersionEventCollection(this.PnPContext, this, nameof(VersionEvents));
        //            SetValue(collection);
        //        }
        //        return GetValue<IFileVersionEventCollection>();
        //    }
        //}

        //[SharePointProperty("Versions", Expandable = true)]
        //public IFileVersionCollection Versions
        //{
        //    get
        //    {
        //        if (!HasValue(nameof(Versions)))
        //        {
        //            var collection = new FileVersionCollection(this.PnPContext, this, nameof(Versions));
        //            SetValue(collection);
        //        }
        //        return GetValue<IFileVersionCollection>();
        //    }
        //}
        #endregion

        [KeyProperty("UniqueId")]
        public override object Key { get => this.UniqueId; set => this.UniqueId = Guid.Parse(value.ToString()); }
    }
}
