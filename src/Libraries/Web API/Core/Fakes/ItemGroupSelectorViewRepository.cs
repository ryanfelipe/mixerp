// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.EntityParser;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Core.Fakes
{
    public class ItemGroupSelectorViewRepository : IItemGroupSelectorViewRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemGroupSelectorView> Get()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemGroupSelectorView(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemGroupSelectorView> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemGroupSelectorView(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemGroupSelectorView> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemGroupSelectorView(), 1);
        }

        public IEnumerable<DisplayField> GetDisplayFields()
        {
            return Enumerable.Repeat(new DisplayField(), 1);
        }


        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemGroupSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemGroupSelectorView(), 1);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemGroupSelectorView> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemGroupSelectorView(), 1);
        }

    }
}