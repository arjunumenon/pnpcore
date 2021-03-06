﻿using PnP.Core.Services;
using System;
using System.Threading.Tasks;

namespace PnP.Core.Model.SharePoint
{
    internal partial class TermCollection
    {
        public async Task<ITerm> AddAsync(string name, string description = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Term newTerm = await PrepNewTerm(name, description).ConfigureAwait(false);

            return await newTerm.AddAsync().ConfigureAwait(false) as Term;
        }

        private async Task<Term> PrepNewTerm(string name, string description)
        {
            // Ensure the default termstore language is loaded
            await PnPContext.TermStore.EnsurePropertiesAsync(p => p.DefaultLanguage).ConfigureAwait(false);

            var newTerm = CreateNewAndAdd() as Term;

            // Assign field values
            newTerm.Labels.Add(new TermLocalizedLabel() { Name = name, LanguageTag = PnPContext.TermStore.DefaultLanguage, IsDefault = true });

            if (description != null)
            {
                newTerm.Descriptions.Add(new TermLocalizedDescription() { Description = description, LanguageTag = PnPContext.TermStore.DefaultLanguage });
            }

            return newTerm;
        }

        public ITerm Add(string name, string description = null)
        {
            return AddAsync(name, description).GetAwaiter().GetResult();
        }

        public async Task<ITerm> AddBatchAsync(Batch batch, string name, string description = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Term newTerm = await PrepNewTerm(name, description).ConfigureAwait(false);

            return await newTerm.AddBatchAsync(batch).ConfigureAwait(false) as Term;
        }

        public ITerm AddBatch(Batch batch, string name, string description = null)
        {
            return AddBatchAsync(batch, name, description).GetAwaiter().GetResult();
        }

        public async Task<ITerm> AddBatchAsync(string name, string description = null)
        {
            return await AddBatchAsync(PnPContext.CurrentBatch, name, description).ConfigureAwait(false);
        }

        public ITerm AddBatch(string name, string description = null)
        {
            return AddBatchAsync(name, description).GetAwaiter().GetResult();
        }
    }
}
