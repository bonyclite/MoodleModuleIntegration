using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using PersonnelSTU.Data.Infrastructure;
using PersonnelSTU.Data.Providers;

namespace PersonnelSTU.FakeDBUtilAPI.Providers
{
    public interface IFakeDbProvider : IDbProvider
    {
        void CreateFakeDb(IEnumerable<string> viewNames);
    }

    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class FakeDbProvider : IFakeDbProvider
    {
        public ISqlProvider SqlProvider { get; set; }

        public IReadOnlyCollection<string> GetViews()
        {
            return Enumerable.Range(0, 10).Select(i => Guid.NewGuid().ToString()).ToArray();
        }

        public void CreateFakeDb(IEnumerable<string> viewNames)
        {
        }

        private void CreateTable()
        {
        }
    }
}